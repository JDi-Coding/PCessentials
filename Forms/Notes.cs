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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            this.FormClosed += Notes_FormClosed;
            config.DarkModeChanged += StyleNotes;
        }

        private void StyleNotes()
        {

        }

        private void Notes_FormClosed(object sender, FormClosedEventArgs e)
        {
            config.DarkModeChanged -= StyleNotes;
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            StyleNotes();
        }
    }
}
