
using System.Windows.Forms.VisualStyles;

namespace CyberpunkSRTF
{
    partial class CyberpunkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CyberpunkForm));
            this.StartLoadingpnl = new System.Windows.Forms.Panel();
            this.progressBarStartlbl = new System.Windows.Forms.Label();
            this.progressBarStart = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadingStart = new System.Windows.Forms.Timer(this.components);
            this.Homepnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Inputpnl = new System.Windows.Forms.Panel();
            this.numProcesstxt = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.simulatebtn = new System.Windows.Forms.Button();
            this.addProcessbtn = new System.Windows.Forms.Button();
            this.processNumlbl = new System.Windows.Forms.Label();
            this.processpnl = new System.Windows.Forms.Panel();
            this.processNametxt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.burstTimetxt = new System.Windows.Forms.NumericUpDown();
            this.arrivalTimetxt = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numProcessConfirmbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.simLoadtmr = new System.Windows.Forms.Timer(this.components);
            this.processtmr = new System.Windows.Forms.Timer(this.components);
            this.simulatepnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.rerunSimbtn = new System.Windows.Forms.Button();
            this.ganttChartpnl = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.gcPane = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.aveTaTimelbl = new System.Windows.Forms.Label();
            this.aveWaitingTimelbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hidepnl = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.processlview = new System.Windows.Forms.ListView();
            this.processNamecol = new System.Windows.Forms.ColumnHeader();
            this.arrivalTimecol = new System.Windows.Forms.ColumnHeader();
            this.burstTimecol = new System.Windows.Forms.ColumnHeader();
            this.waitingTimecol = new System.Windows.Forms.ColumnHeader();
            this.taTimecol = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statuspnl = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.simLoadpnl = new System.Windows.Forms.Panel();
            this.progressBarSimLoad = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.StartLoadingpnl.SuspendLayout();
            this.Homepnl.SuspendLayout();
            this.Inputpnl.SuspendLayout();
            this.processpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burstTimetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTimetxt)).BeginInit();
            this.simulatepnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.ganttChartpnl.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.simLoadpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartLoadingpnl
            // 
            this.StartLoadingpnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartLoadingpnl.BackgroundImage = global::CyberpunkSRTF.Properties.Resources.LoadingPage;
            this.StartLoadingpnl.Controls.Add(this.progressBarStartlbl);
            this.StartLoadingpnl.Controls.Add(this.progressBarStart);
            this.StartLoadingpnl.Controls.Add(this.label1);
            this.StartLoadingpnl.Location = new System.Drawing.Point(0, 0);
            this.StartLoadingpnl.Name = "StartLoadingpnl";
            this.StartLoadingpnl.Size = new System.Drawing.Size(1382, 853);
            this.StartLoadingpnl.TabIndex = 0;
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
            // LoadingStart
            // 
            this.LoadingStart.Interval = 2;
            this.LoadingStart.Tick += new System.EventHandler(this.LoadingStart_Tick);
            // 
            // Homepnl
            // 
            this.Homepnl.BackgroundImage = global::CyberpunkSRTF.Properties.Resources.HomePage;
            this.Homepnl.Controls.Add(this.label3);
            this.Homepnl.Controls.Add(this.label2);
            this.Homepnl.Controls.Add(this.Startbtn);
            this.Homepnl.Location = new System.Drawing.Point(0, 0);
            this.Homepnl.Name = "Homepnl";
            this.Homepnl.Size = new System.Drawing.Size(1400, 900);
            this.Homepnl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Equinox Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1131, 190);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPU SCHEDULING\r\nSIMULATION PROGRAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Conthrax Regular", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1210, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "[Algorithm: Shortest Remaining Time First ]";
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
            // Inputpnl
            // 
            this.Inputpnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Inputpnl.BackgroundImage")));
            this.Inputpnl.Controls.Add(this.numProcesstxt);
            this.Inputpnl.Controls.Add(this.textBox4);
            this.Inputpnl.Controls.Add(this.simulatebtn);
            this.Inputpnl.Controls.Add(this.addProcessbtn);
            this.Inputpnl.Controls.Add(this.processNumlbl);
            this.Inputpnl.Controls.Add(this.processpnl);
            this.Inputpnl.Controls.Add(this.numProcessConfirmbtn);
            this.Inputpnl.Controls.Add(this.label4);
            this.Inputpnl.Location = new System.Drawing.Point(0, 0);
            this.Inputpnl.Name = "Inputpnl";
            this.Inputpnl.Size = new System.Drawing.Size(1382, 853);
            this.Inputpnl.TabIndex = 0;
            // 
            // numProcesstxt
            // 
            this.numProcesstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(157)))));
            this.numProcesstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numProcesstxt.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numProcesstxt.ForeColor = System.Drawing.Color.White;
            this.numProcesstxt.Location = new System.Drawing.Point(106, 166);
            this.numProcesstxt.Name = "numProcesstxt";
            this.numProcesstxt.Size = new System.Drawing.Size(308, 33);
            this.numProcesstxt.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(157)))));
            this.textBox4.CausesValidation = false;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(100, 164);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(316, 40);
            this.textBox4.TabIndex = 0;
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
            this.simulatebtn.Location = new System.Drawing.Point(983, 695);
            this.simulatebtn.Name = "simulatebtn";
            this.simulatebtn.Size = new System.Drawing.Size(299, 46);
            this.simulatebtn.TabIndex = 7;
            this.simulatebtn.Text = "SIMULATE";
            this.simulatebtn.UseVisualStyleBackColor = false;
            this.simulatebtn.Click += new System.EventHandler(this.simulatebtn_Click);
            // 
            // addProcessbtn
            // 
            this.addProcessbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(203)))));
            this.addProcessbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProcessbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.addProcessbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProcessbtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProcessbtn.ForeColor = System.Drawing.Color.White;
            this.addProcessbtn.Location = new System.Drawing.Point(983, 639);
            this.addProcessbtn.Name = "addProcessbtn";
            this.addProcessbtn.Size = new System.Drawing.Size(299, 46);
            this.addProcessbtn.TabIndex = 6;
            this.addProcessbtn.Text = "ADD PROCESS";
            this.addProcessbtn.UseVisualStyleBackColor = false;
            this.addProcessbtn.Click += new System.EventHandler(this.addProcessbtn_Click);
            // 
            // processNumlbl
            // 
            this.processNumlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.processNumlbl.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processNumlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.processNumlbl.Location = new System.Drawing.Point(100, 394);
            this.processNumlbl.Name = "processNumlbl";
            this.processNumlbl.Size = new System.Drawing.Size(320, 46);
            this.processNumlbl.TabIndex = 5;
            this.processNumlbl.Text = "PROCESS #01:";
            this.processNumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processpnl
            // 
            this.processpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.processpnl.Controls.Add(this.processNametxt);
            this.processpnl.Controls.Add(this.textBox3);
            this.processpnl.Controls.Add(this.burstTimetxt);
            this.processpnl.Controls.Add(this.arrivalTimetxt);
            this.processpnl.Controls.Add(this.textBox1);
            this.processpnl.Controls.Add(this.textBox2);
            this.processpnl.Controls.Add(this.label8);
            this.processpnl.Controls.Add(this.label7);
            this.processpnl.Controls.Add(this.label5);
            this.processpnl.Location = new System.Drawing.Point(100, 445);
            this.processpnl.Name = "processpnl";
            this.processpnl.Size = new System.Drawing.Size(1182, 184);
            this.processpnl.TabIndex = 4;
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
            // burstTimetxt
            // 
            this.burstTimetxt.AutoSize = true;
            this.burstTimetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.burstTimetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.burstTimetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.burstTimetxt.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.burstTimetxt.ForeColor = System.Drawing.Color.White;
            this.burstTimetxt.Location = new System.Drawing.Point(838, 96);
            this.burstTimetxt.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.burstTimetxt.MaximumSize = new System.Drawing.Size(316, 0);
            this.burstTimetxt.Name = "burstTimetxt";
            this.burstTimetxt.Size = new System.Drawing.Size(310, 36);
            this.burstTimetxt.TabIndex = 9;
            // 
            // arrivalTimetxt
            // 
            this.arrivalTimetxt.AutoSize = true;
            this.arrivalTimetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.arrivalTimetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrivalTimetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.arrivalTimetxt.Font = new System.Drawing.Font("Product Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalTimetxt.ForeColor = System.Drawing.Color.White;
            this.arrivalTimetxt.Location = new System.Drawing.Point(442, 96);
            this.arrivalTimetxt.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.arrivalTimetxt.MaximumSize = new System.Drawing.Size(314, 0);
            this.arrivalTimetxt.Name = "arrivalTimetxt";
            this.arrivalTimetxt.Size = new System.Drawing.Size(310, 36);
            this.arrivalTimetxt.TabIndex = 8;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Conthrax Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(824, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 42);
            this.label8.TabIndex = 6;
            this.label8.Text = "Burst Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Conthrax Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(428, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 42);
            this.label7.TabIndex = 4;
            this.label7.Text = "Arrival Time:";
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
            // numProcessConfirmbtn
            // 
            this.numProcessConfirmbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(203)))));
            this.numProcessConfirmbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numProcessConfirmbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.numProcessConfirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numProcessConfirmbtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numProcessConfirmbtn.ForeColor = System.Drawing.Color.White;
            this.numProcessConfirmbtn.Location = new System.Drawing.Point(100, 219);
            this.numProcessConfirmbtn.Name = "numProcessConfirmbtn";
            this.numProcessConfirmbtn.Size = new System.Drawing.Size(200, 46);
            this.numProcessConfirmbtn.TabIndex = 3;
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
            this.label4.Location = new System.Drawing.Point(91, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "No. of Processes:";
            // 
            // simLoadtmr
            // 
            this.simLoadtmr.Interval = 20;
            this.simLoadtmr.Tick += new System.EventHandler(this.simLoadtmr_Tick);
            // 
            // processtmr
            // 
            this.processtmr.Interval = 10;
            // 
            // simulatepnl
            // 
            this.simulatepnl.AutoScroll = true;
            this.simulatepnl.AutoSize = true;
            this.simulatepnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simulatepnl.BackgroundImage")));
            this.simulatepnl.Controls.Add(this.panel2);
            this.simulatepnl.Controls.Add(this.panel1);
            this.simulatepnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulatepnl.Location = new System.Drawing.Point(0, 0);
            this.simulatepnl.Name = "simulatepnl";
            this.simulatepnl.Size = new System.Drawing.Size(1382, 853);
            this.simulatepnl.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.ganttChartpnl);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1361, 850);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.exitbtn);
            this.panel8.Controls.Add(this.rerunSimbtn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 704);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1361, 146);
            this.panel8.TabIndex = 9;
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
            // rerunSimbtn
            // 
            this.rerunSimbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(203)))));
            this.rerunSimbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rerunSimbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(241)))));
            this.rerunSimbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rerunSimbtn.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rerunSimbtn.ForeColor = System.Drawing.Color.White;
            this.rerunSimbtn.Location = new System.Drawing.Point(59, 50);
            this.rerunSimbtn.Name = "rerunSimbtn";
            this.rerunSimbtn.Size = new System.Drawing.Size(539, 46);
            this.rerunSimbtn.TabIndex = 8;
            this.rerunSimbtn.Text = "RUN ANOTHER SIMULATION";
            this.rerunSimbtn.UseVisualStyleBackColor = false;
            this.rerunSimbtn.Click += new System.EventHandler(this.rerunSimbtn_Click);
            // 
            // ganttChartpnl
            // 
            this.ganttChartpnl.BackColor = System.Drawing.Color.Transparent;
            this.ganttChartpnl.Controls.Add(this.panel7);
            this.ganttChartpnl.Controls.Add(this.label10);
            this.ganttChartpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ganttChartpnl.ForeColor = System.Drawing.Color.White;
            this.ganttChartpnl.Location = new System.Drawing.Point(0, 387);
            this.ganttChartpnl.Name = "ganttChartpnl";
            this.ganttChartpnl.Size = new System.Drawing.Size(1361, 317);
            this.ganttChartpnl.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.gcPane);
            this.panel7.Location = new System.Drawing.Point(59, 152);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1243, 165);
            this.panel7.TabIndex = 7;
            // 
            // gcPane
            // 
            this.gcPane.AutoScroll = true;
            this.gcPane.BackColor = System.Drawing.Color.Transparent;
            this.gcPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPane.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gcPane.Location = new System.Drawing.Point(0, 0);
            this.gcPane.Margin = new System.Windows.Forms.Padding(0);
            this.gcPane.Name = "gcPane";
            this.gcPane.Size = new System.Drawing.Size(1243, 165);
            this.gcPane.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Conthrax Regular", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(50, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 92);
            this.label10.TabIndex = 5;
            this.label10.Text = "Gantt\r\nChart:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.aveTaTimelbl);
            this.panel5.Controls.Add(this.aveWaitingTimelbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 243);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1361, 144);
            this.panel5.TabIndex = 3;
            // 
            // aveTaTimelbl
            // 
            this.aveTaTimelbl.AutoSize = true;
            this.aveTaTimelbl.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aveTaTimelbl.Location = new System.Drawing.Point(50, 107);
            this.aveTaTimelbl.Name = "aveTaTimelbl";
            this.aveTaTimelbl.Size = new System.Drawing.Size(563, 39);
            this.aveTaTimelbl.TabIndex = 1;
            this.aveTaTimelbl.Text = "Average Turnaround Time: 00";
            // 
            // aveWaitingTimelbl
            // 
            this.aveWaitingTimelbl.AutoSize = true;
            this.aveWaitingTimelbl.Font = new System.Drawing.Font("Conthrax Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aveWaitingTimelbl.Location = new System.Drawing.Point(50, 50);
            this.aveWaitingTimelbl.Name = "aveWaitingTimelbl";
            this.aveWaitingTimelbl.Size = new System.Drawing.Size(471, 39);
            this.aveWaitingTimelbl.TabIndex = 0;
            this.aveWaitingTimelbl.Text = "Average Waiting Time: 00";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.hidepnl);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.processlview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1361, 243);
            this.panel3.TabIndex = 2;
            // 
            // hidepnl
            // 
            this.hidepnl.Location = new System.Drawing.Point(1302, 202);
            this.hidepnl.Name = "hidepnl";
            this.hidepnl.Size = new System.Drawing.Size(59, 38);
            this.hidepnl.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Conthrax Regular", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(50, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 92);
            this.label9.TabIndex = 4;
            this.label9.Text = "Process\r\nExecution Table:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1361, 66);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(59, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1243, 2);
            this.panel6.TabIndex = 4;
            // 
            // processlview
            // 
            this.processlview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(115)))));
            this.processlview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processlview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processNamecol,
            this.arrivalTimecol,
            this.burstTimecol,
            this.waitingTimecol,
            this.taTimecol});
            this.processlview.Font = new System.Drawing.Font("Conthrax Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processlview.ForeColor = System.Drawing.Color.White;
            this.processlview.GridLines = true;
            this.processlview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.processlview.HideSelection = false;
            this.processlview.Location = new System.Drawing.Point(59, 202);
            this.processlview.Name = "processlview";
            this.processlview.Scrollable = false;
            this.processlview.Size = new System.Drawing.Size(1243, 38);
            this.processlview.TabIndex = 0;
            this.processlview.UseCompatibleStateImageBehavior = false;
            this.processlview.View = System.Windows.Forms.View.Details;
            // 
            // processNamecol
            // 
            this.processNamecol.Text = "Process Name";
            this.processNamecol.Width = 290;
            // 
            // arrivalTimecol
            // 
            this.arrivalTimecol.Text = "Arrival Time";
            this.arrivalTimecol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arrivalTimecol.Width = 219;
            // 
            // burstTimecol
            // 
            this.burstTimecol.Text = "Burst Time";
            this.burstTimecol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.burstTimecol.Width = 202;
            // 
            // waitingTimecol
            // 
            this.waitingTimecol.Text = "Waiting Time";
            this.waitingTimecol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.waitingTimecol.Width = 232;
            // 
            // taTimecol
            // 
            this.taTimecol.Text = "Turnaround Time";
            this.taTimecol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.taTimecol.Width = 317;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.statuspnl);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 156);
            this.panel1.TabIndex = 0;
            // 
            // statuspnl
            // 
            this.statuspnl.AutoSize = true;
            this.statuspnl.ForeColor = System.Drawing.Color.White;
            this.statuspnl.Location = new System.Drawing.Point(492, 103);
            this.statuspnl.Name = "statuspnl";
            this.statuspnl.Size = new System.Drawing.Size(813, 50);
            this.statuspnl.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Conthrax Regular", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(50, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(410, 92);
            this.label13.TabIndex = 5;
            this.label13.Text = "Process\r\nExecution Status:";
            // 
            // simLoadpnl
            // 
            this.simLoadpnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simLoadpnl.BackgroundImage")));
            this.simLoadpnl.Controls.Add(this.progressBarSimLoad);
            this.simLoadpnl.Controls.Add(this.label6);
            this.simLoadpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simLoadpnl.Location = new System.Drawing.Point(0, 0);
            this.simLoadpnl.Name = "simLoadpnl";
            this.simLoadpnl.Size = new System.Drawing.Size(1382, 853);
            this.simLoadpnl.TabIndex = 3;
            // 
            // progressBarSimLoad
            // 
            this.progressBarSimLoad.Location = new System.Drawing.Point(117, 442);
            this.progressBarSimLoad.Name = "progressBarSimLoad";
            this.progressBarSimLoad.Size = new System.Drawing.Size(1150, 20);
            this.progressBarSimLoad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Conthrax Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(561, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "SIMULATING...";
            // 
            // CyberpunkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.Inputpnl);
            this.Controls.Add(this.simLoadpnl);
            this.Controls.Add(this.simulatepnl);
            this.Controls.Add(this.StartLoadingpnl);
            this.Controls.Add(this.Homepnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 900);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "CyberpunkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Scheduling Simulation Program";
            this.Load += new System.EventHandler(this.CyberpunkForm_Load);
            this.StartLoadingpnl.ResumeLayout(false);
            this.StartLoadingpnl.PerformLayout();
            this.Homepnl.ResumeLayout(false);
            this.Homepnl.PerformLayout();
            this.Inputpnl.ResumeLayout(false);
            this.Inputpnl.PerformLayout();
            this.processpnl.ResumeLayout(false);
            this.processpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burstTimetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTimetxt)).EndInit();
            this.simulatepnl.ResumeLayout(false);
            this.simulatepnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ganttChartpnl.ResumeLayout(false);
            this.ganttChartpnl.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.simLoadpnl.ResumeLayout(false);
            this.simLoadpnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel StartLoadingpnl;
        private System.Windows.Forms.Label progressBarStartlbl;
        private System.Windows.Forms.ProgressBar progressBarStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer LoadingStart;
        private System.Windows.Forms.Panel Homepnl;
        private System.Windows.Forms.Panel Inputpnl;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label processNumlbl;
        private System.Windows.Forms.Panel processpnl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox processNametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button numProcessConfirmbtn;
        private System.Windows.Forms.TextBox numProcesstxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button simulatebtn;
        private System.Windows.Forms.Button addProcessbtn;
        private System.Windows.Forms.Timer simLoadtmr;
        private System.Windows.Forms.Timer processtmr;
        private System.Windows.Forms.NumericUpDown arrivalTimetxt;
        private System.Windows.Forms.NumericUpDown burstTimetxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel simulatepnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView processlview;
        private System.Windows.Forms.ColumnHeader processNamecol;
        private System.Windows.Forms.ColumnHeader arrivalTimecol;
        private System.Windows.Forms.ColumnHeader burstTimecol;
        private System.Windows.Forms.ColumnHeader waitingTimecol;
        private System.Windows.Forms.ColumnHeader taTimecol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button rerunSimbtn;
        private System.Windows.Forms.Panel ganttChartpnl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label aveTaTimelbl;
        private System.Windows.Forms.Label aveWaitingTimelbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel hidepnl;
        private System.Windows.Forms.Panel gcPane;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel simLoadpnl;
        private System.Windows.Forms.ProgressBar progressBarSimLoad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel statuspnl;
    }
}

