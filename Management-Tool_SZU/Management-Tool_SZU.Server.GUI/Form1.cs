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
            GetStatisticForm();
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
                string text = wmics.GetStatistic(tbxuserip.Text,tbxusername.Text,tbxpassword.Text);
                lsb_networkadapter.Items.Add(text);
                string text2 = wmics.GetStatistic2(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text2);
                string text3 = wmics.GetStatistic3(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text3);
                string text4 = wmics.GetStatistic4(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text4);
                string text5 = wmics.GetStatistic5(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text5);
                string text6 = wmics.GetStatistic6(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text6);
                string text7 = wmics.GetStatistic7(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text7);
                string text8 = wmics.GetStatistic8(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text8);
                string text9 = wmics.GetStatistic9(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text9);
                string text10 = wmics.GetStatistic10(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text10);
                string text11 = wmics.GetStatistic11(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text11);
                string text12 = wmics.GetStatistic12(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text12);
                string text13 = wmics.GetStatistic13(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text13);
                string text14 = wmics.GetStatistic14(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text14);
                string text15 = wmics.GetStatistic15(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text15);
                string text16 = wmics.GetStatistic16(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text16);
                string text17 = wmics.GetStatistic17(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text17);
                string text18 = wmics.GetStatistic18(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text18);
                string text19 = wmics.GetStatistic19(tbxuserip.Text, tbxusername.Text, tbxpassword.Text);
                lsb_networkadapter.Items.Add(text19);

            }
        }

        private void Lsb_discover_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userip = lsb_discover.GetItemText(lsb_discover.SelectedItem);
            tbxuserip.Text = userip;
        }
    }
}

