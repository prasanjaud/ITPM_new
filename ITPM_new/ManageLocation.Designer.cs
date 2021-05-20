
namespace ITPM_new
{
    partial class ManageLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdBtnLaboratory = new System.Windows.Forms.RadioButton();
            this.rdBtnLectureHall = new System.Windows.Forms.RadioButton();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lecturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workingDaysAndHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(432, 293);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 26);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(674, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 26);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdBtnLaboratory
            // 
            this.rdBtnLaboratory.AutoSize = true;
            this.rdBtnLaboratory.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.rdBtnLaboratory.Location = new System.Drawing.Point(637, 341);
            this.rdBtnLaboratory.Name = "rdBtnLaboratory";
            this.rdBtnLaboratory.Size = new System.Drawing.Size(114, 32);
            this.rdBtnLaboratory.TabIndex = 21;
            this.rdBtnLaboratory.Text = "Laboratory";
            this.rdBtnLaboratory.UseVisualStyleBackColor = true;
            this.rdBtnLaboratory.CheckedChanged += new System.EventHandler(this.rdBtnLaboratory_CheckedChanged);
            // 
            // rdBtnLectureHall
            // 
            this.rdBtnLectureHall.AutoSize = true;
            this.rdBtnLectureHall.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.rdBtnLectureHall.Location = new System.Drawing.Point(489, 341);
            this.rdBtnLectureHall.Name = "rdBtnLectureHall";
            this.rdBtnLectureHall.Size = new System.Drawing.Size(124, 32);
            this.rdBtnLectureHall.TabIndex = 20;
            this.rdBtnLectureHall.Text = "Lecture Hall";
            this.rdBtnLectureHall.UseVisualStyleBackColor = true;
            this.rdBtnLectureHall.CheckedChanged += new System.EventHandler(this.rdBtnLectureHall_CheckedChanged);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(490, 396);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(233, 20);
            this.txtCapacity.TabIndex = 19;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(166, 396);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(172, 20);
            this.txtRoomName.TabIndex = 18;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(166, 346);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(172, 20);
            this.txtBuildingName.TabIndex = 17;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCapacity.Location = new System.Drawing.Point(365, 396);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(91, 24);
            this.lblCapacity.TabIndex = 16;
            this.lblCapacity.Text = "Capacity :";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRoomType.Location = new System.Drawing.Point(365, 343);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(119, 24);
            this.lblRoomType.TabIndex = 15;
            this.lblRoomType.Text = "Room Type :";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRoomName.Location = new System.Drawing.Point(16, 396);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(127, 24);
            this.lblRoomName.TabIndex = 14;
            this.lblRoomName.Text = "Room Name :";
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblBuildingName.Location = new System.Drawing.Point(16, 346);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(144, 24);
            this.lblBuildingName.TabIndex = 13;
            this.lblBuildingName.Text = "Building Name :";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRoom.Location = new System.Drawing.Point(14, 84);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.RowTemplate.Height = 25;
            this.dataGridViewRoom.Size = new System.Drawing.Size(757, 191);
            this.dataGridViewRoom.TabIndex = 24;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(556, 293);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 26);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeading.Location = new System.Drawing.Point(16, 43);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(183, 29);
            this.lblHeading.TabIndex = 27;
            this.lblHeading.Text = "Manage Rooms";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecturesToolStripMenuItem,
            this.studentGroupsToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.tagsToolStripMenuItem,
            this.locationsToolStripMenuItem,
            this.staticsToolStripMenuItem,
            this.sessionsToolStripMenuItem,
            this.workingDaysAndHoursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lecturesToolStripMenuItem
            // 
            this.lecturesToolStripMenuItem.Name = "lecturesToolStripMenuItem";
            this.lecturesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.lecturesToolStripMenuItem.Text = "Lectures";
            // 
            // studentGroupsToolStripMenuItem
            // 
            this.studentGroupsToolStripMenuItem.Name = "studentGroupsToolStripMenuItem";
            this.studentGroupsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.studentGroupsToolStripMenuItem.Text = "Student Groups";
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tagsToolStripMenuItem.Text = "Tags";
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocationsToolStripMenuItem,
            this.manageLocationsToolStripMenuItem});
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.locationsToolStripMenuItem.Text = "Locations";
            // 
            // addLocationsToolStripMenuItem
            // 
            this.addLocationsToolStripMenuItem.Name = "addLocationsToolStripMenuItem";
            this.addLocationsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addLocationsToolStripMenuItem.Text = "Add Locations";
            this.addLocationsToolStripMenuItem.Click += new System.EventHandler(this.addLocationsToolStripMenuItem_Click);
            // 
            // manageLocationsToolStripMenuItem
            // 
            this.manageLocationsToolStripMenuItem.Name = "manageLocationsToolStripMenuItem";
            this.manageLocationsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.manageLocationsToolStripMenuItem.Text = "Manage Locations";
            this.manageLocationsToolStripMenuItem.Click += new System.EventHandler(this.manageLocationsToolStripMenuItem_Click);
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.staticsToolStripMenuItem.Text = "Statics";
            // 
            // sessionsToolStripMenuItem
            // 
            this.sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            this.sessionsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sessionsToolStripMenuItem.Text = "Sessions";
            // 
            // workingDaysAndHoursToolStripMenuItem
            // 
            this.workingDaysAndHoursToolStripMenuItem.Name = "workingDaysAndHoursToolStripMenuItem";
            this.workingDaysAndHoursToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.workingDaysAndHoursToolStripMenuItem.Text = "Working Days and Hours";
            // 
            // ManageLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rdBtnLaboratory);
            this.Controls.Add(this.rdBtnLectureHall);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.lblBuildingName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Location";
            this.Load += new System.EventHandler(this.ManageLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdBtnLaboratory;
        private System.Windows.Forms.RadioButton rdBtnLectureHall;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lecturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workingDaysAndHoursToolStripMenuItem;
    }
}