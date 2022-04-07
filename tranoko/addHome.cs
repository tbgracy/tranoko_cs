using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tranoko
{
    public partial class addHome : Form
    {
        private string[] logins;
        public addHome(string[] Logins)
        {
            InitializeComponent();
            logins = Logins;
        }

        private void addHome_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            houseModel house = new houseModel(new DatabaseConnector());
            house.Insert(townAdd.Text, addressAdd.Text, priceAdd.Value.ToString(), categoryAdd.Text, descripAdd.Text);

            if (MessageBox.Show("New house added successuly") == DialogResult.OK)
            {
                townAdd.Text = "";
                addressAdd.ResetText();
                priceAdd.ResetText(); 
                categoryAdd.ResetText();
                descripAdd.ResetText();
            }
        }
    }
}
