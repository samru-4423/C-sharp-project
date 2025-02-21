namespace StartPage
{
    partial class TRANSACTION
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tcardno = new System.Windows.Forms.TextBox();
            this.cmbpayment = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewtrans = new System.Windows.Forms.DataGridView();
            this.tproquantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tproprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tprobill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tproname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcuscon = new System.Windows.Forms.TextBox();
            this.tcusname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbempid = new System.Windows.Forms.TextBox();
            this.tbempname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttpri = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtrans)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1125, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 22);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1085, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Date";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "card Number";
            // 
            // tcardno
            // 
            this.tcardno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tcardno.Location = new System.Drawing.Point(292, 4);
            this.tcardno.Name = "tcardno";
            this.tcardno.Size = new System.Drawing.Size(164, 22);
            this.tcardno.TabIndex = 51;
            // 
            // cmbpayment
            // 
            this.cmbpayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbpayment.FormattingEnabled = true;
            this.cmbpayment.Items.AddRange(new object[] {
            "Bkash",
            "Nagod",
            "Upay",
            "Card"});
            this.cmbpayment.Location = new System.Drawing.Point(7, 7);
            this.cmbpayment.Name = "cmbpayment";
            this.cmbpayment.Size = new System.Drawing.Size(129, 24);
            this.cmbpayment.TabIndex = 50;
            this.cmbpayment.Text = "PAYMENT";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1215, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 25);
            this.button3.TabIndex = 49;
            this.button3.Text = "Trans His";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 25);
            this.button2.TabIndex = 48;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 25);
            this.button1.TabIndex = 47;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewtrans
            // 
            this.dataGridViewtrans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewtrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewtrans.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtrans.Location = new System.Drawing.Point(12, 283);
            this.dataGridViewtrans.Name = "dataGridViewtrans";
            this.dataGridViewtrans.RowHeadersWidth = 51;
            this.dataGridViewtrans.RowTemplate.Height = 24;
            this.dataGridViewtrans.Size = new System.Drawing.Size(1325, 228);
            this.dataGridViewtrans.TabIndex = 46;
            this.dataGridViewtrans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtrans_CellContentClick);
            // 
            // tproquantity
            // 
            this.tproquantity.Location = new System.Drawing.Point(730, 209);
            this.tproquantity.Name = "tproquantity";
            this.tproquantity.Size = new System.Drawing.Size(99, 22);
            this.tproquantity.TabIndex = 43;
            this.tproquantity.TextChanged += new System.EventHandler(this.tproquantity_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(669, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Quantity";
            // 
            // tproprice
            // 
            this.tproprice.Location = new System.Drawing.Point(564, 209);
            this.tproprice.Name = "tproprice";
            this.tproprice.Size = new System.Drawing.Size(89, 22);
            this.tproprice.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Price";
            // 
            // tprobill
            // 
            this.tprobill.Location = new System.Drawing.Point(354, 210);
            this.tprobill.Name = "tprobill";
            this.tprobill.Size = new System.Drawing.Size(150, 22);
            this.tprobill.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Bill No";
            // 
            // tproname
            // 
            this.tproname.Location = new System.Drawing.Point(121, 209);
            this.tproname.Name = "tproname";
            this.tproname.Size = new System.Drawing.Size(164, 22);
            this.tproname.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Product  Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Customer Contact";
            // 
            // tcuscon
            // 
            this.tcuscon.Location = new System.Drawing.Point(441, 14);
            this.tcuscon.Name = "tcuscon";
            this.tcuscon.Size = new System.Drawing.Size(164, 22);
            this.tcuscon.TabIndex = 34;
            // 
            // tcusname
            // 
            this.tcusname.Location = new System.Drawing.Point(123, 14);
            this.tcusname.Name = "tcusname";
            this.tcusname.Size = new System.Drawing.Size(164, 22);
            this.tcusname.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Customer Name";
            // 
            // tbempid
            // 
            this.tbempid.Location = new System.Drawing.Point(123, 33);
            this.tbempid.Name = "tbempid";
            this.tbempid.Size = new System.Drawing.Size(164, 22);
            this.tbempid.TabIndex = 31;
            // 
            // tbempname
            // 
            this.tbempname.Location = new System.Drawing.Point(123, 5);
            this.tbempname.Name = "tbempname";
            this.tbempname.Size = new System.Drawing.Size(164, 22);
            this.tbempname.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Employee Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Employee Name";
            // 
            // ttpri
            // 
            this.ttpri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ttpri.Location = new System.Drawing.Point(930, 209);
            this.ttpri.Name = "ttpri";
            this.ttpri.Size = new System.Drawing.Size(69, 22);
            this.ttpri.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(852, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 58;
            this.label13.Text = "Total Price";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(1228, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 32);
            this.button5.TabIndex = 60;
            this.button5.Text = "NEXT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(7, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 32);
            this.button6.TabIndex = 61;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tbempname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbempid);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 100);
            this.panel1.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.tcuscon);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tcusname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1325, 59);
            this.panel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cmbpayment);
            this.panel3.Controls.Add(this.tcardno);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(12, 561);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1325, 91);
            this.panel3.TabIndex = 64;
            // 
            // TRANSACTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1349, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ttpri);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewtrans);
            this.Controls.Add(this.tproquantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tproprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tprobill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tproname);
            this.Controls.Add(this.label5);
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TRANSACTION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtrans)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tcardno;
        private System.Windows.Forms.ComboBox cmbpayment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewtrans;
        private System.Windows.Forms.TextBox tproquantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tproprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tprobill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tproname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tcuscon;
        private System.Windows.Forms.TextBox tcusname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbempid;
        private System.Windows.Forms.TextBox tbempname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttpri;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

