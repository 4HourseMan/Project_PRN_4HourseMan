using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Views
{
    public interface IManagerCarView : IView
    {
        string ProductID { get; }
        string ProductName { get; }
        string CategoryID { get; }
        float Price { get; }
        int Quantity { get; }
        string SupplierID { get; }
        DateTime CreateDate { get; }
        bool Status { get; }
    }
}
