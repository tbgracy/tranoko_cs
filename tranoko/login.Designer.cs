namespace tranoko
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 10;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.Yellow;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(77, 322);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(180, 45);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Yellow;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(297, 12);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(20, 20);
            this.guna2CircleButton1.TabIndex = 1;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2CircleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 32);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 100);
            this.panel2.TabIndex = 4;
            // 
            // emailLogin
            // 
            this.emailLogin.BackColor = System.Drawing.Color.Maroon;
            this.emailLogin.BorderColor = System.Drawing.Color.Silver;
            this.emailLogin.BorderThickness = 2;
            this.emailLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailLogin.DefaultText = "";
            this.emailLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailLogin.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.emailLogin.DisabledState.Parent = this.emailLogin;
            this.emailLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.emailLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailLogin.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.emailLogin.FocusedState.Parent = this.emailLogin;
            this.emailLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailLogin.ForeColor = System.Drawing.Color.Silver;
            this.emailLogin.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.emailLogin.HoverState.Parent = this.emailLogin;
            this.emailLogin.HoverState.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.emailLogin.Location = new System.Drawing.Point(50, 166);
            this.emailLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailLogin.Name = "emailLogin";
            this.emailLogin.PasswordChar = '\0';
            this.emailLogin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.emailLogin.PlaceholderText = "e-mail";
            this.emailLogin.SelectedText = "";
            this.emailLogin.ShadowDecoration.Parent = this.emailLogin;
            this.emailLogin.Size = new System.Drawing.Size(233, 47);
            this.emailLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.emailLogin.TabIndex = 5;
            // 
            // passwordLogin
            // 
            this.passwordLogin.BackColor = System.Drawing.Color.Maroon;
            this.passwordLogin.BorderColor = System.Drawing.Color.Silver;
            this.passwordLogin.BorderThickness = 2;
            this.passwordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordLogin.DefaultText = "";
            this.passwordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordLogin.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.passwordLogin.DisabledState.Parent = this.passwordLogin;
            this.passwordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordLogin.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.passwordLogin.FocusedState.ForeColor = System.Drawing.Color.Yellow;
            this.passwordLogin.FocusedState.Parent = this.passwordLogin;
            this.passwordLogin.FocusedState.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.passwordLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordLogin.ForeColor = System.Drawing.Color.Silver;
            this.passwordLogin.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.passwordLogin.HoverState.Parent = this.passwordLogin;
            this.passwordLogin.HoverState.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.passwordLogin.Location = new System.Drawing.Point(50, 221);
            this.passwordLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.PasswordChar = '\0';
            this.passwordLogin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordLogin.PlaceholderText = "password ";
            this.passwordLogin.SelectedText = "";
            this.passwordLogin.ShadowDecoration.Parent = this.passwordLogin;
            this.passwordLogin.Size = new System.Drawing.Size(233, 47);
            this.passwordLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passwordLogin.TabIndex = 6;
            this.passwordLogin.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Not registered yet?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "for free.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(173, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sign up";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(329, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.emailLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox emailLogin;
        private Guna.UI2.WinForms.Guna2TextBox passwordLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}