using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Деееееееееееееееееееееемо
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void exitRegFormButton_Click(object sender, EventArgs e)
        {
            
        }

        private void exitProdFormButton_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }

        private void ProdForm_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = LoginClass.UserName;
            ApplyPoileUi();
        }

        private void ApplyPoileUi()
        {
            bool allowed = LoginClass.Role == LoginClass.UserRole.Admin || LoginClass.Role == LoginClass.UserRole.Manager;
            pTools.Visible = allowed;
        }
    }
}
