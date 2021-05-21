﻿
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSession = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddSes = new System.Windows.Forms.Button();
            this.btnAddCon = new System.Windows.Forms.Button();
            this.dataGridViewConsecutive = new System.Windows.Forms.DataGridView();
            this.btnRefreshCon = new System.Windows.Forms.Button();
            this.btnRefreshSes = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsecutive)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(31, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 305);
            this.tabControl1.TabIndex = 29;
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
            // dataGridViewSession
            // 
            this.dataGridViewSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSession.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSession.Name = "dataGridViewSession";
            this.dataGridViewSession.Size = new System.Drawing.Size(723, 188);
            this.dataGridViewSession.TabIndex = 0;
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(723, 154);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Not Available Times";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // addLocationSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(120)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblHeading);
            this.Name = "addLocationSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Location Session";
            this.Load += new System.EventHandler(this.addLocationSession_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsecutive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewSession;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddSes;
        private System.Windows.Forms.Button btnAddCon;
        private System.Windows.Forms.DataGridView dataGridViewConsecutive;
        private System.Windows.Forms.Button btnRefreshSes;
        private System.Windows.Forms.Button btnRefreshCon;
    }
}