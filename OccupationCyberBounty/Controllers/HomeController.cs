using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OCB.Data;
using OCB.Domain.Entities;

namespace OccupationCyberBounty.Controllers
{
    public class HomeController : Controller
    {
        private readonly OCBContext _db;

        HomeController(OCBContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
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

        public string TestDB()
        {
            var TestBounty = new WowBounty() {
                Balance = 5
            };

            _db.WowBounties.Add(TestBounty);
            var success = _db.SaveChanges();

            return success.ToString();
        }
    }
}