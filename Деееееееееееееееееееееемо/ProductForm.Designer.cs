namespace Деееееееееееееееееееееемо
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.exitRegFormButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pTop = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pTools = new System.Windows.Forms.Panel();
            this.remainingComboBox = new System.Windows.Forms.ComboBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.ComboBox();
            this.remainingProductLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pTop.SuspendLayout();
            this.pTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitRegFormButton
            // 
            this.exitRegFormButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exitRegFormButton.Location = new System.Drawing.Point(1113, 11);
            this.exitRegFormButton.Name = "exitRegFormButton";
            this.exitRegFormButton.Size = new System.Drawing.Size(75, 30);
            this.exitRegFormButton.TabIndex = 0;
            this.exitRegFormButton.Text = "Выйти";
            this.exitRegFormButton.UseVisualStyleBackColor = true;
            this.exitRegFormButton.Click += new System.EventHandler(this.exitRegFormButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 116);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1200, 542);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список товаров";
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userLabel.Location = new System.Drawing.Point(914, 17);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(180, 19);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Пользователь: ";
            // 
            // supplierLabel
            // 
            this.supplierLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(270, 22);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(84, 19);
            this.supplierLabel.TabIndex = 0;
            this.supplierLabel.Text = "Поставщик";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(26, 22);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(51, 19);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Поиск";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pTop);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exitRegFormButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 59);
            this.panel1.TabIndex = 3;
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.userNameLabel);
            this.pTop.Controls.Add(this.label4);
            this.pTop.Controls.Add(this.label5);
            this.pTop.Controls.Add(this.button1);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1200, 59);
            this.pTop.TabIndex = 4;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userNameLabel.Location = new System.Drawing.Point(813, 17);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(294, 19);
            this.userNameLabel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.Location = new System.Drawing.Point(699, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Пользователь: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Список товаров";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(1113, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exitProdFormButton_Click);
            // 
            // pTools
            // 
            this.pTools.Controls.Add(this.remainingComboBox);
            this.pTools.Controls.Add(this.supplierComboBox);
            this.pTools.Controls.Add(this.searchTextBox);
            this.pTools.Controls.Add(this.remainingProductLabel);
            this.pTools.Controls.Add(this.searchLabel);
            this.pTools.Controls.Add(this.supplierLabel);
            this.pTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTools.Location = new System.Drawing.Point(0, 59);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(1200, 59);
            this.pTools.TabIndex = 4;
            // 
            // remainingComboBox
            // 
            this.remainingComboBox.FormattingEnabled = true;
            this.remainingComboBox.Location = new System.Drawing.Point(631, 18);
            this.remainingComboBox.Name = "remainingComboBox";
            this.remainingComboBox.Size = new System.Drawing.Size(121, 27);
            this.remainingComboBox.TabIndex = 8;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(376, 18);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(121, 27);
            this.supplierComboBox.TabIndex = 7;
            // 
            // searchTextBox
            // 
            this.searchTextBox.FormattingEnabled = true;
            this.searchTextBox.Location = new System.Drawing.Point(93, 18);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(121, 27);
            this.searchTextBox.TabIndex = 6;
            // 
            // remainingProductLabel
            // 
            this.remainingProductLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remainingProductLabel.AutoSize = true;
            this.remainingProductLabel.Location = new System.Drawing.Point(550, 21);
            this.remainingProductLabel.Name = "remainingProductLabel";
            this.remainingProductLabel.Size = new System.Drawing.Size(64, 19);
            this.remainingProductLabel.TabIndex = 2;
            this.remainingProductLabel.Text = "Остаток";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.pTools);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.ProdForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.pTools.ResumeLayout(false);
            this.pTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitRegFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pTools;
        private System.Windows.Forms.Label remainingProductLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.ComboBox remainingComboBox;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.ComboBox searchTextBox;
    }
}