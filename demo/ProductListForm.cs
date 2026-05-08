using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class ProductListForm : Form
    {
        private List<ProductCardTemplate> cards = new List<ProductCardTemplate>();
        private string logoPath = @"C:\демо\Модуль 1\Прил_2_ОЗ_КОД 09.02.07-2-2026-М1\import\Icon.png";

        public ProductListForm()
        {
            InitializeComponent();


            // Настройка логотипа
            if (System.IO.File.Exists(logoPath))
                pbLogo.Image = Image.FromFile(logoPath);
            // Иконка приложения
            try {
                string iconPath = @"C:\демо\Модуль 1\Прил_2_ОЗ_КОД 09.02.07-2-2026-М1\import\Icon.ico";
                if (System.IO.File.Exists(iconPath))
                    this.Icon = new Icon(iconPath);
            } catch { }

            // Инициализация фильтров
            cmbSort.SelectedIndex = 0;
            
            // Подгружаем поставщиков в фильтр
            try {
                cmbFilter.Items.Clear();
                cmbFilter.Items.Add("Все поставщики");
                var table = DatabaseContext.ExecuteQuery("SELECT DISTINCT Supplier FROM Product");
                foreach (DataRow r in table.Rows) cmbFilter.Items.Add(r[0].ToString());
                cmbFilter.SelectedIndex = 0;
            } catch {
                cmbFilter.Items.Add("Все поставщики");
                cmbFilter.SelectedIndex = 0;
            }
            
            // Подписки
            cmbSort.SelectedIndexChanged += (s, e) => LoadProducts();
            cmbFilter.SelectedIndexChanged += (s, e) => LoadProducts();
            txtSearch.TextChanged += (s, e) => LoadProducts();
            btnOrders.Click += btnOrders_Click;

            LoadProducts();
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            btnAddProduct.Visible = (CurrentUser.Role == "Администратор");
            btnOrders.Visible = (CurrentUser.Role == "Администратор" || CurrentUser.Role == "Менеджер");
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Раздел 'Заказы' находится в разработке.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            if (pf.ShowDialog() == DialogResult.OK)
            {
                LoadProducts(); // Обновляем список после добавления
            }
        }

        private void LoadProducts()
        {
            try
            {
                foreach (var card in cards) { flpProducts.Controls.Remove(card); card.Dispose(); }
                cards.Clear();

                // 1. Поиск (по всем текстовым полям по нескольким словам)
                string search = txtSearch.Text.Trim().Replace("'", "''");
                string filterClause = " (1=1) ";
                if (!string.IsNullOrEmpty(search))
                {
                    var words = search.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach(var word in words)
                    {
                        filterClause += $" AND (ProductName LIKE N'%{word}%' OR Description LIKE N'%{word}%' OR Manufacturer LIKE N'%{word}%' OR Category LIKE N'%{word}%' OR Supplier LIKE N'%{word}%')";
                    }
                }

                // 2. Фильтрация по поставщику
                if (cmbFilter.SelectedIndex > 0)
                {
                    string selectedSupp = cmbFilter.SelectedItem.ToString().Replace("'", "''");
                    filterClause += $" AND Supplier = N'{selectedSupp}'";
                }

                // 3. Сортировка
                string sortClause = "";
                if (cmbSort.SelectedIndex == 1) sortClause = " ORDER BY Cost ASC";
                else if (cmbSort.SelectedIndex == 2) sortClause = " ORDER BY Cost DESC";
                else if (cmbSort.SelectedIndex == 3) sortClause = " ORDER BY QuantityInStock ASC";
                else if (cmbSort.SelectedIndex == 4) sortClause = " ORDER BY QuantityInStock DESC";

                string query = $"SELECT * FROM Product WHERE {filterClause} {sortClause}";
                DataTable dt = DatabaseContext.ExecuteQuery(query);

                int count = 0;

                foreach (DataRow row in dt.Rows)
                {

                    var card = CreateProductCard(row);
                    cards.Add(card);
                    count++;
                }

                lblCount.Text = $"{count} из {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ProductCardTemplate CreateProductCard(DataRow row)
        {
            ProductCardTemplate card = new ProductCardTemplate();
            
            // Фото
            string photoName = row["Photo"] != DBNull.Value ? row["Photo"].ToString() : "";
            string fullPhotoPath = $@"C:\демо\Модуль 1\Прил_2_ОЗ_КОД 09.02.07-2-2026-М1\import\{photoName}";
            Image img = null;
            
            try {
                if (!string.IsNullOrEmpty(photoName) && System.IO.File.Exists(fullPhotoPath))
                    img = Image.FromFile(fullPhotoPath);
                else
                    img = Image.FromFile(@"C:\демо\Модуль 1\Прил_2_ОЗ_КОД 09.02.07-2-2026-М1\import\picture.png");
            } catch { }

            int discount = row["DiscountAmount"] != DBNull.Value ? Convert.ToInt32(row["DiscountAmount"]) : 0;
            int stock = row["QuantityInStock"] != DBNull.Value ? Convert.ToInt32(row["QuantityInStock"]) : 0;
            decimal cost = Convert.ToDecimal(row["Cost"]);

            card.SetData(
                row["ProductName"].ToString(),
                row["Category"].ToString(),
                row["Description"].ToString(),
                row["Manufacturer"].ToString(),
                row["Supplier"].ToString(),
                row["Unit"].ToString(),
                cost,
                discount,
                stock,
                img
            );

            // Клик
            Action<object, EventArgs> clickHandler = (s, e) => {
                if (CurrentUser.Role == "Администратор") {
                    ProductForm pf = new ProductForm(row["ProductArticleNumber"].ToString());
                    if (pf.ShowDialog() == DialogResult.OK) LoadProducts();
                }
            };
            card.Click += new EventHandler(clickHandler);
            foreach (Control c in card.Controls) c.Click += new EventHandler(clickHandler);

            flpProducts.Controls.Add(card);
            return card;
        }
    }
}
