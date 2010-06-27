using DAO;
namespace BUS
{
    public class ThamSoBUS
    {
        // Trả về true nếu số lượng sách nhập vào lớn hơn hoặc bằng
        // số lượng sách NN theo quy định được lưu trong db
        public static bool CheckSoLuongNhapNN (int soLuong) {
            if (soLuong < ThamSoDAO.GetSoLuongNhapNN()) 
                return false;
            return true;
        }
        // Kiểm tra nợ của một khách hàng (string) có thoả không
        public static bool CheckNoLN ( string tenKH) {
            decimal no = KhachHangDAO.GetNo(tenKH);
            if (no < ThamSoDAO.GetNoLN() ) {
                return true;
            }
            return false;
        }
        // Lấy lượng tồn tối đa để nhập một cuốn sách
        public static bool CheckLTNN (string tenSach, int luongXuat) {
            if ( (SachDAO.GetLuongTon(tenSach) - luongXuat) < ThamSoDAO.SoLuongTonNN())
                return false;
            return true;
        }
    }
}
