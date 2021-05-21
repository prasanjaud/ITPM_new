
namespace ITPM_new
{
    partial class manageSessionRoom
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
            this.lblSelectSession = new System.Windows.Forms.Label();
            this.cmbBoxSession = new System.Windows.Forms.ComboBox();
            this.cmbBoxRoom = new System.Windows.Forms.ComboBox();
            this.lblSelectRoom = new System.Windows.Forms.Label();
            this.lblSelectedSession = new System.Windows.Forms.Label();
            this.txtBoxSelectedSession = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
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
            this.advancedSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeading = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectSession
            // 
            this.lblSelectSession.AutoSize = true;
            this.lblSelectSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelectSession.Location = new System.Drawing.Point(38, 126);
            this.lblSelectSession.Name = "lblSelectSession";
            this.lblSelectSession.Size = new System.Drawing.Size(144, 24);
            this.lblSelectSession.TabIndex = 16;
            this.lblSelectSession.Text = "Select Session :";
            // 
            // cmbBoxSession
            // 
            this.cmbBoxSession.FormattingEnabled = true;
            this.cmbBoxSession.Location = new System.Drawing.Point(195, 130);
            this.cmbBoxSession.Name = "cmbBoxSession";
            this.cmbBoxSession.Size = new System.Drawing.Size(126, 21);
            this.cmbBoxSession.TabIndex = 17;
            this.cmbBoxSession.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSession_SelectedIndexChanged);
            // 
            // cmbBoxRoom
            // 
            this.cmbBoxRoom.FormattingEnabled = true;
            this.cmbBoxRoom.Location = new System.Drawing.Point(594, 131);
            this.cmbBoxRoom.Name = "cmbBoxRoom";
            this.cmbBoxRoom.Size = new System.Drawing.Size(126, 21);
            this.cmbBoxRoom.TabIndex = 19;
            this.cmbBoxRoom.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRoom_SelectedIndexChanged);
            // 
            // lblSelectRoom
            // 
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelectRoom.Location = new System.Drawing.Point(416, 126);
            this.lblSelectRoom.Name = "lblSelectRoom";
            this.lblSelectRoom.Size = new System.Drawing.Size(128, 24);
            this.lblSelectRoom.TabIndex = 18;
            this.lblSelectRoom.Text = "Select Room :";
            // 
            // lblSelectedSession
            // 
            this.lblSelectedSession.AutoSize = true;
            this.lblSelectedSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelectedSession.Location = new System.Drawing.Point(297, 180);
            this.lblSelectedSession.Name = "lblSelectedSession";
            this.lblSelectedSession.Size = new System.Drawing.Size(156, 24);
            this.lblSelectedSession.TabIndex = 20;
            this.lblSelectedSession.Text = "Selected Session";
            // 
            // txtBoxSelectedSession
            // 
            this.txtBoxSelectedSession.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBoxSelectedSession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSelectedSession.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxSelectedSession.Location = new System.Drawing.Point(12, 229);
            this.txtBoxSelectedSession.Multiline = true;
            this.txtBoxSelectedSession.Name = "txtBoxSelectedSession";
            this.txtBoxSelectedSession.ReadOnly = true;
            this.txtBoxSelectedSession.Size = new System.Drawing.Size(761, 77);
            this.txtBoxSelectedSession.TabIndex = 25;
            this.txtBoxSelectedSession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSave.Location = new System.Drawing.Point(256, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 26);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Location = new System.Drawing.Point(450, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 26);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.workingDaysAndHoursToolStripMenuItem,
            this.advancedSessionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lecturesToolStripMenuItem
            // 
            this.lecturesToolStripMenuItem.Name = "lecturesToolStripMenuItem";
            this.lecturesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.lecturesToolStripMenuItem.Text = "Lectures";
            this.lecturesToolStripMenuItem.Click += new System.EventHandler(this.lecturesToolStripMenuItem_Click);
            // 
            // studentGroupsToolStripMenuItem
            // 
            this.studentGroupsToolStripMenuItem.Name = "studentGroupsToolStripMenuItem";
            this.studentGroupsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.studentGroupsToolStripMenuItem.Text = "Student Groups";
            this.studentGroupsToolStripMenuItem.Click += new System.EventHandler(this.studentGroupsToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            this.subjectsToolStripMenuItem.Click += new System.EventHandler(this.subjectsToolStripMenuItem_Click);
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tagsToolStripMenuItem.Text = "Tags";
            this.tagsToolStripMenuItem.Click += new System.EventHandler(this.tagsToolStripMenuItem_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocationsToolStripMenuItem,
            this.manageLocationsToolStripMenuItem});
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.locationsToolStripMenuItem.Text = "Locations";
            this.locationsToolStripMenuItem.Click += new System.EventHandler(this.locationsToolStripMenuItem_Click);
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
            this.staticsToolStripMenuItem.Click += new System.EventHandler(this.staticsToolStripMenuItem_Click);
            // 
            // sessionsToolStripMenuItem
            // 
            this.sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            this.sessionsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sessionsToolStripMenuItem.Text = "Sessions";
            this.sessionsToolStripMenuItem.Click += new System.EventHandler(this.sessionsToolStripMenuItem_Click);
            // 
            // workingDaysAndHoursToolStripMenuItem
            // 
            this.workingDaysAndHoursToolStripMenuItem.Name = "workingDaysAndHoursToolStripMenuItem";
            this.workingDaysAndHoursToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.workingDaysAndHoursToolStripMenuItem.Text = "Working Days and Hours";
            this.workingDaysAndHoursToolStripMenuItem.Click += new System.EventHandler(this.workingDaysAndHoursToolStripMenuItem_Click);
            // 
            // advancedSessionsToolStripMenuItem
            // 
            this.advancedSessionsToolStripMenuItem.Checked = true;
            this.advancedSessionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.advancedSessionsToolStripMenuItem.Name = "advancedSessionsToolStripMenuItem";
            this.advancedSessionsToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.advancedSessionsToolStripMenuItem.Text = "Advanced Sessions";
            this.advancedSessionsToolStripMenuItem.Click += new System.EventHandler(this.advancedSessionsToolStripMenuItem_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeading.Location = new System.Drawing.Point(268, 58);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(276, 29);
            this.lblHeading.TabIndex = 34;
            this.lblHeading.Text = "Manage Session Rooms";
            // 
            // manageSessionRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(785, 388);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxSelectedSession);
            this.Controls.Add(this.lblSelectedSession);
            this.Controls.Add(this.cmbBoxRoom);
            this.Controls.Add(this.lblSelectRoom);
            this.Controls.Add(this.cmbBoxSession);
            this.Controls.Add(this.lblSelectSession);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "manageSessionRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Session Room";
            this.Load += new System.EventHandler(this.manageSessionRoom_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectSession;
        private System.Windows.Forms.ComboBox cmbBoxSession;
        private System.Windows.Forms.ComboBox cmbBoxRoom;
        private System.Windows.Forms.Label lblSelectRoom;
        private System.Windows.Forms.Label lblSelectedSession;
        private System.Windows.Forms.TextBox txtBoxSelectedSession;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
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
        private System.Windows.Forms.ToolStripMenuItem advancedSessionsToolStripMenuItem;
        private System.Windows.Forms.Label lblHeading;
    }
}