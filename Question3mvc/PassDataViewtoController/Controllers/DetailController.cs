using PassDataViewtoController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassDataViewtoController.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Detail detail)
        {
            int personId = detail.PersonId;
            string name = detail.Name;
            int Age = detail.Age;
            string gender = detail.Gender;
            string city = detail.City;
            

            return View();
        }
    }
}