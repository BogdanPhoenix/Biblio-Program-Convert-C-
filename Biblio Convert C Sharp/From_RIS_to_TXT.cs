using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblio_Convert_C_Sharp
{
    class From_RIS_to_TXT : IClass_Type
    {
        private string size_delete_dash = "  - ";
        public void Start(string name_open_file, string name_save_file)
        {
            bool exit_check = false;
            string sentence, identifier = "";
            List<string> fragment = new List<string>();
            StreamReader file_read = new StreamReader(name_open_file, Encoding.UTF8);
            ALL_RIS_TXT type_class = new ALL_RIS_TXT();

            while (!file_read.EndOfStream)
            {
                sentence = file_read.ReadLine();
                fragment.Add(sentence);
                if (sentence == "") {
                    fragment.Clear();
                    continue;
                }
                if(sentence.Substring(0, 2) == "ER")
                {
                    try
                    {
                        identifier = fragment[0].Substring(fragment[0].IndexOf(size_delete_dash) + size_delete_dash.Length, 4);
                    }
                    catch(Exception ex)
                    {
                        string error = "";
                        string info_to = "Виявлений фрагмент який не має ідентифікатора для подальшого розпізнавання.\nОсь даний фрагмент:\n****\n";
                        string info_after = "****\nПродовжити обробку цього фрагмента?\nЗа замовчуванням індентифікатор буде присвоїний \"JOUR\"";
                        for (int index = 0; index < fragment.Count && index < 10; index++)
                            error += fragment[index] + "\n";
                        DialogResult result = MessageBox.Show(info_to + error + info_after, "Увага", MessageBoxButtons.YesNo);
                        switch (result)
                        {
                            case DialogResult.Yes: identifier = "ALL"; break;
                            case DialogResult.No: fragment.Clear(); exit_check = true; break;
                            default: break;
                        }
                    }
                    if (exit_check)
                    {
                        exit_check = false;
                        continue;
                    }
                    type_class.Set_Fragment_File(fragment);
                    type_class.Convert(name_save_file, identifier);
                    fragment.Clear();
                }
            }
            file_read.Close();
        }
    }
}
