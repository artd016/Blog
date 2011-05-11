using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        BlogEntities blogDB = new BlogEntities();

        public ActionResult Index()
        {
            var Vblog = blogDB.Post.ToList();
            if(Vblog.Count>0)
                return View(Vblog);
            return View("Brak");
        }

        public ActionResult Post(int id)
        {
            return View();
        }
        public ActionResult Data(DateTime data)
        {
            return View();
        }
    }
}
