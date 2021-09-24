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
    public partial class Converting_Type_Form : Form
    {
        public Converting_Type_Form()
        {
            InitializeComponent();
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
            Start_Form start_ = new Start_Form();
            Hide();
            start_.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Converting_Form return_converting = new Converting_Form(comboBox_Type.Text, comboBox_Type.SelectedIndex);
            Hide();
            return_converting.Show();
        }
    }
}
