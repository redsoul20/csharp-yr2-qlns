using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLNS {
    public partial class HoaDonBanSach : Form {
        public HoaDonBanSach() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
        }

        private void Button1Click(object sender, EventArgs e) {
            // pseudo code
            // get ten KhachHang > tim no  >> GetNoByKhachHangName >> KHACHHANG
            // Nếu là khách hàng mới thì tạo khách hàng và cho qua
            // if no ko thoả > ko lập phiếu >> GetNoLN >> THAMSO
            // Duyệt từng rows
            // nếu thoả > kiểm tra số lượng sách sau khi tồn có thoả ko >> GetSoLuongSachTonLN >> THAMSO
            // tạo biến tính tiền
            // Lập CHITIETPHIEUBAN >> trừ số lượng sách > Update Lượng tồn [ Đã có ]
            // Lấy giá bán x Số lượng sách
            // Cộng thêm nợ cho khách
            // Update thành tiền > PHIEUBAN

            string tenKH = hoTen.Text;
            int khachHangID = KhachHangBUS.GetKhachHangID(tenKH);
            if (khachHangID != 0) {
                if (ThamSoBUS.CheckNoLN(tenKH)) {
                    int rowCount = PhieuNhapGrid.Rows.Count;
                    bool hasPhieuXuat = false;
                    string msg = "";
                    decimal sum = 0; // Tổng tiền mua của khách hàng, để cập nhật vào nợ
                    for (int i = 0; i < rowCount; ++i) {
                        var sachNhap = new SachNhapDTO();
                        DataGridViewCellCollection cell = PhieuNhapGrid.Rows[i].Cells;
                        bool data = true; // Kiểm tra coi dữ liệu một row đã được nhập đủ chưa
                        for (int j = 1; j < cell.Count; j++)
                            if (cell[i].Value == null) {
                                data = false;
                                break;
                            }
                        if (data) {
                            sachNhap.STT = Int32.Parse(cell[0].Value.ToString()); // STT
                            sachNhap.TenSach = cell[1].Value.ToString(); // Ten sach
                            sachNhap.TacGia = cell[3].Value.ToString(); // TacGia
                            sachNhap.TheLoai = cell[2].Value.ToString(); // The Loai 
                            sachNhap.SoLuong = Int32.Parse(cell[4].Value.ToString()); // SoLuong Xuat
                            sachNhap.DonGia = Decimal.Parse(cell[5].Value.ToString()); // DonGia

                            // Kiểm tra lượng sách tồn sau khi nhập có đúng như quy định không)
                            if (ThamSoBUS.CheckLTNN(sachNhap.TenSach, sachNhap.SoLuong)) {
                                var phieuXuat = new PhieuXuatDTO {
                                                                     NgayXuat = ngayLap.Value,
                                                                     MaKH = khachHangID,
                                                                 };

                                // We use another hasPhieuNhap bool to make sure
                                // we only check phieuNhap in database one time
                                int phieuXuatID = PhieuXuatBUS.CheckPhieuXuat(khachHangID, ngayLap.Value);
                                if (!hasPhieuXuat)
                                    if (phieuXuatID != 0)
                                        hasPhieuXuat = true;
                                    else {
                                        phieuXuatID = PhieuXuatBUS.Insert(phieuXuat);
                                    }
                                int sachID = DauSachBUS.CheckBook(sachNhap.TenSach);
                                if (sachID == 0) {
                                    msg += "Sách " + sachNhap.TenSach + " không tồn tại trong kho hàng + \n";
                                }
                                else {
                                    // Lập phiếu chi tiết nhập sách
                                    var chiTietPhieuXuat = new ChiTietPhieuXuatDTO {
                                                                                       DonGia = sachNhap.DonGia,
                                                                                       MaSach = sachID,
                                                                                       SoLuong = sachNhap.SoLuong,
                                                                                       MaPhieuXuat = phieuXuatID
                                                                                   };

                                    ChiTietPhieuXuatBUS.Insert(chiTietPhieuXuat);
                                    // + tiền
                                    sum += sachNhap.DonGia*sachNhap.SoLuong;
                                    // Update lại lượng tồn
                                    int luongTon = DauSachBUS.GetLuongTon(sachNhap.TenSach);
                                    DauSachBUS.UpdateLuongTon(sachNhap.TenSach, luongTon - sachNhap.SoLuong);
                                }
                            }
                        }
                    }
                    // Cập nhật nợ
                    KhachHangBUS.UpdateNo(khachHangID, sum);
                }
            }
            else {
                // tạo form tạo khách hàng mới
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            PhieuNhapGrid.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }
    }
}