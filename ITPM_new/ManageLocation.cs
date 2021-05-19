﻿using System;
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
    public partial class ManageLocation : Form
    {
        dbConnection con = new dbConnection();
        String query;
        String room_Type;

        public ManageLocation()
        {
            InitializeComponent();
        }

        private void manageLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLocation form2 = new ManageLocation();
            form2.Show();
        }

        private void addLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLocation f1 = new AddLocation();
            f1.Show();
        }

        private void ManageLocation_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "SELECT * FROM rooms";
            DataSet ds = con.getData(query);
            dataGridViewRoom.DataSource = ds.Tables[0];
        }

        int id;
        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridViewRoom.Rows[e.RowIndex].Cells[0].Value.ToString());
            String buildingName = dataGridViewRoom.Rows[e.RowIndex].Cells[1].Value.ToString();
            String roomName = dataGridViewRoom.Rows[e.RowIndex].Cells[2].Value.ToString();
            String roomType = dataGridViewRoom.Rows[e.RowIndex].Cells[3].Value.ToString();
            int capacity = int.Parse(dataGridViewRoom.Rows[e.RowIndex].Cells[4].Value.ToString());

            txtBuildingName.Text = buildingName;
            txtRoomName.Text = roomName;
            txtCapacity.Text = capacity.ToString();

            if (roomType == "Lecture Hall")
            {
                rdBtnLectureHall.Checked = true;
            }
            else
            {
                rdBtnLaboratory.Checked = true;
            }
        }

        private void rdBtnLectureHall_CheckedChanged(object sender, EventArgs e)
        {
            room_Type = "Lecture Hall";
        }

        private void rdBtnLaboratory_CheckedChanged(object sender, EventArgs e)
        {
            room_Type = "Laboratory";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "UPDATE rooms SET buildingName='" + txtBuildingName.Text + "',roomName='" + txtRoomName.Text + "',roomType='" + room_Type + "',capacity=" + txtCapacity.Text + " WHERE id=" + id + "";
            con.setData(query);
            loadData();
            ClearAll();
        }

        public void ClearAll()
        {
            txtBuildingName.Clear();
            txtRoomName.Clear();
            txtCapacity.Clear();
            rdBtnLaboratory.Checked = false;
            rdBtnLectureHall.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBuildingName.Text != "")
            {
                if (MessageBox.Show("Delete room?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    query = "DELETE FROM rooms WHERE id=" + id + "";
                    con.setData(query);
                    loadData();
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("Please Select Row!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
