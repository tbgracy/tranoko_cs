using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace tranoko
{
    class userModel
    {
        private DatabaseConnector db;

        public userModel(DatabaseConnector Db)
        {
            db = Db;
        }

        public void Insert(string email, byte [] photo)
        {
            string query = "INSERT INTO photo VALUES (@data, @email)";

            if (db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.Add("@data", MySqlDbType.Blob).Value = photo;
                cmd.Parameters.Add("@email", MySqlDbType.String).Value = email;
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        public void Insert(string nom, string prenom, string email, string tel, string password)
        {
            string Query = "INSERT INTO user(nom, prenom, email, tel, password) VALUES (@nom, @prenom, @email, @tel, md5(@password))";

            if (db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(Query, db.connection);
                cmd.Parameters.Add("@nom", MySqlDbType.String).Value = nom;
                cmd.Parameters.Add("@prenom", MySqlDbType.String).Value = prenom;
                cmd.Parameters.Add("@email", MySqlDbType.String).Value = email;
                cmd.Parameters.Add("@tel", MySqlDbType.Int64).Value = tel;
                cmd.Parameters.Add("@password", MySqlDbType.String).Value = password;
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        public List<string>[] Login(string email, string password)
        {
            string query = "SELECT prenom, email, password FROM user WHERE email=@email AND password=md5(@password)";

            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            if (db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.Add("@email", MySqlDbType.String).Value = email;
                cmd.Parameters.Add("@password", MySqlDbType.String).Value = password;
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["prenom"].ToString());
                    list[1].Add(dataReader["email"].ToString());
                    list[2].Add(dataReader["password"].ToString());
                }
                dataReader.Close();
                db.CloseConnection();
                return list;
            }
            else return list;
        }

        public List<string>[] Select(string email)
        {
            string query = "SELECT * FROM user WHERE email=@email";

            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.Add("@email", MySqlDbType.String).Value = email;
                //cmd.Parameters.Add("@password", MySqlDbType.String).Value = password;
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["userID"] + "");
                    list[1].Add(dataReader["nom"] + "");
                    list[2].Add(dataReader["prenom"] + "");
                    list[3].Add(dataReader["email"] + "");
                    list[4].Add(dataReader["tel"] + "");
                    list[5].Add(dataReader["password"] + "");
                }
                dataReader.Close();
                db.CloseConnection();
                return list;
            }
            else return list;
        }

        public void Update(string userID, string nom, string prenom, string email, string tel, string password)
        {
            string query = "UPDATE user SET nom=@nom, prenom=@prenom, email=@email, tel=@tel, password=md5(@password) WHERE userID=@userID";

            if(db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.Add("@userID", MySqlDbType.String).Value = userID;
                cmd.Parameters.Add("@nom", MySqlDbType.String).Value = nom;
                cmd.Parameters.Add("@prenom", MySqlDbType.String).Value = prenom;
                cmd.Parameters.Add("@email", MySqlDbType.String).Value = email;
                cmd.Parameters.Add("@tel", MySqlDbType.Int64).Value = tel;
                cmd.Parameters.Add("@password", MySqlDbType.String).Value = password;

                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        public void Update(string email, byte[] photo)
        {
            string query = "UPDATE photo SET data=@data WHERE email=@email";

            if (db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.Add("@data", MySqlDbType.Blob).Value = photo;
                cmd.Parameters.Add("@email", MySqlDbType.String).Value = email;
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }
    }
}
