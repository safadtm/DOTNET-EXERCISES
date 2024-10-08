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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            cmbDept = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 57);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 1;
            label2.Text = "Application name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 121);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 2;
            label3.Text = "Department name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 200);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 3;
            label4.Text = "Events";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 283);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 4;
            label5.Text = "Date";
            // 
            // txtName
            // 
            txtName.Location = new Point(385, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 34);
            txtName.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(397, 196);
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
            checkBox2.Location = new Point(500, 196);
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
            checkBox3.Location = new Point(607, 196);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(88, 32);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Dance";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(385, 277);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 11;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(147, 386);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 28);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(231, 76, 60);
            button1.Location = new Point(458, 379);
            button1.Name = "button1";
            button1.Size = new Size(107, 42);
            button1.TabIndex = 13;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbDept
            // 
            cmbDept.FormattingEnabled = true;
            cmbDept.Location = new Point(385, 118);
            cmbDept.Name = "cmbDept";
            cmbDept.Size = new Size(264, 36);
            cmbDept.TabIndex = 14;
            // 
            // applicationform
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 195, 199);
            ClientSize = new Size(929, 588);
            Controls.Add(cmbDept);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "applicationform";
            Text = "applicationform";
            Load += applicationform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private DateTimePicker dateTimePicker1;
        private LinkLabel linkLabel1;
        private Button button1;
        private ComboBox cmbDept;
    }
}