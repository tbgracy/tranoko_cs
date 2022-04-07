using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tranoko
{
    public partial class allHomes : Form
    {
        private DatabaseConnector db = new DatabaseConnector();
        public allHomes()
        {
            InitializeComponent();
            if (db.OpenConnection() == true)
            {
                MySqlDataAdapter myda = new MySqlDataAdapter();
                string query = "SELECT ville, adresse, prix, categorie, descriptif FROM house";
                myda.SelectCommand = new MySqlCommand(query, db.connection);

                DataTable table = new DataTable();
                myda.Fill(table);

                BindingSource bsourse = new BindingSource();
                bsourse.DataSource = table;

                homeListDG.DataSource = bsourse;

                homeListDG.Columns[0].HeaderText = "Town";
                homeListDG.Columns[1].HeaderText = "Address";
                homeListDG.Columns[2].HeaderText = "Price";
                homeListDG.Columns[3].HeaderText = "Category";
                homeListDG.Columns[4].HeaderText = "Description";

                db.CloseConnection();
            }
        }

        private void homeListDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allHomes_Load(object sender, EventArgs e)
        {

        }
    }
}
