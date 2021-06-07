using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarTI2.Models
{
    public class VehicleImages : BaseAuditObject
    {
        public int VehicleImageID { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public string Path { get; set; }
        public bool IsThumbnail { get; set; }

        public int VehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
