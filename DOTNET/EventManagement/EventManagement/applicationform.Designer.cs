namespace EventManagement
{
    partial class applicationform
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 51);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 0;
            label1.Text = "Application ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 122);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 1;
            label2.Text = "Application name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 186);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 2;
            label3.Text = "Department name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 265);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 3;
            label4.Text = "Events";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 348);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 4;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 426);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 5;
            label6.Text = "Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 34);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(338, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 34);
            textBox2.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(350, 261);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 32);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Food";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(453, 261);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(85, 32);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Music";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(560, 261);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(88, 32);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Dance";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(338, 342);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 11;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(103, 514);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 28);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(414, 507);
            button1.Name = "button1";
            button1.Size = new Size(107, 42);
            button1.TabIndex = 13;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(338, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 36);
            comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(338, 418);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(264, 36);
            comboBox2.TabIndex = 15;
            // 
            // applicationform
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(929, 588);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "applicationform";
            Text = "applicationform";
            Load += applicationform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private DateTimePicker dateTimePicker1;
        private LinkLabel linkLabel1;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}