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
    public partial class _3mem2 : Form
    {
        public _3mem2()
        {
            InitializeComponent();
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            label4.Text = row.Cells[0].Value.ToString();
            numericUpDown1.Text = row.Cells[1].Value.ToString();
            checkBox1.Text = row.Cells[2].Value.ToString();
            checkBox2.Text = row.Cells[3].Value.ToString();
            checkBox3.Text = row.Cells[4].Value.ToString();
            checkBox4.Text = row.Cells[5].Value.ToString();
            checkBox5.Text = row.Cells[6].Value.ToString();
            checkBox6.Text = row.Cells[7].Value.ToString();
            checkBox7.Text = row.Cells[8].Value.ToString();
            textBox1.Text = row.Cells[9].Value.ToString();

        }

        private void btnWvUpdate_Click(object sender, EventArgs e)
        {
            //
            try
            {

                DB abc_dbDB = new DB();
                string sql = "UPDATE ddays SET Noofdays = '" + this.numericUpDown1.Text + "',monday = '" + this.checkBox1.Text + "', tuesday = '" + this.checkBox2.Text + "' , wednesday = '" + this.checkBox3.Text + "', thursday='" + this.checkBox4.Text + "', friday = '" + this.checkBox5.Text + "',saturday='" + this.checkBox6.Text + "',sunday='" + this.checkBox7.Text + "',workingtime='" + this.textBox1.Text + "' WHERE idddays ='" + label4.Text + "';";
                abc_dbDB.excecuteSQL(sql);
                dataGridView1.Refresh();

                MessageBox.Show("Data Update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update data" + ex);
            }
        }

        private void _3mem2_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server = localhost; user id = root; database =itpm; ");
            da = new MySqlDataAdapter("Select * from ddays", cn);
            ds = new DataSet();
            da.Fill(ds, "dept");
            dataGridView1.DataSource = ds.Tables["dept"];
        }

        private void btnVRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new MySqlConnection("server = localhost; user id = root; database = itpm; ");
                da = new MySqlDataAdapter("Select * from ddays", cn);
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

        private void btnWvDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DB itpmDB = new DB();
                String sql = "DELETE FROM ddays WHERE idddays ='" + label4.Text + "';";
                itpmDB.excecuteSQL(sql);
                dataGridView1.Refresh();

                MessageBox.Show("Data Delete successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete data" + ex);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _3mem3 mform = new _3mem3();
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

        private void button8_Click(object sender, EventArgs e)
        {
            VisulizingStatics form2 = new VisulizingStatics();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }
    }
}
