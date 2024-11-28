using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LogicMines.Data
{
    class Connection
    {
        public static MySqlConnection connMaster = new MySqlConnection();
        static int server = 3306;
        static string database = "scanner";
        static string uid = "root";
        static string password = "123";

        public static MySqlConnection dataSource()
        {
            connMaster = new MySqlConnection($"server = {server}; database = {database}; uid = {uid}; password = {password}");
            return connMaster;
        }

        public void connOpen()
        {
            dataSource();
            connMaster.Open();
        }

        public void connClose()
        {
            dataSource();
            connMaster.Close();
        }
    }
}
