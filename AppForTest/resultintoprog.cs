using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DLL_APP_TEST;
using System.Diagnostics;
using Microsoft.Office.Interop.Word;


namespace AppForTest
{
    public partial class resultintoprog : Form
    {
        public resultintoprog()
        {
            InitializeComponent();
            label1.Text = $"Ваше количество баллов: {DLL_APP_TEST.Class1.n}";
        }

        //==============блокнот====================
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter stw = new StreamWriter("TextFile1.txt");
            string strok = "";
            int l = 0;
            foreach (int i in DLL_APP_TEST.Class1.Results)
            {
                l++;
                strok += $"{l.ToString()}      {i.ToString()}\n";
                
            }
            stw.WriteLine(strok);
            stw.Close();
            Process.Start("TextFile1.txt");

        }
        //==============блокнот====================



        //==============datagrid====================
        private void button2_Click(object sender, EventArgs e)
        {
            int gh = 0;
            dataGridView1.ColumnCount = 18;
            dataGridView1.Rows.Add();
            foreach (int i in DLL_APP_TEST.Class1.Results)
            {
                dataGridView1.Columns[gh].Name = $"[{gh+1}]";
                dataGridView1.Rows[0].Cells[gh].Value = i;
                gh++;

            }

        }
        //==============datagrid====================



        //==============word====================
        private void button3_Click(object sender, EventArgs e)
        {

            string strok = "";
            int l = 0;
            foreach (int i in DLL_APP_TEST.Class1.Results)
            {
                l++;
                strok += $"{l.ToString()}      {i.ToString()}\n";

            }
            DLL_APP_TEST.Class2.nazv(strok);



        }
        //==============word====================
    }
}
