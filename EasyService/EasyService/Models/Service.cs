using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyService.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public int VehicleId { get; set; }
        public int ServiceTypeId { get; set; }
        public string CurrentMilage { get; set; }
        public DateTime DateOfService { get; set; }
        public int EmployeeId { get; set; }
        public double Totali { get; set; }

    }
}