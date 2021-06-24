using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using RentACarTI2.DAL;
using System.Linq;

namespace RentACarTI2.BLL
{
    public class ReturnBLL : IBaseCrud<Rental_Return>
    {
        public static ReturnDAL dal = new ReturnDAL();

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
            var returnsWithFees = InitFees(dal.GetAll());
            return returnsWithFees;
        }

        public bool Modify(Rental_Return model)
        {
            return dal.Modify(model);
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Rental_Return model)
        {
            throw new NotImplementedException();
        }

        public bool CloseTransaction(int id)
        {
            return dal.CloseTransaction(id);
        }

        public List<Rental_Return> InitFees(List<Rental_Return> returns)
        {
            foreach (var Return in returns)
            {
                Return.Fees = new FeeBLL().GetAll().Where(x => x.returnID == Return.Rental_ReturnID).ToList();
            }
            return returns;
        }
    }
}
