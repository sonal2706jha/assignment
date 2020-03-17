using API_CORE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API_CORE.Data
{
   public interface IEmployee
    {
        DataSet GetData();

        DataSet GetDataId(int EMP_ID);

        bool InsertData(EMP E);

        bool UpdateData(int EMP_ID,EMP E);

        DataSet DeleteData(EMP E);
        
    }
}
