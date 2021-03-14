using DataObjescts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DataAccess
{
    public class ProductData
    {
        public void AddProduct(Product p)
        {
            SqlParameter id = new SqlParameter("@ProductID", p.ProductID);
            SqlParameter name = new SqlParameter("@ProductName", p.ProductName);
            SqlParameter cate = new SqlParameter("@CategoryID", p.CategoryID);
            SqlParameter pri = new SqlParameter("@Price", p.Price);
            SqlParameter quant = new SqlParameter("@Quantity", p.Quantity);
            SqlParameter sup = new SqlParameter("@SupplierID", p.SupplierID);
            SqlParameter date = new SqlParameter("@CreateDate", p.CreateDate);
            SqlParameter status = new SqlParameter("@Status", p.Status);
            try
            {
                DataProvider.ExecuteNonQuery("InsertProduct", id, name, cate, pri, quant, sup, date, status);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
        }
    }
}
