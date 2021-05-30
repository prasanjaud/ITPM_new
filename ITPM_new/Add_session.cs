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
    public partial class Add_session : Form
    {
        dbConnection con = new dbConnection();
        String query;
        String query2;

        public Add_session()
        {
            InitializeComponent();


        
        }

        private void center_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Add_session_Load(object sender, EventArgs e)
        {
            LoadData1();
            LoadData2();
            LoadData3();
            LoadData4();
            LoadData5();
            LoadData6();

            
            


            


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

        private void button13_Click(object sender, EventArgs e)
        {
            String Lname = lec.Text;
            String lect2 = lec2.Text;
            String group = grp.Text;
            String subject = sub.Text;
            String sub_name = subn.Text;
            String tag1 = tag.Text;
            String count = scount.Text;
            String dtime = time.Text;

            String overview ="   " + Lname + "   --   "+  lect2  + "   --   " + group + "   --   " + subject + "   --   "+  sub_name + "   --" + tag1 + "   --   " + count + "   --   " + dtime + "Hrs   ";
            view.Text = overview;

           

                button12.Enabled = true;
                button14.Enabled = true;
           
        }

        private bool IsValid()
        {
            if(lec.Text == String.Empty)
            {
                MessageBox.Show("Please Select Lecture 1");
                return false;
            }
            return true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                

                    query = "insert into session (lec1,lec2,subject_code,grp_id,tag,nstudents, duration,sub_name,overview) values" + "('" + lec.Text.Trim() + "','" + lec2.Text.Trim() + "','" + sub.Text.Trim() + "','" + grp.Text.Trim() + "','" + tag.Text.Trim() + "','" + scount.Text.Trim() + "','" + time.Text.Trim() + "','" + subn.Text.Trim() + "','"+view.Text.Trim()+"')";
                    con.setData(query);

            }

            lec.Text = "";
            lec2.Text = "";
            grp.Text = "";
            sub.Text = "";
            subn.Text = "";
            tag.Text = "";
            scount.Text = "";
            time.Text = "";
            view.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //String sub;
            //query = "Select Subject_Name  From subjectinfo WHERE "
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Lec form2 = new Add_Lec();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            mng_session form2 = new mng_session();
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

        private void button11_Click(object sender, EventArgs e)
        {
            lec.Text = "";
            lec2.Text = "";
            grp.Text = "";
            sub.Text = "";
            subn.Text = "";
            tag.Text = "";
            scount.Text = "";
            time.Text = "";
            view.Text = "";
        }
    }
}
