using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class AdminController : Controller
    {
        BlogEntities blogDB = new BlogEntities();
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            var Vblog = blogDB.Post.ToList();
            return View();
        }

        public ActionResult WyswietlPosty()
        {
            var Vblog = blogDB.Post.ToList();
            if (Vblog.Count > 0)
                return View(Vblog);
            return RedirectToAction("Dodaj");
        }

        public ActionResult Dodaj()//tagi, walidacja
        {
            PostTag nowy_post = new PostTag();
            
            return View(nowy_post);
        }
        [HttpPost]
        public ActionResult Dodaj(PostTag nowy_post)
        {
            try
            {
                nowy_post.post.status = 0;
                nowy_post.post.data_dodania = DateTime.Now;
                blogDB.AddToPost(nowy_post.post);
                blogDB.SaveChanges();
                var post = blogDB.Post.Single(a => a.tresc == nowy_post.post.tresc);
                //var post = blogDB.Post.Single(a => a.data_dodania.Equals(nowy_post.post.data_dodania));
                nowy_post.tag.id_posta = post.id;
                blogDB.AddToTagi(nowy_post.tag);//pobrać id
                blogDB.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(nowy_post);
            }
        }
        public ActionResult Edycja(int id)
        {
            Post post = blogDB.Post.Single(a => a.id == id);
            return View(post);
        }
        [HttpPost]
        public ActionResult Edycja(int id,Post post)
        {
            var Ppost = blogDB.Post.Single(a => a.id == id);
            try
            {
                Ppost = post;
                blogDB.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(Ppost);
            }
        }
        public ActionResult Usun(int id)
        {
            var post = blogDB.Post.Single(a => a.id == id);
            return View(post);
        }

        [HttpPost]
        public ActionResult Usun(int id, string confirmButton)
        {
            var post = blogDB.Post.Single(a => a.id == id);
           // .Include("OrderDetails").Include("Carts")
            
            blogDB.DeleteObject(post);
            blogDB.SaveChanges();
            return View("Usun");
        }
        public ActionResult Detale(int year)
        {
            string data="2011-04-02";
            DateTime data_pdb=Convert.ToDateTime(data);
            var Vblog = blogDB.Post.Single(a=>a.data_dodania==data_pdb);
            return View(Vblog);
        }
        /*public ActionResult Ustawienia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ustawienia()
        {
            return View();
        }
        public ActionResult Komentarze()
        {
            return View();
        }*/

    }
}
