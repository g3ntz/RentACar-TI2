using Microsoft.AspNetCore.Http;
using RentACarTI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarTI2.Areas.Admin.ViewModels
{
    public class VehicleViewModel
    {
        public int VehicleID { get; set; }
        public int VehicleBrandID { get; set; }
        public int VehicleRegistrationID { get; set; }
        public string Transmission { get; set; }
        public int ProductionYear { get; set; }
        public decimal DailyPrice { get; set; } = 00.00M;
        public string PlateNr { get; set; }
        public int SeatsNr { get; set; }
        public string OtherInfos { get; set; }
        public bool IsAvailable { get; set; }
        public string FuelType { get; set; }
        public decimal FuelAmount { get; set; }
        public string VehicleActualCondition { get; set; }
        public bool InGoodCondition { get; set; }
        public string Mileage { get; set; }

        public VehicleBrand VehicleBrand { get; set; }
        public VehicleRegistration VehicleRegistration { get; set; }
        public List<VehicleImages> vehicleImages { get; set; }
        public List<IFormFile> photos { get; set; }
        public string imageThumbnailName { get; set; }
    }
}
