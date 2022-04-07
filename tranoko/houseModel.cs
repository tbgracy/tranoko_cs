using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace tranoko
{
    class houseModel
    {
        private DatabaseConnector db;

        public houseModel(DatabaseConnector Db)
        {
            db = Db;
        }

        public void Insert(string ville, string adresse, string prix, string categorie, string descriptif) {
            string query = "INSERT INTO house(ville, adresse, prix, categorie, descriptif) VALUES (@ville, @adresse, @prix, @categorie, @descriptif)";

            if (db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.Add("@ville", MySqlDbType.String).Value = ville;
                cmd.Parameters.Add("@adresse", MySqlDbType.String).Value = adresse;
                cmd.Parameters.Add("@prix", MySqlDbType.String).Value = prix;
                cmd.Parameters.Add("@categorie", MySqlDbType.String).Value = categorie;
                cmd.Parameters.Add("@descriptif", MySqlDbType.String).Value = descriptif;
                //cmd.Parameters.Add("@userID", MySqlDbType.String).Value = userID;
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        public void Select()
        {

        }
    }
}
