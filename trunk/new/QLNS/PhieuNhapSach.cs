using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PhieuNhapSach : Form
    {
        public PhieuNhapSach()
        {
            /* ---------------------------------------
             *  update > Sach, the loai, tac gia, so lg
             *  if tensach khong co
             *      tao sach
             *  else
             *  if (Kiem tra SoLuongNhap NN 
             * va dau sach co luong ton LN )
             *      Kiem tra sach da co 
             *           nhap so luong
             *      else nhap mot cuon sach ( ... )

               --------------------------------------- */
            InitializeComponent();

        }



        // Neu click bo thi don gian dong form
        private void btnBo_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            try {
                int rowCount = PhieuNhapGrid.Rows.Count; // Number of row of the grid
                for (int i = 0; i < rowCount; i++) {
                }
            }
            catch (Exception) {
                
                throw;
            }
        }
    }
}
