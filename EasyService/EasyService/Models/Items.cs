using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyService.Models
{
    public class Items
    {
        public int ItemId { get; set; }
        public int ItemNumber { get; set; }
        public string PicturePath { get; set; }
        public string Name { get; set; }
        public int ItemCategoryId { get; set; }
    }
}