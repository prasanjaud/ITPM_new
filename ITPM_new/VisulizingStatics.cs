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
    public partial class VisulizingStatics : Form
    {
        dbConnection con = new dbConnection();
        String query;

        public VisulizingStatics()
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

        private void VisulizingStatics_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "SELECT * FROM rooms";
            DataSet ds = con.getData(query);
            lblRoomCount.Text = ds.Tables[0].Rows.Count.ToString();

            query = "SELECT * FROM subjectinfo";
            DataSet ds1 = con.getData(query);
            lblSubjectCount.Text = ds1.Tables[0].Rows.Count.ToString();

            query = "SELECT * FROM student";
            DataSet ds2 = con.getData(query);
            lblStudentCount.Text = ds2.Tables[0].Rows.Count.ToString();

            query = "SELECT * FROM lectureinfo";
            DataSet ds3 = con.getData(query);
            lblLectureCount.Text = ds3.Tables[0].Rows.Count.ToString();

            query = "SELECT * FROM lectureinfo ORDER BY id_lec DESC LIMIT 1;";
            DataSet ds4 = con.getData(query);
            txtLatestLecturer.Text = ds4.Tables[0].Rows[0][0].ToString();

            query = "SELECT * FROM student ORDER BY idstudent DESC LIMIT 1;";
            DataSet ds5 = con.getData(query);
            txtLatestGroup.Text = ds5.Tables[0].Rows[0][5].ToString();

            query = "SELECT * FROM subjectinfo ORDER BY id_sub DESC LIMIT 1;";
            DataSet ds6 = con.getData(query);
            txtLatestSubject.Text = ds6.Tables[0].Rows[0][1].ToString();

            query = "SELECT * FROM rooms";
            DataSet ds7 = con.getData(query);
            chart1.Series["Lecture Rooms"].XValueMember = "roomType";
            chart1.Series["Lecture Rooms"].YValueMembers = "capacity";
            chart1.DataSource = ds7.Tables[0];

            query = "SELECT * FROM rooms";
            DataSet ds8 = con.getData(query);
            chart1.Series["Laboratories"].XValueMember = "roomType";
            chart1.Series["Laboratories"].YValueMembers = "capacity";
            chart1.DataSource = ds8.Tables[0];
        }

        private void lecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Lec addLec = new Add_Lec();
            addLec.Show();
        }

        private void manageSessionRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageSessionRoom msform = new manageSessionRoom();
            msform.Show();
        }

        private void sessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_session form2 = new Add_session();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void workingDaysAndHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _3mem1 mform = new _3mem1();
            mform.Show();
            this.Hide();
        }

        private void txtLatestLecturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void adavncedSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
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

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisulizingStatics mform = new VisulizingStatics();
            mform.Show();
            this.Hide();
        }

        private void studentGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mform = new Form1();
            mform.Show();
            this.Hide();
        }
    }
}
