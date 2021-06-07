using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.DAL;
using RentACarTI2.Models;
using RentACarTI2.ViewModels;
using RentACarTI2.Interfaces;

namespace RentACarTI2.BLL
{
    public class UserBLL : IBaseCrud<User>
    {
        public static UserDAL userDAL = new UserDAL();

        public static User Login(User user)
        {
            return userDAL.Login(user);
        }

        public static bool Register(Client client, User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            return userDAL.Register(client, user);
        }

        public static bool ChangePassword(string username,string actualPassword, string newPassword)
        {
            return userDAL.ChangePassword(username,actualPassword,newPassword);
        }

        // INTERFACE METHODS
        public List<User> GetAll()
        {
            List<User> users = userDAL.GetAll();            
            return users;
        }

        public bool Add(User user)
        {
            return userDAL.Add(user);
        }

        public bool Modify(User user)
        {
            return userDAL.Modify(user);
        }

        public bool Remove(int id)
        {
            return userDAL.Remove(id);
        }

        public bool Remove(User user)
        {
            return userDAL.Remove(user);
        }

        public User Get(int id)
        {
            return userDAL.Get(id);
        }

        public User Get(User model)
        {
            return userDAL.Get(model);
        }
    }
}
