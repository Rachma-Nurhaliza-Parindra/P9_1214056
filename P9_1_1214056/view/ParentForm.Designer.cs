namespace P9_1_1214056.view
{
    partial class ParentForm
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
            this.MdiMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataMahasiswaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMansterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataMahasiswaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputNilaiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tugasPraktikum11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataMasterBarangMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataTransaksiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiMenu
            // 
            this.MdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.dataMansterToolStripMenuItem,
            this.pToolStripMenuItem,
            this.HelpMenuItem,
            this.tugasPraktikum11ToolStripMenuItem});
            this.MdiMenu.Location = new System.Drawing.Point(0, 0);
            this.MdiMenu.Name = "MdiMenu";
            this.MdiMenu.Size = new System.Drawing.Size(800, 24);
            this.MdiMenu.TabIndex = 1;
            this.MdiMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataMahasiswaMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "&File";
            // 
            // DataMahasiswaMenuItem
            // 
            this.DataMahasiswaMenuItem.Name = "DataMahasiswaMenuItem";
            this.DataMahasiswaMenuItem.Size = new System.Drawing.Size(159, 22);
            this.DataMahasiswaMenuItem.Text = "Data &Mahasiswa";
            this.DataMahasiswaMenuItem.Click += new System.EventHandler(this.DataMahasiswaMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ExitMenuItem.Text = "&Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // dataMansterToolStripMenuItem
            // 
            this.dataMansterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataMahasiswaMenu});
            this.dataMansterToolStripMenuItem.Name = "dataMansterToolStripMenuItem";
            this.dataMansterToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dataMansterToolStripMenuItem.Text = "Data Master";
            // 
            // DataMahasiswaMenu
            // 
            this.DataMahasiswaMenu.Name = "DataMahasiswaMenu";
            this.DataMahasiswaMenu.Size = new System.Drawing.Size(159, 22);
            this.DataMahasiswaMenu.Text = "Data &Mahasiswa";
            this.DataMahasiswaMenu.Click += new System.EventHandler(this.DataMahasiswaMenu_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputNilaiMenuItem});
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.pToolStripMenuItem.Text = "Data Transaksi";
            // 
            // InputNilaiMenuItem
            // 
            this.InputNilaiMenuItem.Name = "InputNilaiMenuItem";
            this.InputNilaiMenuItem.Size = new System.Drawing.Size(180, 22);
            this.InputNilaiMenuItem.Text = "Input Nilai";
            this.InputNilaiMenuItem.Click += new System.EventHandler(this.InputNilaiMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMeMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "&Help";
            // 
            // AboutMeMenuItem
            // 
            this.AboutMeMenuItem.Name = "AboutMeMenuItem";
            this.AboutMeMenuItem.Size = new System.Drawing.Size(127, 22);
            this.AboutMeMenuItem.Text = "About Me";
            this.AboutMeMenuItem.Click += new System.EventHandler(this.AboutMeMenuItem_Click);
            // 
            // tugasPraktikum11ToolStripMenuItem
            // 
            this.tugasPraktikum11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataMasterBarangMenuItem,
            this.DataTransaksiMenuItem});
            this.tugasPraktikum11ToolStripMenuItem.Name = "tugasPraktikum11ToolStripMenuItem";
            this.tugasPraktikum11ToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.tugasPraktikum11ToolStripMenuItem.Text = "Tugas Praktikum 11";
            // 
            // DataMasterBarangMenuItem
            // 
            this.DataMasterBarangMenuItem.Name = "DataMasterBarangMenuItem";
            this.DataMasterBarangMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DataMasterBarangMenuItem.Text = "Data Master Barang";
            this.DataMasterBarangMenuItem.Click += new System.EventHandler(this.DataMasterBarangMenuItem_Click);
            // 
            // DataTransaksiMenuItem
            // 
            this.DataTransaksiMenuItem.Name = "DataTransaksiMenuItem";
            this.DataTransaksiMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DataTransaksiMenuItem.Text = "Data Transaksi";
            this.DataTransaksiMenuItem.Click += new System.EventHandler(this.DataTransaksiMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MdiMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MdiMenu;
            this.Name = "ParentForm";
            this.Text = "Parent Form";
            this.MdiMenu.ResumeLayout(false);
            this.MdiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MdiMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataMahasiswaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InputNilaiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMansterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataMahasiswaMenu;
        private System.Windows.Forms.ToolStripMenuItem tugasPraktikum11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataMasterBarangMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataTransaksiMenuItem;
    }
}