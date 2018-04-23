using Sklep.DAL;
using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sklep.Controllers
{
    public class HomeController : Controller
    {
        private PrzedmiotContext db = new PrzedmiotContext();

        public ActionResult Index()
        {
            Kategoria kategoria = new Kategoria { NazwaKategorii = "Płyty główne", NazwaPlikuIkony = "plytyglowne.png", OpisKategorii = "opis" };
            db.Kategorie.Add(kategoria);
            db.SaveChanges();

            return View();
        }

            public ActionResult About()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }

            public ActionResult Contact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
        }
    }

