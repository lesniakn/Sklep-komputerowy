using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sklep.Models
{
    public class Przedmiot
    {
        public int PrzedmiotId { get; set; }
        public int KategoriaId { get; set; }

        [Required(ErrorMessage = "Wprowadź nazwę przedmiotu")]
        [StringLength(50)]
        public string NazwaPrzedmiotu { get; set; }

        [Required(ErrorMessage = "Wprowadź producenta przedmiotu")]
        [StringLength(50)]
        public string ProducentPrzedmiotu { get; set; }
        public DateTime DataDodania { get; set; }

        [StringLength(100)]
        public string NazwaPlikuObrazka { get; set; }
        public string OpisPrzedmiotu { get; set; }
        public decimal CenaPrzedmiotu { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; }
        public string OpisSkrocony { get; set; }

        public virtual Kategoria Kategoria { get; set; }
    }
}
