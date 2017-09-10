using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyService.Models
{
    public class Stock
    {
        public int ItemID { get; set; }
        public int CuantityId { get; set; }
        public double CurrentPrice { get; set; }
    }
}