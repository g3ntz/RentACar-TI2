using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarTI2.Models
{
    public class BaseAuditObject
    {
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LUB { get; set; }
        public DateTime LUD { get; set; }
        public int LUN { get; set; }
    }
}
