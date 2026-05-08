namespace demo
{
    partial class ProductForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.lblArticle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(154)))));
            this.btnSave.Location = new System.Drawing.Point(12, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(146, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 50);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Наименование";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Location = new System.Drawing.Point(12, 80);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 23);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 110);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Описание";
            this.txtDescription.Size = new System.Drawing.Size(200, 60);
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.Location = new System.Drawing.Point(12, 180);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(200, 23);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(12, 210);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PlaceholderText = "Поставщик";
            this.txtSupplier.Size = new System.Drawing.Size(200, 23);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(12, 240);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PlaceholderText = "Ед. изм.";
            this.txtUnit.Size = new System.Drawing.Size(200, 23);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(220, 50);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Цена";
            this.txtPrice.Size = new System.Drawing.Size(160, 23);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(220, 80);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PlaceholderText = "Скидка (%)";
            this.txtDiscount.Size = new System.Drawing.Size(160, 23);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(220, 110);
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "На складе";
            this.txtStock.Size = new System.Drawing.Size(160, 23);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(220, 150);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(160, 120);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 10;
            this.pbPhoto.TabStop = false;
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.Location = new System.Drawing.Point(220, 280);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(160, 23);
            this.btnChangePhoto.TabIndex = 11;
            this.btnChangePhoto.Text = "Изменить фото";
            this.btnChangePhoto.UseVisualStyleBackColor = true;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Location = new System.Drawing.Point(12, 20);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(56, 15);
            this.lblArticle.TabIndex = 12;
            this.lblArticle.Text = "Артикул: ";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lblArticle);
            this.Controls.Add(this.btnChangePhoto);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "ProductForm";
            this.Text = "Товар";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnChangePhoto;
        private System.Windows.Forms.Label lblArticle;
    }
}
