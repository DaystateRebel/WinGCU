namespace WinGCU
{
    partial class Form1
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
            this.connectionstate = new System.Windows.Forms.Button();
            this.AvailableSerialPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.version = new System.Windows.Forms.TextBox();
            this.pressure = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pl_low = new System.Windows.Forms.CheckBox();
            this.pl_medium = new System.Windows.Forms.CheckBox();
            this.pl_high = new System.Windows.Forms.CheckBox();
            this.lowBar = new System.Windows.Forms.Label();
            this.midBar = new System.Windows.Forms.Label();
            this.highBar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.volts = new System.Windows.Forms.NumericUpDown();
            this.lowPulse = new System.Windows.Forms.NumericUpDown();
            this.midPulse = new System.Windows.Forms.NumericUpDown();
            this.highPulse = new System.Windows.Forms.NumericUpDown();
            this.lowPressure = new System.Windows.Forms.NumericUpDown();
            this.midPressure = new System.Windows.Forms.NumericUpDown();
            this.highPressure = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            this.highSlope = new System.Windows.Forms.TextBox();
            this.lowSlope = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PowerSetting = new System.Windows.Forms.ComboBox();
            this.download = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.poll_timer = new System.Windows.Forms.Timer(this.components);
            this.pulse_duration = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.clear_history = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highPressure)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionstate
            // 
            this.connectionstate.Location = new System.Drawing.Point(115, 20);
            this.connectionstate.Name = "connectionstate";
            this.connectionstate.Size = new System.Drawing.Size(116, 37);
            this.connectionstate.TabIndex = 0;
            this.connectionstate.Text = "Connect";
            this.connectionstate.UseVisualStyleBackColor = true;
            this.connectionstate.Click += new System.EventHandler(this.ConnectionState_Click);
            // 
            // AvailableSerialPorts
            // 
            this.AvailableSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvailableSerialPorts.FormattingEnabled = true;
            this.AvailableSerialPorts.Location = new System.Drawing.Point(8, 25);
            this.AvailableSerialPorts.Name = "AvailableSerialPorts";
            this.AvailableSerialPorts.Size = new System.Drawing.Size(98, 28);
            this.AvailableSerialPorts.Sorted = true;
            this.AvailableSerialPorts.TabIndex = 1;
            this.AvailableSerialPorts.DropDown += new System.EventHandler(this.AvailableSerialPorts_DropDown);
            this.AvailableSerialPorts.SelectionChangeCommitted += new System.EventHandler(this.AvailableSerialPorts_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.version);
            this.groupBox1.Location = new System.Drawing.Point(17, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Version";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(4, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Version";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 26);
            this.textBox1.TabIndex = 0;
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(13, 26);
            this.version.Name = "version";
            this.version.ReadOnly = true;
            this.version.Size = new System.Drawing.Size(178, 26);
            this.version.TabIndex = 0;
            // 
            // pressure
            // 
            this.pressure.Location = new System.Drawing.Point(12, 25);
            this.pressure.Name = "pressure";
            this.pressure.ReadOnly = true;
            this.pressure.Size = new System.Drawing.Size(103, 26);
            this.pressure.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pressure);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(653, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 68);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pressure (BAR)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Location = new System.Drawing.Point(4, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 68);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Version";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(224, 26);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pl_low);
            this.groupBox5.Controls.Add(this.pl_medium);
            this.groupBox5.Controls.Add(this.pl_high);
            this.groupBox5.Controls.Add(this.lowBar);
            this.groupBox5.Controls.Add(this.midBar);
            this.groupBox5.Controls.Add(this.highBar);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.volts);
            this.groupBox5.Controls.Add(this.lowPulse);
            this.groupBox5.Controls.Add(this.midPulse);
            this.groupBox5.Controls.Add(this.highPulse);
            this.groupBox5.Controls.Add(this.lowPressure);
            this.groupBox5.Controls.Add(this.midPressure);
            this.groupBox5.Controls.Add(this.highPressure);
            this.groupBox5.Controls.Add(this.save);
            this.groupBox5.Controls.Add(this.highSlope);
            this.groupBox5.Controls.Add(this.lowSlope);
            this.groupBox5.Controls.Add(this.load);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.PowerSetting);
            this.groupBox5.Location = new System.Drawing.Point(12, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(634, 231);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Power Settings";
            // 
            // pl_low
            // 
            this.pl_low.Appearance = System.Windows.Forms.Appearance.Button;
            this.pl_low.AutoSize = true;
            this.pl_low.Location = new System.Drawing.Point(513, 122);
            this.pl_low.Name = "pl_low";
            this.pl_low.Size = new System.Drawing.Size(101, 30);
            this.pl_low.TabIndex = 29;
            this.pl_low.Text = "Power Lock";
            this.pl_low.UseVisualStyleBackColor = true;
            this.pl_low.CheckStateChanged += new System.EventHandler(this.pl_low_CheckedChanged);
            // 
            // pl_medium
            // 
            this.pl_medium.Appearance = System.Windows.Forms.Appearance.Button;
            this.pl_medium.AutoSize = true;
            this.pl_medium.Location = new System.Drawing.Point(513, 82);
            this.pl_medium.Name = "pl_medium";
            this.pl_medium.Size = new System.Drawing.Size(101, 30);
            this.pl_medium.TabIndex = 28;
            this.pl_medium.Text = "Power Lock";
            this.pl_medium.UseVisualStyleBackColor = true;
            this.pl_medium.CheckStateChanged += new System.EventHandler(this.pl_medium_CheckedChanged);
            // 
            // pl_high
            // 
            this.pl_high.Appearance = System.Windows.Forms.Appearance.Button;
            this.pl_high.AutoSize = true;
            this.pl_high.Location = new System.Drawing.Point(513, 41);
            this.pl_high.Name = "pl_high";
            this.pl_high.Size = new System.Drawing.Size(101, 30);
            this.pl_high.TabIndex = 27;
            this.pl_high.Text = "Power Lock";
            this.pl_high.UseVisualStyleBackColor = true;
            this.pl_high.CheckStateChanged += new System.EventHandler(this.pl_high_CheckedChanged);
            // 
            // lowBar
            // 
            this.lowBar.AutoSize = true;
            this.lowBar.Location = new System.Drawing.Point(320, 127);
            this.lowBar.Name = "lowBar";
            this.lowBar.Size = new System.Drawing.Size(0, 20);
            this.lowBar.TabIndex = 26;
            // 
            // midBar
            // 
            this.midBar.AutoSize = true;
            this.midBar.Location = new System.Drawing.Point(320, 86);
            this.midBar.Name = "midBar";
            this.midBar.Size = new System.Drawing.Size(0, 20);
            this.midBar.TabIndex = 25;
            // 
            // highBar
            // 
            this.highBar.AutoSize = true;
            this.highBar.Location = new System.Drawing.Point(320, 46);
            this.highBar.Name = "highBar";
            this.highBar.Size = new System.Drawing.Size(0, 20);
            this.highBar.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "LS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Volts";
            // 
            // volts
            // 
            this.volts.DecimalPlaces = 3;
            this.volts.Increment = new decimal(new int[] {
            75,
            0,
            0,
            196608});
            this.volts.Location = new System.Drawing.Point(207, 167);
            this.volts.Name = "volts";
            this.volts.Size = new System.Drawing.Size(100, 26);
            this.volts.TabIndex = 18;
            this.volts.ValueChanged += new System.EventHandler(this.volts_ValueChanged);
            // 
            // lowPulse
            // 
            this.lowPulse.Location = new System.Drawing.Point(399, 125);
            this.lowPulse.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.lowPulse.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lowPulse.Name = "lowPulse";
            this.lowPulse.Size = new System.Drawing.Size(100, 26);
            this.lowPulse.TabIndex = 23;
            this.lowPulse.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lowPulse.ValueChanged += new System.EventHandler(this.lowPulse_ValueChanged);
            // 
            // midPulse
            // 
            this.midPulse.Location = new System.Drawing.Point(399, 84);
            this.midPulse.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.midPulse.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.midPulse.Name = "midPulse";
            this.midPulse.Size = new System.Drawing.Size(100, 26);
            this.midPulse.TabIndex = 22;
            this.midPulse.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.midPulse.ValueChanged += new System.EventHandler(this.midPulse_ValueChanged);
            // 
            // highPulse
            // 
            this.highPulse.Location = new System.Drawing.Point(399, 44);
            this.highPulse.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.highPulse.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.highPulse.Name = "highPulse";
            this.highPulse.Size = new System.Drawing.Size(100, 26);
            this.highPulse.TabIndex = 21;
            this.highPulse.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.highPulse.ValueChanged += new System.EventHandler(this.highPulse_ValueChanged);
            // 
            // lowPressure
            // 
            this.lowPressure.Location = new System.Drawing.Point(207, 125);
            this.lowPressure.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.lowPressure.Minimum = new decimal(new int[] {
            103,
            0,
            0,
            0});
            this.lowPressure.Name = "lowPressure";
            this.lowPressure.Size = new System.Drawing.Size(100, 26);
            this.lowPressure.TabIndex = 20;
            this.lowPressure.Value = new decimal(new int[] {
            103,
            0,
            0,
            0});
            this.lowPressure.ValueChanged += new System.EventHandler(this.lowPressure_ValueChanged);
            // 
            // midPressure
            // 
            this.midPressure.Location = new System.Drawing.Point(207, 84);
            this.midPressure.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.midPressure.Name = "midPressure";
            this.midPressure.Size = new System.Drawing.Size(100, 26);
            this.midPressure.TabIndex = 19;
            this.midPressure.Value = new decimal(new int[] {
            103,
            0,
            0,
            0});
            this.midPressure.ValueChanged += new System.EventHandler(this.midPressure_ValueChanged);
            // 
            // highPressure
            // 
            this.highPressure.Location = new System.Drawing.Point(207, 44);
            this.highPressure.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.highPressure.Name = "highPressure";
            this.highPressure.Size = new System.Drawing.Size(100, 26);
            this.highPressure.TabIndex = 18;
            this.highPressure.Value = new decimal(new int[] {
            103,
            0,
            0,
            0});
            this.highPressure.ValueChanged += new System.EventHandler(this.highPressure_ValueChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(10, 109);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(116, 33);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // highSlope
            // 
            this.highSlope.Location = new System.Drawing.Point(49, 157);
            this.highSlope.Name = "highSlope";
            this.highSlope.ReadOnly = true;
            this.highSlope.Size = new System.Drawing.Size(77, 26);
            this.highSlope.TabIndex = 6;
            // 
            // lowSlope
            // 
            this.lowSlope.Location = new System.Drawing.Point(49, 189);
            this.lowSlope.Name = "lowSlope";
            this.lowSlope.ReadOnly = true;
            this.lowSlope.Size = new System.Drawing.Size(77, 26);
            this.lowSlope.TabIndex = 14;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(10, 68);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(116, 33);
            this.load.TabIndex = 9;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "HS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Low";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Medium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "High";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pulse Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pressure";
            // 
            // PowerSetting
            // 
            this.PowerSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PowerSetting.FormattingEnabled = true;
            this.PowerSetting.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.PowerSetting.Location = new System.Drawing.Point(10, 31);
            this.PowerSetting.Name = "PowerSetting";
            this.PowerSetting.Size = new System.Drawing.Size(116, 28);
            this.PowerSetting.TabIndex = 6;
            this.PowerSetting.SelectionChangeCommitted += new System.EventHandler(this.PowerSetting_SelectionChangeCommitted);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(8, 69);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(98, 37);
            this.download.TabIndex = 7;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(115, 70);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(116, 37);
            this.upload.TabIndex = 8;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 20;
            this.historyListBox.Location = new System.Drawing.Point(271, 16);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(541, 224);
            this.historyListBox.TabIndex = 9;
            // 
            // poll_timer
            // 
            this.poll_timer.Interval = 1000;
            this.poll_timer.Tick += new System.EventHandler(this.poll_timer_Tick);
            // 
            // pulse_duration
            // 
            this.pulse_duration.Location = new System.Drawing.Point(12, 25);
            this.pulse_duration.Name = "pulse_duration";
            this.pulse_duration.ReadOnly = true;
            this.pulse_duration.Size = new System.Drawing.Size(103, 26);
            this.pulse_duration.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pulse_duration);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(652, 407);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(160, 68);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pulse Duration (us)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox4);
            this.groupBox7.Location = new System.Drawing.Point(4, 80);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(237, 68);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Version";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(224, 26);
            this.textBox4.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.AvailableSerialPorts);
            this.groupBox8.Controls.Add(this.connectionstate);
            this.groupBox8.Controls.Add(this.download);
            this.groupBox8.Controls.Add(this.upload);
            this.groupBox8.Controls.Add(this.groupBox1);
            this.groupBox8.Location = new System.Drawing.Point(13, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(237, 228);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Connection";
            // 
            // clear_history
            // 
            this.clear_history.Location = new System.Drawing.Point(653, 257);
            this.clear_history.Name = "clear_history";
            this.clear_history.Size = new System.Drawing.Size(158, 34);
            this.clear_history.TabIndex = 11;
            this.clear_history.Text = "Clear History";
            this.clear_history.UseVisualStyleBackColor = true;
            this.clear_history.Click += new System.EventHandler(this.clear_history_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 489);
            this.Controls.Add(this.clear_history);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "WinGCU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highPressure)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectionstate;
        private System.Windows.Forms.ComboBox AvailableSerialPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox version;
        private System.Windows.Forms.TextBox pressure;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox highSlope;
        private System.Windows.Forms.ComboBox PowerSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lowSlope;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.NumericUpDown highPressure;
        private System.Windows.Forms.NumericUpDown lowPressure;
        private System.Windows.Forms.NumericUpDown midPressure;
        private System.Windows.Forms.NumericUpDown lowPulse;
        private System.Windows.Forms.NumericUpDown midPulse;
        private System.Windows.Forms.NumericUpDown highPulse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown volts;
        private System.Windows.Forms.Label highBar;
        private System.Windows.Forms.Label lowBar;
        private System.Windows.Forms.Label midBar;
        private System.Windows.Forms.Timer poll_timer;
        private System.Windows.Forms.TextBox pulse_duration;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox pl_low;
        private System.Windows.Forms.CheckBox pl_medium;
        private System.Windows.Forms.CheckBox pl_high;
        private System.Windows.Forms.Button clear_history;
    }
}

