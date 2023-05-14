using DLL_APP_TEST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppForTest
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            label3.Text = "Ваш ответ: " + hScrollBar1.Value.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros11(hScrollBar1);

            if (!(rez == -1))
            {
                Form12 f = new Form12();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int ans = hScrollBar1.Value;
            label3.Text = "Ваш ответ: " + ans;
        }
    }


}
