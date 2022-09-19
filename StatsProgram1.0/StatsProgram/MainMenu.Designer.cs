namespace StatsProgram
{
    partial class MainMenu
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
            this.TitleMM = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRosterManagement = new System.Windows.Forms.Button();
            this.btnGameManagement = new System.Windows.Forms.Button();
            this.btnViewRep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleMM
            // 
            this.TitleMM.AutoSize = true;
            this.TitleMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleMM.Location = new System.Drawing.Point(67, 36);
            this.TitleMM.Name = "TitleMM";
            this.TitleMM.Size = new System.Drawing.Size(309, 29);
            this.TitleMM.TabIndex = 0;
            this.TitleMM.Text = "Stats Program-Basketball";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnExit.Location = new System.Drawing.Point(120, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(199, 66);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRosterManagement
            // 
            this.btnRosterManagement.BackColor = System.Drawing.Color.Maroon;
            this.btnRosterManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosterManagement.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnRosterManagement.Location = new System.Drawing.Point(120, 115);
            this.btnRosterManagement.Name = "btnRosterManagement";
            this.btnRosterManagement.Size = new System.Drawing.Size(199, 66);
            this.btnRosterManagement.TabIndex = 3;
            this.btnRosterManagement.Text = "Team Management";
            this.btnRosterManagement.UseVisualStyleBackColor = false;
            this.btnRosterManagement.Click += new System.EventHandler(this.btnRosterManagement_Click);
            // 
            // btnGameManagement
            // 
            this.btnGameManagement.BackColor = System.Drawing.Color.Maroon;
            this.btnGameManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameManagement.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnGameManagement.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGameManagement.Location = new System.Drawing.Point(120, 204);
            this.btnGameManagement.Name = "btnGameManagement";
            this.btnGameManagement.Size = new System.Drawing.Size(199, 66);
            this.btnGameManagement.TabIndex = 5;
            this.btnGameManagement.Text = "Game Management";
            this.btnGameManagement.UseVisualStyleBackColor = false;
            this.btnGameManagement.Click += new System.EventHandler(this.btnGameManagement_Click);
            // 
            // btnViewRep
            // 
            this.btnViewRep.BackColor = System.Drawing.Color.Maroon;
            this.btnViewRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRep.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnViewRep.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnViewRep.Location = new System.Drawing.Point(120, 294);
            this.btnViewRep.Name = "btnViewRep";
            this.btnViewRep.Size = new System.Drawing.Size(199, 66);
            this.btnViewRep.TabIndex = 6;
            this.btnViewRep.Text = "View Reports";
            this.btnViewRep.UseVisualStyleBackColor = false;
            this.btnViewRep.Click += new System.EventHandler(this.btnViewRep_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(427, 523);
            this.Controls.Add(this.btnViewRep);
            this.Controls.Add(this.btnGameManagement);
            this.Controls.Add(this.btnRosterManagement);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.TitleMM);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "MainMenu";
            this.Text = "Stat Program";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleMM;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRosterManagement;
        private System.Windows.Forms.Button btnGameManagement;
        private System.Windows.Forms.Button btnViewRep;
    }
}

