using CopyBackupToolUI;
using CopyBackupToolUI.Helpers;
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
            Guid g1 = Guid.NewGuid();
            Guid g2 = Guid.NewGuid();
            Application.Run(new Painel());
        }
    }
}
