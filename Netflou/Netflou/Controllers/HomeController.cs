using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Netflou.Models;
using Microsoft.EntityFrameworkCore;

namespace Netflou.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var db = new NetflouContext();

            var medias = new MediaList();
            medias.Films = db.Films.ToList();
            medias.Series = db.Series.ToList();

            return View(medias);
        }

        public IActionResult About()
        {
            // Film filmUn = new Film();
            // filmUn.Title = "test";

            using (var db = new NetflouContext())
            {
                //db.Films.Add(new Film { Title = "mathilde" });
                //  var count = db.SaveChanges();

                int film = db.Films.Count();



                for (int i = 0; i < film; i++)
                {
                    foreach (var filme in db.Films)
                    {
                        ViewData["filmList"] += filme.Title;
                        ViewData["Title"] = filme.Title;
                        ViewData["Img"] = filme.Img;
                    }
                }
            }
            return View();

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