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
                    string text = wmics.GetStatistic(IPAddress.Parse(lsb_discover.SelectedItem.ToString()));
                    lsb_networkadapter.Items.Add(text);
                }
                catch (Exception)
                {
                }

            }
        }
    }
}

