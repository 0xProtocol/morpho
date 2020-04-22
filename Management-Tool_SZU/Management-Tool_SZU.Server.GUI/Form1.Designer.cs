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
            this.components = new System.ComponentModel.Container();
            this.tbxNetwork = new System.Windows.Forms.TextBox();
            this.lsb_networkadapter = new System.Windows.Forms.ListBox();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAdapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcWindow = new System.Windows.Forms.TabControl();
            this.tcNetworkDicovery = new System.Windows.Forms.TabPage();
            this.lsb_discover = new System.Windows.Forms.ListBox();
            this.btn_Discover = new System.Windows.Forms.Button();
            this.pbnetwork = new System.Windows.Forms.ProgressBar();
            this.tbx_Discovery = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblSearchIP = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cms.SuspendLayout();
            this.tcWindow.SuspendLayout();
            this.tcNetworkDicovery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNetwork
            // 
            this.tbxNetwork.Location = new System.Drawing.Point(367, 402);
            this.tbxNetwork.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxNetwork.Name = "tbxNetwork";
            this.tbxNetwork.Size = new System.Drawing.Size(320, 20);
            this.tbxNetwork.TabIndex = 91;
            // 
            // lsb_networkadapter
            // 
            this.lsb_networkadapter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lsb_networkadapter.ContextMenuStrip = this.cms;
            this.lsb_networkadapter.ForeColor = System.Drawing.Color.Black;
            this.lsb_networkadapter.FormattingEnabled = true;
            this.lsb_networkadapter.ItemHeight = 12;
            this.lsb_networkadapter.Location = new System.Drawing.Point(39, 42);
            this.lsb_networkadapter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsb_networkadapter.Name = "lsb_networkadapter";
            this.lsb_networkadapter.Size = new System.Drawing.Size(1015, 244);
            this.lsb_networkadapter.TabIndex = 92;
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAdapterToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(151, 26);
            this.cms.Opening += new System.ComponentModel.CancelEventHandler(this.Cms_Opening);
            // 
            // selectAdapterToolStripMenuItem
            // 
            this.selectAdapterToolStripMenuItem.Name = "selectAdapterToolStripMenuItem";
            this.selectAdapterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.selectAdapterToolStripMenuItem.Text = "Select Adapter";
            this.selectAdapterToolStripMenuItem.Click += new System.EventHandler(this.SelectAdapterToolStripMenuItem_Click_1);
            // 
            // tcWindow
            // 
            this.tcWindow.Controls.Add(this.tcNetworkDicovery);
            this.tcWindow.Font = new System.Drawing.Font("Rockwell", 7.8F);
            this.tcWindow.Location = new System.Drawing.Point(13, 12);
            this.tcWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcWindow.Name = "tcWindow";
            this.tcWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcWindow.SelectedIndex = 0;
            this.tcWindow.Size = new System.Drawing.Size(1103, 482);
            this.tcWindow.TabIndex = 91;
            // 
            // tcNetworkDicovery
            // 
            this.tcNetworkDicovery.BackColor = System.Drawing.Color.DodgerBlue;
            this.tcNetworkDicovery.Controls.Add(this.pictureBox1);
            this.tcNetworkDicovery.Controls.Add(this.lblLoading);
            this.tcNetworkDicovery.Controls.Add(this.lblSearchIP);
            this.tcNetworkDicovery.Controls.Add(this.lblIP);
            this.tcNetworkDicovery.Controls.Add(this.panel7);
            this.tcNetworkDicovery.Controls.Add(this.panel8);
            this.tcNetworkDicovery.Controls.Add(this.panel6);
            this.tcNetworkDicovery.Controls.Add(this.panel5);
            this.tcNetworkDicovery.Controls.Add(this.panel1);
            this.tcNetworkDicovery.Controls.Add(this.panel3);
            this.tcNetworkDicovery.Controls.Add(this.panel4);
            this.tcNetworkDicovery.Controls.Add(this.panel2);
            this.tcNetworkDicovery.Controls.Add(this.lsb_networkadapter);
            this.tcNetworkDicovery.Controls.Add(this.tbxNetwork);
            this.tcNetworkDicovery.Controls.Add(this.lsb_discover);
            this.tcNetworkDicovery.Controls.Add(this.btn_Discover);
            this.tcNetworkDicovery.Controls.Add(this.pbnetwork);
            this.tcNetworkDicovery.Controls.Add(this.tbx_Discovery);
            this.tcNetworkDicovery.Location = new System.Drawing.Point(4, 21);
            this.tcNetworkDicovery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcNetworkDicovery.Name = "tcNetworkDicovery";
            this.tcNetworkDicovery.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcNetworkDicovery.Size = new System.Drawing.Size(1095, 457);
            this.tcNetworkDicovery.TabIndex = 2;
            this.tcNetworkDicovery.Text = "Netzwerkerkennung";
            this.tcNetworkDicovery.Click += new System.EventHandler(this.TcNetworkDicovery_Click);
            // 
            // lsb_discover
            // 
            this.lsb_discover.ContextMenuStrip = this.cms;
            this.lsb_discover.FormattingEnabled = true;
            this.lsb_discover.ItemHeight = 12;
            this.lsb_discover.Location = new System.Drawing.Point(39, 292);
            this.lsb_discover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsb_discover.Name = "lsb_discover";
            this.lsb_discover.Size = new System.Drawing.Size(320, 88);
            this.lsb_discover.TabIndex = 82;
            // 
            // btn_Discover
            // 
            this.btn_Discover.Font = new System.Drawing.Font("Rockwell", 18.5F);
            this.btn_Discover.Location = new System.Drawing.Point(367, 292);
            this.btn_Discover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Discover.Name = "btn_Discover";
            this.btn_Discover.Size = new System.Drawing.Size(320, 41);
            this.btn_Discover.TabIndex = 83;
            this.btn_Discover.Text = "Start Recognition";
            this.btn_Discover.UseVisualStyleBackColor = true;
            this.btn_Discover.Click += new System.EventHandler(this.Btn_Discover_Click_1);
            // 
            // pbnetwork
            // 
            this.pbnetwork.BackColor = System.Drawing.Color.Blue;
            this.pbnetwork.ForeColor = System.Drawing.Color.Blue;
            this.pbnetwork.Location = new System.Drawing.Point(367, 359);
            this.pbnetwork.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbnetwork.Name = "pbnetwork";
            this.pbnetwork.Size = new System.Drawing.Size(320, 18);
            this.pbnetwork.TabIndex = 89;
            // 
            // tbx_Discovery
            // 
            this.tbx_Discovery.Location = new System.Drawing.Point(39, 402);
            this.tbx_Discovery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_Discovery.Name = "tbx_Discovery";
            this.tbx_Discovery.Size = new System.Drawing.Size(320, 20);
            this.tbx_Discovery.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(8, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 10);
            this.panel2.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(8, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1078, 10);
            this.panel3.TabIndex = 95;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(7, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 10);
            this.panel1.TabIndex = 97;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(7, 444);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1078, 10);
            this.panel4.TabIndex = 96;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(1076, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 445);
            this.panel5.TabIndex = 95;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Location = new System.Drawing.Point(1061, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 445);
            this.panel6.TabIndex = 96;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Blue;
            this.panel7.Location = new System.Drawing.Point(7, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 445);
            this.panel7.TabIndex = 98;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Blue;
            this.panel8.Location = new System.Drawing.Point(22, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 445);
            this.panel8.TabIndex = 97;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(38, 386);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(65, 13);
            this.lblIP.TabIndex = 99;
            this.lblIP.Text = "IP-Adresse:";
            // 
            // lblSearchIP
            // 
            this.lblSearchIP.AutoSize = true;
            this.lblSearchIP.Location = new System.Drawing.Point(364, 386);
            this.lblSearchIP.Name = "lblSearchIP";
            this.lblSearchIP.Size = new System.Drawing.Size(104, 13);
            this.lblSearchIP.TabIndex = 100;
            this.lblSearchIP.Text = "Search IP-Address:";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(366, 343);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(99, 13);
            this.lblLoading.TabIndex = 101;
            this.lblLoading.Text = "Loading Progress:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Management_Tool_SZU.Server.GUI.Properties.Resources.morpho2;
            this.pictureBox1.Location = new System.Drawing.Point(694, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 506);
            this.Controls.Add(this.tcWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ServerSettings_Load);
            this.cms.ResumeLayout(false);
            this.tcWindow.ResumeLayout(false);
            this.tcNetworkDicovery.ResumeLayout(false);
            this.tcNetworkDicovery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNetwork;
        private System.Windows.Forms.ListBox lsb_networkadapter;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem selectAdapterToolStripMenuItem;
        private System.Windows.Forms.TabControl tcWindow;
        private System.Windows.Forms.TabPage tcNetworkDicovery;
        private System.Windows.Forms.ListBox lsb_discover;
        private System.Windows.Forms.Button btn_Discover;
        private System.Windows.Forms.ProgressBar pbnetwork;
        private System.Windows.Forms.TextBox tbx_Discovery;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblSearchIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

