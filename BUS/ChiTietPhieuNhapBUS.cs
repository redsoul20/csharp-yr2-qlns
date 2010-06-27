using DAO;
using DTO;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        public static int Insert(ChiTietPhieuNhapDTO chiTietPN) {
            return ChiTietPhieuNhapDAO.InsertChiTietPhieuNhap(chiTietPN);
        }
    }
}
