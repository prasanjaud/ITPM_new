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
    public partial class addConsecutive : Form
    {
        dbConnection con = new dbConnection();
        String query;
        String s1, s2, s3;

        public addConsecutive()
        {
            InitializeComponent();
        }

        private void addConsecutive_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void cmbBoxSession2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string session_id = cmbBoxSession1.SelectedItem.ToString();

            query = "SELECT * FROM session WHERE s_id = " + session_id + "";
            DataSet ds = con.getData(query);
            s2 = ds.Tables[0].Rows[0][10].ToString();
            txtBoxSelectedSession.Text = s1 + "\r\n" + s2 + "\r\n" + s3;
        }

        private void cmbBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            s3 = cmbBoxRoom.SelectedItem.ToString();
            txtBoxSelectedSession.Text = s1 + "\r\n" + s2 + "\r\n" + s3;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBoxRoom.Text) || string.IsNullOrEmpty(cmbBoxSession1.Text) || string.IsNullOrEmpty(cmbBoxSession2.Text))
            {
                MessageBox.Show("Select all combo boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "insert into consecutive (session1, session2, room) values ('" + s1 + "','" + s2 + "','" + s3 + "')";
                con.setData(query);
                this.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbBoxRoom.Text = "";
            cmbBoxSession1.Text = "";
            cmbBoxSession2.Text = "";
            txtBoxSelectedSession.Text = "";
        }

        public void loadData()
        {
            query = "SELECT roomName FROM rooms";
            DataSet ds = con.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                cmbBoxRoom.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            query = "SELECT s_id FROM session";
            DataSet ds1 = con.getData(query);
            for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                cmbBoxSession1.Items.Add(ds1.Tables[0].Rows[j][0].ToString());
            for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                cmbBoxSession2.Items.Add(ds1.Tables[0].Rows[j][0].ToString());

        }

        private void cmbBoxSession1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string session_id = cmbBoxSession1.SelectedItem.ToString();

            query = "SELECT * FROM session WHERE s_id = " + session_id + "";
            DataSet ds = con.getData(query);
            s1 = ds.Tables[0].Rows[0][10].ToString();
            txtBoxSelectedSession.Text = s1 + "\r\n" + s2 + "\r\n" + s3;
        }
    }
}
