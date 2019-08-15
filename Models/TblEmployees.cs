using System;
using System.Collections.Generic;

namespace CoreWebApiTest.Models
{
    public partial class TblEmployees
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public int? SkillId { get; set; }
        public int? YearsExperience { get; set; }
    }
}
