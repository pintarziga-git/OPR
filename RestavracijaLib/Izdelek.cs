using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestavracijaLib 
{
    public abstract class Izdelek //abstraktni razred
    {
        private decimal cena;

        public string Naziv { get; }

        public decimal Cena
        {
            get { return cena; }
            protected set
            {
                if (value < 0) throw new System.ArgumentException("Cena ne sme biti negativna.");
                cena = value;
            }
        }

        // abstraktni razred + polimorfizem: vsaka podrazred vrne svoj opis
        public abstract string Opis();

        protected Izdelek(string naziv, decimal cena)
        {
            Naziv = naziv;
            Cena = cena;
        }

        public override string ToString()
        {
            return Opis();
        }
    }
}

