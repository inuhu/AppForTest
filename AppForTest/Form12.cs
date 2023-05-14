using DLL_APP_TEST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppForTest
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros12(checkedListBox1);
            if (!(rez == -1)) 
            {
                Form13 f = new Form13();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
