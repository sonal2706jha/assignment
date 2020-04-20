using MVC2.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC2.Models.Interface
{
    interface IEmployee
    {
       
            IEnumerable<Employee> GetEmployees();
            bool InsertEmployee(Employee employee);
        
    }
}
