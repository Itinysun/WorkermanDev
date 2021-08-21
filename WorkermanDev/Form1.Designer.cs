namespace WorkermanDev
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.TsHome = new System.Windows.Forms.ToolStrip();
            this.TbStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TbStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TbRestart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtConfirmFilter = new System.Windows.Forms.Button();
            this.TbFilter = new System.Windows.Forms.TextBox();
            this.CbFilter = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDebounce = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.buttonStartpath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPhp = new System.Windows.Forms.TextBox();
            this.buttonSelectPhp = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.listBoxMonitor = new System.Windows.Forms.ListBox();
            this.TsMonitors = new System.Windows.Forms.ToolStrip();
            this.TsbAddMonitor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbAddMonitorFolders = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbDeleteMonitor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.TsHome.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDebounce)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.TsMonitors.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogBox.Location = new System.Drawing.Point(0, 0);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(786, 470);
            this.LogBox.TabIndex = 1;
            this.LogBox.Text = "";
            this.LogBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LogBox_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 535);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStripContainer1);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LogBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(786, 470);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(786, 495);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TsHome);
            // 
            // TsHome
            // 
            this.TsHome.Dock = System.Windows.Forms.DockStyle.None;
            this.TsHome.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TsHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TbStart,
            this.toolStripSeparator1,
            this.TbStop,
            this.toolStripSeparator2,
            this.TbRestart,
            this.toolStripButtonAbout});
            this.TsHome.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TsHome.Location = new System.Drawing.Point(0, 0);
            this.TsHome.Name = "TsHome";
            this.TsHome.Size = new System.Drawing.Size(786, 25);
            this.TsHome.Stretch = true;
            this.TsHome.TabIndex = 0;
            // 
            // TbStart
            // 
            this.TbStart.Image = global::WorkermanDev.Properties.Resources._60207_start_icon;
            this.TbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbStart.Name = "TbStart";
            this.TbStart.Size = new System.Drawing.Size(55, 22);
            this.TbStart.Text = "Start";
            this.TbStart.Click += new System.EventHandler(this.TbStart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TbStop
            // 
            this.TbStop.Enabled = false;
            this.TbStop.Image = global::WorkermanDev.Properties.Resources._60208_red_stop_icon;
            this.TbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbStop.Name = "TbStop";
            this.TbStop.Size = new System.Drawing.Size(55, 22);
            this.TbStop.Text = "Stop";
            this.TbStop.Click += new System.EventHandler(this.TbStop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TbRestart
            // 
            this.TbRestart.Enabled = false;
            this.TbRestart.Image = global::WorkermanDev.Properties.Resources._60196_order_icon;
            this.TbRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbRestart.Name = "TbRestart";
            this.TbRestart.Size = new System.Drawing.Size(69, 22);
            this.TbRestart.Text = "Restart";
            this.TbRestart.Click += new System.EventHandler(this.TbRestart_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAbout.Image = global::WorkermanDev.Properties.Resources._60173_example_icon;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonAbout.Text = "about";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtConfirmFilter);
            this.groupBox4.Controls.Add(this.TbFilter);
            this.groupBox4.Controls.Add(this.CbFilter);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(6, 381);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(778, 108);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extension filter";
            // 
            // BtConfirmFilter
            // 
            this.BtConfirmFilter.Enabled = false;
            this.BtConfirmFilter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtConfirmFilter.Location = new System.Drawing.Point(649, 54);
            this.BtConfirmFilter.Name = "BtConfirmFilter";
            this.BtConfirmFilter.Size = new System.Drawing.Size(110, 29);
            this.BtConfirmFilter.TabIndex = 3;
            this.BtConfirmFilter.Text = "Confirm";
            this.BtConfirmFilter.UseVisualStyleBackColor = true;
            this.BtConfirmFilter.Click += new System.EventHandler(this.BtConfirmFilter_Click);
            // 
            // TbFilter
            // 
            this.TbFilter.Enabled = false;
            this.TbFilter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbFilter.Location = new System.Drawing.Point(91, 55);
            this.TbFilter.Name = "TbFilter";
            this.TbFilter.Size = new System.Drawing.Size(540, 26);
            this.TbFilter.TabIndex = 2;
            // 
            // CbFilter
            // 
            this.CbFilter.AutoSize = true;
            this.CbFilter.Location = new System.Drawing.Point(11, 57);
            this.CbFilter.Name = "CbFilter";
            this.CbFilter.Size = new System.Drawing.Size(74, 23);
            this.CbFilter.TabIndex = 1;
            this.CbFilter.Text = "Enable";
            this.CbFilter.UseVisualStyleBackColor = true;
            this.CbFilter.CheckStateChanged += new System.EventHandler(this.CbFilter_CheckStateChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(737, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "If enabled, only files with the specified extension will be monitored,Use | to sp" +
    "lit like \".php|.env\"";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownDebounce);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(6, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(778, 96);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Debounce";
            // 
            // numericUpDownDebounce
            // 
            this.numericUpDownDebounce.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownDebounce.Location = new System.Drawing.Point(10, 56);
            this.numericUpDownDebounce.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDebounce.Name = "numericUpDownDebounce";
            this.numericUpDownDebounce.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownDebounce.TabIndex = 1;
            this.numericUpDownDebounce.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(136, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Set the restart delay after file changes to avoid frequent triggers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxStart);
            this.groupBox2.Controls.Add(this.buttonStartpath);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(6, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start-path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select or Drag Drop start.php(bootstrap file) here";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStart.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxStart.Location = new System.Drawing.Point(10, 58);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(621, 26);
            this.textBoxStart.TabIndex = 1;
            this.textBoxStart.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxStart_DragDrop);
            this.textBoxStart.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_DragDrop);
            // 
            // buttonStartpath
            // 
            this.buttonStartpath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStartpath.Location = new System.Drawing.Point(649, 57);
            this.buttonStartpath.Name = "buttonStartpath";
            this.buttonStartpath.Size = new System.Drawing.Size(110, 31);
            this.buttonStartpath.TabIndex = 2;
            this.buttonStartpath.Text = "Select";
            this.buttonStartpath.UseVisualStyleBackColor = true;
            this.buttonStartpath.Click += new System.EventHandler(this.buttonStartpath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPhp);
            this.groupBox1.Controls.Add(this.buttonSelectPhp);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PHP-path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select or Drag Drop php.exe here";
            // 
            // textBoxPhp
            // 
            this.textBoxPhp.AllowDrop = true;
            this.textBoxPhp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPhp.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxPhp.Location = new System.Drawing.Point(10, 59);
            this.textBoxPhp.Name = "textBoxPhp";
            this.textBoxPhp.Size = new System.Drawing.Size(621, 26);
            this.textBoxPhp.TabIndex = 1;
            this.textBoxPhp.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxPhp_DragDrop);
            this.textBoxPhp.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_DragDrop);
            // 
            // buttonSelectPhp
            // 
            this.buttonSelectPhp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSelectPhp.Location = new System.Drawing.Point(649, 57);
            this.buttonSelectPhp.Name = "buttonSelectPhp";
            this.buttonSelectPhp.Size = new System.Drawing.Size(110, 31);
            this.buttonSelectPhp.TabIndex = 2;
            this.buttonSelectPhp.Text = "Select";
            this.buttonSelectPhp.UseVisualStyleBackColor = true;
            this.buttonSelectPhp.Click += new System.EventHandler(this.buttonSelectPhp_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.toolStripContainer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Monitors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.listBoxMonitor);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(792, 476);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(792, 501);
            this.toolStripContainer2.TabIndex = 0;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.TsMonitors);
            // 
            // listBoxMonitor
            // 
            this.listBoxMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMonitor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxMonitor.FormattingEnabled = true;
            this.listBoxMonitor.ItemHeight = 21;
            this.listBoxMonitor.Location = new System.Drawing.Point(0, 0);
            this.listBoxMonitor.Name = "listBoxMonitor";
            this.listBoxMonitor.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMonitor.Size = new System.Drawing.Size(792, 476);
            this.listBoxMonitor.TabIndex = 0;
            // 
            // TsMonitors
            // 
            this.TsMonitors.Dock = System.Windows.Forms.DockStyle.None;
            this.TsMonitors.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TsMonitors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbAddMonitor,
            this.toolStripSeparator5,
            this.TsbAddMonitorFolders,
            this.toolStripSeparator3,
            this.TsbDeleteMonitor,
            this.toolStripSeparator4,
            this.toolStripLabel1});
            this.TsMonitors.Location = new System.Drawing.Point(3, 0);
            this.TsMonitors.Name = "TsMonitors";
            this.TsMonitors.Size = new System.Drawing.Size(517, 25);
            this.TsMonitors.TabIndex = 0;
            // 
            // TsbAddMonitor
            // 
            this.TsbAddMonitor.Image = global::WorkermanDev.Properties.Resources._48761_file_add_upload_icon;
            this.TsbAddMonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAddMonitor.Name = "TsbAddMonitor";
            this.TsbAddMonitor.Size = new System.Drawing.Size(81, 22);
            this.TsbAddMonitor.Text = "Add Files";
            this.TsbAddMonitor.Click += new System.EventHandler(this.TsbAddMonitor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbAddMonitorFolders
            // 
            this.TsbAddMonitorFolders.Image = global::WorkermanDev.Properties.Resources._17374_add_folder_icon;
            this.TsbAddMonitorFolders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAddMonitorFolders.Name = "TsbAddMonitorFolders";
            this.TsbAddMonitorFolders.Size = new System.Drawing.Size(99, 22);
            this.TsbAddMonitorFolders.Text = "Add Folders";
            this.TsbAddMonitorFolders.Click += new System.EventHandler(this.TsbAddMonitorFolders_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbDeleteMonitor
            // 
            this.TsbDeleteMonitor.Image = global::WorkermanDev.Properties.Resources._48768_delete_folder_icon;
            this.TsbDeleteMonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbDeleteMonitor.Name = "TsbDeleteMonitor";
            this.TsbDeleteMonitor.Size = new System.Drawing.Size(65, 22);
            this.TsbDeleteMonitor.Text = "Delete";
            this.TsbDeleteMonitor.Click += new System.EventHandler(this.TsbDeleteMonitor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(251, 22);
            this.toolStripLabel1.Text = "The operation will take effect immediately";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WorkmanDev";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.TsHome.ResumeLayout(false);
            this.TsHome.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDebounce)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.TsMonitors.ResumeLayout(false);
            this.TsMonitors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TsHome;
        private System.Windows.Forms.ToolStripButton TbStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TbStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TbRestart;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStrip TsMonitors;
        private System.Windows.Forms.ListBox listBoxMonitor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhp;
        private System.Windows.Forms.Button buttonSelectPhp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Button buttonStartpath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDebounce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton TsbAddMonitor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TsbDeleteMonitor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton TsbAddMonitorFolders;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbFilter;
        private System.Windows.Forms.CheckBox CbFilter;
        private System.Windows.Forms.Button BtConfirmFilter;
    }
}

