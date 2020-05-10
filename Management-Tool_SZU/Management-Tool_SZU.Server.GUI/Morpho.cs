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
    /// <summary>
    /// Code from the Morpho GUI
    /// </summary>
    public partial class Morpho : Form
    {
        /// <summary>
        /// Constructor of the class Morpho
        /// </summary>
        public Morpho()
        {
            InitializeComponent();
            lvstatistics.FullRowSelect = true;
            lvstatistics.MultiSelect = false;
            lvstatistics.ColumnClick += new ColumnClickEventHandler(lvItem_ColumnClick);
            lvstatistics.Columns.Add("IPAddress", "IPAddress");
            lvstatistics.Columns.Add("Property", "Property");
            lvstatistics.Columns.Add("Result", "Result");
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
            if (lsb_networkadapter.SelectedIndex == -1)
            {
                lblCheck1.ForeColor = System.Drawing.Color.Black;
            }


        }

        private int _sortColumnIndex = -1;

        /// <summary>
        /// Method for sorting the list view data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvItem_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {

                if (e.Column != _sortColumnIndex)
                {
                    _sortColumnIndex = e.Column;
                    lvstatistics.Sorting = SortOrder.Ascending;
                }
                else
                {
                    if (lvstatistics.Sorting == SortOrder.Ascending)
                        lvstatistics.Sorting = SortOrder.Descending;
                    else
                        lvstatistics.Sorting = SortOrder.Ascending;
                }

                lvstatistics.Sort();

                if (e.Column == lvstatistics.Columns["Result"].Index)
                    lvstatistics.ListViewItemSorter = new ListViewComparer(e.Column, lvstatistics.Sorting);
                else
                    lvstatistics.ListViewItemSorter = new ListViewComparer(e.Column, lvstatistics.Sorting);
            }
            catch (Exception)
            {
                //Errorlog
            }
        }

        private SpeechSynthesizer com = new SpeechSynthesizer();
        NetworkDiscovery nd = new NetworkDiscovery();
        WMICStatistic wmics = new WMICStatistic();
        Thread discoverythread;

        /// <summary>
        /// ???
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerSettings_Load(object sender, EventArgs e)
        {
            lsb_networkadapter.Items.Clear();
            nd.getip(lsb_networkadapter);
            string[] splitzeile = nd.firstvalue.Split('|');
            tbx_Discovery.Text = splitzeile[1];
            tbxNetwork.Text = splitzeile[2];
        }

        /// <summary>
        /// Writes the selected ip address and subnet mask in text boxes
        /// </summary>
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

        /// <summary>
        /// ???
        /// </summary>
        /// <param name="value"></param>
        public void Discover(string value)
        {
            try
            {
                nd.getSubnet(tbxNetwork);
                lsb_discover.Items.Clear();
                nd.FillArpResults(tbx_Discovery, lsb_discover);

                ThreadStart start = delegate { nd.QuickSearch(lsb_discover, pbnetwork, cbAllIPs); };
                discoverythread = new Thread(new ThreadStart(start));
                discoverythread.Start();

            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// ???
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Discover_Click_1(object sender, EventArgs e)
        {
            lblCheck2.ForeColor = System.Drawing.Color.Black;
            if (nd.isworking == false)
            {
                cbAllIPs.Enabled = false;
                Discover("0");
            }
        }

        /// <summary>
        /// Writes the selected ip address and subnet mask in text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lsb_networkadapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            GiveSelectedAdapterinTextBox();
        }

        /// <summary>
        /// Method for voice output
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        private string Speech(string state)
        {
            if (this.lsb_discover.SelectedIndex == -1 && state == "single" || this.lsb_discover.SelectedIndex == -1 && state == "multiple")
            {
                try
                {
                    com.SelectVoice("Microsoft Hazel Desktop");
                    com.SpeakAsync("Please enter a selection");
                    return "false";
                }
                catch (Exception)
                {

                }
                return "false";
            }
            else
            {
                try
                {
                    com.SelectVoice("Microsoft Hazel Desktop");
                    com.SpeakAsync("Results are in the Statistic tab");
                    return "true";

                }
                catch (Exception)
                {

                }
                finally
                {
                    tcWindow.SelectedIndex = 1;
                }
                return "true";
            }
        }

        /// <summary>
        /// Get wmic information of the selected PC(s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cb_Click(object sender, EventArgs e)
        {
            lblCheck5.ForeColor = System.Drawing.Color.Black;
            if (cbAllIPs.Checked == true)
            {
                Speech("all");
                foreach (string item in lsb_discover.Items)
                {
                    ipAddressList2.Add(System.Net.IPAddress.Parse(item));
                }
                foreach (IPAddress item in ipAddressList2)
                {
                    Thread thread = new Thread(delegate () { GetStatisticForm(Convert.ToString(item)); });
                    thread.Start();
                    tcWindow.SelectedIndex = 1;
                }
                ipAddressList2.Clear();
            }
            if(cbmultiple.Checked == true)
            {
                string action2 = Speech("multiple");
                if (action2 == "true")
                {
                    foreach (IPAddress item in ipAddressesmultiple)
                    {
                        Thread thread = new Thread(delegate () { GetStatisticForm(Convert.ToString(item)); });
                        thread.Start();
                        tcWindow.SelectedIndex = 1;
                    }
                }
            }
            else
            {
                if (lsb_discover.SelectedItems.Count> 1)
                {
                    string action = Speech("multiple");
                    if (action == "true")
                    {
                        foreach (String item in lsb_discover.SelectedItems)
                        {
                            Thread thread = new Thread(delegate () { GetStatisticForm(item); });
                            thread.Start();
                        }
                    }
                }
                if (lsb_discover.SelectedItems.Count == 1)
                {
                    string action = Speech("single");
                    if (action == "true")
                    {
                        Thread thread = new Thread(delegate () { GetStatisticForm(Convert.ToString(lsb_discover.SelectedItem)); });
                        thread.Start();
                    }
                    else
                    {
                    }
                }
                else
                {
                    Speech("single");
                }
                
            }


        }

        /// <summary>
        /// Get wmic statistics from the specific ip
        /// </summary>
        /// <param name="ip"></param>
        private void GetStatisticForm(string ip)
        {
            try
            {
                WMICAction(ip);
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Splits incoming message
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string[] SplitIncominMessage(string text)
        {
            text = text.Replace("\t", " ");
            text = text.Replace(" ", "");
            string[] seperator = { "\r\r\n" };

            string[] tmp = text.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

            return tmp;
        }

        int counter = 0;
        /// <summary>
        /// Writes a wmic value and the ip into the listview
        /// </summary>
        /// <param name="wmicvalue"></param>
        /// <param name="ip"></param>
        private void GiveIntoListview(string wmicvalue, string ip)
        {
            try
            {
                string[] values = SplitIncominMessage(wmicvalue);

                if (values.Length > 0)
                {

                    if (lvstatistics.Columns.Count < values.Length)
                    {
                        counter = values.Length - lvstatistics.Columns.Count;
                        for (int i = 0; i < counter + 1; i++)
                        {
                            lvstatistics.Columns.Add("Result", 155, HorizontalAlignment.Left);
                        }
                    }
                    
                    ListViewItem lvi = new ListViewItem(ip);
                    foreach (var item in values)
                    {
                        lvi.SubItems.Add(item);
                    }
                    lvstatistics.Items.Add(lvi);
                }

            }
            catch (Exception)
            {


            }

        }

        /// <summary>
        /// Gets the selected wmic values
        /// </summary>
        /// <param name="ip"></param>
        private void WMICAction(string ip)
        {
            // OS
            if (cboperatingsystem.Text == "All")
            {
                string OperatingSystemName = wmics.GetStatistic(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemName, ip);

                string OperatingSystemArchitecture = wmics.GetStatistic30(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemArchitecture, ip);

                string OperatingSystemInstallDate = wmics.GetStatistic31(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemInstallDate, ip);

                string OperatingSystemRegisteredUser = wmics.GetStatistic32(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemRegisteredUser, ip);

                string OperatingSystemVersion = wmics.GetStatistic33(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemVersion, ip);

                string OperatingSystemStatus = wmics.GetStatistic34(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemStatus, ip);
            }
            if (cboperatingsystem.Text == "Name")
            {
                string OperatingSystemName = wmics.GetStatistic(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemName, ip);
            }
            if (cboperatingsystem.Text == "Architecture")
            {
                string OperatingSystemArchitecture = wmics.GetStatistic30(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemArchitecture, ip);
            }
            if (cboperatingsystem.Text == "Registered User")
            {
                string OperatingSystemRegisteredUser = wmics.GetStatistic32(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemRegisteredUser, ip);
            }
            if (cboperatingsystem.Text == "Install Date")
            {
                string OperatingSystemInstallDate = wmics.GetStatistic31(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemInstallDate, ip);
            }
            if (cboperatingsystem.Text == "Version")
            {
                string OperatingSystemVersion = wmics.GetStatistic33(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemVersion, ip);
            }
            if (cboperatingsystem.Text == "Status")
            {
                string OperatingSystemStatus = wmics.GetStatistic34(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemStatus, ip);
            }

            //BIOS
            if (cbBIOS.Text == "All")
            {
                string BIOSVersion = wmics.GetStatistic6(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSVersion, ip);

                string BIOSManufacturer = wmics.GetStatistic7(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSManufacturer, ip);

                string BIOSStatus = wmics.GetStatistic8(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSStatus, ip);
            }
            if (cbBIOS.Text == "Version")
            {
                string BIOSVersion = wmics.GetStatistic6(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSVersion, ip);
            }
            if (cbBIOS.Text == "Manufacturer")
            {
                string BIOSManufacturer = wmics.GetStatistic7(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSManufacturer, ip);
            }
            if (cbBIOS.Text == "Status")
            {
                string BIOSStatus = wmics.GetStatistic8(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(BIOSStatus, ip);
            }

            //BaseBoard
            if (cbBaseBoard.Text == "All")
            {
                string baseboardmanufacturer = wmics.GetStatistic2(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardmanufacturer, ip);

                string baseboardserialnumber = wmics.GetStatistic3(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardserialnumber, ip);

                string baseboardstatus = wmics.GetStatistic4(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardstatus, ip);

                string baseboardproduct = wmics.GetStatistic5(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardproduct, ip);
            }
            if (cbBaseBoard.Text == "Manufacturer")
            {
                string baseboardmanufacturer = wmics.GetStatistic2(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardmanufacturer, ip); ;
            }
            if (cbBaseBoard.Text == "Serialnumber")
            {
                string baseboardserialnumber = wmics.GetStatistic3(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardserialnumber, ip);
            }
            if (cbBaseBoard.Text == "Status")
            {
                string baseboardstatus = wmics.GetStatistic4(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardstatus, ip);
            }
            if (cbBaseBoard.Text == "Product")
            {
                string baseboardproduct = wmics.GetStatistic5(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(baseboardproduct, ip);
            }

            // ComputerSystem
            if (cbComputerSystem.Text == "All")
            {
                string ComputersystemAdminPasswortStatus = wmics.GetStatistic9(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemAdminPasswortStatus, ip);

                string ComputersystemCurrentTimeZone = wmics.GetStatistic10(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemCurrentTimeZone, ip);

                string ComputersystemDNSHostname = wmics.GetStatistic11(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemDNSHostname, ip);

                string ComputersystemPrimaryOwner = wmics.GetStatistic12(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemPrimaryOwner, ip);

                string ComputersystemName = wmics.GetStatistic13(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemName, ip);

                string ComputersystemStatus = wmics.GetStatistic14(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemStatus, ip);

                string ComputersystemWorkgroup = wmics.GetStatistic15(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemWorkgroup, ip);
            }
            if (cbComputerSystem.Text == "Adminpasswortstatus")
            {
                string ComputersystemAdminPasswortStatus = wmics.GetStatistic9(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemAdminPasswortStatus, ip);
            }
            if (cbComputerSystem.Text == "CurrentTimeZone")
            {

                string ComputersystemCurrentTimeZone = wmics.GetStatistic10(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemCurrentTimeZone, ip);
            }
            if (cbComputerSystem.Text == "DNSHostname")
            {
                string ComputersystemDNSHostname = wmics.GetStatistic11(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemDNSHostname, ip);
            }
            if (cbComputerSystem.Text == "PrimaryOwner")
            {
                string ComputersystemPrimaryOwner = wmics.GetStatistic12(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemPrimaryOwner, ip);

            }
            if (cbComputerSystem.Text == "Name")
            {
                string ComputersystemName = wmics.GetStatistic13(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemName, ip);
            }
            if (cbComputerSystem.Text == "Status")
            {
                string ComputersystemStatus = wmics.GetStatistic14(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemStatus, ip);
            }
            if (cbComputerSystem.Text == "Workgroup")
            {
                string ComputersystemWorkgroup = wmics.GetStatistic15(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(ComputersystemWorkgroup, ip);
            }


            //DiskDrive
            if (cbDiskDrive.Text == "All")
            {
                string DiskDriveCaption = wmics.GetStatistic16(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveCaption, ip);

                string DiskDriveMediaLoaded = wmics.GetStatistic17(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveMediaLoaded, ip);

                string DiskDriveStatus = wmics.GetStatistic18(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveStatus, ip);

                string DiskDriveSize = wmics.GetStatistic19(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveSize, ip);

            }
            if (cbDiskDrive.Text == "Caption")
            {
                string DiskDriveCaption = wmics.GetStatistic16(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveCaption, ip);

            }
            if (cbDiskDrive.Text == "Media Loaded")
            {
                string DiskDriveMediaLoaded = wmics.GetStatistic17(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveMediaLoaded, ip);
            }
            if (cbDiskDrive.Text == "Status")
            {
                string DiskDriveStatus = wmics.GetStatistic18(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveStatus, ip);
            }
            if (cbDiskDrive.Text == "Size")
            {
                string DiskDriveSize = wmics.GetStatistic19(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(DiskDriveSize, ip);
            }

            //LogicalDisk
            if (cbLogicalDisk.Text == "All")
            {
                string LogicalDiskCaption = wmics.GetStatistic21(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskCaption, ip);

                string LogicalDiskFileSystem = wmics.GetStatistic22(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskFileSystem, ip);

                string LogicalDiskSize = wmics.GetStatistic23(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskSize, ip);
            }
            if (cbLogicalDisk.Text == "Caption")
            {
                string LogicalDiskCaption = wmics.GetStatistic21(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskCaption, ip);

            }
            if (cbLogicalDisk.Text == "FileSystem")
            {
                string LogicalDiskFileSystem = wmics.GetStatistic22(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskFileSystem, ip);
            }
            if (cbLogicalDisk.Text == "Size")
            {
                string LogicalDiskSize = wmics.GetStatistic23(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(LogicalDiskSize, ip);
            }

            // Network Adapter
            if (cbNetworkAdapter.Text == "All")
            {
                string NetworkAdapterDescription = wmics.GetStatistic24(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterDescription, ip);

                string NetworkAdapterManufacturer = wmics.GetStatistic25(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterManufacturer, ip);

                string NetworkAdapterMacAddress = wmics.GetStatistic26(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterMacAddress, ip);

                string NetworkAdapterName = wmics.GetStatistic27(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterName, ip);

                string NetworkAdapterAdaptertype = wmics.GetStatistic28(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterAdaptertype, ip);

                string NetworkAdapterInstalled = wmics.GetStatistic29(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterInstalled, ip);
            }
            if (cbNetworkAdapter.Text == "Description")
            {
                string NetworkAdapterDescription = wmics.GetStatistic24(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterDescription, ip);
            }
            if (cbNetworkAdapter.Text == "Manufacturer")
            {
                string NetworkAdapterManufacturer = wmics.GetStatistic25(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterManufacturer, ip);
            }
            if (cbNetworkAdapter.Text == "MacAddress")
            {
                string NetworkAdapterMacAddress = wmics.GetStatistic26(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterMacAddress, ip);
            }
            if (cbNetworkAdapter.Text == "Name")
            {
                string NetworkAdapterName = wmics.GetStatistic27(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterName, ip);
            }
            if (cbNetworkAdapter.Text == "Adaptertype")
            {
                string NetworkAdapterAdaptertype = wmics.GetStatistic28(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterAdaptertype, ip);

            }
            if (cbNetworkAdapter.Text == "Installed")
            {
                string NetworkAdapterInstalled = wmics.GetStatistic29(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(NetworkAdapterInstalled, ip);
            }

            //Alternative
            if (cbAlternative.Text == "All")
            {
                string Lastbootuptime = wmics.GetStatistic20(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(Lastbootuptime, ip); ;

                string TimeZoneDescription = wmics.GetStatistic35(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(TimeZoneDescription, ip);

                string SystemTimeZoneSetting = wmics.GetStatistic36(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(SystemTimeZoneSetting, ip);
            }
            if (cbAlternative.Text == "Lastbootuptime")
            {
                string Lastbootuptime = wmics.GetStatistic20(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(Lastbootuptime, ip);
            }
            if (cbAlternative.Text == "Timezonedescription")
            {
                string TimeZoneDescription = wmics.GetStatistic35(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(TimeZoneDescription, ip);
            }
            if (cbAlternative.Text == "Systemtimezonesetting")
            {
                string SystemTimeZoneSetting = wmics.GetStatistic36(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(SystemTimeZoneSetting, ip);
            }
            else
            {
            }
        }

        /// <summary>
        /// Selectes option "all" on all statics comboboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Selectes option none on all statics comboboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNone_Click(object sender, EventArgs e)
        {
            cbAlternative.SelectedIndex = cbAlternative.Items.Count - 1;
            cbBaseBoard.SelectedIndex = cbBaseBoard.Items.Count - 1;
            cbBIOS.SelectedIndex = cbBIOS.Items.Count - 1;
            cbComputerSystem.SelectedIndex = cbComputerSystem.Items.Count - 1;
            cbDiskDrive.SelectedIndex = cbDiskDrive.Items.Count - 1;
            cbLogicalDisk.SelectedIndex = cbLogicalDisk.Items.Count - 1;
            cbNetworkAdapter.SelectedIndex = cbNetworkAdapter.Items.Count - 1;
            cboperatingsystem.SelectedIndex = cboperatingsystem.Items.Count - 1;
        }

        /// <summary>
        /// Checks if cbAllIPs is checked to change the state at the checklist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAllIPs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllIPs.Checked == true)
            {
                lblCheck4.ForeColor = System.Drawing.Color.Black;
                //tbxuserip.Text = "All IPs are selected!";
            }
            if (cbAllIPs.Checked != true)
            {
                lblCheck4.ForeColor = System.Drawing.Color.DodgerBlue;
            }
        }

        /// <summary>
        /// Checks if there is text in tbxusername to change the state at the checklist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxusername_TextChanged(object sender, EventArgs e)
        {
            if (tbxusername.TextLength == 0 || tbxpassword.TextLength == 0)
            {
                lblCheck3.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            if (tbxusername.TextLength != 0 && tbxpassword.TextLength != 0)
            {
                lblCheck3.ForeColor = System.Drawing.Color.Black;
            }
        }

        /// <summary>
        /// Checks if there is text in tbxpassword to change the state at the checklist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxpassword_TextChanged(object sender, EventArgs e)
        {
            if (tbxusername.TextLength == 0 || tbxpassword.TextLength == 0)
            {
                lblCheck3.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            if (tbxusername.TextLength != 0 && tbxpassword.TextLength != 0)
            {
                lblCheck3.ForeColor = System.Drawing.Color.Black;
            }
        }

        /// <summary>
        /// Opens the help window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Visible = true;
        }

        public List<IPAddress> ipAddressesmultiple = new List<IPAddress>();

        /// <summary>
        /// Doubleclick to select multiple IPs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lsb_discover_DoubleClick(object sender, EventArgs e)
        {
            string item = Convert.ToString(lsb_discover.SelectedItem);
            try
            {
                if (ipAddressesmultiple.Contains(IPAddress.Parse(item)))
                {

                }
                else
                {
                    ipAddressesmultiple.Add(IPAddress.Parse(item));
                    MessageBox.Show(item + " added");
                    int position = lsb_discover.Items.IndexOf(item);
                    lsb_discover.Items.RemoveAt(position);
                    lsb_discover.Items.Insert(position, item + " ✔");
                }
            }catch(FormatException fe)
            {
                MessageBox.Show("This IP address has already been selected!");
            }
        }

        private void Tbxuserip_TextChanged(object sender, EventArgs e)
        {

        }
        private void All_Click(object sender, EventArgs e)
        {


        }

        private void Cbmultiple_CheckedChanged(object sender, EventArgs e)
        {
            //cbAllIPs.Enabled = false;
        }

        private void TcNetworkDicovery_Click(object sender, EventArgs e)
        {

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

        private void Lsb_discover_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblLoading_Click(object sender, EventArgs e)
        {

        }
    }
}

