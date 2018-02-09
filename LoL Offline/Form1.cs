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

        private void button1_Click(object sender, EventArgs e)
        {
            var blockedRegion = RegionChosen();
            if (RegionBox.SelectedItem == "EUW")
            {
                var createRule_EUW =
                    new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                    "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = 185.40.64.69 protocol = TCP action = block")
                    {
                        UseShellExecute = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        Verb = "runas"
                    };

                try
                {
                    Process.Start(createRule_EUW);
                }
                catch (Win32Exception) { }

            }

            if (RegionBox.SelectedItem == "NA")
            {
                var createRule_NA =
                    new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                    "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = 192.64.174.69 protocol = TCP action = block")
                    {
                        UseShellExecute = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        Verb = "runas"
                    };

                try
                {
                    Process.Start(createRule_NA);
                }
                catch (Win32Exception) { }

            }

            if (RegionBox.SelectedItem == "EUNE")
            {
                string EUNE_IP = "";
                var createRule_EUNE =
                        new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                        "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = " + EUNE_IP + " protocol = TCP action = block")
                        {
                            UseShellExecute = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            Verb = "runas"
                        };

                try
                {
                    Process.Start(createRule_EUNE);
                }
                catch (Win32Exception) { }

            }

            if (RegionBox.SelectedItem == "OCE")
            {
                string OCE_IP = "";
                var createRule_OCE =
                        new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                        "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = " + OCE_IP + " protocol = TCP action = block")
                        {
                            UseShellExecute = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            Verb = "runas"
                        };

                try
                {
                    Process.Start(createRule_OCE);
                }
                catch (Win32Exception) { }

            }

            if (RegionBox.SelectedItem == "LAS")
            {
                string LAS_IP = "";
                var createRule_LAS =
                        new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                        "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = " + LAS_IP + " protocol = TCP action = block")
                        {
                            UseShellExecute = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            Verb = "runas"
                        };

                try
                {
                    Process.Start(createRule_LAS);
                }
                catch (Win32Exception) { }

            }

            if (RegionBox.SelectedItem == "LAN")
            {
                string LAN_IP = "";
                var createRule_LAN =
                        new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                        "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = " + LAN_IP + " protocol = TCP action = block")
                        {
                            UseShellExecute = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            Verb = "runas"
                        };

                try
                {
                    Process.Start(createRule_LAN);
                }
                catch (Win32Exception) { }

            }

            if (RegionBox.SelectedItem == "BR")
            {
                string BR_IP = "";
                var createRule_BR =
                        new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                        "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = " + BR_IP + " protocol = TCP action = block")
                        {
                            UseShellExecute = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            Verb = "runas"
                        };

                try
                {
                    Process.Start(createRule_BR);
                }
                catch (Win32Exception) { }

            }

            if (RegionBox.SelectedItem == "TUR")
            {
                string TUR_IP = "";
                var createRule_TUR =
                        new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                        "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = " + TUR_IP + " protocol = TCP action = block")
                        {
                            UseShellExecute = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            Verb = "runas"
                        };

                try
                {
                    Process.Start(createRule_TUR);
                }
                catch (Win32Exception) { }

            }

            if (RegionBox.SelectedItem == "RUS")
            {
                string RUS_IP = "";
                var createRule_RUS =
                        new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                        "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = " + RUS_IP + " protocol = TCP action = block")
                        {
                            UseShellExecute = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            Verb = "runas"
                        };

                try
                {
                    Process.Start(createRule_RUS);
                }
                catch (Win32Exception) { }

            }

            //var createRule_NA =
            //    new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
            //    "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = 192.64.174.69 protocol = TCP action = block")                {
            //        UseShellExecute = true,
            //        WindowStyle = ProcessWindowStyle.Hidden,
            //        Verb = "runas"
            //  };

            //        var enableRule =
            //            new ProcessStartInfo("c:\\windows\\system32\\cmd.exe",
            //            "/Q /C netsh advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = 185.40.64.69 protocol = TCP action = block" +
            //            " & " +
            //            "netsh advfirewall firewall set rule name=\"N3RLoLOffline\" new enable=yes")
            //            {
            //                UseShellExecute = true,
            //                Verb = "runas"
            //            };
            //
            //Process.Start(enableRule);


            //try
            //{
            //    Process.Start(createRule_NA);
            //}
            //catch (Win32Exception) { }

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
