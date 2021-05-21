using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace ITPM_new
{
    public partial class Add_Lec : Form
    {
        MySqlConnection con = null;

        public Add_Lec()
        {
            InitializeComponent();

            try
            {
                string sql = ("Server=localhost;Uid=root;password=root;Database=itpm;");
                con = new MySqlConnection(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\Database1.mdf; Integrated Security = True

                

                try
                {
                    con.Open();
                    string sql = "INSERT INTO lectureinfo(lecturer_Name,emp_Id,faculty,department,center,building,level,rank) VALUES" +
                        "('" + lname.Text.Trim() + "','" + eid.Text.Trim() + "','" + faculty.Text.Trim() + "','" + department.Text.Trim() + "','" + center.Text.Trim() + "','" + building.Text.Trim() + "','" + level.Text.Trim() + "','" + rank.Text.Trim() + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    int r = cmd.ExecuteNonQuery();

                    if (r > 0)
                    {
                        MessageBox.Show("Successfully Added");
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
                    con.Close();
                }

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

        private void button14_Click(object sender, EventArgs e)
        {
            Man_lec form2 = new Man_lec();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void level_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
