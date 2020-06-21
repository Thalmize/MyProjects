namespace StatsProgram
{
    partial class PlayerCore
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
            this.lblPlayerind = new System.Windows.Forms.Label();
            this.lblPlayersComp = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtbxPosition = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtbxNumber = new System.Windows.Forms.TextBox();
            this.lblSavePlyr = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtbxGrade = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.gbPlayerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayerInfo
            // 
            this.gbPlayerInfo.BackColor = System.Drawing.Color.Maroon;
            this.gbPlayerInfo.Controls.Add(this.lblPlayerind);
            this.gbPlayerInfo.Controls.Add(this.lblPlayersComp);
            this.gbPlayerInfo.Controls.Add(this.btnReset);
            this.gbPlayerInfo.Controls.Add(this.btnReturn);
            this.gbPlayerInfo.Controls.Add(this.btnAddPlayer);
            this.gbPlayerInfo.Controls.Add(this.lblPosition);
            this.gbPlayerInfo.Controls.Add(this.txtbxPosition);
            this.gbPlayerInfo.Controls.Add(this.lblNumber);
            this.gbPlayerInfo.Controls.Add(this.txtbxNumber);
            this.gbPlayerInfo.Controls.Add(this.lblSavePlyr);
            this.gbPlayerInfo.Controls.Add(this.lblGrade);
            this.gbPlayerInfo.Controls.Add(this.txtbxGrade);
            this.gbPlayerInfo.Controls.Add(this.lblLastName);
            this.gbPlayerInfo.Controls.Add(this.txtbxLastName);
            this.gbPlayerInfo.Controls.Add(this.lblFirstName);
            this.gbPlayerInfo.Controls.Add(this.txtbxFirstName);
            this.gbPlayerInfo.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbPlayerInfo.Location = new System.Drawing.Point(12, 12);
            this.gbPlayerInfo.Name = "gbPlayerInfo";
            this.gbPlayerInfo.Size = new System.Drawing.Size(542, 363);
            this.gbPlayerInfo.TabIndex = 0;
            this.gbPlayerInfo.TabStop = false;
            this.gbPlayerInfo.Text = " Player Information";
            // 
            // lblPlayerind
            // 
            this.lblPlayerind.AutoSize = true;
            this.lblPlayerind.Location = new System.Drawing.Point(269, 23);
            this.lblPlayerind.Name = "lblPlayerind";
            this.lblPlayerind.Size = new System.Drawing.Size(19, 13);
            this.lblPlayerind.TabIndex = 208;
            this.lblPlayerind.Text = "00";
            // 
            // lblPlayersComp
            // 
            this.lblPlayersComp.AutoSize = true;
            this.lblPlayersComp.Location = new System.Drawing.Point(214, 23);
            this.lblPlayersComp.Name = "lblPlayersComp";
            this.lblPlayersComp.Size = new System.Drawing.Size(49, 13);
            this.lblPlayersComp.TabIndex = 208;
            this.lblPlayersComp.Text = "Player #:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnReset.Location = new System.Drawing.Point(229, 307);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 30);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Maroon;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnReturn.Location = new System.Drawing.Point(371, 307);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(114, 30);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.BackColor = System.Drawing.Color.Maroon;
            this.btnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAddPlayer.Location = new System.Drawing.Point(90, 307);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddPlayer.Size = new System.Drawing.Size(114, 30);
            this.btnAddPlayer.TabIndex = 18;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPosition.Location = new System.Drawing.Point(128, 229);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 17;
            this.lblPosition.Text = "Position";
            // 
            // txtbxPosition
            // 
            this.txtbxPosition.Location = new System.Drawing.Point(272, 227);
            this.txtbxPosition.Name = "txtbxPosition";
            this.txtbxPosition.Size = new System.Drawing.Size(124, 20);
            this.txtbxPosition.TabIndex = 16;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumber.Location = new System.Drawing.Point(128, 190);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(58, 17);
            this.lblNumber.TabIndex = 15;
            this.lblNumber.Text = "Number";
            // 
            // txtbxNumber
            // 
            this.txtbxNumber.Location = new System.Drawing.Point(272, 188);
            this.txtbxNumber.Name = "txtbxNumber";
            this.txtbxNumber.Size = new System.Drawing.Size(124, 20);
            this.txtbxNumber.TabIndex = 14;
            // 
            // lblSavePlyr
            // 
            this.lblSavePlyr.AutoSize = true;
            this.lblSavePlyr.Location = new System.Drawing.Point(269, 267);
            this.lblSavePlyr.Name = "lblSavePlyr";
            this.lblSavePlyr.Size = new System.Drawing.Size(13, 13);
            this.lblSavePlyr.TabIndex = 13;
            this.lblSavePlyr.Text = "  ";
            this.lblSavePlyr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGrade.Location = new System.Drawing.Point(128, 150);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(48, 17);
            this.lblGrade.TabIndex = 11;
            this.lblGrade.Text = "Grade";
            // 
            // txtbxGrade
            // 
            this.txtbxGrade.Location = new System.Drawing.Point(272, 148);
            this.txtbxGrade.Name = "txtbxGrade";
            this.txtbxGrade.Size = new System.Drawing.Size(124, 20);
            this.txtbxGrade.TabIndex = 10;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLastName.Location = new System.Drawing.Point(128, 109);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name";
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(272, 107);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(124, 20);
            this.txtbxLastName.TabIndex = 8;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(128, 69);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(272, 67);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(124, 20);
            this.txtbxFirstName.TabIndex = 0;
            // 
            // PlayerCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(573, 387);
            this.Controls.Add(this.gbPlayerInfo);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "PlayerCore";
            this.Text = "PlayerCore";
            this.Load += new System.EventHandler(this.PlayerCore_Load);
            this.gbPlayerInfo.ResumeLayout(false);
            this.gbPlayerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtbxGrade;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSavePlyr;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtbxPosition;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtbxNumber;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPlayerind;
        private System.Windows.Forms.Label lblPlayersComp;
        public System.Windows.Forms.GroupBox gbPlayerInfo;
    }
}