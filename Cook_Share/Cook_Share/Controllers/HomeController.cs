using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cook_Share.Models;
using Microsoft.AspNetCore.Authorization;

namespace Cook_Share.Controllers
{
    public class HomeController : Controller
    {

        public DataContext db;

        public HomeController(DataContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            //return Content(User.Identity.Name);
            //return View(db.Users.ToList());
            return RedirectToAction("Account", "Account");
        }
      

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
