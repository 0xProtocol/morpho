﻿using Management_Tool_SZU.Shared;
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
        private void lvItem_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != _sortColumnIndex)
            {
                // Set the sort column to the new column.
                _sortColumnIndex = e.Column;
                // Set the sort order to ascending by default.
                lvstatistics.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (lvstatistics.Sorting == SortOrder.Ascending)
                    lvstatistics.Sorting = SortOrder.Descending;
                else
                    lvstatistics.Sorting = SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            lvstatistics.Sort();
            
            // Set the ListViewItemSorter property to a new ListViewItemComparer object.
            if (e.Column == lvstatistics.Columns["Result"].Index)
                lvstatistics.ListViewItemSorter = new ListViewComparer(e.Column, lvstatistics.Sorting);
            else
                lvstatistics.ListViewItemSorter = new ListViewComparer(e.Column, lvstatistics.Sorting);
                
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

                ThreadStart start = delegate { nd.QuickSearch(lsb_discover, pbnetwork, cbAllIPs); };
                discoverythread = new Thread(new ThreadStart(start));
                discoverythread.Start();

            }
            catch (Exception ex)
            {
            }
        }

        private void Btn_Discover_Click_1(object sender, EventArgs e)
        {
            lblCheck2.ForeColor = System.Drawing.Color.Black;
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
            lblCheck5.ForeColor = System.Drawing.Color.Black;
            if(cbAllIPs.Checked == true)
            {
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
            else
            {
                Thread thread = new Thread(delegate () { GetStatisticForm(Convert.ToString(tbxuserip.Text)); });
                thread.Start();
                tcWindow.SelectedIndex = 1;
            }

           
        }

        private void GetStatisticForm(string ip)
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
                  //  com.SelectVoice("Microsoft Hazel Desktop");
                 //   com.SpeakAsync("Results are in the Statistic tab");
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
        int counter = 0;
        private void GiveIntoListview(string wmicvalue,string ip)
        {
            try
            {
                string[] values = SplitIncominMessage(wmicvalue);

                if (lvstatistics.Columns.Count < values.Length)
                {
                    counter = values.Length - lvstatistics.Columns.Count;
                    for (int i = 0; i < counter +1; i++)
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
            catch (Exception)
            {

                
            }
            
        }

        private void WMICAction(string ip)
        {
            // OS
            if (cboperatingsystem.Text == "All")
            {
                string OperatingSystemName = wmics.GetStatistic(ip, tbxusername.Text, tbxpassword.Text);
                GiveIntoListview(OperatingSystemName,ip);

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
                GiveIntoListview(DiskDriveStatus,ip);

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
                string LogicalDiskFileSystem = wmics.GetStatistic22(ip ,tbxusername.Text, tbxpassword.Text);
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
                string NetworkAdapterDescription = wmics.GetStatistic24(ip ,tbxusername.Text, tbxpassword.Text);
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
            if(cbAlternative.Text=="All")
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
            
            
        }

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

        private void cbAllIPs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllIPs.Checked == true)
            {
                lblCheck4.ForeColor = System.Drawing.Color.Black;
            }
            if (cbAllIPs.Checked != true)
            {
                lblCheck4.ForeColor = System.Drawing.Color.DodgerBlue;
            }
        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Visible = true;
        }
    }
}

