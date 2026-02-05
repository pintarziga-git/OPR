using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestavracijaLib //Faza 2 – dodan vmesnik ICenik

{
    public interface ICenik // VMESNIK: določa, da mora razred znati izračunati končno ceno
    {
        decimal KoncnaCena();
    }
}
