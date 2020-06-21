namespace StatsProgram
{
    partial class TeamDelete
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
            this.gbTeamInfo = new System.Windows.Forms.GroupBox();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.cbTeamName = new System.Windows.Forms.ComboBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.gbTeamInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTeamInfo
            // 
            this.gbTeamInfo.BackColor = System.Drawing.Color.Maroon;
            this.gbTeamInfo.Controls.Add(this.btnDeleteTeam);
            this.gbTeamInfo.Controls.Add(this.cbTeamName);
            this.gbTeamInfo.Controls.Add(this.lblTeamName);
            this.gbTeamInfo.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbTeamInfo.Location = new System.Drawing.Point(12, 12);
            this.gbTeamInfo.Name = "gbTeamInfo";
            this.gbTeamInfo.Size = new System.Drawing.Size(542, 139);
            this.gbTeamInfo.TabIndex = 1;
            this.gbTeamInfo.TabStop = false;
            this.gbTeamInfo.Text = "Team Information";
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeam.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteTeam.Location = new System.Drawing.Point(196, 81);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(136, 33);
            this.btnDeleteTeam.TabIndex = 16;
            this.btnDeleteTeam.Text = "Delete Team";
            this.btnDeleteTeam.UseVisualStyleBackColor = false;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // cbTeamName
            // 
            this.cbTeamName.FormattingEnabled = true;
            this.cbTeamName.Location = new System.Drawing.Point(250, 34);
            this.cbTeamName.Name = "cbTeamName";
            this.cbTeamName.Size = new System.Drawing.Size(196, 21);
            this.cbTeamName.TabIndex = 6;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTeamName.Location = new System.Drawing.Point(132, 35);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(85, 17);
            this.lblTeamName.TabIndex = 7;
            this.lblTeamName.Text = "Team Name";
            // 
            // TeamDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(564, 164);
            this.Controls.Add(this.gbTeamInfo);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "TeamDelete";
            this.Text = "TeamDelete";
            this.Load += new System.EventHandler(this.TeamDelete_Load);
            this.gbTeamInfo.ResumeLayout(false);
            this.gbTeamInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTeamInfo;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.ComboBox cbTeamName;
        private System.Windows.Forms.Label lblTeamName;
    }
}