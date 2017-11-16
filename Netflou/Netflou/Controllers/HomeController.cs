using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Netflou.Models;

namespace Netflou.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            
            // Film filmUn = new Film();
            // filmUn.Title = "test";

            using (var db = new NetflouContext())
            {
                //db.Films.Add(new Film { Title = "mathilde" });

              //  var count = db.SaveChanges();
 

           
                foreach (var film in db.Films)
                {
                    ViewData["Message"] = film.Title;
                    //ViewData["Message"] = count;
                }


            

            return View();
        }


        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
