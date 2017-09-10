using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyService.Models
{
    public class Vehicle
    {
        public string VehicleNumber { get; set; }
        public DateTime ProductYear { get; set; }
        public string LicensePlate { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public string CurrentMilage { get; set; }
        public string FuelType { get; set; }

    }
}