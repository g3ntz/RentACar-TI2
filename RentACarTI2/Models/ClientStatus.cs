using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarTI2.Models
{
    class ClientStatus:BaseAuditObject
    {
        public int ClientStatusID { get; set; }
        public string StatusName { get; set; }
    }
}
