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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.Vopros10_b1(listBox1, textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.Vopros10_b1(listBox1, textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.Vopros10_b1(listBox1, textBox3);
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            int rez = Class1.Vopros10("1) Эвристика", "2) Программирование", "3) Рекурсия", textBox1.Text, textBox2.Text, textBox3.Text);

            if (!(rez == -1))
            {
                Form11 f = new Form11();
                this.Hide();
                f.ShowDialog();
            }
        }


    }
}
