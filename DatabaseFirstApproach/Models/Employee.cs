using System;
using System.Collections.Generic;

namespace DatabaseFirstApproach.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public long? Phone { get; set; }
        public int? Salary { get; set; }
        public int? DeptNo { get; set; }

        public virtual Department DeptNoNavigation { get; set; }
    }
}
