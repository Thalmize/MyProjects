namespace Timer
{
    partial class Clock
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblsecchoice = new System.Windows.Forms.Label();
            this.lblminchoice = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.btnminus1min = new System.Windows.Forms.Button();
            this.btnminus10min = new System.Windows.Forms.Button();
            this.btnminus10sec = new System.Windows.Forms.Button();
            this.btnplus10sec = new System.Windows.Forms.Button();
            this.btnminus1sec = new System.Windows.Forms.Button();
            this.btnplus10min = new System.Windows.Forms.Button();
            this.btnplus1sec = new System.Windows.Forms.Button();
            this.btnplus1min = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.TimeSec = new System.Windows.Forms.Label();
            this.TimeMin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(252, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 135);
            this.label1.TabIndex = 21;
            this.label1.Text = ":";
            // 
            // lblsecchoice
            // 
            this.lblsecchoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblsecchoice.AutoSize = true;
            this.lblsecchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecchoice.ForeColor = System.Drawing.Color.Black;
            this.lblsecchoice.Location = new System.Drawing.Point(340, 172);
            this.lblsecchoice.Name = "lblsecchoice";
            this.lblsecchoice.Size = new System.Drawing.Size(107, 54);
            this.lblsecchoice.TabIndex = 20;
            this.lblsecchoice.Text = "Sec";
            // 
            // lblminchoice
            // 
            this.lblminchoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblminchoice.AutoSize = true;
            this.lblminchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminchoice.ForeColor = System.Drawing.Color.Black;
            this.lblminchoice.Location = new System.Drawing.Point(134, 172);
            this.lblminchoice.Name = "lblminchoice";
            this.lblminchoice.Size = new System.Drawing.Size(101, 54);
            this.lblminchoice.TabIndex = 19;
            this.lblminchoice.Text = "Min";
            // 
            // lblDone
            // 
            this.lblDone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDone.Location = new System.Drawing.Point(180, 338);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(208, 39);
            this.lblDone.TabIndex = 18;
            this.lblDone.Text = "TIME IS UP";
            // 
            // btnminus1min
            // 
            this.btnminus1min.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnminus1min.AutoSize = true;
            this.btnminus1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus1min.Location = new System.Drawing.Point(186, 275);
            this.btnminus1min.Name = "btnminus1min";
            this.btnminus1min.Size = new System.Drawing.Size(52, 46);
            this.btnminus1min.TabIndex = 16;
            this.btnminus1min.Text = "-1";
            this.btnminus1min.UseVisualStyleBackColor = true;
            this.btnminus1min.Click += new System.EventHandler(this.btnminus1min_Click);
            // 
            // btnminus10min
            // 
            this.btnminus10min.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnminus10min.AutoSize = true;
            this.btnminus10min.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus10min.Location = new System.Drawing.Point(110, 275);
            this.btnminus10min.Name = "btnminus10min";
            this.btnminus10min.Size = new System.Drawing.Size(69, 46);
            this.btnminus10min.TabIndex = 15;
            this.btnminus10min.Text = "-10";
            this.btnminus10min.UseVisualStyleBackColor = true;
            this.btnminus10min.Click += new System.EventHandler(this.btnminus10min_Click);
            // 
            // btnminus10sec
            // 
            this.btnminus10sec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnminus10sec.AutoSize = true;
            this.btnminus10sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus10sec.Location = new System.Drawing.Point(320, 275);
            this.btnminus10sec.Name = "btnminus10sec";
            this.btnminus10sec.Size = new System.Drawing.Size(69, 46);
            this.btnminus10sec.TabIndex = 14;
            this.btnminus10sec.Text = "-10";
            this.btnminus10sec.UseVisualStyleBackColor = true;
            this.btnminus10sec.Click += new System.EventHandler(this.btnminus10sec_Click);
            // 
            // btnplus10sec
            // 
            this.btnplus10sec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnplus10sec.AutoSize = true;
            this.btnplus10sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus10sec.Location = new System.Drawing.Point(320, 220);
            this.btnplus10sec.Name = "btnplus10sec";
            this.btnplus10sec.Size = new System.Drawing.Size(76, 46);
            this.btnplus10sec.TabIndex = 17;
            this.btnplus10sec.Text = "+10";
            this.btnplus10sec.UseVisualStyleBackColor = true;
            this.btnplus10sec.Click += new System.EventHandler(this.btnplus10sec_Click);
            // 
            // btnminus1sec
            // 
            this.btnminus1sec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnminus1sec.AutoSize = true;
            this.btnminus1sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus1sec.Location = new System.Drawing.Point(396, 275);
            this.btnminus1sec.Name = "btnminus1sec";
            this.btnminus1sec.Size = new System.Drawing.Size(52, 46);
            this.btnminus1sec.TabIndex = 13;
            this.btnminus1sec.Text = "-1";
            this.btnminus1sec.UseVisualStyleBackColor = true;
            this.btnminus1sec.Click += new System.EventHandler(this.btnminus1sec_Click);
            // 
            // btnplus10min
            // 
            this.btnplus10min.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnplus10min.AutoSize = true;
            this.btnplus10min.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus10min.Location = new System.Drawing.Point(110, 220);
            this.btnplus10min.Name = "btnplus10min";
            this.btnplus10min.Size = new System.Drawing.Size(76, 46);
            this.btnplus10min.TabIndex = 12;
            this.btnplus10min.Text = "+10";
            this.btnplus10min.UseVisualStyleBackColor = true;
            this.btnplus10min.Click += new System.EventHandler(this.btnplus10min_Click);
            // 
            // btnplus1sec
            // 
            this.btnplus1sec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnplus1sec.AutoSize = true;
            this.btnplus1sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus1sec.Location = new System.Drawing.Point(396, 220);
            this.btnplus1sec.Name = "btnplus1sec";
            this.btnplus1sec.Size = new System.Drawing.Size(59, 46);
            this.btnplus1sec.TabIndex = 11;
            this.btnplus1sec.Text = "+1";
            this.btnplus1sec.UseVisualStyleBackColor = true;
            this.btnplus1sec.Click += new System.EventHandler(this.btnplus1sec_Click);
            // 
            // btnplus1min
            // 
            this.btnplus1min.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnplus1min.AutoSize = true;
            this.btnplus1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus1min.Location = new System.Drawing.Point(186, 220);
            this.btnplus1min.Name = "btnplus1min";
            this.btnplus1min.Size = new System.Drawing.Size(59, 46);
            this.btnplus1min.TabIndex = 10;
            this.btnplus1min.Text = "+1";
            this.btnplus1min.UseVisualStyleBackColor = true;
            this.btnplus1min.Click += new System.EventHandler(this.btnplus1min_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStop.AutoSize = true;
            this.btnStop.Location = new System.Drawing.Point(233, 369);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 35);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(350, 369);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.AutoSize = true;
            this.btnStart.Location = new System.Drawing.Point(118, 369);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 35);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TimeSec
            // 
            this.TimeSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSec.Location = new System.Drawing.Point(334, 43);
            this.TimeSec.Name = "TimeSec";
            this.TimeSec.Size = new System.Drawing.Size(171, 108);
            this.TimeSec.TabIndex = 6;
            this.TimeSec.Text = "00";
            this.TimeSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeMin
            // 
            this.TimeMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeMin.AutoSize = true;
            this.TimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimeMin.Location = new System.Drawing.Point(38, 40);
            this.TimeMin.Name = "TimeMin";
            this.TimeMin.Size = new System.Drawing.Size(258, 135);
            this.TimeMin.TabIndex = 5;
            this.TimeMin.Text = "100";
            this.TimeMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(526, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsecchoice);
            this.Controls.Add(this.lblminchoice);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.btnminus1min);
            this.Controls.Add(this.btnminus10min);
            this.Controls.Add(this.btnminus10sec);
            this.Controls.Add(this.btnplus10sec);
            this.Controls.Add(this.btnminus1sec);
            this.Controls.Add(this.btnplus10min);
            this.Controls.Add(this.btnplus1sec);
            this.Controls.Add(this.btnplus1min);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.TimeSec);
            this.Controls.Add(this.TimeMin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Clock";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsecchoice;
        private System.Windows.Forms.Label lblminchoice;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Button btnminus1min;
        private System.Windows.Forms.Button btnminus10min;
        private System.Windows.Forms.Button btnminus10sec;
        private System.Windows.Forms.Button btnplus10sec;
        private System.Windows.Forms.Button btnminus1sec;
        private System.Windows.Forms.Button btnplus10min;
        private System.Windows.Forms.Button btnplus1sec;
        private System.Windows.Forms.Button btnplus1min;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label TimeSec;
        private System.Windows.Forms.Label TimeMin;
        private System.Windows.Forms.Timer timer1;
    }
}