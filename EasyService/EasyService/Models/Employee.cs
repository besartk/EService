using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyService.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string PersonalNumberId { get; set; }
        public int RoleID { get; set; }
    }
}