using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class SachDAO : SQLConnection
    {
        // Them dau sach moi
        public bool InsertBook(DauSachDTO sach)
        {
            try
            {
                SqlConnection sqlConnection = MakeSQLConnect();

                #region Query
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO DAUSACH VALUES (@MaSach,@TenSach,@TheLoai,@TacGia,@LuongTon);", sqlConnection);

                // add parameters
                sqlCommand.Parameters.Add("@MaSach", SqlDbType.Text);
                sqlCommand.Parameters["@masach"].Value = sach.MaSach;
                sqlCommand.Parameters.Add("@TenSach", SqlDbType.Text);
                sqlCommand.Parameters["@tensach"].Value = sach.TenSach;
                sqlCommand.Parameters.Add("@TheLoai", SqlDbType.Text);
                sqlCommand.Parameters["@theloai"].Value = sach.TheLoai;
                sqlCommand.Parameters.Add("@TacGia", SqlDbType.Text);
                sqlCommand.Parameters["@tacgia"].Value = sach.TacGia;
                sqlCommand.Parameters.Add("@LuongTon", SqlDbType.Int);
                sqlCommand.Parameters["@luongton"].Value = sach.LuongTon;
                #endregion

                sqlConnection.Open();
                sqlCommand.ExecuteScalar();

                // Get rid what we create
                sqlCommand.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
                return true;
            }
            catch (Exception e)
            {
                // Do nothing
                return false;
            }
        }

        // Kiem tra mot dau sach co ton tai trong database hay khong
        public bool BooksHave(string tenSach)
        {
            try
            {
                SqlConnection sqlConnection = MakeSQLConnect();

                SqlCommand sqlCommand = new SqlCommand("SELECT MaSach from DAUSACH WHERE TenSach=@TenSach;");
                sqlCommand.Parameters.Add("@TenSach", SqlDbType.Text);
                sqlCommand.Parameters["@tensach"].Value = tenSach;

                sqlConnection.Open();
                int x = sqlCommand.ExecuteNonQuery();
                if (x != 0)
                    return true;
                // Get rid what we create
                sqlCommand.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
                return false;
            }
            catch (Exception e)
            {
                // Do nothing
                return false;
            }
        }

        // Cap nhat luong ton = luong ton cu + sach nhap vao
        public void UpdateLuongTon(int maSach, int luongNhap)
        {
            try
            {
                int lastLuongTon = 0;

                SqlConnection sqlConnection = MakeSQLConnect();
                sqlConnection.Open();
                #region Query
                // Lay luong ton de tinh toan luong ton cuoi
                SqlCommand sqlCommand = new SqlCommand("SELECT LuongTon from DAUSACH WHERE MaSach=@MaSach;");
                sqlCommand.Parameters.Add("@MaSach", SqlDbType.Text);
                sqlCommand.Parameters["@masach"].Value = maSach;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int luongTon = (int)sqlDataReader["LuongTon"];
                lastLuongTon = luongTon + luongNhap;

                // Update Luong Ton cho ma sach tuong ung
                sqlCommand.CommandText = "UPDATE DAUSACH SET LuongTon = @LuongTon WHERE MaSach = @MaSach";
                sqlCommand.Parameters.Add("@LuongTon", SqlDbType.Int);
                sqlCommand.Parameters["@luongton"].Value = lastLuongTon;

                sqlCommand.ExecuteNonQuery();
                #endregion

                sqlConnection.Open();
                sqlCommand.ExecuteScalar();

                // Get rid what we create
                sqlCommand.Dispose();
                sqlConnection.Close();
                sqlConnection.Dispose();
                return;
            }
            catch (Exception e)
            {
                // Do nothing
                return;
            }
        }
    }

}
