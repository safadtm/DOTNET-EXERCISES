namespace EventManagement
{
    partial class departmentform
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
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            txtxDeptName = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 173);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "dept name";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(192, 297);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(52, 28);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(231, 76, 60);
            button1.Location = new Point(424, 292);
            button1.Name = "button1";
            button1.Size = new Size(106, 39);
            button1.TabIndex = 4;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtxDeptName
            // 
            txtxDeptName.Location = new Point(392, 173);
            txtxDeptName.Name = "txtxDeptName";
            txtxDeptName.Size = new Size(180, 34);
            txtxDeptName.TabIndex = 6;
            // 
            // departmentform
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 195, 199);
            ClientSize = new Size(922, 525);
            Controls.Add(txtxDeptName);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "departmentform";
            Text = "departmentform";
            Load += departmentform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox txtxDeptName;
    }
}