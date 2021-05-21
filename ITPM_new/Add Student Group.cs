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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStuAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTableDao timeTableDao = new TimeTableDao();
                string sql = "INSERT INTO student(year_sem,programme,grp_no,sub_grp_no,grp_id,sub_grp_id)values('" + this.textBox1.Text + "','" + this.comboBox1.Text + "','" + this.numericUpDown1.Text + "','" + this.numericUpDown2.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "')";
                timeTableDao.excecuteSQL(sql);
                MessageBox.Show("Data add successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add the Database" + ex);
            }
        }

        private void btnStuclear_Click(object sender, EventArgs e)
        {
            try
            {

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = string.Empty;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;

                MessageBox.Show("Data clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to clear data" + ex);
            }
        }

        private void btnStugid_Click(object sender, EventArgs e)
        {
            try
            {

                String year_sem = textBox1.Text;
                String programme = comboBox1.Text;

                int grp_no = Convert.ToInt32(numericUpDown1.Value);
                int sub_grp_no = Convert.ToInt32(numericUpDown2.Value);

                textBox2.Text = year_sem + "." + programme + "." + grp_no;
                textBox3.Text = year_sem + "." + programme + "." + grp_no + "." + sub_grp_no;

                MessageBox.Show("Generates IDs successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Generate IDs" + ex);
            }
        }

        private void btnStuview_Click(object sender, EventArgs e)
        {
            
            Manage_Student_Group mform = new Manage_Student_Group();
            mform.Show();
            this.Hide();
        }

        private void btnTagFormS_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag ();
            mform.Show();
            this.Hide();
        }

        private void btn_Adavaced_Session_Form_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _3mem1 mform = new _3mem1();
            mform.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddLocation mform = new AddLocation();
            mform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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
