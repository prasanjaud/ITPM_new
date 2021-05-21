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
    public partial class View_Non_Overlapping : Form
    {
        public View_Non_Overlapping()
        {
            InitializeComponent();
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        private void View_Non_Overlapping_Load(object sender, EventArgs e)
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

        private void btn_View_Overlappingupdate_Click(object sender, EventArgs e)
        {

            try
            {
                TimeTableDao timeTableDao = new TimeTableDao();
                string sql = "UPDATE non_overlap SET session1 = '" + this.comboBox1.Text + "',session2='" + this.comboBox2.Text + "',duration ='" + this.comboBox3.Text + "',day ='" + this.comboBox4.Text + "',start_time ='" + this.comboBox5.Text + "',end_time ='" + this.comboBox6.Text + "'WHERE id ='" + label11.Text + "';";
                timeTableDao.excecuteSQL(sql);
                ViewNonOverlapping_dataGridView1.Refresh();

                MessageBox.Show("Data update successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update data" + ex);
            }
        }

        private void ViewNonOverlapping_dataGridView1_CellClike(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = ViewNonOverlapping_dataGridView1.Rows[e.RowIndex];
            label11.Text = row.Cells[0].Value.ToString();
            comboBox1.Text = row.Cells[1].Value.ToString();
            comboBox2.Text = row.Cells[2].Value.ToString();
            comboBox3.Text = row.Cells[3].Value.ToString();
            comboBox4.Text = row.Cells[4].Value.ToString();
            comboBox5.Text = row.Cells[5].Value.ToString();
            comboBox6.Text = row.Cells[6].Value.ToString();
        }

        private void btn_View_OverlappingRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new MySqlConnection("server = localhost; user id = root; database =itpm ");
                da = new MySqlDataAdapter("Select * from non_overlap", cn);
                ds = new DataSet();
                da.Fill(ds, "dept");
                ViewNonOverlapping_dataGridView1.DataSource = ds.Tables["dept"];

                MessageBox.Show("Refresh successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Refresh" + ex);
            }
        }

        private void btn_View_OverlappingDelete_Click(object sender, EventArgs e)
        {
            try
            {

                TimeTableDao timeTableDao = new TimeTableDao();
                String sql = "DELETE FROM non_overlap WHERE id ='" + label11.Text + "';";
                timeTableDao.excecuteSQL(sql);
                ViewNonOverlapping_dataGridView1.Refresh();

                MessageBox.Show("Data delete successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to data delete" + ex);
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

        private void btn_View_OverlappingBack_Click(object sender, EventArgs e)
        {
            Add_Non_Overlapping_Session mform = new Add_Non_Overlapping_Session();
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
