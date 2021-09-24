using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Convert_C_Sharp
{
    class Open_Variant_Convert
    {
        private string name_open_file, name_save_file;
        public Open_Variant_Convert(string _name_open_file, string _name_save_file)
        {
            name_open_file = _name_open_file;
            name_save_file = _name_save_file;
        }
        public void Start_Program(IClass_Type variant) { variant.Start(name_open_file, name_save_file); }
    }
}
