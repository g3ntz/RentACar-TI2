using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarTI2.Models
{
    public class VehicleRegistration:BaseAuditObject
    {
        public int VehicleRegistrationID { get; set; }
        public DateTime  RegistrationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
