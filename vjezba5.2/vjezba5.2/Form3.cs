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
    public partial class Form3 : Form
    {
        string filePath = "ucenici.txt";
        public Form3()
        {
            InitializeComponent();
        }
        List<Ucenik> popisUcenika = new List<Ucenik>();

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(filePath);
            string linija = sr.ReadLine();

            while (linija != null)
            {
                var razlomiti = new string[] { "|" };

                foreach (var c in razlomiti)
                {
                    linija = linija.Replace(c, " ");
                }
                
                popisUcenika.Add(new Ucenik(linija)); 
                listBox1.Items.Add(linija);
                linija = sr.ReadLine();

            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(filePath, false);
            sw.Write("");
            sw.Close();
            listBox1.DataSource = new List<string>() { };

            MessageBox.Show("Učenici su obrisani!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string razred = comboBox1.Text;
            List<string> Razredi = new List<string>() { };

            for (int i = 0; i < popisUcenika.Count; i++)
            {
                if (popisUcenika[i].razred == razred)
                {
                    Razredi.Add(popisUcenika[i].ime + " " + popisUcenika[i].prezime + " " + popisUcenika[i].razred + " " + popisUcenika[i].uspjeh);
                }
            }

            listBox1.DataSource = Razredi;
        }
    }
}
