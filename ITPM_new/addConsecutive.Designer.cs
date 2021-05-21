
namespace ITPM_new
{
    partial class addConsecutive
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBoxSelectedSession = new System.Windows.Forms.TextBox();
            this.lblSelectedSession = new System.Windows.Forms.Label();
            this.cmbBoxRoom = new System.Windows.Forms.ComboBox();
            this.lblSelectRoom = new System.Windows.Forms.Label();
            this.cmbBoxSession1 = new System.Windows.Forms.ComboBox();
            this.lblSelectSession1 = new System.Windows.Forms.Label();
            this.cmbBoxSession2 = new System.Windows.Forms.ComboBox();
            this.lblSelectSession2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHeading.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeading.Location = new System.Drawing.Point(253, 58);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(321, 29);
            this.lblHeading.TabIndex = 43;
            this.lblHeading.Text = "Manage Consecutive Rooms";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSave.Location = new System.Drawing.Point(270, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 26);
            this.btnSave.TabIndex = 41;
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
            this.btnClear.Location = new System.Drawing.Point(463, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 26);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBoxSelectedSession
            // 
            this.txtBoxSelectedSession.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBoxSelectedSession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSelectedSession.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxSelectedSession.Location = new System.Drawing.Point(55, 221);
            this.txtBoxSelectedSession.Multiline = true;
            this.txtBoxSelectedSession.Name = "txtBoxSelectedSession";
            this.txtBoxSelectedSession.ReadOnly = true;
            this.txtBoxSelectedSession.Size = new System.Drawing.Size(678, 77);
            this.txtBoxSelectedSession.TabIndex = 42;
            this.txtBoxSelectedSession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSelectedSession
            // 
            this.lblSelectedSession.AutoSize = true;
            this.lblSelectedSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelectedSession.Location = new System.Drawing.Point(317, 194);
            this.lblSelectedSession.Name = "lblSelectedSession";
            this.lblSelectedSession.Size = new System.Drawing.Size(156, 24);
            this.lblSelectedSession.TabIndex = 39;
            this.lblSelectedSession.Text = "Selected Session";
            // 
            // cmbBoxRoom
            // 
            this.cmbBoxRoom.FormattingEnabled = true;
            this.cmbBoxRoom.Location = new System.Drawing.Point(414, 152);
            this.cmbBoxRoom.Name = "cmbBoxRoom";
            this.cmbBoxRoom.Size = new System.Drawing.Size(126, 21);
            this.cmbBoxRoom.TabIndex = 38;
            this.cmbBoxRoom.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRoom_SelectedIndexChanged);
            // 
            // lblSelectRoom
            // 
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelectRoom.Location = new System.Drawing.Point(254, 152);
            this.lblSelectRoom.Name = "lblSelectRoom";
            this.lblSelectRoom.Size = new System.Drawing.Size(128, 24);
            this.lblSelectRoom.TabIndex = 37;
            this.lblSelectRoom.Text = "Select Room :";
            // 
            // cmbBoxSession1
            // 
            this.cmbBoxSession1.FormattingEnabled = true;
            this.cmbBoxSession1.Location = new System.Drawing.Point(258, 112);
            this.cmbBoxSession1.Name = "cmbBoxSession1";
            this.cmbBoxSession1.Size = new System.Drawing.Size(99, 21);
            this.cmbBoxSession1.TabIndex = 36;
            this.cmbBoxSession1.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSession1_SelectedIndexChanged);
            // 
            // lblSelectSession1
            // 
            this.lblSelectSession1.AutoSize = true;
            this.lblSelectSession1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelectSession1.Location = new System.Drawing.Point(77, 112);
            this.lblSelectSession1.Name = "lblSelectSession1";
            this.lblSelectSession1.Size = new System.Drawing.Size(159, 24);
            this.lblSelectSession1.TabIndex = 35;
            this.lblSelectSession1.Text = "Select Session 1 :";
            // 
            // cmbBoxSession2
            // 
            this.cmbBoxSession2.FormattingEnabled = true;
            this.cmbBoxSession2.Location = new System.Drawing.Point(572, 112);
            this.cmbBoxSession2.Name = "cmbBoxSession2";
            this.cmbBoxSession2.Size = new System.Drawing.Size(99, 21);
            this.cmbBoxSession2.TabIndex = 45;
            this.cmbBoxSession2.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSession2_SelectedIndexChanged);
            // 
            // lblSelectSession2
            // 
            this.lblSelectSession2.AutoSize = true;
            this.lblSelectSession2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelectSession2.Location = new System.Drawing.Point(407, 112);
            this.lblSelectSession2.Name = "lblSelectSession2";
            this.lblSelectSession2.Size = new System.Drawing.Size(159, 24);
            this.lblSelectSession2.TabIndex = 44;
            this.lblSelectSession2.Text = "Select Session 2 :";
            // 
            // addConsecutive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(785, 388);
            this.Controls.Add(this.cmbBoxSession2);
            this.Controls.Add(this.lblSelectSession2);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxSelectedSession);
            this.Controls.Add(this.lblSelectedSession);
            this.Controls.Add(this.cmbBoxRoom);
            this.Controls.Add(this.lblSelectRoom);
            this.Controls.Add(this.cmbBoxSession1);
            this.Controls.Add(this.lblSelectSession1);
            this.Name = "addConsecutive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addConsecutive";
            this.Load += new System.EventHandler(this.addConsecutive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBoxSelectedSession;
        private System.Windows.Forms.Label lblSelectedSession;
        private System.Windows.Forms.ComboBox cmbBoxRoom;
        private System.Windows.Forms.Label lblSelectRoom;
        private System.Windows.Forms.ComboBox cmbBoxSession1;
        private System.Windows.Forms.Label lblSelectSession1;
        private System.Windows.Forms.ComboBox cmbBoxSession2;
        private System.Windows.Forms.Label lblSelectSession2;
    }
}