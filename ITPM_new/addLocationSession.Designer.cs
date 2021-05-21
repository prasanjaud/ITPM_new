
namespace ITPM_new
{
    partial class addLocationSession
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRefreshCon = new System.Windows.Forms.Button();
            this.btnAddCon = new System.Windows.Forms.Button();
            this.dataGridViewConsecutive = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefreshSes = new System.Windows.Forms.Button();
            this.btnAddSes = new System.Windows.Forms.Button();
            this.dataGridViewSession = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
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
            this.addRoomForSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsecutive)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeading.Location = new System.Drawing.Point(300, 27);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(246, 29);
            this.lblHeading.TabIndex = 28;
            this.lblHeading.Text = "Add Location Session";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRefreshCon);
            this.tabPage2.Controls.Add(this.btnAddCon);
            this.tabPage2.Controls.Add(this.dataGridViewConsecutive);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consecutive";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRefreshCon
            // 
            this.btnRefreshCon.BackColor = System.Drawing.Color.Teal;
            this.btnRefreshCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefreshCon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefreshCon.Location = new System.Drawing.Point(360, 235);
            this.btnRefreshCon.Name = "btnRefreshCon";
            this.btnRefreshCon.Size = new System.Drawing.Size(84, 26);
            this.btnRefreshCon.TabIndex = 27;
            this.btnRefreshCon.Text = "Refresh";
            this.btnRefreshCon.UseVisualStyleBackColor = false;
            this.btnRefreshCon.Click += new System.EventHandler(this.btnRefreshCon_Click);
            // 
            // btnAddCon
            // 
            this.btnAddCon.BackColor = System.Drawing.Color.Navy;
            this.btnAddCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCon.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAddCon.Location = new System.Drawing.Point(212, 235);
            this.btnAddCon.Name = "btnAddCon";
            this.btnAddCon.Size = new System.Drawing.Size(77, 26);
            this.btnAddCon.TabIndex = 26;
            this.btnAddCon.Text = "Add";
            this.btnAddCon.UseVisualStyleBackColor = false;
            this.btnAddCon.Click += new System.EventHandler(this.btnAddCon_Click);
            // 
            // dataGridViewConsecutive
            // 
            this.dataGridViewConsecutive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConsecutive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsecutive.Location = new System.Drawing.Point(0, 12);
            this.dataGridViewConsecutive.Name = "dataGridViewConsecutive";
            this.dataGridViewConsecutive.Size = new System.Drawing.Size(723, 188);
            this.dataGridViewConsecutive.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefreshSes);
            this.tabPage1.Controls.Add(this.btnAddSes);
            this.tabPage1.Controls.Add(this.dataGridViewSession);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sessions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefreshSes
            // 
            this.btnRefreshSes.BackColor = System.Drawing.Color.Teal;
            this.btnRefreshSes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshSes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefreshSes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefreshSes.Location = new System.Drawing.Point(376, 232);
            this.btnRefreshSes.Name = "btnRefreshSes";
            this.btnRefreshSes.Size = new System.Drawing.Size(84, 26);
            this.btnRefreshSes.TabIndex = 28;
            this.btnRefreshSes.Text = "Refresh";
            this.btnRefreshSes.UseVisualStyleBackColor = false;
            this.btnRefreshSes.Click += new System.EventHandler(this.btnRefreshSes_Click);
            // 
            // btnAddSes
            // 
            this.btnAddSes.BackColor = System.Drawing.Color.Navy;
            this.btnAddSes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddSes.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAddSes.Location = new System.Drawing.Point(234, 232);
            this.btnAddSes.Name = "btnAddSes";
            this.btnAddSes.Size = new System.Drawing.Size(77, 26);
            this.btnAddSes.TabIndex = 24;
            this.btnAddSes.Text = "Add";
            this.btnAddSes.UseVisualStyleBackColor = false;
            this.btnAddSes.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewSession
            // 
            this.dataGridViewSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSession.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSession.Name = "dataGridViewSession";
            this.dataGridViewSession.Size = new System.Drawing.Size(723, 188);
            this.dataGridViewSession.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(31, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 305);
            this.tabControl1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(157, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 20);
            this.button1.TabIndex = 29;
            this.button1.Text = "Not Available Time";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.menuStrip1.TabIndex = 31;
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
            this.manageLocationsToolStripMenuItem,
            this.addRoomForSessionToolStripMenuItem});
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.locationsToolStripMenuItem.Text = "Locations";
            this.locationsToolStripMenuItem.Click += new System.EventHandler(this.locationsToolStripMenuItem_Click);
            // 
            // addLocationsToolStripMenuItem
            // 
            this.addLocationsToolStripMenuItem.Name = "addLocationsToolStripMenuItem";
            this.addLocationsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addLocationsToolStripMenuItem.Text = "Add Locations";
            this.addLocationsToolStripMenuItem.Click += new System.EventHandler(this.addLocationsToolStripMenuItem_Click);
            // 
            // manageLocationsToolStripMenuItem
            // 
            this.manageLocationsToolStripMenuItem.Name = "manageLocationsToolStripMenuItem";
            this.manageLocationsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
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
            // advancedSessionsToolStripMenuItem
            // 
            this.advancedSessionsToolStripMenuItem.Name = "advancedSessionsToolStripMenuItem";
            this.advancedSessionsToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.advancedSessionsToolStripMenuItem.Text = "Advanced Sessions";
            // 
            // addRoomForSessionToolStripMenuItem
            // 
            this.addRoomForSessionToolStripMenuItem.Name = "addRoomForSessionToolStripMenuItem";
            this.addRoomForSessionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addRoomForSessionToolStripMenuItem.Text = "Add Room for Session";
            this.addRoomForSessionToolStripMenuItem.Click += new System.EventHandler(this.addRoomForSessionToolStripMenuItem_Click);
            // 
            // addLocationSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblHeading);
            this.Name = "addLocationSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Location Session";
            this.Load += new System.EventHandler(this.addLocationSession_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsecutive)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRefreshCon;
        private System.Windows.Forms.Button btnAddCon;
        private System.Windows.Forms.DataGridView dataGridViewConsecutive;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRefreshSes;
        private System.Windows.Forms.Button btnAddSes;
        private System.Windows.Forms.DataGridView dataGridViewSession;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.ToolStripMenuItem addRoomForSessionToolStripMenuItem;
    }
}