using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace P9_1_1214056
{
    internal class Koneksi
    {
        string connectionstring = "datasource=127.0.0.1;port=3306;Uid=root;pwd=;database=ulbi;";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionstring);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object datable = data.Tables[0];
            return datable;
        }
        public MySqlDataReader reader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
