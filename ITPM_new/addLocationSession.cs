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
    public partial class addLocationSession : Form
    {
        dbConnection con = new dbConnection();
        String query;
        public addLocationSession()
        {
            InitializeComponent();
        }

        private void addLocationSession_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "SELECT lec1 AS Lecture1, lec2 AS Lecture2, subject_code AS SubjectCode, sub_name AS SubjectName, grp_id AS GroupID, tag AS Tag, room AS Room FROM session";
            DataSet ds = con.getData(query);
            dataGridViewSession.DataSource = ds.Tables[0];

            query = "SELECT session1 AS Session1, session2 AS Session2, room AS Room FROM consecutive";
            DataSet ds1 = con.getData(query);
            dataGridViewConsecutive.DataSource = ds1.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            manageSessionRoom msrForm = new manageSessionRoom();
            msrForm.Show();
        }

        private void btnAddCon_Click(object sender, EventArgs e)
        {
            addConsecutive acForm = new addConsecutive();
            acForm.Show();
        }

        private void btnRefreshSes_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRefreshCon_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3mem5 form2 = new _3mem5();
            form2.Tag = this;
            form2.Show(this);
            Hide();
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

        private void manageSessionRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageSessionRoom msform = new manageSessionRoom();
            msform.Show();
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocation mform = new AddLocation();
            mform.Show();
            this.Hide();
        }

        private void addRoomForSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            addLocationSession form = new addLocationSession();
            form.Show();
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

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_sub form2 = new Add_sub();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void workingDaysAndHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _3mem1 mform = new _3mem1();
            mform.Show();
            this.Hide();
        }

        private void tagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void sessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_session form2 = new Add_session();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisulizingStatics form2 = new VisulizingStatics();
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
    }
}
