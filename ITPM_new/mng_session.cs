using MySql.Data.MySqlClient;
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
    public partial class mng_session : Form
    {

        dbConnection con = new dbConnection();
        String query;
        String query2; 
        public mng_session()
        {
            InitializeComponent();
        }
       

        private void mng_session_Load(object sender, EventArgs e)
        {
            LoadData1();
            LoadData2();
            LoadData3();
            LoadData4();
            LoadData5();
            LoadData6();
            loadData7();

        }

        public void loadData7()
        {
            query = "SELECT s_id,lec1,lec2,subject_code,grp_id,tag,nstudents, duration,sub_name FROM session";
            DataSet ds = con.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private bool IsValid()
        {
            if (lec.Text == String.Empty)
            {
                MessageBox.Show("Please Select Lecture 1");
                return false;
            }
            return true;
        }

        //int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            lec.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            lec2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            sub.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            grp.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            tag.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            scount.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            time.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            subn.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        public void LoadData1()
        {
            query = "SELECT lecturer_Name FROM lectureinfo";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                lec.Items.Add(ds.Tables[0].Rows[i][0].ToString());


        }
        public void LoadData2()
        {
            query = "SELECT tag_name FROM tag_table";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                tag.Items.Add(ds.Tables[0].Rows[i][0].ToString());


        }
        public void LoadData3()
        {
            query = "SELECT grp_id, sub_grp_id  FROM student";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                grp.Items.Add(ds.Tables[0].Rows[i][0].ToString());


        }
        public void LoadData4()
        {
            query = "SELECT Subject_Code FROM subjectinfo";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                sub.Items.Add(ds.Tables[0].Rows[i][0].ToString());


        }
        public void LoadData5()
        {
            query = "SELECT lecturer_Name FROM lectureinfo";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                lec2.Items.Add(ds.Tables[0].Rows[i][0].ToString());


        }
        public void LoadData6()
        {
            query = "SELECT Subject_Name FROM subjectinfo";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                subn.Items.Add(ds.Tables[0].Rows[i][0].ToString());


        }

        private void button11_Click(object sender, EventArgs e)
        {

            query = "UPDATE session SET lec1='" + lec.Text + "',lec2='" + lec2.Text + "',subject_code ='" + sub + "',grp_id='" + grp.Text + "',tag = '" + tag.Text + "',sub_name = '" + subn.Text + "',nstudents = '" + scount.Text + "',duration  = '" + time.Text + "' WHERE s_id= "+label7.Text+" ";
            con.setData(query);

            loadData7();


        }

        private void button14_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM session WHERE s_id=" + label7.Text + "";
            con.setData(query);
            loadData7();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Lec form2 = new Add_Lec();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_sub form2 = new Add_sub();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Add_session form2 = new Add_session();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _3mem1 mform = new _3mem1();
            mform.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mform = new Form1();
            mform.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            addLocationSession form2 = new addLocationSession();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VisulizingStatics form2 = new VisulizingStatics();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddLocation mform = new AddLocation();
            mform.Show();
            this.Hide();
        }
    }
}
