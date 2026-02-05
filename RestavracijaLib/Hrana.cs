using RestavracijaLib.RestavracijaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestavracijaLib
{
    public class Hrana : Izdelek
    {
        public string Alergeni { get; }

        public Hrana(string naziv, decimal cena, string alergeni) : base(naziv, cena)
        {
            Alergeni = alergeni;
        }

        public override string Opis()
        {
            return Naziv + " (hrana) - " + Cena.ToString("0.00") + " €";
        }
    }
}
