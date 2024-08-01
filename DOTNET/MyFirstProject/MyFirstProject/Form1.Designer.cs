namespace MyFirstProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new TextBox();
            labelname = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            username.Location = new Point(12, 61);
            username.Name = "username";
            username.Size = new Size(776, 34);
            username.TabIndex = 0;
            // 
            // labelname
            // 
            labelname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelname.AutoSize = true;
            labelname.Location = new Point(12, 30);
            labelname.Name = "labelname";
            labelname.Size = new Size(155, 28);
            labelname.TabIndex = 1;
            labelname.Text = "Enter your name";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 351);
            button1.Name = "button1";
            button1.Size = new Size(776, 65);
            button1.TabIndex = 2;
            button1.Text = "Click Me";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelname);
            Controls.Add(username);
            Name = "Form1";
            Text = "My App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private Label labelname;
        private Button button1;
    }
}
