using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Web.Models;
using System.Configuration;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        public ActionResult Index()
        {
            var model = new GreetingViewModel();
            // on Windows, this would use ConfigurationManager.AppSettings
            model.Message = ConfigurationSettings.AppSettings["message"];
            return View (model);
        }
    }
}
