using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
    public class SQLConnection 
    {
        #region config
        public static string Server = @"NXQD-PC\SQLEXPRESS";
        public static string Username = "sa";
        public static string Password = "";
        public static string Database = "QLNS";

        public static string ConnectionString;
        #endregion

        public static SqlConnection MakeSQLConnect()
        {
            ConnectionString = "Data Source=" + Server + ";" +
                                 "User ID=" + Username + ";" +
                                 "Password=" + Password + ";" +
                                 "Initial Catalog=" + Database;

            var sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = ConnectionString;
                return sqlConnection;
            }
            catch (Exception e)
            {
                sqlConnection.Dispose(); // release sqlConnection resource

                // Create a (useful) error message
                string ErrorMessage = "A error occurred while trying to connect to the server.";
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Environment.NewLine;
                ErrorMessage += e.Message;

                // Show error message (this = the parent Form object)
                MessageBox.Show(ErrorMessage, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Stop here
                return null;
            }
        }
    }
}
