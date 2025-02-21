namespace StartPage
{
    partial class maintain
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbmainid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbbill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbissue = new System.Windows.Forms.ComboBox();
            this.cbresolution = new System.Windows.Forms.ComboBox();
            this.tbmamount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbmdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbstatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbitemcode = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAINTENANCE  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbmainid
            // 
            this.tbmainid.Location = new System.Drawing.Point(174, 103);
            this.tbmainid.Name = "tbmainid";
            this.tbmainid.Size = new System.Drawing.Size(231, 22);
            this.tbmainid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maintenance ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bill NO";
            // 
            // tbbill
            // 
            this.tbbill.Location = new System.Drawing.Point(174, 140);
            this.tbbill.Name = "tbbill";
            this.tbbill.Size = new System.Drawing.Size(231, 22);
            this.tbbill.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 7;
            // 
            // cbissue
            // 
            this.cbissue.FormattingEnabled = true;
            this.cbissue.Items.AddRange(new object[] {
            "Display burn",
            "Ram issue",
            "Hdd Problem",
            "Adapter problem",
            "antena problem",
            "sensor problem"});
            this.cbissue.Location = new System.Drawing.Point(447, 106);
            this.cbissue.Name = "cbissue";
            this.cbissue.Size = new System.Drawing.Size(117, 24);
            this.cbissue.TabIndex = 8;
            this.cbissue.Text = "Issues";
            this.cbissue.SelectedIndexChanged += new System.EventHandler(this.cbissue_SelectedIndexChanged);
            // 
            // cbresolution
            // 
            this.cbresolution.FormattingEnabled = true;
            this.cbresolution.Items.AddRange(new object[] {
            "Display change",
            "Ram change",
            "Hdd repaire",
            "Adapter change",
            "antena change",
            "change"});
            this.cbresolution.Location = new System.Drawing.Point(447, 146);
            this.cbresolution.Name = "cbresolution";
            this.cbresolution.Size = new System.Drawing.Size(124, 24);
            this.cbresolution.TabIndex = 9;
            this.cbresolution.Text = "Resolution";
            this.cbresolution.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tbmamount
            // 
            this.tbmamount.Location = new System.Drawing.Point(174, 270);
            this.tbmamount.Name = "tbmamount";
            this.tbmamount.Size = new System.Drawing.Size(231, 22);
            this.tbmamount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Amount";
            // 
            // tbmdate
            // 
            this.tbmdate.Location = new System.Drawing.Point(174, 313);
            this.tbmdate.Name = "tbmdate";
            this.tbmdate.Size = new System.Drawing.Size(231, 22);
            this.tbmdate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "DATE";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(26, 390);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(972, 257);
            this.dataGridViewMain.TabIndex = 48;
            this.dataGridViewMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Location = new System.Drawing.Point(462, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 49;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.Location = new System.Drawing.Point(568, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 50;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 81);
            this.panel1.TabIndex = 51;
            // 
            // tbstatus
            // 
            this.tbstatus.Location = new System.Drawing.Point(174, 232);
            this.tbstatus.Name = "tbstatus";
            this.tbstatus.Size = new System.Drawing.Size(231, 22);
            this.tbstatus.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Status";
            // 
            // cbitemcode
            // 
            this.cbitemcode.FormattingEnabled = true;
            this.cbitemcode.Items.AddRange(new object[] {
            "Laptop - HW001",
            "Desktop - HW002",
            "Monitor - HW003",
            "Keyboard - HW004",
            "Mouse - HW005",
            "Printer - HW006",
            "Router - HW007",
            "UPS (Uninterruptible Power Supply) - HW010",
            "Power Adapter - ACC001",
            "External Hard Drive - ACC002",
            "USB Flash Drive - ACC003",
            "Webcam - ACC004",
            "Headphones - ACC005"});
            this.cbitemcode.Location = new System.Drawing.Point(174, 183);
            this.cbitemcode.Name = "cbitemcode";
            this.cbitemcode.Size = new System.Drawing.Size(231, 24);
            this.cbitemcode.TabIndex = 54;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::StartPage.Properties.Resources.back1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(26, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // maintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1022, 659);
            this.Controls.Add(this.cbitemcode);
            this.Controls.Add(this.tbstatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.tbmdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbmamount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbresolution);
            this.Controls.Add(this.cbissue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbbill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbmainid);
            this.Name = "maintain";
            this.Text = "maintain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbmainid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbbill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbissue;
        private System.Windows.Forms.ComboBox cbresolution;
        private System.Windows.Forms.TextBox tbmamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbmdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbstatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbitemcode;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}