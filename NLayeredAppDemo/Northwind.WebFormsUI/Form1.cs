using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using Exception = System.Exception;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        ICategoryService _categoryService;
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadProducts();
            LoadCategories();

        }

        private void LoadCategories()
        {
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
            cbxCategory.DataSource = _categoryService.GetAll();

            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";
            cbxCategoryAdd.DataSource = _categoryService.GetAll();

            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //throw;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbxProductName.Text))
                {
                    dgwProduct.DataSource = _productService.GetProductsByName(tbxProductName.Text);
                }
                else
                {
                    LoadProducts();
                }
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product()
                    {
                        ProductName = txbProductNameAdd.Text,
                        CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                        QuantityPerUnit = txbQuantityPerUnitAdd.Text,
                        UnitPrice = Convert.ToDecimal(tbxProductNameAdd.Text),
                        UnitsInStock = Convert.ToInt16(txbStockAdd.Text)
                    }
                );
                LoadProducts();
                MessageBox.Show("Ürün eklendi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProduct.CurrentRow != null)
                {
                                _productService.Update(new Product()
                                {
                                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                                    ProductName = tbxProductNameUpdate.Text,
                                    CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                                    QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                                    UnitPrice = Convert.ToDecimal(tbxPriceUpdate.Text),
                                    UnitsInStock = Convert.ToInt16(tbxStockUpdate.Text)
                                });
                            LoadProducts();
                            MessageBox.Show("Ürün güncellendi");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            

        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
            if (dgwProduct.CurrentRow != null)
            {
                var row = dgwProduct.CurrentRow.Cells;
                tbxProductNameUpdate.Text = row[1].Value.ToString();

                cbxCategoryUpdate.SelectedValue = row[2].Value;//Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                tbxQuantityPerUnitUpdate.Text = row[4].Value.ToString();
                tbxPriceUpdate.Text = row[3].Value.ToString();
                tbxStockUpdate.Text = row[5].Value.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                _productService.Delete(new Product()
                    { ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value) });
                LoadProducts();
                MessageBox.Show("Ürün silindi");
            }

        }
    }
}
