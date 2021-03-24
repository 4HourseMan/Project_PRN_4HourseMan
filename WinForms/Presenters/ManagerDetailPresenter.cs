using BusinessObjects;
using System.Collections.Generic;
using WinForms.Views;

namespace WinForms.Presenters
{
    public class ManagerDetailPresenter : Presenter<IDetailOrderView>
    {
        public ManagerDetailPresenter(IDetailOrderView view) : base(view)
        {
        }

        public bool AddDetail()
        {
            int OrderID = View.OrderID;
            string ProductID = View.ProductID;
            int Quantity = View.Quantity;
            float Price = View.Price;
            BusinessObjects.OrderDetail d = new BusinessObjects.OrderDetail(1, OrderID, ProductID, Quantity, Price);
            return DetailModel.AddDetail(d);
        }

        public List<BusinessObjects.OrderDetail> GetDetail()
        {
            int OrderID = View.OrderID;
            return DetailModel.GetDetail(OrderID);
        }
    }
}