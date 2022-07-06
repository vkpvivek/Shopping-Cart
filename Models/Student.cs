using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstApp.Models
{
    public partial class Student
    {
        public int StdId { get; set; }
        public string StdName { get; set; }
        public int? StdAge { get; set; }
    }
}
