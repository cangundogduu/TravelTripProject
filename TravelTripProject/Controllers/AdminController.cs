using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Blogs.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var value= c.Blogs.Find(id);
            c.Blogs.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult BlogGetir(int id)
        {
            var bl= c.Blogs.Find(id);
            return View("BlogGetir",bl);
        }
    }
}