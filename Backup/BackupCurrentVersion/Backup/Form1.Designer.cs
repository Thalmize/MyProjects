namespace Backup
{
    partial class Form1
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
            this.txtbxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathBrowse = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxDestination = new System.Windows.Forms.TextBox();
            this.txtbxresults = new System.Windows.Forms.TextBox();
            this.btnStartBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxFilePath
            // 
            this.txtbxFilePath.Location = new System.Drawing.Point(90, 57);
            this.txtbxFilePath.Name = "txtbxFilePath";
            this.txtbxFilePath.ReadOnly = true;
            this.txtbxFilePath.Size = new System.Drawing.Size(195, 20);
            this.txtbxFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path: ";
            // 
            // FilePathBrowse
            // 
            this.FilePathBrowse.Location = new System.Drawing.Point(319, 52);
            this.FilePathBrowse.Name = "FilePathBrowse";
            this.FilePathBrowse.Size = new System.Drawing.Size(92, 28);
            this.FilePathBrowse.TabIndex = 2;
            this.FilePathBrowse.Text = "Browse";
            this.FilePathBrowse.UseVisualStyleBackColor = true;
            this.FilePathBrowse.Click += new System.EventHandler(this.FilePathBrowse_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(319, 113);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(92, 28);
            this.btnDestination.TabIndex = 5;
            this.btnDestination.Text = "Browse";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.BtnDestination_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination: ";
            // 
            // txtbxDestination
            // 
            this.txtbxDestination.Location = new System.Drawing.Point(90, 118);
            this.txtbxDestination.Name = "txtbxDestination";
            this.txtbxDestination.ReadOnly = true;
            this.txtbxDestination.Size = new System.Drawing.Size(195, 20);
            this.txtbxDestination.TabIndex = 3;
            // 
            // txtbxresults
            // 
            this.txtbxresults.Location = new System.Drawing.Point(12, 208);
            this.txtbxresults.Multiline = true;
            this.txtbxresults.Name = "txtbxresults";
            this.txtbxresults.ReadOnly = true;
            this.txtbxresults.Size = new System.Drawing.Size(462, 281);
            this.txtbxresults.TabIndex = 6;
            // 
            // btnStartBackup
            // 
            this.btnStartBackup.Location = new System.Drawing.Point(193, 174);
            this.btnStartBackup.Name = "btnStartBackup";
            this.btnStartBackup.Size = new System.Drawing.Size(92, 28);
            this.btnStartBackup.TabIndex = 5;
            this.btnStartBackup.Text = "Start";
            this.btnStartBackup.UseVisualStyleBackColor = true;
            this.btnStartBackup.Click += new System.EventHandler(this.BtnStartBackup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 501);
            this.Controls.Add(this.txtbxresults);
            this.Controls.Add(this.btnStartBackup);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxDestination);
            this.Controls.Add(this.FilePathBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilePathBrowse;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxDestination;
        private System.Windows.Forms.TextBox txtbxresults;
        private System.Windows.Forms.Button btnStartBackup;
    }
}

