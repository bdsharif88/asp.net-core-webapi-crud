﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPractice.ViewModels
{
    public class EmployeeVM
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }

        public string Department { get; set; }
        public string DateOfJoining { get; set; }
    }
}
