using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.ToList();
            }
        }

        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbbCatergory.DataSource = context.Categories.ToList();
                cbbCatergory.DisplayMember = "CategoryName";
                cbbCatergory.ValueMember = "CategoryId";
            }
        }

        private void cbbCatergory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategoryAndName(Convert.ToInt32(cbbCatergory.SelectedValue),txbProductName.Text);
                //ListProductsByCategroy(Convert.ToInt32(cbbCatergory.SelectedValue));
            }
            catch
            {

            }
            
        }

        private void ListProductsByCategroy(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.Where(p=>p.CategoryId==categoryId).ToList();
            }
        }

        private void ListProductsByName(string productName)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.Where(p => p.ProductName.Contains(productName)).ToList();
            }
        }

        private void txbProductName_TextChanged(object sender, EventArgs e)
        {
            //ListProductsByName(txbProductName.Text);
            if(string.IsNullOrEmpty(txbProductName.Text))
            {
                ListProducts();
            } else
            {
                ListProductsByCategoryAndName(Convert.ToInt32(cbbCatergory.SelectedValue), txbProductName.Text);
            }
            
        }
        //

        private void ListProductsByCategoryAndName(int categoryId, string productName)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                if (string.IsNullOrEmpty(productName))
                {
                    ListProductsByCategroy(categoryId);//dgwProducts.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
                }
                    
                else {
                    try
                    {
                        dgwProducts.DataSource = context.Products.Where(p => p.CategoryId == categoryId).Where(p=>p.ProductName.Contains(productName)).ToList();
                        //ListProductsByCategoryAndName(categoryId, productName);
                        //ListProductsByCategroy(categoryId);
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
