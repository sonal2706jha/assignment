using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceBlazor.Data
{
    public class NavServices
    {
        private readonly ApplicationDbContext _db;

        public NavServices(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Nav> GetNav()
        {
            var result = _db.Navs.ToList();

            return result;
        }
        public string AddNavBar(Nav nav)
        {
            if (_db.Navs.Any(x => x.Name == nav.Name))
            {
                return "Can not generate link with same name with same name";
            }
            else
            {
                _db.Navs.Add(nav);
                _db.SaveChanges();
                return "Successfully";

            }


        }

    }
}

    

