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

namespace WindowsRepoTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            addRepoBox.Text = "https://";
            searchBox.Text = "Search Packages";
            const string sPath = "Repos.txt";
            const string sDirectory = "Debs";
            const string sPackages = "Packages";
            const string sDownloads = "Packages.bz2";
            if (!Directory.Exists(sDirectory))
            {
                Directory.CreateDirectory(sDirectory);
            }
            if (Directory.Exists(sPackages))
            {
                Directory.Delete(sPackages, true);
            }
            if (File.Exists(sDownloads))
            {
                File.Delete(sDownloads);
            }
            if (!File.Exists(sPath))
            {
                File.Create(sPath).Close();
                string[] lines = File.ReadAllLines(sPath);
                repoListBox.Items.AddRange(lines);
            }
            else
            {
                string[] lines = File.ReadAllLines(sPath);
                repoListBox.Items.AddRange(lines);
            }
        }

        public static class Globals
        {
            public static List<string> list = new List<string>();
            public static List<string> name = new List<string>();
            public static List<string> version = new List<string>();
            public static String repo = "";
            public static int count = 0;
        }

        public class ListItem
        {
            public string Name { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private void addRepoBtn_Click(object sender, EventArgs e)
        {
            string repo = addRepoBox.Text.ToLower();
            string finalrepo;
            
            if (repo.EndsWith("/"))
            {
                finalrepo = repo;
            }
            else
            {
                finalrepo = repo + "/";
            }
            
            if (!repoListBox.Items.Contains(finalrepo))
            {
                if (addRepoBox.Text != "https://")
                {
                    repoListBox.Items.Add(finalrepo);
                    const string sPath = "Repos.txt";
                    StreamWriter SaveFile = new StreamWriter(sPath);
                    foreach (var item in repoListBox.Items) {
                        SaveFile.WriteLine(item.ToString());
                    }
                    SaveFile.Close();
                    addRepoBox.Clear();
                    addRepoBox.Text = "https://";
                    string title = "Notice";
                    string message = "Added Repo Successfully";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string title = "Notice";
                    string message = "Please Type In A Repo";
                    MessageBox.Show(message, title);
                }
            }
            else
            {
                addRepoBox.Clear();
                addRepoBox.Text = "https://";
                string title = "Notice";
                string message = "You Already Have This Repo Added";
                MessageBox.Show(message, title);
            };
        }

        private void clearAllReposBtn_Click(object sender, EventArgs e)
        {
            string title = "Notice";
            string message = "Are you sure you want to clear all added repos?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                repoListBox.Items.Clear();
                const string sPath = "Repos.txt";
                StreamWriter SaveFile = new StreamWriter(sPath);
                foreach (var item in repoListBox.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.Close();
                string titlefinal = "Notice";
                string messagefinal = "Cleared All Repos Successfully";
                MessageBox.Show(messagefinal, titlefinal);
            }
        }

        private void clearSelectedRepoBtn_Click(object sender, EventArgs e)
        {
            string title = "Notice";
            string message = "Are you sure you want to clear the selected repo?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (repoListBox.SelectedItem == null)
                {
                    string titlefinal = "Notice";
                    string messagefinal = "No Repo Selected, Please Select A Repo";
                    MessageBox.Show(messagefinal, titlefinal);
                }
                else
                {
                    repoListBox.Items.Remove(repoListBox.SelectedItem);
                    const string sPath = "Repos.txt";
                    StreamWriter SaveFile = new StreamWriter(sPath);
                    foreach (var item in repoListBox.Items)
                    {
                        SaveFile.WriteLine(item.ToString());
                    }
                    SaveFile.Close();
                    string titlefinal = "Notice";
                    string messagefinal = "Cleared The Selected Repo Successfully";
                    MessageBox.Show(messagefinal, titlefinal);
                }
            }
        }

        private void openSelectedRepoBtn_Click(object sender, EventArgs e)
        {
            if (repoListBox.SelectedItem == null)
            {
                string titlefinal = "Notice";
                string messagefinal = "Test Null";
                MessageBox.Show(messagefinal, titlefinal);
            }
            else
            {
                packagesListBox.Items.Clear();
                packagesListBox.Items.Add("Opening Repo, Please Wait");
                Globals.name.Clear();
                Globals.version.Clear();
                Globals.list.Clear();
                Globals.count = 0;
                Globals.repo = repoListBox.SelectedItem.ToString();
                const string sPath = "Packages.bz2";
                const string sFolder = "Packages";
                const string sPackages = "Packages/Packages";
                if (File.Exists(sPath))
                {
                    File.Delete(sPath);
                }
                if (Directory.Exists(sFolder))
                {
                    Directory.Delete(sFolder, true);
                }
                using (var client = new WebClient())
                {
                    if (repoListBox.SelectedItem.ToString() == "http://apt.thebigboss.org/repofiles/cydia/" || repoListBox.SelectedItem.ToString() == "https://apt.thebigboss.org/repofiles/cydia/") {
                        client.DownloadFile("http://apt.thebigboss.org/repofiles/cydia/dists/stable/main/binary-iphoneos-arm/Packages.bz2", "Packages.bz2");
                    }
                    else if (repoListBox.SelectedItem.ToString() == "http://apt.modmyi.com/" || repoListBox.SelectedItem.ToString() == "https://apt.modmyi.com/")
                    {
                        client.DownloadFile("http://apt.modmyi.com/dists/stable/main/binary-iphoneos-arm/Packages.bz2", "Packages.bz2");
                    }
                    else
                    {
                        client.DownloadFile(repoListBox.SelectedItem + "Packages.bz2", "Packages.bz2");
                    }
                    string zPath = "7za.exe";
                    try
                    {
                        ProcessStartInfo pro = new ProcessStartInfo();
                        pro.WindowStyle = ProcessWindowStyle.Hidden;
                        pro.FileName = zPath;
                        pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sPath, sFolder);
                        Process x = Process.Start(pro);
                        x.WaitForExit();
                    }
                    catch (System.Exception Ex)
                    {
                        string titlefinal = "Notice";
                        string messagefinal = Ex.ToString();
                        MessageBox.Show(messagefinal, titlefinal);
                    }

                    string[] lines = File.ReadAllLines(sPackages);
                    foreach (string line in lines)
                    {
                        if (line.StartsWith("Name"))
                        {
                            Globals.name.Add(line);
                        }
                        if (line.StartsWith("Version"))
                        {
                            Globals.version.Add(line);
                        }
                        if (line.StartsWith("Filename"))
                        {
                            Globals.list.Add(line);
                        }
                    }
                    packagesListBox.Items.Clear();
                    foreach (string name in Globals.name)
                    {
                        packagesListBox.Items.Add(new ListItem { Name = name.Substring(6, name.Length - 6) + " v" + Globals.version[Globals.count].Substring(9, Globals.version[Globals.count].Length - 9), Value = Globals.list[Globals.count] });
                        Globals.count = Globals.count + 1;
                    }
                    packagesListBox.Sorted = true;
                }
            }
        }

        private void downloadSelectedPackageBtn_Click(object sender, EventArgs e)
        {
            string selectedPackageItem = packagesListBox.SelectedItem.ToString();
            string repoURL = Globals.repo;
            string packageURL = ((ListItem)packagesListBox.SelectedItem).Value;
            string downloadURL = repoURL + packageURL.Substring(10, packageURL.Length - 10);
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(downloadURL, $"Debs/{selectedPackageItem}.deb");
                    string titlefinal = "Notice";
                    string messagefinal = "Download Complete, Deb Is Located In The Debs Folder";
                    MessageBox.Show(messagefinal, titlefinal);
                }
                catch (System.Exception Ex)
                {
                    string titleexception = "Notice";
                    string messageexception = "You can't download paid packages with Windows Repo Tool \n\n" + Ex.ToString();
                    MessageBox.Show(messageexception, titleexception);
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            packagesListBox.Items.Clear();
            packagesListBox.Items.Add("Searching, Please Wait");
            Globals.name.Clear();
            Globals.version.Clear();
            Globals.list.Clear();
            Globals.count = 0;
            const string sPackages = "Packages/Packages";
            string[] lines = { };
            if (File.Exists(sPackages))
            {
                lines = File.ReadAllLines(sPackages);
            }
            foreach (string line in lines)
            {
                if (line.StartsWith("Name"))
                {
                    Globals.name.Add(line);
                }
                if (line.StartsWith("Version"))
                {
                    Globals.version.Add(line);
                }
                if (line.StartsWith("Filename"))
                {
                    Globals.list.Add(line);
                }
            }
            packagesListBox.Items.Clear();
            foreach (string name in Globals.name)
            {
                if (name.Substring(6, name.Length - 6).StartsWith(searchBox.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    packagesListBox.Items.Add(new ListItem { Name = name.Substring(6, name.Length - 6) + " v" + Globals.version[Globals.count].Substring(9, Globals.version[Globals.count].Length - 9), Value = Globals.list[Globals.count] });
                }
                Globals.count = Globals.count + 1;
            }
            packagesListBox.Sorted = true;
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Packages")
            {
                searchBox.Clear();
            }
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == string.Empty)
            {
                searchBox.Text = "Search Packages";
            }
        }
    }
}
