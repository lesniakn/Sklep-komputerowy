using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Sklep.DAL
{
    public class PrzedmiotContext : DbContext
    {
        public PrzedmiotContext() : base("PrzedmiotContext")
        {

        }

        public DbSet<Przedmiot> Przedmioty { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamówienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjaZamowienia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Using System.Data.Entity.ModelConfiguration.Conventions;
            //Wyłacza konwencję, która automatyczie tworzy liczbę mnogą dla nazw tabel w bazie danych
            //Zamiast Kategorie zostałaby stworzona tabela o nazwie Kategories 

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}