using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PCessentials.assets.PrintManager
{
    using System;
    using System.Collections.Generic;
    using System.Drawing.Printing;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class PrintJob
    {
        public string FilePath { get; set; }
        public string PrinterName { get; set; }
        public bool Duplex { get; set; }
        public bool Grayscale { get; set; }
        public bool Landscape { get; set; }
        public PaperSize PaperSize { get; set; }

        public string Status { get; set; } = "Wartend";
    }

    public class PManager
    {
        private Queue<PrintJob> printQueue = new Queue<PrintJob>();
        private CancellationTokenSource cts;
        public event Action<PrintJob> OnJobStarted;
        public event Action<PrintJob> OnJobFinished;
        public event Action<PrintJob, string> OnStatusUpdate;

        public List<string> GetInstalledPrinters()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }

        public void AddPrintJob(PrintJob job)
        {
            lock (printQueue)
            {
                printQueue.Enqueue(job);
            }
        }

        public void StartProcessing()
        {
            if (cts != null) return; // Already running

            cts = new CancellationTokenSource();
            Task.Run(() => ProcessQueue(cts.Token));
        }

        public void StopProcessing()
        {
            cts?.Cancel();
            cts = null;
        }

        private void ProcessQueue(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                PrintJob job = null;
                lock (printQueue)
                {
                    if (printQueue.Count > 0)
                        job = printQueue.Dequeue();
                }

                if (job != null)
                {
                    job.Status = "In Bearbeitung";
                    OnJobStarted?.Invoke(job);
                    OnStatusUpdate?.Invoke(job, "Starte Druckvorgang...");

                    try
                    {
                        Print(job);
                        job.Status = "Fertig";
                    }
                    catch (Exception ex)
                    {
                        job.Status = $"Fehlgeschlagen: {ex.Message}";
                    }

                    OnJobFinished?.Invoke(job);
                }
                else
                {
                    Thread.Sleep(1000); // Warte, wenn keine Jobs vorhanden sind
                }
            }
        }

        private void Print(PrintJob job)
        {
            // TODO: Implementiere den Druckvorgang
            // Verwende PDF-Drucktool deiner Wahl z.B. Acrobat, PDFSharp, Ghostscript etc.
            // Hier ein Platzhalter:
            OnStatusUpdate?.Invoke(job, "Drucksimulation gestartet...");
            Thread.Sleep(3000); // Simuliert Druckdauer
            OnStatusUpdate?.Invoke(job, "Druck abgeschlossen");
        }
    }

}
