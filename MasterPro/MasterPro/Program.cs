using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterPro.Dlg;
namespace MasterPro
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginDlg loginDlg = new LoginDlg();
            loginDlg.StartPosition = FormStartPosition.CenterScreen;
            loginDlg.ShowDialog();


            if (loginDlg.DialogResult == DialogResult.OK)
            {
                Application.Run(new TutorDlg(loginDlg.id, loginDlg.select));
                loginDlg.Dispose();
            }
        }
    }
}
