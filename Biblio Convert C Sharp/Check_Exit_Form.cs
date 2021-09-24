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
    public partial class Check_Exit_Form : Form
    {
        public Check_Exit_Form()
        {
            InitializeComponent();
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
