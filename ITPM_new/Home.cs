using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM_new
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLocation f1 = new AddLocation();
            f1.Show();
        }

        private void manageLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLocation form2 = new ManageLocation();
            form2.Show();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
