﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jilebi.Domain
{
    public class EmployeeDomainModel
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }

        public string DepartmentName { get; set; }
    }
}
