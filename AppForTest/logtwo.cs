﻿using System;
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
    public partial class logtwo : Form
    {
        public logtwo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Вы ввели неверные данные или поля пустые");
            }
        }
    }
}
