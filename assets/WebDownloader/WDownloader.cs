// Required NuGet packages:
// - Xabe.FFmpeg (Install-Package Xabe.FFmpeg)
// - YoutubeExplode   (Install-Package YoutubeExplode)
// External tool: yt-dlp.exe
//   - Add yt-dlp.exe to your project (e.g., in a 'Tools' folder)
//   - In its file properties, set Build Action = Content and Copy to Output Directory = Copy Always

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Downloader;

namespace PCessentials.assets.WebDownloader
{
    /// <summary>
    /// Represents a download job/task.
    /// </summary>
    public class DownloadAuftrag
    {
        public string Plattform { get; }
        public string Url { get; }
        public bool OnlyAudio { get; }

        public DownloadAuftrag(string url, string plattform, bool onlyAudio = false)
        {
            Url = url;
            Plattform = plattform;
            OnlyAudio = onlyAudio;
        }
    }

    /// <summary>
    /// Downloads videos (or audio) from different platforms.
    /// </summary>
    public class WDownloader
    {
        private string path;
        private readonly List<DownloadAuftrag> jobs;

        // Events for progress and status updates (auftrag, value or message)
        public event Action<DownloadAuftrag, double> ProgressChanged;
        public event Action<DownloadAuftrag, string> StatusChanged;

        #region SmallMethods
        public int GetListLength() => jobs.Count;
        public void SetPath(string p) => this.path = p;
        public string GetPath() => this.path;
        #endregion

        static WDownloader()
        {
            // Initialize FFmpeg binaries once
            _ = InitializeFFmpegAsync();
        }

        public WDownloader(string downloadPath)
        {
            path = downloadPath;
            jobs = new List<DownloadAuftrag>();
        }

        /// <summary>
        /// Setup FFmpeg executables.
        /// </summary>
        private static async Task InitializeFFmpegAsync()
        {
            var ffmpegDir = Path.Combine(Application.StartupPath, "ffmpeg");
            await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Official, ffmpegDir);
            FFmpeg.SetExecutablesPath(ffmpegDir);
        }

        /// <summary>
        /// Adds a new download job.
        /// </summary>
        public bool AddDownloadAuftrag(string url, string plattform, bool onlyAudio = false)
        {
            try
            {
                var job = new DownloadAuftrag(url, plattform, onlyAudio);
                jobs.Add(job);
                StatusChanged?.Invoke(job, "Added to queue");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error adding job: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Returns the current list of jobs (read-only).
        /// </summary>
        public IReadOnlyList<DownloadAuftrag> GetDownloadAuftraege() => jobs.AsReadOnly();

        /// <summary>
        /// Starts all queued downloads asynchronously.
        /// </summary>
        public void StartDownload()
        {
            _ = DownloadAllAsync();
        }

        private async Task DownloadAllAsync()
        {
            var jobsCopy = jobs.ToList(); // Kopie der Liste erstellen
            foreach (var job in jobsCopy)
            {
                StatusChanged?.Invoke(job, "Starting download");
                Debug.WriteLine($"Starting download for {job.Url} {job.Plattform} {job.OnlyAudio.ToString()}");
                switch (job.Plattform.ToLowerInvariant())
                {
                    case "youtube":
                        await DownloadYouTubeAsync(job);
                        break;
                    case "twitter":
                        await DownloadTwitterAsync(job);
                        break;
                    case "instagram":
                        await DownloadInstagramAsync(job);
                        break;
                    case "tiktok":
                        await DownloadTikTokAsync(job);
                        break;
                    case "vimeo":
                        await DownloadVimeoAsync(job);
                        break;
                    default:
                        StatusChanged?.Invoke(job, $"Platform '{job.Plattform}' not implemented.");
                        break;
                }
                // Remove the job from the original list after completion
                StatusChanged?.Invoke(job, "Download completed");
                jobs.Remove(job);
            }
        }

        /// <summary>
        /// Handles YouTube downloads (video + merge, or audio only).
        /// </summary>
        private async Task DownloadYouTubeAsync(DownloadAuftrag job)
        {
            try
            {
                var yt = new YoutubeClient();
                var video = await yt.Videos.GetAsync(job.Url);
                var title = string.Join("_", video.Title.Split(Path.GetInvalidFileNameChars()));
                var manifest = await yt.Videos.Streams.GetManifestAsync(video.Id);

                if (job.OnlyAudio)
                {
                    // Download only audio stream
                    var audioStream = manifest.GetAudioOnlyStreams()
                                              .OrderByDescending(s => s.Bitrate)
                                              .FirstOrDefault();

                    if (audioStream == null)
                        throw new InvalidOperationException("Kein geeigneter Audiostream gefunden.");

                    var audioPath = Path.Combine(path, $"{title}.{audioStream.Container}");
                    var mp3Path = Path.Combine(path, $"{title}.mp3");

                    // Download audio with progress
                    var audioProgress = new Progress<double>(p => ProgressChanged?.Invoke(job, p));
                    await yt.Videos.Streams.DownloadAsync(audioStream, audioPath, audioProgress);
                    StatusChanged?.Invoke(job, "Audio downloaded, converting to MP3...");

                    // Convert to MP3
                    var conversion = FFmpeg.Conversions.New()
                        .AddParameter($"-i \"{audioPath}\" -vn", ParameterPosition.PreInput)
                        .AddParameter("-c:a libmp3lame -q:a 2")
                        .SetOutput(mp3Path);

                    conversion.OnProgress += (s, e) => ProgressChanged?.Invoke(job, e.Percent / 100.0);
                    await conversion.Start();

                    File.Delete(audioPath);
                    StatusChanged?.Invoke(job, $"Audio saved: {mp3Path}");
                }
                else
                {
                    // Download video + audio and merge
                    var videoStream = manifest.GetVideoStreams()
                                               .OrderByDescending(s => s.VideoQuality)
                                               .FirstOrDefault();
                    var audioStream = manifest.GetAudioStreams().OrderByDescending(s => s.Bitrate)
                                               .FirstOrDefault();

                    if (videoStream == null || audioStream == null)
                        throw new InvalidOperationException("Kein geeigneter Video- oder Audiostream gefunden.");

                    var videoPath = Path.Combine(path, $"{title}_video.{videoStream.Container}");
                    var audioPath = Path.Combine(path, $"{title}_audio.{audioStream.Container}");
                    var outputPath = Path.Combine(path, $"{title}.mp4");

                    // Download with progress
                    var vidProg = new Progress<double>(p => ProgressChanged?.Invoke(job, p * 0.4));
                    var audProg = new Progress<double>(p => ProgressChanged?.Invoke(job, 0.4 + p * 0.4));

                    await yt.Videos.Streams.DownloadAsync(videoStream, videoPath, vidProg);
                    StatusChanged?.Invoke(job, "Video downloaded");

                    await yt.Videos.Streams.DownloadAsync(audioStream, audioPath, audProg);
                    StatusChanged?.Invoke(job, "Audio downloaded, merging...");

                    // Merge streams
                    var conversion = FFmpeg.Conversions.New()
                        .AddParameter($"-i \"{videoPath}\"", ParameterPosition.PreInput)
                        .AddParameter($"-i \"{audioPath}\"", ParameterPosition.PreInput)
                        .AddParameter("-c:v copy -c:a aac")
                        .SetOutput(outputPath);

                    conversion.OnProgress += (s, e) => ProgressChanged?.Invoke(job, 0.8 + e.Percent / 100.0 * 0.2);
                    await conversion.Start();

                    File.Delete(videoPath);
                    File.Delete(audioPath);
                    StatusChanged?.Invoke(job, $"Video saved: {outputPath}");
                }
            }
            catch (Exception ex)
            {
                StatusChanged?.Invoke(job, $"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Downloads Twitter video/audio using yt-dlp.
        /// </summary>
        private async Task DownloadTwitterAsync(DownloadAuftrag job)
        {
            var ytDlpPath = Path.Combine(Application.StartupPath, "yt-dlp.exe");
            if (!File.Exists(ytDlpPath))
            {
                StatusChanged?.Invoke(job, "Error: yt-dlp.exe not found.");
                return;
            }

            var tweetId = new Uri(job.Url).Segments.Last().Split('?').First();
            var outputTemplate = Path.Combine(path, tweetId + ".%(ext)s");

            // Build arguments with correctly escaped quotes
            var args = job.OnlyAudio
            ? $"{job.Url} -x --audio-format mp3 -o \"{outputTemplate}\""
            : $"{job.Url} -f bestvideo+bestaudio --merge-output-format mp4 -o \"{outputTemplate}\"";


            var psi = new ProcessStartInfo
            {
                FileName = ytDlpPath,
                Arguments = args,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = new Process { StartInfo = psi, EnableRaisingEvents = true };
            var tcs = new TaskCompletionSource<bool>();

            process.ErrorDataReceived += (s, e) => ParseYtDlpOutput(job, e.Data);
            process.OutputDataReceived += (s, e) => ParseYtDlpOutput(job, e.Data);
            process.Exited += (s, e) => tcs.TrySetResult(true);

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();

            await tcs.Task;

            var ext = job.OnlyAudio ? "mp3" : "mp4";
            var filePath = Path.Combine(path, tweetId + $".{ext}");
            StatusChanged?.Invoke(job, $"Saved: {filePath}");
        }

        /// <summary>
        /// Downloads TikTok video/audio using yt-dlp.
        /// </summary>
        private async Task DownloadTikTokAsync(DownloadAuftrag job)
        {
            await DownloadGenericWithYtDlp(job);
        }

        /// <summary>
        /// Downloads Vimeo video/audio using yt-dlp.
        /// </summary>
        private async Task DownloadVimeoAsync(DownloadAuftrag job)
        {
            await DownloadGenericWithYtDlp(job);
        }

        /// <summary>
        /// Generic download logic via yt-dlp for platforms supported by yt-dlp.
        /// </summary>
        private async Task DownloadGenericWithYtDlp(DownloadAuftrag job)
        {
            var ytDlpPath = Path.Combine(Application.StartupPath, "yt-dlp.exe");
            if (!File.Exists(ytDlpPath))
            {
                StatusChanged?.Invoke(job, "Error: yt-dlp.exe not found.");
                return;
            }

            // Use sanitized URL as identifier
            var identifier = Regex.Replace(job.Url, "[^a-zA-Z0-9]", "_");
            var outputTemplate = Path.Combine(path, identifier + ".%(ext)s");

            var args = job.OnlyAudio
                ? $"{job.Url} -x --audio-format mp3 -o \"{outputTemplate}\""
                : $"{job.Url} -f bestvideo+bestaudio --merge-output-format mp4 -o \"{outputTemplate}\"";

            var psi = new ProcessStartInfo
            {
                FileName = ytDlpPath,
                Arguments = args,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = new Process { StartInfo = psi, EnableRaisingEvents = true };
            var tcs = new TaskCompletionSource<bool>();

            process.OutputDataReceived += (s, e) => ParseYtDlpOutput(job, e.Data);
            process.ErrorDataReceived += (s, e) => ParseYtDlpOutput(job, e.Data);
            process.Exited += (s, e) => tcs.TrySetResult(true);

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await tcs.Task;

            var ext = job.OnlyAudio ? "mp3" : "mp4";
            var filePath = Path.Combine(path, identifier + $".{ext}");
            StatusChanged?.Invoke(job, $"Saved: {filePath}");
        }


        /// <summary>
        /// Downloads Instagram video/audio using yt-dlp.
        /// </summary>
        private async Task DownloadInstagramAsync(DownloadAuftrag job)
        {
            var ytDlpPath = Path.Combine(Application.StartupPath, "yt-dlp.exe");
            if (!File.Exists(ytDlpPath))
            {
                StatusChanged?.Invoke(job, "Error: yt-dlp.exe not found.");
                return;
            }

            // Der Instagram-URL kann Post, Reels oder IGTV sein.
            // Wir verwenden den kompletten URL als Schlüssel.
            var identifier = Regex.Replace(job.Url, @"[^a-zA-Z0-9]", "_");
            var outputTemplate = Path.Combine(path, identifier + ".%(ext)s");

            // Build arguments
            var args = job.OnlyAudio
                ? $"{job.Url} -x --audio-format mp3 -o \"{outputTemplate}\""
                : $"{job.Url} -f bestvideo+bestaudio --merge-output-format mp4 -o \"{outputTemplate}\"";

            var psi = new ProcessStartInfo
            {
                FileName = ytDlpPath,
                Arguments = args,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = new Process { StartInfo = psi, EnableRaisingEvents = true };
            var tcs = new TaskCompletionSource<bool>();

            process.OutputDataReceived += (s, e) => ParseYtDlpOutput(job, e.Data);
            process.ErrorDataReceived += (s, e) => ParseYtDlpOutput(job, e.Data);
            process.Exited += (s, e) => tcs.TrySetResult(true);

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await tcs.Task;

            var ext = job.OnlyAudio ? "mp3" : "mp4";
            var filePath = Path.Combine(path, identifier + $".{ext}");
            StatusChanged?.Invoke(job, $"Saved: {filePath}");
        }

        /// <summary>
        /// Parses yt-dlp output lines for progress updates.
        /// </summary>
        private void ParseYtDlpOutput(DownloadAuftrag job, string line)
        {
            if (string.IsNullOrEmpty(line)) return;

            var match = Regex.Match(line, "\\s(\\d{1,3}\\.\\d)%");
            if (match.Success && double.TryParse(match.Groups[1].Value, out var pct))
            {
                ProgressChanged?.Invoke(job, pct / 100.0);
            }
            else
            {
                StatusChanged?.Invoke(job, line);
            }
        }
    }
}
