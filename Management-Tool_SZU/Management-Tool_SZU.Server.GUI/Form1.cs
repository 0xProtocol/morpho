using Management_Tool_SZU.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace Management_Tool_SZU.Server.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            cbAlternative.SelectedIndex = 0;
            cbBaseBoard.SelectedIndex = 0;
            cbBIOS.SelectedIndex = 0;
            cbComputerSystem.SelectedIndex = 0;
            cbDiskDrive.SelectedIndex = 0;
            cbLogicalDisk.SelectedIndex = 0;
            cbNetworkAdapter.SelectedIndex = 0;
            cboperatingsystem.SelectedIndex = 0;
            tbxpassword.PasswordChar = '*';
        }

        private SpeechSynthesizer com = new SpeechSynthesizer();
        NetworkDiscovery nd = new NetworkDiscovery();
        WMICStatistic wmics = new WMICStatistic();
        Thread discoverythread;
        private void ServerSettings_Load(object sender, EventArgs e)
        {
            lsb_networkadapter.Items.Clear();
            nd.getip(lsb_networkadapter);
            string[] splitzeile = nd.firstvalue.Split('|');
            tbx_Discovery.Text = splitzeile[1];
            tbxNetwork.Text = splitzeile[2];
        }

        private void GiveSelectedAdapterinTextBox()
        {
            try
            {
                string split = lsb_networkadapter.GetItemText(lsb_networkadapter.SelectedItem);
                string[] seperator = { "| " };
                string[] splitzeile = split.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                tbx_Discovery.Text = splitzeile[1];
                tbxNetwork.Text = splitzeile[2];
            }
            catch (Exception)
            {
            }
        }
        public void Discover(string value)
        {
            try
            {
                nd.getSubnet(tbxNetwork);
                lsb_discover.Items.Clear();
                nd.FillArpResults(tbx_Discovery, lsb_discover);

                ThreadStart start = delegate { nd.QuickSearch(lsb_discover, pbnetwork); };
                discoverythread = new Thread(new ThreadStart(start));
                discoverythread.Start();

            }
            catch (Exception ex)
            {
            }
        }

        private void Btn_Discover_Click_1(object sender, EventArgs e)
        {
            if (nd.isworking == false)
            {
                Discover("0");
            }
        }

        private void TcNetworkDicovery_Click(object sender, EventArgs e)
        {

        }

        private void Cms_Opening(object sender, CancelEventArgs e)
        {

        }

        private void SelectAdapterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GiveSelectedAdapterinTextBox();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblSearchIP_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TbxNetwork_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lsb_networkadapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            GiveSelectedAdapterinTextBox();
            // lsb_networkadapter.SelectedIndex = lsb_networkadapter.Items.Count - 1;
        }

        private void Cb_Click(object sender, EventArgs e)
        {
          /*/  ThreadStart ts = new ThreadStart(GetStatisticForm);
            Thread t = new Thread(ts)
            {
                IsBackground = true
            };
            t.Start();
            tcWindow.SelectedIndex = 1;
            /*/
        }

        private void GetStatisticForm(IPAddress ip)
        {
          /*/  if (this.lsb_discover.SelectedIndex == -1)
            {
                try
                {
                    com.SelectVoice("Microsoft Hazel Desktop");
                    com.SpeakAsync("Please enter a selection");
                }
                catch (Exception)
                {
                }
            }
            else
            {/*/
                try
                {
                    com.SelectVoice("Microsoft Hazel Desktop");
                    com.SpeakAsync("Results are in the Statistic tab");
                }
                catch (Exception)
                {
                }
                WMICAction(ip);
            
        }

        private void Lsb_discover_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userip = lsb_discover.GetItemText(lsb_discover.SelectedItem);
            tbxuserip.Text = userip;
        }

        private void LblLoading_Click(object sender, EventArgs e)
        {

        }

        private string[] SplitIncominMessage(string text)
        {
            text = text.Replace("\t", " ");
            text = text.Replace(" ", "");
            string[] seperator = { "\r\r\n" };

            string[] tmp = text.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

            return tmp;
        }

        private void GiveIntoListview(string wmicvalue)
        {
            string[] values = SplitIncominMessage(wmicvalue);
            ListViewItem lvi = new ListViewItem(values[0]);
            lvi.SubItems.Add(values[1]);
            lvstatistics.Items.Add(lvi);
        }

        private void WMICAction(IPAddress ip)
        {
            // OS
            if (cboperatingsystem.Text == "All")
            {
                string OperatingSystemName = wmics.GetStatistic(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemName);

                string OperatingSystemArchitecture = wmics.GetStatistic30(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemArchitecture);

                string OperatingSystemInstallDate = wmics.GetStatistic31(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemInstallDate);

                string OperatingSystemRegisteredUser = wmics.GetStatistic32(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemRegisteredUser);

                string OperatingSystemVersion = wmics.GetStatistic33(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemVersion);

                string OperatingSystemStatus = wmics.GetStatistic34(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemStatus);
            }
            if (cboperatingsystem.Text == "Name")
            {
                string OperatingSystemName = wmics.GetStatistic(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemName);
            }
            if (cboperatingsystem.Text == "Architecture")
            {
                string OperatingSystemArchitecture = wmics.GetStatistic30(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemArchitecture);
            }
            if (cboperatingsystem.Text == "Registered User")
            {
                string OperatingSystemArchitecture = wmics.GetStatistic30(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemArchitecture);
            }
            if (cboperatingsystem.Text == "Install Date")
            {
                string OperatingSystemInstallDate = wmics.GetStatistic31(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemInstallDate);
            }
            if (cboperatingsystem.Text == "Version")
            {
                string OperatingSystemVersion = wmics.GetStatistic33(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemVersion);
            }
            if (cboperatingsystem.Text == "Status")
            {
                string OperatingSystemStatus = wmics.GetStatistic34(Convert.ToString(ip), tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemStatus);
            }

            //BIOS
            if (cbBIOS.Text == "All")
            {
                string BIOSVersion = wmics.GetStatistic6(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSVersion);

                string BIOSManufacturer = wmics.GetStatistic7(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSManufacturer);

                string BIOSStatus = wmics.GetStatistic8(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSStatus);
            }
            if (cbBIOS.Text == "Version")
            {
                string BIOSVersion = wmics.GetStatistic6(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSVersion);
            }
            if (cbBIOS.Text == "Manufacturer")
            {
                string BIOSManufacturer = wmics.GetStatistic7(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSManufacturer);
            }
            if (cbBIOS.Text == "Status")
            {
                string BIOSStatus = wmics.GetStatistic8(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSStatus);
            }

            //BaseBoard
            if (cbBaseBoard.Text == "All")
            {
                string baseboardmanufacturer = wmics.GetStatistic2(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardmanufacturer);

                string baseboardserialnumber = wmics.GetStatistic3(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardserialnumber);

                string baseboardstatus = wmics.GetStatistic4(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardstatus);

                string baseboardproduct = wmics.GetStatistic5(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardproduct);
            }
            if (cbBaseBoard.Text == "Manufacturer")
            {
                string baseboardmanufacturer = wmics.GetStatistic2(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardmanufacturer);
            }
            if (cbBaseBoard.Text == "Serialnumber")
            {
                string baseboardserialnumber = wmics.GetStatistic3(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardserialnumber);
            }
            if (cbBaseBoard.Text == "Status")
            {
                string baseboardstatus = wmics.GetStatistic4(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardstatus);
            }
            if (cbBaseBoard.Text == "Product")
            {
                string baseboardproduct = wmics.GetStatistic5(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardproduct);
            }

            // ComputerSystem
            if (cbComputerSystem.Text == "All")
            {
                string ComputersystemAdminPasswortStatus = wmics.GetStatistic9(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemAdminPasswortStatus);

                string ComputersystemCurrentTimeZone = wmics.GetStatistic10(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemCurrentTimeZone);

                string ComputersystemDNSHostname = wmics.GetStatistic11(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemDNSHostname);

                string ComputersystemPrimaryOwner = wmics.GetStatistic12(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemPrimaryOwner);

                string ComputersystemName = wmics.GetStatistic13(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemName);

                string ComputersystemStatus = wmics.GetStatistic14(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemStatus);

                string ComputersystemWorkgroup = wmics.GetStatistic15(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemWorkgroup);
            }
            if (cbComputerSystem.Text == "Adminpasswortstatus")
            {
                string ComputersystemAdminPasswortStatus = wmics.GetStatistic9(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemAdminPasswortStatus);
            }
            if (cbComputerSystem.Text == "CurrentTimeZone")
            {

                string ComputersystemCurrentTimeZone = wmics.GetStatistic10(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemCurrentTimeZone);
            }
            if (cbComputerSystem.Text == "DNSHostname")
            {
                string ComputersystemDNSHostname = wmics.GetStatistic11(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemDNSHostname);
            }
            if (cbComputerSystem.Text == "PrimaryOwner")
            {
                string ComputersystemPrimaryOwner = wmics.GetStatistic12(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemPrimaryOwner);

            }
            if (cbComputerSystem.Text == "Name")
            {
                string ComputersystemName = wmics.GetStatistic13(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemName);
            }
            if (cbComputerSystem.Text == "Status")
            {
                string ComputersystemStatus = wmics.GetStatistic14(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemStatus);
            }
            if (cbComputerSystem.Text == "Workgroup")
            {
                string ComputersystemWorkgroup = wmics.GetStatistic15(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemWorkgroup);
            }


            //DiskDrive
            if (cbDiskDrive.Text == "All")
            {
                string DiskDriveCaption = wmics.GetStatistic16(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveCaption);

                string DiskDriveMediaLoaded = wmics.GetStatistic17(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveMediaLoaded);

                string DiskDriveStatus = wmics.GetStatistic18(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveStatus);

                string DiskDriveSize = wmics.GetStatistic19(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveSize);

            }
            if (cbDiskDrive.Text == "Caption")
            {
                string DiskDriveCaption = wmics.GetStatistic16(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveCaption);

            }
            if (cbDiskDrive.Text == "MeidaLoaded")
            {
                string DiskDriveMediaLoaded = wmics.GetStatistic17(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveMediaLoaded);
            }
            if (cbDiskDrive.Text == "Status")
            {
                string DiskDriveStatus = wmics.GetStatistic18(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveStatus);
            }
            if (cbDiskDrive.Text == "Size")
            {
                string DiskDriveSize = wmics.GetStatistic19(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveSize);
            }

            //LogicalDisk
            if (cbLogicalDisk.Text == "All")
            {
                string LogicalDiskCaption = wmics.GetStatistic21(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskCaption);

                string LogicalDiskFileSystem = wmics.GetStatistic22(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskFileSystem);

                string LogicalDiskSize = wmics.GetStatistic23(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskSize);
            }
            if (cbLogicalDisk.Text == "Catption")
            {
                string LogicalDiskCaption = wmics.GetStatistic21(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskCaption);

            }
            if (cbLogicalDisk.Text == "FileSystem")
            {
                string LogicalDiskFileSystem = wmics.GetStatistic22(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskFileSystem);
            }
            if (cbLogicalDisk.Text == "Size")
            {
                string LogicalDiskSize = wmics.GetStatistic23(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskSize);
            }

            // Network Adapter
            if (cbNetworkAdapter.Text == "All")
            {
                string NetworkAdapterDescription = wmics.GetStatistic24(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterDescription);

                string NetworkAdapterManufacturer = wmics.GetStatistic25(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterManufacturer);

                string NetworkAdapterMacAddress = wmics.GetStatistic26(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterMacAddress);

                string NetworkAdapterName = wmics.GetStatistic27(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterName);

                string NetworkAdapterAdaptertype = wmics.GetStatistic28(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterAdaptertype);

                string NetworkAdapterInstalled = wmics.GetStatistic29(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterInstalled);
            }
            if (cbNetworkAdapter.Text == "Description")
            {
                string NetworkAdapterDescription = wmics.GetStatistic24(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterDescription);
            }
            if (cbNetworkAdapter.Text == "Manufacturer")
            {
                string NetworkAdapterManufacturer = wmics.GetStatistic25(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterManufacturer);
            }
            if (cbNetworkAdapter.Text == "MacAddress")
            {
                string NetworkAdapterMacAddress = wmics.GetStatistic26(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterMacAddress);
            }
            if (cbNetworkAdapter.Text == "Name")
            {
                string NetworkAdapterName = wmics.GetStatistic27(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterName);
            }
            if (cbNetworkAdapter.Text == "Adaptertype")
            {
                string NetworkAdapterAdaptertype = wmics.GetStatistic28(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterAdaptertype);

            }
            if (cbNetworkAdapter.Text == "Installed")
            {
                string NetworkAdapterInstalled = wmics.GetStatistic29(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterInstalled);
            }

            //Alternative
            if(cbAlternative.Text=="All")
            {
                string Lastbootuptime = wmics.GetStatistic20(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(Lastbootuptime);

                string TimeZoneDescription = wmics.GetStatistic35(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(TimeZoneDescription);

                string SystemTimeZoneSetting = wmics.GetStatistic36(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(SystemTimeZoneSetting);
            }
            if (cbAlternative.Text == "Lastbootuptime")
            {
                string Lastbootuptime = wmics.GetStatistic20(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(Lastbootuptime);
            }
            if (cbAlternative.Text == "Timezonedescription")
            {
                string TimeZoneDescription = wmics.GetStatistic35(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(TimeZoneDescription);
            }
            if (cbAlternative.Text == "Systemtimezonesetting")
            {
                string SystemTimeZoneSetting = wmics.GetStatistic36(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(SystemTimeZoneSetting);
            }
            else
            {
            }
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            cbAlternative.SelectedIndex = cbAlternative.Items.Count - 2;
            cbBaseBoard.SelectedIndex = cbBaseBoard.Items.Count - 2;
            cbBIOS.SelectedIndex = cbBIOS.Items.Count - 2;
            cbComputerSystem.SelectedIndex = cbComputerSystem.Items.Count - 2;
            cbDiskDrive.SelectedIndex = cbDiskDrive.Items.Count - 2;
            cbLogicalDisk.SelectedIndex = cbLogicalDisk.Items.Count - 2;
            cbNetworkAdapter.SelectedIndex = cbNetworkAdapter.Items.Count - 2;
            cboperatingsystem.SelectedIndex = cboperatingsystem.Items.Count - 2;
        }
        public List<IPAddress> ipAddressList2 = new List<IPAddress>();
        
        private void All_Click(object sender, EventArgs e)
        {
            ipAddressList2.Add(IPAddress.Parse("192.168.0.2"));
            ipAddressList2.Add(IPAddress.Parse("192.168.0.5"));
            foreach (IPAddress item in ipAddressList2)
            {
                GetStatisticForm(item);
                tcWindow.SelectedIndex = 1;
            }
            
        }
    }
}

