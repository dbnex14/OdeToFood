using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using OdeToFood.Data.Services;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {
		IRestaurantData db;

		public HomeController(IRestaurantData db)
		{
            this.db = db;
		}

		public ActionResult Index()
		{
            //var mvcName = typeof(Controller).Assembly.GetName();
            //var isMono = Type.GetType("Mono.Runtime") != null;
            //ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            //ViewData["Runtime"] = isMono ? "Mono" : ".NET";
            //ViewData["Author"] = "Dino Buljubasic";
            var model = db.GetAll();
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
	}
}
