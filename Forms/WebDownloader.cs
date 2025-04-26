using PCessentials.assets.WebDownloader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCessentials.Forms
{
    public partial class WebDownloader : Form
    {
        private string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PCessentials\\WebDownloader";

        private readonly WDownloader _downloader;

        public WebDownloader()
        {
            InitializeComponent();
            _downloader = new WDownloader(Path);

            // Events abonnieren
            _downloader.ProgressChanged += Downloader_ProgressChanged;
            _downloader.StatusChanged += Downloader_StatusChanged;

            this.GetSavedPath();
            this.FillComboPlattform();
            //Elemente verstecken die noch nicht benötigt werden
            lbl_WD_Plattform_ERROR.Hide();
            lbl_WD_URL_ERROR.Hide();
            lbl_WD_prgs.Text = "Status: Bereit";
            progressBarDownload.Show();


        }

        #region  Logic Methods
            #region Getters and Setters

        /// <summary>
        /// This Method Updates the Path for the Downloader
        /// </summary>
        /// <param name="Path"></param>
        public void SetPath(string Path)
        {
            if (CheckPath(Path))
            {
                Properties.Settings.Default.WD_SavePath = Path;
                Properties.Settings.Default.Save();
                this.Path = Path;
                this.txtBox_WD_Path.Text = Path;
                if (_downloader != null) _downloader.SetPath(Path);
                this.lbl_WD_CurrentPath.Text = "Current Path: " + Path;
            }
            else
            {
                DisplayMessage("Der Pfad ist ungültig");
            }
        }

        public string GetPath(){ return this.Path; }

            #endregion

        /// <summary>
        /// This Method Checks if the Path is Valid
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        private bool CheckPath(string Path)
        {
            bool pathValid = true;
            if (Path == "")
            {
                DisplayMessage("Bitte einen Pfad angeben");
                pathValid = false;
            }
            else
            {
                //TODO: Check if the Path is Valid
                pathValid = true;
            }
            return pathValid;
        }
        private void FillComboPlattform()
        {
            cbox_WD_Plattform.Items.Clear();
            cbox_WD_Plattform.Items.AddRange(new[] { "Bitte Waehlen", "YouTube", "Twitter", "Instagram", "Reddit", "TikTok","Vimeo", "Phub" });
            cbox_WD_Plattform.SelectedIndex = 0;
        }

        /// <summary>
        /// Gets the Path from the Settings if it exists
        /// </summary>
        private void GetSavedPath()
        {
            string path = Properties.Settings.Default.WD_SavePath;
            Debug.WriteLine("Saved Path:" + path);
            if (path != "NotSet" )
            {
                SetPath(path);
            }
            else
            {
                this.Path = path;
            }
        }

        private void UpdateJobList()
        {
            try
            {
                lBox_WD_Auftraege.Items.Clear();
                IReadOnlyList<DownloadAuftrag> list = _downloader.GetDownloadAuftraege();
                foreach (DownloadAuftrag l in list)
                {
                    lBox_WD_Auftraege.Items.Add(l.Url);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Adds a DownloadAuftrag to the List
        /// </summary>
        private void AddAuftrag()
        {
            // INIT Variables
            string url = txt_WD_URL.Text;
            string plattform = cbox_WD_Plattform.SelectedItem.ToString();
            bool onlyAudio = cBox_WD_Content_Audio.Checked;

            // Check if the URL is valid
            if (url == "" || url == null)
            {
                DisplayMessage("Bitte eine URL angeben");
                return;
            }
            // Check if the Plattform is valid
            if (plattform == "" || plattform == "Bitte Waehlen")
            {
                DisplayMessage("Bitte eine Plattform angeben");
                return;
            }
            // Add the Auftrag to the List
            bool opSuccess = _downloader.AddDownloadAuftrag(url, plattform, onlyAudio);
            if (opSuccess)
            {
                DisplayMessage("Der Auftrag wurde hinzugefügt");
                txt_WD_URL.Text = "";
                cbox_WD_Plattform.SelectedIndex = 0;
                cBox_WD_Content_Audio.Checked = false;
            }
            else
            {
                DisplayMessage("Der Auftrag konnte nicht hinzugefügt werden");
            }
            UpdateJobList();
        }

        /// <summary>
        /// Starts the Download Queue
        /// </summary>
        private void StartDownload()
        {
            lbl_WD_prgs.Show();
            progressBarDownload.Show();

            btn_WD_AddAuftrag.Enabled = false;
            btn_WD_clearDownloadJobs.Enabled = false;
            btn_WD_StartDownload.Enabled = false;
            _downloader.StartDownload();

            btn_WD_AddAuftrag.Enabled = true;
            btn_WD_clearDownloadJobs.Enabled = true;
            btn_WD_StartDownload.Enabled = true;
        }

        /// <summary>
        /// Creates a PopUp Message
        /// </summary>
        /// <param name="Msg"></param>
        private void DisplayMessage(string Msg)
        {
            MessageBox.Show(Msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void Downloader_ProgressChanged(DownloadAuftrag job, double progressFraction)
        {
            // progressFraction ist 0.0–1.0, wir brauchen 0–100
            int percent = (int)(progressFraction * 100);

            // Da Events möglicherweise auf Background-Threads feuern, per Invoke auf UI-Thread
            if (progressBarDownload.InvokeRequired)
            {
                progressBarDownload.Invoke((Action)(() =>
                {
                    progressBarDownload.Value = Math.Min(Math.Max(percent, 0), 100);
                    if (progressBarDownload.Value > 75)
                    {
                        // Wenn der Fortschritt über 70% liegt, auf 100 setzen
                        // da die sonst stehen bleibt
                        progressBarDownload.Value = 100;
                    }
                }));
            }
            else
            {
                progressBarDownload.Value = Math.Min(Math.Max(percent, 0), 100);
            }


        }

        private void Downloader_StatusChanged(DownloadAuftrag job, string message)
        {
            // Status-Label aktualisieren
            if (lbl_WD_prgs.InvokeRequired)
            {
                lbl_WD_prgs.Invoke((Action)(() =>
                {
                    lbl_WD_prgs.Text = message;
                }));
            }
            else
            {
                lbl_WD_prgs.Text = message;
            }
            // Job-Status aktualisieren
            UpdateJobList();
        }

        #region Event Handlers
        private void WebDownloader_Load(object sender, EventArgs e)
        {

        }

        private void btn_WD_UpdatePath_Click(object sender, EventArgs e)
        {
            //Open the FolderBrowserDialog to select a new Path
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Waehlen Sie einen Zielordner aus";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //VALIDATE THE PATH
                    if (CheckPath(dlg.SelectedPath))
                    {
                        txtBox_WD_Path.Text = dlg.SelectedPath;
                        SetPath(dlg.SelectedPath);
                        DisplayMessage("Der Pfad wurde aktualisiert");
                    }
                    else
                    {
                        DisplayMessage("Der Pfad ist ungültig");
                    }
                }
            }
        }

        private void btn_WD_AddAuftrag_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Adding Auftrag");
            //Adding the DownloadAuftrag
            this.AddAuftrag();
        }

        private void btn_WD_StartDownload_Click(object sender, EventArgs e)
        {
            UpdateJobList();

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Moechten Sie den Download starten?", "Download starten", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Start the Download
                if (_downloader.GetListLength() < 1)
                {
                    DisplayMessage("Bitte einen Auftrag setzen");
                    return;
                }
                else
                {
                    Debug.WriteLine("Der Download wird gestartet");
                    this.StartDownload();
                }
            }
            else
            {
                //Cancel the Download
                Debug.WriteLine("Der Download wurde abgebrochen");
            }
        }

        private void btn_WD_clearDownloadJobs_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clearing Download Jobliste");
        }

        #endregion
    }
}
