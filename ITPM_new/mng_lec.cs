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
    public partial class Man_lec : Form
    {
        public Man_lec()
        {
            InitializeComponent();
        }


        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("Server = localhost;user id = root; password =; Database = itpm;");
            da = new MySqlDataAdapter("select lecturer_Name,emp_Id,faculty,department,center,building,level,rank from lectureinfo", cn);
            ds = new DataSet();

            da.Fill(ds, "dept");
            dataGridView1.DataSource = ds.Tables["dept"];
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void eid_TextChanged(object sender, EventArgs e)
        {

        }

        private void building_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void center_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void faculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rank_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void level_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string sql = "DELETE FROM lectureinfo WHERE emp_Id ='" + eid.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Successfully Deleted");

                    da = new MySqlDataAdapter("select lecturer_Name,emp_Id,faculty,department,center,building,level,rank from lectureinfo", cn);
                    ds = new DataSet();
                    //ds.Clear();
                    //dataGridView1.Rows.Clear();
                    da.Fill(ds, "dept");
                    dataGridView1.DataSource = ds.Tables["dept"];

                    lname.Text = "";
                    eid.Text = "";
                    faculty.Text = "";
                    department.Text = "";
                    center.Text = "";
                    building.Text = "";
                    level.Text = "";
                    rank.Text = "";
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

        private void button13_Click(object sender, EventArgs e)
        {

            String num1 = eid.Text;
            String num2 = level.Text;
            int val = 0;


            switch (num2)
            {
                case "Professor":
                    val = 1;
                    break;
                case "Assistant Professor":
                    val = 2;
                    break;
                case "Senior Lecturer(HG)":
                    val = 3;
                    break;
                case "Senior Lecturer":
                    val = 4;
                    break;
                case "Lecturer":
                    val = 5;
                    break;
                case "Assistant Lecturer":
                    val = 6;
                    break;
                default:
                    break;


            }
            rank.Text = val + "." + num1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string sql = "UPDATE lectureinfo SET lecturer_Name='" + lname.Text.Trim() + "',faculty='" + faculty.Text.Trim() + "',department='" + department.Text.Trim() + "',center='" + center.Text.Trim() + "',building='" + building.Text.Trim() + "',level='" + level.Text.Trim() + "',rank='" + rank.Text.Trim() + "' WHERE  emp_Id= '" + eid.Text.Trim() + "'";

                MySqlCommand cmd = new MySqlCommand(sql, cn);
                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    MessageBox.Show("Updated");
                    da = new MySqlDataAdapter("select * from lectureinfo", cn);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lname.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            eid.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            faculty.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            department.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            center.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            building.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            level.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            rank.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lname.Text = "";
            eid.Text = "";
            faculty.Text = "";
            department.Text = "";
            center.Text = "";
            building.Text = "";
            level.Text = "";
            rank.Text = "";
        }
    }
}
