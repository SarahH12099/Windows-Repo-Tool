
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
            this.startWithWindowsOption = new System.Windows.Forms.CheckBox();
            this.showTrayIconOption = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // startWithWindowsOption
            // 
            this.startWithWindowsOption.AutoSize = true;
            this.startWithWindowsOption.Location = new System.Drawing.Point(63, 45);
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
            this.showTrayIconOption.Location = new System.Drawing.Point(63, 73);
            this.showTrayIconOption.Name = "showTrayIconOption";
            this.showTrayIconOption.Size = new System.Drawing.Size(127, 21);
            this.showTrayIconOption.TabIndex = 1;
            this.showTrayIconOption.Text = "Show Tray Icon";
            this.showTrayIconOption.UseVisualStyleBackColor = true;
            this.showTrayIconOption.CheckedChanged += new System.EventHandler(this.showTrayIconOption_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showTrayIconOption);
            this.Controls.Add(this.startWithWindowsOption);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startWithWindowsOption;
        private System.Windows.Forms.CheckBox showTrayIconOption;
    }
}