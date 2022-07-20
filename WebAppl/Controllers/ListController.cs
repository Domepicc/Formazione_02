using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebAppl.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult List()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CancelItineraryItem(string id)
        {

            var data = new StringBuilder();
            data.Append($"<h2>prova del metodo getHelp {id}<h2>");
            return Json(data.ToString());
        }
    }
}