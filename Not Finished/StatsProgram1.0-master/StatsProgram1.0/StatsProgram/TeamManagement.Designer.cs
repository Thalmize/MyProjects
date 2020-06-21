namespace StatsProgram
{
    partial class TeamManagement
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
            this.components = new System.ComponentModel.Container();
            this.lblTeamTeam = new System.Windows.Forms.Label();
            this.txtbxTeam = new System.Windows.Forms.TextBox();
            this.gbFunctions = new System.Windows.Forms.GroupBox();
            this.btnOpenRoster = new System.Windows.Forms.Button();
            this.btnAddRoster = new System.Windows.Forms.Button();
            this.btnOpenTeam = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.bxTeamRoster = new System.Windows.Forms.GroupBox();
            this.txtbxPlayerRoster = new System.Windows.Forms.TextBox();
            this.TimerShowBottom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PageTimer = new System.Windows.Forms.Timer(this.components);
            this.gbFunctions.SuspendLayout();
            this.bxTeamRoster.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTeamTeam
            // 
            this.lblTeamTeam.AutoSize = true;
            this.lblTeamTeam.Location = new System.Drawing.Point(440, 24);
            this.lblTeamTeam.Name = "lblTeamTeam";
            this.lblTeamTeam.Size = new System.Drawing.Size(65, 13);
            this.lblTeamTeam.TabIndex = 5;
            this.lblTeamTeam.Text = "Team Name";
            // 
            // txtbxTeam
            // 
            this.txtbxTeam.BackColor = System.Drawing.Color.Maroon;
            this.txtbxTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTeam.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtbxTeam.Location = new System.Drawing.Point(238, 52);
            this.txtbxTeam.Name = "txtbxTeam";
            this.txtbxTeam.ReadOnly = true;
            this.txtbxTeam.Size = new System.Drawing.Size(465, 20);
            this.txtbxTeam.TabIndex = 125;
            // 
            // gbFunctions
            // 
            this.gbFunctions.Controls.Add(this.btnOpenRoster);
            this.gbFunctions.Controls.Add(this.btnAddRoster);
            this.gbFunctions.Controls.Add(this.btnOpenTeam);
            this.gbFunctions.Controls.Add(this.btnAddTeam);
            this.gbFunctions.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbFunctions.Location = new System.Drawing.Point(13, 12);
            this.gbFunctions.Name = "gbFunctions";
            this.gbFunctions.Size = new System.Drawing.Size(200, 587);
            this.gbFunctions.TabIndex = 9;
            this.gbFunctions.TabStop = false;
            this.gbFunctions.Text = "Functions";
            // 
            // btnOpenRoster
            // 
            this.btnOpenRoster.BackColor = System.Drawing.Color.Maroon;
            this.btnOpenRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnOpenRoster.Location = new System.Drawing.Point(31, 452);
            this.btnOpenRoster.Name = "btnOpenRoster";
            this.btnOpenRoster.Size = new System.Drawing.Size(136, 71);
            this.btnOpenRoster.TabIndex = 5;
            this.btnOpenRoster.Text = "Open Roster";
            this.btnOpenRoster.UseVisualStyleBackColor = false;
            this.btnOpenRoster.Click += new System.EventHandler(this.btnOpenRoster_Click);
            // 
            // btnAddRoster
            // 
            this.btnAddRoster.BackColor = System.Drawing.Color.Maroon;
            this.btnAddRoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAddRoster.Location = new System.Drawing.Point(31, 305);
            this.btnAddRoster.Name = "btnAddRoster";
            this.btnAddRoster.Size = new System.Drawing.Size(136, 71);
            this.btnAddRoster.TabIndex = 3;
            this.btnAddRoster.Text = "Add Roster";
            this.btnAddRoster.UseVisualStyleBackColor = false;
            this.btnAddRoster.Click += new System.EventHandler(this.btnAddRoster_Click);
            // 
            // btnOpenTeam
            // 
            this.btnOpenTeam.BackColor = System.Drawing.Color.Maroon;
            this.btnOpenTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTeam.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnOpenTeam.Location = new System.Drawing.Point(31, 165);
            this.btnOpenTeam.Name = "btnOpenTeam";
            this.btnOpenTeam.Size = new System.Drawing.Size(136, 71);
            this.btnOpenTeam.TabIndex = 4;
            this.btnOpenTeam.Text = "Open Team";
            this.btnOpenTeam.UseVisualStyleBackColor = false;
            this.btnOpenTeam.Click += new System.EventHandler(this.btnOpenTeam_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BackColor = System.Drawing.Color.Maroon;
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAddTeam.Location = new System.Drawing.Point(31, 40);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(136, 71);
            this.btnAddTeam.TabIndex = 0;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // bxTeamRoster
            // 
            this.bxTeamRoster.Controls.Add(this.txtbxPlayerRoster);
            this.bxTeamRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.bxTeamRoster.Location = new System.Drawing.Point(238, 81);
            this.bxTeamRoster.Name = "bxTeamRoster";
            this.bxTeamRoster.Size = new System.Drawing.Size(465, 518);
            this.bxTeamRoster.TabIndex = 10;
            this.bxTeamRoster.TabStop = false;
            this.bxTeamRoster.Text = "Team Roster";
            // 
            // txtbxPlayerRoster
            // 
            this.txtbxPlayerRoster.AcceptsReturn = true;
            this.txtbxPlayerRoster.AcceptsTab = true;
            this.txtbxPlayerRoster.BackColor = System.Drawing.Color.Maroon;
            this.txtbxPlayerRoster.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtbxPlayerRoster.Location = new System.Drawing.Point(7, 20);
            this.txtbxPlayerRoster.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxPlayerRoster.Multiline = true;
            this.txtbxPlayerRoster.Name = "txtbxPlayerRoster";
            this.txtbxPlayerRoster.ReadOnly = true;
            this.txtbxPlayerRoster.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxPlayerRoster.Size = new System.Drawing.Size(451, 491);
            this.txtbxPlayerRoster.TabIndex = 208;
            // 
            // TimerShowBottom
            // 
            this.TimerShowBottom.AutoSize = true;
            this.TimerShowBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerShowBottom.Location = new System.Drawing.Point(176, 615);
            this.TimerShowBottom.Name = "TimerShowBottom";
            this.TimerShowBottom.Size = new System.Drawing.Size(21, 13);
            this.TimerShowBottom.TabIndex = 126;
            this.TimerShowBottom.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 127;
            this.label7.Text = "This page updates in:";
            // 
            // PageTimer
            // 
            this.PageTimer.Interval = 1000;
            this.PageTimer.Tick += new System.EventHandler(this.PageTimer_Tick);
            // 
            // TeamManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(733, 637);
            this.Controls.Add(this.TimerShowBottom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbxTeam);
            this.Controls.Add(this.bxTeamRoster);
            this.Controls.Add(this.gbFunctions);
            this.Controls.Add(this.lblTeamTeam);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "TeamManagement";
            this.Text = "Team Management";
            this.Load += new System.EventHandler(this.RosterManagement_Load);
            this.gbFunctions.ResumeLayout(false);
            this.bxTeamRoster.ResumeLayout(false);
            this.bxTeamRoster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTeamTeam;
        private System.Windows.Forms.GroupBox gbFunctions;
        private System.Windows.Forms.GroupBox bxTeamRoster;
        private System.Windows.Forms.Button btnAddRoster;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnOpenRoster;
        private System.Windows.Forms.Button btnOpenTeam;
        private System.Windows.Forms.TextBox txtbxTeam;
        private System.Windows.Forms.Label TimerShowBottom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer PageTimer;
        public System.Windows.Forms.TextBox txtbxPlayerRoster;
    }
}