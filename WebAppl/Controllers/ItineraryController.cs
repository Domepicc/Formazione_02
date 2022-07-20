using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebAppl.Models;

namespace WebAppl.Controllers
{
    public class ItineraryController : Controller
    {
        // GET: Itnerary
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new ItineraryItem();
            return View(model);
        }



        [HttpPost]
        public ActionResult Create(ItineraryItem data)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "The data you entered was not valid");
            }
            return View();
        }

        


        [HttpGet()]
        public JsonResult VerifyAvailability(DateTime When, string Description)
        {
            return Json(true, JsonRequestBehavior.AllowGet);
        }


    }
}