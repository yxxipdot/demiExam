namespace Деееееееееееееееееееееемо
{
    partial class ProductCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.discountPanel = new System.Windows.Forms.Panel();
            this.pisyunkiTLP = new System.Windows.Forms.TableLayoutPanel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.stockAmountLabel = new System.Windows.Forms.Label();
            this.cardPictureBox = new System.Windows.Forms.PictureBox();
            this.stockDataLabel = new System.Windows.Forms.Label();
            this.unitDataLabel = new System.Windows.Forms.Label();
            this.priceDataLabel = new System.Windows.Forms.Label();
            this.supplierDataLabel = new System.Windows.Forms.Label();
            this.manufacturerDataLabel = new System.Windows.Forms.Label();
            this.descDataLabel = new System.Windows.Forms.Label();
            this.headerDataLabel = new System.Windows.Forms.Label();
            this.pisyunkiTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // discountPanel
            // 
            this.discountPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.discountPanel.Location = new System.Drawing.Point(944, 0);
            this.discountPanel.Name = "discountPanel";
            this.discountPanel.Size = new System.Drawing.Size(205, 222);
            this.discountPanel.TabIndex = 1;
            // 
            // pisyunkiTLP
            // 
            this.pisyunkiTLP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pisyunkiTLP.ColumnCount = 2;
            this.pisyunkiTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pisyunkiTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pisyunkiTLP.Controls.Add(this.headerDataLabel, 1, 0);
            this.pisyunkiTLP.Controls.Add(this.headerLabel, 0, 0);
            this.pisyunkiTLP.Controls.Add(this.descLabel, 0, 1);
            this.pisyunkiTLP.Controls.Add(this.manufacturerLabel, 0, 2);
            this.pisyunkiTLP.Controls.Add(this.supplierLabel, 0, 3);
            this.pisyunkiTLP.Controls.Add(this.priceLabel, 0, 4);
            this.pisyunkiTLP.Controls.Add(this.unitLabel, 0, 5);
            this.pisyunkiTLP.Controls.Add(this.stockAmountLabel, 0, 6);
            this.pisyunkiTLP.Controls.Add(this.stockDataLabel, 1, 6);
            this.pisyunkiTLP.Controls.Add(this.unitDataLabel, 1, 5);
            this.pisyunkiTLP.Controls.Add(this.priceDataLabel, 1, 4);
            this.pisyunkiTLP.Controls.Add(this.supplierDataLabel, 1, 3);
            this.pisyunkiTLP.Controls.Add(this.manufacturerDataLabel, 1, 2);
            this.pisyunkiTLP.Controls.Add(this.descDataLabel, 1, 1);
            this.pisyunkiTLP.Location = new System.Drawing.Point(225, 3);
            this.pisyunkiTLP.Name = "pisyunkiTLP";
            this.pisyunkiTLP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pisyunkiTLP.RowCount = 7;
            this.pisyunkiTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pisyunkiTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pisyunkiTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pisyunkiTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pisyunkiTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pisyunkiTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pisyunkiTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pisyunkiTLP.Size = new System.Drawing.Size(713, 215);
            this.pisyunkiTLP.TabIndex = 3;
            this.pisyunkiTLP.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(3, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(258, 19);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Категория | Наименование товара";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descLabel.Location = new System.Drawing.Point(3, 30);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(134, 19);
            this.descLabel.TabIndex = 1;
            this.descLabel.Text = "Описание товара: ";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerLabel.Location = new System.Drawing.Point(3, 60);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(120, 19);
            this.manufacturerLabel.TabIndex = 2;
            this.manufacturerLabel.Text = "Производитель: ";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierLabel.Location = new System.Drawing.Point(3, 90);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(91, 19);
            this.supplierLabel.TabIndex = 3;
            this.supplierLabel.Text = "Поставщик: ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(3, 120);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(50, 19);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Цена: ";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitLabel.Location = new System.Drawing.Point(3, 150);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(152, 19);
            this.unitLabel.TabIndex = 5;
            this.unitLabel.Text = "Единица измерения: ";
            // 
            // stockAmountLabel
            // 
            this.stockAmountLabel.AutoSize = true;
            this.stockAmountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stockAmountLabel.Location = new System.Drawing.Point(3, 180);
            this.stockAmountLabel.Name = "stockAmountLabel";
            this.stockAmountLabel.Size = new System.Drawing.Size(164, 19);
            this.stockAmountLabel.TabIndex = 6;
            this.stockAmountLabel.Text = "Количество на складе: ";
            // 
            // cardPictureBox
            // 
            this.cardPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cardPictureBox.Location = new System.Drawing.Point(4, 3);
            this.cardPictureBox.Name = "cardPictureBox";
            this.cardPictureBox.Size = new System.Drawing.Size(215, 215);
            this.cardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPictureBox.TabIndex = 2;
            this.cardPictureBox.TabStop = false;
            // 
            // stockDataLabel
            // 
            this.stockDataLabel.AutoSize = true;
            this.stockDataLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stockDataLabel.Location = new System.Drawing.Point(359, 180);
            this.stockDataLabel.Name = "stockDataLabel";
            this.stockDataLabel.Size = new System.Drawing.Size(164, 19);
            this.stockDataLabel.TabIndex = 7;
            this.stockDataLabel.Text = "Количество на складе: ";
            // 
            // unitDataLabel
            // 
            this.unitDataLabel.AutoSize = true;
            this.unitDataLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitDataLabel.Location = new System.Drawing.Point(359, 150);
            this.unitDataLabel.Name = "unitDataLabel";
            this.unitDataLabel.Size = new System.Drawing.Size(152, 19);
            this.unitDataLabel.TabIndex = 8;
            this.unitDataLabel.Text = "Единица измерения: ";
            // 
            // priceDataLabel
            // 
            this.priceDataLabel.AutoSize = true;
            this.priceDataLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceDataLabel.Location = new System.Drawing.Point(359, 120);
            this.priceDataLabel.Name = "priceDataLabel";
            this.priceDataLabel.Size = new System.Drawing.Size(50, 19);
            this.priceDataLabel.TabIndex = 9;
            this.priceDataLabel.Text = "Цена: ";
            // 
            // supplierDataLabel
            // 
            this.supplierDataLabel.AutoSize = true;
            this.supplierDataLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierDataLabel.Location = new System.Drawing.Point(359, 90);
            this.supplierDataLabel.Name = "supplierDataLabel";
            this.supplierDataLabel.Size = new System.Drawing.Size(91, 19);
            this.supplierDataLabel.TabIndex = 10;
            this.supplierDataLabel.Text = "Поставщик: ";
            // 
            // manufacturerDataLabel
            // 
            this.manufacturerDataLabel.AutoSize = true;
            this.manufacturerDataLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerDataLabel.Location = new System.Drawing.Point(359, 60);
            this.manufacturerDataLabel.Name = "manufacturerDataLabel";
            this.manufacturerDataLabel.Size = new System.Drawing.Size(120, 19);
            this.manufacturerDataLabel.TabIndex = 11;
            this.manufacturerDataLabel.Text = "Производитель: ";
            // 
            // descDataLabel
            // 
            this.descDataLabel.AutoSize = true;
            this.descDataLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descDataLabel.Location = new System.Drawing.Point(359, 30);
            this.descDataLabel.Name = "descDataLabel";
            this.descDataLabel.Size = new System.Drawing.Size(134, 19);
            this.descDataLabel.TabIndex = 12;
            this.descDataLabel.Text = "Описание товара: ";
            // 
            // headerDataLabel
            // 
            this.headerDataLabel.AutoSize = true;
            this.headerDataLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerDataLabel.Location = new System.Drawing.Point(359, 0);
            this.headerDataLabel.Name = "headerDataLabel";
            this.headerDataLabel.Size = new System.Drawing.Size(258, 19);
            this.headerDataLabel.TabIndex = 13;
            this.headerDataLabel.Text = "Категория | Наименование товара";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardPictureBox);
            this.Controls.Add(this.pisyunkiTLP);
            this.Controls.Add(this.discountPanel);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(1149, 221);
            this.Load += new System.EventHandler(this.ProductCard_Load);
            this.pisyunkiTLP.ResumeLayout(false);
            this.pisyunkiTLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel discountPanel;
        private System.Windows.Forms.PictureBox cardPictureBox;
        private System.Windows.Forms.TableLayoutPanel pisyunkiTLP;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label stockAmountLabel;
        private System.Windows.Forms.Label headerDataLabel;
        private System.Windows.Forms.Label stockDataLabel;
        private System.Windows.Forms.Label unitDataLabel;
        private System.Windows.Forms.Label priceDataLabel;
        private System.Windows.Forms.Label supplierDataLabel;
        private System.Windows.Forms.Label manufacturerDataLabel;
        private System.Windows.Forms.Label descDataLabel;
    }
}
