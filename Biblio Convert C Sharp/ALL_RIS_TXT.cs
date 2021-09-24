using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblio_Convert_C_Sharp
{
	enum System_File_Code
	{
		Country_Code,
		Language_Code,
		Mark_from_RIS_to_TXT,
		Mark_Ignore
	}
	enum Operating_Modes_N1
	{
		/*
		 Режими роботи для мітки N1
		 */
		Link,
		Export_Date,
		Quotes
	}
	class ALL_RIS_TXT
	{
		private int number_AU = 0;
		private int part_size = 2;
		private int index = 0;
		private string part, mark_DB;
		private string size_delete_dash = "  - ";
		private List<string> fragment;

		//checks for an additional label attribute
		private bool Check_Attribute(string word, ref int position)
		{
			position = fragment[index].IndexOf(word);
			return position < 0 ? false : true;
		}
		// implement AU label change
		private void Work_AU(string part, string atrebut)
		{
			// replace labels
			int position = -1;
			string AU_label = ", ";
			fragment[index] = fragment[index].Replace(part, atrebut);
			if (Check_Attribute(AU_label, ref position))
			{
				fragment[index] = fragment[index].Replace(AU_label, "^B", fragment[index].LastIndexOf(AU_label));
				fragment[index] = fragment[index].Replace(".", " ");
			}
		}
		private void Work_A2(string part, string atrebut)
		{
			// replace labels
			int position = -1;
			string A2_label = " ";
			fragment[index] = fragment[index].Replace(part, atrebut);
			if (Check_Attribute(A2_label, ref position))
			{
				fragment[index] = fragment[index].Replace(A2_label, "^B", fragment[index].LastIndexOf(A2_label));
				fragment[index] = fragment[index].Replace(".", " ");
			}
		}
		// implement label change AD
		private void Work_AD(string part)
		{
			int position = -1;
			string AD_label = ", ";
			JObject json = JObject.Parse(File.ReadAllText(Function.Get_System_File((int)System_File_Code.Country_Code)));
			fragment[index] = fragment[index].Replace(part, "#711: ^A");
			if (Check_Attribute(AD_label, ref position))
				fragment[index] = fragment[index].Replace(AD_label, "^S", fragment[index].LastIndexOf(AD_label));
			foreach (var element in json)
			{
				if (fragment[index].Contains(element.Key))
				{
					fragment[index] = fragment[index].Replace(element.Key, (string)element.Value, fragment[index].LastIndexOf(element.Key));
					break;
				}
			}
		}
		// implement LA tag change
		private void Work_LA(string part)
		{
			JObject json = JObject.Parse(File.ReadAllText(Function.Get_System_File((int)System_File_Code.Language_Code)));
			foreach (var element in json)
			{
				if (fragment[index].Contains(element.Key))
				{
					fragment[index] = fragment[index].Replace(element.Key, (string)element.Value);
					break;
				}
			}
			fragment[index] = fragment[index].Replace(part, "#101: ");
		}

		private void Work_N1(string part)
		{
			List<string> N1_variant = new List<string>()
			{
				"Пристатейные ссылки:",
				"Export Date:",
				"Цитирования:",
			};
			if (fragment[index].Contains(N1_variant[(int)Operating_Modes_N1.Link]))
			{
				string sentense;
				int start = fragment.FindIndex(x => x.Contains(N1_variant[(int)Operating_Modes_N1.Link])), end = fragment.FindIndex(x => x.Contains("UR" + size_delete_dash));

				fragment[index] = fragment[index].Replace(part + N1_variant[(int)Operating_Modes_N1.Link], "#338: ").Replace(";", "");
				index++;
				for(; index < end; index++)
                {
					fragment[index] = "#338: " + fragment[index].Replace(";", "");
				}
				index--;
			}
			else if (fragment[index].Contains(N1_variant[(int)Operating_Modes_N1.Export_Date]))
			{
				Work_N1_Date(N1_variant[(int)Operating_Modes_N1.Export_Date]);
			}
			else if (fragment[index].Contains(N1_variant[(int)Operating_Modes_N1.Quotes]))
			{
				string variant = N1_variant[(int)Operating_Modes_N1.Quotes];
				fragment[index] = "#339: " + fragment[index].Substring(fragment[index].IndexOf(variant) + variant.Length);
			}
			else
			{
				fragment.Remove(fragment[index--]);
			}
		}
		private void Work_N1_Date(string variant)
		{
			string buffer = fragment[index].Substring(fragment[index].IndexOf(variant) + variant.Length + 1);
			string[] box = buffer.Split(' ');
			string date = box[0];
			string month = box[1];
			string year = box[2];

			switch (month)
			{
				case "January": month = "01"; break;
				case "February": month = "02"; break;
				case "March": month = "03"; break;
				case "April": month = "04"; break;
				case "May": month = "05"; break;
				case "June": month = "06"; break;
				case "July": month = "07"; break;
				case "August": month = "08"; break;
				case "September": month = "09"; break;
				case "October": month = "10"; break;
				case "November": month = "11"; break;
				case "December": month = "12"; break;
				default: month = ""; break;
			}
			fragment[index] = "#907: ^A" + year + month + date + "^BScopus";
		}
		// output DB label
		private string Get_Mark_DB() { return mark_DB; }
		// write the DB label
		private void Set_Mark_DB(string _mark_DB) { mark_DB = _mark_DB; }

		// method for converting labels from RIS to TXT, in a certain sequence
		private void Strict_Transformation(string type)
		{
			int start = index;
			string sentence = "";
			JObject json = JObject.Parse(File.ReadAllText(Function.Get_System_File((int)System_File_Code.Mark_from_RIS_to_TXT)));
			var from_object = JArray.FromObject(json[type]);

			foreach (var element_file in from_object)
			{
				var element_object = JObject.Parse(element_file.ToString());
				var Key = element_object.First.First.Path;
				var Value = element_object.GetValue(Key).ToString();
				sentence += Check_Replase(Key + size_delete_dash, Value);
			}

            if (type == "BOOK")
            {
                sentence += Check_Replase("SN" + size_delete_dash, "\n#10: ^a");
                sentence = sentence.Replace("(", "");
                sentence = sentence.Replace(")", "");
                sentence = sentence.Replace(";", "\n#10: ^a");
            }
			index = start;
			fragment.Insert(index, sentence);
			fragment[index] = sentence;
		}
		private string Check_Replase( string Key, string Value)
		{
			foreach (var text in fragment)
			{
				if (text.Contains(Key))
				{
					fragment.Remove(text);
					return text.Replace(Key, Value);
				}
			}
			return "";
		}
		// implementation of replacement of RIS label by TXT (common for all types)
		private void Free_Transformation(string first_part)
		{
			switch (first_part)
			{
				case "DB":
					{
						string[] box = fragment[index].Split(' ');
						Set_Mark_DB(box[box.Length - 1]);
						fragment[index] = fragment[index].Replace(first_part + size_delete_dash, "#902: ^A");
						break;
					}
				case "AU": Work_AU(first_part + size_delete_dash, number_AU++ == 0 ? "#700: ^A" : "#701: ^A"); break;
				case "A2": Work_A2(first_part + size_delete_dash, "#702: ^A"); break;
				case "N1": Work_N1(first_part + size_delete_dash); break;
				case "AD": Work_AD(first_part + size_delete_dash); break;
				case "LA": Work_LA(first_part + size_delete_dash); break;
				case "UR":
					{
						fragment[index] = fragment[index].Replace(first_part + size_delete_dash, "#951: ^I");
						fragment[index] += "^T" + Get_Mark_DB();
						break;
					}
				default:
					{
						string value = "", key = first_part;
						JObject json = JObject.Parse(File.ReadAllText(Function.Get_System_File((int)System_File_Code.Mark_from_RIS_to_TXT)));
						foreach (var element_file in json["ALL"])
						{
							var element_object = JObject.Parse(element_file.ToString());
							if (key == element_object.First.First.Path)
							{
								value = element_object.GetValue(key).ToString();
								key += size_delete_dash;
								break;
							}
						}
						fragment[index] = fragment[index].Replace(key, value);
						break;
					}
			}
		}
        /*
         *  private KeyValuePair<string, JToken> Get_Key_Value(JToken value)
			{
				var element = JObject.Parse(value.ToString());
				var object_key = element.First.First.Path;
				var object_value = element.GetValue(object_key);
				KeyValuePair<string, JToken> result = new KeyValuePair<string, JToken>(object_key, object_value);
				return result;
			}
		*/

        //check ignore mark
        private bool Check_Ignore_Mark(string copy_part, string type)
		{
			JObject json = JObject.Parse(File.ReadAllText(Function.Get_System_File((int)System_File_Code.Mark_Ignore)));
			foreach (var element in json[type])
				if (fragment[index].Contains(element.ToString() + size_delete_dash))
				{
					fragment.Remove(fragment[index--]);
					return true;
				}
			return false;
		}
		// the label that is placed at the beginning of the file
		private string First_Label() { return "#905: ^D1^11"; }

		private bool Check_Strict(string identifier)
        {
			JObject json = JObject.Parse(File.ReadAllText(Function.Get_System_File((int)System_File_Code.Mark_from_RIS_to_TXT)));
			var from_object = JArray.FromObject(json["JOUR_CONF"]);

			foreach (var element_file in from_object)
			{
				var element_object = JObject.Parse(element_file.ToString());
				var Key = element_object.First.First.Path;
				if (part == Key)
				{
					Strict_Transformation("JOUR_CONF");
					return true;
				}
			}
			return false;
        }

		// conversion of excellent tags JOUR
		private bool Jour(string identifier)
		{
			bool check = true;
			switch (part)
			{
				case "TY": fragment[index] = "#920: ASP"; break;
				default: check = Check_Strict(identifier); break;
			}
			return check;
		}
		// conversion of excellent tags CONF
		private bool Conf(string identifier)
		{
			bool check = true;
			switch (part)
			{
				case "TY": fragment[index] = "#920: ASP"; break;
				default: check = Check_Strict(identifier); break;
			}
			return check;
		}
		// conversion of excellent tags BOOK
		private bool Book(string identifier)
		{
			bool check = true;
			switch (part)
			{
				case "TY": fragment[index] = "#920: PAZK"; break;
				case "EP": fragment[index].Replace(part + 4, "#215: ^A"); fragment[index] += "^1p."; break;
				case "PY": Strict_Transformation("BOOK"); break;
				default: check = Check_Strict(identifier); break;
			}
			return check;
		}

		// file conversion
		public void Convert(string file_name_save, string identifier)
		{
			bool chech = false;
			for(index = 0; index < fragment.Count; index++)
            {
				part = fragment[index].Substring(0, part_size);
				if (Check_Ignore_Mark(part, identifier) || Check_Ignore_Mark(part, "ALL")) 
				{ continue; }
				else
				{
					switch (identifier)
					{
						case "JOUR": chech = Jour("JOUR_CONF"); break;
						case "CONF": chech = Conf("JOUR_CONF"); break;
						case "BOOK": chech = Book("BOOK"); break;
					}
					if (!chech)
						Free_Transformation(part);
				}
			}
			StreamWriter file_write = new StreamWriter(file_name_save, true, Encoding.UTF8);
			file_write.WriteLine(First_Label());
			foreach(var it in fragment)
				file_write.WriteLine(it);
			file_write.WriteLine("*****");
			file_write.Close();
		}

		// method for writing the address in which the file fragment lies
		public void Set_Fragment_File(List<string> _fragment) { fragment = _fragment; }
	}
}
