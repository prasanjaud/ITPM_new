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
      
        private void _3mem1_Load(object sender, EventArgs e)
        {

        }

        private void btnWADD_Click(object sender, EventArgs e)
        {
            try
            {
                DB abc_dbDB = new DB();
                string sql = "INSERT INTO days(Noofdays,workingdays,workingtime)values('" + this.numericUpDown1.Text + "','" + this.checkBox1.Text + "','" + this.textBox1.Text + "')";
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
