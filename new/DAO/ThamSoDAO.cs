using System;
using System.Data.SqlClient;

namespace DAO
{
    public class ThamSoDAO: SQLConnection
    {
        public ThamSoDAO() {
        }
        public int getSoLuongNhapNN() {
            int soLuong = 0;
            SqlConnection sqlConnection = MakeSQLConnect();
            
            #region Query
            var sqlCommand = new SqlCommand("SELECT LuongNhapNN FROM THAMSO;",sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataAdapter = sqlCommand.ExecuteReader();
            if (sqlDataAdapter.Read())
                soLuong = (int) sqlDataAdapter["LuongNhapNN"];
            #endregion

            // Get rid what we create
            sqlCommand.Dispose();
            sqlConnection.Close();
            sqlConnection.Dispose();
            return soLuong;
        }
        public static bool checkLuongNhapNhoNhatVaLuongTonLonNhat(int inSoLuongNNN, string tenSach) {
            SqlConnection sqlConnection = MakeSQLConnect();
            #region Thuc hien truy van
            if (sqlConnection != null){
                try {
                    // Mo ket noi
                    sqlConnection.Open();

                    // Tao query va lan luot lay SoLuongNhapNN va LuongTonLN tu THAMSO
                    SqlCommand sqlCommand = new SqlCommand("SELECT LuongNhapNN,LuongTonLN FROM THAMSO;",sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    // Lay du lieu tu data reader
                    int soLuongNNN = 0;
                    int luongTonLN = 0;
                    if (sqlDataReader.Read()) {
                        soLuongNNN = (int)sqlDataReader["LuongNhapNN"];
                        luongTonLN = (int)sqlDataReader["LuongTonLN"];
                    }
            #endregion

                    #region Kiem tra: So luong nhap NN va 
                    // Kiem So luong nhap nho nhat
                    if (inSoLuongNNN < soLuongNNN ) {
                        return false;
                    }
                    // Kiem tra lieu cuon sach co trong CSDL hay khogn
                    else {
                        sqlCommand.CommandText = "SELECT TenSach FROM DAUSACH;";
                        sqlCommand.Connection = sqlConnection;
                        sqlDataReader = sqlCommand.ExecuteReader();
                    }
                    #endregion

                    // Get rid what we create
                    sqlDataReader.Dispose();
                    sqlConnection.Close();
                    sqlConnection.Dispose();

                }
                catch(Exception e) {
                    
                }
                finally {

                }

                
            }
            return true;
        }
           
        
    }
}
