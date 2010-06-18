using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using Presentation;

namespace QLNS
{
    static class Program
    {
        // Press ESC to close windows
        public class CloseWindowBehavior : IMessageFilter
        {

            const int WM_KEYDOWN = 0x100;
            const int VK_ESCAPE = 0x1B;

            bool IMessageFilter.PreFilterMessage(ref Message m)
            {
                if (m.Msg == WM_KEYDOWN && (int)m.WParam == VK_ESCAPE)
                {
                    if (Form.ActiveForm != null)
                    {
                        Form.ActiveForm.Close();
                    }
                    return true;
                }
                return false;
            }

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PhieuNhapSach());
        }
    }
}
