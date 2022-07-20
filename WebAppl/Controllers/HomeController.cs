using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebAppl.Models;

namespace WebAppl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new GreetingModel
            {
                Greeting = "Welcome to the World of MVC",
                Name = "Your friendly neighborhood MVC App"
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult GetAdsSimple()
        {
            var data = new StringBuilder();
            data.Append("<ul><li><img width='200' height='200' src='https://lapugliasegreta.it/wp-content/uploads/2015/11/produttori.jpg'></li>");
            data.Append("<li><img width='200' height='200' src='https://lapugliasegreta.it/wp-content/uploads/2015/11/produttori2.jpg'></li></ul>");
            return Json(data.ToString());
        }

        [HttpPost]
        public JsonResult getHelp()
        {
            var data = new StringBuilder();
            data.Append("<h2>prova del metodo getHelp<h2>");
            return Json(data.ToString());
        }




    }
}