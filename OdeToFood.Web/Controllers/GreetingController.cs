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
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            //access http context directly but this is not needed with asp.net mvc since
            // you can insterad pass it as parameter into the method and MVC framework
            // will do anything it can to populate that param.  It will look in QueryString
            // and find it there (among others).
            //var name = HttpContext.Request.QueryString["name"];
            // on Windows, this would use ConfigurationManager.AppSettings
            model.Message = ConfigurationSettings.AppSettings["message"];
            model.Name = name ?? "No name";
            return View (model);
        }
    }
}
