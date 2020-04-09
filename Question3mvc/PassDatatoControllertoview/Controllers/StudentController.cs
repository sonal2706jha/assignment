using PassDatatoControllertoview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassDatatoControllertoview.Controllers
{
    //To Pass data from controller to view first we will make a model class then controller class and give defination of model class .
    //By using http post we will make insert of data.
    //Then we will make view of action method and pass the detail.
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            try
            {
                Student student = new Student
                {
                    Id = 101,
                    Name = "Sonal",
                    Detail = "Student of Cs Department",
                    Age = 20,
                    Gender = "Female"
                };
                ViewBag.Message = student;
                return View();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}