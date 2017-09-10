using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyService.Models
{
    public class Appointment
    {
        public int VehicleId { get; set; }
        public int AppointementId { get; set; }
        public int SlotNumber { get; set; }
        public DateTime StartTime { get; set; }
        public int ServiceTypeId { get; set; }
        public int StatusId { get; set; }
    }
}