using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Models
{
    public interface ISupplierModel
    {
        bool InsertSupplier(Supplier supplier);

        bool UpdateSupplier(Supplier supplier);

        bool DeleteSupplier(Supplier supplier);

        List<Supplier> GetAllSuppliers();

        Supplier GetSupplier(string SupplierID);
    }
}
