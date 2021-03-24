using DataObjescts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BusinessObjects.DataAccess
{
    public class OrderData
    {
        public bool AddOrder(Order o)
        {
            SqlParameter orderDate = new SqlParameter("@OrderDate", o.OrderDate);
            SqlParameter totalPrice = new SqlParameter("@TotalPrice", o.TotalPrice);
            SqlParameter note = new SqlParameter("@Note", o.Note);
            SqlParameter userID = new SqlParameter("@UserID", o.UserID);
            SqlParameter cusPhone = new SqlParameter("@CusPhone", o.CusPhone);
            SqlParameter status = new SqlParameter("@Status", o.Status);
            try
            {
                return DataProvider.ExecuteNonQuery("InsertOrder", orderDate, totalPrice, note, userID, cusPhone, status);
            }
            catch (SqlException)
            {
                return false;
            }
        }
        public bool DeleteOrder(string ID)
        {
            SqlParameter id = new SqlParameter("@OrderID", ID);
            try
            {
                return DataProvider.ExecuteNonQuery("DeteleOrder", id);
            }
            catch (SqlException)
            {
                return false;
            }
        }
        public List<Order> getAllOrder()
        {
            List<Order> list = null;
            try
            {
                SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader("GetAllOrder");
                while (rd.Read())
                {
                    int id = rd.GetInt32(0);
                    DateTime date = rd.GetDateTime(1);
                    float totalPrice = Convert.ToSingle(rd.GetDouble(2));
                    string note = rd.GetString(3);
                    string userID = rd.GetString(4);
                    string cusPhone = rd.GetString(5);
                    bool status = rd.GetBoolean(6);
                    Order o = new Order(id, date, totalPrice, note, userID, cusPhone, status);
                    if (list == null)
                    {
                        list = new List<Order>();
                    }
                    list.Add(o);
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
