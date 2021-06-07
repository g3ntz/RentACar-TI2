using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarTI2.Models
{
    public class VehicleBrand:BaseAuditObject
    {
        public int VehicleBrandID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Category { get; set; }
    }
}
