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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            register Register = new tranoko.register();
            Register.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userModel user = new userModel(new DatabaseConnector());

            List<string>[] res = user.Login(emailLogin.Text, passwordLogin.Text);

            try
            {
                MessageBox.Show(String.Concat("Welcome ", res[0][0], " 😃."));
                string[] logins = new string[2];
                logins[0] = res[1][0];
                logins[1] = res[2][0];
                MainWindow mw = new MainWindow(logins);
                mw.Show();
                this.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show("Incorrect email/pasword combination. Pleaser try again."); 
            }
        }
    }
}
