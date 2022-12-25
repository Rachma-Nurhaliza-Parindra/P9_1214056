namespace P9_1_1214056.view
{
    partial class FormMasterBarang
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
            this.DataBarang = new System.Windows.Forms.DataGridView();
            this.GBTombol = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).BeginInit();
            this.GBTombol.SuspendLayout();
            this.GB2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.DataBarang);
            this.GB1.Location = new System.Drawing.Point(3, 3);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(785, 200);
            this.GB1.TabIndex = 3;
            this.GB1.TabStop = false;
            this.GB1.Text = "Table Data Barang";
            // 
            // DataBarang
            // 
            this.DataBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBarang.Location = new System.Drawing.Point(6, 19);
            this.DataBarang.Name = "DataBarang";
            this.DataBarang.Size = new System.Drawing.Size(773, 175);
            this.DataBarang.TabIndex = 0;
            this.DataBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBarang_CellClick);
            // 
            // GBTombol
            // 
            this.GBTombol.Controls.Add(this.btnHapus);
            this.GBTombol.Controls.Add(this.btnUbah);
            this.GBTombol.Controls.Add(this.btnSimpan);
            this.GBTombol.Controls.Add(this.btnRefresh);
            this.GBTombol.Location = new System.Drawing.Point(538, 215);
            this.GBTombol.Name = "GBTombol";
            this.GBTombol.Size = new System.Drawing.Size(250, 150);
            this.GBTombol.TabIndex = 12;
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
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(22, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(96, 23);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(300, 20);
            this.tbNamaBarang.TabIndex = 6;
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(96, 54);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(300, 20);
            this.tbHarga.TabIndex = 7;
            // 
            // GB2
            // 
            this.GB2.Controls.Add(this.groupBox1);
            this.GB2.Controls.Add(this.tbHarga);
            this.GB2.Controls.Add(this.tbNamaBarang);
            this.GB2.Controls.Add(this.label2);
            this.GB2.Controls.Add(this.label1);
            this.GB2.Location = new System.Drawing.Point(3, 213);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(525, 160);
            this.GB2.TabIndex = 2;
            this.GB2.TabStop = false;
            this.GB2.Text = "Form Input Barang";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCariData);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(0, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian ";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(96, 27);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(300, 20);
            this.tbCariData.TabIndex = 1;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // FormMasterBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.GBTombol);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.GB2);
            this.Name = "FormMasterBarang";
            this.Text = "FormMasterBarang";
            this.Load += new System.EventHandler(this.FormMasterBarang_Load);
            this.GB1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).EndInit();
            this.GBTombol.ResumeLayout(false);
            this.GB2.ResumeLayout(false);
            this.GB2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.DataGridView DataBarang;
        private System.Windows.Forms.GroupBox GBTombol;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCariData;
    }
}