using MySql.Data.MySqlClient;
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
    public partial class FormTransaksiBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_transaksi transaksibarang = new M_transaksi();
        M_barang barang = new M_barang();
        string id_transaksi;

        public void Tampil()
        {

            DataTransaksi.DataSource = koneksi.ShowData("SELECT " + " id_transaksi, t_transaksi.id_barang, nama_barang, harga, qty, total " +
                "FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang");


            /*//QueryDB
            DataTransaksi.DataSource = koneksi.ShowData("select * from t_transaksi");*/
            //Mengubah Nama Kolom Table
            DataTransaksi.Columns[0].HeaderText = "ID";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "NamaBarang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "Qty";
            DataTransaksi.Columns[5].HeaderText = "Total Harga";

        }

        public FormTransaksiBarang()
        {
            InitializeComponent();
        }

        public void GetDataBrg()
        {
            //ambil data ID Barang dari table (t_barang) untuk mengisi data pada combobox ID Barang
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang");
            while (reader.Read())
            {
                cbIdBarang.Items.Add(reader.GetString("id_barang"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataBrg();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbIdBarang.SelectedIndex == -1 || tbNamaBarang.Text == "" || tbHargaBarang.Text == "" || tbQuantity.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiBarang m_Transaksi = new TransaksiBarang();
                transaksibarang.Id_barang = cbIdBarang.Text;
                barang.Nama_barang = tbNamaBarang.Text;
                barang.Harga = tbHargaBarang.Text;
                transaksibarang.Qty = tbQuantity.Text;
                transaksibarang.Total = tbTotal.Text;

                m_Transaksi.Insert(transaksibarang);

                cbIdBarang.SelectedIndex = -1;
                tbNamaBarang.Text = "";
                tbHargaBarang.Text = "";
                tbQuantity.Text = "";
                tbTotal.Text = "";

            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (cbIdBarang.SelectedIndex == -1 || tbNamaBarang.Text == "" || tbHargaBarang.Text == "" || tbQuantity.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiBarang m_Transaksi = new TransaksiBarang();
                transaksibarang.Id_barang = cbIdBarang.Text;
                barang.Nama_barang = tbNamaBarang.Text;
                barang.Harga = tbHargaBarang.Text;
                transaksibarang.Qty = tbQuantity.Text;
                transaksibarang.Total = tbTotal.Text;


                m_Transaksi.Update(transaksibarang, id_transaksi);

                cbIdBarang.SelectedIndex = -1;
                tbNamaBarang.Text = "";
                tbHargaBarang.Text = "";
                tbQuantity.Text = "";
                tbTotal.Text = "";

            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah Yakin Ingin Menghapus?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                TransaksiBarang m_Transaksi = new TransaksiBarang();
                m_Transaksi.Delete(id_transaksi);
                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            /*DataTransaksi.DataSource = koneksi.ShowData("SELECT " + " id_transaksi, t_transaksi.id_barang, nama_barang, harga, qty, total " +
                "FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang");*/

            //Query DB Search Data
            /*DataTransaksi.DataSource = koneksi.ShowData("SELECT " +
                " id_transaksi, t_transaksi.id_barang, nama_barang, harga, qty, total " +
                "FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang" +
                "WHERE t_transaksi.id_barang LIKE '%' '" + tbCariData.Text + "' '%' " +
                "OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' ");*/
        }

        public void GetNamaBrg()
        {
            //ambil data Nama Barang ketika combobox ID Barang dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama_barang FROM t_barang " + "WHERE id_barang = '" + cbIdBarang.Text + "'");
            while (reader.Read())
            {
                tbNamaBarang.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetHargaBrg()
        {
            //ambil data Harga Barang ketikan combobox ID Barang dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT harga FROM t_barang " + "WHERE id_barang = '" + cbIdBarang.Text + "'");
            while (reader.Read())
            {
                tbHargaBarang.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void cbIdBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaBrg();
            GetHargaBrg();
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbTotal.Text = (float.Parse(tbHargaBarang.Text) * float.Parse(tbQuantity.Text)).ToString();
            }
            catch
            {

            }
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbIdBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbNamaBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbHargaBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbQuantity.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTotal.Text = DataTransaksi.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
