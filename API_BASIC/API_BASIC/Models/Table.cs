using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_BASIC.Models
{
    public class Table
    {
        public string EMP_NAME { get; set; }
        public int EMP_ID { get; set; }

        public string EMP_DOB { get; set; }

        public int EMP_SALARY { get; set; }

        public int MANAGER_ID { get; set; }

    }
}