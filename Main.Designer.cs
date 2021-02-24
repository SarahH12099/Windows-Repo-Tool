
namespace WindowsRepoTool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.SuspendLayout();
            // 
            // addRepoBtn
            // 
            this.addRepoBtn.Location = new System.Drawing.Point(12, 410);
            this.addRepoBtn.Name = "addRepoBtn";
            this.addRepoBtn.Size = new System.Drawing.Size(181, 29);
            this.addRepoBtn.TabIndex = 0;
            this.addRepoBtn.Text = "Add Repo";
            this.addRepoBtn.UseVisualStyleBackColor = true;
            this.addRepoBtn.Click += new System.EventHandler(this.addRepoBtn_Click);
            // 
            // addRepoBox
            // 
            this.addRepoBox.Location = new System.Drawing.Point(12, 382);
            this.addRepoBox.Name = "addRepoBox";
            this.addRepoBox.Size = new System.Drawing.Size(181, 22);
            this.addRepoBox.TabIndex = 1;
            // 
            // repoListBox
            // 
            this.repoListBox.FormattingEnabled = true;
            this.repoListBox.ItemHeight = 16;
            this.repoListBox.Location = new System.Drawing.Point(12, 12);
            this.repoListBox.Name = "repoListBox";
            this.repoListBox.Size = new System.Drawing.Size(181, 356);
            this.repoListBox.TabIndex = 2;
            // 
            // clearAllReposBtn
            // 
            this.clearAllReposBtn.Location = new System.Drawing.Point(12, 515);
            this.clearAllReposBtn.Name = "clearAllReposBtn";
            this.clearAllReposBtn.Size = new System.Drawing.Size(181, 29);
            this.clearAllReposBtn.TabIndex = 3;
            this.clearAllReposBtn.Text = "Clear All Repos";
            this.clearAllReposBtn.UseVisualStyleBackColor = true;
            this.clearAllReposBtn.Click += new System.EventHandler(this.clearAllReposBtn_Click);
            // 
            // clearSelectedRepoBtn
            // 
            this.clearSelectedRepoBtn.Location = new System.Drawing.Point(12, 480);
            this.clearSelectedRepoBtn.Name = "clearSelectedRepoBtn";
            this.clearSelectedRepoBtn.Size = new System.Drawing.Size(181, 29);
            this.clearSelectedRepoBtn.TabIndex = 4;
            this.clearSelectedRepoBtn.Text = "Clear Selected Repo";
            this.clearSelectedRepoBtn.UseVisualStyleBackColor = true;
            this.clearSelectedRepoBtn.Click += new System.EventHandler(this.clearSelectedRepoBtn_Click);
            // 
            // openSelectedRepoBtn
            // 
            this.openSelectedRepoBtn.Location = new System.Drawing.Point(12, 445);
            this.openSelectedRepoBtn.Name = "openSelectedRepoBtn";
            this.openSelectedRepoBtn.Size = new System.Drawing.Size(181, 29);
            this.openSelectedRepoBtn.TabIndex = 5;
            this.openSelectedRepoBtn.Text = "Open Selected Repo";
            this.openSelectedRepoBtn.UseVisualStyleBackColor = true;
            this.openSelectedRepoBtn.Click += new System.EventHandler(this.openSelectedRepoBtn_Click);
            // 
            // packagesListBox
            // 
            this.packagesListBox.FormattingEnabled = true;
            this.packagesListBox.ItemHeight = 16;
            this.packagesListBox.Location = new System.Drawing.Point(227, 12);
            this.packagesListBox.Name = "packagesListBox";
            this.packagesListBox.Size = new System.Drawing.Size(561, 372);
            this.packagesListBox.TabIndex = 6;
            this.packagesListBox.SelectedIndexChanged += new System.EventHandler(this.packagesListBox_SelectedIndexChanged);
            // 
            // downloadSelectedPackageBtn
            // 
            this.downloadSelectedPackageBtn.Location = new System.Drawing.Point(543, 515);
            this.downloadSelectedPackageBtn.Name = "downloadSelectedPackageBtn";
            this.downloadSelectedPackageBtn.Size = new System.Drawing.Size(245, 29);
            this.downloadSelectedPackageBtn.TabIndex = 7;
            this.downloadSelectedPackageBtn.Text = "Download Selected Package";
            this.downloadSelectedPackageBtn.UseVisualStyleBackColor = true;
            this.downloadSelectedPackageBtn.Click += new System.EventHandler(this.downloadSelectedPackageBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(227, 515);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(297, 22);
            this.searchBox.TabIndex = 8;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // detailsBox
            // 
            this.detailsBox.Location = new System.Drawing.Point(227, 390);
            this.detailsBox.Multiline = true;
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(561, 119);
            this.detailsBox.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
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
            this.Name = "Main";
            this.Text = "Windows Repo Tool v1.0.5 (Beta)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRepoBtn;
        private System.Windows.Forms.TextBox addRepoBox;
        private System.Windows.Forms.ListBox repoListBox;
        private System.Windows.Forms.Button clearAllReposBtn;
        private System.Windows.Forms.Button clearSelectedRepoBtn;
        private System.Windows.Forms.Button openSelectedRepoBtn;
        private System.Windows.Forms.ListBox packagesListBox;
        private System.Windows.Forms.Button downloadSelectedPackageBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox detailsBox;
    }
}

