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
    public partial class _3mem6 : Form
    {
        public _3mem6()
        {
            InitializeComponent();
        }

        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            label6.Text = row.Cells[0].Value.ToString();
            comboBox1.Text = row.Cells[1].Value.ToString();
            comboBox2.Text = row.Cells[2].Value.ToString();
            comboBox3.Text = row.Cells[3].Value.ToString();
            comboBox4.Text = row.Cells[4].Value.ToString();
        }

        private void _3mem6_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server = localhost; user id = root; database = itpm; ");
            da = new MySqlDataAdapter("Select * from notlocation", cn);
            ds = new DataSet();
            da.Fill(ds, "dept");
            dataGridView1.DataSource = ds.Tables["dept"];
        }

        private void btnTUPDATE_Click(object sender, EventArgs e)
        {
            try
            {

                DB abc_dbDB = new DB();
                string sql = "UPDATE notlocation SET loroom = '" + this.comboBox1.Text + "',lolocation = '" + this.comboBox2.Text + "', lostime = '" + this.comboBox3.Text + "' , loetime = '" + this.comboBox4.Text + "' WHERE idnotlocation ='" + label6.Text + "';";
                abc_dbDB.excecuteSQL(sql);
                dataGridView1.Refresh();

                MessageBox.Show("Data Update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update data" + ex);
            }
        }

        private void btnTDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                DB abc_dbDB = new DB();
                String sql = "DELETE FROM notlocation WHERE idnotlocation ='" + label6.Text + "';";
                abc_dbDB.excecuteSQL(sql);
                dataGridView1.Refresh();

                MessageBox.Show("Data Delete successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete data" + ex);
            }
        }

        private void btnTREFRESH_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new MySqlConnection("server = localhost; user id = root; database = itpm; ");
                da = new MySqlDataAdapter("Select * from notlocation", cn);
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button14_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
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
            addLocationSession form2 = new addLocationSession();
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
