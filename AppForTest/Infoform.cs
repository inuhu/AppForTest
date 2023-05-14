using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppForTest
{
    public partial class Infoform : Form
    {

        public Infoform()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1eFU6yDbEhLEwlyb8_eYaYSVrnGxHE-uR?usp=sharing");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logtwo f = new logtwo();
            f.Show();
            this.Hide();
        }
    }
}
