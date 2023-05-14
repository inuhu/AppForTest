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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AppForTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int rez = Class1.Vopros1(radioButton1, radioButton2, radioButton3);
            if (!(rez == -1))
            {
                Form2 f = new Form2();
                this.Hide();
                f.Show();
            }

        }

    }
}
