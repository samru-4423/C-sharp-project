namespace StartPage
{
    partial class EmployeeInfo
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cbposition = new System.Windows.Forms.ComboBox();
            this.cbdid = new System.Windows.Forms.ComboBox();
            this.cbdname = new System.Windows.Forms.ComboBox();
            this.tbename = new System.Windows.Forms.TextBox();
            this.tbecontact = new System.Windows.Forms.TextBox();
            this.tbeemail = new System.Windows.Forms.TextBox();
            this.tbeaddress = new System.Windows.Forms.TextBox();
            this.tbeid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbeuname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbepass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbesalary = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbjoindate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.IndianRed;
            this.btnSave.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Location = new System.Drawing.Point(437, 656);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 38);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Delete";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbposition
            // 
            this.cbposition.FormattingEnabled = true;
            this.cbposition.Items.AddRange(new object[] {
            "Software Engineer",
            "IT Support Specialist",
            "System Administrator",
            "Network Engineer",
            "Database Administrator",
            "Project Manager",
            "Business Analyst",
            "Quality Assurance Engineer",
            "HR Manager",
            "Accountant",
            "Marketing Executive",
            "Sales Representative"});
            this.cbposition.Location = new System.Drawing.Point(441, 372);
            this.cbposition.Margin = new System.Windows.Forms.Padding(4);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(439, 24);
            this.cbposition.TabIndex = 43;
            this.cbposition.SelectedIndexChanged += new System.EventHandler(this.cbposition_SelectedIndexChanged);
            // 
            // cbdid
            // 
            this.cbdid.FormattingEnabled = true;
            this.cbdid.Items.AddRange(new object[] {
            "22401 - IT",
            "24510 - HR",
            "35712 - Finance",
            "64891 - Marketing",
            "54921 - Operations",
            "45632 - Customer Service",
            "47456 - Logistics",
            "47485 - R & D"});
            this.cbdid.Location = new System.Drawing.Point(441, 236);
            this.cbdid.Margin = new System.Windows.Forms.Padding(4);
            this.cbdid.Name = "cbdid";
            this.cbdid.Size = new System.Drawing.Size(439, 24);
            this.cbdid.TabIndex = 42;
            // 
            // cbdname
            // 
            this.cbdname.FormattingEnabled = true;
            this.cbdname.Items.AddRange(new object[] {
            "Customer Service Department",
            "Finance Department",
            "HR Department",
            "IT Department",
            "Logistics Department",
            "Marketing Department",
            "Operations Department",
            "Research and Development (R&D) Department"});
            this.cbdname.Location = new System.Drawing.Point(441, 186);
            this.cbdname.Margin = new System.Windows.Forms.Padding(4);
            this.cbdname.Name = "cbdname";
            this.cbdname.Size = new System.Drawing.Size(439, 24);
            this.cbdname.Sorted = true;
            this.cbdname.TabIndex = 41;
            // 
            // tbename
            // 
            this.tbename.Location = new System.Drawing.Point(441, 88);
            this.tbename.Margin = new System.Windows.Forms.Padding(4);
            this.tbename.Multiline = true;
            this.tbename.Name = "tbename";
            this.tbename.Size = new System.Drawing.Size(439, 28);
            this.tbename.TabIndex = 50;
            // 
            // tbecontact
            // 
            this.tbecontact.Location = new System.Drawing.Point(441, 509);
            this.tbecontact.Margin = new System.Windows.Forms.Padding(4);
            this.tbecontact.Multiline = true;
            this.tbecontact.Name = "tbecontact";
            this.tbecontact.Size = new System.Drawing.Size(439, 28);
            this.tbecontact.TabIndex = 51;
            // 
            // tbeemail
            // 
            this.tbeemail.Location = new System.Drawing.Point(441, 461);
            this.tbeemail.Margin = new System.Windows.Forms.Padding(4);
            this.tbeemail.Multiline = true;
            this.tbeemail.Name = "tbeemail";
            this.tbeemail.Size = new System.Drawing.Size(439, 28);
            this.tbeemail.TabIndex = 55;
            // 
            // tbeaddress
            // 
            this.tbeaddress.Location = new System.Drawing.Point(441, 556);
            this.tbeaddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbeaddress.Multiline = true;
            this.tbeaddress.Name = "tbeaddress";
            this.tbeaddress.Size = new System.Drawing.Size(439, 28);
            this.tbeaddress.TabIndex = 56;
            // 
            // tbeid
            // 
            this.tbeid.Location = new System.Drawing.Point(441, 135);
            this.tbeid.Margin = new System.Windows.Forms.Padding(4);
            this.tbeid.Multiline = true;
            this.tbeid.Name = "tbeid";
            this.tbeid.Size = new System.Drawing.Size(439, 28);
            this.tbeid.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(347, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 60);
            this.label1.TabIndex = 59;
            this.label1.Text = "Employee Information";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(224, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 60;
            this.label2.Text = "Employee name :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(224, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Employee ID :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(224, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 28);
            this.label4.TabIndex = 62;
            this.label4.Text = "Department name :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(224, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 28);
            this.label5.TabIndex = 63;
            this.label5.Text = "Department ID :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(224, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 28);
            this.label6.TabIndex = 64;
            this.label6.Text = "Position :";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(224, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 28);
            this.label7.TabIndex = 65;
            this.label7.Text = "Contact no :";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(224, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 28);
            this.label8.TabIndex = 66;
            this.label8.Text = "Email :";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(224, 558);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 28);
            this.label9.TabIndex = 67;
            this.label9.Text = "Address :";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(224, 605);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 28);
            this.label10.TabIndex = 68;
            this.label10.Text = "Joining Date :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(751, 656);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 69;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(597, 656);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 38);
            this.button2.TabIndex = 71;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(224, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 28);
            this.label11.TabIndex = 73;
            this.label11.Text = "Username :";
            // 
            // tbeuname
            // 
            this.tbeuname.Location = new System.Drawing.Point(441, 279);
            this.tbeuname.Margin = new System.Windows.Forms.Padding(4);
            this.tbeuname.Multiline = true;
            this.tbeuname.Name = "tbeuname";
            this.tbeuname.Size = new System.Drawing.Size(439, 28);
            this.tbeuname.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(224, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 28);
            this.label12.TabIndex = 75;
            this.label12.Text = "Password :";
            // 
            // tbepass
            // 
            this.tbepass.Location = new System.Drawing.Point(441, 325);
            this.tbepass.Margin = new System.Windows.Forms.Padding(4);
            this.tbepass.Multiline = true;
            this.tbepass.Name = "tbepass";
            this.tbepass.PasswordChar = '*';
            this.tbepass.Size = new System.Drawing.Size(439, 28);
            this.tbepass.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Indigo;
            this.label13.Location = new System.Drawing.Point(224, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 28);
            this.label13.TabIndex = 77;
            this.label13.Text = "Salary :";
            // 
            // tbesalary
            // 
            this.tbesalary.Location = new System.Drawing.Point(441, 412);
            this.tbesalary.Margin = new System.Windows.Forms.Padding(4);
            this.tbesalary.Multiline = true;
            this.tbesalary.Name = "tbesalary";
            this.tbesalary.Size = new System.Drawing.Size(439, 28);
            this.tbesalary.TabIndex = 78;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(915, 656);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 38);
            this.button3.TabIndex = 79;
            this.button3.Text = "List";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbjoindate
            // 
            this.tbjoindate.Location = new System.Drawing.Point(437, 605);
            this.tbjoindate.Margin = new System.Windows.Forms.Padding(4);
            this.tbjoindate.Multiline = true;
            this.tbjoindate.Name = "tbjoindate";
            this.tbjoindate.Size = new System.Drawing.Size(439, 28);
            this.tbjoindate.TabIndex = 80;
            // 
            // EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StartPage.Properties.Resources.ss;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 707);
            this.Controls.Add(this.tbjoindate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbesalary);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbepass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbeuname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbeid);
            this.Controls.Add(this.tbeaddress);
            this.Controls.Add(this.tbeemail);
            this.Controls.Add(this.tbecontact);
            this.Controls.Add(this.tbename);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbposition);
            this.Controls.Add(this.cbdid);
            this.Controls.Add(this.cbdname);
            this.Location = new System.Drawing.Point(400, 150);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Employee Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbposition;
        private System.Windows.Forms.ComboBox cbdid;
        private System.Windows.Forms.ComboBox cbdname;
        private System.Windows.Forms.TextBox tbename;
        private System.Windows.Forms.TextBox tbecontact;
        private System.Windows.Forms.TextBox tbeemail;
        private System.Windows.Forms.TextBox tbeaddress;
        private System.Windows.Forms.TextBox tbeid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbeuname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbepass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbesalary;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbjoindate;
    }
}

