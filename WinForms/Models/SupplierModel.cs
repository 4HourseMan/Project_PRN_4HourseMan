using BusinessObjects;
using BusinessObjects.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using BusinessObjects.DataAccess;


namespace WinForms.Models
{
    public class SupplierModel : ISupplierModel
    {
        
        SupplierData data = new SupplierData();

        public bool DeleteSupplier(Supplier supplier)
        {
            return data.DeleteSupplier(supplier);
            
        }

        public List<Supplier> GetSuppliers()
        {
            return data.getSupplier();
        }

        public bool InsertSupplier(Supplier supplier)
        {
            return data.InsertSupplier(supplier);
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            return data.UpdateSupplier(supplier);
        }
        
    }

}
