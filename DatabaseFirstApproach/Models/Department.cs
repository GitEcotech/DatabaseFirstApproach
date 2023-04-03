using System;
using System.Collections.Generic;

namespace DatabaseFirstApproach.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DeptNo { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
