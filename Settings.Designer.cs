
namespace WindowsRepoTool
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.startWithWindowsOption = new System.Windows.Forms.CheckBox();
            this.showTrayIconOption = new System.Windows.Forms.CheckBox();
            this.darkModeOption = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // startWithWindowsOption
            // 
            this.startWithWindowsOption.AutoSize = true;
            this.startWithWindowsOption.Location = new System.Drawing.Point(63, 37);
            this.startWithWindowsOption.Name = "startWithWindowsOption";
            this.startWithWindowsOption.Size = new System.Drawing.Size(152, 21);
            this.startWithWindowsOption.TabIndex = 0;
            this.startWithWindowsOption.Text = "Start With Windows";
            this.startWithWindowsOption.UseVisualStyleBackColor = true;
            this.startWithWindowsOption.CheckedChanged += new System.EventHandler(this.startWithWindowsOption_CheckedChanged);
            // 
            // showTrayIconOption
            // 
            this.showTrayIconOption.AutoSize = true;
            this.showTrayIconOption.Checked = true;
            this.showTrayIconOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showTrayIconOption.Location = new System.Drawing.Point(63, 64);
            this.showTrayIconOption.Name = "showTrayIconOption";
            this.showTrayIconOption.Size = new System.Drawing.Size(127, 21);
            this.showTrayIconOption.TabIndex = 1;
            this.showTrayIconOption.Text = "Show Tray Icon";
            this.showTrayIconOption.UseVisualStyleBackColor = true;
            this.showTrayIconOption.CheckedChanged += new System.EventHandler(this.showTrayIconOption_CheckedChanged);
            // 
            // darkModeOption
            // 
            this.darkModeOption.AutoSize = true;
            this.darkModeOption.Location = new System.Drawing.Point(63, 91);
            this.darkModeOption.Name = "darkModeOption";
            this.darkModeOption.Size = new System.Drawing.Size(99, 21);
            this.darkModeOption.TabIndex = 2;
            this.darkModeOption.Text = "Dark Mode";
            this.darkModeOption.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 148);
            this.Controls.Add(this.darkModeOption);
            this.Controls.Add(this.showTrayIconOption);
            this.Controls.Add(this.startWithWindowsOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startWithWindowsOption;
        private System.Windows.Forms.CheckBox showTrayIconOption;
        private System.Windows.Forms.CheckBox darkModeOption;
    }
}