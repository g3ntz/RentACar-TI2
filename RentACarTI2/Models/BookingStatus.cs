using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarTI2.Models
{
    public class BookingStatus:BaseAuditObject
    {
        public int BookingStatusID { get; set; }
        public string StatusName { get; set; }
    }
}
