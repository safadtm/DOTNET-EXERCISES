namespace EventManagement
{
    partial class userform
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
            myApplicationToolStripMenuItem = new ToolStripMenuItem();
            showApplicationToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // myApplicationToolStripMenuItem
            // 
            myApplicationToolStripMenuItem.Name = "myApplicationToolStripMenuItem";
            myApplicationToolStripMenuItem.Size = new Size(160, 32);
            myApplicationToolStripMenuItem.Text = "My Application";
            myApplicationToolStripMenuItem.Click += myApplicationToolStripMenuItem_Click;
            // 
            // showApplicationToolStripMenuItem
            // 
            showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem";
            showApplicationToolStripMenuItem.Size = new Size(180, 32);
            showApplicationToolStripMenuItem.Text = "Show Application";
            showApplicationToolStripMenuItem.Click += showApplicationToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(79, 32);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { myApplicationToolStripMenuItem, showApplicationToolStripMenuItem, homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 36);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "My Application";
            // 
            // userform
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "userform";
            Text = "userform";
            Load += userform_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem myApplicationToolStripMenuItem;
        private ToolStripMenuItem showApplicationToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}