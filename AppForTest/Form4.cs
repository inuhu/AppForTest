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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros4(checkBox6, checkBox5, checkBox4);
            if (!(rez == -1))
            {
                Form5 f = new Form5();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
