using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAPClinet.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}