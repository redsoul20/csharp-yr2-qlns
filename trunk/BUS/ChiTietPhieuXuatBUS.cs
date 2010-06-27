using DAO;
using DTO;

namespace BUS
{
    public class ChiTietPhieuXuatBUS
    {
        public static void Insert (ChiTietPhieuXuatDTO phieuXuat) {
            ChiTietPhieuXuatDAO.Insert(phieuXuat);
        }
    }
}
