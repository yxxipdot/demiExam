using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace demo
{
    public partial class ProductForm : Form
    {
        private string _articleNumber;
        private bool _isEditMode;
        private string _newPhotoPath = null;
        private string _oldPhotoName = null;
        private string _importPath = @"C:\демо\Модуль 1\Прил_2_ОЗ_КОД 09.02.07-2-2026-М1\import";

        public ProductForm(string articleNumber = null)
        {
            InitializeComponent();
            _articleNumber = articleNumber;
            _isEditMode = articleNumber != null;
            
            LoadComboBoxes();

            if (_isEditMode)
            {
                this.Text = "Редактирование товара";
                lblArticle.Text = $"Артикул: {_articleNumber}";
                LoadProductData();
            }
            else
            {
                this.Text = "Добавление товара";
                lblArticle.Text = "Артикул будет сгенерирован";
                btnDelete.Visible = false;
            }
        }

        private void LoadComboBoxes()
        {
            try {
                var catTable = DatabaseContext.ExecuteQuery("SELECT DISTINCT Category FROM Product");
                foreach (DataRow r in catTable.Rows) cmbCategory.Items.Add(r[0]);

                var manTable = DatabaseContext.ExecuteQuery("SELECT DISTINCT Manufacturer FROM Product");
                foreach (DataRow r in manTable.Rows) cmbManufacturer.Items.Add(r[0]);
            } catch { }
        }

        private void LoadProductData()
        {
            try
            {
                string query = "SELECT * FROM Product WHERE ProductArticleNumber = @Art";
                SqlParameter[] pars = { new SqlParameter("@Art", _articleNumber) };
                DataTable dt = DatabaseContext.ExecuteQuery(query, pars);
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    txtName.Text = r["ProductName"].ToString();
                    cmbCategory.Text = r["Category"].ToString();
                    txtDescription.Text = r["Description"].ToString();
                    cmbManufacturer.Text = r["Manufacturer"].ToString();
                    txtSupplier.Text = r["Supplier"].ToString();
                    txtUnit.Text = r["Unit"].ToString();
                    txtPrice.Text = r["Cost"].ToString();
                    txtDiscount.Text = r["DiscountAmount"].ToString();
                    txtStock.Text = r["QuantityInStock"].ToString();
                    
                    _oldPhotoName = r["Photo"].ToString();
                    LoadImageToPB(_oldPhotoName);
                }
            } catch (Exception ex) {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadImageToPB(string photoName)
        {
            string path = System.IO.Path.Combine(_importPath, photoName ?? "");
            if (System.IO.File.Exists(path))
                pbPhoto.Image = Image.FromFile(path);
            else
                pbPhoto.Image = Image.FromFile(System.IO.Path.Combine(_importPath, "picture.png"));
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _newPhotoPath = ofd.FileName;
                pbPhoto.Image = Image.FromFile(_newPhotoPath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try {
                string savedPhotoName = _oldPhotoName;
                if (_newPhotoPath != null) {
                    savedPhotoName = SaveAndResizeImage(_newPhotoPath);
                    // Удаляем старое фото если оно было и изменилось
                    if (!string.IsNullOrEmpty(_oldPhotoName) && _oldPhotoName != "picture.png") {
                        try { System.IO.File.Delete(System.IO.Path.Combine(_importPath, _oldPhotoName)); } catch {}
                    }
                }

                if (_isEditMode) {
                    string sql = "UPDATE Product SET ProductName=@Name, Category=@Cat, Description=@Desc, Manufacturer=@Man, Supplier=@Sup, Unit=@Unit, Cost=@Cost, DiscountAmount=@Disc, QuantityInStock=@Stock, Photo=@Photo WHERE ProductArticleNumber=@Art";
                    SqlParameter[] pars = GetParams(savedPhotoName);
                    DatabaseContext.ExecuteQuery(sql, pars);
                } else {
                    // Генерация ID и вставка (упрощено)
                    string sql = "INSERT INTO Product (ProductArticleNumber, ProductName, Category, Description, Manufacturer, Supplier, Unit, Cost, DiscountAmount, QuantityInStock, Photo) VALUES (@Art, @Name, @Cat, @Desc, @Man, @Sup, @Unit, @Cost, @Disc, @Stock, @Photo)";
                    _articleNumber = "NEW" + DateTime.Now.Ticks.ToString().Substring(10); // Упрощенный артикул
                    SqlParameter[] pars = GetParams(savedPhotoName);
                    DatabaseContext.ExecuteQuery(sql, pars);
                }

                MessageBox.Show("Данные сохранены успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show("Ошибка сохранения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("Введите наименование", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!decimal.TryParse(txtPrice.Text, out decimal p) || p < 0) { MessageBox.Show("Некорректная цена", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!int.TryParse(txtStock.Text, out int s) || s < 0) { MessageBox.Show("Некорректное количество", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        private SqlParameter[] GetParams(string photo)
        {
            return new SqlParameter[] {
                new SqlParameter("@Art", _articleNumber),
                new SqlParameter("@Name", txtName.Text),
                new SqlParameter("@Cat", cmbCategory.Text),
                new SqlParameter("@Desc", txtDescription.Text),
                new SqlParameter("@Man", cmbManufacturer.Text),
                new SqlParameter("@Sup", txtSupplier.Text),
                new SqlParameter("@Unit", txtUnit.Text),
                new SqlParameter("@Cost", decimal.Parse(txtPrice.Text)),
                new SqlParameter("@Disc", byte.Parse(string.IsNullOrEmpty(txtDiscount.Text) ? "0" : txtDiscount.Text)),
                new SqlParameter("@Stock", int.Parse(txtStock.Text)),
                new SqlParameter("@Photo", photo ?? (object)DBNull.Value)
            };
        }

        private string SaveAndResizeImage(string sourcePath)
        {
            string fileName = System.IO.Path.GetFileName(sourcePath);
            string destPath = System.IO.Path.Combine(_importPath, fileName);
            
            using (Image img = Image.FromFile(sourcePath)) {
                using (Bitmap b = new Bitmap(img, new Size(300, 200))) {
                    b.Save(destPath);
                }
            }
            return fileName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                try {
                    // Проверка на наличие в заказах
                    var check = DatabaseContext.ExecuteQuery("SELECT 1 FROM OrderProduct op JOIN Product p ON op.ProductID = p.ProductID WHERE p.ProductArticleNumber = @Art", new SqlParameter[] { new SqlParameter("@Art", _articleNumber) });
                    if (check.Rows.Count > 0) {
                        MessageBox.Show("Нельзя удалить товар, который есть в заказе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DatabaseContext.ExecuteQuery("DELETE FROM Product WHERE ProductArticleNumber = @Art", new SqlParameter[] { new SqlParameter("@Art", _articleNumber) });
                    if (!string.IsNullOrEmpty(_oldPhotoName) && _oldPhotoName != "picture.png") {
                        try { System.IO.File.Delete(System.IO.Path.Combine(_importPath, _oldPhotoName)); } catch {}
                    }
                    
                    MessageBox.Show("Товар удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                } catch (Exception ex) {
                    MessageBox.Show("Ошибка удаления: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) { this.Close(); }
    }
}
