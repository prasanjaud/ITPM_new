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
            if (string.IsNullOrEmpty(txtBuildingName.Text) || string.IsNullOrEmpty(txtRoomName.Text) || string.IsNullOrEmpty(txtCapacity.Text))
            {
                MessageBox.Show("Fill all textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "insert into rooms (buildingName, roomName, roomType, capacity) values ('" + txtBuildingName.Text + "','" + txtRoomName.Text + "','" + roomType + "'," + txtCapacity.Text + ")";
                con.setData(query);
                ClearAll();
            }
        }

        private void rdBtnLaboratory_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Laboratory";
        }

        private void rdBtnLectureHall_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Lecture Hall";
        }

        private void btnManageLocation_Click(object sender, EventArgs e)
        {
            ManageLocation mform = new ManageLocation();
            mform.Show();
            this.Hide();
        }

        private void lecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Lec form2 = new Add_Lec();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void studentGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mform = new Form1();
            mform.Show();
            this.Hide();
        }

        private void workingDaysAndHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _3mem1 form2 = new _3mem1();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void advancedSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisulizingStatics form2 = new VisulizingStatics();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_sub form2 = new Add_sub();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void tagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocation mform = new AddLocation();
            mform.Show();
            this.Hide();
        }

        private void btnLecture_Click(object sender, EventArgs e)
        {

        }
    }
}
