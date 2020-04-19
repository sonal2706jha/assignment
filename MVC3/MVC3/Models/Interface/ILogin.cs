using MVC3.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace MVC3.Models.Interface
{
    interface ILogin
    {
        bool AuthenticateCreds(LoginDetail login);
        List<Employee> ShowData();

        List<Employee> Display();
        Employee Detail(int id);
        Employee Edit(int id);
    }
}
