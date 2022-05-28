using System.Collections.Generic;
using Biblio_Convert_C_Shart_Xp.Interface;

namespace Biblio_Convert_C_Shart_Xp
{
    class RIS_TO_TXT_Convert
    {
        private readonly ALL_RIS_TXT menu = new ALL_RIS_TXT();
		private readonly List<string> ignoreALL = new List<string>();
        readonly IVariantIgnore variantIgnore = null;
		private readonly HashSet<string> colection = new HashSet<string>();

		public List<string> Fragment { get; set; }
		public HashSet<string> Colection { get => colection; }

		public RIS_TO_TXT_Convert(string convertType)
        {
			switch (convertType)
			{
				case "SCOPUS (RIS to TXT)": ignoreALL = menu.Ignore.SCOPUS.ALL; variantIgnore = menu.Ignore.SCOPUS; break;
				case "WoS (RIS to TXT)": ignoreALL = menu.Ignore.WOS.ALL; variantIgnore = menu.Ignore.WOS; break;
			}
		}

        public void Convert(string file_name_save, string identifier)
        {
			menu.Fragment = Fragment;
			menu.Index = 0;
			bool chech = false;
			int start = 0, mark_Length = 2;

			for (; menu.Index < Fragment.Count; menu.Index++)
			{
				menu.Part = Fragment[menu.Index].Substring(start, mark_Length);
				switch (identifier)
				{
					case "JOUR":
						if (!menu.Check(variantIgnore.JOUR, ignoreALL))
							chech = menu.Jour();
						break;
					case "CPAPER":
						if (!menu.Check(menu.Ignore.WOS.CPAPER, ignoreALL))
							chech = menu.Cpaper();
						break;
					case "BOOK":
						if (!menu.Check(variantIgnore.BOOK, ignoreALL))
							chech = menu.Book();
						break;
					case "CONF":
						if (!menu.Check(menu.Ignore.SCOPUS.CONF, ignoreALL))
							chech = menu.Conf();
						break;
				}
				if (!chech)
				{
					Free_Transformation();
				}
				Find_Mark();
			}
			menu.WriteFile(file_name_save, Fragment);
		}
        private void Free_Transformation()
        {
			switch (menu.Part)
			{
				case "DB": menu.Work_DB(); break;
				case "AU": menu.Work_AU(); break;
				case "A2": menu.Work_A2(); break;
				case "N1": menu.Work_N1(); break;
				case "AD": menu.Work_AD(); break;
				case "LA": menu.Work_LA(); break;
				case "UR": menu.Work_UR(); break;
				case "AN": menu.Work_AN_WOS(); break;
				default: menu.Work_Default(); break;
			}
		}

		/// <summary>
		/// Пошук міток про які нічого не відомо
		/// </summary>
		public void Find_Mark()
		{
			if (Fragment[menu.Index].StartsWith(menu.Part + menu.Size_Delete_Dash))
			{
				colection.Add(menu.Part);
			}
		}
	}
}
