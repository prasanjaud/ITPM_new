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
    public partial class Add_sub : Form
    {

        MySqlConnection con = null;
        public Add_sub()
        {
            InitializeComponent();


            try
            {
                string sql = ("Server=localhost;Uid=root; password=; database=itpm");
                con = new MySqlConnection(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void Add_sub_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String sems;
            if (rd1.Checked)
            {
                sems = rd1.Text;
            }
            else
            {
                sems = rd2.Text;
            }

            try
            {
                con.Open();
                string sql = "INSERT INTO subjectinfo(Subject_Name,Subject_Code,Offered_Year,Semester,Lecture_Hours,Tutorial_Hours,Lab_Hours,Evalution_Hours) VALUES" +
                    "('" + sname.Text.Trim() + "','" + scode.Text.Trim() + "','" + year.Text.Trim() + "','" + sems + "','" + lechour.Text.Trim() + "','" + thour.Text.Trim() + "','" + labhour.Text.Trim() + "','" + ehour.Text.Trim() + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Successfully Added");
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            sname.Text = "";
            scode.Text = "";
            year.Text = "";
            rd1.Checked = false;
            rd2.Checked = false;
            lechour.Text = "";
            labhour.Text = "";
            thour.Text = "";
            ehour.Text = "";
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sname.Text = "";
            scode.Text = "";
            year.Text = "";
            rd1.Checked = false;
            rd2.Checked = false;
            lechour.Text = "";
            labhour.Text = "";
            thour.Text = "";
            ehour.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Add_sub form2 = new Add_sub();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mng_sub form2 = new mng_sub();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Add_session form2 = new Add_session();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Add_Lec form2 = new Add_Lec();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            _3mem1 mform = new _3mem1();
            mform.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form1 mform = new Form1();
            mform.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VisulizingStatics form2 = new VisulizingStatics();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AddLocation mform = new AddLocation();
            mform.Show();
            this.Hide();
        }
    }
}
