using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezba5._2
{
    public partial class Form2 : Form
    {
        string filePath = "ucenici.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            string tekstUcenici;
            tekstUcenici = textBox1.Text + "|" + textBox2.Text + "|" + comboBox1.Text + "|" + comboBox2.Text ;
            if (tekstUcenici != "")
            {
                sw.WriteLine(tekstUcenici);
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                MessageBox.Show("Podaci su spremljeni!");

            }

            sw.Close();

        }
    }
}
