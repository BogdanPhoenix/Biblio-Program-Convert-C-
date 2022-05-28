using System;
using System.Windows.Forms;

namespace Biblio_Convert_C_Shart_Xp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Function.System_Check())
                Application.Run(new StartProgram());
            else
                Application.Exit();
        }
    }
}
