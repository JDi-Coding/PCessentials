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
    public partial class FinanceHelper : Form
    {
        public FinanceHelper()
        {
            InitializeComponent();
            config.DarkModeChanged += StyleFinanceHelper;
            this.FormClosed += FinanceHelper_FormClosed;
        }

        private void StyleFinanceHelper()
        {

        }

        private void FinanceHelper_FormClosed(object sender, FormClosedEventArgs e)
        {
            config.DarkModeChanged -= StyleFinanceHelper;
        }


        //TODO: Implement the Finance Helper functionality

        private void FinanceHelper_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is not Implemented Yet", "Finance Helper", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StyleFinanceHelper();
        }
    }
}
