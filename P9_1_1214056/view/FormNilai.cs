﻿using MySql.Data.MySqlClient;
using P9_1_1214056.controller;
using P9_1_1214056.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P9_1_1214056.view
{
    public partial class FormNilai : Form
    {
        Koneksi koneksi = new Koneksi();
        M_nilai m_nli = new M_nilai();
        string id_nilai;
        public void Tampil()
        {
            //Query DB
            DataNilai.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " + "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");

            //Mengubah Nama Kolom Tabel
            DataNilai.Columns[0].HeaderText = "ID";
            DataNilai.Columns[1].HeaderText = "Matkul";
            DataNilai.Columns[2].HeaderText = "Kategori";
            DataNilai.Columns[3].HeaderText = "NPM";
            DataNilai.Columns[4].HeaderText = "Nama";
            DataNilai.Columns[5].HeaderText = "Nilai";
        }
        public void GetDataMhs()
        {
            //ambil data NPM dari table (t_mahasiswa) untuk mengisi data pada combobox NPM
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                cbnpm.Items.Add(reader.GetString("npm"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public FormNilai()
        {
            InitializeComponent();
        }
        public void GetNamaMhs()
        {
            //ambil data nama ketikan combobox npm dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa " + "WHERE npm = '" + cbnpm.Text + "'");
            while (reader.Read())
            {
                tbnama.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            GetDataMhs();
            //Memanggil method tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbmatkul.SelectedIndex == -1 || cbkategori.SelectedIndex == -1 || cbnpm.SelectedIndex == -1 || tbnilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nli.Matkul = cbmatkul.Text;
                m_nli.Kategori = cbkategori.Text;
                m_nli.Npm = cbnpm.Text;
                m_nli.Nilai = tbnilai.Text;

                nilai.Insert(m_nli);

                cbmatkul.SelectedIndex = -1;
                cbkategori.SelectedIndex = -1;
                cbnpm.SelectedIndex = -1;
                cbnpm.Text = "";

                Tampil();
            }
        }

        private void DataNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_nilai = DataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbmatkul.Text = DataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbkategori.Text = DataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbnpm.Text = DataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbnilai.Text = DataNilai.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (cbmatkul.SelectedIndex == -1 || cbkategori.SelectedIndex == -1 || cbnpm.SelectedIndex == -1 || tbnilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nli.Matkul = cbmatkul.Text;
                m_nli.Kategori = cbkategori.Text;
                m_nli.Npm = cbnpm.Text;
                m_nli.Nilai = tbnilai.Text;

                nilai.Update(m_nli, id_nilai);

                cbmatkul.SelectedIndex = -1;
                cbkategori.SelectedIndex = -1;
                cbnpm.SelectedIndex = -1;
                cbnpm.Text = "";

                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbmatkul.SelectedIndex = -1;
            cbkategori.SelectedIndex = -1;
            cbnpm.SelectedIndex = -1;
            tbnilai.Text = "";
            tbnama.Text = "";

            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id_nilai);
                Tampil();
            }
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB search data
            DataNilai.DataSource = koneksi.ShowData("SELECT " +
                "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON  t_mahasiswa.npm = t_nilai.npm " +
                "WHERE t_nilai.npm LIKE '%' '" + tbCariData.Text + "' '%' " +
                "OR matkul LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void cbnpm_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaMhs();
        }

        private void ExportExcel(DataGridView dataGrid, string searchData)
        {
            string Output = "";
            string Headers = "";

            //Export Title 
            for (int j = 0; j < dataGrid.ColumnCount; j++)
            {
                Headers = Headers.ToString() + Convert.ToString(dataGrid.Columns[j].HeaderText) + "\t";
            }
            Output += Headers + ",\r\n";

            //Export Data
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                string Line = "";
                for (int j = 0; j < dataGrid.Rows[i].Cells.Count; j++)
                {
                    Line = Line.ToString() + Convert.ToString(dataGrid.Rows[i].Cells[j].Value) + "\t";
                }
                Output += Line + "\r\n";
            }
            Encoding encoding = Encoding.GetEncoding(1254);
            //array dengan tipe byte
            byte[] ouputs = encoding.GetBytes(Output);
            FileStream file = new FileStream(searchData, FileMode.Create);
            BinaryWriter binary = new BinaryWriter(file);

            binary.Write(ouputs, 0, Output.Length);
            binary.Flush();
            binary.Close();
            file.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Document (*.xls)|*.xls";
            save.FileName = "Report Nilai.xls";

            if(save.ShowDialog() == DialogResult.OK)
            {
                ExportExcel(DataNilai, save.FileName);
            }
        }
    }
}
