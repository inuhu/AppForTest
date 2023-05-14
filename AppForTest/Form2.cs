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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int rez = new Class1().Vopros2(checkBox1, checkBox2, checkBox3);
            if (!(rez == -1))
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.ShowDialog();
            }
        }
    }
}
