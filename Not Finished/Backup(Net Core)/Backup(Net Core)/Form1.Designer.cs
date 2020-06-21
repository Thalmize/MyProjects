namespace Backup_Net_Core_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxDestination = new System.Windows.Forms.TextBox();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnStartBackup = new System.Windows.Forms.Button();
            this.txtbxResults = new System.Windows.Forms.TextBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destination";
            // 
            // txtbxDestination
            // 
            this.txtbxDestination.Enabled = false;
            this.txtbxDestination.Location = new System.Drawing.Point(138, 38);
            this.txtbxDestination.Name = "txtbxDestination";
            this.txtbxDestination.ReadOnly = true;
            this.txtbxDestination.Size = new System.Drawing.Size(203, 23);
            this.txtbxDestination.TabIndex = 5;
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(384, 31);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(120, 34);
            this.btnDestination.TabIndex = 1;
            this.btnDestination.Text = "Browse";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnStartBackup
            // 
            this.btnStartBackup.Location = new System.Drawing.Point(182, 94);
            this.btnStartBackup.Name = "btnStartBackup";
            this.btnStartBackup.Size = new System.Drawing.Size(194, 38);
            this.btnStartBackup.TabIndex = 2;
            this.btnStartBackup.Text = "Start";
            this.btnStartBackup.UseVisualStyleBackColor = true;
            this.btnStartBackup.Click += new System.EventHandler(this.btnStartBackup_Click);
            // 
            // txtbxResults
            // 
            this.txtbxResults.AcceptsReturn = true;
            this.txtbxResults.Location = new System.Drawing.Point(12, 163);
            this.txtbxResults.Multiline = true;
            this.txtbxResults.Name = "txtbxResults";
            this.txtbxResults.ReadOnly = true;
            this.txtbxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbxResults.Size = new System.Drawing.Size(544, 330);
            this.txtbxResults.TabIndex = 6;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(228, 145);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(0, 15);
            this.lblInformation.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(568, 506);
            this.Controls.Add(this.txtbxResults);
            this.Controls.Add(this.btnStartBackup);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.txtbxDestination);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxDestination;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnStartBackup;
        private System.Windows.Forms.TextBox txtbxResults;
        private System.Windows.Forms.Label lblInformation;
    }
}

