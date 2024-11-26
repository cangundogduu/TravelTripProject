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
            var degerler=c.Blogs.ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}