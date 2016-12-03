using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWS.Models
{
    public class Unit
    {
        public int UomId { get; set; }
        public string UomDesc { get; set; }
        public int ConversionRate { get; set; }
    }
}