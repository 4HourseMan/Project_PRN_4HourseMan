using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models
{
    public interface IProductModel
    {
        bool AddProduct(Product p);
        bool DeleteProduct(String id);
        bool UpdateProduct(Product p);
        List<Product> SearchProduct(String name, bool status);
    }
}
