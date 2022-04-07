using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tranoko
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private byte[] pdp;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string filename;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                photoRegister.Text = filename;
                profilPicture.Image = new Bitmap(filename);
                pdp = File.ReadAllBytes(filename);
            }

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            userModel user = new userModel(new DatabaseConnector());
            //need controller
            user.Insert(lastnameRegister.Text, firstnameRegister.Text, emailRegister.Text, telRegister.Text, passwordRegister.Text);
            user.Insert(emailRegister.Text, pdp);
            if (MessageBox.Show("Welcome to the family 😃") == DialogResult.OK) {
                login Login = new login();
                Login.Show();
                this.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            login Login = new tranoko.login();
            Login.Show();
            this.Hide();
        }

        private void profilPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
