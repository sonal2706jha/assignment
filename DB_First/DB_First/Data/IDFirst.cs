using _dFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _dFirst.Data
{
   public interface IDFirst 
    {
        public IEnumerable<Customers> Show ();
        public IEnumerable<Customers> GetId(int id);

        public string Insert(Orders orders);

        public string Update(Orders orders);

        public string Delete(Orders orders);
    }
}
