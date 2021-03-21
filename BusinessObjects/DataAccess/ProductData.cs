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
        public bool AddProduct(Product p)
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
                return DataProvider.ExecuteNonQuery("InsertProduct", id, name, cate, pri, quant, sup, date, status);
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool UpdateProduct(Product p)
        {
            SqlParameter id = new SqlParameter("@ProductID", p.ProductID);
            SqlParameter name = new SqlParameter("@ProductName", p.ProductName);
            SqlParameter cate = new SqlParameter("@CategoryID", p.CategoryID);
            SqlParameter pri = new SqlParameter("@Price", p.Price);
            SqlParameter quant = new SqlParameter("@Quantity", p.Quantity);
            SqlParameter sup = new SqlParameter("@SupplierID", p.SupplierID);

            try
            {
                return DataProvider.ExecuteNonQuery("UpdateProduct", id, name, cate, pri, quant, sup);
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool DeleteProduct(string ProductID)
        {
            SqlParameter id = new SqlParameter("@ProductID", ProductID);
            try
            {
                return DataProvider.ExecuteNonQuery("DeteleProduct", id);
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public List<Product> SearchProduct(String searchName, bool status)
        {
            SqlParameter name = new SqlParameter("@ProductName", searchName);
            List<Product> list = null;
            try
            {
                SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader("SearchProductByName", name);
                while (rd.Read())
                {
                    string id = rd.GetString(0);
                    string nameP = rd.GetString(1);
                    string cate = rd.GetString(2);
                    string sup = rd.GetString(5);
                    float price = Convert.ToSingle(rd.GetDouble(3));
                    int quant = rd.GetInt32(4);
                    DateTime date = rd.GetDateTime(6);
                    Product p = new Product(id, nameP, cate, sup, price, quant, date, status);
                    if (list == null)
                    {
                        list = new List<Product>();
                    }
                    list.Add(p);
                }
            }
            catch (SqlException)
            {
                return null;
            }
            return list;
        }
        public List<Category> getCategory()
        {
            List<Category> list = null;
            try
            {
                SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader("GetAllCategory");
                while (rd.Read())
                {
                    Category cate = new Category(rd.GetString(0), rd.GetString(1));
                    if (list == null)
                    {
                        list = new List<Category>();
                    }
                    list.Add(cate);
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
