using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace vjezba5._2
{
    internal class Ucenik
    {
        public string ime, prezime, razred, uspjeh;

        public Ucenik(string ime, string prezime, string razred, string uspjeh)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.razred = razred;
            this.uspjeh = uspjeh;
        }

        public Ucenik(string unos)
        {
            string trenutno = "";
            int brojac = 0;
            int i;

            ime = "Nije uneseno";
            prezime = "Nije uneseno";
            razred = "Nije uneseno";
            uspjeh = "Nije uneseno";

            for (i = 0; i < unos.Length; i++)
            {
                if (unos[i] == '|' || i == unos.Length - 1)
                {
                    if (brojac == 0)
                    {
                        ime = trenutno;
                        brojac++;
                    }
                    else if (brojac == 1)
                    {
                        prezime = trenutno;
                        brojac++;
                    }
                    else if (brojac == 2)
                    {
                        razred = trenutno;
                        brojac++;
                    }
                    else
                    {
                        trenutno += unos[i];
                        uspjeh = trenutno;
                    }

                    trenutno = "";
                }
                else trenutno += unos[i];
            }
        }
    }
}
