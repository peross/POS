using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Klase
{
    public class Artikl
    {
        public int IdProizvoda { get; set; }
        public string Naziv { get; set; }
        public int IdKategorije { get; set; }
        public int SifJM { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }
    }
}
