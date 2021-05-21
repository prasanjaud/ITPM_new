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
    }
}
