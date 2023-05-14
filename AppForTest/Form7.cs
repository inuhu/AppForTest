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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int rez = Class1.Vopros7(comboBox1,comboBox2);
            if (!(rez == -1))
            {
                Form8 f = new Form8();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
