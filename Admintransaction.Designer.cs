namespace StartPage
{
    partial class Admintransaction
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
            this.dataGridViewadt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewadt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewadt
            // 
            this.dataGridViewadt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewadt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewadt.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewadt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewadt.Location = new System.Drawing.Point(21, 216);
            this.dataGridViewadt.Name = "dataGridViewadt";
            this.dataGridViewadt.RowHeadersWidth = 51;
            this.dataGridViewadt.RowTemplate.Height = 24;
            this.dataGridViewadt.Size = new System.Drawing.Size(1237, 287);
            this.dataGridViewadt.TabIndex = 47;
            this.dataGridViewadt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewadt_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 37);
            this.label1.TabIndex = 48;
            this.label1.Text = "TRANSACTION HISTORY";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1160, 672);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 35);
            this.button2.TabIndex = 50;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admintransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1281, 719);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewadt);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Admintransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "cart";
            this.Load += new System.EventHandler(this.Admintransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewadt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewadt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}