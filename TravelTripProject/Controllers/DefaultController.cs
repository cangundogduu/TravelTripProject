using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        
        
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler=c.Blogs.Take(5).OrderByDescending(x=>x.ID).ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var deger=c.Blogs.ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial2()
        {
            var deger= c.Blogs.Take(3).OrderBy(x=>x.ID).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial3() 
        {
            var deger=c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(deger);
        }
    }
}