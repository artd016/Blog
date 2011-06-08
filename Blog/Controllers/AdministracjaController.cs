using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;
using Blog.Helpers;

namespace Blog.Controllers
{
    public class AdministracjaController : Controller
    {
        BlogEntities blogDB = new BlogEntities();
        const int pageSize = 5;

        
        //
        // GET: /Administracja/

        public ActionResult Index()
        {

            return View();
        }

        //
        // GET: /Administracja/Post/5

        public ActionResult Post(int year=0,int month=0,int day=0,string id="",int page=0)
        {        
                DateTime now, date2;
                id=id.Replace('_', ' ');

                if (month == 0 & day == 0&year==0)
                {
                    return View("Error");
                }
                else if (month == 0 & day == 0)
                {
                    now = new DateTime(year, 1, 1).AddYears(1);
                    ViewData["data"] = String.Format("{0:yyyy}", now.AddYears(-1));
                    ViewData["akcja"] = "/" + year;
                    date2 = now.AddYears(-1);
                }
                else if (day == 0)
                {
                    now = new DateTime(year, month, 1).AddMonths(1);
                    ViewData["data"] = String.Format("{0:yyyy-MM}", now.AddMonths(-1));
                    string m = Convert.ToString(month);
                    if (m.Length == 1) m = "0" + m;
                    ViewData["akcja"] = "/" + year + "/" + m;
                    date2 = now.AddMonths(-1);
                }
                else
                {
                    now = new DateTime(year, month, day).AddDays(1);
                    ViewData["data"] = String.Format("{0:yyyy-MM-dd}", now.AddDays(-1));
                    string m = Convert.ToString(month);
                    string d = Convert.ToString(day);
                    if (m.Length == 1) m = "0" + m;
                    if (d.Length == 1) d = "0" + d;
                    ViewData["akcja"] = "/" + year + "/" + m + "/" + d;
                    date2 = now.AddDays(-1);
                }

                if (id == "")
                {
                var posty = from posts in blogDB.Post
                            where posts.data_dodania < now & posts.data_dodania > date2
                            orderby posts.data_dodania
                            select posts;
                var strPost = new PaginatedList<Post>(posty, page, pageSize);

                if (posty.Count() == 0)
                    ViewData["komunikat"] = "Brak postów w tym dniu.";
                    
                return View(strPost);
            }
            else
            {

                var post = from posts in blogDB.Post
                           where posts.data_dodania < now & posts.data_dodania > date2 & posts.tytul.Equals(id)
                           orderby posts.data_dodania
                           select posts;
                var strPost = new PaginatedList<Post>(post, page, pageSize);


                if (strPost.Count != 1)
                    return View(strPost);
                else
                {
                    int id_posta=strPost[0].id;

                    Tagi Tagi = blogDB.Tagi.Single(t=>t.id_posta==id_posta);

                    List<string> lista_t=new List<string>();
                    int j=0,k=0;

                    for (int i = 0; i < Tagi.keywords.Length; i++)
                    {
                        if(Tagi.keywords[i]==','){
                            lista_t.Add(Tagi.keywords.Substring(j,k).TrimStart(' '));
                            j=i;
                            j++;
                            k = -1;
                        }
                        k++;
                    }
                    
                    lista_t.Add(Tagi.keywords.Substring(j).TrimStart(' '));

                    ViewData["tagi"] = lista_t;
                   // ViewData["description"] = Tagi.description;
                    return View("ViewPost", strPost[0]);
                }
            }
        }
        
        //
        // GET: /Administracja/Post/5
        public ActionResult PostyOznaczoneTagiem(string id, int page=0)
        {
            var post = from tags in blogDB.Tagi.Include("Post")
                       where tags.keywords.Contains(id)
                       orderby tags.Post.data_dodania
                       select tags.Post;
            var strPost = new PaginatedList<Post>(post, page, pageSize);
            return View("WyswietlPosty",strPost);
        }
        
        [NonAction]
        public SelectList lista()
        {
            var list = new SelectList(new[]
            {
              new {ID="0",Name="Wyświetl"},
              new{ID="1",Name="Ukryj"},
             },"ID", "Name");

            return list;
        }
        
        //
        // GET: /Administracja/DodajPost

        public ActionResult DodajPost()
        {
            var post = new Post();

            ViewData["list"] = lista();
       
            return View(post);
        }

        //
        // POST: /Administracja/DodajPost

        [HttpPost]
        public ActionResult DodajPost(Post collection)
        {

            if (ModelState.IsValid)
            {
                DateTime now=DateTime.Now;
                now = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
                collection.data_dodania = now;
                
                blogDB.AddToPost(collection);
                blogDB.SaveChanges();
                int post_id = blogDB.Post.Single(p => p.data_dodania == collection.data_dodania).id;
                Tagi tag = new Tagi();
                tag.id_posta = post_id;
                return View("Tagi",tag);
            }


            else
            {
                ViewData["list"] = lista();
                return View(collection);
            }

        }

        //
        // POST: /Administracja/Create

        [HttpPost]//dodaj tagi
        public ActionResult Tagi(Tagi collection)
        {

            if (ModelState.IsValid)
            {
                blogDB.AddToTagi(collection);
                blogDB.SaveChanges();
                return RedirectToAction("Index");
            }

            else
            {
                return RedirectToAction("DodajPost");
            }

        }

        // GET: /Administracja/WyswietlPosty

        public ActionResult WyswietlPosty(int page=0)
        {
            var posty = from posts in blogDB.Post
                        orderby posts.data_dodania descending
                        select posts;

            var strPosty = new PaginatedList<Post>(posty, page, pageSize);

            return View(strPosty);
        }
        //
        // GET: /Administracja/Edit/5

        public ActionResult EdytujPost(int id)
        {
            Post post = blogDB.Post.Single(p => p.id == id);
            ViewData["list"] = lista();
            return View(post);
        }

        //
        // POST: /Administracja/Edit/5

        [HttpPost]
        public ActionResult EdytujPost(Post collection)
        {
            Post post = blogDB.Post.Single(p => p.id == collection.id);
            if (ModelState.IsValid)
            {
                collection.data_modyfikacji = DateTime.Now;

                post = collection;
                blogDB.Post.ApplyCurrentValues(post);
                blogDB.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewData["list"] = lista();

            return View(collection);
        }

        //
        // GET: /Administracja/Delete/5

        public ActionResult UsunPost(int id)
        {
            Post post = blogDB.Post.Single(p => p.id == id);
            return View(post);
        }

        //
        // POST: /Administracja/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Szukaj(string zapytanie, int page=0)
        {
            var wynik = from blog in blogDB.Post
                        where blog.tytul.Contains(zapytanie) || blog.tresc.Contains(zapytanie)
                        orderby blog.data_dodania descending
                        select blog;

            if (wynik.Count()==0)
                ViewData["komunikat"] = "Brak postów";

            var strPost = new PaginatedList<Post>(wynik, page, pageSize);

            return View("WyswietlPosty", strPost);
        }

        [ChildActionOnly]
        public ActionResult WysKomentarze(int id,int page=0)
        {
            var kom = from komentarze in blogDB.Komentarze
                      where komentarze.Post.id==id
                      orderby komentarze.data_dodania descending
                      select komentarze;

            if (kom.Count() == 0)
                ViewData["komunikat"] = "Brak komentarzów";

           // var strKomentarze = new PaginatedList<Komentarze>(kom, page, pageSize);
            return View(kom);
        }

        public ActionResult DodajKom()
        {
            Komentarze kom = new Komentarze();
            
            ViewData["list"] = lista();

            return PartialView(kom);
        }

        [HttpPost]
        public ActionResult DodajKom(Komentarze nkom)
        {
            if (ModelState.IsValid)
            {
                nkom.id_posta = nkom.id;//??
                nkom.id=0;
                nkom.data_dodania = DateTime.Now;

                blogDB.AddToKomentarze(nkom);
                blogDB.SaveChanges();
               
                ViewData["list"] = lista();
                return View();
            }
            else
            {
                ViewData["list"] = lista();
                return View(nkom);
            }
        }


        [HttpPost]
        public ActionResult UsunKom(int id)
        {
            Komentarze dkom = blogDB.Komentarze.Single(dk=>dk.id==id);
            blogDB.Komentarze.DeleteObject(dkom);
            blogDB.SaveChanges();
            
            
            var kom = from komentarze in blogDB.Komentarze
                      where komentarze.Post.id==dkom.id_posta
                      orderby komentarze.data_dodania descending
                      select komentarze;

            return PartialView("WysKomentarze", kom);
        }

        

    }
}
