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
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using Microsoft.Win32;

namespace WindowsRepoTool
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public static class GlobalsSettings
        {
            public static NotifyIcon trayIconOptions = Main.Globals.trayProperties;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            const string sSettings = "Settings.txt";
            string[] options = File.ReadAllLines(sSettings);
            string settingscheck = options[2 - 1];
            string settingsvalue = settingscheck.Substring(16, settingscheck.Length - 16).ToString();
            showTrayIconOption.Checked = bool.Parse(settingsvalue);
        }

        private void startWithWindowsOption_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (startWithWindowsOption.Checked)
            {
                rk.SetValue("WindowsRepoTool", Application.ExecutablePath);
            }
            else
            {
                rk.DeleteValue("WindowsRepoTool", false);
            }
        }

        private void showTrayIconOption_CheckedChanged(object sender, EventArgs e)
        {
            const string sSettings = "Settings.txt";
            if (showTrayIconOption.Checked)
            {
                GlobalsSettings.trayIconOptions.Visible = true;
                string[] options = File.ReadAllLines(sSettings);
                options[2 - 1] = "Show Tray Icon: True";
                File.WriteAllLines(sSettings, options);
            }
            else
            {
                GlobalsSettings.trayIconOptions.Visible = false;
                string[] options = File.ReadAllLines(sSettings);
                options[2 - 1] = "Show Tray Icon: False";
                File.WriteAllLines(sSettings, options);
            }
        }
    }
}
