using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Деееееееееееееееееееееемо
{
    public partial class AuthForm : Form
    {
        private static string connectionString = @"Data Source=LAB-405-ST-3\MSLR1REG;Initial Catalog=Демов;Persist Security Info=True;User ID=default;Password=123";

        public AuthForm()
        {
            InitializeComponent();
        }


        private void exitAuthFormButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guestLoginButton_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm();
            prodForm.ShowDialog();
            this.Hide();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string signInQuery = $"select Top 1 [Роль сотрудника] as Role, ltrim(rtrim(isnull(Фамилия, ''))) " +
                $"+ ' ' + ltrim(rtrim(isnull(Имя, ''))) + ' ' + ltrim(rtrim(isnull(Отчество, ''))) as FIO " +
                $"from Пользователи where Логин = '{loginTextBox.Text.ToString()}' and Пароль = '{passwordTextBox.Text.ToString()}'";
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString)) {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(signInQuery, connect))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string roleName = Convert.ToString(reader["Role"]);
                                string FIO = Convert.ToString(reader["FIO"]);
                                LoginClass.UserName = string.IsNullOrWhiteSpace(FIO) ? loginTextBox.Text : FIO;
                                LoginClass.Role = ParseRole(roleName);
                                ProductForm productForm = new ProductForm();
                                productForm.ShowDialog();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }      
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));

            }
        }

        private LoginClass.UserRole ParseRole(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                return LoginClass.UserRole.Guest;
            roleName = roleName.Trim().ToLower();
            if (roleName.Contains("администратор")) return LoginClass.UserRole.Admin;
            if (roleName.Contains("менеджер")) return LoginClass.UserRole.Manager;
            if (roleName.Contains("авторизованный клиент")) return LoginClass.UserRole.Client;
            return LoginClass.UserRole.Guest;
        }
    }
}
