namespace StatsProgram
{
    partial class RosterDelete
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
            this.gbRosterInfo = new System.Windows.Forms.GroupBox();
            this.cbRosterName = new System.Windows.Forms.ComboBox();
            this.btnDeleteRoster = new System.Windows.Forms.Button();
            this.lblRosterName = new System.Windows.Forms.Label();
            this.cbTeamName = new System.Windows.Forms.ComboBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.gbRosterInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRosterInfo
            // 
            this.gbRosterInfo.BackColor = System.Drawing.Color.Maroon;
            this.gbRosterInfo.Controls.Add(this.cbRosterName);
            this.gbRosterInfo.Controls.Add(this.btnDeleteRoster);
            this.gbRosterInfo.Controls.Add(this.lblRosterName);
            this.gbRosterInfo.Controls.Add(this.cbTeamName);
            this.gbRosterInfo.Controls.Add(this.lblTeamName);
            this.gbRosterInfo.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbRosterInfo.Location = new System.Drawing.Point(12, 12);
            this.gbRosterInfo.Name = "gbRosterInfo";
            this.gbRosterInfo.Size = new System.Drawing.Size(542, 191);
            this.gbRosterInfo.TabIndex = 1;
            this.gbRosterInfo.TabStop = false;
            this.gbRosterInfo.Text = "Roster Information";
            // 
            // cbRosterName
            // 
            this.cbRosterName.FormattingEnabled = true;
            this.cbRosterName.Location = new System.Drawing.Point(250, 87);
            this.cbRosterName.Name = "cbRosterName";
            this.cbRosterName.Size = new System.Drawing.Size(196, 21);
            this.cbRosterName.TabIndex = 17;
            // 
            // btnDeleteRoster
            // 
            this.btnDeleteRoster.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteRoster.Location = new System.Drawing.Point(193, 140);
            this.btnDeleteRoster.Name = "btnDeleteRoster";
            this.btnDeleteRoster.Size = new System.Drawing.Size(136, 33);
            this.btnDeleteRoster.TabIndex = 16;
            this.btnDeleteRoster.Text = "Delete Roster";
            this.btnDeleteRoster.UseVisualStyleBackColor = false;
            this.btnDeleteRoster.Click += new System.EventHandler(this.btnDeleteRoster_Click);
            // 
            // lblRosterName
            // 
            this.lblRosterName.AutoSize = true;
            this.lblRosterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRosterName.Location = new System.Drawing.Point(132, 91);
            this.lblRosterName.Name = "lblRosterName";
            this.lblRosterName.Size = new System.Drawing.Size(91, 17);
            this.lblRosterName.TabIndex = 8;
            this.lblRosterName.Text = "Roster Name";
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
            // RosterDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(567, 214);
            this.Controls.Add(this.gbRosterInfo);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "RosterDelete";
            this.Text = "RosterDelete";
            this.Load += new System.EventHandler(this.RosterDelete_Load);
            this.gbRosterInfo.ResumeLayout(false);
            this.gbRosterInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRosterInfo;
        private System.Windows.Forms.Button btnDeleteRoster;
        private System.Windows.Forms.Label lblRosterName;
        private System.Windows.Forms.ComboBox cbTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.ComboBox cbRosterName;
    }
}