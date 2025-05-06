using DownloadCleanerV2.assets;
using PCessentials.assets;
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
            config.DarkModeChanged += StyleDownloadCleaner;
            this.FormClosed += DownloadCleaner_FormClosed;
        }

        private void StyleDownloadCleaner()
        {
            UIHelper.StyleModernChildForm(this);

            UIHelper.StyleModernGroupBox(gBox_DC_cleaner);

            UIHelper.StyleModernButton(btn_StartCleaning);

            UIHelper.StyleModernCheckBox(cbox_StartUp);

            UIHelper.StyleModernLabel(label1, true);
            UIHelper.StyleModernLabel(lbl_StatusMsg);
            UIHelper.StyleModernLabel(lbl_DC_Header, true);

        }

        private void DownloadCleaner_FormClosed(object sender, FormClosedEventArgs e)
        {
            config.DarkModeChanged -= StyleDownloadCleaner;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StyleDownloadCleaner();
            cbox_StartUp.Checked = Properties.Settings.Default.cbox_startupState;
            if (cbox_StartUp.Checked)
            {
                lbl_StatusMsg.Text = "Cleaning...";
                cleaner.startCleaning();
                lbl_StatusMsg.Text = "Finished Cleaning";
            }

        }
        private void btn_StartCleaning_Click(object sender, EventArgs e)
        {
            lbl_StatusMsg.Text = "Cleaning...";
            this.cleaner.startCleaning();
            lbl_StatusMsg.Text = "Finished Cleaning";
        }
        private void cbox_StartUp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.cbox_startupState = cbox_StartUp.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
