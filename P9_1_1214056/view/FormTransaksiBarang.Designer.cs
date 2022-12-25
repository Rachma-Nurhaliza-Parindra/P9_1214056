namespace P9_1_1214056.view
{
    partial class FormTransaksiBarang
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
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.DataTransaksi = new System.Windows.Forms.DataGridView();
            this.GBTombol = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHargaBarang = new System.Windows.Forms.TextBox();
            this.cbIdBarang = new System.Windows.Forms.ComboBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).BeginInit();
            this.GBTombol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GB2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.DataTransaksi);
            this.GB1.Location = new System.Drawing.Point(8, 1);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(785, 200);
            this.GB1.TabIndex = 4;
            this.GB1.TabStop = false;
            this.GB1.Text = "Table Data Barang";
            // 
            // DataTransaksi
            // 
            this.DataTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksi.Location = new System.Drawing.Point(6, 19);
            this.DataTransaksi.Name = "DataTransaksi";
            this.DataTransaksi.Size = new System.Drawing.Size(773, 175);
            this.DataTransaksi.TabIndex = 0;
            this.DataTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksi_CellClick);
            // 
            // GBTombol
            // 
            this.GBTombol.Controls.Add(this.btnHapus);
            this.GBTombol.Controls.Add(this.btnUbah);
            this.GBTombol.Controls.Add(this.btnSimpan);
            this.GBTombol.Controls.Add(this.btnRefresh);
            this.GBTombol.Location = new System.Drawing.Point(539, 284);
            this.GBTombol.Name = "GBTombol";
            this.GBTombol.Size = new System.Drawing.Size(250, 150);
            this.GBTombol.TabIndex = 13;
            this.GBTombol.TabStop = false;
            this.GBTombol.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(22, 121);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(200, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(22, 91);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(200, 23);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(22, 56);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(200, 23);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(22, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(546, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian ";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(63, 27);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(170, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // GB2
            // 
            this.GB2.Controls.Add(this.label6);
            this.GB2.Controls.Add(this.label5);
            this.GB2.Controls.Add(this.tbQuantity);
            this.GB2.Controls.Add(this.tbTotal);
            this.GB2.Controls.Add(this.groupBox2);
            this.GB2.Controls.Add(this.label2);
            this.GB2.Controls.Add(this.label3);
            this.GB2.Location = new System.Drawing.Point(10, 208);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(525, 198);
            this.GB2.TabIndex = 14;
            this.GB2.TabStop = false;
            this.GB2.Text = "Form Input Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rp";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(81, 128);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(197, 20);
            this.tbQuantity.TabIndex = 10;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(78, 164);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(198, 20);
            this.tbTotal.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbHargaBarang);
            this.groupBox2.Controls.Add(this.cbIdBarang);
            this.groupBox2.Controls.Add(this.tbNamaBarang);
            this.groupBox2.Location = new System.Drawing.Point(72, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nama Barang";
            // 
            // tbHargaBarang
            // 
            this.tbHargaBarang.Location = new System.Drawing.Point(246, 68);
            this.tbHargaBarang.Name = "tbHargaBarang";
            this.tbHargaBarang.Size = new System.Drawing.Size(198, 20);
            this.tbHargaBarang.TabIndex = 7;
            // 
            // cbIdBarang
            // 
            this.cbIdBarang.FormattingEnabled = true;
            this.cbIdBarang.Location = new System.Drawing.Point(6, 16);
            this.cbIdBarang.Name = "cbIdBarang";
            this.cbIdBarang.Size = new System.Drawing.Size(193, 21);
            this.cbIdBarang.TabIndex = 8;
            this.cbIdBarang.SelectedIndexChanged += new System.EventHandler(this.cbIdBarang_SelectedIndexChanged);
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(6, 65);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(200, 20);
            this.tbNamaBarang.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.GB2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBTombol);
            this.Controls.Add(this.GB1);
            this.Name = "FormTransaksiBarang";
            this.Text = "Form Transaksi Barang";
            this.Load += new System.EventHandler(this.FormTransaksiBarang_Load);
            this.GB1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).EndInit();
            this.GBTombol.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB2.ResumeLayout(false);
            this.GB2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.DataGridView DataTransaksi;
        private System.Windows.Forms.GroupBox GBTombol;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHargaBarang;
        private System.Windows.Forms.ComboBox cbIdBarang;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbTotal;
    }
}