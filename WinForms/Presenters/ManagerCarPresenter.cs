using BusinessObjects;
using System;
using WinForms.Models;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class ManagerCarPresenter : Presenter<IManageCarView>
    {
        public ManagerCarPresenter(IManageCarView view) : base(view) { }
        public void AddProduct()
        {
            string ProductID = View.ProductID;
            string ProductName = View.ProductName1;
            string CategoryID = View.CategoryID;
            string SupplierID = View.SupplierID;
            float Price = View.Price;
            int Quantity = View.Quantity;
            DateTime CreateDate = DateTime.Now;
            Product p = new Product(ProductID, ProductName, CategoryID, SupplierID, Price, Quantity, CreateDate, true);
            ProductModel.AddProduct(p);
        }

    }
}
