using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace tranoko
{
    public partial class profilSettings : Form
    {
        private string[] logins;
        private userModel user;
        private List<string>[] userInfo;
        private System.Drawing.Image picture;
        public profilSettings(string[] Logins)
        {
            InitializeComponent();
            logins = Logins;
            DatabaseConnector db = new DatabaseConnector();
            user = new userModel(new DatabaseConnector());
            userInfo = user.Select(logins[0]);

            //mangala sary
            string query = "SELECT data FROM photo WHERE email='" + logins[0] + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            db.OpenConnection();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, db.connection);
            sda.Fill(dt);
            byte[] bits = new byte[0];
            bits = (byte[])dt.Rows[0][0];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bits);
            profilPicture.Image = System.Drawing.Bitmap.FromStream(ms);
            db.CloseConnection();
            
            firstnameRegister.Text = userInfo[2][0];
            lastnameRegister.Text = userInfo[1][0];
            emailRegister.Text = userInfo[3][0];
            telRegister.Text = userInfo[4][0];
            //passwordRegister.Text = userInfo[5][0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

                string filename;
                byte[] pdp;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;
                    profilPicture.Image = new Bitmap(filename);
                    pdp = System.IO.File.ReadAllBytes(filename);
                    user.Update(logins[0], pdp);
                }
                 }

        private void registerButton_Click(object sender, EventArgs e)
        {


            user.Update(userInfo[0][0], lastnameRegister.Text, firstnameRegister.Text, emailRegister.Text, telRegister.Text, passwordRegister.Text);

            MessageBox.Show("Profil updated successfully");
        }

        private void profilSettings_Load(object sender, EventArgs e)
        {
            
        }
    }
}
