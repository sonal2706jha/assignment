using System;
using System.Collections.Generic;

namespace API_CORE.Models
{
    public partial class TblEmployees
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime? EmpDob { get; set; }
        public decimal? EmpSalary { get; set; }
        public int? ManagerId { get; set; }
        public bool? IsTrainer { get; set; }
    }
}
