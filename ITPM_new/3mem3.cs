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
    public partial class _3mem3 : Form
    {
        public _3mem3()
        {
            InitializeComponent();
        }

        private void btnSADD_Click(object sender, EventArgs e)
        {

            try
            {
                DB itpmDB = new DB();
                string sql = "INSERT INTO notavailable(nlecturer,ngroup,nsubgroup,nsession,nday,ntime)values('" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.comboBox3.Text + "','" + this.comboBox4.Text + "','" + this.comboBox5.Text + "','" + this.textBox1.Text + "')";
                itpmDB.excecuteSQL(sql);
                MessageBox.Show("Data Add successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Add the Database" + ex);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _3mem3 mform = new _3mem3();
            mform.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Parallel_Session mform = new Parallel_Session();
            mform.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Add_Non_Overlapping_Session mform = new Add_Non_Overlapping_Session();
            mform.Show();
            this.Hide();
        }

        private void btnSCLEAR_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = string.Empty;
                comboBox2.Text = string.Empty;
                comboBox3.Text = string.Empty;
                comboBox4.Text = string.Empty;
                comboBox5.Text = string.Empty;
                textBox1.Clear();

                MessageBox.Show("Data Clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Clear data" + ex);
            }
        }

        private void btnSVIEW_Click(object sender, EventArgs e)
        {
            _3mem4 mform = new _3mem4();
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

        private void _3mem3_Load(object sender, EventArgs e)
        {

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