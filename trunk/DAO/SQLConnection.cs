using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
    public class SQLConnection
    {
        #region config
        private string Server = @"NXQD-PC\SQLEXPRESS";
        private string Username = "sa";
        private string Password = "";
        private string Database = "QLNS";

        private string ConnectionString;
        #endregion

        public SqlConnection SQLConnect()
        {
            ConnectionString = "Data Source=" + Server + ";" +
                                 "User ID=" + Username + ";" +
                                 "Password=" + Password + ";" +
                                 "Initial Catalog=" + Database;

            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = ConnectionString;
                return sqlConnection;
            }
            catch (Exception e)
            {
                if (sqlConnection != null)
                    sqlConnection.Dispose(); // release sqlConnection resource

                // Create a (useful) error message
                string ErrorMessage = "A error occurred while trying to connect to the server.";
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Environment.NewLine;
                ErrorMessage += e.Message;

                // Show error message (this = the parent Form object)
                MessageBox.Show((IWin32Window)this, ErrorMessage, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Stop here
                return null;
            }
        }
    }
}
