using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace tranoko
{
    class DatabaseConnector
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlConnection connection {
            get { return conn; }
            }

        public DatabaseConnector()
        {
            server = Environment.GetEnvironmentVariable("DB_HOST");
            database = Environment.GetEnvironmentVariable("DB_DATABASE");
            uid = Environment.GetEnvironmentVariable("DB_USERNAME");
            password = Environment.GetEnvironmentVariable("DB_PASSWORD");

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            conn = new MySqlConnection(connectionString);
        }

        public bool OpenConnection() {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid login");
                        break;
                        
                }
                return false;
            }
        }

        public bool CloseConnection() {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
