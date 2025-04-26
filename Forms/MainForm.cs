using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCessentials
{
    public partial class MainForm : Form
    {
        private Color defaultButtonColor = SystemColors.Control;
        private Color activeButtonColor = Color.LightBlue;
        private Button currentButton;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, Button senderButton)
        {
            if (currentButton != null)
                currentButton.BackColor = defaultButtonColor;

            currentButton = senderButton;
            currentButton.BackColor = activeButtonColor;

            foreach (Control ctrl in panelContainer.Controls)
                if (ctrl is Form f)
                    f.Close();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            var form1 = new PCessentials.DownloadCleaner();
            OpenChildForm(form1, sender as Button);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is not available yet. \n\r THIS STILL NEED FIXING BUG #1");
            var form2 = new PCessentials.Controlpanel();
            OpenChildForm(form2, sender as Button);
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            var form3 = new PCessentials.PSWManager();
            OpenChildForm(form3, sender as Button);
        }

        private void btn_FormPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not fully Completed yet. \n\r #2");
            var form4 = new PCessentials.PrintManager();
            OpenChildForm(form4, sender as Button);
        }

        private void btn_FormWebDownloader_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is not fully Completed yet. \n\r #3");
            var form4 = new PCessentials.WebDownloader();
            OpenChildForm(form4, sender as Button);
        }
    }
}
