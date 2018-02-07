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
            if(RegionBox.SelectedItem == "EUW")
            {
            var createRule_EUW =
                new ProcessStartInfo("c:\\windows\\system32\\netsh.exe",
                "advfirewall firewall add rule name = \"N3RLoLOffline\" dir =out remoteip = 185.40.64.69 protocol = TCP action = block")                {
                    UseShellExecute = true,
                    WindowStyle =ProcessWindowStyle.Hidden,
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
                case "EUW":return "EUW";
                case "NA":return "NA";
                default:return "";
            }
        }
    }
}
