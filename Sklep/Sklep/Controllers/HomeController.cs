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
            var listaKategorii = db.Kategorie.ToList();

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

