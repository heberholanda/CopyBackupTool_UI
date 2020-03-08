using CopyBackupToolUI;
using System;
using System.Windows.Forms;

namespace CopyBackupToolUI_NS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Painel());
        }
    }
}
