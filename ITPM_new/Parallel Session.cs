using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITPM_new
{
    public partial class Parallel_Session : Form
    {
        public Parallel_Session()
        {
            InitializeComponent();
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        private void Parallel_Session_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server=localhost;user id=root; database=itpm");
            da = new MySqlDataAdapter("Select * from session_table", cn);

            string selectQuery = "Select Session_ID,lecture1, lecture2,subject_code, subject_name, group_id , tag from session_table";

            cn.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, cn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString("Session_ID") + ' ' + reader.GetString("lecture1") + ' ' + reader.GetString("lecture2") + ' ' + reader.GetString("subject_code") + ' ' + reader.GetString("subject_name") + ' ' + reader.GetString("group_id") + ' ' + reader.GetString("tag"));


                comboBox2.Items.Add(reader.GetString("Session_ID") + ' ' + reader.GetString("lecture1") + ' ' + reader.GetString("lecture2") + ' ' + reader.GetString("subject_code") + ' ' + reader.GetString("subject_name") + ' ' + reader.GetString("group_id") + ' ' + reader.GetString("tag"));
            }

            cn.Close();
        }

        private void btn_Add_Parallel_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTableDao timeTableDao = new TimeTableDao();
                string sql = "INSERT INTO parallel_table(session1,session2,duration,day,start_time,end_time)values('" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.comboBox3.Text + "','" + this.comboBox4.Text + "','" + this.comboBox5.Text + "','" + this.comboBox6.Text + "')";
                timeTableDao.excecuteSQL(sql);
                MessageBox.Show("Data add successfully");

            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add the Database" + ex);
               
            }
        }

        private void btn_Parallel_View_Click(object sender, EventArgs e)
        {
            View_Parallel_Session mform = new View_Parallel_Session();
            mform.Show();
            this.Hide();
        }

        private void btn_Parallel_Clear_Click(object sender, EventArgs e)
        {
            try
            {

                comboBox1.Text = string.Empty;
                comboBox2.Text = string.Empty;
                comboBox3.Text = string.Empty;
                comboBox4.Text = string.Empty;
                comboBox5.Text = string.Empty;
                comboBox6.Text = string.Empty;


                MessageBox.Show("Data clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to clear data" + ex);
            }
        }

        private void btn_Add_Parallel_Session_Click(object sender, EventArgs e)
        {
            Parallel_Session mform = new Parallel_Session();
            mform.Show();
            this.Hide();
        }

        private void btn_NonOverlap_Session_Click(object sender, EventArgs e)
        {
            Add_Non_Overlapping_Session mform = new Add_Non_Overlapping_Session();
            mform.Show();
            this.Hide();
        }

        private void btn_Add_Consective_Session_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void btn_Add_NotAvailable_Session_Click(object sender, EventArgs e)
        {
            _3mem3 mform = new _3mem3();
            mform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _3mem1 mform = new _3mem1();
            mform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddLocation mform = new AddLocation();
            mform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            VisulizingStatics form2 = new VisulizingStatics();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }
    }
}
