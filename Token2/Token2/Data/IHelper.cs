using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Token2.Models;

namespace Token2.Data
{
  public  interface IHelper
    {
        string TokenGenerate(Login login);
    }
}
