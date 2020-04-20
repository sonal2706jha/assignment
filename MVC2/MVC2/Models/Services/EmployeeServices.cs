using MVC2.Models.Entity;
using MVC2.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2.Models.Services
{
   public class EmployeeService : IEmployee
        {
            private readonly MVCEntities _ent;
            public EmployeeService()
            {
                _ent = new MVCEntities();
            }

            public IEnumerable<Employee> GetEmployees()
            {
                try
                {
                    var result = _ent.Employees.Select(e => e).ToList(); // using method syntext form of linq . 
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            public bool InsertEmployee(Employee employee) // insert method 
            {
                try
                {
                    _ent.Employees.Add(employee);
                    _ent.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
    }

