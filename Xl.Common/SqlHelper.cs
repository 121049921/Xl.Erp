using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Xl.Common
{
    internal class SqlHelper
    {

        public static string GetSqlConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sqlConnection"].ToString();
        }
        //适合增删改操作，返回影响条数
        public static int ExecuteNonQuery(string sql, string connectionString = "", params SqlParameter[] parameters)
        {
            connectionString = !string.IsNullOrEmpty(connectionString) ? connectionString : GetSqlConnectionString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        comm.Parameters.AddRange(parameters);
                        return comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (conn != null && conn.State != ConnectionState.Closed)
                            conn.Close();
                    }

                }
            }
        }
        //查询操作，返回查询结果中的第一行第一列的值
        public static object ExecuteScalar(string sql, string connectionString = "", params SqlParameter[] parameters)
        {
            connectionString = !string.IsNullOrEmpty(connectionString) ? connectionString : GetSqlConnectionString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        comm.Parameters.AddRange(parameters);
                        return comm.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (conn != null && conn.State != ConnectionState.Closed)
                            conn.Close();
                    }
                }
            }
        }
        //Adapter调整，查询操作，返回DataTable
        public static DataTable ExecuteDataTable(string sql,string connectionString="", params SqlParameter[] parameters)
        {
            connectionString = !string.IsNullOrEmpty(connectionString) ? connectionString : GetSqlConnectionString();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString))
            {
                DataTable dt = new DataTable();
                if (parameters != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                }
                adapter.Fill(dt);
                return dt;
            }
        }

        public static SqlDataReader ExecuteReader(string sqlText, string connectionString="" ,params SqlParameter[] parameters)
        {
            //SqlDataReader要求，它读取数据的时候有，它独占它的SqlConnection对象，而且SqlConnection必须是Open状态
            connectionString = !string.IsNullOrEmpty(connectionString) ? connectionString : GetSqlConnectionString();
            SqlConnection conn = new SqlConnection(GetSqlConnectionString());//不要释放连接，因为后面还需要连接打开状态
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = sqlText;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }



}