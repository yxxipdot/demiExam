using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace demo
{
    public static class DatabaseContext
    {
        private static string connectionString = "Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Trade;Integrated Security=True;Encrypt=False"; 
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    try
                    {
                        conn.Open();
                        adapter.Fill(dt);
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }
    }

    public static class CurrentUser
    {
        public static int UserID { get; set; } = 0;
        public static string Role { get; set; } = "Гость";
        public static string FIO { get; set; } = "";
    }
}
