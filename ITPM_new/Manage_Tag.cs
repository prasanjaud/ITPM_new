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
    public partial class Manage_Tag : Form
    {
        public Manage_Tag()
        {
            InitializeComponent();
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        private void Manage_Tag_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server = localhost; user id = root; database = itpm");
            da = new MySqlDataAdapter("Select * from tag_table", cn);
            ds = new DataSet();
            da.Fill(ds, "dept");
            Manage_TagdataGridView.DataSource = ds.Tables["dept"];
        }

        private void Manage_TagdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Manage_TagdataGridView.Rows[e.RowIndex];
            label4.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            comboBox1.Text = row.Cells[3].Value.ToString();
        }

        private void btnMTUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTableDao timeTableDao = new TimeTableDao();
                string sql = "UPDATE tag_table SET tag_name = '" + this.textBox1.Text + "',tag_code='" + this.textBox2.Text + "',related_tag ='" + this.comboBox1.Text + "'WHERE idtag_table ='" + label4.Text + "';";
                timeTableDao.excecuteSQL(sql);
                Manage_TagdataGridView.Refresh();

                MessageBox.Show("Data update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update data" + ex);
            }
        }

        private void btnMTDelete_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTableDao timeTableDao = new TimeTableDao();
                String sql = "DELETE FROM tag_table WHERE idtag_table ='" + label4.Text + "';";
                timeTableDao.excecuteSQL(sql);
                Manage_TagdataGridView.Refresh();

                MessageBox.Show("Data delete successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete data" + ex);
            }
        }

        private void btnMTClear_Click(object sender, EventArgs e)
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
                MessageBox.Show("Unable to clear delete" + ex);
            }
        }

        private void btnMTRefresh_Click(object sender, EventArgs e)
        {

            try
            {
                cn = new MySqlConnection("server = localhost; user id = root; database = itpm");
                da = new MySqlDataAdapter("Select * from tag_table", cn);
                ds = new DataSet();
                da.Fill(ds, "dept");
                Manage_TagdataGridView.DataSource = ds.Tables["dept"];

                MessageBox.Show("Refresh successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Refresh" + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddLocation mform = new AddLocation();
            mform.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
