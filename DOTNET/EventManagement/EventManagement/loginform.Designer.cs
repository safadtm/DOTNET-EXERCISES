namespace EventManagement
{
    partial class loginform
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(291, 366);
            button1.Name = "button1";
            button1.Size = new Size(114, 36);
            button1.TabIndex = 0;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(492, 366);
            button2.Name = "button2";
            button2.Size = new Size(114, 36);
            button2.TabIndex = 1;
            button2.Text = "login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 89);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 170);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(382, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 34);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 458);
            label3.Name = "label3";
            label3.Size = new Size(216, 28);
            label3.TabIndex = 6;
            label3.Text = "Don't have an account?";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(382, 227);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 32);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(382, 273);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(142, 28);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "reset password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(457, 458);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(165, 28);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "create an account";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(931, 571);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "loginform";
            Text = "loginform";
            Load += loginform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}