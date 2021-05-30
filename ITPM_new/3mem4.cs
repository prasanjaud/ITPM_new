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
    public partial class _3mem4 : Form
    {
        dbConnection con = new dbConnection();
        String query;
        public _3mem4()
        {
            InitializeComponent();
        }

        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            label8.Text = row.Cells[0].Value.ToString();
            comboBox1.Text = row.Cells[1].Value.ToString();
            comboBox2.Text = row.Cells[2].Value.ToString();
            comboBox3.Text = row.Cells[3].Value.ToString();
            comboBox4.Text = row.Cells[4].Value.ToString();
            comboBox5.Text = row.Cells[5].Value.ToString();
            textBox1.Text = row.Cells[6].Value.ToString();
        }

        private void _3mem4_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server = localhost; user id = root; database = itpm; ");
            da = new MySqlDataAdapter("Select * from notavailable", cn);
            ds = new DataSet();
            da.Fill(ds, "dept");
            dataGridView1.DataSource = ds.Tables["dept"];

            LoadData1();
            LoadData2();
            LoadData3();
            LoadData4();
        }

        public void LoadData1()
        {
            query = "SELECT lecturer_Name FROM lectureinfo";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());


        }

        public void LoadData2()
        {
            query = "SELECT grp_id FROM student";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                comboBox2.Items.Add(ds.Tables[0].Rows[i][0].ToString());


        }

        public void LoadData3()
        {
            query = "SELECT sub_grp_id  FROM student";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                comboBox3.Items.Add(ds.Tables[0].Rows[i][0].ToString());


        }

        public void LoadData4()
        {
            query = "SELECT s_id FROM session";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                comboBox4.Items.Add(ds.Tables[0].Rows[i][0].ToString());


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSUPDATE_Click(object sender, EventArgs e)
        {

            try
            {

                DB abc_dbDB = new DB();
                string sql = "UPDATE notavailable SET nlecturer = '" + this.comboBox1.Text + "',ngroup = '" + this.comboBox2.Text + "', nsubgroup = '" + this.comboBox3.Text + "' , nsession = '" + this.comboBox4.Text + "', nday='" + this.comboBox5.Text + "', ntime = '" + this.textBox1.Text + "' WHERE idnotavailable ='" + label8.Text + "';";
                abc_dbDB.excecuteSQL(sql);
                dataGridView1.Refresh();

                MessageBox.Show("Data Update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update data" + ex);
            }
        }

        private void btnSDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                DB abc_dbDB = new DB();
                String sql = "DELETE FROM notavailable WHERE idnotavailable ='" + label8.Text + "';";
                abc_dbDB.excecuteSQL(sql);
                dataGridView1.Refresh();

                MessageBox.Show("Data Delete successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete data" + ex);
            }
        }

        private void btnSREFRESH_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new MySqlConnection("server = localhost; user id = root; database = itpm; ");
                da = new MySqlDataAdapter("Select * from notavailable", cn);
                ds = new DataSet();
                da.Fill(ds, "dept");
                dataGridView1.DataSource = ds.Tables["dept"];

                MessageBox.Show("Refresh successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Refresh" + ex);
            }
        }

        private void button14_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Parallel_Session form2 = new Parallel_Session();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Add_Non_Overlapping_Session form2 = new Add_Non_Overlapping_Session();
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
