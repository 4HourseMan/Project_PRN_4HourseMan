using BusinessObjects;
using BusinessObjects.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models
{
    public class ProductModel : IProductModel
    {
        public bool AddProduct(Product p)
        {
            ProductData product = new ProductData();
            return product.AddProduct(p);
        }

        public bool DeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchProduct(string name, bool status)
        {
            ProductData product = new ProductData();
            return product.SearchProduct(name, status);
        }

        public bool UpdateProduct(Product p)
        {
            ProductData product = new ProductData();
            return product.UpdateProduct(p);
        }

    }
}
