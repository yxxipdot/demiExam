namespace demo
{
    partial class ProductListForm
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
            lblDiscount = new Label();
            lblInfo = new Label();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            cmbSort = new ComboBox();
            cmbFilter = new ComboBox();
            txtSearch = new TextBox();
            lblCount = new Label();
            pbLogo = new PictureBox();
            btnAddProduct = new Button();
            btnOrders = new Button();
            pnlHeader = new Panel();
            flpProducts = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblDiscount
            // 
            lblDiscount.Location = new Point(680, 20);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(100, 140);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "Скидка:\r\n0%";
            lblDiscount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(180, 50);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(480, 120);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Описание товара:\r\nПроизводитель:\r\nЦена:\r\nКоличество на складе:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(180, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 19);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Категория товара | Наименование товара";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Font = new Font("Times New Roman", 10F);
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Без сортировки", "Стоимость (возр.)", "Стоимость (убыв.)", "Остаток (возр.)", "Остаток (убыв.)" });
            cmbSort.Location = new Point(150, 45);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(160, 23);
            cmbSort.TabIndex = 1;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Times New Roman", 10F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Все скидки", "0-9.99%", "10-14.99%", "15% и более" });
            cmbFilter.Location = new Point(320, 45);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(160, 23);
            cmbFilter.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 10F);
            txtSearch.Location = new Point(150, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск по товарам...";
            txtSearch.Size = new Size(330, 23);
            txtSearch.TabIndex = 3;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            lblCount.Location = new Point(490, 15);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(44, 17);
            lblCount.TabIndex = 4;
            lblCount.Text = "0 из 0";
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(12, 10);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(120, 80);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 5;
            pbLogo.TabStop = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(0, 250, 154);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnAddProduct.Location = new Point(640, 10);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(180, 35);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Добавить товар";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.FromArgb(0, 250, 154);
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnOrders.Location = new Point(640, 50);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(180, 35);
            btnOrders.TabIndex = 9;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pbLogo);
            pnlHeader.Controls.Add(btnOrders);
            pnlHeader.Controls.Add(btnAddProduct);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(lblCount);
            pnlHeader.Controls.Add(cmbSort);
            pnlHeader.Controls.Add(cmbFilter);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(844, 100);
            pnlHeader.TabIndex = 7;
            // 
            // flpProducts
            // 
            flpProducts.AutoScroll = true;
            flpProducts.BackColor = Color.White;
            flpProducts.Dock = DockStyle.Fill;
            flpProducts.FlowDirection = FlowDirection.TopDown;
            flpProducts.Location = new Point(0, 100);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(844, 650);
            flpProducts.TabIndex = 8;
            flpProducts.WrapContents = false;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(844, 750);
            Controls.Add(flpProducts);
            Controls.Add(pnlHeader);
            Font = new Font("Times New Roman", 9F);
            Name = "ProductListForm";
            Text = "Торговля - Список товаров";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblInfo;
        private Label lblDiscount;
        private ComboBox cmbSort;
        private ComboBox cmbFilter;
        private TextBox txtSearch;
        private Label lblCount;
        private PictureBox pbLogo;
        private Button btnAddProduct;
        private Panel pnlHeader;
        private Button btnOrders;
        private FlowLayoutPanel flpProducts;
    }
}
