using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CORE.Models
{
    public class EMP
    {
        public string EMP_NAME { get; set; }
        public int EMP_ID { get; set; }

        public string EMP_DOB { get; set; }

        public int EMP_SALARY { get; set; }

        public int MANAGER_ID { get; set; }

    }
}
