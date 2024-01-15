
namespace CyberpunkNEXTFIT
{
    partial class CyberpunkNF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CyberpunkNF));
            this.StartLoadingpnl = new System.Windows.Forms.Panel();
            this.progressBarStartlbl = new System.Windows.Forms.Label();
            this.progressBarStart = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Homepnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.inputProcesspnl = new System.Windows.Forms.Panel();
            this.numProcesstxt = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.simulatebtn = new System.Windows.Forms.Button();
            this.addProcessbtn = new System.Windows.Forms.Button();
            this.numProcessConfirmbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.processNumlbl = new System.Windows.Forms.Label();
            this.processpnl = new System.Windows.Forms.Panel();
            this.processNametxt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.processSizetxt = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputBlockpnl = new System.Windows.Forms.Panel();
            this.numBlockstxt = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.nextbtn = new System.Windows.Forms.Button();
            this.addBlockbtn = new System.Windows.Forms.Button();
            this.numBlocksConfirmbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.blockNumlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.blockSizetxt = new System.Windows.Forms.NumericUpDown();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LoadingStart = new System.Windows.Forms.Timer(this.components);
            this.simulatepnl = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.retrySimbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvwProcess = new System.Windows.Forms.ListView();
            this.procN = new System.Windows.Forms.ColumnHeader();
            this.procS = new System.Windows.Forms.ColumnHeader();
            this.procA = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blocklview = new System.Windows.Forms.ListView();
            this.blockNum = new System.Windows.Forms.ColumnHeader();
            this.blockSiz = new System.Windows.Forms.ColumnHeader();
            this.label13 = new System.Windows.Forms.Label();
            this.StartLoadingpnl.SuspendLayout();
            this.Homepnl.SuspendLayout();
            this.inputProcesspnl.SuspendLayout();
            this.processpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processSizetxt)).BeginInit();
            this.inputBlockpnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockSizetxt)).BeginInit();
            this.simulatepnl.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartLoadingpnl
            // 
            this.StartLoadingpnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartLoadingpnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartLoadingpnl.BackgroundImage")));
            this.StartLoadingpnl.Controls.Add(this.progressBarStartlbl);
            this.StartLoadingpnl.Controls.Add(this.progressBarStart);
            this.StartLoadingpnl.Controls.Add(this.label1);
            this.StartLoadingpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartLoadingpnl.Location = new System.Drawing.Point(0, 0);
            this.StartLoadingpnl.Name = "StartLoadingpnl";
            this.StartLoadingpnl.Size = new System.Drawing.Size(1382, 853);
            this.StartLoadingpnl.TabIndex = 1;
            this.StartLoadingpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.StartLoadingpnl_Paint);
            // 
            // progressBarStartlbl
            // 
            this.progressBarStartlbl.BackColor = System.Drawing.Color.Transparent;
            this.progressBarStartlbl.Enabled = false;
            this.progressBarStartlbl.Font = new System.Drawing.Font("Product Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressBarStartlbl.ForeColor = System.Drawing.Color.White;
            this.progressBarStartlbl.Location = new System.Drawing.Point(50, 780);
            this.progressBarStartlbl.Name = "progressBarStartlbl";
            this.progressBarStartlbl.Size = new System.Drawing.Size(100, 42);
            this.progressBarStartlbl.TabIndex = 2;
            this.progressBarStartlbl.Text = "100%";
            // 
            // progressBarStart
            // 
            this.progressBarStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.progressBarStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.progressBarStart.Location = new System.Drawing.Point(156, 780);
            this.progressBarStart.Name = "progressBarStart";
            this.progressBarStart.Size = new System.Drawing.Size(1167, 42);
            this.progressBarStart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Conthrax Regular", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 710);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOADING...";
            // 
            // Homepnl
            // 
            this.Homepnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Homepnl.BackgroundImage")));
            this.Homepnl.Controls.Add(this.label2);
            this.Homepnl.Controls.Add(this.Startbtn);
            this.Homepnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Homepnl.Location = new System.Drawing.Point(0, 0);
            this.Homepnl.Name = "Homepnl";
            this.Homepnl.Size = new System.Drawing.Size(1382, 853);
            this.Homepnl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Conthrax Regular", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(573, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "[Algorithm: Next Fit]";
            // 
            // Startbtn
            // 
            this.Startbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.Startbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Startbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.Startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Startbtn.Font = new System.Drawing.Font("Conthrax Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Startbtn.ForeColor = System.Drawing.Color.White;
            this.Startbtn.Location = new System.Drawing.Point(50, 761);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(161, 61);
            this.Startbtn.TabIndex = 0;
            this.Startbtn.Text = "START";
            this.Startbtn.UseVisualStyleBackColor = false;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // inputProcesspnl
            // 
            this.inputProcesspnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputProcesspnl.BackgroundImage")));
            this.inputProcesspnl.Controls.Add(this.numProcesstxt);
            this.inputProcesspnl.Controls.Add(this.textBox4);
            this.inputProcesspnl.Controls.Add(this.simulatebtn);
            this.inputProcesspnl.Controls.Add(this.addProcessbtn);
            this.inputProcesspnl.Controls.Add(this.numProcessConfirmbtn);
            this.inputProcesspnl.Controls.Add(this.label4);
            this.inputProcesspnl.Controls.Add(this.processNumlbl);
            this.inputProcesspnl.Controls.Add(this.processpnl);
            this.inputProcesspnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputProcesspnl.Location = new System.Drawing.Point(0, 0);
            this.inputProcesspnl.Name = "inputProcesspnl";
            this.inputProcesspnl.Size = new System.Drawing.Size(1382, 853);
            this.inputProcesspnl.TabIndex = 3;
            // 
            // numProcesstxt
            // 
            this.numProcesstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(157)))));
            this.numProcesstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numProcesstxt.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numProcesstxt.ForeColor = System.Drawing.Color.White;
            this.numProcesstxt.Location = new System.Drawing.Point(280, 150);
            this.numProcesstxt.Name = "numProcesstxt";
            this.numProcesstxt.Size = new System.Drawing.Size(308, 33);
            this.numProcesstxt.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(157)))));
            this.textBox4.CausesValidation = false;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(276, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(316, 40);
            this.textBox4.TabIndex = 12;
            this.textBox4.WordWrap = false;
            // 
            // simulatebtn
            // 
            this.simulatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(203)))));
            this.simulatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simulatebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.simulatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simulatebtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simulatebtn.ForeColor = System.Drawing.Color.White;
            this.simulatebtn.Location = new System.Drawing.Point(805, 669);
            this.simulatebtn.Name = "simulatebtn";
            this.simulatebtn.Size = new System.Drawing.Size(299, 46);
            this.simulatebtn.TabIndex = 11;
            this.simulatebtn.Text = "SIMULATE";
            this.simulatebtn.UseVisualStyleBackColor = false;
            this.simulatebtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // addProcessbtn
            // 
            this.addProcessbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(203)))));
            this.addProcessbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProcessbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.addProcessbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProcessbtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProcessbtn.ForeColor = System.Drawing.Color.White;
            this.addProcessbtn.Location = new System.Drawing.Point(805, 618);
            this.addProcessbtn.Name = "addProcessbtn";
            this.addProcessbtn.Size = new System.Drawing.Size(299, 46);
            this.addProcessbtn.TabIndex = 10;
            this.addProcessbtn.Text = "ADD PROCESS";
            this.addProcessbtn.UseVisualStyleBackColor = false;
            this.addProcessbtn.Click += new System.EventHandler(this.addProcessbtn_Click);
            // 
            // numProcessConfirmbtn
            // 
            this.numProcessConfirmbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(203)))));
            this.numProcessConfirmbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numProcessConfirmbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.numProcessConfirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numProcessConfirmbtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numProcessConfirmbtn.ForeColor = System.Drawing.Color.White;
            this.numProcessConfirmbtn.Location = new System.Drawing.Point(276, 203);
            this.numProcessConfirmbtn.Name = "numProcessConfirmbtn";
            this.numProcessConfirmbtn.Size = new System.Drawing.Size(200, 46);
            this.numProcessConfirmbtn.TabIndex = 8;
            this.numProcessConfirmbtn.Text = "CONFIRM";
            this.numProcessConfirmbtn.UseVisualStyleBackColor = false;
            this.numProcessConfirmbtn.Click += new System.EventHandler(this.numProcessConfirmbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Conthrax Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(268, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. of Processes:";
            // 
            // processNumlbl
            // 
            this.processNumlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.processNumlbl.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processNumlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.processNumlbl.Location = new System.Drawing.Point(276, 380);
            this.processNumlbl.Name = "processNumlbl";
            this.processNumlbl.Size = new System.Drawing.Size(320, 46);
            this.processNumlbl.TabIndex = 6;
            this.processNumlbl.Text = "PROCESS #01:";
            this.processNumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processpnl
            // 
            this.processpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.processpnl.Controls.Add(this.processNametxt);
            this.processpnl.Controls.Add(this.textBox3);
            this.processpnl.Controls.Add(this.processSizetxt);
            this.processpnl.Controls.Add(this.textBox1);
            this.processpnl.Controls.Add(this.textBox2);
            this.processpnl.Controls.Add(this.label7);
            this.processpnl.Controls.Add(this.label5);
            this.processpnl.Location = new System.Drawing.Point(276, 429);
            this.processpnl.Name = "processpnl";
            this.processpnl.Size = new System.Drawing.Size(832, 184);
            this.processpnl.TabIndex = 5;
            // 
            // processNametxt
            // 
            this.processNametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.processNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processNametxt.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processNametxt.ForeColor = System.Drawing.Color.White;
            this.processNametxt.Location = new System.Drawing.Point(48, 96);
            this.processNametxt.Name = "processNametxt";
            this.processNametxt.Size = new System.Drawing.Size(306, 33);
            this.processNametxt.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.textBox3.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(40, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(316, 40);
            this.textBox3.TabIndex = 12;
            // 
            // processSizetxt
            // 
            this.processSizetxt.AutoSize = true;
            this.processSizetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.processSizetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processSizetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.processSizetxt.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processSizetxt.ForeColor = System.Drawing.Color.White;
            this.processSizetxt.Location = new System.Drawing.Point(442, 96);
            this.processSizetxt.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.processSizetxt.MaximumSize = new System.Drawing.Size(314, 0);
            this.processSizetxt.Name = "processSizetxt";
            this.processSizetxt.Size = new System.Drawing.Size(310, 36);
            this.processSizetxt.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.textBox1.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(437, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(316, 40);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.textBox2.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(833, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(316, 40);
            this.textBox2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Conthrax Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(428, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 42);
            this.label7.TabIndex = 4;
            this.label7.Text = "Process Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Conthrax Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "Process Name:";
            // 
            // inputBlockpnl
            // 
            this.inputBlockpnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputBlockpnl.BackgroundImage")));
            this.inputBlockpnl.Controls.Add(this.numBlockstxt);
            this.inputBlockpnl.Controls.Add(this.textBox6);
            this.inputBlockpnl.Controls.Add(this.nextbtn);
            this.inputBlockpnl.Controls.Add(this.addBlockbtn);
            this.inputBlockpnl.Controls.Add(this.numBlocksConfirmbtn);
            this.inputBlockpnl.Controls.Add(this.label3);
            this.inputBlockpnl.Controls.Add(this.blockNumlbl);
            this.inputBlockpnl.Controls.Add(this.panel2);
            this.inputBlockpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputBlockpnl.Location = new System.Drawing.Point(0, 0);
            this.inputBlockpnl.Name = "inputBlockpnl";
            this.inputBlockpnl.Size = new System.Drawing.Size(1382, 853);
            this.inputBlockpnl.TabIndex = 4;
            this.inputBlockpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.inputBlockpnl_Paint);
            // 
            // numBlockstxt
            // 
            this.numBlockstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(164)))));
            this.numBlockstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numBlockstxt.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numBlockstxt.ForeColor = System.Drawing.Color.White;
            this.numBlockstxt.Location = new System.Drawing.Point(280, 150);
            this.numBlockstxt.Name = "numBlockstxt";
            this.numBlockstxt.Size = new System.Drawing.Size(308, 33);
            this.numBlockstxt.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(157)))));
            this.textBox6.CausesValidation = false;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(276, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(316, 40);
            this.textBox6.TabIndex = 12;
            this.textBox6.WordWrap = false;
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(203)))));
            this.nextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.nextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextbtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextbtn.ForeColor = System.Drawing.Color.White;
            this.nextbtn.Location = new System.Drawing.Point(276, 572);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(276, 46);
            this.nextbtn.TabIndex = 11;
            this.nextbtn.Text = "NEXT";
            this.nextbtn.UseVisualStyleBackColor = false;
            this.nextbtn.Click += new System.EventHandler(this.simulatebtn_Click);
            // 
            // addBlockbtn
            // 
            this.addBlockbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(203)))));
            this.addBlockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBlockbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.addBlockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBlockbtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBlockbtn.ForeColor = System.Drawing.Color.White;
            this.addBlockbtn.Location = new System.Drawing.Point(276, 521);
            this.addBlockbtn.Name = "addBlockbtn";
            this.addBlockbtn.Size = new System.Drawing.Size(276, 46);
            this.addBlockbtn.TabIndex = 10;
            this.addBlockbtn.Text = "ADD BLOCK";
            this.addBlockbtn.UseVisualStyleBackColor = false;
            this.addBlockbtn.Click += new System.EventHandler(this.addBlockbtn_Click);
            // 
            // numBlocksConfirmbtn
            // 
            this.numBlocksConfirmbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(203)))));
            this.numBlocksConfirmbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numBlocksConfirmbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.numBlocksConfirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numBlocksConfirmbtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numBlocksConfirmbtn.ForeColor = System.Drawing.Color.White;
            this.numBlocksConfirmbtn.Location = new System.Drawing.Point(276, 203);
            this.numBlocksConfirmbtn.Name = "numBlocksConfirmbtn";
            this.numBlocksConfirmbtn.Size = new System.Drawing.Size(200, 46);
            this.numBlocksConfirmbtn.TabIndex = 8;
            this.numBlocksConfirmbtn.Text = "CONFIRM";
            this.numBlocksConfirmbtn.UseVisualStyleBackColor = false;
            this.numBlocksConfirmbtn.Click += new System.EventHandler(this.numBlocksConfirmbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Conthrax Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(268, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. of Blocks:";
            // 
            // blockNumlbl
            // 
            this.blockNumlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.blockNumlbl.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blockNumlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.blockNumlbl.Location = new System.Drawing.Point(276, 355);
            this.blockNumlbl.Name = "blockNumlbl";
            this.blockNumlbl.Size = new System.Drawing.Size(235, 46);
            this.blockNumlbl.TabIndex = 6;
            this.blockNumlbl.Text = "BLOCK #01:";
            this.blockNumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.blockSizetxt);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(276, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 92);
            this.panel2.TabIndex = 5;
            // 
            // blockSizetxt
            // 
            this.blockSizetxt.AutoSize = true;
            this.blockSizetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(20)))), ((int)(((byte)(87)))));
            this.blockSizetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blockSizetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.blockSizetxt.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blockSizetxt.ForeColor = System.Drawing.Color.White;
            this.blockSizetxt.Location = new System.Drawing.Point(5, 54);
            this.blockSizetxt.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.blockSizetxt.MaximumSize = new System.Drawing.Size(314, 0);
            this.blockSizetxt.Name = "blockSizetxt";
            this.blockSizetxt.Size = new System.Drawing.Size(310, 36);
            this.blockSizetxt.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(20)))), ((int)(((byte)(87)))));
            this.textBox8.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(0, 52);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(316, 40);
            this.textBox8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Conthrax Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-9, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 42);
            this.label9.TabIndex = 2;
            this.label9.Text = "Block Size:";
            // 
            // LoadingStart
            // 
            this.LoadingStart.Interval = 2;
            this.LoadingStart.Tick += new System.EventHandler(this.LoadingStart_Tick);
            // 
            // simulatepnl
            // 
            this.simulatepnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.simulatepnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simulatepnl.BackgroundImage")));
            this.simulatepnl.Controls.Add(this.panel8);
            this.simulatepnl.Controls.Add(this.panel3);
            this.simulatepnl.Controls.Add(this.panel1);
            this.simulatepnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulatepnl.Location = new System.Drawing.Point(0, 0);
            this.simulatepnl.Name = "simulatepnl";
            this.simulatepnl.Size = new System.Drawing.Size(1382, 853);
            this.simulatepnl.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.exitbtn);
            this.panel8.Controls.Add(this.retrySimbtn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 386);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1382, 146);
            this.panel8.TabIndex = 10;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitbtn.FlatAppearance.BorderSize = 2;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitbtn.ForeColor = System.Drawing.Color.White;
            this.exitbtn.Location = new System.Drawing.Point(618, 50);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(149, 46);
            this.exitbtn.TabIndex = 9;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // retrySimbtn
            // 
            this.retrySimbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(203)))));
            this.retrySimbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrySimbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.retrySimbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retrySimbtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.retrySimbtn.ForeColor = System.Drawing.Color.White;
            this.retrySimbtn.Location = new System.Drawing.Point(59, 50);
            this.retrySimbtn.Name = "retrySimbtn";
            this.retrySimbtn.Size = new System.Drawing.Size(539, 46);
            this.retrySimbtn.TabIndex = 8;
            this.retrySimbtn.Text = "RUN ANOTHER SIMULATION";
            this.retrySimbtn.UseVisualStyleBackColor = false;
            this.retrySimbtn.Click += new System.EventHandler(this.retrySimbtn_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lvwProcess);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1382, 193);
            this.panel3.TabIndex = 2;
            // 
            // lvwProcess
            // 
            this.lvwProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(115)))));
            this.lvwProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.procN,
            this.procS,
            this.procA});
            this.lvwProcess.Font = new System.Drawing.Font("Conthrax Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwProcess.ForeColor = System.Drawing.Color.White;
            this.lvwProcess.GridLines = true;
            this.lvwProcess.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwProcess.HideSelection = false;
            this.lvwProcess.Location = new System.Drawing.Point(59, 152);
            this.lvwProcess.Name = "lvwProcess";
            this.lvwProcess.Scrollable = false;
            this.lvwProcess.Size = new System.Drawing.Size(1264, 38);
            this.lvwProcess.TabIndex = 7;
            this.lvwProcess.UseCompatibleStateImageBehavior = false;
            this.lvwProcess.View = System.Windows.Forms.View.Details;
            // 
            // procN
            // 
            this.procN.Text = "Process Name";
            this.procN.Width = 421;
            // 
            // procS
            // 
            this.procS.Text = "Process Size";
            this.procS.Width = 421;
            // 
            // procA
            // 
            this.procA.Text = "Process Allocation";
            this.procA.Width = 422;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Conthrax Regular", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 92);
            this.label6.TabIndex = 5;
            this.label6.Text = "Process\r\nAllocation Table:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.blocklview);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 193);
            this.panel1.TabIndex = 1;
            // 
            // blocklview
            // 
            this.blocklview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(115)))));
            this.blocklview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blocklview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.blockNum,
            this.blockSiz});
            this.blocklview.Font = new System.Drawing.Font("Conthrax Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blocklview.ForeColor = System.Drawing.Color.White;
            this.blocklview.GridLines = true;
            this.blocklview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.blocklview.HideSelection = false;
            this.blocklview.Location = new System.Drawing.Point(59, 152);
            this.blocklview.Name = "blocklview";
            this.blocklview.Scrollable = false;
            this.blocklview.Size = new System.Drawing.Size(1264, 38);
            this.blocklview.TabIndex = 6;
            this.blocklview.UseCompatibleStateImageBehavior = false;
            this.blocklview.View = System.Windows.Forms.View.Details;
            // 
            // blockNum
            // 
            this.blockNum.Text = "Block Number";
            this.blockNum.Width = 632;
            // 
            // blockSiz
            // 
            this.blockSiz.Text = "Block Size";
            this.blockSiz.Width = 632;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Conthrax Regular", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(50, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(254, 92);
            this.label13.TabIndex = 5;
            this.label13.Text = "Block\r\nSize Table:";
            // 
            // CyberpunkNF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.inputProcesspnl);
            this.Controls.Add(this.inputBlockpnl);
            this.Controls.Add(this.simulatepnl);
            this.Controls.Add(this.StartLoadingpnl);
            this.Controls.Add(this.Homepnl);
            this.Name = "CyberpunkNF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CyberpunkNF";
            this.Load += new System.EventHandler(this.CyberpunkNF_Load);
            this.StartLoadingpnl.ResumeLayout(false);
            this.StartLoadingpnl.PerformLayout();
            this.Homepnl.ResumeLayout(false);
            this.Homepnl.PerformLayout();
            this.inputProcesspnl.ResumeLayout(false);
            this.inputProcesspnl.PerformLayout();
            this.processpnl.ResumeLayout(false);
            this.processpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processSizetxt)).EndInit();
            this.inputBlockpnl.ResumeLayout(false);
            this.inputBlockpnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockSizetxt)).EndInit();
            this.simulatepnl.ResumeLayout(false);
            this.simulatepnl.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartLoadingpnl;
        private System.Windows.Forms.Label progressBarStartlbl;
        private System.Windows.Forms.ProgressBar progressBarStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Homepnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Panel inputProcesspnl;
        private System.Windows.Forms.TextBox numProcesstxt;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button addProcessbtn;
        private System.Windows.Forms.Button numProcessConfirmbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label processNumlbl;
        private System.Windows.Forms.Panel processpnl;
        private System.Windows.Forms.TextBox processNametxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown processSizetxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel inputBlockpnl;
        private System.Windows.Forms.TextBox numBlockstxt;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button addBlockbtn;
        private System.Windows.Forms.Button numBlocksConfirmbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label blockNumlbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown blockSizetxt;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer LoadingStart;
        private System.Windows.Forms.Panel simulatepnl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView blocklview;
        private System.Windows.Forms.ColumnHeader blockNum;
        private System.Windows.Forms.ColumnHeader blockSiz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lvwProcess;
        private System.Windows.Forms.ColumnHeader procN;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader procS;
        private System.Windows.Forms.ColumnHeader procA;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button retrySimbtn;
        private System.Windows.Forms.Button simulatebtn;
        private System.Windows.Forms.Button nextbtn;
    }
}

