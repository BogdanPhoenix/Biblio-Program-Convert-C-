using System.Collections.Generic;
using Biblio_Convert_C_Shart_Xp.Interface;

namespace Biblio_Convert_C_Shart_Xp
{
    class WOS_Ignore : IVariantIgnore
    {
        public List<string> ALL { get; set; }
        public List<string> JOUR { get; set; }
        public List<string> CPAPER { get; set; }
        public List<string> BOOK { get; set; }
    }
}
