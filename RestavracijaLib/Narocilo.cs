using RestavracijaLib.RestavracijaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestavracijaLib
{
    public class Narocilo
    {
        public const decimal DDV = 0.22m; //const podatek
        private static int stevec = 1; //static podatek

        public readonly DateTime Ustvarjeno; //readonly podatek
        public int Stevilka { get; }

        public List<PostavkaNarocila> Postavke { get; } = new List<PostavkaNarocila>();

        public Narocilo() //konstruktor
        {
            Ustvarjeno = DateTime.Now;
            Stevilka = stevec++;
        }

        public void DodajIzdelek(Izdelek izdelek) //objektna metoda
        {
            var obstojeca = Postavke.FirstOrDefault(p => p.Izdelek.Naziv == izdelek.Naziv);
            if (obstojeca != null)
            {
                var nova = obstojeca + 1;
                Postavke.Remove(obstojeca);
                Postavke.Add(nova);
            }
            else
            {
                Postavke.Add(new PostavkaNarocila(izdelek, 1));
            }
        }

        public decimal Skupaj() => Postavke.Sum(p => p.VmesnaCena);
        public decimal ZnesekZDDV() => Skupaj() * (1 + DDV);

        public PostavkaNarocila this[int index]
        {
            get { return Postavke[index]; }
        }
    }
}
