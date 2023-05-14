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
    public partial class first_anim : Form
    {
        public Timer abs;

        public first_anim()
        {

            InitializeComponent();
            abs = new Timer();
            abs.Interval = 4000;
            abs.Tick += new EventHandler(timer1_Tick);
            abs.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            abs.Stop();
            Loginform f = new Loginform();
            this.Hide();
            f.Show();
        }
    }
}
