namespace Деееееееееееееееееееееемо
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.guestLoginButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.exitAuthFormButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guestLoginButton
            // 
            this.guestLoginButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guestLoginButton.BackColor = System.Drawing.Color.Chartreuse;
            this.guestLoginButton.CausesValidation = false;
            this.guestLoginButton.FlatAppearance.BorderSize = 0;
            this.guestLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestLoginButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestLoginButton.ForeColor = System.Drawing.Color.Black;
            this.guestLoginButton.Location = new System.Drawing.Point(77, 188);
            this.guestLoginButton.Name = "guestLoginButton";
            this.guestLoginButton.Size = new System.Drawing.Size(104, 34);
            this.guestLoginButton.TabIndex = 0;
            this.guestLoginButton.Text = "Гость";
            this.guestLoginButton.UseVisualStyleBackColor = false;
            this.guestLoginButton.Click += new System.EventHandler(this.guestLoginButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(149, 92);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(146, 26);
            this.loginTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(149, 129);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(146, 26);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(73, 95);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 19);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(73, 132);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(58, 19);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Пароль";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appNameLabel.Location = new System.Drawing.Point(94, 33);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(100, 19);
            this.appNameLabel.TabIndex = 6;
            this.appNameLabel.Text = "ООО \"Обувь\"";
            // 
            // signInButton
            // 
            this.signInButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.signInButton.BackColor = System.Drawing.Color.Chartreuse;
            this.signInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.Location = new System.Drawing.Point(191, 188);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(104, 34);
            this.signInButton.TabIndex = 7;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // exitAuthFormButton
            // 
            this.exitAuthFormButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exitAuthFormButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.exitAuthFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitAuthFormButton.FlatAppearance.BorderSize = 0;
            this.exitAuthFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAuthFormButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitAuthFormButton.ForeColor = System.Drawing.Color.Black;
            this.exitAuthFormButton.Location = new System.Drawing.Point(149, 257);
            this.exitAuthFormButton.Name = "exitAuthFormButton";
            this.exitAuthFormButton.Size = new System.Drawing.Size(75, 41);
            this.exitAuthFormButton.TabIndex = 8;
            this.exitAuthFormButton.Text = "Выйти";
            this.exitAuthFormButton.UseVisualStyleBackColor = false;
            this.exitAuthFormButton.Click += new System.EventHandler(this.exitAuthFormButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.ImageLocation = "C:\\Users\\user\\Downloads\\Модуль 1\\import\\Icon.png";
            this.logoPictureBox.Location = new System.Drawing.Point(220, 13);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(54, 54);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 317);
            this.Controls.Add(this.exitAuthFormButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.guestLoginButton);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guestLoginButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button exitAuthFormButton;
    }
}

