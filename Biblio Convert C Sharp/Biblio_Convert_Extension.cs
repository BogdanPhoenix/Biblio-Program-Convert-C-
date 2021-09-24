using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Convert_C_Sharp
{
    static class Biblio_Convert_Extension
    {
        public static string Replace(this string explention_string, string oldValue, string newValue, int index)
        {
            explention_string = explention_string.Remove(index, oldValue.Length);
            explention_string = explention_string.Insert(index, newValue);
            return explention_string;
        }
    }
}
