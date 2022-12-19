using MySql.Data.MySqlClient;
using P9_1_1214056.model;
using P9_1_1214056.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1_1214056.controller
{
    internal class login
    {
        Koneksi koneksi = new Koneksi();
        public bool check_login (string user, string pass)
        {
            try
            {
                koneksi.OpenConnection();
                MySqlDataReader reader = koneksi.reader("Select * From t_admin Where user ='" +
                    user + "' AND pass ='" + pass + "'");
                if (reader.Read())
                {
                    koneksi.CloseConnection();
                    return true;
                }
                else
                {
                    koneksi.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal");
            }
            return false;
        }
    }
}
