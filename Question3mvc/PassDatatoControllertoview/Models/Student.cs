﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassDatatoControllertoview.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}