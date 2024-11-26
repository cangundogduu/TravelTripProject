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

        Context c = new Context();
        BlogYorum blogYorum = new BlogYorum();
        
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            blogYorum.Deger1=c.Blogs.ToList();
            blogYorum.Deger3=c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return View(blogYorum);
        }

        

        public ActionResult BlogDetay(int id)
        {
            blogYorum.Deger1=c.Blogs.Where(x=>x.ID==id).ToList();
            blogYorum.Deger2=c.Yorumlars.Where(x=>x.BlogId==id).ToList();
            return View(blogYorum);
        }
    }
}