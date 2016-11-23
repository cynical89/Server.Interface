using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Server.Interface
{
    public class Database
    {
        public static Func<Guid, int, DateTime, string, string> StartNewGame = NewGame;
        private static string queryText = string.Empty;
        // TODO: Add this string to a config file.
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["AuthContext"].ConnectionString;
        private static readonly SqlConnection myCon = new SqlConnection(connectionString);

        private static string NewGame(Guid id, int i, DateTime dt, string m)
        {
            queryText = "INSERT INTO dbo.Games (Id,Active,TimeAndDate,Map) VALUES (@val1, @val2, @val3, @val4)";
            using (var cmd = new SqlCommand(queryText, myCon))
            {
                cmd.Parameters.AddWithValue("@val1", id);
                cmd.Parameters.AddWithValue("@val2", i);
                cmd.Parameters.AddWithValue("@val3", dt);
                cmd.Parameters.AddWithValue("@val4", m);
                try
                {
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException err)
                {
                    // do something with the error
                    var error = err.Message;
                }
                finally
                {
                    myCon.Close();
                }
            }
            return id.ToString();
        }
    }
}
