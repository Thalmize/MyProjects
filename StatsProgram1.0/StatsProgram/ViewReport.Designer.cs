namespace StatsProgram
{
    partial class ViewReport
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
            this.gbGenRep = new System.Windows.Forms.GroupBox();
            this.btnTeamRep = new System.Windows.Forms.Button();
            this.btnGameRep = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbGenRep.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGenRep
            // 
            this.gbGenRep.Controls.Add(this.btnExit);
            this.gbGenRep.Controls.Add(this.btnGameRep);
            this.gbGenRep.Controls.Add(this.btnTeamRep);
            this.gbGenRep.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbGenRep.Location = new System.Drawing.Point(12, 12);
            this.gbGenRep.Name = "gbGenRep";
            this.gbGenRep.Size = new System.Drawing.Size(247, 311);
            this.gbGenRep.TabIndex = 0;
            this.gbGenRep.TabStop = false;
            this.gbGenRep.Text = "Report Options";
            // 
            // btnTeamRep
            // 
            this.btnTeamRep.BackColor = System.Drawing.Color.Maroon;
            this.btnTeamRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamRep.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnTeamRep.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTeamRep.Location = new System.Drawing.Point(22, 41);
            this.btnTeamRep.Name = "btnTeamRep";
            this.btnTeamRep.Size = new System.Drawing.Size(199, 66);
            this.btnTeamRep.TabIndex = 7;
            this.btnTeamRep.Text = "Team Report";
            this.btnTeamRep.UseVisualStyleBackColor = false;
            // 
            // btnGameRep
            // 
            this.btnGameRep.BackColor = System.Drawing.Color.Maroon;
            this.btnGameRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameRep.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnGameRep.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGameRep.Location = new System.Drawing.Point(22, 128);
            this.btnGameRep.Name = "btnGameRep";
            this.btnGameRep.Size = new System.Drawing.Size(199, 66);
            this.btnGameRep.TabIndex = 8;
            this.btnGameRep.Text = "Game Report";
            this.btnGameRep.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnExit.Location = new System.Drawing.Point(22, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(199, 66);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(271, 338);
            this.Controls.Add(this.gbGenRep);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "GenerateReport";
            this.Text = "GenerateReport";
            this.Load += new System.EventHandler(this.GenerateReport_Load);
            this.gbGenRep.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGenRep;
        private System.Windows.Forms.Button btnTeamRep;
        private System.Windows.Forms.Button btnGameRep;
        private System.Windows.Forms.Button btnExit;
    }
}