using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.Models
{
    public class Przedmiot
    {
        public int PrzedmiotId { get; set; }
        public int KategoriaId { get; set; }
        public string NazwaPrzedmiotu { get; set; }
        public string ProducentPrzedmiotu { get; set; }
        public DateTime DataDodania { get; set; }
        public string NazwaPlikuObrazka { get; set; }
        public string OpisPrzedmiotu { get; set; }
        public decimal CenaPrzedmiotu { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; }

        public virtual Kategoria Kategoria { get; set; }
    }
}