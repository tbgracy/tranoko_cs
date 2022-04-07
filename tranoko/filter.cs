using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace tranoko
{
    public partial class filter : Form
    {
        private DatabaseConnector db = new DatabaseConnector();
        public filter()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (db.OpenConnection() == true)
            {
                MySqlDataAdapter myda = new MySqlDataAdapter();
                string query = "SELECT ville, adresse, prix, categorie, descriptif FROM house WHERE ville='"+guna2ComboBox1.Text+"' AND categorie='"+ guna2ComboBox2.Text + "' AND prix BETWEEN "+guna2NumericUpDown1.Value+" AND "+guna2NumericUpDown2.Value;
                myda.SelectCommand = new MySqlCommand(query, db.connection);

                DataTable table = new DataTable();
                myda.Fill(table);

                BindingSource bsourse = new BindingSource();
                bsourse.DataSource = table;

                dataGridView1.DataSource = bsourse;

                dataGridView1.Columns[0].HeaderText = "Town";
                dataGridView1.Columns[1].HeaderText = "Address";
                dataGridView1.Columns[2].HeaderText = "Price";
                dataGridView1.Columns[3].HeaderText = "Category";
                dataGridView1.Columns[4].HeaderText = "Description";

                db.CloseConnection();
            }
        }
    }
}
