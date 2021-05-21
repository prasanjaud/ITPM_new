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
    public partial class Add_Tag : Form
    {
        public Add_Tag()
        {
            InitializeComponent();
        }

        private void btnATagSave_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTableDao timeTableDao = new TimeTableDao();
                string sql = "INSERT INTO tag_table(tag_name,tag_code,related_tag)values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.comboBox1.Text + "')";
                timeTableDao.excecuteSQL(sql);
                MessageBox.Show("Data add successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add the Database" + ex);
            }
        }

        private void btnATClear_Click(object sender, EventArgs e)
        {
            try
            {

                textBox1.Clear();
                textBox2.Clear();
                comboBox1.Text = string.Empty;


                MessageBox.Show("Data clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to clear data" + ex);
            }
        }

        private void btnATView_Click(object sender, EventArgs e)
        {

            Manage_Tag mform = new Manage_Tag();
            mform.Show();
            this.Hide();
        }

        private void Add_Tag_Load(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            _3mem1 mform = new _3mem1();
            mform.Show();
            this.Hide();
        }

        private void btnTagForm_Click(object sender, EventArgs e)
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
