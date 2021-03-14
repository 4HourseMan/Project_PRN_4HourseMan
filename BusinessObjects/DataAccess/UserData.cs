using DataObjescts;
using System;
using System.Data.SqlClient;

namespace BusinessObjects.DataAccess
{
    public class UserData
    {
        public User CheckLogin(string UserID, string Password)
        {
            User user = null;
            SqlParameter UserIDParam = new SqlParameter("@UserID", UserID);
            SqlParameter PasswordParam = new SqlParameter("@Password", Password);

            SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader("CheckLogin", UserIDParam, PasswordParam);
            if (reader.Read())
            {
                user = new User(UserID, reader["UserName"].ToString(), reader["Email"].ToString(), reader["Address"].ToString(), reader["Phone"].ToString(), reader["RoleID"].ToString(), Password, reader.GetBoolean(7));
            }
            if (user != null)
            {
                Console.WriteLine("K null");
            }
            return user;
        }

        public bool InsertEmployee(User user)
        {
            bool check = false;
            SqlParameter UserIDParam = new SqlParameter("@UserID", user.UserID);
            SqlParameter UserNameParam = new SqlParameter("@UserName", user.UserName);
            SqlParameter AddressParam = new SqlParameter("@Address", user.Address);
            SqlParameter PhoneParam = new SqlParameter("@Phone", user.Phone);
            SqlParameter RoleIDParam = new SqlParameter("@RoleID", "EMP");
            SqlParameter PasswordParam = new SqlParameter("@Password", user.Password);
            SqlParameter EmailParam = new SqlParameter("@Email", user.Email);
            SqlParameter StatusParam = new SqlParameter("@Status", "true");
            check = DataProvider.ExecuteNonQuery("InsertEmployee", UserIDParam, UserNameParam, AddressParam, PhoneParam, RoleIDParam, PasswordParam, EmailParam, StatusParam);
            return check;
        }

        public bool UpdateEmployee(User user)
        {
            bool check = false;
            SqlParameter UserIDParam = new SqlParameter("@UserID", user.UserID);
            SqlParameter UserNameParam = new SqlParameter("@UserName", user.UserName);
            SqlParameter AddressParam = new SqlParameter("@Address", user.Address);
            SqlParameter PhoneParam = new SqlParameter("@Phone", user.Phone);
            SqlParameter RoleIDParam = new SqlParameter("@RoleID", "EMP");
            SqlParameter PasswordParam = new SqlParameter("@Password", user.Password);
            SqlParameter EmailParam = new SqlParameter("@Email", user.Email);
            SqlParameter StatusParam = new SqlParameter("@Status", "true");
            check = DataProvider.ExecuteNonQuery("UpdateEmployee", UserIDParam, UserNameParam, AddressParam, PhoneParam, RoleIDParam, PasswordParam, EmailParam, StatusParam);
            return check;
        }


        public bool DeleteEmployee(string UserID)
        {
            bool check = false;
            SqlParameter UserIDParam = new SqlParameter("@UserID", UserID);
            check = DataProvider.ExecuteNonQuery("DeleteEmployee", UserIDParam);
            return check;
        }
    }
}
