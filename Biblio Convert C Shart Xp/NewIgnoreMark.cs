using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Biblio_Convert_C_Shart_Xp
{
    public partial class NewIgnoreMark : Form
    {
        public HashSet<string> hashMark = new HashSet<string>();
        private static readonly Ignore ignore = JsonConvert.DeserializeObject<Ignore>(File.ReadAllText(Function.Get_System_File(System_File_Code.Mark_Ignore)));

        public NewIgnoreMark(List<string> Information, HashSet<string> hashMark)
        {
            InitializeComponent();
            textBoxInformation.Lines = Information.ToArray();
            this.hashMark = hashMark;
            Button_No.Click += (s, a) => { DialogResult = DialogResult.No; Hide(); };
            Timer_Checked.Start();
        }

        private void Button_Yes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            foreach (string element in CheckedListBox_MarkVariant.CheckedItems)
            {
                switch (element)
                {
                    case "Всі": ignore.COMMON.AddRange(hashMark); break;
                    case "SCOPUS(RIS to TXT)": ignore.SCOPUS.ALL.AddRange(hashMark); break;
                    case "WoS(RIS to TXT)": ignore.WOS.ALL.AddRange(hashMark); break;
                }
            }
            string json = JsonConvert.SerializeObject(ignore, Formatting.Indented);
            File.WriteAllText(Function.Get_System_File(System_File_Code.Mark_Ignore), json);
            Hide();
        }
        
        private void CheckedListBox_MarkVariant_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (CheckedListBox_MarkVariant.SelectedItem.ToString().Contains("Всі") && !CheckedListBox_MarkVariant.GetItemChecked(e.Index))
            {
                foreach (int index in CheckedListBox_MarkVariant.CheckedIndices)
                {
                    CheckedListBox_MarkVariant.SetItemCheckState(index, CheckState.Unchecked);
                }
                return;
            }
            int index_ALL = CheckedListBox_MarkVariant.FindStringExact("Всі");
            if (CheckedListBox_MarkVariant.GetItemChecked(index_ALL) && e.Index != index_ALL)
            {
                CheckedListBox_MarkVariant.SetItemCheckState(index_ALL, CheckState.Unchecked);
                return;
            }
        }

        private void Timer_Checked_Tick(object sender, EventArgs e)
        {
            foreach (int index in CheckedListBox_MarkVariant.CheckedIndices)
            {
                if (CheckedListBox_MarkVariant.GetItemChecked(index))
                {
                    Button_Yes.Enabled = true;
                    Button_Yes.BackColor = Color.FromArgb(255, 215, 158);
                    return;
                }
            }
            Button_Yes.Enabled = false;
            Button_Yes.BackColor = Color.Gray;
        }
    }
}
