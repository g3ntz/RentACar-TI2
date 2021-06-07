using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using RentACarTI2.DAL;

namespace RentACarTI2.BLL
{
    public class ClientBLL : IBaseCrud<Client>
    {
        public static ClientDAL dal = new ClientDAL();

        public bool Add(Client client)
        {
            return dal.Add(client);
        }

        public Client Get(int id)
        {
            return dal.Get(id);
        }

        public Client Get(Client client)
        {
            return dal.Get(client);
        }

        public List<Client> GetAll()
        {
            return dal.GetAll();
        }

        public bool Modify(Client client)
        {
            return dal.Modify(client);
        }

        public bool Remove(int id)
        {
            return dal.Remove(id);
        }

        public bool Remove(Client client)
        {
            return dal.Remove(client);
        }
    }
}
