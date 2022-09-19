
namespace Clock_Timer
{
    partial class Timer_Main
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
            this.currentTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.breakMin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.breakSec = new System.Windows.Forms.Label();
            this.cbSetTime = new System.Windows.Forms.ComboBox();
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(285, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 46);
            this.label1.TabIndex = 38;
            this.label1.Text = ":";
            // 
            // lblsecchoice
            // 
            this.lblsecchoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblsecchoice.AutoSize = true;
            this.lblsecchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecchoice.ForeColor = System.Drawing.Color.Black;
            this.lblsecchoice.Location = new System.Drawing.Point(391, 95);
            this.lblsecchoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsecchoice.Name = "lblsecchoice";
            this.lblsecchoice.Size = new System.Drawing.Size(78, 36);
            this.lblsecchoice.TabIndex = 37;
            this.lblsecchoice.Text = "Sec:";
            // 
            // lblminchoice
            // 
            this.lblminchoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblminchoice.AutoSize = true;
            this.lblminchoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminchoice.ForeColor = System.Drawing.Color.Black;
            this.lblminchoice.Location = new System.Drawing.Point(17, 91);
            this.lblminchoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblminchoice.Name = "lblminchoice";
            this.lblminchoice.Size = new System.Drawing.Size(76, 36);
            this.lblminchoice.TabIndex = 36;
            this.lblminchoice.Text = "Min:";
            // 
            // lblDone
            // 
            this.lblDone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDone.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDone.Location = new System.Drawing.Point(19, 196);
            this.lblDone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(208, 39);
            this.lblDone.TabIndex = 35;
            this.lblDone.Text = "TIME IS UP";
            // 
            // btnminus1min
            // 
            this.btnminus1min.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnminus1min.AutoSize = true;
            this.btnminus1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus1min.Location = new System.Drawing.Point(305, 87);
            this.btnminus1min.Margin = new System.Windows.Forms.Padding(4);
            this.btnminus1min.Name = "btnminus1min";
            this.btnminus1min.Size = new System.Drawing.Size(61, 49);
            this.btnminus1min.TabIndex = 33;
            this.btnminus1min.Text = "-1";
            this.btnminus1min.UseVisualStyleBackColor = true;
            this.btnminus1min.Click += new System.EventHandler(this.btnminus1min_Click);
            // 
            // btnminus10min
            // 
            this.btnminus10min.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnminus10min.AutoSize = true;
            this.btnminus10min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus10min.Location = new System.Drawing.Point(167, 87);
            this.btnminus10min.Margin = new System.Windows.Forms.Padding(4);
            this.btnminus10min.Name = "btnminus10min";
            this.btnminus10min.Size = new System.Drawing.Size(61, 49);
            this.btnminus10min.TabIndex = 32;
            this.btnminus10min.Text = "-10";
            this.btnminus10min.UseVisualStyleBackColor = true;
            this.btnminus10min.Click += new System.EventHandler(this.btnminus10min_Click);
            // 
            // btnminus10sec
            // 
            this.btnminus10sec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnminus10sec.AutoSize = true;
            this.btnminus10sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus10sec.Location = new System.Drawing.Point(549, 89);
            this.btnminus10sec.Margin = new System.Windows.Forms.Padding(4);
            this.btnminus10sec.Name = "btnminus10sec";
            this.btnminus10sec.Size = new System.Drawing.Size(61, 49);
            this.btnminus10sec.TabIndex = 31;
            this.btnminus10sec.Text = "-10";
            this.btnminus10sec.UseVisualStyleBackColor = true;
            this.btnminus10sec.Click += new System.EventHandler(this.btnminus10sec_Click);
            // 
            // btnplus10sec
            // 
            this.btnplus10sec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnplus10sec.AutoSize = true;
            this.btnplus10sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus10sec.Location = new System.Drawing.Point(480, 89);
            this.btnplus10sec.Margin = new System.Windows.Forms.Padding(4);
            this.btnplus10sec.Name = "btnplus10sec";
            this.btnplus10sec.Size = new System.Drawing.Size(61, 49);
            this.btnplus10sec.TabIndex = 34;
            this.btnplus10sec.Text = "+10";
            this.btnplus10sec.UseVisualStyleBackColor = true;
            this.btnplus10sec.Click += new System.EventHandler(this.btnplus10sec_Click);
            // 
            // btnminus1sec
            // 
            this.btnminus1sec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnminus1sec.AutoSize = true;
            this.btnminus1sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus1sec.Location = new System.Drawing.Point(688, 89);
            this.btnminus1sec.Margin = new System.Windows.Forms.Padding(4);
            this.btnminus1sec.Name = "btnminus1sec";
            this.btnminus1sec.Size = new System.Drawing.Size(61, 49);
            this.btnminus1sec.TabIndex = 30;
            this.btnminus1sec.Text = "-1";
            this.btnminus1sec.UseVisualStyleBackColor = true;
            this.btnminus1sec.Click += new System.EventHandler(this.btnminus1sec_Click);
            // 
            // btnplus10min
            // 
            this.btnplus10min.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnplus10min.AutoSize = true;
            this.btnplus10min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus10min.Location = new System.Drawing.Point(99, 87);
            this.btnplus10min.Margin = new System.Windows.Forms.Padding(4);
            this.btnplus10min.Name = "btnplus10min";
            this.btnplus10min.Size = new System.Drawing.Size(61, 49);
            this.btnplus10min.TabIndex = 29;
            this.btnplus10min.Text = "+10";
            this.btnplus10min.UseVisualStyleBackColor = true;
            this.btnplus10min.Click += new System.EventHandler(this.btnplus10min_Click);
            // 
            // btnplus1sec
            // 
            this.btnplus1sec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnplus1sec.AutoSize = true;
            this.btnplus1sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus1sec.Location = new System.Drawing.Point(619, 89);
            this.btnplus1sec.Margin = new System.Windows.Forms.Padding(4);
            this.btnplus1sec.Name = "btnplus1sec";
            this.btnplus1sec.Size = new System.Drawing.Size(61, 49);
            this.btnplus1sec.TabIndex = 28;
            this.btnplus1sec.Text = "+1";
            this.btnplus1sec.UseVisualStyleBackColor = true;
            this.btnplus1sec.Click += new System.EventHandler(this.btnplus1sec_Click);
            // 
            // btnplus1min
            // 
            this.btnplus1min.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnplus1min.AutoSize = true;
            this.btnplus1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus1min.Location = new System.Drawing.Point(236, 87);
            this.btnplus1min.Margin = new System.Windows.Forms.Padding(4);
            this.btnplus1min.Name = "btnplus1min";
            this.btnplus1min.Size = new System.Drawing.Size(61, 49);
            this.btnplus1min.TabIndex = 27;
            this.btnplus1min.Text = "+1";
            this.btnplus1min.UseVisualStyleBackColor = true;
            this.btnplus1min.Click += new System.EventHandler(this.btnplus1min_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStop.AutoSize = true;
            this.btnStop.Location = new System.Drawing.Point(527, 159);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 37);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(649, 159);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 37);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.AutoSize = true;
            this.btnStart.Location = new System.Drawing.Point(397, 159);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 37);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TimeSec
            // 
            this.TimeSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeSec.AutoSize = true;
            this.TimeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSec.Location = new System.Drawing.Point(316, 11);
            this.TimeSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeSec.Name = "TimeSec";
            this.TimeSec.Size = new System.Drawing.Size(66, 46);
            this.TimeSec.TabIndex = 23;
            this.TimeSec.Text = "00";
            this.TimeSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeMin
            // 
            this.TimeMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeMin.AutoSize = true;
            this.TimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimeMin.Location = new System.Drawing.Point(201, 11);
            this.TimeMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeMin.Name = "TimeMin";
            this.TimeMin.Size = new System.Drawing.Size(89, 46);
            this.TimeMin.TabIndex = 22;
            this.TimeMin.Text = "100";
            this.TimeMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentTimer
            // 
            this.currentTimer.Interval = 1000;
            this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 46);
            this.label2.TabIndex = 39;
            this.label2.Text = "Current:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(440, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 46);
            this.label3.TabIndex = 40;
            this.label3.Text = "Break:";
            // 
            // breakMin
            // 
            this.breakMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.breakMin.AutoSize = true;
            this.breakMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakMin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.breakMin.Location = new System.Drawing.Point(587, 11);
            this.breakMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.breakMin.Name = "breakMin";
            this.breakMin.Size = new System.Drawing.Size(66, 46);
            this.breakMin.TabIndex = 41;
            this.breakMin.Text = "00";
            this.breakMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(648, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 46);
            this.label5.TabIndex = 43;
            this.label5.Text = ":";
            // 
            // breakSec
            // 
            this.breakSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.breakSec.AutoSize = true;
            this.breakSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakSec.Location = new System.Drawing.Point(673, 11);
            this.breakSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.breakSec.Name = "breakSec";
            this.breakSec.Size = new System.Drawing.Size(66, 46);
            this.breakSec.TabIndex = 42;
            this.breakSec.Text = "00";
            this.breakSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSetTime
            // 
            this.cbSetTime.FormattingEnabled = true;
            this.cbSetTime.Items.AddRange(new object[] {
            "Timer",
            "Break"});
            this.cbSetTime.Location = new System.Drawing.Point(99, 166);
            this.cbSetTime.Margin = new System.Windows.Forms.Padding(4);
            this.cbSetTime.Name = "cbSetTime";
            this.cbSetTime.Size = new System.Drawing.Size(160, 24);
            this.cbSetTime.TabIndex = 44;
            // 
            // breakTimer
            // 
            this.breakTimer.Interval = 1000;
            this.breakTimer.Tick += new System.EventHandler(this.breakTimer_Tick);
            // 
            // Timer_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 239);
            this.Controls.Add(this.btnminus1min);
            this.Controls.Add(this.btnplus10sec);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.cbSetTime);
            this.Controls.Add(this.breakMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.breakSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsecchoice);
            this.Controls.Add(this.lblminchoice);
            this.Controls.Add(this.btnminus10min);
            this.Controls.Add(this.btnminus10sec);
            this.Controls.Add(this.btnminus1sec);
            this.Controls.Add(this.btnplus10min);
            this.Controls.Add(this.btnplus1sec);
            this.Controls.Add(this.btnplus1min);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.TimeSec);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timer_Main";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Timer_Main_Load);
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
        private System.Windows.Forms.Timer currentTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label breakMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label breakSec;
        private System.Windows.Forms.ComboBox cbSetTime;
        private System.Windows.Forms.Timer breakTimer;
    }
}

