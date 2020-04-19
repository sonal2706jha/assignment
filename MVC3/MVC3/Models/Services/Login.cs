using MVC3.Models.Entity;
using MVC3.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MVC3.Models.Services
{
    public class Login : ILogin
    {
        public bool AuthenticateCreds(LoginDetail login)
        {
            try
            {
                MVC2Entities2 conn = new MVC2Entities2();
                var name = conn.LoginDetails.Where(x => x.Name == login.Name).Select(x => x.Name).ToList();
                var password = conn.LoginDetails.Where(x => x.Password == login.Password).Select(x => x.Password).ToList();
                if (login.Name == name.FirstOrDefault() && login.Password == password.FirstOrDefault())
                {

                    return true; ;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employee Detail(int id)
        {
            try
            {

                var context = new MVC2Entities2();
                var data = context.Employees.Where(x => x.ID == id).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Employee> Display()
        {
            try
            {
                MVC2Entities2 conn = new MVC2Entities2();
                var data = conn.Employees.ToList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employee Edit(int id)
        {
            try
            {

                var context = new MVC2Entities2();
                var data = context.Employees.Where(x => x.ID == id).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Employee> ShowData()
        {
            try
            {
                MVC2Entities2 conn = new MVC2Entities2();
                var data = conn.Employees.ToList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
    