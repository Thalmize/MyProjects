namespace StatsProgram
{
    partial class RosterManagement
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
            this.lblSelectRoster = new System.Windows.Forms.Label();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.gbRoster = new System.Windows.Forms.GroupBox();
            this.btnShowRoster = new System.Windows.Forms.Button();
            this.btnShowTeam = new System.Windows.Forms.Button();
            this.btnlbclear = new System.Windows.Forms.Button();
            this.gbFunctions = new System.Windows.Forms.GroupBox();
            this.btnDeleteRoster = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnModifyPlayer = new System.Windows.Forms.Button();
            this.bxTeamRoster = new System.Windows.Forms.GroupBox();
            this.lbTeamRoster = new System.Windows.Forms.ListBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.txtbxSelRoster = new System.Windows.Forms.TextBox();
            this.txtbxSelTeam = new System.Windows.Forms.TextBox();
            this.gbRoster.SuspendLayout();
            this.gbFunctions.SuspendLayout();
            this.bxTeamRoster.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectRoster
            // 
            this.lblSelectRoster.AutoSize = true;
            this.lblSelectRoster.Location = new System.Drawing.Point(91, 80);
            this.lblSelectRoster.Name = "lblSelectRoster";
            this.lblSelectRoster.Size = new System.Drawing.Size(71, 13);
            this.lblSelectRoster.TabIndex = 7;
            this.lblSelectRoster.Text = "Select Roster";
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Location = new System.Drawing.Point(91, 22);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(67, 13);
            this.lblSelectTeam.TabIndex = 5;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // gbRoster
            // 
            this.gbRoster.Controls.Add(this.txtbxSelTeam);
            this.gbRoster.Controls.Add(this.txtbxSelRoster);
            this.gbRoster.Controls.Add(this.btnShowRoster);
            this.gbRoster.Controls.Add(this.btnShowTeam);
            this.gbRoster.Controls.Add(this.btnlbclear);
            this.gbRoster.Controls.Add(this.lblSelectRoster);
            this.gbRoster.Controls.Add(this.lblSelectTeam);
            this.gbRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbRoster.Location = new System.Drawing.Point(226, 12);
            this.gbRoster.Name = "gbRoster";
            this.gbRoster.Size = new System.Drawing.Size(252, 217);
            this.gbRoster.TabIndex = 8;
            this.gbRoster.TabStop = false;
            this.gbRoster.Text = "Roster";
            // 
            // btnShowRoster
            // 
            this.btnShowRoster.BackColor = System.Drawing.Color.Maroon;
            this.btnShowRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnShowRoster.Location = new System.Drawing.Point(123, 131);
            this.btnShowRoster.Name = "btnShowRoster";
            this.btnShowRoster.Size = new System.Drawing.Size(125, 33);
            this.btnShowRoster.TabIndex = 11;
            this.btnShowRoster.Text = "Show Roster";
            this.btnShowRoster.UseVisualStyleBackColor = false;
            this.btnShowRoster.Click += new System.EventHandler(this.btnShowRoster_Click);
            // 
            // btnShowTeam
            // 
            this.btnShowTeam.BackColor = System.Drawing.Color.Maroon;
            this.btnShowTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTeam.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnShowTeam.Location = new System.Drawing.Point(3, 131);
            this.btnShowTeam.Name = "btnShowTeam";
            this.btnShowTeam.Size = new System.Drawing.Size(117, 33);
            this.btnShowTeam.TabIndex = 10;
            this.btnShowTeam.Text = "Show Team";
            this.btnShowTeam.UseVisualStyleBackColor = false;
            this.btnShowTeam.Click += new System.EventHandler(this.btnShowTeam_Click);
            // 
            // btnlbclear
            // 
            this.btnlbclear.BackColor = System.Drawing.Color.Maroon;
            this.btnlbclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlbclear.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnlbclear.Location = new System.Drawing.Point(92, 170);
            this.btnlbclear.Name = "btnlbclear";
            this.btnlbclear.Size = new System.Drawing.Size(66, 33);
            this.btnlbclear.TabIndex = 9;
            this.btnlbclear.Text = "Clear";
            this.btnlbclear.UseVisualStyleBackColor = false;
            this.btnlbclear.Click += new System.EventHandler(this.btnlbclear_Click);
            // 
            // gbFunctions
            // 
            this.gbFunctions.Controls.Add(this.btnDeleteRoster);
            this.gbFunctions.Controls.Add(this.btnDeleteTeam);
            this.gbFunctions.Controls.Add(this.btnAddTeam);
            this.gbFunctions.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbFunctions.Location = new System.Drawing.Point(13, 12);
            this.gbFunctions.Name = "gbFunctions";
            this.gbFunctions.Size = new System.Drawing.Size(200, 217);
            this.gbFunctions.TabIndex = 9;
            this.gbFunctions.TabStop = false;
            this.gbFunctions.Text = "Functions";
            // 
            // btnDeleteRoster
            // 
            this.btnDeleteRoster.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteRoster.Location = new System.Drawing.Point(31, 149);
            this.btnDeleteRoster.Name = "btnDeleteRoster";
            this.btnDeleteRoster.Size = new System.Drawing.Size(136, 33);
            this.btnDeleteRoster.TabIndex = 5;
            this.btnDeleteRoster.Text = "Delete Roster";
            this.btnDeleteRoster.UseVisualStyleBackColor = false;
            this.btnDeleteRoster.Click += new System.EventHandler(this.btnDeleteRoster_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeam.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteTeam.Location = new System.Drawing.Point(31, 94);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(136, 33);
            this.btnDeleteTeam.TabIndex = 4;
            this.btnDeleteTeam.Text = "Delete Team";
            this.btnDeleteTeam.UseVisualStyleBackColor = false;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BackColor = System.Drawing.Color.Maroon;
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAddTeam.Location = new System.Drawing.Point(31, 40);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(136, 33);
            this.btnAddTeam.TabIndex = 0;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnModifyPlayer
            // 
            this.btnModifyPlayer.BackColor = System.Drawing.Color.Maroon;
            this.btnModifyPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyPlayer.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnModifyPlayer.Location = new System.Drawing.Point(272, 221);
            this.btnModifyPlayer.Name = "btnModifyPlayer";
            this.btnModifyPlayer.Size = new System.Drawing.Size(136, 33);
            this.btnModifyPlayer.TabIndex = 3;
            this.btnModifyPlayer.Text = "Modify Player";
            this.btnModifyPlayer.UseVisualStyleBackColor = false;
            this.btnModifyPlayer.Click += new System.EventHandler(this.btnModifyPlayer_Click);
            // 
            // bxTeamRoster
            // 
            this.bxTeamRoster.Controls.Add(this.lbTeamRoster);
            this.bxTeamRoster.Controls.Add(this.btnAddPlayer);
            this.bxTeamRoster.Controls.Add(this.btnModifyPlayer);
            this.bxTeamRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.bxTeamRoster.Location = new System.Drawing.Point(13, 235);
            this.bxTeamRoster.Name = "bxTeamRoster";
            this.bxTeamRoster.Size = new System.Drawing.Size(465, 272);
            this.bxTeamRoster.TabIndex = 10;
            this.bxTeamRoster.TabStop = false;
            this.bxTeamRoster.Text = "Team Roster";
            // 
            // lbTeamRoster
            // 
            this.lbTeamRoster.BackColor = System.Drawing.Color.Maroon;
            this.lbTeamRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbTeamRoster.FormattingEnabled = true;
            this.lbTeamRoster.ItemHeight = 25;
            this.lbTeamRoster.Location = new System.Drawing.Point(6, 20);
            this.lbTeamRoster.Name = "lbTeamRoster";
            this.lbTeamRoster.Size = new System.Drawing.Size(453, 179);
            this.lbTeamRoster.TabIndex = 5;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.BackColor = System.Drawing.Color.Maroon;
            this.btnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAddPlayer.Location = new System.Drawing.Point(64, 221);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(136, 33);
            this.btnAddPlayer.TabIndex = 4;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // txtbxSelRoster
            // 
            this.txtbxSelRoster.BackColor = System.Drawing.Color.Maroon;
            this.txtbxSelRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSelRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtbxSelRoster.Location = new System.Drawing.Point(31, 98);
            this.txtbxSelRoster.Name = "txtbxSelRoster";
            this.txtbxSelRoster.ReadOnly = true;
            this.txtbxSelRoster.Size = new System.Drawing.Size(188, 20);
            this.txtbxSelRoster.TabIndex = 124;
            // 
            // txtbxSelTeam
            // 
            this.txtbxSelTeam.BackColor = System.Drawing.Color.Maroon;
            this.txtbxSelTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSelTeam.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtbxSelTeam.Location = new System.Drawing.Point(33, 40);
            this.txtbxSelTeam.Name = "txtbxSelTeam";
            this.txtbxSelTeam.ReadOnly = true;
            this.txtbxSelTeam.Size = new System.Drawing.Size(186, 20);
            this.txtbxSelTeam.TabIndex = 125;
            // 
            // RosterManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(490, 519);
            this.Controls.Add(this.bxTeamRoster);
            this.Controls.Add(this.gbFunctions);
            this.Controls.Add(this.gbRoster);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "RosterManagement";
            this.Text = "RosterManagement";
            this.Load += new System.EventHandler(this.RosterManagement_Load);
            this.gbRoster.ResumeLayout(false);
            this.gbRoster.PerformLayout();
            this.gbFunctions.ResumeLayout(false);
            this.bxTeamRoster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSelectRoster;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.GroupBox gbRoster;
        private System.Windows.Forms.GroupBox gbFunctions;
        private System.Windows.Forms.GroupBox bxTeamRoster;
        private System.Windows.Forms.Button btnModifyPlayer;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnDeleteRoster;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.ListBox lbTeamRoster;
        private System.Windows.Forms.Button btnlbclear;
        private System.Windows.Forms.Button btnShowTeam;
        private System.Windows.Forms.Button btnShowRoster;
        private System.Windows.Forms.TextBox txtbxSelTeam;
        private System.Windows.Forms.TextBox txtbxSelRoster;
    }
}