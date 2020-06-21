namespace StatsProgram
{
    partial class PlayerDelete
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
            this.gbPlayerInfo = new System.Windows.Forms.GroupBox();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.cbPlayerName = new System.Windows.Forms.ComboBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.gbPlayerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayerInfo
            // 
            this.gbPlayerInfo.BackColor = System.Drawing.Color.Maroon;
            this.gbPlayerInfo.Controls.Add(this.btnDeletePlayer);
            this.gbPlayerInfo.Controls.Add(this.cbPlayerName);
            this.gbPlayerInfo.Controls.Add(this.lblPlayerName);
            this.gbPlayerInfo.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbPlayerInfo.Location = new System.Drawing.Point(12, 12);
            this.gbPlayerInfo.Name = "gbPlayerInfo";
            this.gbPlayerInfo.Size = new System.Drawing.Size(542, 140);
            this.gbPlayerInfo.TabIndex = 1;
            this.gbPlayerInfo.TabStop = false;
            this.gbPlayerInfo.Text = "Player Information";
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.BackColor = System.Drawing.Color.Maroon;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayer.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnDeletePlayer.Location = new System.Drawing.Point(194, 87);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(136, 33);
            this.btnDeletePlayer.TabIndex = 16;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = false;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // cbPlayerName
            // 
            this.cbPlayerName.FormattingEnabled = true;
            this.cbPlayerName.Location = new System.Drawing.Point(250, 34);
            this.cbPlayerName.Name = "cbPlayerName";
            this.cbPlayerName.Size = new System.Drawing.Size(196, 21);
            this.cbPlayerName.TabIndex = 6;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPlayerName.Location = new System.Drawing.Point(132, 35);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(89, 17);
            this.lblPlayerName.TabIndex = 7;
            this.lblPlayerName.Text = "Player Name";
            // 
            // PlayerDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(568, 165);
            this.Controls.Add(this.gbPlayerInfo);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "PlayerDelete";
            this.Text = "PlayerDelete";
            this.Load += new System.EventHandler(this.PlayerDelete_Load);
            this.gbPlayerInfo.ResumeLayout(false);
            this.gbPlayerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayerInfo;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.ComboBox cbPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
    }
}