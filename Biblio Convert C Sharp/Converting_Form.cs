using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Biblio_Convert_C_Sharp
{
    public partial class Converting_Form : Form
    {
        private Check_Exit_Form return_exit;
        private int Combo_Index;
        public Converting_Form(string text, int _Combo_Index)
        {
            InitializeComponent();
            textBox_Variant_Convert.Text = text;
            Combo_Index = _Combo_Index;
            return_exit = new Check_Exit_Form();
            return_exit.Owner = this;
            return_exit.Hide();
        }
        public void Check_File_Is_Empty(string file_name)
        {
            if (File.Exists(file_name))
            {
                checkBox_Full_File.Checked = checkBox_Full_File.Visible = true;
                checkBox_Full_File.Text = "Видалити вміст файлу " + file_name;
                MessageBox.Show("Даний файл " + file_name + ", не є пустим. \nЯкщо ви не хочете, щоб дані було видалено, будь ласка приберіть прапорець у відповідному полі", "Увага");
            }
            else
            {
                checkBox_Full_File.Visible = false;
            }
        }
        private void button_Search_open_File_Click(object sender, EventArgs e)
        {
            string File_Name;
            switch (Combo_Index)
            {
                case 0: openFileDialog_Choose.Filter = "Type file(*.ris)|*.ris| All files (*.*)|*.*"; break;
                default: MessageBox.Show("Сталася помилка. \nПрограма завершена!!!", "Увага"); Hide(); break;
            }

            File_Name = openFileDialog_Choose.ShowDialog() == DialogResult.OK ? openFileDialog_Choose.FileName : "";
            label_Open_Check.Text = File_Name.Length == 0 ? "Дане поле порожнє" : "";

            try { textBox_open_File.Text = File_Name; }
            catch (Exception ex){ MessageBox.Show(this, "Не вдалося відкрити файл! \nПомилка: " + ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_Search_save_File_Click(object sender, EventArgs e)
        {
            string File_Name;
            switch (Combo_Index)
            {
                case 0: saveFileDialog_Choose.Filter = "Type file(*.txt)|*.txt| All files(*.*)|*.*"; break;
                default: MessageBox.Show("Сталася помилка. \nПрограма завершена!!!", "Увага"); Hide(); break;
            }

            File_Name = saveFileDialog_Choose.ShowDialog() == DialogResult.OK ? saveFileDialog_Choose.FileName : "";
            label_Save_Check.Text = File_Name.Length == 0 ? "Дане поле порожнє" : "";
             
            try { textBox_save_File.Text = File_Name; }
            catch (Exception ex) { MessageBox.Show(this, "Не вдалося відкрити файл! \nПомилка: " + ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Check_File_Is_Empty(File_Name);
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            if(textBox_open_File.Text == "C:\\" || textBox_save_File.Text == "C:\\")
            {
                MessageBox.Show("Не вистачає деяких даних. \nБудь ласка заповніть їх.", "Увага");
            }
            else
            {
                //не видаляє файл
                if (checkBox_Full_File.Checked)
                {
                    File.Create(textBox_save_File.Text).Close();
                    //File.WriteAllText(textBox_save_File.Text, string.Empty);
                }
                IClass_Type class_Type = null;
                Open_Variant_Convert open = new Open_Variant_Convert(textBox_open_File.Text, textBox_save_File.Text);
                switch (Combo_Index)
                {
                    case 0: class_Type = new From_RIS_to_TXT(); break;
                    default: MessageBox.Show("Сталася помилка. \nПрограма завершена!!!", "Увага"); Hide(); break;
                }
                open.Start_Program(class_Type);
                Finish_Form finish = new Finish_Form(textBox_save_File.Text);
                Hide();
                finish.Show();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Draw_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void головнийЕкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start_Form start = new Start_Form();
            Hide();
            start.Show();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            return_exit.Show();
        }

        private void екранВиборуКонвертатораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Converting_Type_Form converting = new Converting_Type_Form();
            Hide();
            converting.Show();
        }
    }
}
