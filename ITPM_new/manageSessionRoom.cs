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
    public partial class manageSessionRoom : Form
    {
        dbConnection con = new dbConnection();
        String query;

        public manageSessionRoom()
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

        private void manageSessionRoom_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "SELECT roomName FROM rooms";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmbBoxRoom.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
