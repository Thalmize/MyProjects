namespace StatsProgram
{
    partial class ReportTxtArea
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
            this.txtOutputTeam = new System.Windows.Forms.TextBox();
            this.txtOutputIndOverall = new System.Windows.Forms.TextBox();
            this.txtOutputTeamOverall = new System.Windows.Forms.TextBox();
            this.txtOutputIndGame = new System.Windows.Forms.TextBox();
            this.txtOutputTeambyGame = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOutputTeam
            // 
            this.txtOutputTeam.AcceptsReturn = true;
            this.txtOutputTeam.AcceptsTab = true;
            this.txtOutputTeam.BackColor = System.Drawing.Color.Maroon;
            this.txtOutputTeam.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtOutputTeam.Location = new System.Drawing.Point(25, 28);
            this.txtOutputTeam.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputTeam.Multiline = true;
            this.txtOutputTeam.Name = "txtOutputTeam";
            this.txtOutputTeam.ReadOnly = true;
            this.txtOutputTeam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputTeam.Size = new System.Drawing.Size(60, 25);
            this.txtOutputTeam.TabIndex = 207;
            this.txtOutputTeam.Visible = false;
            // 
            // txtOutputIndOverall
            // 
            this.txtOutputIndOverall.AcceptsReturn = true;
            this.txtOutputIndOverall.AcceptsTab = true;
            this.txtOutputIndOverall.BackColor = System.Drawing.Color.Maroon;
            this.txtOutputIndOverall.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtOutputIndOverall.Location = new System.Drawing.Point(30, 194);
            this.txtOutputIndOverall.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputIndOverall.Multiline = true;
            this.txtOutputIndOverall.Name = "txtOutputIndOverall";
            this.txtOutputIndOverall.ReadOnly = true;
            this.txtOutputIndOverall.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputIndOverall.Size = new System.Drawing.Size(55, 23);
            this.txtOutputIndOverall.TabIndex = 208;
            this.txtOutputIndOverall.Visible = false;
            // 
            // txtOutputTeamOverall
            // 
            this.txtOutputTeamOverall.AcceptsReturn = true;
            this.txtOutputTeamOverall.AcceptsTab = true;
            this.txtOutputTeamOverall.BackColor = System.Drawing.Color.Maroon;
            this.txtOutputTeamOverall.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtOutputTeamOverall.Location = new System.Drawing.Point(30, 158);
            this.txtOutputTeamOverall.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputTeamOverall.Multiline = true;
            this.txtOutputTeamOverall.Name = "txtOutputTeamOverall";
            this.txtOutputTeamOverall.ReadOnly = true;
            this.txtOutputTeamOverall.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputTeamOverall.Size = new System.Drawing.Size(55, 23);
            this.txtOutputTeamOverall.TabIndex = 209;
            this.txtOutputTeamOverall.Visible = false;
            // 
            // txtOutputIndGame
            // 
            this.txtOutputIndGame.AcceptsReturn = true;
            this.txtOutputIndGame.AcceptsTab = true;
            this.txtOutputIndGame.BackColor = System.Drawing.Color.Maroon;
            this.txtOutputIndGame.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtOutputIndGame.Location = new System.Drawing.Point(30, 80);
            this.txtOutputIndGame.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputIndGame.Multiline = true;
            this.txtOutputIndGame.Name = "txtOutputIndGame";
            this.txtOutputIndGame.ReadOnly = true;
            this.txtOutputIndGame.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputIndGame.Size = new System.Drawing.Size(55, 21);
            this.txtOutputIndGame.TabIndex = 210;
            this.txtOutputIndGame.Visible = false;
            // 
            // txtOutputTeambyGame
            // 
            this.txtOutputTeambyGame.AcceptsReturn = true;
            this.txtOutputTeambyGame.AcceptsTab = true;
            this.txtOutputTeambyGame.BackColor = System.Drawing.Color.Maroon;
            this.txtOutputTeambyGame.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtOutputTeambyGame.Location = new System.Drawing.Point(30, 120);
            this.txtOutputTeambyGame.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutputTeambyGame.Multiline = true;
            this.txtOutputTeambyGame.Name = "txtOutputTeambyGame";
            this.txtOutputTeambyGame.ReadOnly = true;
            this.txtOutputTeambyGame.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputTeambyGame.Size = new System.Drawing.Size(55, 20);
            this.txtOutputTeambyGame.TabIndex = 211;
            this.txtOutputTeambyGame.Visible = false;
            // 
            // ReportTxtArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 256);
            this.Controls.Add(this.txtOutputIndOverall);
            this.Controls.Add(this.txtOutputTeamOverall);
            this.Controls.Add(this.txtOutputIndGame);
            this.Controls.Add(this.txtOutputTeambyGame);
            this.Controls.Add(this.txtOutputTeam);
            this.Name = "ReportTxtArea";
            this.Text = "ReportTxtArea";
            this.Load += new System.EventHandler(this.ReportTxtArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtOutputTeam;
        public System.Windows.Forms.TextBox txtOutputIndOverall;
        public System.Windows.Forms.TextBox txtOutputTeamOverall;
        public System.Windows.Forms.TextBox txtOutputIndGame;
        public System.Windows.Forms.TextBox txtOutputTeambyGame;
    }
}