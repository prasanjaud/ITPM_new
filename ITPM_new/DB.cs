using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ITPM_new
{
    class DB
    {
        string connectionString = "";
        MySqlConnection mysqlConnection;
        MySqlCommand mysqlCommand;
        private string mysql;

        public DB()
        {
            connectionString = "server=localhost;user id=root;database=itpm;";
            mysqlConnection = new MySqlConnection(connectionString);
        }

        public MySqlDataReader excecuteSQL(String sql)
        {

            mysqlCommand = new MySqlCommand(mysql, mysqlConnection);
            mysqlConnection.Open();
            mysqlCommand.CommandText = sql;
            return mysqlCommand.ExecuteReader();
        }
    }
}