namespace ps_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ps1connect = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ps2connect = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_help = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ps2setcurr = new System.Windows.Forms.Button();
            this.btn_ps2setvolt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ps2curr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ps2volt = new System.Windows.Forms.TextBox();
            this.btn_ps2pcycle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ps2off = new System.Windows.Forms.Button();
            this.btn_ps2on = new System.Windows.Forms.Button();
            this.lbl_ps2curr = new System.Windows.Forms.Label();
            this.lbl_ps2volt = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ps1setcurr = new System.Windows.Forms.Button();
            this.btn_ps1setvolt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ps1curr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ps1volt = new System.Windows.Forms.TextBox();
            this.btn_ps1pcycle = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_ps1off = new System.Windows.Forms.Button();
            this.btn_ps1on = new System.Windows.Forms.Button();
            this.lbl_ps1curr = new System.Windows.Forms.Label();
            this.lbl_ps1volt = new System.Windows.Forms.Label();
            this.timer_instread = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cut,
            this.btn_copy,
            this.btn_paste,
            this.btn_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btn_cut
            // 
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(180, 22);
            this.btn_cut.Text = "Cut";
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(180, 22);
            this.btn_copy.Text = "Copy";
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(180, 22);
            this.btn_paste.Text = "Paste";
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(180, 22);
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ps1connect,
            this.btn_ps2connect});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // btn_ps1connect
            // 
            this.btn_ps1connect.Name = "btn_ps1connect";
            this.btn_ps1connect.Size = new System.Drawing.Size(180, 22);
            this.btn_ps1connect.Text = "PS1";
            this.btn_ps1connect.Click += new System.EventHandler(this.btn_ps1connect_Click);
            // 
            // btn_ps2connect
            // 
            this.btn_ps2connect.Name = "btn_ps2connect";
            this.btn_ps2connect.Size = new System.Drawing.Size(180, 22);
            this.btn_ps2connect.Text = "PS2";
            this.btn_ps2connect.Click += new System.EventHandler(this.btn_ps2connect_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_help});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btn_help
            // 
            this.btn_help.Enabled = false;
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(180, 22);
            this.btn_help.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(265, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(266, 468);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PS_Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 436);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btn_ps2setcurr);
            this.groupBox1.Controls.Add(this.btn_ps2setvolt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_ps2curr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ps2volt);
            this.groupBox1.Controls.Add(this.btn_ps2pcycle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_ps2off);
            this.groupBox1.Controls.Add(this.btn_ps2on);
            this.groupBox1.Controls.Add(this.lbl_ps2curr);
            this.groupBox1.Controls.Add(this.lbl_ps2volt);
            this.groupBox1.Location = new System.Drawing.Point(3, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 212);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Power Supply (Change as necessary)";
            // 
            // btn_ps2setcurr
            // 
            this.btn_ps2setcurr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ps2setcurr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ps2setcurr.Location = new System.Drawing.Point(186, 183);
            this.btn_ps2setcurr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ps2setcurr.Name = "btn_ps2setcurr";
            this.btn_ps2setcurr.Size = new System.Drawing.Size(53, 22);
            this.btn_ps2setcurr.TabIndex = 26;
            this.btn_ps2setcurr.Text = "Set";
            this.btn_ps2setcurr.UseVisualStyleBackColor = false;
            this.btn_ps2setcurr.Click += new System.EventHandler(this.btn_ps2setcurr_Click);
            // 
            // btn_ps2setvolt
            // 
            this.btn_ps2setvolt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ps2setvolt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ps2setvolt.Location = new System.Drawing.Point(186, 161);
            this.btn_ps2setvolt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ps2setvolt.Name = "btn_ps2setvolt";
            this.btn_ps2setvolt.Size = new System.Drawing.Size(53, 22);
            this.btn_ps2setvolt.TabIndex = 25;
            this.btn_ps2setvolt.Text = "Set";
            this.btn_ps2setvolt.UseVisualStyleBackColor = false;
            this.btn_ps2setvolt.Click += new System.EventHandler(this.btn_ps2setvolt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(7, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Current Limit:";
            // 
            // tb_ps2curr
            // 
            this.tb_ps2curr.Location = new System.Drawing.Point(86, 184);
            this.tb_ps2curr.Name = "tb_ps2curr";
            this.tb_ps2curr.Size = new System.Drawing.Size(97, 20);
            this.tb_ps2curr.TabIndex = 23;
            this.tb_ps2curr.Text = "0";
            this.tb_ps2curr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(7, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Voltage:";
            // 
            // tb_ps2volt
            // 
            this.tb_ps2volt.Location = new System.Drawing.Point(86, 162);
            this.tb_ps2volt.Name = "tb_ps2volt";
            this.tb_ps2volt.Size = new System.Drawing.Size(97, 20);
            this.tb_ps2volt.TabIndex = 21;
            this.tb_ps2volt.Text = "0";
            this.tb_ps2volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ps2pcycle
            // 
            this.btn_ps2pcycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ps2pcycle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ps2pcycle.Location = new System.Drawing.Point(186, 134);
            this.btn_ps2pcycle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ps2pcycle.Name = "btn_ps2pcycle";
            this.btn_ps2pcycle.Size = new System.Drawing.Size(53, 22);
            this.btn_ps2pcycle.TabIndex = 19;
            this.btn_ps2pcycle.Text = "P Cycle";
            this.btn_ps2pcycle.UseVisualStyleBackColor = false;
            this.btn_ps2pcycle.Click += new System.EventHandler(this.btn_ps2pcycle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "P/S#2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(7, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Power:";
            // 
            // btn_ps2off
            // 
            this.btn_ps2off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ps2off.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ps2off.Location = new System.Drawing.Point(119, 133);
            this.btn_ps2off.Name = "btn_ps2off";
            this.btn_ps2off.Size = new System.Drawing.Size(62, 23);
            this.btn_ps2off.TabIndex = 9;
            this.btn_ps2off.Text = "OFF";
            this.btn_ps2off.UseVisualStyleBackColor = false;
            this.btn_ps2off.Click += new System.EventHandler(this.btn_ps2off_Click);
            // 
            // btn_ps2on
            // 
            this.btn_ps2on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ps2on.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ps2on.Location = new System.Drawing.Point(53, 133);
            this.btn_ps2on.Name = "btn_ps2on";
            this.btn_ps2on.Size = new System.Drawing.Size(60, 23);
            this.btn_ps2on.TabIndex = 8;
            this.btn_ps2on.Text = "ON";
            this.btn_ps2on.UseVisualStyleBackColor = false;
            this.btn_ps2on.Click += new System.EventHandler(this.btn_ps2on_Click);
            // 
            // lbl_ps2curr
            // 
            this.lbl_ps2curr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ps2curr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ps2curr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ps2curr.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ps2curr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ps2curr.Location = new System.Drawing.Point(7, 86);
            this.lbl_ps2curr.Name = "lbl_ps2curr";
            this.lbl_ps2curr.Size = new System.Drawing.Size(232, 43);
            this.lbl_ps2curr.TabIndex = 7;
            this.lbl_ps2curr.Text = "A";
            this.lbl_ps2curr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ps2volt
            // 
            this.lbl_ps2volt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ps2volt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ps2volt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ps2volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ps2volt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ps2volt.Location = new System.Drawing.Point(7, 34);
            this.lbl_ps2volt.Name = "lbl_ps2volt";
            this.lbl_ps2volt.Size = new System.Drawing.Size(232, 43);
            this.lbl_ps2volt.TabIndex = 6;
            this.lbl_ps2volt.Text = "V";
            this.lbl_ps2volt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.btn_ps1setcurr);
            this.groupBox3.Controls.Add(this.btn_ps1setvolt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_ps1curr);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_ps1volt);
            this.groupBox3.Controls.Add(this.btn_ps1pcycle);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btn_ps1off);
            this.groupBox3.Controls.Add(this.btn_ps1on);
            this.groupBox3.Controls.Add(this.lbl_ps1curr);
            this.groupBox3.Controls.Add(this.lbl_ps1volt);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 212);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Power Supply (Change as necessary)";
            // 
            // btn_ps1setcurr
            // 
            this.btn_ps1setcurr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ps1setcurr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ps1setcurr.Location = new System.Drawing.Point(186, 183);
            this.btn_ps1setcurr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ps1setcurr.Name = "btn_ps1setcurr";
            this.btn_ps1setcurr.Size = new System.Drawing.Size(53, 22);
            this.btn_ps1setcurr.TabIndex = 26;
            this.btn_ps1setcurr.Text = "Set";
            this.btn_ps1setcurr.UseVisualStyleBackColor = false;
            this.btn_ps1setcurr.Click += new System.EventHandler(this.btn_ps1setcurr_Click);
            // 
            // btn_ps1setvolt
            // 
            this.btn_ps1setvolt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ps1setvolt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ps1setvolt.Location = new System.Drawing.Point(186, 161);
            this.btn_ps1setvolt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ps1setvolt.Name = "btn_ps1setvolt";
            this.btn_ps1setvolt.Size = new System.Drawing.Size(53, 22);
            this.btn_ps1setvolt.TabIndex = 25;
            this.btn_ps1setvolt.Text = "Set";
            this.btn_ps1setvolt.UseVisualStyleBackColor = false;
            this.btn_ps1setvolt.Click += new System.EventHandler(this.btn_ps1setvolt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(7, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Current Limit:";
            // 
            // tb_ps1curr
            // 
            this.tb_ps1curr.Location = new System.Drawing.Point(86, 184);
            this.tb_ps1curr.Name = "tb_ps1curr";
            this.tb_ps1curr.Size = new System.Drawing.Size(97, 20);
            this.tb_ps1curr.TabIndex = 23;
            this.tb_ps1curr.Text = "0";
            this.tb_ps1curr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(7, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Voltage:";
            // 
            // tb_ps1volt
            // 
            this.tb_ps1volt.Location = new System.Drawing.Point(86, 162);
            this.tb_ps1volt.Name = "tb_ps1volt";
            this.tb_ps1volt.Size = new System.Drawing.Size(97, 20);
            this.tb_ps1volt.TabIndex = 21;
            this.tb_ps1volt.Text = "0";
            this.tb_ps1volt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ps1pcycle
            // 
            this.btn_ps1pcycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ps1pcycle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ps1pcycle.Location = new System.Drawing.Point(186, 134);
            this.btn_ps1pcycle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ps1pcycle.Name = "btn_ps1pcycle";
            this.btn_ps1pcycle.Size = new System.Drawing.Size(53, 22);
            this.btn_ps1pcycle.TabIndex = 19;
            this.btn_ps1pcycle.Text = "P Cycle";
            this.btn_ps1pcycle.UseVisualStyleBackColor = false;
            this.btn_ps1pcycle.Click += new System.EventHandler(this.btn_ps1pcycle_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold);
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(7, 18);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "P/S#1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(7, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Power:";
            // 
            // btn_ps1off
            // 
            this.btn_ps1off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ps1off.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ps1off.Location = new System.Drawing.Point(119, 133);
            this.btn_ps1off.Name = "btn_ps1off";
            this.btn_ps1off.Size = new System.Drawing.Size(62, 23);
            this.btn_ps1off.TabIndex = 9;
            this.btn_ps1off.Text = "OFF";
            this.btn_ps1off.UseVisualStyleBackColor = false;
            this.btn_ps1off.Click += new System.EventHandler(this.btn_ps1off_Click);
            // 
            // btn_ps1on
            // 
            this.btn_ps1on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ps1on.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ps1on.Location = new System.Drawing.Point(53, 133);
            this.btn_ps1on.Name = "btn_ps1on";
            this.btn_ps1on.Size = new System.Drawing.Size(60, 23);
            this.btn_ps1on.TabIndex = 8;
            this.btn_ps1on.Text = "ON";
            this.btn_ps1on.UseVisualStyleBackColor = false;
            this.btn_ps1on.Click += new System.EventHandler(this.btn_ps1on_Click);
            // 
            // lbl_ps1curr
            // 
            this.lbl_ps1curr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ps1curr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ps1curr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ps1curr.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ps1curr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ps1curr.Location = new System.Drawing.Point(7, 86);
            this.lbl_ps1curr.Name = "lbl_ps1curr";
            this.lbl_ps1curr.Size = new System.Drawing.Size(232, 43);
            this.lbl_ps1curr.TabIndex = 7;
            this.lbl_ps1curr.Text = "A";
            this.lbl_ps1curr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ps1volt
            // 
            this.lbl_ps1volt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ps1volt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ps1volt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ps1volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ps1volt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ps1volt.Location = new System.Drawing.Point(7, 34);
            this.lbl_ps1volt.Name = "lbl_ps1volt";
            this.lbl_ps1volt.Size = new System.Drawing.Size(232, 43);
            this.lbl_ps1volt.TabIndex = 6;
            this.lbl_ps1volt.Text = "V";
            this.lbl_ps1volt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 516);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Power Supply Controller";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_cut;
        private System.Windows.Forms.ToolStripMenuItem btn_copy;
        private System.Windows.Forms.ToolStripMenuItem btn_paste;
        private System.Windows.Forms.ToolStripMenuItem btn_exit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_help;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ps2setcurr;
        private System.Windows.Forms.Button btn_ps2setvolt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ps2curr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ps2volt;
        private System.Windows.Forms.Button btn_ps2pcycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ps2off;
        private System.Windows.Forms.Button btn_ps2on;
        private System.Windows.Forms.Label lbl_ps2curr;
        private System.Windows.Forms.Label lbl_ps2volt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ps1setcurr;
        private System.Windows.Forms.Button btn_ps1setvolt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ps1curr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ps1volt;
        private System.Windows.Forms.Button btn_ps1pcycle;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_ps1off;
        private System.Windows.Forms.Button btn_ps1on;
        private System.Windows.Forms.Label lbl_ps1curr;
        private System.Windows.Forms.Label lbl_ps1volt;
        private System.Windows.Forms.Timer timer_instread;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_ps1connect;
        private System.Windows.Forms.ToolStripMenuItem btn_ps2connect;
    }
}

