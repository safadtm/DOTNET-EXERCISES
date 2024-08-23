namespace EventManagement
{
    partial class applicationshow
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(175, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(576, 158);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 237);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 1;
            label1.Text = "Application ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 278);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 2;
            label2.Text = "Application Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(378, 326);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 36);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 334);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 4;
            label3.Text = "Department Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(378, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 34);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 392);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 6;
            label4.Text = "Events";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(378, 389);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(208, 36);
            comboBox2.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(378, 447);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 34);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 453);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 9;
            label5.Text = "Status";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(378, 517);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(334, 614);
            button1.Name = "button1";
            button1.Size = new Size(103, 57);
            button1.TabIndex = 11;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(483, 614);
            button2.Name = "button2";
            button2.Size = new Size(103, 57);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(88, 628);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 28);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // applicationshow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(985, 703);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "applicationshow";
            Text = "applicationshow";
            Load += applicationshow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}