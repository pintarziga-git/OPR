using RestavracijaLib.RestavracijaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestavracijaLib
{
    public class Pijaca : Izdelek
    {
        public double Volumen { get; }

        public Pijaca(string naziv, decimal cena, double volumen) : base(naziv, cena)
        {
            Volumen = volumen;
        }

        public override string Opis()
        {
            return Naziv + " (pijača) - " + Cena.ToString("0.00") + " €";
        }
    }
}

