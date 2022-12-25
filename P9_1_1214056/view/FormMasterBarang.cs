using P9_1_1214056.controller;
using P9_1_1214056.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1_1214056.view
{
    public partial class FormMasterBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang barang = new M_barang();
        string id_barang;

        public void Tampil()
        {
            //QueryDB
            DataBarang.DataSource = koneksi.ShowData("select * from t_barang");

            //Mengubah Nama Kolom Table
            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
        }

        public FormMasterBarang()
        {
            InitializeComponent();
        }

        private void FormMasterBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text == "" || tbHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MasterBarang masterbrg = new MasterBarang();
                barang.Nama_barang = tbNamaBarang.Text;
                barang.Harga = tbHarga.Text;

                masterbrg.Insert(barang);

                tbNamaBarang.Text = "";
                tbHarga.Text = "";


                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbNamaBarang.Text = "";
            tbHarga.Text = "";
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text == "" || tbHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MasterBarang masterbrg = new MasterBarang();
                barang.Nama_barang = tbNamaBarang.Text;
                barang.Harga = tbHarga.Text;

                masterbrg.Update(barang, id_barang);

                tbNamaBarang.Text = "";
                tbHarga.Text = "";


                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah Yakin Ingin Menghapus?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                MasterBarang masterbrg = new MasterBarang();
                masterbrg.Delete(id_barang);
                Tampil();
            }
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNamaBarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHarga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search Data
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%' '" + tbCariData.Text + "' '%' " +
                "OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' " +
                "OR harga LIKE '%' '" + tbCariData.Text + "' '%' ");
        }
    }
}
