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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            Class1.Vopros9_b1(listBox1,textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.Vopros9_b1(listBox1, textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.Vopros9_b1(listBox1, textBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros9("1) Линейная", "2) Разветвлённая", "3) Циклическая", textBox1.Text, textBox2.Text, textBox3.Text);

            if (!(rez == -1))
            {
                Form10 f = new Form10();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
