using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductDirector productDirector = new ProductDirector();
            var builder = new NewCustomerBuilder(); 
            productDirector.GeneretaProduct(builder);
            var model = builder.GetModel();
            Console.WriteLine(model.Id);
            Console.WriteLine(model.ProductName);
            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.DiscountApplied);
            Console.WriteLine(model.UnitPrice);
            Console.WriteLine(model.DiscountedPrice);

        }
    }

    class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }   
    }

    abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel();
    }


    class NewCustomerBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnitPrice * (decimal)0.90;
            model.DiscountApplied = true;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id= 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Çay";
            model.UnitPrice = 20;
        }
    }

    class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();

        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnitPrice;
            model.DiscountApplied = false;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Çay";
            model.UnitPrice = 20;
        }
    }

    class ProductDirector
    {
        public void GeneretaProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.ApplyDiscount();
            
        }
    }

}
