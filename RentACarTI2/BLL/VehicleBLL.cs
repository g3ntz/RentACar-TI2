using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using RentACarTI2.DAL;
using System.Linq;

namespace RentACarTI2.BLL
{
    public class VehicleBLL : IBaseCrud<Vehicle>
    {
        public static VehicleDAL dal = new VehicleDAL();
        public static VehicleImagesDAL dalTest = new VehicleImagesDAL();

        public bool Add(Vehicle model)
        {
            return dal.Add(model);
        }

        public Vehicle Get(int id)
        {
            var vehicle = dal.Get(id);
            return InitImagesToVehicle(vehicle);
        }

        public Vehicle Get(Vehicle model)
        {
            return dal.Get(model);
        }

        public List<Vehicle> GetAll()
        {
            List<Vehicle> vehicles = dal.GetAll();
            return InitImagesToVehicles(vehicles);
        }

        public bool Modify(Vehicle model)
        {
            return dal.Modify(model);
        }

        public bool Remove(int id)
        {
            return dal.Remove(id);
        }

        public bool Remove(Vehicle model)
        {
            return dal.Remove(model);
        }

        // CUSTOM METHODS
        public List<Vehicle> InitImagesToVehicles(List<Vehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.vehicleImages = dalTest.GetAll().Where(x => x.VehicleID == vehicle.VehicleID).ToList();
            }
            return vehicles;
        }

        public Vehicle InitImagesToVehicle(Vehicle vehicle)
        {
            vehicle.vehicleImages = dalTest.GetAll().Where(x => x.VehicleID == vehicle.VehicleID).ToList();
            return vehicle;
        }

        //public List<KeyValuePair<int, decimal>> GetVehicleSalesDaily()
        //{
        //    var vehicleSales = new Dictionary<int, decimal>();

        //    DateTime currentDate;
        //    int dayOfWeek = (int)DateTime.Today.DayOfWeek;
        //    int dayOfWeekFinal = dayOfWeek == 0 ? 7 : dayOfWeek;

        //    for (int startDate = 1; startDate <= dayOfWeekFinal; startDate++)
        //    {
        //        //currentDate = DateTime.Today.Date.AddDays(-dayOfWeekFinal + startDate);
        //        currentDate = new DateTime(2020, 9, 20);
        //        int salesThisDay = (int)new RentalBLL().GetAll().Where(x => x.Date.Date == currentDate.Date).Select(x => x.Booking.TotalPrice).Sum();
        //        vehicleSales.Add(startDate, salesThisDay);
        //    }
        //    return vehicleSales.ToList();
        //}

        //public List<KeyValuePair<int,decimal>> GetVehicleSalesMonthly()
        //{
        //    var vehicleSales = new Dictionary<int, decimal>();

        //    DateTime currentDate;
        //    int currentMonth = DateTime.Today.Month;

        //    var rentals = new RentalBLL().GetAll();
        //    for (int firstMonth = 1; firstMonth <= currentMonth; firstMonth++)
        //    {
        //        currentDate = DateTime.Today.Date.AddMonths(-currentMonth + firstMonth);
        //        //currentDate = new DateTime(2020, 9, 20);

        //        var salesThisMonth = rentals.Where(x => x.Date.Month == currentDate.Month).Select(x => x.Booking.TotalPrice).Sum();

        //        vehicleSales.Add(firstMonth, salesThisMonth);
        //    }
        //    return vehicleSales.ToList();
        //}

        public List<int> GetVehicleSalesDaily()
        {
            var vehicleSales = new List<int>();

            DateTime currentDate;
            int dayOfWeek = (int)DateTime.Today.DayOfWeek;
            int dayOfWeekFinal = dayOfWeek == 0 ? 7 : dayOfWeek;

            for (int startDate = 1; startDate <= dayOfWeekFinal; startDate++)
            {
                currentDate = DateTime.Today.Date.AddDays(-dayOfWeekFinal + startDate);

                int salesThisDay = (int)new RentalBLL().GetAll().Where(x => x.Date.Date == currentDate.Date).Select(x => x.Booking.TotalPrice).Sum();
                vehicleSales.Add(salesThisDay);
            }

            return vehicleSales;
        }

        public List<int> GetVehicleSalesMonthly()
        {
            var vehicleSales = new List<int>();

            DateTime currentDate;
            int currentMonth = DateTime.Today.Month;

            var rentals = new RentalBLL().GetAll();
            for (int firstMonth = 1; firstMonth <= currentMonth; firstMonth++)
            {
                currentDate = DateTime.Today.Date.AddMonths(-currentMonth + firstMonth);

                var salesThisMonth = (int)rentals.Where(x => x.Date.Month == currentDate.Month).Select(x => x.Booking.TotalPrice).Sum();

                vehicleSales.Add(salesThisMonth);
            }
            if(vehicleSales.Count < 12)
            {
                for (int i = vehicleSales.Count; i < 12; i++)
                {
                    vehicleSales.Add(0);
                }
            }
            return vehicleSales;
        }
    }
}
