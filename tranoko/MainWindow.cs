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
    public partial class MainWindow : Form
    {
        private string[] logins;

        public MainWindow(string[] Logins)
        {
            InitializeComponent();
            homePanel.Visible = false;
            settingsPanel.Visible = false;
            this.logins = Logins;
        }

        private void hideSubMenus()
        {
            if (homePanel.Visible == true)
            {
                homePanel.Visible = false;
            }
            if (settingsPanel.Visible == true)
            {
                settingsPanel.Visible = false;
            }
        }

        private void toggleSubMenuVisibility(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            toggleSubMenuVisibility(homePanel);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            toggleSubMenuVisibility(settingsPanel);
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            openChildForm(new allHomes());
            hideSubMenus();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            openChildForm(new filter());
            hideSubMenus();
        }

        private void meSettingsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new profilSettings(logins));
            hideSubMenus();
        }

        private void appSettingsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new appSettings());
            hideSubMenus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            openChildForm(new addHome(logins));
            hideSubMenus();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            openChildForm(new dashboard());
            hideSubMenus();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            // s'il y a une form active, nous le fermons avant d'en ouvrir un autre
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            // changer le comportement du childForm en celui d'un simple Controler
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // enlever bordure
            childForm.Dock = DockStyle.Fill;

            // ajouter childForm dans le childFormPanel
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;

            childForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                text: "Are you sure?",
                caption: "Confirm logout",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Warning
            );

            if (response.Equals(DialogResult.Yes))
            {
                this.Hide();
                login Login = new login();
                Login.Show();
            }
            else if (response.Equals(DialogResult.No))
            {
                MessageBox.Show("Merci pour votre addiction à notre application 😊.");
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
