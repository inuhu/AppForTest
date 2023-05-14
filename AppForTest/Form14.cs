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

namespace AppForTest
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros14(trackBar1);
            if (!(rez == -1))
            {
                Form15 f = new Form15();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
