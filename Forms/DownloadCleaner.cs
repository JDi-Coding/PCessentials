using DownloadCleanerV2.assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PCessentials.Forms
{
    public partial class DownloadCleaner : Form
    {
        private Cleaner cleaner;

        public DownloadCleaner()
        {
            InitializeComponent();
            cleaner = new Cleaner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbox_StartUp.Checked = Properties.Settings.Default.cbox_startupState;
            if (cbox_StartUp.Checked)
            {
                lbl_StatusMsg.Text = "Cleaning...";
                cleaner.StartCleaning();
                lbl_StatusMsg.Text = "Finished Cleaning";
            }

        }
        private void btn_StartCleaning_Click(object sender, EventArgs e)
        {
            lbl_StatusMsg.Text = "Cleaning...";
            this.cleaner.StartCleaning();
            lbl_StatusMsg.Text = "Finished Cleaning";
        }
        private void cbox_StartUp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.cbox_startupState = cbox_StartUp.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
