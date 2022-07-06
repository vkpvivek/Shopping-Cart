using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstApp.Models
{
    public partial class EmployeeTable
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAdd { get; set; }
        public int? EmpAge { get; set; }
        public decimal? EmpSal { get; set; }
    }
}
