using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfanum
{
    public partial class Form1 : Form
    {
        public string JeAlfanum(string a, bool f)
        {
            f = true;
            int pocetm = 0, pocetv = 0, pocetj = 0;
            /*a.Replace("  ", " ");
            string[] slovo = a.Split(' ');*/
            foreach (char p in a)
            {
                try
                {
                    if (f)
                    {
                        if (p >= 48 && p <= 57) { f = true; }
                        else if (p >= 65 && p <= 90) { f = true; pocetv++; }
                        else if (p >= 97 && p <= 122) { f = true; pocetm++; }
                        else { f = false; pocetj++; }
                    }
                    else
                    {
                        if (p >= 48 && p <= 57) { f = false; }
                        else if (p >= 65 && p <= 90) { f = false; pocetv++; }
                        else if (p >= 97 && p <= 122) { f = false; pocetm++; }
                        else { f = false; pocetj++; }
                    }
                }
                catch { }
            }
            if (f) {a = "Řetězec je alfanumerický."; }
            else if (!f) { a = "Řetězec není alfanumerický."; }
            label2.Text = pocetv.ToString();
            label3.Text = pocetm.ToString();
            label4.Text = pocetj.ToString();
            return a;
        }   

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            bool f = false;
            label1.Text = JeAlfanum(i, f);
        }
    }
}
