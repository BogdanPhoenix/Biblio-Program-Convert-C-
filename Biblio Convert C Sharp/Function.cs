using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;

namespace Biblio_Convert_C_Sharp
{
    static class Function
    {
        // an array of file names that are required for the full operation of the program
        private static List<string> system_File = new List<string>()
        {
            "File_Info\\Country_Code.json",
            "File_Info\\Language_Code.json",
            "File_Info\\Mark_from_RIS_to_TXT.json",
            "File_Info\\Mark_Ignore.json"
        };
        public static string Get_System_File(int index)
        {
            return system_File[index];
        }
        public static bool System_Check()
        {
            foreach(var it in system_File)
            {
                string exePath = AppDomain.CurrentDomain.BaseDirectory;
                string path = Path.Combine(exePath, it);
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл " + it + " не відкрився.", "Увага");
                    return false;
                }
            }
            return true;
        }
    }
}
