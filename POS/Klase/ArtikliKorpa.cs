using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Klase
{
    public class ArtikliKorpa
    {
        [DisplayName("Šifra")]
        public int IdArtikla { get; set; }
        [DisplayName("Naziv artikla")]
        public string Artikli { get; set; }

        [DisplayName("Količina")]
        public decimal Kolicina { get; set; }

        [DisplayName("Cijena po jedinici")]
        public decimal CijenaPoJedinici { get; set; }

        [DisplayName("Ukupan iznos")]
        public decimal UkupanIznos { get; set; }
    }
}
