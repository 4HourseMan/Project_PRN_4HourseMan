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
        public void AddProduct(Product p)
        {
            ProductData product = new ProductData();
            product.AddProduct(p);
        }
    }
}
