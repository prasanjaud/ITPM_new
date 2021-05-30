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
    public partial class _3mem1 : Form
    {
        public _3mem1()
        {
            InitializeComponent();
        }

        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;

        String Monday = "";
        String Tuesday = "";
        String Wednesday = "";
        String Thursday = "";
        String Friday = "";
        String Saturday = "";
        String Sunday = "";

        private void _3mem1_Load(object sender, EventArgs e)
        {

        }

        private void btnWADD_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Monday = "Monday";
            }
            else
            {
                Monday = "";
            }
            if (checkBox2.Checked)
            {
                Tuesday = "Tuesday";
            }
            else
            {
                Tuesday = "";
            }
            if (checkBox3.Checked)
            {
                Wednesday = "Wednesday";
            }
            else
            {
                Wednesday = "";
            }
            if (checkBox4.Checked)
            {
                Thursday = "Thursday";
            }
            else
            {
                Thursday = "";
            }
            if (checkBox5.Checked)
            {
                Friday = "Friday";
            }
            else
            {
                Friday = "";
            }
            if (checkBox6.Checked)
            {
                Saturday = "Saturday";
            }
            else
            {
                Saturday = "";
            }
            if (checkBox7.Checked)
            {
                Sunday = "Sunday";
            }
            else
            {
                Sunday = "";
            }
            try
            {
                DB abc_dbDB = new DB();
                string sql = "INSERT INTO ddays(Noofdays,monday,tuesday,wednesday,thursday,friday,workingtime)values('" + this.numericUpDown1.Text + "','" + Monday + "','" + Tuesday + "','" + Wednesday + "','" + Thursday + "','" + Friday + "','" + Saturday + "','" + Sunday + "','" + this.textBox1.Text + "')";
                abc_dbDB.excecuteSQL(sql);
                MessageBox.Show("Data Add successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Add the Database" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            _3mem1 mform = new _3mem1();
            mform.Show();
            this.Hide();
        }

        private void btnWView_Click(object sender, EventArgs e)
        {
            _3mem2 mform = new _3mem2();
            mform.Show();
            this.Hide();
        }

        private void btnWClear_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Text = string.Empty;

                textBox1.Clear();

                MessageBox.Show("Data Clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Clear data" + ex);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _3mem3 mform = new _3mem3();
            mform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Manage_Student_Group mform = new Manage_Student_Group();
            mform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddLocation mform = new AddLocation();
            mform.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
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

        private void button8_Click(object sender, EventArgs e)
        {
            VisulizingStatics form2 = new VisulizingStatics();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }
    }
}
