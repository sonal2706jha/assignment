using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceBlazor.Data
{
    public class LoginServices
    {
        private readonly ApplicationDbContext _db;

        public LoginServices(ApplicationDbContext db)
        {
            _db = db;
        }

        public string Register(Login login)
        {
            
            _db.Logins.Add(login);
            _db.SaveChanges();
            return "Success";
        }
        

    }
}
