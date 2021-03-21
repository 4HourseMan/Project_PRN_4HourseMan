using System;
using WinForms.Views;
using WinForms.Models;
using BusinessObjects;
using WinForms.Presenters;
using System.Collections.Generic;

public class ManageSupplierPresenter : Presenter<ISupplierView>
{
    public ManageSupplierPresenter(ISupplierView view) : base(view) { }

    public bool InsertSupplier()
    {
        string SupplierID = View.SupID;
        string SupplierName = View.SupName;
        string SupplierOrigin = View.Origin;
        bool SupplierStatus = true;

        Supplier sup = new Supplier(SupplierID, SupplierName, SupplierOrigin, SupplierStatus);
        return SupplierModel.InsertSupplier(sup);
    }

    public bool DeleteSupplier()
    {
        string SupplierID = View.SupID;
        string SupplierName = View.SupName;
        string SupplierOrigin = View.Origin;
        bool SupplierStatus = true;

        Supplier sup = new Supplier(SupplierID, SupplierName, SupplierOrigin, SupplierStatus);
        return SupplierModel.DeleteSupplier(sup);
    }

    public bool UpdateSupplier()
    {
        string SupplierID = View.SupID;
        string SupplierName = View.SupName;
        string SupplierOrigin = View.Origin;
        bool SupplierStatus = true;

        Supplier sup = new Supplier(SupplierID, SupplierName, SupplierOrigin, SupplierStatus);
        return SupplierModel.UpdateSupplier(sup);
    }

    public List<Supplier> GetSuppliers()
    {
        return SupplierModel.GetSuppliers();
    }

}

