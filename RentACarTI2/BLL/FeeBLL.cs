using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using RentACarTI2.DAL;

namespace RentACarTI2.BLL
{
    public class FeeBLL : IBaseCrud<Fee>
    {
        public static FeeDAL dal = new FeeDAL();

        public bool Add(Fee model)
        {
            return dal.Add(model);
        }

        public Fee Get(int id)
        {
            return dal.Get(id);
        }

        public Fee Get(Fee model)
        {
            return dal.Get(model);
        }

        public List<Fee> GetAll()
        {
            return dal.GetAll();
        }

        public bool Modify(Fee model)
        {
            return dal.Modify(model);
        }

        public bool Remove(int id)
        {
            return dal.Remove(id);
        }

        public bool Remove(Fee model)
        {
            return dal.Remove(model);
        }
    }
}
