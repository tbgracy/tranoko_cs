namespace tranoko
{
    partial class profilSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profilSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profilPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.firstnameRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastnameRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.telRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.registerButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(357, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profil";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 40);
            this.panel1.TabIndex = 2;
            // 
            // profilPicture
            // 
            this.profilPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilPicture.BackColor = System.Drawing.Color.Transparent;
            this.profilPicture.Image = ((System.Drawing.Image)(resources.GetObject("profilPicture.Image")));
            this.profilPicture.Location = new System.Drawing.Point(276, 48);
            this.profilPicture.Name = "profilPicture";
            this.profilPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilPicture.ShadowDecoration.Parent = this.profilPicture;
            this.profilPicture.Size = new System.Drawing.Size(120, 120);
            this.profilPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilPicture.TabIndex = 16;
            this.profilPicture.TabStop = false;
            this.profilPicture.UseTransparentBackground = true;
            // 
            // firstnameRegister
            // 
            this.firstnameRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnameRegister.BackColor = System.Drawing.Color.Maroon;
            this.firstnameRegister.BorderColor = System.Drawing.Color.Silver;
            this.firstnameRegister.BorderThickness = 2;
            this.firstnameRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstnameRegister.DefaultText = "";
            this.firstnameRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstnameRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstnameRegister.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.firstnameRegister.DisabledState.Parent = this.firstnameRegister;
            this.firstnameRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.firstnameRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstnameRegister.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.firstnameRegister.FocusedState.Parent = this.firstnameRegister;
            this.firstnameRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firstnameRegister.ForeColor = System.Drawing.Color.Silver;
            this.firstnameRegister.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.firstnameRegister.HoverState.Parent = this.firstnameRegister;
            this.firstnameRegister.HoverState.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.firstnameRegister.Location = new System.Drawing.Point(27, 48);
            this.firstnameRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstnameRegister.Name = "firstnameRegister";
            this.firstnameRegister.PasswordChar = '\0';
            this.firstnameRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.firstnameRegister.PlaceholderText = "first name";
            this.firstnameRegister.SelectedText = "";
            this.firstnameRegister.ShadowDecoration.Parent = this.firstnameRegister;
            this.firstnameRegister.Size = new System.Drawing.Size(215, 47);
            this.firstnameRegister.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.firstnameRegister.TabIndex = 18;
            // 
            // lastnameRegister
            // 
            this.lastnameRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastnameRegister.BackColor = System.Drawing.Color.Maroon;
            this.lastnameRegister.BorderColor = System.Drawing.Color.Silver;
            this.lastnameRegister.BorderThickness = 2;
            this.lastnameRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastnameRegister.DefaultText = "";
            this.lastnameRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastnameRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastnameRegister.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.lastnameRegister.DisabledState.Parent = this.lastnameRegister;
            this.lastnameRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.lastnameRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastnameRegister.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.lastnameRegister.FocusedState.Parent = this.lastnameRegister;
            this.lastnameRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lastnameRegister.ForeColor = System.Drawing.Color.Silver;
            this.lastnameRegister.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.lastnameRegister.HoverState.Parent = this.lastnameRegister;
            this.lastnameRegister.HoverState.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.lastnameRegister.Location = new System.Drawing.Point(27, 103);
            this.lastnameRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastnameRegister.Name = "lastnameRegister";
            this.lastnameRegister.PasswordChar = '\0';
            this.lastnameRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.lastnameRegister.PlaceholderText = "last name";
            this.lastnameRegister.SelectedText = "";
            this.lastnameRegister.ShadowDecoration.Parent = this.lastnameRegister;
            this.lastnameRegister.Size = new System.Drawing.Size(215, 47);
            this.lastnameRegister.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.lastnameRegister.TabIndex = 17;
            // 
            // emailRegister
            // 
            this.emailRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailRegister.BackColor = System.Drawing.Color.Maroon;
            this.emailRegister.BorderColor = System.Drawing.Color.Silver;
            this.emailRegister.BorderThickness = 2;
            this.emailRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailRegister.DefaultText = "";
            this.emailRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailRegister.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.emailRegister.DisabledState.Parent = this.emailRegister;
            this.emailRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.emailRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailRegister.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.emailRegister.FocusedState.Parent = this.emailRegister;
            this.emailRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailRegister.ForeColor = System.Drawing.Color.Silver;
            this.emailRegister.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.emailRegister.HoverState.Parent = this.emailRegister;
            this.emailRegister.HoverState.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.emailRegister.Location = new System.Drawing.Point(27, 158);
            this.emailRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailRegister.Name = "emailRegister";
            this.emailRegister.PasswordChar = '\0';
            this.emailRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.emailRegister.PlaceholderText = "e-mail";
            this.emailRegister.SelectedText = "";
            this.emailRegister.ShadowDecoration.Parent = this.emailRegister;
            this.emailRegister.Size = new System.Drawing.Size(215, 47);
            this.emailRegister.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.emailRegister.TabIndex = 6;
            // 
            // telRegister
            // 
            this.telRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telRegister.BackColor = System.Drawing.Color.Maroon;
            this.telRegister.BorderColor = System.Drawing.Color.Silver;
            this.telRegister.BorderThickness = 2;
            this.telRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telRegister.DefaultText = "";
            this.telRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.telRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.telRegister.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.telRegister.DisabledState.Parent = this.telRegister;
            this.telRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.telRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.telRegister.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.telRegister.FocusedState.Parent = this.telRegister;
            this.telRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.telRegister.ForeColor = System.Drawing.Color.Silver;
            this.telRegister.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.telRegister.HoverState.Parent = this.telRegister;
            this.telRegister.HoverState.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.telRegister.Location = new System.Drawing.Point(27, 213);
            this.telRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telRegister.Name = "telRegister";
            this.telRegister.PasswordChar = '\0';
            this.telRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.telRegister.PlaceholderText = "phone number";
            this.telRegister.SelectedText = "";
            this.telRegister.ShadowDecoration.Parent = this.telRegister;
            this.telRegister.Size = new System.Drawing.Size(215, 47);
            this.telRegister.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.telRegister.TabIndex = 11;
            // 
            // passwordRegister
            // 
            this.passwordRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordRegister.BackColor = System.Drawing.Color.Maroon;
            this.passwordRegister.BorderColor = System.Drawing.Color.Silver;
            this.passwordRegister.BorderThickness = 2;
            this.passwordRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordRegister.DefaultText = "";
            this.passwordRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordRegister.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.passwordRegister.DisabledState.Parent = this.passwordRegister;
            this.passwordRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordRegister.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.passwordRegister.FocusedState.ForeColor = System.Drawing.Color.Yellow;
            this.passwordRegister.FocusedState.Parent = this.passwordRegister;
            this.passwordRegister.FocusedState.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.passwordRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordRegister.ForeColor = System.Drawing.Color.Silver;
            this.passwordRegister.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.passwordRegister.HoverState.Parent = this.passwordRegister;
            this.passwordRegister.HoverState.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.passwordRegister.Location = new System.Drawing.Point(27, 268);
            this.passwordRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.PasswordChar = '\0';
            this.passwordRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordRegister.PlaceholderText = "new password ";
            this.passwordRegister.SelectedText = "";
            this.passwordRegister.ShadowDecoration.Parent = this.passwordRegister;
            this.passwordRegister.Size = new System.Drawing.Size(215, 47);
            this.passwordRegister.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passwordRegister.TabIndex = 19;
            this.passwordRegister.UseSystemPasswordChar = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Yellow;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(358, 133);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(38, 35);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.TextOffset = new System.Drawing.Point(0, -2);
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.BorderRadius = 10;
            this.registerButton.CheckedState.Parent = this.registerButton;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.CustomImages.Parent = this.registerButton;
            this.registerButton.FillColor = System.Drawing.Color.Yellow;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registerButton.HoverState.Parent = this.registerButton;
            this.registerButton.Location = new System.Drawing.Point(227, 374);
            this.registerButton.Name = "registerButton";
            this.registerButton.ShadowDecoration.Parent = this.registerButton;
            this.registerButton.Size = new System.Drawing.Size(180, 45);
            this.registerButton.TabIndex = 20;
            this.registerButton.Text = "Save change(s)";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // profilSettings
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(419, 431);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.firstnameRegister);
            this.Controls.Add(this.lastnameRegister);
            this.Controls.Add(this.profilPicture);
            this.Controls.Add(this.telRegister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.emailRegister);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "profilSettings";
            this.Text = "profilSettings";
            this.Load += new System.EventHandler(this.profilSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilPicture;
        private Guna.UI2.WinForms.Guna2TextBox firstnameRegister;
        private Guna.UI2.WinForms.Guna2TextBox lastnameRegister;
        private Guna.UI2.WinForms.Guna2TextBox emailRegister;
        private Guna.UI2.WinForms.Guna2TextBox telRegister;
        private Guna.UI2.WinForms.Guna2TextBox passwordRegister;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button registerButton;
    }
}