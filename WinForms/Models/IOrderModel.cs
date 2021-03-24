using BusinessObjects;
using System.Collections.Generic;

namespace WinForms.Models
{
    public interface IOrderModel
    {
        bool AddOrder(Order o);
        bool DeleteOrder(string id);
        List<Order> GetAllOrder();
    }
}