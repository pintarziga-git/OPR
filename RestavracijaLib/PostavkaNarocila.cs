using RestavracijaLib.RestavracijaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestavracijaLib
{
    public class PostavkaNarocila
    {
        public Izdelek Izdelek { get; }
        public int Kolicina { get; private set; } //lastnosti

        public decimal VmesnaCena => Izdelek.Cena * Kolicina;

        public PostavkaNarocila(Izdelek izdelek, int kolicina)
        {
            Izdelek = izdelek;
            Kolicina = kolicina;
        }

        public static PostavkaNarocila operator +(PostavkaNarocila p, int dodatno) //preoblaganje operatorjev
        {
            return new PostavkaNarocila(p.Izdelek, p.Kolicina + dodatno);
        }

        public override string ToString() => $"{Izdelek.Naziv} x{Kolicina} = {VmesnaCena:0.00} €";
    }
}
