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
    public partial class _3mem5 : Form
    {
        public _3mem5()
        {
            InitializeComponent();
        }

        private void _3mem5_Load(object sender, EventArgs e)
        {

        }

        private void btnTADD_Click(object sender, EventArgs e)
        {
            try
            {
                DB abc_dbDB = new DB();
                string sql = "INSERT INTO notlocation(loroom,lolocation,lostime,loetime)values('" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.comboBox3.Text + "','" + this.comboBox4.Text + "')";
                abc_dbDB.excecuteSQL(sql);
                MessageBox.Show("Data Add successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Add the Database" + ex);
            }
        }

        private void btnTCLEAR_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = string.Empty;
                comboBox2.Text = string.Empty;
                comboBox3.Text = string.Empty;
                comboBox4.Text = string.Empty;

                MessageBox.Show("Data Clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Clear data" + ex);
            }
        }

        private void btnTVIEW_Click(object sender, EventArgs e)
        {
            _3mem6 mform = new _3mem6();
            mform.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addLocationSession form2 = new addLocationSession();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddLocation mform = new AddLocation();
            mform.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            _3mem1 mform = new _3mem1();
            mform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 mform = new Form1();
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
