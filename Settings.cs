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
            string settingsstartwindowscheck = options[1 - 1];
            string settingstrayiconcheck = options[2 - 1];
            string settingsdarkmodecheck = options[3 - 1];
            string settingsstartwindowsvalue = settingsstartwindowscheck.Substring(20, settingsstartwindowscheck.Length - 20).ToString();
            string settingstrayiconvalue = settingstrayiconcheck.Substring(16, settingstrayiconcheck.Length - 16).ToString();
            string settingsdarkmodevalue = settingsdarkmodecheck.Substring(11, settingsdarkmodecheck.Length - 11).ToString();
            startWithWindowsOption.Checked = bool.Parse(settingsstartwindowsvalue);
            showTrayIconOption.Checked = bool.Parse(settingstrayiconvalue);
            darkModeOption.Checked = bool.Parse(settingsdarkmodevalue);
        }

        private void startWithWindowsOption_CheckedChanged(object sender, EventArgs e)
        {
            const string sSettings = "Settings.txt";
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (startWithWindowsOption.Checked)
            {
                rk.SetValue("WindowsRepoTool", Application.ExecutablePath);
                string[] options = File.ReadAllLines(sSettings);
                options[1 - 1] = "Start With Windows: True";
                File.WriteAllLines(sSettings, options);
            }
            else
            {
                rk.DeleteValue("WindowsRepoTool", false);
                string[] options = File.ReadAllLines(sSettings);
                options[1 - 1] = "Start With Windows: False";
                File.WriteAllLines(sSettings, options);
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

        private void darkModeOption_CheckedChanged(object sender, EventArgs e)
        {
            const string sSettings = "Settings.txt";
            if (darkModeOption.Checked)
            {
                this.BackColor = ColorTranslator.FromHtml("#2d2d2d");
                string[] options = File.ReadAllLines(sSettings);
                options[3 - 1] = "Dark Mode: True";
                File.WriteAllLines(sSettings, options);
            }
            else
            {
                this.BackColor = SystemColors.Control;
                string[] options = File.ReadAllLines(sSettings);
                options[3 - 1] = "Dark Mode: False";
                File.WriteAllLines(sSettings, options);
            }
        }
    }
}
