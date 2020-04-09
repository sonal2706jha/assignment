using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Question3mvc.Controllers
{
    //TempData:IT is the dictionaery of temp data dictionary.It is a poperty of BaseController.It is use to redirect the data from one page to another.
    //TempData keeps the value for the time of an HTTP Request. 
    //Using ReturnToAction("Tempview") we can redirect from one action to another action.
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            TempData["message"] = "Welcome to my MVC project";
            return new RedirectResult(@"~\Second\");
        }
    }
}