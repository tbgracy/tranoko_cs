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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint++;
            progressBar.Value = startpoint;
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                login Login = new tranoko.login();
                Login.Show();
                this.Hide();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
