using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.Models
{
    public class PozycjaZamowienia
    {
        public int PozycjaZamowieniaId { get; set; }
        public int ZamówienieID { get; set; }
        public int PrzedmiotId { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaZakupu { get; set; }

        public virtual Przedmiot Przedmiot { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}