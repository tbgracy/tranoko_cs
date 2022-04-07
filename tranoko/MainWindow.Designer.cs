namespace tranoko
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.appSettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.meSettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.filterButton = new Guna.UI2.WinForms.Guna2Button();
            this.allButton = new Guna.UI2.WinForms.Guna2Button();
            this.homeButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.childFormPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.settingsPanel);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.dashboardButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.homePanel);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 588);
            this.panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Yellow;
            this.logoutButton.CheckedState.Parent = this.logoutButton;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.CustomImages.Parent = this.logoutButton;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FillColor = System.Drawing.Color.Transparent;
            this.logoutButton.Font = new System.Drawing.Font("Quicksand", 13F, System.Drawing.FontStyle.Bold);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutButton.HoverState.Parent = this.logoutButton;
            this.logoutButton.Location = new System.Drawing.Point(0, 541);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.ShadowDecoration.Parent = this.logoutButton;
            this.logoutButton.Size = new System.Drawing.Size(187, 45);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Logout";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.appSettingsButton);
            this.settingsPanel.Controls.Add(this.meSettingsButton);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(0, 377);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(187, 97);
            this.settingsPanel.TabIndex = 9;
            // 
            // appSettingsButton
            // 
            this.appSettingsButton.BackColor = System.Drawing.Color.Gray;
            this.appSettingsButton.CheckedState.Parent = this.appSettingsButton;
            this.appSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appSettingsButton.CustomImages.Parent = this.appSettingsButton;
            this.appSettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.appSettingsButton.FillColor = System.Drawing.Color.Transparent;
            this.appSettingsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.appSettingsButton.ForeColor = System.Drawing.Color.White;
            this.appSettingsButton.HoverState.Parent = this.appSettingsButton;
            this.appSettingsButton.Location = new System.Drawing.Point(0, 45);
            this.appSettingsButton.Name = "appSettingsButton";
            this.appSettingsButton.ShadowDecoration.Parent = this.appSettingsButton;
            this.appSettingsButton.Size = new System.Drawing.Size(187, 45);
            this.appSettingsButton.TabIndex = 1;
            this.appSettingsButton.Text = "App";
            this.appSettingsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.appSettingsButton.TextOffset = new System.Drawing.Point(10, 0);
            this.appSettingsButton.Click += new System.EventHandler(this.appSettingsButton_Click);
            // 
            // meSettingsButton
            // 
            this.meSettingsButton.BackColor = System.Drawing.Color.Gray;
            this.meSettingsButton.CheckedState.Parent = this.meSettingsButton;
            this.meSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.meSettingsButton.CustomImages.Parent = this.meSettingsButton;
            this.meSettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.meSettingsButton.FillColor = System.Drawing.Color.Transparent;
            this.meSettingsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.meSettingsButton.ForeColor = System.Drawing.Color.White;
            this.meSettingsButton.HoverState.Parent = this.meSettingsButton;
            this.meSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.meSettingsButton.Name = "meSettingsButton";
            this.meSettingsButton.ShadowDecoration.Parent = this.meSettingsButton;
            this.meSettingsButton.Size = new System.Drawing.Size(187, 45);
            this.meSettingsButton.TabIndex = 0;
            this.meSettingsButton.Text = "Me";
            this.meSettingsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.meSettingsButton.TextOffset = new System.Drawing.Point(10, 0);
            this.meSettingsButton.Click += new System.EventHandler(this.meSettingsButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.CheckedState.Parent = this.settingsButton;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.CustomImages.Parent = this.settingsButton;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FillColor = System.Drawing.Color.Transparent;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.HoverState.Parent = this.settingsButton;
            this.settingsButton.Location = new System.Drawing.Point(0, 332);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.ShadowDecoration.Parent = this.settingsButton;
            this.settingsButton.Size = new System.Drawing.Size(187, 45);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Settings +";
            this.settingsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.CheckedState.Parent = this.dashboardButton;
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.CustomImages.Parent = this.dashboardButton;
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FillColor = System.Drawing.Color.Transparent;
            this.dashboardButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.HoverState.Parent = this.dashboardButton;
            this.dashboardButton.Location = new System.Drawing.Point(0, 287);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.ShadowDecoration.Parent = this.dashboardButton;
            this.dashboardButton.Size = new System.Drawing.Size(187, 45);
            this.dashboardButton.TabIndex = 7;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // addButton
            // 
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton.FillColor = System.Drawing.Color.Transparent;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Location = new System.Drawing.Point(0, 242);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(187, 45);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.filterButton);
            this.homePanel.Controls.Add(this.allButton);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePanel.Location = new System.Drawing.Point(0, 145);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(187, 97);
            this.homePanel.TabIndex = 5;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.Gray;
            this.filterButton.CheckedState.Parent = this.filterButton;
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.CustomImages.Parent = this.filterButton;
            this.filterButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterButton.FillColor = System.Drawing.Color.Transparent;
            this.filterButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterButton.ForeColor = System.Drawing.Color.White;
            this.filterButton.HoverState.Parent = this.filterButton;
            this.filterButton.Location = new System.Drawing.Point(0, 45);
            this.filterButton.Name = "filterButton";
            this.filterButton.ShadowDecoration.Parent = this.filterButton;
            this.filterButton.Size = new System.Drawing.Size(187, 45);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "Filter";
            this.filterButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.filterButton.TextOffset = new System.Drawing.Point(10, 0);
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // allButton
            // 
            this.allButton.BackColor = System.Drawing.Color.Gray;
            this.allButton.CheckedState.Parent = this.allButton;
            this.allButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allButton.CustomImages.Parent = this.allButton;
            this.allButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.allButton.FillColor = System.Drawing.Color.Transparent;
            this.allButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.allButton.ForeColor = System.Drawing.Color.White;
            this.allButton.HoverState.Parent = this.allButton;
            this.allButton.Location = new System.Drawing.Point(0, 0);
            this.allButton.Name = "allButton";
            this.allButton.ShadowDecoration.Parent = this.allButton;
            this.allButton.Size = new System.Drawing.Size(187, 45);
            this.allButton.TabIndex = 0;
            this.allButton.Text = "All";
            this.allButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.allButton.TextOffset = new System.Drawing.Point(10, 0);
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.CheckedState.Parent = this.homeButton;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.CustomImages.Parent = this.homeButton;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FillColor = System.Drawing.Color.Transparent;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.HoverState.Parent = this.homeButton;
            this.homeButton.Location = new System.Drawing.Point(0, 100);
            this.homeButton.Name = "homeButton";
            this.homeButton.ShadowDecoration.Parent = this.homeButton;
            this.homeButton.Size = new System.Drawing.Size(187, 45);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Homes +";
            this.homeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.childFormPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("childFormPanel.BackgroundImage")));
            this.childFormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.childFormPanel.Controls.Add(this.pictureBox2);
            this.childFormPanel.FillColor = System.Drawing.Color.Transparent;
            this.childFormPanel.Location = new System.Drawing.Point(213, 26);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.ShadowColor = System.Drawing.Color.Black;
            this.childFormPanel.ShadowDepth = 12;
            this.childFormPanel.ShadowShift = 200;
            this.childFormPanel.Size = new System.Drawing.Size(424, 540);
            this.childFormPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(196, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 588);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tranoko";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.childFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel homePanel;
        private Guna.UI2.WinForms.Guna2Button filterButton;
        private Guna.UI2.WinForms.Guna2Button allButton;
        private Guna.UI2.WinForms.Guna2Button homeButton;
        private Guna.UI2.WinForms.Guna2Button logoutButton;
        private System.Windows.Forms.Panel settingsPanel;
        private Guna.UI2.WinForms.Guna2Button appSettingsButton;
        private Guna.UI2.WinForms.Guna2Button meSettingsButton;
        private Guna.UI2.WinForms.Guna2Button settingsButton;
        private Guna.UI2.WinForms.Guna2Button dashboardButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2ShadowPanel childFormPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}