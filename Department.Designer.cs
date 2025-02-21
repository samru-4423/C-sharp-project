namespace StartPage
{
    partial class FormDepartment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmbItemID = new System.Windows.Forms.ComboBox();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.cmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.cmbDepartmentID = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbserial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(562, 91);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Size = new System.Drawing.Size(595, 537);
            this.dataGridView2.TabIndex = 29;
            // 
            // cmbItemID
            // 
            this.cmbItemID.FormattingEnabled = true;
            this.cmbItemID.Items.AddRange(new object[] {
            "Laptop-HW001",
            "Desktop-HW002",
            "Monitor-HW003",
            "Keyboard-HW004",
            "Mouse-HW005",
            "Printer-HW006",
            "Router-HW007",
            "UPS-HW010",
            "Hard_Drive-ACC002",
            "USB_Flash_Drive-ACC003",
            "Webcam-ACC004",
            "Headphones-ACC005"});
            this.cmbItemID.Location = new System.Drawing.Point(236, 389);
            this.cmbItemID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItemID.Name = "cmbItemID";
            this.cmbItemID.Size = new System.Drawing.Size(305, 24);
            this.cmbItemID.TabIndex = 25;
            // 
            // cmbFloor
            // 
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Items.AddRange(new object[] {
            "Ground Floor",
            "1st Floor",
            "2nd Floor",
            "3rd Floor",
            "4th Floor",
            "5th Floor",
            "6th Floor"});
            this.cmbFloor.Location = new System.Drawing.Point(236, 289);
            this.cmbFloor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(305, 24);
            this.cmbFloor.TabIndex = 23;
            // 
            // cmbDepartmentName
            // 
            this.cmbDepartmentName.FormattingEnabled = true;
            this.cmbDepartmentName.Items.AddRange(new object[] {
            "IT Department",
            "HR Department",
            "Finance Department",
            "Marketing Department",
            "Logistics Department",
            "Research and Development (R&D) Department"});
            this.cmbDepartmentName.Location = new System.Drawing.Point(236, 197);
            this.cmbDepartmentName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartmentName.Name = "cmbDepartmentName";
            this.cmbDepartmentName.Size = new System.Drawing.Size(305, 24);
            this.cmbDepartmentName.TabIndex = 30;
            // 
            // cmbDepartmentID
            // 
            this.cmbDepartmentID.FormattingEnabled = true;
            this.cmbDepartmentID.Items.AddRange(new object[] {
            "22401-IT",
            "24510-HR",
            "35712-Finance",
            "64891-Marketing",
            "54921-Operations",
            "45632-Customer Service",
            "47456-Logistics",
            "47485-R & D"});
            this.cmbDepartmentID.Location = new System.Drawing.Point(236, 242);
            this.cmbDepartmentID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartmentID.Name = "cmbDepartmentID";
            this.cmbDepartmentID.Size = new System.Drawing.Size(305, 24);
            this.cmbDepartmentID.TabIndex = 33;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Accessories"});
            this.cmbCategory.Location = new System.Drawing.Point(236, 439);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(305, 24);
            this.cmbCategory.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(340, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 60);
            this.label1.TabIndex = 60;
            this.label1.Text = "Department Information";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(18, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 28);
            this.label2.TabIndex = 61;
            this.label2.Text = "Department name :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(17, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 28);
            this.label3.TabIndex = 62;
            this.label3.Text = "Department ID :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(18, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 28);
            this.label5.TabIndex = 64;
            this.label5.Text = "Item name :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(18, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 28);
            this.label6.TabIndex = 65;
            this.label6.Text = "Item ID :";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(17, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 28);
            this.label7.TabIndex = 66;
            this.label7.Text = "Item Category :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::StartPage.Properties.Resources.back1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(404, 511);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 72;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(236, 338);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(305, 22);
            this.tbItemName.TabIndex = 74;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(404, 571);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 38);
            this.button3.TabIndex = 76;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbserial
            // 
            this.tbserial.Location = new System.Drawing.Point(236, 151);
            this.tbserial.Multiline = true;
            this.tbserial.Name = "tbserial";
            this.tbserial.Size = new System.Drawing.Size(305, 26);
            this.tbserial.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(17, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 28);
            this.label4.TabIndex = 63;
            this.label4.Text = "Floor :";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(18, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 28);
            this.label8.TabIndex = 78;
            this.label8.Text = "Serial :";
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::StartPage.Properties.Resources.department;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 699);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbserial);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbDepartmentID);
            this.Controls.Add(this.cmbDepartmentName);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmbItemID);
            this.Controls.Add(this.cmbFloor);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(400, 150);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Department Information";
            this.Load += new System.EventHandler(this.FormDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbItemID;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.ComboBox cmbDepartmentName;
        private System.Windows.Forms.ComboBox cmbDepartmentID;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbserial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}

