namespace demo
{
    partial class ProductCardTemplate
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pbPhoto = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            lblManufacturer = new Label();
            lblSupplier = new Label();
            lblPriceLabel = new Label();
            lblOldPrice = new Label();
            lblNewPrice = new Label();
            lblUnit = new Label();
            lblStock = new Label();
            lblDiscount = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            SuspendLayout();
            // 
            // pbPhoto
            // 
            pbPhoto.Location = new Point(10, 15);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(150, 150);
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoto.TabIndex = 0;
            pbPhoto.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(180, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(40, 19);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            lblDescription.AutoEllipsis = true;
            lblDescription.Location = new Point(180, 38);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(440, 32);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Описание товара:";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(180, 74);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(98, 16);
            lblManufacturer.TabIndex = 3;
            lblManufacturer.Text = "Производитель:";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(180, 94);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(76, 16);
            lblSupplier.TabIndex = 4;
            lblSupplier.Text = "Поставщик:";
            // 
            // lblPriceLabel
            // 
            lblPriceLabel.AutoSize = true;
            lblPriceLabel.Location = new Point(180, 114);
            lblPriceLabel.Name = "lblPriceLabel";
            lblPriceLabel.Size = new Size(42, 16);
            lblPriceLabel.TabIndex = 5;
            lblPriceLabel.Text = "Цена: ";
            // 
            // lblOldPrice
            // 
            lblOldPrice.AutoSize = true;
            lblOldPrice.Font = new Font("Times New Roman", 10F, FontStyle.Strikeout);
            lblOldPrice.ForeColor = Color.Red;
            lblOldPrice.Location = new Point(225, 114);
            lblOldPrice.Name = "lblOldPrice";
            lblOldPrice.Size = new Size(56, 16);
            lblOldPrice.TabIndex = 6;
            lblOldPrice.Text = "OldPrice";
            // 
            // lblNewPrice
            // 
            lblNewPrice.AutoSize = true;
            lblNewPrice.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            lblNewPrice.Location = new Point(290, 114);
            lblNewPrice.Name = "lblNewPrice";
            lblNewPrice.Size = new Size(64, 17);
            lblNewPrice.TabIndex = 7;
            lblNewPrice.Text = "NewPrice";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(180, 134);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(124, 16);
            lblUnit.TabIndex = 8;
            lblUnit.Text = "Единица измерения:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(180, 154);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(139, 16);
            lblStock.TabIndex = 9;
            lblStock.Text = "Количество на складе:";
            // 
            // lblDiscount
            // 
            lblDiscount.Location = new Point(660, 15);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(120, 150);
            lblDiscount.TabIndex = 10;
            lblDiscount.Text = "Discount";
            lblDiscount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductCardTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblDiscount);
            Controls.Add(lblStock);
            Controls.Add(lblUnit);
            Controls.Add(lblNewPrice);
            Controls.Add(lblOldPrice);
            Controls.Add(lblPriceLabel);
            Controls.Add(lblSupplier);
            Controls.Add(lblManufacturer);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(pbPhoto);
            Cursor = Cursors.Hand;
            Font = new Font("Times New Roman", 10F);
            Margin = new Padding(10);
            Name = "ProductCardTemplate";
            Size = new Size(800, 180);
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public System.Windows.Forms.PictureBox pbPhoto;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.Label lblManufacturer;
        public System.Windows.Forms.Label lblSupplier;
        public System.Windows.Forms.Label lblPriceLabel;
        public System.Windows.Forms.Label lblOldPrice;
        public System.Windows.Forms.Label lblNewPrice;
        public System.Windows.Forms.Label lblUnit;
        public System.Windows.Forms.Label lblStock;
        public System.Windows.Forms.Label lblDiscount;
    }
}
