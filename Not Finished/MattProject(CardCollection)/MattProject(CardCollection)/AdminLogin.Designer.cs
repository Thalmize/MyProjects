namespace MattProject_CardCollection_
{
    partial class AdminLogin
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
            this.btnReset = new System.Windows.Forms.Button();
            this.txtbxSubmit = new System.Windows.Forms.Button();
            this.txtbxALusername = new System.Windows.Forms.TextBox();
            this.txtbxALpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(117, 349);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(255, 82);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtbxSubmit
            // 
            this.txtbxSubmit.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSubmit.Location = new System.Drawing.Point(117, 454);
            this.txtbxSubmit.Name = "txtbxSubmit";
            this.txtbxSubmit.Size = new System.Drawing.Size(255, 82);
            this.txtbxSubmit.TabIndex = 0;
            this.txtbxSubmit.Text = "Submit";
            this.txtbxSubmit.UseVisualStyleBackColor = true;
            this.txtbxSubmit.Click += new System.EventHandler(this.txtbxSubmit_Click);
            // 
            // txtbxALusername
            // 
            this.txtbxALusername.Font = new System.Drawing.Font("MV Boli", 15F);
            this.txtbxALusername.Location = new System.Drawing.Point(117, 164);
            this.txtbxALusername.Name = "txtbxALusername";
            this.txtbxALusername.Size = new System.Drawing.Size(255, 40);
            this.txtbxALusername.TabIndex = 1;
            // 
            // txtbxALpassword
            // 
            this.txtbxALpassword.Font = new System.Drawing.Font("MV Boli", 15F);
            this.txtbxALpassword.Location = new System.Drawing.Point(117, 258);
            this.txtbxALpassword.Name = "txtbxALpassword";
            this.txtbxALpassword.Size = new System.Drawing.Size(255, 40);
            this.txtbxALpassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F);
            this.label1.Location = new System.Drawing.Point(132, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory POS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("MV Boli", 16F);
            this.lblNotes.Location = new System.Drawing.Point(95, 562);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(0, 29);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxALpassword);
            this.Controls.Add(this.txtbxALusername);
            this.Controls.Add(this.txtbxSubmit);
            this.Controls.Add(this.btnReset);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "AdminLogin";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button txtbxSubmit;
        private System.Windows.Forms.TextBox txtbxALusername;
        private System.Windows.Forms.TextBox txtbxALpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNotes;
    }
}