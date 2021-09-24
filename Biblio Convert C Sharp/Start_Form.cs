using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio_Convert_C_Sharp
{
    public partial class Start_Form : Form
    {
        private Info_Form info;
        public Start_Form()
        {
            InitializeComponent();
            info = new Info_Form();
            info.Owner = this;
            info.Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Draw_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label_Info_Click(object sender, EventArgs e)
        {
            info.Show();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            Converting_Type_Form conv = new Converting_Type_Form();
            Hide();
            conv.Show();
        }
    }
}
