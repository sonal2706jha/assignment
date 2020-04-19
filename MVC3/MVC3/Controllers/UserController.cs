using MVC3.Models.Custom;
using MVC3.Models.Filters;
using MVC3.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3.Controllers
{
    [CustomException]
    [RoutePrefix("User")]
    

        
        public class UserController : Controller
        {
            // GET: User
            readonly ILogin login;
            public UserController()
            {
                login = new Models.Services.Login();
            }
            public ActionResult Index()
            {

                var data = login.Display();
                return View(data);
            }

            [Route("{id}/Details")]
            [Route("{id}")]

            public ActionResult Details(int id)
            {

                var detail = login.Detail(id);
                return View(detail);

            }
        public ActionResult Edits(int id)
        {

            var edit = login.Edit(id);
            return View(edit);

        }
        [AurthorisationFilter(Order = 2)]
            [FilterB(Order = 1)]
            [Route("Action")]
            public ActionResult Action()
            {
                return View();
            }

        }
    }

