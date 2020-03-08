using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Slider()
        {
            //var items = new Models.Slide().GetList();
            //return PartialView("Slider", items);
            return PartialView("Slider");
        }
        public ActionResult Base64Encode()
        {
            var qs = Utils.Rq("c");
            var retV = Utils.Base64Encode(qs);
            Log.AddLogEntry("-" + retV);
            return PartialView("Error");
        }
        public ActionResult Base64Decode()
        {
            var qs = Utils.Rq("c");
            var retV = Utils.Base64Decode(qs);
            Log.AddLogEntry("-" + retV);
            return PartialView("Error");
        }
    }
}