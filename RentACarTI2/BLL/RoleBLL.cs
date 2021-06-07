using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.DAL;
using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using System.Data.SqlClient;

namespace RentACarTI2.BLL
{
    public class RoleBLL : IBaseCrud<Role>
    {
        public static RoleDAL roleDAL;

        public RoleBLL()
        {
            roleDAL = new RoleDAL();
        }

        public bool Add(Role role)
        {
            return roleDAL.Add(role);
        }

        public bool Modify(Role role)
        {
            return roleDAL.Modify(role);
        }

        public bool Remove(int id)
        {
            return roleDAL.Remove(id);
        }

        public bool Remove(Role model)
        {
            return roleDAL.Remove(model);
        }

        public List<Role> GetAll()
        {
            return roleDAL.GetAll();
        }

        public Role Get(int id)
        {
            return roleDAL.Get(id);
        }

        public Role Get(Role role)
        {
            return roleDAL.Get(role);
        }
    }
}
