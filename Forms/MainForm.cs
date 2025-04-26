using PCessentials.assets;
using PCessentials.assets.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCessentials.Forms
{
    public partial class MainForm : Form
    {
        private readonly FormService _formService;
        private Color defaultButtonColor = SystemColors.Control;
        private Color activeButtonColor = Color.LightBlue;
        private Button currentButton;
        private string currentFormKey;

        public MainForm()
        {
            InitializeComponent();

            // Logik-Klasse instanziieren
            _formService = new FormService();

            // ListBox mit allen verfügbaren Form-Namen füllen
            listBoxForms.DataSource = _formService.getFormNames().ToList();
            listBoxForms.SelectedIndexChanged += ListBoxForms_SelectedIndexChanged;

            // Modernes Styling anwenden
            UIHelper.styleModernListBox(listBoxForms);
        }

        /// <summary>
        /// Schließt das derzeit aktive Child-Form.
        /// </summary>
        private void CloseActiveForm()
        {
            foreach (Control ctrl in pnl_MF_Content.Controls)
                if (ctrl is Form f)
                    f.Close();
            pnl_MF_Content.Controls.Clear();
            pnl_MF_Content.Tag = null;
        }

        /// <summary>
        /// Öffnet das übergebene Child-Form in unserem Panel.
        /// Button-Färbung nur, wenn ein Button übergeben wurde.
        /// </summary>
        private void OpenChildForm(Form childForm, Button senderButton)
        {
            if (senderButton != null)
            {
                if (currentButton != null)
                    currentButton.BackColor = defaultButtonColor;

                currentButton = senderButton;
                currentButton.BackColor = activeButtonColor;
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_MF_Content.Controls.Add(childForm);
            pnl_MF_Content.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// Wechselt das Form anhand der Auswahl in der ListBox.
        /// Bei Auswahl des gleichen Elements wird nur geschlossen.
        /// </summary>
        private void ListBoxForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBoxForms.SelectedItem is string formKey))
                return;

            if (string.Equals(currentFormKey, formKey, StringComparison.Ordinal))
            {
                CloseActiveForm();
                currentFormKey = null;
                return;
            }

            CloseActiveForm();
            var form = _formService.createForm(formKey);
            OpenChildForm(form, null);
            currentFormKey = formKey;
        }
    }
}
