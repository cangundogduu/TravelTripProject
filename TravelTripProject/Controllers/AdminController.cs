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

        [Authorize]
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
            var value = c.Blogs.Find(id);
            c.Blogs.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }


        public ActionResult BlogGuncelle(Blog blog)
        {
            var blg = c.Blogs.Find(blog.ID);
            blg.Baslik = blog.Baslik;
            blg.Aciklama = blog.Aciklama;
            blg.BlogImage = blog.BlogImage;
            blg.Tarih = blog.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");



        }
        [Authorize]
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }


        public ActionResult YorumSil(int id)
        {
            var value = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(value);
            c.SaveChanges();
            return RedirectToAction("YorumListesi", "Admin");

        }

        [HttpGet]
        public ActionResult YorumGuncelle(int id)
        {
            var deger = c.Yorumlars.Find(id);
            return View(deger);
        }

        [HttpPost]
        public ActionResult YorumGuncelle(Yorumlar yorumlar)
        {
            var value = c.Yorumlars.Find(yorumlar.ID);
            value.KullaniciAdi = yorumlar.KullaniciAdi;
            value.Yorum = yorumlar.Yorum;
            value.Mail = yorumlar.Mail;
            value.Blog.Baslik = yorumlar.Blog.Baslik;
            c.SaveChanges();
            return RedirectToAction("YorumListesi", "Admin");
        }



    }
}