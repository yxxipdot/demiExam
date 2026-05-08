using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace demo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
            // Загрузка логотипа
            string logoPath = @"C:\демо\Модуль 1\Прил_2_ОЗ_КОД 09.02.07-2-2026-М1\import\Icon.png";
            if (System.IO.File.Exists(logoPath))
                pbLogo.Image = Image.FromFile(logoPath);
            // Иконка приложения
            try {
                string iconPath = @"C:\демо\Модуль 1\Прил_2_ОЗ_КОД 09.02.07-2-2026-М1\import\Icon.ico";
                if (System.IO.File.Exists(iconPath))
                    this.Icon = new Icon(iconPath);
            } catch { }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "SELECT UserID, Role, UserSurname, UserName, UserPatronymic FROM [User] WHERE Login = @Login AND Password = @Password";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Login", login),
                    new SqlParameter("@Password", password)
                };

                DataTable userTable = DatabaseContext.ExecuteQuery(query, parameters);

                if (userTable.Rows.Count > 0)
                {
                    DataRow userRow = userTable.Rows[0];
                    CurrentUser.UserID = (int)userRow["UserID"];
                    CurrentUser.Role = userRow["Role"].ToString();
                    CurrentUser.FIO = $"{userRow["UserSurname"]} {userRow["UserName"]} {userRow["UserPatronymic"]}";

                    MessageBox.Show($"Добро пожаловать, {CurrentUser.FIO}!\nВаша роль: {CurrentUser.Role}", 
                                    "Вход выполнен", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OpenMainForm();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            CurrentUser.UserID = 0;
            CurrentUser.Role = "Гость";
            CurrentUser.FIO = "Гость";

            MessageBox.Show("Вы вошли как Гость. Доступ ограничен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenMainForm();
        }

        private void OpenMainForm()
        {
            ProductListForm mainForm = new ProductListForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }
    }
}
