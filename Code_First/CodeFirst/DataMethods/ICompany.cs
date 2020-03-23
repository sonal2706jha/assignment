using Codefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst.DataMethods
{
   public interface ICompany
    {
        IEnumerable<Customer> GetData();
        Customer GetId(int id);
        bool InsertData(Customer customer);

        bool UpdateData(int id, Orders orders);
        bool DeleteData(Orders orders);

    }
}
        