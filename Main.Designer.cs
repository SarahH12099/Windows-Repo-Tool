namespace WindowsRepoTool
{
	// Token: 0x02000002 RID: 2
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000368A File Offset: 0x0000188A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000036AC File Offset: 0x000018AC
		private void InitializeComponent()
		{
            this.addRepoBtn = new System.Windows.Forms.Button();
            this.addRepoBox = new System.Windows.Forms.TextBox();
            this.repoListBox = new System.Windows.Forms.ListBox();
            this.clearAllReposBtn = new System.Windows.Forms.Button();
            this.clearSelectedRepoBtn = new System.Windows.Forms.Button();
            this.openSelectedRepoBtn = new System.Windows.Forms.Button();
            this.packagesListBox = new System.Windows.Forms.ListBox();
            this.downloadSelectedPackageBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.detailsBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.queueListBox = new System.Windows.Forms.ListBox();
            this.removeFromQueueBtn = new System.Windows.Forms.Button();
            this.removeAllFromQueueBtn = new System.Windows.Forms.Button();
            this.addToQueueBtn = new System.Windows.Forms.Button();
            this.addAllToQueueBtn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addRepoBtn
            // 
            this.addRepoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addRepoBtn.Location = new System.Drawing.Point(12, 312);
            this.addRepoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addRepoBtn.Name = "addRepoBtn";
            this.addRepoBtn.Size = new System.Drawing.Size(187, 24);
            this.addRepoBtn.TabIndex = 0;
            this.addRepoBtn.Text = "Add Repo";
            this.addRepoBtn.UseVisualStyleBackColor = true;
            this.addRepoBtn.Click += new System.EventHandler(this.addRepoBtn_Click);
            // 
            // addRepoBox
            // 
            this.addRepoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addRepoBox.Location = new System.Drawing.Point(12, 286);
            this.addRepoBox.Margin = new System.Windows.Forms.Padding(2);
            this.addRepoBox.Name = "addRepoBox";
            this.addRepoBox.Size = new System.Drawing.Size(187, 20);
            this.addRepoBox.TabIndex = 1;
            // 
            // repoListBox
            // 
            this.repoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.repoListBox.FormattingEnabled = true;
            this.repoListBox.Location = new System.Drawing.Point(12, 10);
            this.repoListBox.Margin = new System.Windows.Forms.Padding(2);
            this.repoListBox.Name = "repoListBox";
            this.repoListBox.Size = new System.Drawing.Size(187, 264);
            this.repoListBox.TabIndex = 2;
            // 
            // clearAllReposBtn
            // 
            this.clearAllReposBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearAllReposBtn.Location = new System.Drawing.Point(11, 396);
            this.clearAllReposBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearAllReposBtn.Name = "clearAllReposBtn";
            this.clearAllReposBtn.Size = new System.Drawing.Size(188, 24);
            this.clearAllReposBtn.TabIndex = 3;
            this.clearAllReposBtn.Text = "Remove All Repos";
            this.clearAllReposBtn.UseVisualStyleBackColor = true;
            this.clearAllReposBtn.Click += new System.EventHandler(this.clearAllReposBtn_Click);
            // 
            // clearSelectedRepoBtn
            // 
            this.clearSelectedRepoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearSelectedRepoBtn.Location = new System.Drawing.Point(11, 368);
            this.clearSelectedRepoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearSelectedRepoBtn.Name = "clearSelectedRepoBtn";
            this.clearSelectedRepoBtn.Size = new System.Drawing.Size(188, 24);
            this.clearSelectedRepoBtn.TabIndex = 4;
            this.clearSelectedRepoBtn.Text = "Remove Selected Repo";
            this.clearSelectedRepoBtn.UseVisualStyleBackColor = true;
            this.clearSelectedRepoBtn.Click += new System.EventHandler(this.clearSelectedRepoBtn_Click);
            // 
            // openSelectedRepoBtn
            // 
            this.openSelectedRepoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openSelectedRepoBtn.Location = new System.Drawing.Point(11, 340);
            this.openSelectedRepoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.openSelectedRepoBtn.Name = "openSelectedRepoBtn";
            this.openSelectedRepoBtn.Size = new System.Drawing.Size(188, 24);
            this.openSelectedRepoBtn.TabIndex = 5;
            this.openSelectedRepoBtn.Text = "Open Selected Repo";
            this.openSelectedRepoBtn.UseVisualStyleBackColor = true;
            this.openSelectedRepoBtn.Click += new System.EventHandler(this.openSelectedRepoBtn_Click);
            // 
            // packagesListBox
            // 
            this.packagesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packagesListBox.FormattingEnabled = true;
            this.packagesListBox.Location = new System.Drawing.Point(204, 10);
            this.packagesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.packagesListBox.Name = "packagesListBox";
            this.packagesListBox.Size = new System.Drawing.Size(425, 238);
            this.packagesListBox.TabIndex = 6;
            this.packagesListBox.SelectedIndexChanged += new System.EventHandler(this.packagesListBox_SelectedIndexChanged);
            // 
            // downloadSelectedPackageBtn
            // 
            this.downloadSelectedPackageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadSelectedPackageBtn.Location = new System.Drawing.Point(633, 394);
            this.downloadSelectedPackageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.downloadSelectedPackageBtn.Name = "downloadSelectedPackageBtn";
            this.downloadSelectedPackageBtn.Size = new System.Drawing.Size(200, 24);
            this.downloadSelectedPackageBtn.TabIndex = 7;
            this.downloadSelectedPackageBtn.Text = "Download Selected Packages";
            this.downloadSelectedPackageBtn.UseVisualStyleBackColor = true;
            this.downloadSelectedPackageBtn.Click += new System.EventHandler(this.downloadSelectedPackageBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(203, 398);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(193, 20);
            this.searchBox.TabIndex = 8;
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // detailsBox
            // 
            this.detailsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsBox.Location = new System.Drawing.Point(203, 258);
            this.detailsBox.Margin = new System.Windows.Forms.Padding(2);
            this.detailsBox.Multiline = true;
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.ReadOnly = true;
            this.detailsBox.ShortcutsEnabled = false;
            this.detailsBox.Size = new System.Drawing.Size(424, 134);
            this.detailsBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(400, 396);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(21, 24);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // queueListBox
            // 
            this.queueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queueListBox.FormattingEnabled = true;
            this.queueListBox.Location = new System.Drawing.Point(633, 12);
            this.queueListBox.Name = "queueListBox";
            this.queueListBox.Size = new System.Drawing.Size(200, 316);
            this.queueListBox.TabIndex = 14;
            // 
            // removeFromQueueBtn
            // 
            this.removeFromQueueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeFromQueueBtn.Location = new System.Drawing.Point(633, 366);
            this.removeFromQueueBtn.Name = "removeFromQueueBtn";
            this.removeFromQueueBtn.Size = new System.Drawing.Size(200, 23);
            this.removeFromQueueBtn.TabIndex = 15;
            this.removeFromQueueBtn.Text = "Remove Selected Package";
            this.removeFromQueueBtn.UseVisualStyleBackColor = true;
            this.removeFromQueueBtn.Click += new System.EventHandler(this.removeFromQueueBtn_Click);
            // 
            // removeAllFromQueueBtn
            // 
            this.removeAllFromQueueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeAllFromQueueBtn.Location = new System.Drawing.Point(633, 337);
            this.removeAllFromQueueBtn.Name = "removeAllFromQueueBtn";
            this.removeAllFromQueueBtn.Size = new System.Drawing.Size(200, 23);
            this.removeAllFromQueueBtn.TabIndex = 16;
            this.removeAllFromQueueBtn.Text = "Remove All Packages";
            this.removeAllFromQueueBtn.UseVisualStyleBackColor = true;
            this.removeAllFromQueueBtn.Click += new System.EventHandler(this.removeAllFromQueueBtn_Click);
            // 
            // addToQueueBtn
            // 
            this.addToQueueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addToQueueBtn.Location = new System.Drawing.Point(532, 396);
            this.addToQueueBtn.Name = "addToQueueBtn";
            this.addToQueueBtn.Size = new System.Drawing.Size(96, 23);
            this.addToQueueBtn.TabIndex = 17;
            this.addToQueueBtn.Text = "Add to queue";
            this.addToQueueBtn.UseVisualStyleBackColor = true;
            this.addToQueueBtn.Click += new System.EventHandler(this.addToQueueBtn_Click);
            // 
            // addAllToQueueBtn
            // 
            this.addAllToQueueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAllToQueueBtn.Location = new System.Drawing.Point(426, 396);
            this.addAllToQueueBtn.Name = "addAllToQueueBtn";
            this.addAllToQueueBtn.Size = new System.Drawing.Size(100, 23);
            this.addAllToQueueBtn.TabIndex = 18;
            this.addAllToQueueBtn.Text = "Add all to queue";
            this.addAllToQueueBtn.UseVisualStyleBackColor = true;
            this.addAllToQueueBtn.Click += new System.EventHandler(this.addAllToQueueBtn_Click);
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Location = new System.Drawing.Point(12, 425);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(821, 150);
            this.logBox.TabIndex = 19;
            this.logBox.Text = "Log";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 587);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.addAllToQueueBtn);
            this.Controls.Add(this.addToQueueBtn);
            this.Controls.Add(this.removeAllFromQueueBtn);
            this.Controls.Add(this.removeFromQueueBtn);
            this.Controls.Add(this.queueListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.downloadSelectedPackageBtn);
            this.Controls.Add(this.packagesListBox);
            this.Controls.Add(this.openSelectedRepoBtn);
            this.Controls.Add(this.clearSelectedRepoBtn);
            this.Controls.Add(this.clearAllReposBtn);
            this.Controls.Add(this.repoListBox);
            this.Controls.Add(this.addRepoBox);
            this.Controls.Add(this.addRepoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Windows Repo Tool v2.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Button addRepoBtn;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.TextBox addRepoBox;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.ListBox repoListBox;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button clearAllReposBtn;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Button clearSelectedRepoBtn;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button openSelectedRepoBtn;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.ListBox packagesListBox;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Button downloadSelectedPackageBtn;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.TextBox searchBox;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.TextBox detailsBox;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox queueListBox;
        private System.Windows.Forms.Button removeFromQueueBtn;
        private System.Windows.Forms.Button removeAllFromQueueBtn;
        private System.Windows.Forms.Button addToQueueBtn;
        private System.Windows.Forms.Button addAllToQueueBtn;
        private System.Windows.Forms.TextBox logBox;
    }
}
