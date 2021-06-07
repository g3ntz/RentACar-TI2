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
    }
}
