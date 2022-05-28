using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biblio_Convert_C_Shart_Xp
{
    public partial class NumberBook : Form
    {
        public NumberBook()
        {
            InitializeComponent();
            button_Next.Click += (s, a) => { Hide(); };
        }
        /// <summary>
        /// Отримання номеру книги
        /// </summary>
        public string BookNumber { get => maskedTextBox_NumberBook.Text; }

        private void MaskedTextBox_NumberBook_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox_NumberBook.Text.Length == 7)
            {
                button_Next.Enabled = true;
                button_Next.BackColor = Color.FromArgb(255, 215, 158);
            }
            else
            {
                button_Next.Enabled = false;
                button_Next.BackColor = Color.Gray;
            }
        }
    }
}
