using DataObjescts;
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
            return user;
        }
    }
}
