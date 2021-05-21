
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
            this.grpBoxTab = new System.Windows.Forms.GroupBox();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnStudentGrp = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnWorkingDandH = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnTag = new System.Windows.Forms.Button();
            this.btnLecture = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpBoxTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectSession
            // 
            this.lblSelectSession.AutoSize = true;
            this.lblSelectSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelectSession.Location = new System.Drawing.Point(38, 148);
            this.lblSelectSession.Name = "lblSelectSession";
            this.lblSelectSession.Size = new System.Drawing.Size(144, 24);
            this.lblSelectSession.TabIndex = 16;
            this.lblSelectSession.Text = "Select Session :";
            // 
            // cmbBoxSession
            // 
            this.cmbBoxSession.FormattingEnabled = true;
            this.cmbBoxSession.Location = new System.Drawing.Point(195, 152);
            this.cmbBoxSession.Name = "cmbBoxSession";
            this.cmbBoxSession.Size = new System.Drawing.Size(126, 21);
            this.cmbBoxSession.TabIndex = 17;
            this.cmbBoxSession.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSession_SelectedIndexChanged);
            // 
            // cmbBoxRoom
            // 
            this.cmbBoxRoom.FormattingEnabled = true;
            this.cmbBoxRoom.Location = new System.Drawing.Point(594, 153);
            this.cmbBoxRoom.Name = "cmbBoxRoom";
            this.cmbBoxRoom.Size = new System.Drawing.Size(126, 21);
            this.cmbBoxRoom.TabIndex = 19;
            this.cmbBoxRoom.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRoom_SelectedIndexChanged);
            // 
            // lblSelectRoom
            // 
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelectRoom.Location = new System.Drawing.Point(416, 148);
            this.lblSelectRoom.Name = "lblSelectRoom";
            this.lblSelectRoom.Size = new System.Drawing.Size(128, 24);
            this.lblSelectRoom.TabIndex = 18;
            this.lblSelectRoom.Text = "Select Room :";
            // 
            // lblSelectedSession
            // 
            this.lblSelectedSession.AutoSize = true;
            this.lblSelectedSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelectedSession.Location = new System.Drawing.Point(297, 196);
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
            this.txtBoxSelectedSession.Location = new System.Drawing.Point(42, 233);
            this.txtBoxSelectedSession.Multiline = true;
            this.txtBoxSelectedSession.Name = "txtBoxSelectedSession";
            this.txtBoxSelectedSession.ReadOnly = true;
            this.txtBoxSelectedSession.Size = new System.Drawing.Size(678, 77);
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
            this.workingDaysAndHoursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 32;
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
            // grpBoxTab
            // 
            this.grpBoxTab.Controls.Add(this.btnLocation);
            this.grpBoxTab.Controls.Add(this.btnStatic);
            this.grpBoxTab.Controls.Add(this.btnStudentGrp);
            this.grpBoxTab.Controls.Add(this.btnSubject);
            this.grpBoxTab.Controls.Add(this.btnWorkingDandH);
            this.grpBoxTab.Controls.Add(this.btnSession);
            this.grpBoxTab.Controls.Add(this.btnTag);
            this.grpBoxTab.Controls.Add(this.btnLecture);
            this.grpBoxTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpBoxTab.ForeColor = System.Drawing.Color.Black;
            this.grpBoxTab.Location = new System.Drawing.Point(0, 39);
            this.grpBoxTab.Name = "grpBoxTab";
            this.grpBoxTab.Size = new System.Drawing.Size(785, 42);
            this.grpBoxTab.TabIndex = 33;
            this.grpBoxTab.TabStop = false;
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.Color.Gray;
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocation.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLocation.Location = new System.Drawing.Point(318, 6);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(108, 34);
            this.btnLocation.TabIndex = 7;
            this.btnLocation.Text = "Locations";
            this.btnLocation.UseVisualStyleBackColor = false;
            // 
            // btnStatic
            // 
            this.btnStatic.BackColor = System.Drawing.Color.Silver;
            this.btnStatic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatic.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStatic.Location = new System.Drawing.Point(420, 6);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(94, 33);
            this.btnStatic.TabIndex = 6;
            this.btnStatic.Text = "Statics";
            this.btnStatic.UseVisualStyleBackColor = false;
            // 
            // btnStudentGrp
            // 
            this.btnStudentGrp.BackColor = System.Drawing.Color.Silver;
            this.btnStudentGrp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudentGrp.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStudentGrp.Location = new System.Drawing.Point(70, 6);
            this.btnStudentGrp.Name = "btnStudentGrp";
            this.btnStudentGrp.Size = new System.Drawing.Size(114, 34);
            this.btnStudentGrp.TabIndex = 5;
            this.btnStudentGrp.Text = "Student Groups";
            this.btnStudentGrp.UseVisualStyleBackColor = false;
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.Silver;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubject.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubject.Location = new System.Drawing.Point(183, 6);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(74, 34);
            this.btnSubject.TabIndex = 4;
            this.btnSubject.Text = "Subjects";
            this.btnSubject.UseVisualStyleBackColor = false;
            // 
            // btnWorkingDandH
            // 
            this.btnWorkingDandH.BackColor = System.Drawing.Color.Silver;
            this.btnWorkingDandH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWorkingDandH.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnWorkingDandH.Location = new System.Drawing.Point(605, 6);
            this.btnWorkingDandH.Name = "btnWorkingDandH";
            this.btnWorkingDandH.Size = new System.Drawing.Size(180, 33);
            this.btnWorkingDandH.TabIndex = 3;
            this.btnWorkingDandH.Text = "Working Days and Hours";
            this.btnWorkingDandH.UseVisualStyleBackColor = false;
            // 
            // btnSession
            // 
            this.btnSession.BackColor = System.Drawing.Color.Silver;
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSession.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSession.Location = new System.Drawing.Point(510, 6);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(98, 33);
            this.btnSession.TabIndex = 2;
            this.btnSession.Text = "Sessions";
            this.btnSession.UseVisualStyleBackColor = false;
            // 
            // btnTag
            // 
            this.btnTag.BackColor = System.Drawing.Color.Silver;
            this.btnTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTag.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTag.Location = new System.Drawing.Point(256, 6);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(65, 34);
            this.btnTag.TabIndex = 1;
            this.btnTag.Text = "Tags";
            this.btnTag.UseVisualStyleBackColor = false;
            // 
            // btnLecture
            // 
            this.btnLecture.BackColor = System.Drawing.Color.Silver;
            this.btnLecture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLecture.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLecture.Location = new System.Drawing.Point(0, 6);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(80, 34);
            this.btnLecture.TabIndex = 0;
            this.btnLecture.Text = "Lectures";
            this.btnLecture.UseVisualStyleBackColor = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeading.Location = new System.Drawing.Point(268, 95);
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
            this.Controls.Add(this.grpBoxTab);
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
            this.grpBoxTab.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpBoxTab;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnStudentGrp;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnWorkingDandH;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnTag;
        private System.Windows.Forms.Button btnLecture;
        private System.Windows.Forms.Label lblHeading;
    }
}