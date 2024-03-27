namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txbStockAdd = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.txbQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbProductNameAdd = new System.Windows.Forms.TextBox();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxStockUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPriceUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 309);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(776, 129);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            this.dgwProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellContentClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(29, 9);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(306, 73);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Filtrele";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(71, 29);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(191, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(19, 37);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Location = new System.Drawing.Point(372, 9);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(308, 73);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Filtrele";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(24, 44);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(88, 37);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(156, 20);
            this.tbxProductName.TabIndex = 0;
            this.tbxProductName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnProductAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryAdd);
            this.gbxProductAdd.Controls.Add(this.lblCategoryAdd);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.txbStockAdd);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.txbQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.label2);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.label1);
            this.gbxProductAdd.Controls.Add(this.txbProductNameAdd);
            this.gbxProductAdd.Location = new System.Drawing.Point(30, 91);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(649, 103);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(443, 52);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(199, 32);
            this.btnProductAdd.TabIndex = 13;
            this.btnProductAdd.Text = "Ürün Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(492, 19);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(151, 21);
            this.cbxCategoryAdd.TabIndex = 12;
            this.cbxCategoryAdd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(440, 26);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryAdd.TabIndex = 11;
            this.lblCategoryAdd.Text = "Kategori";
            this.lblCategoryAdd.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(214, 26);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(60, 13);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Sok Miktarı";
            // 
            // txbStockAdd
            // 
            this.txbStockAdd.Location = new System.Drawing.Point(321, 19);
            this.txbStockAdd.Name = "txbStockAdd";
            this.txbStockAdd.Size = new System.Drawing.Size(73, 20);
            this.txbStockAdd.TabIndex = 8;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(214, 62);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(84, 13);
            this.lblQuantityPerUnit.TabIndex = 7;
            this.lblQuantityPerUnit.Text = "Paketteki Miktar";
            // 
            // txbQuantityPerUnitAdd
            // 
            this.txbQuantityPerUnitAdd.Location = new System.Drawing.Point(321, 55);
            this.txbQuantityPerUnitAdd.Name = "txbQuantityPerUnitAdd";
            this.txbQuantityPerUnitAdd.Size = new System.Drawing.Size(73, 20);
            this.txbQuantityPerUnitAdd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(70, 55);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(112, 20);
            this.tbxProductNameAdd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı";
            // 
            // txbProductNameAdd
            // 
            this.txbProductNameAdd.Location = new System.Drawing.Point(70, 19);
            this.txbProductNameAdd.Name = "txbProductNameAdd";
            this.txbProductNameAdd.Size = new System.Drawing.Size(112, 20);
            this.txbProductNameAdd.TabIndex = 2;
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.btnRemove);
            this.gbx.Controls.Add(this.btnProductUpdate);
            this.gbx.Controls.Add(this.cbxCategoryUpdate);
            this.gbx.Controls.Add(this.label3);
            this.gbx.Controls.Add(this.label4);
            this.gbx.Controls.Add(this.tbxStockUpdate);
            this.gbx.Controls.Add(this.label5);
            this.gbx.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.gbx.Controls.Add(this.label6);
            this.gbx.Controls.Add(this.tbxPriceUpdate);
            this.gbx.Controls.Add(this.label7);
            this.gbx.Controls.Add(this.tbxProductNameUpdate);
            this.gbx.Location = new System.Drawing.Point(31, 200);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(649, 103);
            this.gbx.TabIndex = 4;
            this.gbx.TabStop = false;
            this.gbx.Text = "Ürün Güncelle";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(557, 52);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(84, 32);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(443, 52);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(84, 32);
            this.btnProductUpdate.TabIndex = 13;
            this.btnProductUpdate.Text = "Güncelle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(492, 19);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(151, 21);
            this.cbxCategoryUpdate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sok Miktarı";
            // 
            // tbxStockUpdate
            // 
            this.tbxStockUpdate.Location = new System.Drawing.Point(321, 19);
            this.tbxStockUpdate.Name = "tbxStockUpdate";
            this.tbxStockUpdate.Size = new System.Drawing.Size(73, 20);
            this.tbxStockUpdate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Paketteki Miktar";
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(321, 55);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(73, 20);
            this.tbxQuantityPerUnitUpdate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ürün Fiyatı";
            // 
            // tbxPriceUpdate
            // 
            this.tbxPriceUpdate.Location = new System.Drawing.Point(70, 55);
            this.tbxPriceUpdate.Name = "tbxPriceUpdate";
            this.tbxPriceUpdate.Size = new System.Drawing.Size(112, 20);
            this.tbxPriceUpdate.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ürün Adı";
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(70, 19);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(112, 20);
            this.tbxProductNameUpdate.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.BindingSource bsProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txbStockAdd;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.TextBox txbQuantityPerUnitAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbProductNameAdd;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxStockUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPriceUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

