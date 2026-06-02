namespace Timer_Project
{
    partial class frmTimer
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "00",
            "00",
            "10"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "00",
            "00",
            "30"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "00",
            "01",
            "00"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "00",
            "05",
            "00"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "00",
            "10",
            "00"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "00",
            "15",
            "00"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "00",
            "20",
            "00"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "00",
            "30",
            "00"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "00",
            "45",
            "00"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "00",
            "00"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "30",
            "00"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "02",
            "00",
            "00"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "03",
            "00",
            "00"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "05",
            "00",
            "00"}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, new System.Drawing.Font("Tahoma", 12F));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimer));
            this.timerStopwatch = new System.Windows.Forms.Timer(this.components);
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStopwatch = new System.Windows.Forms.TabPage();
            this.lblTicks = new System.Windows.Forms.Label();
            this.btnLap = new System.Windows.Forms.Button();
            this.listBoxLap = new System.Windows.Forms.ListBox();
            this.lblStopwatchTitle = new System.Windows.Forms.Label();
            this.btnResetStopwatch = new System.Windows.Forms.Button();
            this.btnStartStopwatch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnMute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblTimerTitle = new System.Windows.Forms.Label();
            this.btnResetTimer = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPresetsTimers = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMinute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSecond = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerTicks = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabStopwatch.SuspendLayout();
            this.tabTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).BeginInit();
            this.tabPresetsTimers.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerStopwatch
            // 
            this.timerStopwatch.Interval = 1000;
            this.timerStopwatch.Tick += new System.EventHandler(this.timerStopwatch_Tick);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.TimerCountdown_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStopwatch);
            this.tabControl1.Controls.Add(this.tabTimer);
            this.tabControl1.Controls.Add(this.tabPresetsTimers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 444);
            this.tabControl1.TabIndex = 11;
            // 
            // tabStopwatch
            // 
            this.tabStopwatch.BackColor = System.Drawing.SystemColors.Control;
            this.tabStopwatch.Controls.Add(this.lblTicks);
            this.tabStopwatch.Controls.Add(this.btnLap);
            this.tabStopwatch.Controls.Add(this.listBoxLap);
            this.tabStopwatch.Controls.Add(this.lblStopwatchTitle);
            this.tabStopwatch.Controls.Add(this.btnResetStopwatch);
            this.tabStopwatch.Controls.Add(this.btnStartStopwatch);
            this.tabStopwatch.Controls.Add(this.label4);
            this.tabStopwatch.Location = new System.Drawing.Point(4, 33);
            this.tabStopwatch.Name = "tabStopwatch";
            this.tabStopwatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabStopwatch.Size = new System.Drawing.Size(770, 407);
            this.tabStopwatch.TabIndex = 0;
            this.tabStopwatch.Text = "Stopwatch";
            // 
            // lblTicks
            // 
            this.lblTicks.AutoSize = true;
            this.lblTicks.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblTicks.Location = new System.Drawing.Point(426, 178);
            this.lblTicks.Name = "lblTicks";
            this.lblTicks.Size = new System.Drawing.Size(102, 48);
            this.lblTicks.TabIndex = 6;
            this.lblTicks.Text = ",  00";
            // 
            // btnLap
            // 
            this.btnLap.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLap.Location = new System.Drawing.Point(550, 295);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(141, 64);
            this.btnLap.TabIndex = 2;
            this.btnLap.Text = "Lap";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // listBoxLap
            // 
            this.listBoxLap.FormattingEnabled = true;
            this.listBoxLap.ItemHeight = 24;
            this.listBoxLap.Location = new System.Drawing.Point(494, 39);
            this.listBoxLap.Name = "listBoxLap";
            this.listBoxLap.Size = new System.Drawing.Size(255, 100);
            this.listBoxLap.TabIndex = 3;
            // 
            // lblStopwatchTitle
            // 
            this.lblStopwatchTitle.AutoSize = true;
            this.lblStopwatchTitle.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblStopwatchTitle.Location = new System.Drawing.Point(73, 178);
            this.lblStopwatchTitle.Name = "lblStopwatchTitle";
            this.lblStopwatchTitle.Size = new System.Drawing.Size(336, 48);
            this.lblStopwatchTitle.TabIndex = 5;
            this.lblStopwatchTitle.Text = "00   :   00   :   00";
            // 
            // btnResetStopwatch
            // 
            this.btnResetStopwatch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnResetStopwatch.Location = new System.Drawing.Point(329, 295);
            this.btnResetStopwatch.Name = "btnResetStopwatch";
            this.btnResetStopwatch.Size = new System.Drawing.Size(141, 64);
            this.btnResetStopwatch.TabIndex = 1;
            this.btnResetStopwatch.Text = "Reset";
            this.btnResetStopwatch.UseVisualStyleBackColor = true;
            this.btnResetStopwatch.Click += new System.EventHandler(this.btnResetStopwatch_Click);
            // 
            // btnStartStopwatch
            // 
            this.btnStartStopwatch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnStartStopwatch.ForeColor = System.Drawing.Color.Green;
            this.btnStartStopwatch.Location = new System.Drawing.Point(116, 294);
            this.btnStartStopwatch.Name = "btnStartStopwatch";
            this.btnStartStopwatch.Size = new System.Drawing.Size(141, 64);
            this.btnStartStopwatch.TabIndex = 0;
            this.btnStartStopwatch.Text = "Start";
            this.btnStartStopwatch.UseVisualStyleBackColor = true;
            this.btnStartStopwatch.Click += new System.EventHandler(this.btnStartStopwatch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label4.Location = new System.Drawing.Point(152, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 68);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stopwatch";
            // 
            // tabTimer
            // 
            this.tabTimer.BackColor = System.Drawing.SystemColors.Control;
            this.tabTimer.Controls.Add(this.lblEndTime);
            this.tabTimer.Controls.Add(this.btnMute);
            this.tabTimer.Controls.Add(this.label3);
            this.tabTimer.Controls.Add(this.label2);
            this.tabTimer.Controls.Add(this.label1);
            this.tabTimer.Controls.Add(this.numericHours);
            this.tabTimer.Controls.Add(this.numericMinutes);
            this.tabTimer.Controls.Add(this.numericSeconds);
            this.tabTimer.Controls.Add(this.lblTimerTitle);
            this.tabTimer.Controls.Add(this.btnResetTimer);
            this.tabTimer.Controls.Add(this.btnStartTimer);
            this.tabTimer.Controls.Add(this.lblTitle);
            this.tabTimer.Location = new System.Drawing.Point(4, 33);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(770, 407);
            this.tabTimer.TabIndex = 1;
            this.tabTimer.Text = "Timer";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(542, 371);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(193, 24);
            this.lblEndTime.TabIndex = 11;
            this.lblEndTime.Text = "Ends at: 00 : 00 : 00";
            this.lblEndTime.Visible = false;
            // 
            // btnMute
            // 
            this.btnMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMute.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMute.Image = global::Timer_Project.Properties.Resources.mute_48_48;
            this.btnMute.Location = new System.Drawing.Point(40, 42);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(65, 65);
            this.btnMute.TabIndex = 10;
            this.btnMute.Tag = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(595, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(604, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(592, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seconds";
            // 
            // numericHours
            // 
            this.numericHours.Location = new System.Drawing.Point(585, 294);
            this.numericHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericHours.Name = "numericHours";
            this.numericHours.Size = new System.Drawing.Size(106, 32);
            this.numericHours.TabIndex = 2;
            this.numericHours.ValueChanged += new System.EventHandler(this.numericHours_ValueChanged);
            // 
            // numericMinutes
            // 
            this.numericMinutes.Location = new System.Drawing.Point(585, 186);
            this.numericMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMinutes.Name = "numericMinutes";
            this.numericMinutes.Size = new System.Drawing.Size(106, 32);
            this.numericMinutes.TabIndex = 1;
            this.numericMinutes.ValueChanged += new System.EventHandler(this.numericMinutes_ValueChanged);
            // 
            // numericSeconds
            // 
            this.numericSeconds.Location = new System.Drawing.Point(585, 78);
            this.numericSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericSeconds.Name = "numericSeconds";
            this.numericSeconds.Size = new System.Drawing.Size(106, 32);
            this.numericSeconds.TabIndex = 0;
            this.numericSeconds.ValueChanged += new System.EventHandler(this.numericSeconds_ValueChanged);
            // 
            // lblTimerTitle
            // 
            this.lblTimerTitle.AutoSize = true;
            this.lblTimerTitle.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblTimerTitle.Location = new System.Drawing.Point(134, 178);
            this.lblTimerTitle.Name = "lblTimerTitle";
            this.lblTimerTitle.Size = new System.Drawing.Size(336, 48);
            this.lblTimerTitle.TabIndex = 6;
            this.lblTimerTitle.Text = "00   :   00   :   00";
            // 
            // btnResetTimer
            // 
            this.btnResetTimer.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnResetTimer.Location = new System.Drawing.Point(329, 295);
            this.btnResetTimer.Name = "btnResetTimer";
            this.btnResetTimer.Size = new System.Drawing.Size(141, 64);
            this.btnResetTimer.TabIndex = 4;
            this.btnResetTimer.Text = "Reset";
            this.btnResetTimer.UseVisualStyleBackColor = true;
            this.btnResetTimer.Click += new System.EventHandler(this.btnResetTimer_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.ForeColor = System.Drawing.Color.Green;
            this.btnStartTimer.Location = new System.Drawing.Point(123, 294);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(141, 64);
            this.btnStartTimer.TabIndex = 3;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.lblTitle.Location = new System.Drawing.Point(215, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 68);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Timer";
            // 
            // tabPresetsTimers
            // 
            this.tabPresetsTimers.BackColor = System.Drawing.SystemColors.Control;
            this.tabPresetsTimers.Controls.Add(this.label5);
            this.tabPresetsTimers.Controls.Add(this.listView1);
            this.tabPresetsTimers.Location = new System.Drawing.Point(4, 33);
            this.tabPresetsTimers.Name = "tabPresetsTimers";
            this.tabPresetsTimers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPresetsTimers.Size = new System.Drawing.Size(770, 407);
            this.tabPresetsTimers.TabIndex = 2;
            this.tabPresetsTimers.Text = "Presets Timers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label5.Location = new System.Drawing.Point(194, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 68);
            this.label5.TabIndex = 6;
            this.label5.Text = "Presets Timers";
            // 
            // listView1
            // 
            this.listView1.BackgroundImageTiled = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHour,
            this.colMinute,
            this.colSecond});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(3, 164);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(764, 240);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colHour
            // 
            this.colHour.Text = "Hour";
            this.colHour.Width = 130;
            // 
            // colMinute
            // 
            this.colMinute.Text = "Minute";
            this.colMinute.Width = 130;
            // 
            // colSecond
            // 
            this.colSecond.Text = "Second";
            this.colSecond.Width = 130;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Timer-icon-png.png");
            // 
            // timerTicks
            // 
            this.timerTicks.Interval = 10;
            this.timerTicks.Tick += new System.EventHandler(this.timerTicks_Tick);
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimer";
            this.Text = "Timer";
            this.tabControl1.ResumeLayout(false);
            this.tabStopwatch.ResumeLayout(false);
            this.tabStopwatch.PerformLayout();
            this.tabTimer.ResumeLayout(false);
            this.tabTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).EndInit();
            this.tabPresetsTimers.ResumeLayout(false);
            this.tabPresetsTimers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerStopwatch;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStopwatch;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.Button btnResetTimer;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnResetStopwatch;
        private System.Windows.Forms.Button btnStartStopwatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStopwatchTitle;
        private System.Windows.Forms.Label lblTimerTitle;
        private System.Windows.Forms.NumericUpDown numericHours;
        private System.Windows.Forms.NumericUpDown numericMinutes;
        private System.Windows.Forms.NumericUpDown numericSeconds;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.ListBox listBoxLap;
        private System.Windows.Forms.Label lblTicks;
        private System.Windows.Forms.Timer timerTicks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.TabPage tabPresetsTimers;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader colHour;
        private System.Windows.Forms.ColumnHeader colMinute;
        private System.Windows.Forms.ColumnHeader colSecond;
        private System.Windows.Forms.Label label5;
    }
}

