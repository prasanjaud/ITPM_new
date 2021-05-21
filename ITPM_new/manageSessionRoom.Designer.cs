
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
            this.lblHeading = new System.Windows.Forms.Label();
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
        private System.Windows.Forms.Label lblHeading;
    }
}