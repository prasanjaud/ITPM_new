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
        String s1, s2, overview;

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

            query = "SELECT s_id FROM session";
            DataSet ds1 = con.getData(query);
            for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                cmbBoxSession.Items.Add(ds1.Tables[0].Rows[j][0].ToString());

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbBoxSession.Text = "";
            cmbBoxRoom.Text = "";
            txtBoxSelectedSession.Text = "";
        }

        private void cmbBoxSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            string session_id = cmbBoxSession.SelectedItem.ToString();

            query = "SELECT * FROM session WHERE s_id = " + session_id + "";
            DataSet ds = con.getData(query);
            s1 = ds.Tables[0].Rows[0][10].ToString();
            txtBoxSelectedSession.Text = s1 + "\r\n" + s2;
        }

        private void advancedSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void workingDaysAndHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _3mem1 mform = new _3mem1();
            mform.Show();
            this.Hide();
        }

        private void studentGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mform = new Form1();
            mform.Show();
            this.Hide();
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

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisulizingStatics form2 = new VisulizingStatics();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocation mform = new AddLocation();
            mform.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Lec form2 = new Add_Lec();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void sessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbBoxRoom.Text) || string.IsNullOrEmpty(cmbBoxSession.Text))
            {
                MessageBox.Show("Select all combo boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "UPDATE session SET room='" + cmbBoxRoom.Text + "' WHERE s_id=" + cmbBoxSession.Text + "";
                con.setData(query);
                this.Hide();
                //addLocationSession addLSForm = new addLocationSession();
                //addLSForm.Show();
            }
        }

        private void cmbBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            s2 = cmbBoxRoom.SelectedItem.ToString();
            txtBoxSelectedSession.Text = s1 + "\r\n" + s2;
        }
    }
}
