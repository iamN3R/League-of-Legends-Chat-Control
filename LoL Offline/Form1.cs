using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace LoL_Offline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void blockRegion(string Ip)
        {

            var createRule =
                new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                $"advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = {Ip} protocol = TCP action = block")
                {
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Verb = "runas"
                };

            try
            {
                Process.Start(createRule);
            }
            catch (Win32Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var blockedRegion = RegionChosen();
            if (blockedRegion == "EUW")
            {
                blockRegion("185.40.64.69");
               
            }
            if (blockedRegion == "NA")
            {
                blockRegion("192.64.174.69");
            }

            if (blockedRegion == "EUNE")
            {
                blockRegion("185.40.64.110");
            }

            if (blockedRegion == "OCE")
            {
                blockRegion("192.64.169.20");
            }

            if (blockedRegion == "LAS")
            {
                blockRegion("66.151.33.28");
            }

            if (blockedRegion == "LAN")
            {
                blockRegion("66.151.33.24");
            }

            if (blockedRegion == "BR")
            {
                blockRegion("66.151.33.20");
            }

            if (blockedRegion == "TUR")
            {
                blockRegion("185.40.64.105");
            }

            if (blockedRegion == "RUS")
            {
                blockRegion("185.40.64.99");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var psi =
                new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                "advfirewall firewall delete rule name = \"N3RLoLOffline\"")
                {
                    UseShellExecute = true,
                    Verb = "runas",
                    WindowStyle = ProcessWindowStyle.Hidden
                };
            try
            {
                Process.Start(psi);
            }
            catch (Win32Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var howitworks = new Form2();
            howitworks.Show();
        }

        private string RegionChosen()
        {
            var chosen = RegionBox.SelectedItem;
            switch (chosen)
            {
                case "EUW": return "EUW";
                case "NA": return "NA";
                case "EUNE": return "EUNE";
                case "LAS": return "LAS";
                case "LAN": return "LAN";
                case "OCE": return "OCE";
                case "BR": return "BR";
                case "TUR": return "TUR";
                case "RUS": return "RUS";
                default: return "";
            }
        }
    }
} 
