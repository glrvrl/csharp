namespace RecapProject1
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
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbbCatergory = new System.Windows.Forms.ComboBox();
            this.gbbSearchByName = new System.Windows.Forms.GroupBox();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.blbProductName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxCategory.SuspendLayout();
            this.gbbSearchByName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Controls.Add(this.cbbCatergory);
            this.gbxCategory.Location = new System.Drawing.Point(26, 27);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(406, 135);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Listele";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(29, 45);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategori";
            // 
            // cbbCatergory
            // 
            this.cbbCatergory.FormattingEnabled = true;
            this.cbbCatergory.Location = new System.Drawing.Point(96, 37);
            this.cbbCatergory.Name = "cbbCatergory";
            this.cbbCatergory.Size = new System.Drawing.Size(253, 21);
            this.cbbCatergory.TabIndex = 0;
            this.cbbCatergory.SelectedIndexChanged += new System.EventHandler(this.cbbCatergory_SelectedIndexChanged);
            // 
            // gbbSearchByName
            // 
            this.gbbSearchByName.Controls.Add(this.txbProductName);
            this.gbbSearchByName.Controls.Add(this.blbProductName);
            this.gbbSearchByName.Location = new System.Drawing.Point(448, 27);
            this.gbbSearchByName.Name = "gbbSearchByName";
            this.gbbSearchByName.Size = new System.Drawing.Size(432, 135);
            this.gbbSearchByName.TabIndex = 1;
            this.gbbSearchByName.TabStop = false;
            this.gbbSearchByName.Text = "Ürün adına göre ara";
            // 
            // txbProductName
            // 
            this.txbProductName.Location = new System.Drawing.Point(105, 38);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(179, 20);
            this.txbProductName.TabIndex = 1;
            this.txbProductName.TextChanged += new System.EventHandler(this.txbProductName_TextChanged);
            // 
            // blbProductName
            // 
            this.blbProductName.AutoSize = true;
            this.blbProductName.Location = new System.Drawing.Point(39, 45);
            this.blbProductName.Name = "blbProductName";
            this.blbProductName.Size = new System.Drawing.Size(51, 13);
            this.blbProductName.TabIndex = 0;
            this.blbProductName.Text = "Ürün Adı:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgwProducts
            // 
            this.dgwProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(26, 183);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(1019, 353);
            this.dgwProducts.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 570);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.gbbSearchByName);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Northwind";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbbSearchByName.ResumeLayout(false);
            this.gbbSearchByName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbbCatergory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbbSearchByName;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label blbProductName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgwProducts;
    }
}

