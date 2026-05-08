namespace demo
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnLogin = new Button();
            btnGuest = new Button();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            lbLogin = new Label();
            lbPass = new Label();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 250, 154);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(122, 330);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 35);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(251, 330);
            btnGuest.Margin = new Padding(4);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 35);
            btnGuest.TabIndex = 1;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(208, 220);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(182, 26);
            txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(208, 270);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(182, 26);
            txtPassword.TabIndex = 3;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(105, 220);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(52, 19);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Логин";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(105, 270);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(58, 19);
            lbPass.TabIndex = 5;
            lbPass.Text = "Пароль";
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(180, 50);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(150, 150);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(519, 486);
            Controls.Add(pbLogo);
            Controls.Add(lbPass);
            Controls.Add(lbLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(btnGuest);
            Controls.Add(btnLogin);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "Торговля - Авторизация";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnGuest;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label lbLogin;
        private Label lbPass;
        private PictureBox pbLogo;
    }
}
