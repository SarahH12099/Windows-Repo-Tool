using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WindowsRepoTool
{
	public partial class Main : Form
	{
		public Main()
		{
			this.InitializeComponent();
			this.addRepoBox.Text = "https://";
			this.searchBox.Text = "Search Packages";
			if (!Directory.Exists("Debs"))
			{
				Directory.CreateDirectory("Debs");
			}
			if (Directory.Exists("Packages"))
			{
				Directory.Delete("Packages", true);
			}
			if (File.Exists("Packages.bz2"))
			{
				File.Delete("Packages.bz2");
			}
			if (File.Exists("Packages.gz"))
			{
				File.Delete("Packages.gz");
			}
			if (File.Exists("Packages.txt"))
			{
				File.Delete("Packages.txt");
			}
			if (!File.Exists("log.txt"))
			{
				File.Create("log.txt").Close();
			}
			if (!File.Exists("Repos.txt"))
			{
				File.Create("Repos.txt").Close();
				return;
			}
			string[] lines = File.ReadAllLines("Repos.txt");
			ListBox.ObjectCollection items = this.repoListBox.Items;
			object[] items2 = lines;
			items.AddRange(items2);
		}
		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Directory.Exists("Packages"))
			{
				Directory.Delete("Packages", true);
			}
			if (File.Exists("Packages.bz2"))
			{
				File.Delete("Packages.bz2");
			}
			if (File.Exists("Packages.gz"))
			{
				File.Delete("Packages.gz");
			}
			if (File.Exists("Packages.txt"))
			{
				File.Delete("Packages.txt");
			}
		}
		private void addRepoBtn_Click(object sender, EventArgs e)
		{
			string repo = this.addRepoBox.Text.ToLower();
			string finalrepo;
			if (repo.EndsWith("/"))
			{
				finalrepo = repo;
			}
			else
			{
				finalrepo = repo + "/";
			}
			if (this.repoListBox.Items.Contains(finalrepo))
			{
				this.addRepoBox.Clear();
				this.addRepoBox.Text = "https://";
				string title = "Notice";
				MessageBox.Show("You Already Have This Repo Added", title);
				return;
			}
			if (this.addRepoBox.Text != "https://" & this.addRepoBox.Text != "http://" & this.addRepoBox.Text != string.Empty)
			{
				this.repoListBox.Items.Add(finalrepo);
				StreamWriter SaveFile = new StreamWriter("Repos.txt");
				foreach (object item in this.repoListBox.Items)
				{
					SaveFile.WriteLine(item.ToString());
				}
				SaveFile.Close();
				this.addRepoBox.Clear();
				this.addRepoBox.Text = "https://";
				return;
			}
			string title2 = "Notice";
			MessageBox.Show("No repo was entered", title2);
		}
		private void clearAllReposBtn_Click(object sender, EventArgs e)
		{
			string title = "Notice";
			string text = "Are you sure you want to clear all added repos?";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(text, title, buttons);
			if (result == DialogResult.Yes)
			{
				this.repoListBox.Items.Clear();
				StreamWriter SaveFile = new StreamWriter("Repos.txt");
				foreach (object item in this.repoListBox.Items)
				{
					SaveFile.WriteLine(item.ToString());
				}
				SaveFile.Close();
				string titlefinal = "Notice";
				MessageBox.Show("Cleared All Repos Successfully", titlefinal);
				return;
			}
		}
		private void clearSelectedRepoBtn_Click(object sender, EventArgs e)
		{
			if (this.repoListBox.SelectedItem == null)
			{
				string titlefinal = "Notice";
				MessageBox.Show("Please select a repo", titlefinal);
				return;
			}
			string title = "Notice";
			string text = "Are you sure you want to clear the selected repo?";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(text, title, buttons);
			if (result == DialogResult.Yes)
			{
				this.repoListBox.Items.Remove(this.repoListBox.SelectedItem);
				StreamWriter SaveFile = new StreamWriter("Repos.txt");
				foreach (object item in this.repoListBox.Items)
				{
					SaveFile.WriteLine(item.ToString());
				}
				SaveFile.Close();
				string titlefinal2 = "Notice";
				MessageBox.Show("Cleared The Selected Repo Successfully", titlefinal2);
				return;
			}
		}
		private void openSelectedRepoBtn_Click(object sender, EventArgs e)
		{
			if (this.repoListBox.SelectedItem == null)
			{
				string titlefinal = "Notice";
				MessageBox.Show("Please select a repo", titlefinal);
				return;
			}
			this.packagesListBox.Items.Clear();
			if (this.searchBox.Text != "Search Packages")
			{
				this.searchBox.Text = "Search Packages";
			}
			this.detailsBox.Clear();
			this.packagesListBox.Items.Add("Opening repo, please wait");
			Main.Globals.name.Clear();
			Main.Globals.version.Clear();
			Main.Globals.link.Clear();
			Main.Globals.details.Clear();
			Main.Globals.repo = this.repoListBox.SelectedItem.ToString();
			if (File.Exists("Packages.bz2"))
			{
				File.Delete("Packages.bz2");
			}
			if (File.Exists("Packages.gz"))
			{
				File.Delete("Packages.gz");
			}
			if (File.Exists("Packages.txt"))
			{
				File.Delete("Packages.txt");
			}
			if (Directory.Exists("Packages"))
			{
				Directory.Delete("Packages", true);
			}
			using (WebClient client = new WebClient())
			{
				try
				{
					client.Headers.Add("X-Machine", "iPhone8,1");
					client.Headers.Add("X-Unique-ID", "8843d7f92416211de9ebb963ff4ce28125932878");
					client.Headers.Add("X-Firmware", "13.1");
					client.Headers.Add("User-Agent", "Telesphoreo APT-HTTP/1.0.592");
					WebClient webClient = client;
					object selectedItem = this.repoListBox.SelectedItem;
					webClient.DownloadFile(((selectedItem != null) ? selectedItem.ToString() : null) + "Packages.bz2", "Packages.bz2");
				}
				catch (Exception)
				{
					try
					{
						client.Headers.Add("X-Machine", "iPhone8,1");
						client.Headers.Add("X-Unique-ID", "8843d7f92416211de9ebb963ff4ce28125932878");
						client.Headers.Add("X-Firmware", "13.1");
						client.Headers.Add("User-Agent", "Telesphoreo APT-HTTP/1.0.592");
						WebClient webClient2 = client;
						object selectedItem2 = this.repoListBox.SelectedItem;
						webClient2.DownloadFile(((selectedItem2 != null) ? selectedItem2.ToString() : null) + "dists/stable/main/binary-iphoneos-arm/Packages.bz2", "Packages.bz2");
					}
					catch (Exception)
					{
						try
						{
							client.Headers.Add("X-Machine", "iPhone8,1");
							client.Headers.Add("X-Unique-ID", "8843d7f92416211de9ebb963ff4ce28125932878");
							client.Headers.Add("X-Firmware", "13.1");
							client.Headers.Add("User-Agent", "Telesphoreo APT-HTTP/1.0.592");
							WebClient webClient3 = client;
							object selectedItem3 = this.repoListBox.SelectedItem;
							webClient3.DownloadFile(((selectedItem3 != null) ? selectedItem3.ToString() : null) + "Packages.gz", "Packages.gz");
						}
						catch (Exception ExThree)
						{
							string titlefinal2 = "Notice";
							string str = "Could not to connect to repo, are you connected to the internet and did you type the repo url correctly? \n\n";
							Exception ex = ExThree;
							MessageBox.Show(str + ((ex != null) ? ex.ToString() : null), titlefinal2);
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
					if (File.Exists("Packages.bz2"))
					{
						pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", "Packages.bz2", "Packages");
					}
					if (File.Exists("Packages.gz"))
					{
						pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", "Packages.gz", "Packages");
					}
					Process.Start(pro).WaitForExit();
				}
				catch (Exception ex2)
				{
					string titlefinal3 = "Notice";
					MessageBox.Show(ex2.ToString(), titlefinal3);
					return;
				}
				StreamReader reader2 = new StreamReader(File.OpenRead("Packages/Packages"));
				StreamWriter SaveFile = new StreamWriter("Packages.txt");
				string parse;
				while ((parse = reader2.ReadLine()) != null)
				{
					SaveFile.WriteLine(parse.ToString());
				}
				SaveFile.Close();
				reader2.Close();
				foreach (string line in File.ReadAllText("Packages.txt").Split(new string[]
				{
					"\r\n\r\n"
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					Main.Globals.details.Add(line);
					foreach (string pass in line.Split(new string[]
					{
						"\r\n"
					}, StringSplitOptions.RemoveEmptyEntries))
					{
						if (pass.StartsWith("Name"))
						{
							string name = pass.Substring(6, pass.Length - 6).ToString();
							Main.Globals.name.Add(name);
						}
						if (pass.StartsWith("Version"))
						{
							string version = pass.Substring(9, pass.Length - 9).ToString();
							Main.Globals.version.Add(version);
						}
						if (pass.StartsWith("Filename"))
						{
							string link = pass.Substring(10, pass.Length - 10).ToString();
							Main.Globals.link.Add(link);
						}
						if (pass.StartsWith("Package"))
						{
							string link2 = pass.Substring(9, pass.Length - 9).ToString();
							Main.Globals.package.Add(link2);
						}
					}
				}
				this.packagesListBox.Items.Clear();
				for (int i = 0; i < Main.Globals.name.Count; i++)
				{
					this.packagesListBox.Items.Add(new Main.ListItem
					{
						Name = Main.Globals.name[i] + " v" + Main.Globals.version[i],
						Link = Main.Globals.link[i],
						Details = Main.Globals.details[i],
						Package = Main.Globals.package[i],
						Version = Main.Globals.version[i]
					});
				}
				this.packagesListBox.Sorted = true;
			}
        }
		private void downloadSelectedPackageBtn_Click(object sender, EventArgs e)
		{
			if (this.queueListBox.Items == null)
			{
				string titlefinal = "Notice";
				MessageBox.Show("There are no packages in the queue", titlefinal);
				return;
			}
			List<string> logToWrite = new List<string>();
			foreach (ListItem package in queueListBox.Items)
            {
				string selectedPackageItem = ((Main.ListItem)package).Package + "_" + ((Main.ListItem)package).Version;
				string repo = Main.Globals.repo;
				string packageURL = ((Main.ListItem)package).Link;
				string downloadURL = repo + packageURL;
				logToWrite.Add("downloading " + selectedPackageItem + " from " + downloadURL);
				using (WebClient client = new WebClient())
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
						client.DownloadFile(downloadURL, "Debs/" + selectedPackageItem + ".deb");
						string toLog = package.Name + " successfully downloaded";
						logToWrite.Add(toLog);
						logBox.AppendText(toLog);
						logBox.AppendText(Environment.NewLine);
					}
					catch (Exception)
					{
						string toLog = package.Name + " failed to download (paid?)";
						logToWrite.Add(toLog);
						logBox.AppendText(toLog);
						logBox.AppendText(Environment.NewLine);
					}
				}
			}
			string titlefinal2 = "Notice";
			MessageBox.Show("Download complete, DEBs are located in the 'Debs' folder\nPlease check the log for any more details", titlefinal2);
			MessageBox.Show("The program will now restart", titlefinal2);
			StreamWriter SaveFile = new StreamWriter("log.txt");
			foreach (string s in logToWrite)
			{
				SaveFile.WriteLine(s);
			}
			SaveFile.Close();
			Application.Restart();
		}
		private void packagesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.detailsBox.Clear();
			this.detailsBox.ScrollBars = ScrollBars.Both;
			this.detailsBox.WordWrap = false;
			this.detailsBox.Text = ((Main.ListItem)this.packagesListBox.SelectedItem).Details;
		}
		private void searchBox_Enter(object sender, EventArgs e)
		{
			if (this.searchBox.Text == "Search Packages")
			{
				this.searchBox.Clear();
			}
		}
		private void searchBox_Leave(object sender, EventArgs e)
		{
			if (this.searchBox.Text == string.Empty)
			{
				this.searchBox.Text = "Search Packages";
			}
		}
		private void searchButton_Click(object sender, EventArgs e)
		{
			this.packagesListBox.Items.Clear();
			for (int i = 0; i < Main.Globals.name.Count; i++)
			{
				if (Main.Globals.name[i].StartsWith(this.searchBox.Text, StringComparison.CurrentCultureIgnoreCase))
				{
					this.packagesListBox.Items.Add(new Main.ListItem
					{
						Name = Main.Globals.name[i] + " v" + Main.Globals.version[i],
						Link = Main.Globals.link[i],
						Details = Main.Globals.details[i],
						Package = Main.Globals.package[i],
						Version = Main.Globals.version[i]
					});
				}
			}
			this.packagesListBox.Sorted = true;
		}
		public static class Globals
		{
			public static List<string> name = new List<string>();
			public static List<string> version = new List<string>();
			public static List<string> link = new List<string>();
			public static List<string> details = new List<string>();
			public static List<string> package = new List<string>();
			public static string repo = "";
		}
		public class ListItem
		{
			public string Name { get; set; }
			public string Link { get; set; }
			public string Details { get; set; }
			public string Package { get; set; }
			public string Version { get; set; }
			public override string ToString()
			{
				return this.Name;
			}
		}

        private void Main_Load(object sender, EventArgs e)
        {
			if (!File.Exists("7za.exe") || !File.Exists("7za.dll") || !File.Exists("7zxa.dll"))
			{
				MessageBox.Show("7za.exe or its required files were not found.", "Required files not found");
			}
		}

        private void addToQueueBtn_Click(object sender, EventArgs e)
        {
			if(packagesListBox.SelectedItem == null)
            {
				MessageBox.Show("Please select a package.", "Notice");
				return;
            }
			queueListBox.Items.Add(new ListItem
			{
				Name = ((ListItem)packagesListBox.SelectedItem).Name + " v" + ((ListItem)packagesListBox.SelectedItem).Version,
				Link = ((ListItem)packagesListBox.SelectedItem).Link,
				Details = ((ListItem)packagesListBox.SelectedItem).Details,
				Package = ((ListItem)packagesListBox.SelectedItem).Package,
				Version = ((ListItem)packagesListBox.SelectedItem).Version
			});
		}

        private void removeAllFromQueueBtn_Click(object sender, EventArgs e)
        {
			string title = "Notice";
			string text = "Are you sure that you want to clear the queue";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(text, title, buttons);
			if (result == DialogResult.Yes)
			{
				this.queueListBox.Items.Clear();
				string titlefinal = "Notice";
				MessageBox.Show("Cleared the queue.", titlefinal);
				return;
			}
		}

        private void removeFromQueueBtn_Click(object sender, EventArgs e)
        {
			if (this.queueListBox.SelectedItem == null)
			{
				string titlefinal = "Notice";
				MessageBox.Show("Please select a package", titlefinal);
				return;
			}
			string title = "Notice";
			string text = "Are you sure you want to remove the selected package from the queue?";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(text, title, buttons);
			if (result == DialogResult.Yes)
			{
				this.queueListBox.Items.Remove(this.queueListBox.SelectedItem);
				return;
			}
		}

        private void addAllToQueueBtn_Click(object sender, EventArgs e)
        {
			foreach(ListItem package in packagesListBox.Items)
            {
				queueListBox.Items.Add(new ListItem
				{
					Name = ((ListItem)package).Name + " v" + ((ListItem)package).Version,
					Link = ((ListItem)package).Link,
					Details = ((ListItem)package).Details,
					Package = ((ListItem)package).Package,
					Version = ((ListItem)package).Version
				});
			}
        }
    }
}
