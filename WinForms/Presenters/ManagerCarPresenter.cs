using BusinessObjects;
using System;
using System.Collections.Generic;
using WinForms.Models;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class ManagerCarPresenter : Presenter<IManageCarView>
    {
        public ManagerCarPresenter(IManageCarView view) : base(view) { }
        public bool AddProduct()
        {
            string ProductID = View.ProductID;
            string ProductName = View.ProductName1;
            string CategoryID = View.CategoryID;
            string SupplierID = View.SupplierID;
            float Price = View.Price;
            int Quantity = View.Quantity;
            DateTime CreateDate = DateTime.Now;
            Product p = new Product(ProductID, ProductName, CategoryID, SupplierID, Price, Quantity, CreateDate, true);
            return ProductModel.AddProduct(p);
        }

        public List<Product> SearchProduct()
        {
            string ProductName = "%" + View.SearchName + "%";
            if (ProductName == null)
            {
                ProductName = "%%";
            }
            return ProductModel.SearchProduct(ProductName, true);
        }
    }
}
