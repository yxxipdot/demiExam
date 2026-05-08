using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace demo
{
    public partial class ProductCardTemplate : UserControl
    {
        public ProductCardTemplate()
        {
            InitializeComponent();
        }

        public void SetData(string name, string category, string description, string manufacturer, 
                            string supplier, string unit, decimal cost, int discount, int stock, Image photo)
        {
            lblTitle.Text = $"{category} | {name}";
            lblDescription.Text = $"Описание товара: {description}";
            lblManufacturer.Text = $"Производитель: {manufacturer}";
            lblSupplier.Text = $"Поставщик: {supplier}";
            lblUnit.Text = $"Единица измерения: {unit}";
            lblStock.Text = $"Количество на складе: {stock}";
            
            if (photo != null) pbPhoto.Image = photo;

           

            if (discount > 15) {
                lblDiscount.BackColor = ColorTranslator.FromHtml("#2E8B57"); // Подкрашиваем только блок скидки (по Прил_3)
            }
            if (stock == 0) {
                lblStock.BackColor = Color.LightBlue; // Подкрашиваем только блок наличия
            }

            // Логика цены
            if (discount > 0)
            {
                decimal totalCost = cost * (1 - (decimal)discount / 100);
                lblOldPrice.Text = $"{cost:F2}";
                lblOldPrice.Visible = true;
                lblOldPrice.BackColor = Color.White;

                lblNewPrice.Text = $"{totalCost:F2} руб.";
                lblNewPrice.BackColor = Color.White;

                lblDiscount.Text = $"Действующая\nскидка\n\n{discount}%";
            }
            else
            {
                lblOldPrice.Visible = false;
                lblNewPrice.Text = $"{cost:F2} руб.";
                lblNewPrice.BackColor = Color.White;
                lblDiscount.Text = "";
            }
        }
    }
}
