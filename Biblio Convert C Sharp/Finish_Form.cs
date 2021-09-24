using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Biblio_Convert_C_Sharp
{
    public partial class Finish_Form : Form
    {
        private string way_file;
        public Finish_Form(string _way_file)
        {
            InitializeComponent();
            way_file = _way_file;
        }

        private void button_Finish_Click(object sender, EventArgs e)
        {
            if (checkBox_Open.Checked)
                Process.Start("notepad.exe", way_file);
            Application.Exit();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            if (checkBox_Open.Checked)
                Process.Start("notepad.exe", way_file);
            Start_Form start = new Start_Form();
            Hide();
            start.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Draw_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }

}
