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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int rez = Class1.Vopros3(radioButton1, radioButton2, radioButton3);
            if (!(rez == -1))
            {
                Form4 f = new Form4();
                this.Hide();
                f.Show();
            }

        }
    }
}
