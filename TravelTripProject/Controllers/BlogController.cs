using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        
        Context c= new Context();
        public ActionResult Index()
        {
            var bloglar=c.Blogs.ToList();
            return View(bloglar);
        }

        public ActionResult BlogDetay(int id)
        {
            var blogbul=c.Blogs.Where(x=>x.ID==id).ToList();
            return View(blogbul);
        }
    }
}