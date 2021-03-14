using System;
using System.Data;
using System.Data.SqlClient;

namespace DataObjescts
{
    public class DataProvider
    {
        public static string getConnectionString()
        {
            //String sv = "LAPTOP-O2NIN5I6\\SQLEXPRESS";
            //String uid = "hienPro";
            //String pwd = "hien12345";
            String sv = "DESKTOP-DLMULPB";
            String uid = "sa";
            String pwd = "tam";
            string strConnection = "server=" + sv + ";database=ThisGonnaBeTheBest;uid=" + uid + ";pwd=" + pwd;
            return strConnection;
        }

        //Execute Query
        public static DataSet ExecuteQueryWithDataSet(
            string cmdText,
            params SqlParameter[] param)
        {
            SqlConnection cnn = new SqlConnection(getConnectionString());
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = cmdText;
            cmd.Parameters.AddRange(param);
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static SqlDataReader ExecuteQueryWithDataReader(string cmdText, params SqlParameter[] param)
        {
            SqlDataReader rd = null;
            SqlConnection cnn = new SqlConnection(getConnectionString());
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = cmdText;
            cmd.Parameters.AddRange(param);
            cmd.Connection = cnn;
            try
            {
                cnn.Open();
                rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
            return rd;
        }
        //ExecuteNonQuery
        public static bool ExecuteNonQuery(string cmdText, params SqlParameter[] paramList)
        {
            bool result = false;
            SqlConnection cnn = new SqlConnection(getConnectionString());
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = cmdText;
            cmd.Parameters.AddRange(paramList);
            cmd.Connection = cnn;
            try
            {
                cnn.Open();
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return result;
        }

        public static int ExecuteNonQueryLastInsertedId(string cmdText, params SqlParameter[] paramList)
        {
            int result = 0;
            SqlConnection cnn = new SqlConnection(getConnectionString());
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = cmdText;
            cmd.Parameters.AddRange(paramList);
            cmd.Connection = cnn;
            try
            {
                cnn.Open();
                result = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return result;
        }
    }
}
