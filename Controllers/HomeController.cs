using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using PlateSpotter.Models;

namespace PlateSpotter.Controllers
{
    public class HomeController : Controller {
        private ApplicationDbContext _context;

        public HomeController(){
            _context = new ApplicationDbContext();
        }
        
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            var result =
                _context.Plates.Where(p => p.FoundByUserId.Equals(userId))
                    .OrderByDescending(p => p.PlateNr)
                    .FirstOrDefault();

            return View(result);
        }

        [Authorize]
        public ActionResult MyPlates(){
            string userId = User.Identity.GetUserId();
            var result = _context.Plates.Where(p => p.FoundByUserId.Equals(userId)).ToList();
            return View(result);
        }

        public ActionResult HighScore()
        {
            return View();
        }

        public ActionResult Map()
        {
            return View();
        }

        public ActionResult addNewPlate()
        {
            Console.WriteLine("du klickade på bilden");
            return null;
        }
    }
}