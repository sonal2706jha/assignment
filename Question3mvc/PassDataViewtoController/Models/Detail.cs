using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassDataViewtoController.Models
{
    public class Detail
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }
        public string City { get; set; }
    }
}