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

namespace PCessentials.Forms
{        
        //TODO: Add settings for the application
        // -Language
        // -Theme
        // -FolderPaths
        // -AutoStart
        // -AutoUpdate
        // -SELECT FORMS
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            config.DarkModeChanged += StyleSettings;
            StyleSettings();
        }

        private void lbl_S_Header_Click(object sender, EventArgs e)
        {
            //MISC
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            bool isDarkMode = Properties.Settings.Default.DarkModeEnabled;
            //true -> DarkMode false-> LightMode
            RadioButton theme_rbtn = isDarkMode ? rbtn_S_ThemeDark : rbtn_S_ThemeLight;
            theme_rbtn.Checked = true;

        }

        private void StyleSettings()
        {
            UIHelper.StyleModernChildForm(this);
            UIHelper.StyleModernLabel(lbl_S_Header, true);
            UIHelper.StyleModernPanel(pnl_S_Left);
            UIHelper.StyleModernGroupBox(gBox_S_lang);
            UIHelper.StyleModernGroupBox(gBox_S_Theme);
            UIHelper.StyleModernGroupBox(gBox_S_Forms);
            UIHelper.StyleModernRadioButton(rBtn_S_lang_de);
            UIHelper.StyleModernRadioButton(rBtn_S_lang_eng);
            UIHelper.StyleModernRadioButton(rbtn_S_ThemeDark);
            UIHelper.StyleModernRadioButton(rbtn_S_ThemeLight);

        }

        private void rbtn_S_ThemeDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_S_ThemeDark.Checked)
            {
                config.SetDarkMode(true);
            }
        }

        private void rbtn_S_ThemeLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_S_ThemeLight.Checked)
            {
                config.SetDarkMode(false);
            }
        }

    }
}
