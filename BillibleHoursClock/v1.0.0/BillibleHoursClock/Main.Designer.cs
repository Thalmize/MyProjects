namespace BillibleHoursClock
{
    partial class MainClocking
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.txtbxRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStartStop = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            this.txtbxBillingCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxDescriptionofWork = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxTotalTime = new System.Windows.Forms.TextBox();
            this.txtbxEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewEntry = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbxClockingInfo = new System.Windows.Forms.TextBox();
            this.lblCurrentMode = new System.Windows.Forms.Label();
            this.lblNewProject = new System.Windows.Forms.Label();
            this.lblLoadProject = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCloseProject = new System.Windows.Forms.Label();
            this.lblCurrentProject = new System.Windows.Forms.Label();
            this.lblNewEntryStarted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStopwatch
            // 
            this.lblStopwatch.AutoSize = true;
            this.lblStopwatch.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStopwatch.Location = new System.Drawing.Point(67, 120);
            this.lblStopwatch.Name = "lblStopwatch";
            this.lblStopwatch.Size = new System.Drawing.Size(99, 81);
            this.lblStopwatch.TabIndex = 0;
            this.lblStopwatch.Text = "00";
            this.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxRate
            // 
            this.txtbxRate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxRate.Location = new System.Drawing.Point(362, 348);
            this.txtbxRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxRate.Name = "txtbxRate";
            this.txtbxRate.Size = new System.Drawing.Size(55, 42);
            this.txtbxRate.TabIndex = 1;
            this.txtbxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(346, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rate / Hour";
            // 
            // lblStartStop
            // 
            this.lblStartStop.BackColor = System.Drawing.Color.DarkGreen;
            this.lblStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartStop.ForeColor = System.Drawing.Color.Cyan;
            this.lblStartStop.Location = new System.Drawing.Point(519, 115);
            this.lblStartStop.Name = "lblStartStop";
            this.lblStartStop.Size = new System.Drawing.Size(137, 35);
            this.lblStartStop.TabIndex = 0;
            this.lblStartStop.Text = "Start";
            this.lblStartStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStartStop.Click += new System.EventHandler(this.lblStartStop_Click);
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.Color.Goldenrod;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSave.ForeColor = System.Drawing.Color.Cyan;
            this.lblSave.Location = new System.Drawing.Point(519, 149);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(280, 33);
            this.lblSave.TabIndex = 0;
            this.lblSave.Text = "Save";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // lblReset
            // 
            this.lblReset.BackColor = System.Drawing.Color.DarkOrange;
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReset.ForeColor = System.Drawing.Color.Cyan;
            this.lblReset.Location = new System.Drawing.Point(519, 183);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(280, 33);
            this.lblReset.TabIndex = 0;
            this.lblReset.Text = "Reset";
            this.lblReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // timerControl
            // 
            this.timerControl.Enabled = true;
            this.timerControl.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtbxBillingCompany
            // 
            this.txtbxBillingCompany.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxBillingCompany.Location = new System.Drawing.Point(142, 348);
            this.txtbxBillingCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxBillingCompany.Name = "txtbxBillingCompany";
            this.txtbxBillingCompany.ReadOnly = true;
            this.txtbxBillingCompany.Size = new System.Drawing.Size(201, 42);
            this.txtbxBillingCompany.TabIndex = 2;
            this.txtbxBillingCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(173, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Company to bill";
            // 
            // txtbxDescriptionofWork
            // 
            this.txtbxDescriptionofWork.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxDescriptionofWork.Location = new System.Drawing.Point(457, 348);
            this.txtbxDescriptionofWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxDescriptionofWork.Name = "txtbxDescriptionofWork";
            this.txtbxDescriptionofWork.Size = new System.Drawing.Size(212, 42);
            this.txtbxDescriptionofWork.TabIndex = 2;
            this.txtbxDescriptionofWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(469, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Description of Work";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(696, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Time(h)";
            // 
            // txtbxTotalTime
            // 
            this.txtbxTotalTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxTotalTime.Location = new System.Drawing.Point(713, 348);
            this.txtbxTotalTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxTotalTime.Name = "txtbxTotalTime";
            this.txtbxTotalTime.ReadOnly = true;
            this.txtbxTotalTime.Size = new System.Drawing.Size(79, 42);
            this.txtbxTotalTime.TabIndex = 5;
            this.txtbxTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbxEntry
            // 
            this.txtbxEntry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxEntry.Location = new System.Drawing.Point(41, 348);
            this.txtbxEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxEntry.Name = "txtbxEntry";
            this.txtbxEntry.ReadOnly = true;
            this.txtbxEntry.Size = new System.Drawing.Size(79, 42);
            this.txtbxEntry.TabIndex = 7;
            this.txtbxEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Entry";
            // 
            // lblNewEntry
            // 
            this.lblNewEntry.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblNewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewEntry.ForeColor = System.Drawing.Color.Cyan;
            this.lblNewEntry.Location = new System.Drawing.Point(662, 115);
            this.lblNewEntry.Name = "lblNewEntry";
            this.lblNewEntry.Size = new System.Drawing.Size(137, 33);
            this.lblNewEntry.TabIndex = 8;
            this.lblNewEntry.Text = "New";
            this.lblNewEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewEntry.Click += new System.EventHandler(this.lblNewEntry_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(538, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "Stopwatch";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(681, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "Clockings";
            // 
            // txtbxClockingInfo
            // 
            this.txtbxClockingInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxClockingInfo.Location = new System.Drawing.Point(866, 80);
            this.txtbxClockingInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxClockingInfo.Multiline = true;
            this.txtbxClockingInfo.Name = "txtbxClockingInfo";
            this.txtbxClockingInfo.ReadOnly = true;
            this.txtbxClockingInfo.Size = new System.Drawing.Size(358, 327);
            this.txtbxClockingInfo.TabIndex = 2;
            // 
            // lblCurrentMode
            // 
            this.lblCurrentMode.BackColor = System.Drawing.Color.Firebrick;
            this.lblCurrentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentMode.ForeColor = System.Drawing.Color.Cyan;
            this.lblCurrentMode.Location = new System.Drawing.Point(519, 217);
            this.lblCurrentMode.Name = "lblCurrentMode";
            this.lblCurrentMode.Size = new System.Drawing.Size(280, 33);
            this.lblCurrentMode.TabIndex = 0;
            this.lblCurrentMode.Text = "Mode: Stopwatch";
            this.lblCurrentMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentMode.Click += new System.EventHandler(this.lblCurrentMode_Click);
            // 
            // lblNewProject
            // 
            this.lblNewProject.BackColor = System.Drawing.Color.Transparent;
            this.lblNewProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewProject.ForeColor = System.Drawing.Color.Black;
            this.lblNewProject.Location = new System.Drawing.Point(5, 4);
            this.lblNewProject.Name = "lblNewProject";
            this.lblNewProject.Size = new System.Drawing.Size(189, 34);
            this.lblNewProject.TabIndex = 0;
            this.lblNewProject.Text = "New Project";
            this.lblNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewProject.Click += new System.EventHandler(this.lblNewProject_Click);
            // 
            // lblLoadProject
            // 
            this.lblLoadProject.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoadProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoadProject.ForeColor = System.Drawing.Color.Black;
            this.lblLoadProject.Location = new System.Drawing.Point(199, 4);
            this.lblLoadProject.Name = "lblLoadProject";
            this.lblLoadProject.Size = new System.Drawing.Size(189, 34);
            this.lblLoadProject.TabIndex = 0;
            this.lblLoadProject.Text = "Load Project";
            this.lblLoadProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoadProject.Click += new System.EventHandler(this.lblLoadProject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(878, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current Project: ";
            // 
            // lblCloseProject
            // 
            this.lblCloseProject.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCloseProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCloseProject.ForeColor = System.Drawing.Color.Black;
            this.lblCloseProject.Location = new System.Drawing.Point(395, 4);
            this.lblCloseProject.Name = "lblCloseProject";
            this.lblCloseProject.Size = new System.Drawing.Size(189, 34);
            this.lblCloseProject.TabIndex = 0;
            this.lblCloseProject.Text = "Close Project";
            this.lblCloseProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCloseProject.Click += new System.EventHandler(this.lblCloseProject_Click);
            // 
            // lblCurrentProject
            // 
            this.lblCurrentProject.AutoSize = true;
            this.lblCurrentProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentProject.Location = new System.Drawing.Point(1029, 29);
            this.lblCurrentProject.Name = "lblCurrentProject";
            this.lblCurrentProject.Size = new System.Drawing.Size(158, 23);
            this.lblCurrentProject.TabIndex = 10;
            this.lblCurrentProject.Text = "No Project Loaded";
            // 
            // lblNewEntryStarted
            // 
            this.lblNewEntryStarted.AutoSize = true;
            this.lblNewEntryStarted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewEntryStarted.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNewEntryStarted.Location = new System.Drawing.Point(155, 255);
            this.lblNewEntryStarted.Name = "lblNewEntryStarted";
            this.lblNewEntryStarted.Size = new System.Drawing.Size(188, 28);
            this.lblNewEntryStarted.TabIndex = 3;
            this.lblNewEntryStarted.Text = "New Entry Started";
            // 
            // MainClocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 480);
            this.Controls.Add(this.txtbxTotalTime);
            this.Controls.Add(this.txtbxRate);
            this.Controls.Add(this.txtbxEntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentProject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtbxBillingCompany);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbxDescriptionofWork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNewEntryStarted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNewEntry);
            this.Controls.Add(this.lblCloseProject);
            this.Controls.Add(this.lblLoadProject);
            this.Controls.Add(this.lblNewProject);
            this.Controls.Add(this.lblStartStop);
            this.Controls.Add(this.txtbxClockingInfo);
            this.Controls.Add(this.lblCurrentMode);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblStopwatch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainClocking";
            this.Text = "Billing Hours Stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStopwatch;
        private System.Windows.Forms.TextBox txtbxRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStartStop;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Timer timerControl;
        private System.Windows.Forms.TextBox txtbxBillingCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxDescriptionofWork;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxTotalTime;
        private System.Windows.Forms.TextBox txtbxEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNewEntry;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbxClockingInfo;
        private System.Windows.Forms.Label lblCurrentMode;
        private System.Windows.Forms.Label lblNewProject;
        private System.Windows.Forms.Label lblLoadProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCloseProject;
        private System.Windows.Forms.Label lblCurrentProject;
        private System.Windows.Forms.Label lblNewEntryStarted;
    }
}

