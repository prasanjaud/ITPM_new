using MySql.Data.MySqlClient;
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
    public partial class mng_sub : Form
    {
        public mng_sub()
        {
            InitializeComponent();
        }

        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;

        private object subjectinfo;
        private void mng_sub_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("Server = localhost;user id = root; password =; Database = itpm;");
            da = new MySqlDataAdapter("select * from subjectinfo", cn);
            ds = new DataSet();

            da.Fill(ds, "dept");
            dataGridView1.DataSource = ds.Tables["dept"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string sems;

            scode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            sname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            year.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            sems = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            lechour.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            thour.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            labhour.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            ehour.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

            if (sems == "1st Semester")
            {
                rd1.Checked = true;
            }
            else
            {
                rd2.Checked = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string sql = "DELETE FROM subjectinfo WHERE Subject_Code  ='" + scode.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Successfully Deleted");

                    da = new MySqlDataAdapter("select * from subjectinfo", cn);
                    ds = new DataSet();
                    //ds.Clear();
                    //dataGridView1.Rows.Clear();
                    da.Fill(ds, "dept");
                    dataGridView1.DataSource = ds.Tables["dept"];
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            try
            {

                cn.Open();
                String sems = rd1.Text;
                string sql = "UPDATE subjectinfo SET Subject_Name='" + sname.Text.Trim() + "', Offered_Year='" + year.Text.Trim() + "',Semester='" + sems + "',Lecture_Hours='" + lechour.Text.Trim() + "',Tutorial_Hours='" + thour.Text.Trim() + "',Lab_Hours='" + labhour.Text.Trim() + "',Evalution_Hours='" + ehour.Text.Trim() + "'WHERE Subject_Code = '" + scode.Text.Trim() + "';";

                MySqlCommand cmd = new MySqlCommand(sql, cn);
                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Updated");
                    da = new MySqlDataAdapter("select * from subjectinfo", cn);
                    ds = new DataSet();
                    //ds.Clear();
                    //dataGridView1.Rows.Clear();
                    da.Fill(ds, "dept");
                    dataGridView1.DataSource = ds.Tables["dept"];
                }
                else
                {
                    MessageBox.Show("Failed!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
