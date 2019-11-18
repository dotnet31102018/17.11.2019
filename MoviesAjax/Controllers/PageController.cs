using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies1711.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMovie()
        {
            return new FilePathResult("~/Views/Page/get.html", "text/html");
        }
        public ActionResult PostMovie()
        {
            return new FilePathResult("~/Views/Page/post.html", "text/html");
        }
        public ActionResult PutMovie()
        {
            return new FilePathResult("~/Views/Page/put.html", "text/html");
        }
        public ActionResult DeleteMovie()
        {
            return new FilePathResult("~/Views/Page/delete.html", "text/html");
        }
    }
}
