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
            const string sGz = "Packages.gz";
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
            if (File.Exists(sGz))
            {
                File.Delete(sGz);
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
            public static List<string> package = new List<string>();
            public static List<string> name = new List<string>();
            public static List<string> version = new List<string>();
            public static List<string> link = new List<string>();
            public static List<string> description = new List<string>();
            public static List<string> author = new List<string>();
            public static List<string> maintainer = new List<string>();
            public static string repo = "";
            public static int count = 0;
            public static int arraycount = 0;
        }

        public class ListItem
        {
            public string Package { get; set; }
            public string Name { get; set; }
            public string SingleName { get; set; }
            public string Version { get; set; }
            public string Link { get; set; }
            public string Description { get; set; }
            public string Author { get; set; }
            public string Maintainer { get; set; }

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
                if (addRepoBox.Text != "https://" & addRepoBox.Text != "http://" & addRepoBox.Text != String.Empty)
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
                    return;
                }
                else
                {
                    string title = "Notice";
                    string message = "Please Type In A Repo";
                    MessageBox.Show(message, title);
                    return;
                }
            }
            else
            {
                addRepoBox.Clear();
                addRepoBox.Text = "https://";
                string title = "Notice";
                string message = "You Already Have This Repo Added";
                MessageBox.Show(message, title);
                return;
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
                return;
            }
            if (result == DialogResult.No)
            {
                return;
            }
        }

        private void clearSelectedRepoBtn_Click(object sender, EventArgs e)
        {
            if (repoListBox.SelectedItem == null)
            {
                string titlefinal = "Notice";
                string messagefinal = "Please select a repo";
                MessageBox.Show(messagefinal, titlefinal);
                return;
            }
            else
            {
                string title = "Notice";
                string message = "Are you sure you want to clear the selected repo?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
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
                    return;
                }
                if (result == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void openSelectedRepoBtn_Click(object sender, EventArgs e)
        {
            if (repoListBox.SelectedItem == null)
            {
                string titlefinal = "Notice";
                string messagefinal = "Please select a repo";
                MessageBox.Show(messagefinal, titlefinal);
                return;
            }
            else
            {
                packagesListBox.Items.Clear();
                detailsBox.Clear();
                using (var badrepocheck = new WebClient())
                {
                    const string sRepos = "https://sarahh12099.github.io/files/badrepos.txt";
                    Stream stream = badrepocheck.OpenRead(sRepos);
                    StreamReader reader = new StreamReader(stream);
                    string check; 
                    while ((check = reader.ReadLine()) != null)
                    {
                        if (check == repoListBox.SelectedItem.ToString())
                        {
                            string title = "Warning";
                            string message = "You are about to open a repo that has been flagged as Dangerous, are you sure you want to open it?";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show(message, title, buttons);
                            if (result == DialogResult.Yes)
                            {
                                continue;
                            }
                            if (result == DialogResult.No)
                            {
                                return;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    reader.Close();
                }
                packagesListBox.Items.Add("Opening Repo, Please Wait");
                Globals.package.Clear(); 
                Globals.name.Clear();
                Globals.description.Clear();
                Globals.version.Clear();
                Globals.link.Clear();
                Globals.author.Clear();
                Globals.maintainer.Clear();
                Globals.count = 0;
                Globals.repo = repoListBox.SelectedItem.ToString();
                const string sPath = "Packages.bz2";
                const string sGz = "Packages.gz";
                const string sFolder = "Packages";
                const string sPackages = "Packages/Packages";
                const string sText = "Packages.txt";
                if (File.Exists(sPath))
                {
                    File.Delete(sPath);
                }
                if (File.Exists(sGz))
                {
                    File.Delete(sGz);
                }
                if (File.Exists(sText))
                {
                    File.Delete(sText);
                }
                if (Directory.Exists(sFolder))
                {
                    Directory.Delete(sFolder, true);
                }
                using (var client = new WebClient())
                {
                    try
                    {
                        client.Headers.Add("X-Machine", "iPhone8,1");
                        client.Headers.Add("X-Unique-ID", "8843d7f92416211de9ebb963ff4ce28125932878");
                        client.Headers.Add("X-Firmware", "13.1");
                        client.Headers.Add("User-Agent", "Telesphoreo APT-HTTP/1.0.592");
                        client.DownloadFile(repoListBox.SelectedItem + "Packages.bz2", "Packages.bz2");
                    }
                    catch (Exception ExOne)
                    {
                        try
                        {
                            client.Headers.Add("X-Machine", "iPhone8,1");
                            client.Headers.Add("X-Unique-ID", "8843d7f92416211de9ebb963ff4ce28125932878");
                            client.Headers.Add("X-Firmware", "13.1");
                            client.Headers.Add("User-Agent", "Telesphoreo APT-HTTP/1.0.592");
                            client.DownloadFile(repoListBox.SelectedItem + "dists/stable/main/binary-iphoneos-arm/Packages.bz2", "Packages.bz2");
                        }
                        catch (Exception ExTwo)
                        {
                            try
                            {
                                client.Headers.Add("X-Machine", "iPhone8,1");
                                client.Headers.Add("X-Unique-ID", "8843d7f92416211de9ebb963ff4ce28125932878");
                                client.Headers.Add("X-Firmware", "13.1");
                                client.Headers.Add("User-Agent", "Telesphoreo APT-HTTP/1.0.592");
                                client.DownloadFile(repoListBox.SelectedItem + "Packages.gz", "Packages.gz");
                            }
                            catch (Exception ExThree)
                            {
                                string titlefinal = "Notice";
                                string messagefinal = "Unable to connect to repo, are you connected to the internet and did you type the repo url correctly? \n\n" + ExThree;
                                MessageBox.Show(messagefinal, titlefinal);
                                return;
                            }
                        }
                    }
                    string zPath = "7za.exe";
                    try
                    {
                        ProcessStartInfo pro = new ProcessStartInfo();
                        pro.WindowStyle = ProcessWindowStyle.Hidden;
                        pro.FileName = zPath;
                        if (File.Exists(sPath))
                        {
                            pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sPath, sFolder);
                        }
                        if (File.Exists(sGz))
                        {
                            pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sGz, sFolder);
                        }
                        Process x = Process.Start(pro);
                        x.WaitForExit();
                    }
                    catch (Exception Ex)
                    {
                        string titlefinal = "Notice";
                        string messagefinal = Ex.ToString();
                        MessageBox.Show(messagefinal, titlefinal);
                        return;
                    }

                    Stream stream = File.OpenRead(sPackages);
                    StreamReader reader = new StreamReader(stream);
                    string parse;
                    const string sTath = "Packages.txt";
                    StreamWriter SaveFile = new StreamWriter(sTath);
                    while ((parse = reader.ReadLine()) != null)
                    {
                        SaveFile.WriteLine(parse.ToString());
                    }
                    SaveFile.Close();
                    reader.Close();
                    string lines = File.ReadAllText(sText);
                    string[] split = lines.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in split)
                    {
                        MessageBox.Show(line);
                    }
                    packagesListBox.Items.Clear();
                    packagesListBox.Items.Add("Done");
                    /* packagesListBox.Items.Clear();
                    for (int i = 0; i < split.Length; i++)
                    {
                        packagesListBox.Items.Add(new ListItem { Name = "Test" });
                    } */
                }
            }
        }

        private void downloadSelectedPackageBtn_Click(object sender, EventArgs e)
        {
            if (packagesListBox.SelectedItem == null)
            {
                string titlefinal = "Notice";
                string messagefinal = "Please select a package";
                MessageBox.Show(messagefinal, titlefinal);
                return;
            }
            string selectedPackageItem = packagesListBox.SelectedItem.ToString();
            string repoURL = Globals.repo;
            string packageURL = ((ListItem)packagesListBox.SelectedItem).Link;
            string downloadURL = repoURL + packageURL;
            using (var client = new WebClient())
            {
                if (!Directory.Exists("Debs"))
                {
                    Directory.CreateDirectory("Debs");
                }
                try
                {
                    client.Headers.Add("X-Machine", "iPhone8,1");
                    client.Headers.Add("X-Unique-ID", "8843d7f92416211de9ebb963ff4ce28125932878");
                    client.Headers.Add("X-Firmware", "13.1");
                    client.Headers.Add("User-Agent", "Telesphoreo APT-HTTP/1.0.592");
                    client.DownloadFile(downloadURL, $"Debs/{selectedPackageItem}.deb");
                    string titlefinal = "Notice";
                    string messagefinal = "Download Complete, Deb Is Located In The Debs Folder";
                    MessageBox.Show(messagefinal, titlefinal);
                }
                catch (Exception Ex)
                {
                    string titleexception = "Notice";
                    string messageexception = "You can't download paid packages with Windows Repo Tool \n\n" + Ex.ToString();
                    MessageBox.Show(messageexception, titleexception);
                }
            }
        }

        private void packagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            detailsBox.Clear();
            string package = ((ListItem)packagesListBox.SelectedItem).Package;
            string name = ((ListItem)packagesListBox.SelectedItem).SingleName;
            string version = ((ListItem)packagesListBox.SelectedItem).Version;
            string author = ((ListItem)packagesListBox.SelectedItem).Author;
            string maintainer = ((ListItem)packagesListBox.SelectedItem).Maintainer;
            string description = ((ListItem)packagesListBox.SelectedItem).Description;
            detailsBox.Text = "ID: " + package + Environment.NewLine + "Name: " + name + Environment.NewLine + "Version: " + version + Environment.NewLine + "Author: " + author + Environment.NewLine + "Maintainer: " + maintainer + Environment.NewLine + "Description: " + description;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            packagesListBox.Items.Clear();
            packagesListBox.Items.Add("Searching, Please Wait");
            Globals.package.Clear();
            Globals.name.Clear();
            Globals.description.Clear();
            Globals.version.Clear();
            Globals.link.Clear();
            Globals.author.Clear();
            Globals.maintainer.Clear();
            Globals.count = 0;
            const string sPackages = "Packages/Packages";
            string[] lines = { };
            if (File.Exists(sPackages))
            {
                lines = File.ReadAllLines(sPackages);
            }
            foreach (string line in lines)
            {
                if (line.StartsWith("Package"))
                {
                    string package = line.Substring(9, line.Length - 9).ToString();
                    Globals.package.Add(package);
                }
                if (line.StartsWith("Name"))
                {
                    string name = line.Substring(6, line.Length - 6).ToString();
                    Globals.name.Add(name);
                }
                if (line.StartsWith("Description"))
                {
                    string description = line.Substring(13, line.Length - 13).ToString();
                    Globals.description.Add(description);
                }
                if (line.StartsWith("Version"))
                {
                    string version = line.Substring(9, line.Length - 9).ToString();
                    Globals.version.Add(version);
                }
                if (line.StartsWith("Filename"))
                {
                    string link = line.Substring(10, line.Length - 10).ToString();
                    Globals.link.Add(link);
                }
                if (line.StartsWith("Author"))
                {
                    string author = line.Substring(8, line.Length - 8).ToString();
                    Globals.author.Add(author);
                }
                if (line.StartsWith("Maintainer"))
                {
                    string maintainer = line.Substring(12, line.Length - 12).ToString();
                    Globals.maintainer.Add(maintainer);
                }
            }
            packagesListBox.Items.Clear();
            foreach (string name in Globals.name)
            {
                if (name.StartsWith(searchBox.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
                        packagesListBox.Items.Add(new ListItem { Name = Globals.name[Globals.count] + " v" + Globals.version[Globals.count], SingleName = Globals.name[Globals.count], Package = Globals.package[Globals.count], Link = Globals.link[Globals.count], Version = Globals.version[Globals.count], Description = Globals.description[Globals.count], Author = Globals.author[Globals.count], Maintainer = Globals.maintainer[Globals.count] });
                    }
                    catch (Exception ExOne)
                    {
                        try
                        {
                            packagesListBox.Items.Add(new ListItem { Name = Globals.name[Globals.count] + " v" + Globals.version[Globals.count], SingleName = Globals.name[Globals.count], Package = Globals.package[Globals.count], Link = Globals.link[Globals.count], Version = Globals.version[Globals.count], Description = Globals.description[Globals.count], Author = Globals.author[Globals.count] });
                        }
                        catch (Exception ExTwo)
                        {
                            try
                            {
                                packagesListBox.Items.Add(new ListItem { Name = Globals.name[Globals.count] + " v" + Globals.version[Globals.count], SingleName = Globals.name[Globals.count], Package = Globals.package[Globals.count], Link = Globals.link[Globals.count], Version = Globals.version[Globals.count], Description = Globals.description[Globals.count], Maintainer = Globals.maintainer[Globals.count] });
                            }
                            catch (Exception ExThree)
                            {
                                try
                                {
                                    packagesListBox.Items.Add(new ListItem { Name = Globals.name[Globals.count] + " v" + Globals.version[Globals.count], SingleName = Globals.name[Globals.count], Package = Globals.package[Globals.count], Link = Globals.link[Globals.count], Version = Globals.version[Globals.count], Description = Globals.description[Globals.count] });
                                }
                                catch (Exception ExFour)
                                {
                                    packagesListBox.Items.Add(new ListItem { Name = Globals.name[Globals.count] + " v" + Globals.version[Globals.count], SingleName = Globals.name[Globals.count], Package = Globals.package[Globals.count], Link = Globals.link[Globals.count], Version = Globals.version[Globals.count] });
                                }
                            }
                        }
                    }
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
