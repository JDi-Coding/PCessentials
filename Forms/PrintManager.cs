using PCessentials.assets.PrintManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCessentials.Forms
{
    public partial class PrintManager : Form
    {
        private PManager pManager;
        public PrintManager()
        {
            InitializeComponent();


            pManager = new PManager();
            // Event-Handler subscriben
            pManager.OnJobStarted += PManager_OnJobStarted;
            pManager.OnStatusUpdate += PManager_OnStatusUpdate;
            pManager.OnJobFinished += PManager_OnJobFinished;
        }

        private void PrintManager_Load(object sender, EventArgs e)
        {
            // Drucker auslesen
            cmbPrinters.Items.AddRange(pManager.GetInstalledPrinters().ToArray());
            if (cmbPrinters.Items.Count > 0)
                cmbPrinters.SelectedIndex = 0;

            // OpenFileDialog konfigurieren
            openFileDialog1.Filter = "PDF-Dateien|*.pdf";
            openFileDialog1.Multiselect = true;

            numCopies.Minimum = 1;
            numCopies.Maximum = 100;
            numCopies.Value = 1;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            foreach (var file in openFileDialog1.FileNames)
            {
                // Job konfigurieren
                var job = new PrintJob
                {
                    FilePath = file,
                    PrinterName = cmbPrinters.SelectedItem.ToString(),
                    Duplex = chkDuplex.Checked,
                    Grayscale = chkGrayscale.Checked,
                    Landscape = chkLandscape.Checked,
                    PaperSize = chkA4.Checked
                                    ? new PaperSize("A4", 827, 1169)
                                    : PrinterSettings.InstalledPrinters.Cast<string>()
                                        .Select(n => new PrinterSettings { PrinterName = n })
                                        .First(ps => ps.PrinterName == cmbPrinters.SelectedItem.ToString())
                                        .DefaultPageSettings.PaperSize
                };

                // Mehrfachkopien
                for (int i = 0; i < numCopies.Value; i++)
                {
                    pManager.AddPrintJob(job);

                    // In ListView anzeigen
                    var lvi = new ListViewItem(new[] {
                        Path.GetFileName(file),
                        job.Status
                    })
                    {
                        Tag = job
                    };
                    lvJobs.Items.Add(lvi);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
            => pManager.StartProcessing();

        private void btnStop_Click(object sender, EventArgs e)
            => pManager.StopProcessing();

        // Event-Handler zur UI-Aktualisierung
        private void PManager_OnJobStarted(PrintJob job)
            => UpdateJobStatus(job, "In Bearbeitung");

        private void PManager_OnStatusUpdate(PrintJob job, string status)
            => UpdateJobStatus(job, status);

        private void PManager_OnJobFinished(PrintJob job)
            => UpdateJobStatus(job, job.Status);

        private void UpdateJobStatus(PrintJob job, string status)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateJobStatus(job, status)));
                return;
            }

            foreach (ListViewItem item in lvJobs.Items)
            {
                if (item.Tag == job)
                {
                    item.SubItems[1].Text = status;
                    break;
                }
            }
        }


    }
}
