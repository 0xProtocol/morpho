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
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblSearchIP = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lsb_discover = new System.Windows.Forms.ListBox();
            this.btn_Discover = new System.Windows.Forms.Button();
            this.pbnetwork = new System.Windows.Forms.ProgressBar();
            this.tbx_Discovery = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tcStatistics = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb = new Management_Tool_SZU.Server.GUI.CircularButton();
            this.tcWindow.SuspendLayout();
            this.tcNetworkDicovery.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tcStatistics.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNetwork
            // 
            this.tbxNetwork.Location = new System.Drawing.Point(7, 86);
            this.tbxNetwork.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxNetwork.Name = "tbxNetwork";
            this.tbxNetwork.Size = new System.Drawing.Size(208, 20);
            this.tbxNetwork.TabIndex = 91;
            this.tbxNetwork.TextChanged += new System.EventHandler(this.TbxNetwork_TextChanged);
            // 
            // lsb_networkadapter
            // 
            this.lsb_networkadapter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lsb_networkadapter.ForeColor = System.Drawing.Color.Black;
            this.lsb_networkadapter.FormattingEnabled = true;
            this.lsb_networkadapter.ItemHeight = 12;
            this.lsb_networkadapter.Location = new System.Drawing.Point(18, 16);
            this.lsb_networkadapter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsb_networkadapter.Name = "lsb_networkadapter";
            this.lsb_networkadapter.Size = new System.Drawing.Size(951, 268);
            this.lsb_networkadapter.TabIndex = 92;
            this.lsb_networkadapter.SelectedIndexChanged += new System.EventHandler(this.Lsb_networkadapter_SelectedIndexChanged);
            // 
            // tcWindow
            // 
            this.tcWindow.Controls.Add(this.tcNetworkDicovery);
            this.tcWindow.Controls.Add(this.tcStatistics);
            this.tcWindow.Font = new System.Drawing.Font("Rockwell", 7.8F);
            this.tcWindow.Location = new System.Drawing.Point(34, 35);
            this.tcWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcWindow.Name = "tcWindow";
            this.tcWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcWindow.SelectedIndex = 0;
            this.tcWindow.Size = new System.Drawing.Size(1322, 586);
            this.tcWindow.TabIndex = 91;
            // 
            // tcNetworkDicovery
            // 
            this.tcNetworkDicovery.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.tcNetworkDicovery.Location = new System.Drawing.Point(4, 21);
            this.tcNetworkDicovery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcNetworkDicovery.Name = "tcNetworkDicovery";
            this.tcNetworkDicovery.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcNetworkDicovery.Size = new System.Drawing.Size(1314, 561);
            this.tcNetworkDicovery.TabIndex = 2;
            this.tcNetworkDicovery.Text = "Network Discovery";
            this.tcNetworkDicovery.Click += new System.EventHandler(this.TcNetworkDicovery_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(6, 25);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(99, 13);
            this.lblLoading.TabIndex = 101;
            this.lblLoading.Text = "Loading Progress:";
            // 
            // lblSearchIP
            // 
            this.lblSearchIP.AutoSize = true;
            this.lblSearchIP.Location = new System.Drawing.Point(6, 70);
            this.lblSearchIP.Name = "lblSearchIP";
            this.lblSearchIP.Size = new System.Drawing.Size(71, 13);
            this.lblSearchIP.TabIndex = 100;
            this.lblSearchIP.Text = "Subnetmask:";
            this.lblSearchIP.Click += new System.EventHandler(this.LblSearchIP_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(6, 25);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(65, 13);
            this.lblIP.TabIndex = 99;
            this.lblIP.Text = "IP-Adresse:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Blue;
            this.panel7.Location = new System.Drawing.Point(0, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 560);
            this.panel7.TabIndex = 98;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(1304, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 559);
            this.panel5.TabIndex = 95;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(7, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1307, 10);
            this.panel3.TabIndex = 95;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(3, 551);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1311, 10);
            this.panel4.TabIndex = 96;
            // 
            // lsb_discover
            // 
            this.lsb_discover.FormattingEnabled = true;
            this.lsb_discover.ItemHeight = 12;
            this.lsb_discover.Location = new System.Drawing.Point(977, 16);
            this.lsb_discover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsb_discover.Name = "lsb_discover";
            this.lsb_discover.Size = new System.Drawing.Size(320, 532);
            this.lsb_discover.TabIndex = 82;
            // 
            // btn_Discover
            // 
            this.btn_Discover.Font = new System.Drawing.Font("Rockwell", 18.5F);
            this.btn_Discover.Location = new System.Drawing.Point(7, 70);
            this.btn_Discover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Discover.Name = "btn_Discover";
            this.btn_Discover.Size = new System.Drawing.Size(408, 41);
            this.btn_Discover.TabIndex = 83;
            this.btn_Discover.Text = "Start Discovery";
            this.btn_Discover.UseVisualStyleBackColor = true;
            this.btn_Discover.Click += new System.EventHandler(this.Btn_Discover_Click_1);
            // 
            // pbnetwork
            // 
            this.pbnetwork.BackColor = System.Drawing.Color.Blue;
            this.pbnetwork.ForeColor = System.Drawing.Color.Blue;
            this.pbnetwork.Location = new System.Drawing.Point(7, 41);
            this.pbnetwork.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbnetwork.Name = "pbnetwork";
            this.pbnetwork.Size = new System.Drawing.Size(408, 20);
            this.pbnetwork.TabIndex = 89;
            // 
            // tbx_Discovery
            // 
            this.tbx_Discovery.Location = new System.Drawing.Point(7, 41);
            this.tbx_Discovery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_Discovery.Name = "tbx_Discovery";
            this.tbx_Discovery.Size = new System.Drawing.Size(208, 20);
            this.tbx_Discovery.TabIndex = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_Discovery);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.tbxNetwork);
            this.groupBox1.Controls.Add(this.lblSearchIP);
            this.groupBox1.Location = new System.Drawing.Point(302, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 125);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discovery Configuration";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Discover);
            this.groupBox2.Controls.Add(this.pbnetwork);
            this.groupBox2.Controls.Add(this.lblLoading);
            this.groupBox2.Location = new System.Drawing.Point(536, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 125);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discovery";
            // 
            // tcStatistics
            // 
            this.tcStatistics.BackColor = System.Drawing.Color.DodgerBlue;
            this.tcStatistics.Controls.Add(this.panel8);
            this.tcStatistics.Controls.Add(this.panel6);
            this.tcStatistics.Controls.Add(this.panel2);
            this.tcStatistics.Controls.Add(this.panel1);
            this.tcStatistics.Location = new System.Drawing.Point(4, 21);
            this.tcStatistics.Name = "tcStatistics";
            this.tcStatistics.Size = new System.Drawing.Size(1314, 561);
            this.tcStatistics.TabIndex = 3;
            this.tcStatistics.Text = "Statistics";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 10);
            this.panel1.TabIndex = 96;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(7, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 10);
            this.panel2.TabIndex = 97;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Location = new System.Drawing.Point(0, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 560);
            this.panel6.TabIndex = 99;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Blue;
            this.panel8.Location = new System.Drawing.Point(1304, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 560);
            this.panel8.TabIndex = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb);
            this.groupBox3.Location = new System.Drawing.Point(302, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 113);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Management_Tool_SZU.Server.GUI.Properties.Resources.morpho2;
            this.pictureBox1.Location = new System.Drawing.Point(16, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // cb
            // 
            this.cb.BackgroundImage = global::Management_Tool_SZU.Server.GUI.Properties.Resources.morphobutton;
            this.cb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cb.Location = new System.Drawing.Point(260, 19);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(79, 76);
            this.cb.TabIndex = 106;
            this.cb.UseVisualStyleBackColor = true;
            this.cb.Click += new System.EventHandler(this.Cb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1387, 665);
            this.Controls.Add(this.tcWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ServerSettings_Load);
            this.tcWindow.ResumeLayout(false);
            this.tcNetworkDicovery.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tcStatistics.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

