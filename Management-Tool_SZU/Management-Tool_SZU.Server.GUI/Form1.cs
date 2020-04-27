using Management_Tool_SZU.Shared;
using System;
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
            ThreadStart ts = new ThreadStart(GetStatisticForm);
            Thread t = new Thread(ts)
            {
                IsBackground = true
            };
            t.Start();
            tcWindow.SelectedIndex = 1;
        }

        private void GetStatisticForm()
        {
            if (this.lsb_discover.SelectedIndex == -1)
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
            {
                try
                {
                    com.SelectVoice("Microsoft Hazel Desktop");
                    com.SpeakAsync("Results are in the Statistic tab");
                }
                catch (Exception)
                {
                }
                WMICAction();
            }
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

        private void WMICAction()
        {
            string osname = wmics.GetStatistic(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(osname);

            string baseboardmanufacturer = wmics.GetStatistic2(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(baseboardmanufacturer);

            string baseboardserialnumber = wmics.GetStatistic3(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(baseboardserialnumber);

            string baseboardstatus = wmics.GetStatistic4(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(baseboardstatus);

            string text5 = wmics.GetStatistic5(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text5);

            string text6 = wmics.GetStatistic6(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text6);

            string text7 = wmics.GetStatistic7(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text7);

            string text8 = wmics.GetStatistic8(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text8);

            string text9 = wmics.GetStatistic9(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text9);

            string text10 = wmics.GetStatistic10(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text10);

            string text11 = wmics.GetStatistic11(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text11);

            string text12 = wmics.GetStatistic12(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text12);

            string text13 = wmics.GetStatistic13(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text13);

            string text14 = wmics.GetStatistic14(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text14);

            string text15 = wmics.GetStatistic15(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text15);

            string text16 = wmics.GetStatistic16(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text16);

            string text17 = wmics.GetStatistic17(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text17);

            string text18 = wmics.GetStatistic18(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text18);

            string text19 = wmics.GetStatistic19(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text19);

            string text20 = wmics.GetStatistic20(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text20);

            string text21 = wmics.GetStatistic21(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text21);

            string text22 = wmics.GetStatistic22(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text22);

            string text23 = wmics.GetStatistic23(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text23);

            string text24 = wmics.GetStatistic24(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text24);

            string text25 = wmics.GetStatistic25(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text25);

            string text26 = wmics.GetStatistic26(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text26);

            string text27 = wmics.GetStatistic27(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text27);

            string text28 = wmics.GetStatistic28(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text28);

            string text29 = wmics.GetStatistic29(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text29);

            string text30 = wmics.GetStatistic30(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text30);

            string text31 = wmics.GetStatistic31(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text31);

            string text32 = wmics.GetStatistic32(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text32);

            string text33 = wmics.GetStatistic33(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text33);

            string text34 = wmics.GetStatistic34(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text34);

            string text35 = wmics.GetStatistic35(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(text35);

            string text36 = wmics.GetStatistic36(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
            GiveIntoListview(osname);
        }
    }
}

