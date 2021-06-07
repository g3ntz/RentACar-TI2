using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using RentACarTI2.DAL;

namespace RentACarTI2.BLL
{
    public class RentalBLL : IBaseCrud<Rental_Return>
    {
        public static RentalDAL dal = new RentalDAL();

        public bool Add(Rental_Return model)
        {
            return dal.Add(model);
        }

        public Rental_Return Get(int id)
        {
            return dal.Get(id);
        }

        public Rental_Return Get(Rental_Return model)
        {
            return dal.Get(model);
        }

        public List<Rental_Return> GetAll()
        {
            return dal.GetAll();
        }

        public bool Modify(Rental_Return model)
        {
            return dal.Modify(model);
        }

        public bool Remove(int id)
        {
            return dal.Remove(id);
        }

        public bool Remove(Rental_Return model)
        {
            return dal.Add(model);
        }
    }
}
