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
        public List<Supplier> getSupplier()
        {
            List<Supplier> list = null;
            try
            {
                SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader("GetAllSupplier");
                while (rd.Read())
                {
                    Supplier sup = new Supplier(rd.GetString(0), rd.GetString(1), rd.GetString(2), true);
                    if (list == null)
                    {
                        list = new List<Supplier>();
                    }
                    list.Add(sup);
                }
            }
            catch (SqlException)
            {
                return null;
            }
            return list;
        }
    }
}
