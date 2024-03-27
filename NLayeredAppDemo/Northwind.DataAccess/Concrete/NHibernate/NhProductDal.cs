using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal:IProductDal
    {

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    CategoryId = 1,
                    ProductId = 1,
                    ProductName = "Laptop",
                    QuantityPerUnit = "1 in a box",
                    UnitPrice = 2500,
                    UnitsInStock = 12
                }
            };

            return products;
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }


    }
}
