using DataObjescts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DataAccess
{
    public class SupplierData
    {
        public bool InsertSupplier(Supplier supplier)
        {
            bool res = false;
            SqlParameter SupplierIDParam = new SqlParameter("@SupplierID", supplier.SupID);
            SqlParameter SupplierNameParam = new SqlParameter("@SupplierName", supplier.SupName);
            SqlParameter SupplierOriginParam = new SqlParameter("@Origin", supplier.Origin);
            SqlParameter SupplierStatusParam = new SqlParameter("@Status", supplier.Status);

            res = DataProvider.ExecuteNonQuery("InsertSupplier", SupplierIDParam, SupplierNameParam, SupplierOriginParam, SupplierStatusParam);

            return res;
        }
        public bool UpdateSupplier(Supplier supplier)
        {
            bool res = false;
            SqlParameter SupplierIDParam = new SqlParameter("@SupplierID", supplier.SupID);
            SqlParameter SupplierNameParam = new SqlParameter("@SupplierName", supplier.SupName);
            SqlParameter SupplierOriginParam = new SqlParameter("@Origin", supplier.Origin);
            SqlParameter SupplierStatusParam = new SqlParameter("@Status", supplier.Status);

            res = DataProvider.ExecuteNonQuery("UpdateSupplier", SupplierIDParam, SupplierNameParam, SupplierOriginParam, SupplierStatusParam);

            return res;
        }
        public bool DeleteSupplier(Supplier supplier)
        {
            bool res = false;
            SqlParameter SupplierIDParam = new SqlParameter("@SupplierID", supplier.SupID);          

            res = DataProvider.ExecuteNonQuery("DeleteSupplier", SupplierIDParam);

            return res;
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> list = new List<Supplier>();
            SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader("GetAllSupplier");
            while (reader.Read())
            {
                list.Add(new Supplier(reader["SupplierID"].ToString(), reader["SupplierName"].ToString(), reader["Origin"].ToString(), (bool)reader["Status"]));
            }
            return list;
        }

        public Supplier GetSupplier(string SupplierID)
        {
            Supplier sup=null;
            SqlParameter SupplierIDParam = new SqlParameter("@SupplierID", SupplierID);
            SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader("GetSupplier", SupplierIDParam);

            if (reader.Read())
            {
                sup = new Supplier(SupplierID, reader["SupplierName"].ToString(), reader["Origin"].ToString(),(bool)reader["Status"]);
            }

            return sup;
        }
    }
}
