using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;


namespace Kakkulator_1
{
    public partial class Form1 : Form
    {
        static Regex rgx = new Regex(@"(^|\.)0+(?!\.|$)", RegexOptions.Compiled);
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateIP(object sender, EventArgs e)
        {
            String ipString = IpTextBox.Text;
            ipString = rgx.Replace(ipString, ".");

            IPAddress ipAddress = IPAddress.Parse(ipString);
            IPAddress maskAddress = IPAddress.Parse(MaskTextBox.Text);
            byte[] ip = ipAddress.GetAddressBytes();
            byte[] mask = maskAddress.GetAddressBytes();
            byte[] network = new byte[4];
            byte[] broadcast = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                network[i] = (byte)(ip[i] & mask[i]);
            }
            Array.Copy(network, broadcast, 4);
            string networkAddressString = "";
            string broadcastAddressString = "";
            for (int i = 0; i < 4; i++)
            {
                //string
                string ipFragment = network[i].ToString();
                networkAddressString += ipFragment;
                //broadcast
                ipFragment = broadcast[i].ToString();
                ipFragment = ipFragment.PadLeft(3, '0');
                broadcastAddressString += ipFragment;
            }
            NetworkAddressTextBox.Text = networkAddressString;
            BroadcastTextBox.Text = broadcastAddressString;



          
        }
        private void Buttonix(object sender, EventArgs e)
        {
            byte[] ipAddress = new byte[4];
            ipAddress[0] = (byte)Ip0octet1.Value;
            ipAddress[1] = (byte)Ip0octet2.Value;
            ipAddress[2] = (byte)Ip0octet3.Value;
            ipAddress[3] = (byte)Ip0octet4.Value;
            IPAddress ip = new IPAddress(ipAddress);
            IPNetwork network = IPNetwork.Parse(ip.ToString(), (byte)CidrTextBox.Value);
            IpTextBox.Text = network.Value;
            MaskTextBox.Text = network.Netmask.ToString();
            NetworkAddressTextBox.Text = network.Network.ToString();
            BroadcastTextBox.Text = network.Broadcast.ToString();
            FirstUsefullTextBox.Text = network.FirstUsable.ToString();
            LastUsefullTextBox.Text = network.LastUsable.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
