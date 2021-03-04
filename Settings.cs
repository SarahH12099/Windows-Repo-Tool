using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (showTrayIconOption.Checked)
            {
                GlobalsSettings.trayIconOptions.Visible = true;
            }
            else
            {
                GlobalsSettings.trayIconOptions.Visible = false;
            }
        }
    }
}
