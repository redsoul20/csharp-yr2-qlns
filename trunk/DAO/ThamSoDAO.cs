using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
    public class ThamSoDAO: SQLConnection
    {
       
       public ThamSoDAO() {
           SqlConnection sqlConnection = SQLConnect();
       }

        
    }
}
