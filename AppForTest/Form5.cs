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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int rez = Class1.Vopros5("словесных", textBox1.Text);
            if (!(rez == -1))
            {
                Form6 f = new Form6();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
