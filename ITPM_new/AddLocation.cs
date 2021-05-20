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
    public partial class AddLocation : Form
    {
        dbConnection con = new dbConnection();
        String query;
        String roomType = "Lecture Hall";

        public AddLocation()
        {
            InitializeComponent();
        }

        private void manageLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLocation form2 = new ManageLocation();
            form2.Show();
        }

        private void addLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLocation f1 = new AddLocation();
            f1.Show();
        }

        public void ClearAll()
        {
            txtBuildingName.Clear();
            txtRoomName.Clear();
            txtCapacity.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query = "insert into rooms (buildingName, roomName, roomType, capacity) values ('" + txtBuildingName.Text + "','" + txtRoomName.Text + "','" + roomType + "'," + txtCapacity.Text + ")";
            con.setData(query);
            ClearAll();
        }

        private void rdBtnLaboratory_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Laboratory";
        }

        private void rdBtnLectureHall_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Lecture Hall";
        }

        private void AddLocation_Load(object sender, EventArgs e)
        {

        }
    }
}
