using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace P9_1_1214056.view
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void DataMahasiswaMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void AboutMeMenuItem_Click(object sender, EventArgs e)
        {
            
            AboutMe aboutMe = new AboutMe();
            aboutMe.MdiParent = this;
            aboutMe.Show();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void DataMahasiswaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void InputNilaiMenuItem_Click(object sender, EventArgs e)
        {
            FormNilai formNilai = new FormNilai();
            formNilai.MdiParent = this;
            formNilai.Show();
        }

        private void DataMasterBarangMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterBarang formMasterBarang = new FormMasterBarang();
            formMasterBarang.MdiParent = this;
            formMasterBarang.Show();
        }

        private void DataTransaksiMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiBarang formTransaksiBarang = new FormTransaksiBarang();
            formTransaksiBarang.MdiParent = this;
            formTransaksiBarang.Show();
        }
    }
}
