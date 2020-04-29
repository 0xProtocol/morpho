namespace Management_Tool_SZU.Server.GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxNetwork = new System.Windows.Forms.TextBox();
            this.lsb_networkadapter = new System.Windows.Forms.ListBox();
            this.tcWindow = new System.Windows.Forms.TabControl();
            this.tcNetworkDicovery = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.lblStepFive = new System.Windows.Forms.Label();
            this.lblStepOne = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxuserip = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpui = new System.Windows.Forms.GroupBox();
            this.tbxpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxusername = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbNetworkAdapter = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLogicalDisk = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDiskDrive = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbComputerSystem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBaseBoard = new System.Windows.Forms.ComboBox();
            this.cbAlternative = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBIOS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboperatingsystem = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Discover = new System.Windows.Forms.Button();
            this.pbnetwork = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_Discovery = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblSearchIP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lsb_discover = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblCheck4 = new System.Windows.Forms.Label();
            this.lblCheck3 = new System.Windows.Forms.Label();
            this.lblCheck2 = new System.Windows.Forms.Label();
            this.lblCheck1 = new System.Windows.Forms.Label();
            this.lblCheck5 = new System.Windows.Forms.Label();
            this.lblStepTwo = new System.Windows.Forms.Label();
            this.lblStepFour = new System.Windows.Forms.Label();
            this.lblStepThree = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tcStatistics = new System.Windows.Forms.TabPage();
            this.lvstatistics = new System.Windows.Forms.ListView();
            this.Property = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAllIPs = new System.Windows.Forms.CheckBox();
            this.cb = new Management_Tool_SZU.Server.GUI.CircularButton();
            this.tcWindow.SuspendLayout();
            this.tcNetworkDicovery.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpui.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tcStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNetwork
            // 
            this.tbxNetwork.Location = new System.Drawing.Point(9, 130);
            this.tbxNetwork.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxNetwork.Name = "tbxNetwork";
            this.tbxNetwork.Size = new System.Drawing.Size(225, 23);
            this.tbxNetwork.TabIndex = 91;
            this.tbxNetwork.TextChanged += new System.EventHandler(this.TbxNetwork_TextChanged);
            // 
            // lsb_networkadapter
            // 
            this.lsb_networkadapter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lsb_networkadapter.ForeColor = System.Drawing.Color.Black;
            this.lsb_networkadapter.FormattingEnabled = true;
            this.lsb_networkadapter.ItemHeight = 16;
            this.lsb_networkadapter.Location = new System.Drawing.Point(24, 20);
            this.lsb_networkadapter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lsb_networkadapter.Name = "lsb_networkadapter";
            this.lsb_networkadapter.Size = new System.Drawing.Size(1267, 308);
            this.lsb_networkadapter.TabIndex = 92;
            this.lsb_networkadapter.SelectedIndexChanged += new System.EventHandler(this.Lsb_networkadapter_SelectedIndexChanged);
            // 
            // tcWindow
            // 
            this.tcWindow.Controls.Add(this.tcNetworkDicovery);
            this.tcWindow.Controls.Add(this.tcStatistics);
            this.tcWindow.Font = new System.Drawing.Font("Rockwell", 7.8F);
            this.tcWindow.Location = new System.Drawing.Point(45, 43);
            this.tcWindow.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tcWindow.Name = "tcWindow";
            this.tcWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcWindow.SelectedIndex = 0;
            this.tcWindow.Size = new System.Drawing.Size(1763, 721);
            this.tcWindow.TabIndex = 91;
            // 
            // tcNetworkDicovery
            // 
            this.tcNetworkDicovery.BackColor = System.Drawing.Color.DodgerBlue;
            this.tcNetworkDicovery.Controls.Add(this.groupBox5);
            this.tcNetworkDicovery.Controls.Add(this.label12);
            this.tcNetworkDicovery.Controls.Add(this.lblStepFive);
            this.tcNetworkDicovery.Controls.Add(this.lblStepOne);
            this.tcNetworkDicovery.Controls.Add(this.gpui);
            this.tcNetworkDicovery.Controls.Add(this.groupBox3);
            this.tcNetworkDicovery.Controls.Add(this.groupBox2);
            this.tcNetworkDicovery.Controls.Add(this.groupBox1);
            this.tcNetworkDicovery.Controls.Add(this.pictureBox1);
            this.tcNetworkDicovery.Controls.Add(this.panel7);
            this.tcNetworkDicovery.Controls.Add(this.panel5);
            this.tcNetworkDicovery.Controls.Add(this.panel3);
            this.tcNetworkDicovery.Controls.Add(this.panel4);
            this.tcNetworkDicovery.Controls.Add(this.lsb_networkadapter);
            this.tcNetworkDicovery.Controls.Add(this.lsb_discover);
            this.tcNetworkDicovery.Controls.Add(this.groupBox7);
            this.tcNetworkDicovery.Controls.Add(this.groupBox6);
            this.tcNetworkDicovery.Location = new System.Drawing.Point(4, 25);
            this.tcNetworkDicovery.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tcNetworkDicovery.Name = "tcNetworkDicovery";
            this.tcNetworkDicovery.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tcNetworkDicovery.Size = new System.Drawing.Size(1755, 692);
            this.tcNetworkDicovery.TabIndex = 2;
            this.tcNetworkDicovery.Text = "Network Discovery";
            this.tcNetworkDicovery.Click += new System.EventHandler(this.TcNetworkDicovery_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(83, 633);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 37);
            this.label12.TabIndex = 106;
            this.label12.Text = "A product by 3EIC ";
            // 
            // lblStepFive
            // 
            this.lblStepFive.AutoSize = true;
            this.lblStepFive.Font = new System.Drawing.Font("Rockwell", 6.7F);
            this.lblStepFive.Location = new System.Drawing.Point(25, 500);
            this.lblStepFive.Name = "lblStepFive";
            this.lblStepFive.Size = new System.Drawing.Size(301, 14);
            this.lblStepFive.TabIndex = 113;
            this.lblStepFive.Text = "5. The receiving of the client information has started:";
            // 
            // lblStepOne
            // 
            this.lblStepOne.AutoSize = true;
            this.lblStepOne.Font = new System.Drawing.Font("Rockwell", 7.5F);
            this.lblStepOne.Location = new System.Drawing.Point(25, 365);
            this.lblStepOne.Name = "lblStepOne";
            this.lblStepOne.Size = new System.Drawing.Size(247, 16);
            this.lblStepOne.TabIndex = 109;
            this.lblStepOne.Text = "1. The Network adapter has been chosen:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.tbxuserip);
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Font = new System.Drawing.Font("Rockwell", 7.8F);
            this.groupBox5.Location = new System.Drawing.Point(936, 342);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(348, 182);
            this.groupBox5.TabIndex = 107;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Elements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "Selected IP:";
            // 
            // tbxuserip
            // 
            this.tbxuserip.Location = new System.Drawing.Point(12, 59);
            this.tbxuserip.Margin = new System.Windows.Forms.Padding(4);
            this.tbxuserip.Name = "tbxuserip";
            this.tbxuserip.ReadOnly = true;
            this.tbxuserip.Size = new System.Drawing.Size(328, 23);
            this.tbxuserip.TabIndex = 105;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Management_Tool_SZU.Server.GUI.Properties.Resources.network;
            this.pictureBox2.Location = new System.Drawing.Point(11, 87);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(329, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 108;
            this.pictureBox2.TabStop = false;
            // 
            // gpui
            // 
            this.gpui.Controls.Add(this.tbxpassword);
            this.gpui.Controls.Add(this.label2);
            this.gpui.Controls.Add(this.label1);
            this.gpui.Controls.Add(this.tbxusername);
            this.gpui.Location = new System.Drawing.Point(656, 342);
            this.gpui.Margin = new System.Windows.Forms.Padding(4);
            this.gpui.Name = "gpui";
            this.gpui.Padding = new System.Windows.Forms.Padding(4);
            this.gpui.Size = new System.Drawing.Size(272, 182);
            this.gpui.TabIndex = 106;
            this.gpui.TabStop = false;
            this.gpui.Text = "User Information";
            // 
            // tbxpassword
            // 
            this.tbxpassword.Location = new System.Drawing.Point(12, 130);
            this.tbxpassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxpassword.Name = "tbxpassword";
            this.tbxpassword.Size = new System.Drawing.Size(251, 23);
            this.tbxpassword.TabIndex = 103;
            this.tbxpassword.TextChanged += new System.EventHandler(this.tbxpassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "Username: ";
            // 
            // tbxusername
            // 
            this.tbxusername.Location = new System.Drawing.Point(8, 62);
            this.tbxusername.Margin = new System.Windows.Forms.Padding(4);
            this.tbxusername.Name = "tbxusername";
            this.tbxusername.Size = new System.Drawing.Size(255, 23);
            this.tbxusername.TabIndex = 0;
            this.tbxusername.TextChanged += new System.EventHandler(this.tbxusername_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbAllIPs);
            this.groupBox3.Controls.Add(this.btnNone);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cbNetworkAdapter);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbLogicalDisk);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbDiskDrive);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbComputerSystem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbBaseBoard);
            this.groupBox3.Controls.Add(this.cbAlternative);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbBIOS);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cboperatingsystem);
            this.groupBox3.Location = new System.Drawing.Point(656, 532);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1075, 142);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistic";
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(688, 22);
            this.btnNone.Margin = new System.Windows.Forms.Padding(4);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(209, 26);
            this.btnNone.TabIndex = 125;
            this.btnNone.Text = "Select None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.BtnNone_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 26);
            this.button1.TabIndex = 123;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // cbNetworkAdapter
            // 
            this.cbNetworkAdapter.FormattingEnabled = true;
            this.cbNetworkAdapter.Items.AddRange(new object[] {
            "Description",
            "Manufacturer",
            "MacAddress",
            "Name",
            "Adaptertype",
            "Installed",
            "All",
            " "});
            this.cbNetworkAdapter.Location = new System.Drawing.Point(516, 50);
            this.cbNetworkAdapter.Margin = new System.Windows.Forms.Padding(4);
            this.cbNetworkAdapter.Name = "cbNetworkAdapter";
            this.cbNetworkAdapter.Size = new System.Drawing.Size(160, 24);
            this.cbNetworkAdapter.TabIndex = 122;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 17);
            this.label11.TabIndex = 121;
            this.label11.Text = "Network Adapter:";
            // 
            // cbLogicalDisk
            // 
            this.cbLogicalDisk.FormattingEnabled = true;
            this.cbLogicalDisk.Items.AddRange(new object[] {
            "Caption",
            "FileSystem",
            "Size",
            "All",
            " "});
            this.cbLogicalDisk.Location = new System.Drawing.Point(347, 98);
            this.cbLogicalDisk.Margin = new System.Windows.Forms.Padding(4);
            this.cbLogicalDisk.Name = "cbLogicalDisk";
            this.cbLogicalDisk.Size = new System.Drawing.Size(160, 24);
            this.cbLogicalDisk.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 119;
            this.label10.Text = "Logical Disk:";
            // 
            // cbDiskDrive
            // 
            this.cbDiskDrive.FormattingEnabled = true;
            this.cbDiskDrive.Items.AddRange(new object[] {
            "Caption",
            "MediaLoaded",
            "Status",
            "Size",
            "All",
            " "});
            this.cbDiskDrive.Location = new System.Drawing.Point(347, 50);
            this.cbDiskDrive.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiskDrive.Name = "cbDiskDrive";
            this.cbDiskDrive.Size = new System.Drawing.Size(160, 24);
            this.cbDiskDrive.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 117;
            this.label9.Text = "Diskdrive:";
            // 
            // cbComputerSystem
            // 
            this.cbComputerSystem.FormattingEnabled = true;
            this.cbComputerSystem.Items.AddRange(new object[] {
            "Adminpasswortstatus",
            "CurrentTimeZone",
            "DNSHostname",
            "PrimaryOwner",
            "Name",
            "Status",
            "Workgroup",
            "All",
            " "});
            this.cbComputerSystem.Location = new System.Drawing.Point(177, 98);
            this.cbComputerSystem.Margin = new System.Windows.Forms.Padding(4);
            this.cbComputerSystem.Name = "cbComputerSystem";
            this.cbComputerSystem.Size = new System.Drawing.Size(160, 24);
            this.cbComputerSystem.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 115;
            this.label8.Text = "Computersystem:";
            // 
            // cbBaseBoard
            // 
            this.cbBaseBoard.FormattingEnabled = true;
            this.cbBaseBoard.Items.AddRange(new object[] {
            "Manufacturer",
            "Serialnumber",
            "Status",
            "All",
            " "});
            this.cbBaseBoard.Location = new System.Drawing.Point(177, 50);
            this.cbBaseBoard.Margin = new System.Windows.Forms.Padding(4);
            this.cbBaseBoard.Name = "cbBaseBoard";
            this.cbBaseBoard.Size = new System.Drawing.Size(160, 24);
            this.cbBaseBoard.TabIndex = 114;
            // 
            // cbAlternative
            // 
            this.cbAlternative.FormattingEnabled = true;
            this.cbAlternative.Items.AddRange(new object[] {
            "Lastbootuptime",
            "Timezonedescription",
            "Systemtimezonesetting",
            "All",
            " "});
            this.cbAlternative.Location = new System.Drawing.Point(520, 98);
            this.cbAlternative.Margin = new System.Windows.Forms.Padding(4);
            this.cbAlternative.Name = "cbAlternative";
            this.cbAlternative.Size = new System.Drawing.Size(160, 24);
            this.cbAlternative.TabIndex = 113;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 112;
            this.label7.Text = "Alternative Informations: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 111;
            this.label6.Text = "Baseboard:";
            // 
            // cbBIOS
            // 
            this.cbBIOS.FormattingEnabled = true;
            this.cbBIOS.Items.AddRange(new object[] {
            "Manufacturer",
            "Version",
            "Status",
            "All",
            " "});
            this.cbBIOS.Location = new System.Drawing.Point(8, 98);
            this.cbBIOS.Margin = new System.Windows.Forms.Padding(4);
            this.cbBIOS.Name = "cbBIOS";
            this.cbBIOS.Size = new System.Drawing.Size(160, 24);
            this.cbBIOS.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 109;
            this.label5.Text = "BIOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 104;
            this.label4.Text = "Operating System:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb);
            this.groupBox4.Location = new System.Drawing.Point(905, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(161, 119);
            this.groupBox4.TabIndex = 108;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action";
            // 
            // cboperatingsystem
            // 
            this.cboperatingsystem.BackColor = System.Drawing.SystemColors.Window;
            this.cboperatingsystem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboperatingsystem.FormattingEnabled = true;
            this.cboperatingsystem.Items.AddRange(new object[] {
            "Name",
            "Architecture",
            "Install Date",
            "Registered User",
            "Version",
            "Status",
            "All",
            " "});
            this.cboperatingsystem.Location = new System.Drawing.Point(8, 50);
            this.cboperatingsystem.Margin = new System.Windows.Forms.Padding(4);
            this.cboperatingsystem.Name = "cboperatingsystem";
            this.cboperatingsystem.Size = new System.Drawing.Size(160, 24);
            this.cboperatingsystem.TabIndex = 107;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Discover);
            this.groupBox2.Controls.Add(this.pbnetwork);
            this.groupBox2.Controls.Add(this.lblLoading);
            this.groupBox2.Location = new System.Drawing.Point(403, 532);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(245, 139);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discovery";
            // 
            // btn_Discover
            // 
            this.btn_Discover.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Discover.Location = new System.Drawing.Point(9, 82);
            this.btn_Discover.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Discover.Name = "btn_Discover";
            this.btn_Discover.Size = new System.Drawing.Size(227, 44);
            this.btn_Discover.TabIndex = 83;
            this.btn_Discover.Text = "Start Discovery";
            this.btn_Discover.UseVisualStyleBackColor = true;
            this.btn_Discover.Click += new System.EventHandler(this.Btn_Discover_Click_1);
            // 
            // pbnetwork
            // 
            this.pbnetwork.BackColor = System.Drawing.Color.Blue;
            this.pbnetwork.ForeColor = System.Drawing.Color.Blue;
            this.pbnetwork.Location = new System.Drawing.Point(9, 50);
            this.pbnetwork.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbnetwork.Name = "pbnetwork";
            this.pbnetwork.Size = new System.Drawing.Size(227, 25);
            this.pbnetwork.TabIndex = 89;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(8, 31);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(125, 17);
            this.lblLoading.TabIndex = 101;
            this.lblLoading.Text = "Loading Progress:";
            this.lblLoading.Click += new System.EventHandler(this.LblLoading_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_Discovery);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.tbxNetwork);
            this.groupBox1.Controls.Add(this.lblSearchIP);
            this.groupBox1.Location = new System.Drawing.Point(403, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(245, 182);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discovery Configuration";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // tbx_Discovery
            // 
            this.tbx_Discovery.Location = new System.Drawing.Point(9, 62);
            this.tbx_Discovery.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbx_Discovery.Name = "tbx_Discovery";
            this.tbx_Discovery.Size = new System.Drawing.Size(225, 23);
            this.tbx_Discovery.TabIndex = 84;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(8, 42);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(82, 17);
            this.lblIP.TabIndex = 99;
            this.lblIP.Text = "IP-Adresse:";
            // 
            // lblSearchIP
            // 
            this.lblSearchIP.AutoSize = true;
            this.lblSearchIP.Location = new System.Drawing.Point(8, 107);
            this.lblSearchIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchIP.Name = "lblSearchIP";
            this.lblSearchIP.Size = new System.Drawing.Size(89, 17);
            this.lblSearchIP.TabIndex = 100;
            this.lblSearchIP.Text = "Subnetmask:";
            this.lblSearchIP.Click += new System.EventHandler(this.LblSearchIP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Management_Tool_SZU.Server.GUI.Properties.Resources.morpho2;
            this.pictureBox1.Location = new System.Drawing.Point(130, 530);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Blue;
            this.panel7.Location = new System.Drawing.Point(0, 1);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 689);
            this.panel7.TabIndex = 98;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(1739, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 688);
            this.panel5.TabIndex = 95;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(9, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1743, 12);
            this.panel3.TabIndex = 95;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(4, 678);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1748, 12);
            this.panel4.TabIndex = 96;
            // 
            // lsb_discover
            // 
            this.lsb_discover.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lsb_discover.FormattingEnabled = true;
            this.lsb_discover.ItemHeight = 16;
            this.lsb_discover.Location = new System.Drawing.Point(1303, 20);
            this.lsb_discover.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lsb_discover.Name = "lsb_discover";
            this.lsb_discover.Size = new System.Drawing.Size(425, 500);
            this.lsb_discover.TabIndex = 82;
            this.lsb_discover.SelectedIndexChanged += new System.EventHandler(this.Lsb_discover_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblCheck4);
            this.groupBox7.Controls.Add(this.lblCheck3);
            this.groupBox7.Controls.Add(this.lblCheck2);
            this.groupBox7.Controls.Add(this.lblCheck1);
            this.groupBox7.Controls.Add(this.lblCheck5);
            this.groupBox7.Controls.Add(this.lblStepTwo);
            this.groupBox7.Controls.Add(this.lblStepFour);
            this.groupBox7.Controls.Add(this.lblStepThree);
            this.groupBox7.Location = new System.Drawing.Point(21, 342);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(374, 182);
            this.groupBox7.TabIndex = 104;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Program Checklist";
            // 
            // lblCheck4
            // 
            this.lblCheck4.AutoSize = true;
            this.lblCheck4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCheck4.Font = new System.Drawing.Font("Rockwell", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblCheck4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCheck4.Location = new System.Drawing.Point(322, 123);
            this.lblCheck4.Name = "lblCheck4";
            this.lblCheck4.Size = new System.Drawing.Size(26, 20);
            this.lblCheck4.TabIndex = 117;
            this.lblCheck4.Text = "✔";
            // 
            // lblCheck3
            // 
            this.lblCheck3.AutoSize = true;
            this.lblCheck3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCheck3.Font = new System.Drawing.Font("Rockwell", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblCheck3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCheck3.Location = new System.Drawing.Point(322, 89);
            this.lblCheck3.Name = "lblCheck3";
            this.lblCheck3.Size = new System.Drawing.Size(26, 20);
            this.lblCheck3.TabIndex = 116;
            this.lblCheck3.Text = "✔";
            // 
            // lblCheck2
            // 
            this.lblCheck2.AutoSize = true;
            this.lblCheck2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCheck2.Font = new System.Drawing.Font("Rockwell", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblCheck2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCheck2.Location = new System.Drawing.Point(322, 54);
            this.lblCheck2.Name = "lblCheck2";
            this.lblCheck2.Size = new System.Drawing.Size(26, 20);
            this.lblCheck2.TabIndex = 115;
            this.lblCheck2.Text = "✔";
            // 
            // lblCheck1
            // 
            this.lblCheck1.AutoSize = true;
            this.lblCheck1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCheck1.Font = new System.Drawing.Font("Rockwell", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblCheck1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCheck1.Location = new System.Drawing.Point(322, 18);
            this.lblCheck1.Name = "lblCheck1";
            this.lblCheck1.Size = new System.Drawing.Size(26, 20);
            this.lblCheck1.TabIndex = 114;
            this.lblCheck1.Text = "✔";
            // 
            // lblCheck5
            // 
            this.lblCheck5.AutoSize = true;
            this.lblCheck5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCheck5.Font = new System.Drawing.Font("Rockwell", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblCheck5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCheck5.Location = new System.Drawing.Point(322, 154);
            this.lblCheck5.Name = "lblCheck5";
            this.lblCheck5.Size = new System.Drawing.Size(26, 20);
            this.lblCheck5.TabIndex = 113;
            this.lblCheck5.Text = "✔";
            // 
            // lblStepTwo
            // 
            this.lblStepTwo.AutoSize = true;
            this.lblStepTwo.Font = new System.Drawing.Font("Rockwell", 7.5F);
            this.lblStepTwo.Location = new System.Drawing.Point(4, 51);
            this.lblStepTwo.Name = "lblStepTwo";
            this.lblStepTwo.Size = new System.Drawing.Size(274, 32);
            this.lblStepTwo.TabIndex = 110;
            this.lblStepTwo.Text = "2. The Network Discovery searching progress \r\nhas been started:";
            // 
            // lblStepFour
            // 
            this.lblStepFour.AutoSize = true;
            this.lblStepFour.Font = new System.Drawing.Font("Rockwell", 7.5F);
            this.lblStepFour.Location = new System.Drawing.Point(4, 131);
            this.lblStepFour.Name = "lblStepFour";
            this.lblStepFour.Size = new System.Drawing.Size(246, 16);
            this.lblStepFour.TabIndex = 112;
            this.lblStepFour.Text = "4. All clients will be asked for information:";
            // 
            // lblStepThree
            // 
            this.lblStepThree.AutoSize = true;
            this.lblStepThree.Font = new System.Drawing.Font("Rockwell", 7.5F);
            this.lblStepThree.Location = new System.Drawing.Point(4, 92);
            this.lblStepThree.Name = "lblStepThree";
            this.lblStepThree.Size = new System.Drawing.Size(265, 32);
            this.lblStepThree.TabIndex = 111;
            this.lblStepThree.Text = "3. The Username and the password from the \r\nclient has been entered:";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(21, 342);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(245, 182);
            this.groupBox6.TabIndex = 104;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Discovery Configuration";
            // 
            // tcStatistics
            // 
            this.tcStatistics.BackColor = System.Drawing.Color.DodgerBlue;
            this.tcStatistics.Controls.Add(this.lvstatistics);
            this.tcStatistics.Controls.Add(this.panel8);
            this.tcStatistics.Controls.Add(this.panel6);
            this.tcStatistics.Controls.Add(this.panel2);
            this.tcStatistics.Controls.Add(this.panel1);
            this.tcStatistics.Location = new System.Drawing.Point(4, 25);
            this.tcStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.tcStatistics.Name = "tcStatistics";
            this.tcStatistics.Size = new System.Drawing.Size(1755, 692);
            this.tcStatistics.TabIndex = 3;
            this.tcStatistics.Text = "Statistics";
            // 
            // lvstatistics
            // 
            this.lvstatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Property,
            this.Result});
            this.lvstatistics.GridLines = true;
            this.lvstatistics.HideSelection = false;
            this.lvstatistics.Location = new System.Drawing.Point(21, 31);
            this.lvstatistics.Margin = new System.Windows.Forms.Padding(4);
            this.lvstatistics.Name = "lvstatistics";
            this.lvstatistics.Size = new System.Drawing.Size(1708, 639);
            this.lvstatistics.TabIndex = 101;
            this.lvstatistics.UseCompatibleStateImageBehavior = false;
            this.lvstatistics.View = System.Windows.Forms.View.Details;
            // 
            // Property
            // 
            this.Property.Text = "Property";
            this.Property.Width = 113;
            // 
            // Result
            // 
            this.Result.Text = "Result";
            this.Result.Width = 155;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Blue;
            this.panel8.Location = new System.Drawing.Point(1739, 1);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(13, 689);
            this.panel8.TabIndex = 100;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Location = new System.Drawing.Point(0, 1);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 689);
            this.panel6.TabIndex = 99;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(9, 678);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1743, 12);
            this.panel2.TabIndex = 97;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(9, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1743, 12);
            this.panel1.TabIndex = 96;
            // 
            // cbAllIPs
            // 
            this.cbAllIPs.AutoSize = true;
            this.cbAllIPs.Location = new System.Drawing.Point(800, 89);
            this.cbAllIPs.Name = "cbAllIPs";
            this.cbAllIPs.Size = new System.Drawing.Size(97, 21);
            this.cbAllIPs.TabIndex = 126;
            this.cbAllIPs.Text = "All Clients";
            this.cbAllIPs.UseVisualStyleBackColor = true;
            this.cbAllIPs.CheckedChanged += new System.EventHandler(this.cbAllIPs_CheckedChanged);
            // 
            // cb
            // 
            this.cb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cb.Font = new System.Drawing.Font("Rockwell", 10F);
            this.cb.Location = new System.Drawing.Point(29, 18);
            this.cb.Margin = new System.Windows.Forms.Padding(4);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(105, 94);
            this.cb.TabIndex = 106;
            this.cb.Text = "Morph it!";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.Click += new System.EventHandler(this.Cb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1849, 818);
            this.Controls.Add(this.tcWindow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ServerSettings_Load);
            this.tcWindow.ResumeLayout(false);
            this.tcNetworkDicovery.ResumeLayout(false);
            this.tcNetworkDicovery.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpui.ResumeLayout(false);
            this.gpui.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tcStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNetwork;
        private System.Windows.Forms.ListBox lsb_networkadapter;
        private System.Windows.Forms.TabControl tcWindow;
        private System.Windows.Forms.TabPage tcNetworkDicovery;
        private System.Windows.Forms.ListBox lsb_discover;
        private System.Windows.Forms.Button btn_Discover;
        private System.Windows.Forms.ProgressBar pbnetwork;
        private System.Windows.Forms.TextBox tbx_Discovery;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblSearchIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tcStatistics;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private CircularButton cb;
        private System.Windows.Forms.GroupBox gpui;
        private System.Windows.Forms.TextBox tbxpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxusername;
        private System.Windows.Forms.TextBox tbxuserip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboperatingsystem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvstatistics;
        private System.Windows.Forms.ColumnHeader Property;
        private System.Windows.Forms.ColumnHeader Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBIOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAlternative;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBaseBoard;
        private System.Windows.Forms.ComboBox cbComputerSystem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLogicalDisk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDiskDrive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbNetworkAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblStepFive;
        private System.Windows.Forms.Label lblStepOne;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblCheck5;
        private System.Windows.Forms.Label lblStepTwo;
        private System.Windows.Forms.Label lblStepFour;
        private System.Windows.Forms.Label lblStepThree;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblCheck4;
        private System.Windows.Forms.Label lblCheck3;
        private System.Windows.Forms.Label lblCheck2;
        private System.Windows.Forms.Label lblCheck1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbAllIPs;
    }
}

