﻿using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using RentACarTI2.DAL;

namespace RentACarTI2.BLL
{
    public class RepairsBLL : IBaseCrud<Repair>
    {
        public static RepairsDAL dal = new RepairsDAL();

        public bool Add(Repair model)
        {
            return dal.Add(model);
        }

        public Repair Get(int id)
        {
            return dal.Get(id);
        }

        public Repair Get(Repair model)
        {
            return dal.Get(model);
        }

        public List<Repair> GetAll()
        {
            return dal.GetAll();
        }

        public bool Modify(Repair model)
        {
            return dal.Modify(model);
        }

        public bool Remove(int id)
        {
            return dal.Remove(id);
        }

        public bool Remove(Repair model)
        {
            return dal.Remove(model);
        }
    }
}
