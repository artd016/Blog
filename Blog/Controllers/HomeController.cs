using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;
using Blog.Helpers;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        BlogEntities blogDB = new BlogEntities();
        const int pageSize = 5;

        public ActionResult Index(int page = 0)
        {
            var posty = from posts in blogDB.Post
                        where posts.status==0
                        orderby posts.data_dodania descending
                        select posts;

            var strPosty = new PaginatedList<Post>(posty, page, pageSize);

            return View(strPosty);
        }
        public ActionResult Post(int year = 0, int month = 0, int day = 0, string id = "", int page = 0)
        {
            DateTime now, date2;
            id = id.Replace('_', ' ');

            if (month == 0 & day == 0 & year == 0)
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
                            where posts.data_dodania < now & posts.data_dodania > date2 & posts.status == 0
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
                           where posts.data_dodania < now & posts.data_dodania > date2 & posts.tytul.Equals(id)&posts.status==0
                           orderby posts.data_dodania
                           select posts;
                var strPost = new PaginatedList<Post>(post, page, pageSize);


                if (strPost.Count != 1)
                    return View(strPost);
                else
                {
                    int id_posta = strPost[0].id;

                    Tagi Tagi = blogDB.Tagi.Single(t => t.id_posta == id_posta);

                    List<string> lista_t = new List<string>();
                    int j = 0, k = 0;

                    for (int i = 0; i < Tagi.keywords.Length; i++)
                    {
                        if (Tagi.keywords[i] == ',')
                        {
                            lista_t.Add(Tagi.keywords.Substring(j, k).TrimStart(' '));
                            j = i;
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
        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public JsonResult FindItems(string searchText, int maxResults)
        {
            
                var wynik = from blog in blogDB.Post
                               where (blog.tytul.Contains(searchText)||blog.tresc.Contains(searchText))&blog.status==0
                               select blog.tytul;
                List<string> results = wynik.Take(maxResults).ToList();

                return Json(results);

        }
        [HttpPost]
        public ActionResult Szukaj(string zapytanie, int page = 0)
        {
            var wynik = from blog in blogDB.Post
                        where (blog.tytul.Contains(zapytanie) || blog.tresc.Contains(zapytanie)) & blog.status == 0
                        orderby blog.data_dodania descending
                        select blog;

            if (wynik.Count() == 0)
                ViewData["komunikat"] = "Brak postów";

            var strPost = new PaginatedList<Post>(wynik, page, pageSize);

            return View("Index", strPost);
        }
        public ActionResult PostyOznaczoneTagiem(string id, int page = 0)
        {
            var post = from tags in blogDB.Tagi.Include("Post")
                       where tags.keywords.Contains(id) & tags.Post.status==0
                       orderby tags.Post.data_dodania
                       select tags.Post;

            var strPost = new PaginatedList<Post>(post, page, pageSize);

            return View("Index", strPost);
        }

        [ChildActionOnly]
        public ActionResult WysKomentarze(int id, int page = 0)
        {
            var kom = from komentarze in blogDB.Komentarze
                      where komentarze.Post.id == id &komentarze.status==0
                      orderby komentarze.data_dodania descending
                      select komentarze;

            if (kom.Count() == 0)
                ViewData["komunikat"] = "Brak komentarzów";

            // var strKomentarze = new PaginatedList<Komentarze>(kom, page, pageSize);
            return View(kom);
        }
    }
}
