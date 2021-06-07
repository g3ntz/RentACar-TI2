using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.DAL;
using RentACarTI2.Models;
using RentACarTI2.Interfaces;

namespace RentACarTI2.BLL
{
    public class VehicleBrandBLL : IBaseCrud<VehicleBrand>
    {
        public static VehicleBrandDAL vehicleBrandDAL = new VehicleBrandDAL();

        public bool Add(VehicleBrand model)
        {
            return vehicleBrandDAL.Add(model);
        }

        public VehicleBrand Get(int id)
        {
            return vehicleBrandDAL.Get(id);
        }

        public VehicleBrand Get(VehicleBrand model)
        {
            return vehicleBrandDAL.Get(model);
        }

        public List<VehicleBrand> GetAll()
        {
            return vehicleBrandDAL.GetAll();
        }

        public bool Modify(VehicleBrand model)
        {
            return vehicleBrandDAL.Modify(model);
        }

        public bool Remove(int id)
        {
            return vehicleBrandDAL.Remove(id);
        }

        public bool Remove(VehicleBrand model)
        {
            return vehicleBrandDAL.Remove(model);
        }

        public List<VehicleBrand> getModelAndCategory(string make)
        {
            return vehicleBrandDAL.getModelAndCategory(make);
        }
    }
}
