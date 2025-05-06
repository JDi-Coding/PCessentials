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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            config.DarkModeChanged += StyleHelp;
            this.FormClosed += Help_FormClosed;
        }

        private void StyleHelp()
        {

        }

        private void Help_FormClosed(object sender, FormClosedEventArgs e)
        {
            config.DarkModeChanged -= StyleHelp;
        }

        private void Help_Load(object sender, EventArgs e)
        {
            StyleHelp();
        }
    }
}
