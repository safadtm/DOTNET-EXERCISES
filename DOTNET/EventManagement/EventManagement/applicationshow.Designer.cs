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
            cmbDept = new ComboBox();
            label3 = new Label();
            txtAplnName = new TextBox();
            label4 = new Label();
            cmbEvents = new ComboBox();
            txtStatus = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            txtAppId = new TextBox();
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
            // cmbDept
            // 
            cmbDept.FormattingEnabled = true;
            cmbDept.Location = new Point(378, 326);
            cmbDept.Name = "cmbDept";
            cmbDept.Size = new Size(208, 36);
            cmbDept.TabIndex = 3;
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
            // txtAplnName
            // 
            txtAplnName.Location = new Point(378, 277);
            txtAplnName.Name = "txtAplnName";
            txtAplnName.Size = new Size(208, 34);
            txtAplnName.TabIndex = 5;
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
            // cmbEvents
            // 
            cmbEvents.FormattingEnabled = true;
            cmbEvents.Location = new Point(378, 389);
            cmbEvents.Name = "cmbEvents";
            cmbEvents.Size = new Size(208, 36);
            cmbEvents.TabIndex = 7;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(378, 447);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(208, 34);
            txtStatus.TabIndex = 8;
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
            // txtAppId
            // 
            txtAppId.Location = new Point(378, 231);
            txtAppId.Name = "txtAppId";
            txtAppId.Size = new Size(208, 34);
            txtAppId.TabIndex = 14;
            // 
            // applicationshow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(985, 703);
            Controls.Add(txtAppId);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(txtStatus);
            Controls.Add(cmbEvents);
            Controls.Add(label4);
            Controls.Add(txtAplnName);
            Controls.Add(label3);
            Controls.Add(cmbDept);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
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
        private ComboBox cmbDept;
        private Label label3;
        private TextBox txtAplnName;
        private Label label4;
        private ComboBox cmbEvents;
        private TextBox txtStatus;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private TextBox txtAppId;
    }
}