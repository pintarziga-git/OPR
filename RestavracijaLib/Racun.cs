using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestavracijaLib
{
    using System;

    namespace RestavracijaLib
    {
        public class Racun : Narocilo, ICenik //dedovanje
        {
            private static int zapStevilka = 1;

            public int StevilkaRacuna { get; }
            public decimal Popust { get; private set; }  

            public Racun() : base()
            {
                StevilkaRacuna = zapStevilka++;
                Popust = 0m;
            }

            public Racun(decimal popust) : base()
            {
                StevilkaRacuna = zapStevilka++;
                NastaviPopust(popust);
            }

            public void NastaviPopust(decimal popust)
            {
                if (popust < 0m) popust = 0m;
                if (popust > 1m) popust = 1m;
                Popust = popust;
            }

            public decimal SkupajSPopustom()
            {
                decimal skupaj = Skupaj();
                return skupaj * (1m - Popust);
            }

            public decimal KoncniZnesek()
            {
                decimal osnovno = SkupajSPopustom();
                return osnovno * (1m + DDV);
            }

            public override string ToString()
            {
                return "Račun #" + StevilkaRacuna + " | Skupaj: " + KoncniZnesek().ToString("0.00") + " €";
            }

            // VMESNIK: implementacija metode iz vmesnika ICenik
            public decimal KoncnaCena()
            {
                return ZnesekZDDV();
            }
        }
    }
}
