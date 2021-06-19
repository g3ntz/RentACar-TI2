using RentACarTI2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACarTI2.Models;
using RentACarTI2.DAL;

namespace RentACarTI2.BLL
{
    public class VehicleImagesBLL : IBaseCrud<VehicleImages>
    {
        public static VehicleImagesDAL DAL = new VehicleImagesDAL();

        public bool Add(VehicleImages model)
        {
            return DAL.Add(model);
        }

        public VehicleImages Get(int id)
        {
            throw new NotImplementedException();
        }

        public VehicleImages Get(VehicleImages model)
        {
            throw new NotImplementedException();
        }

        public List<VehicleImages> GetAll()
        {
            return DAL.GetAll();
        }

        public bool Modify(VehicleImages model)
        {
            return DAL.Modify(model);
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(VehicleImages model)
        {
            throw new NotImplementedException();
        }

        public bool ResetThumbnail(VehicleImages model)
        {
            return DAL.ResetThumbnail(model);
        }
    }
}
