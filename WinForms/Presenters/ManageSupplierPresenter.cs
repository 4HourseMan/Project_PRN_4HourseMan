using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Views;
using WinForms.Models;
using BusinessObjects;

namespace WinForms.Presenters
{
    class ManageSupplierPresenter : Presenter<ISupplierView> 
    {
        public ManageSupplierPresenter(ISupplierView view) : base(view) { }

        public bool InsertSupplier()
        {
            string SupplierID = View.SupID;
            string SupplierName = View.SupName;
            string SupplierOrigin = View.Origin;
            bool SupplierStatus = true;

            Supplier sup = new Supplier(SupplierID,SupplierName,SupplierOrigin,SupplierStatus);
            return SupplierModel.InsertSupplier(sup);
        } 
    }
}
