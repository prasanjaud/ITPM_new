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
    public partial class Manage_Student_Group : Form
    {
        public Manage_Student_Group()
        {
            InitializeComponent();
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        private void Manage_Student_Group_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server = localhost; user id = root; database = itpm");
            da = new MySqlDataAdapter("Select * from student", cn);
            ds = new DataSet();
            da.Fill(ds, "dept");
            Mange_StudentdataGridView.DataSource = ds.Tables["dept"];
        }
        

        private void Manage_StudentdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Mange_StudentdataGridView.Rows[e.RowIndex];
            label7.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            comboBox1.Text = row.Cells[2].Value.ToString();
            numericUpDown1.Text = row.Cells[3].Value.ToString();
            numericUpDown2.Text = row.Cells[4].Value.ToString();
            textBox2.Text = row.Cells[5].Value.ToString();
            textBox3.Text = row.Cells[6].Value.ToString();
        }
        private void btnMsupdate_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTableDao timeTableDao = new TimeTableDao();
                string sql = "UPDATE student SET year_sem = '" + this.textBox1.Text + "',programme='" + this.comboBox1.Text + "',grp_no ='" + this.numericUpDown1.Text + "',sub_grp_no ='" + this.numericUpDown2.Text + "',grp_id ='" + this.textBox2.Text + "',sub_grp_id ='" + this.textBox3.Text + "'WHERE idstudent ='" + label7.Text + "';";
                timeTableDao.excecuteSQL(sql);
                Mange_StudentdataGridView.Refresh();

                MessageBox.Show("Data update successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update data" + ex);
            }
        }

        private void btnMsDelete_Click(object sender, EventArgs e)
        {
            try
            {

                TimeTableDao timeTableDao = new TimeTableDao();
                String sql = "DELETE FROM student WHERE idstudent ='" + label7.Text + "';";
                timeTableDao.excecuteSQL(sql);
                Mange_StudentdataGridView.Refresh();

                MessageBox.Show("Data delete successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to data delete" + ex);
            }
        }

        private void btnMsRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new MySqlConnection("server = localhost; user id = root; database = itpm");
                da = new MySqlDataAdapter("Select * from student", cn);
                ds = new DataSet();
                da.Fill(ds, "dept");
                Mange_StudentdataGridView.DataSource = ds.Tables["dept"];

                MessageBox.Show("Refresh successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Refresh" + ex);
            }
        }

        private void btnMsGenerate_Click(object sender, EventArgs e)
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

        private void btnMSclear_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = string.Empty;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;

                MessageBox.Show("Data Clear successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to clear data" + ex);
            }
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
            Form1 mform = new Form1();
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
