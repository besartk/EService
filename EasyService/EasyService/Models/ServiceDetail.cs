using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyService.Models
{
    public class ServiceDetail
    {
        public int ServiceId { get; set; }
        public int ItemId { get; set; }
        public int ActiveTypeId { get; set; }
        public int Cuantity { get; set; }
        public double Price { get; set; }
    }
}