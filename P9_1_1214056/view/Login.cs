using P9_1_1214056.model;
using MySql.Data.MySqlClient;
using P9_1_1214056.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace P9_1_1214056.controller
{
    public partial class Login : Form
    {
        login cek_login = new login();
        public Login()
        {
            InitializeComponent();
        }
        string connectionstring = "datasource=127.0.0.1;port=3306;Uid=root;pwd=;database=ulbi;";
        public void loginnn()
        {
            string query = "SELECT * FROM t_admin WHERE user='" + (tbUsername.Text) + "' AND pass='" + (tbPassword.Text) + "'";

            // Connecting MySql Database
            MySqlConnection databaseConnection = new MySqlConnection(connectionstring);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Login Berhasil", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ParentForm parentForm = new ParentForm();
                    parentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah, masukkan kembali dengan benar.",
                        "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Wrong, Please Try again.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username atau Password tidak boleh kosong!", "Gagal");
            }
            else
            {
                string user = tbUsername.Text;
                string pass = tbPassword.Text;

                bool status = cek_login.check_login(user, pass);
                if(status)
                {
                    MessageBox.Show("Login berhasil", "Berhasil");
                    ParentForm parentform = new ParentForm();
                    parentform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Periksa kembali username dan password anda!", "Gagal");
                }
            }
        }
    }
}
