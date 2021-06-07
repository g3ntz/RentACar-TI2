using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using RentACarTI2.Models;
using RentACarTI2.Interfaces;

namespace RentACarTI2.DAL
{
    public class ClientDAL : IBaseCrud<Client>, IBaseConvert<Client>
    {
        public bool Add(Client client)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_Clients_Insert",
                        CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("Name", client.Name);
                        command.Parameters.AddWithValue("Surname", client.Surname);
                        command.Parameters.AddWithValue("Birthdate", client.Birthdate);
                        command.Parameters.AddWithValue("Address", client.Address);
                        command.Parameters.AddWithValue("PhoneNr", client.PhoneNr);
                        command.Parameters.AddWithValue("DrivingLicense", client.DrivingLicense);
                        command.Parameters.AddWithValue("Email", client.Email);
                        command.Parameters.AddWithValue("LoggedUser", client.InsertBy);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Modify(Client client)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_Clients_Modify",
                        CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("ClientID", client.ClientID);
                        command.Parameters.AddWithValue("Name", client.Name);
                        command.Parameters.AddWithValue("Surname", client.Surname);
                        command.Parameters.AddWithValue("Birthdate", client.Birthdate);
                        command.Parameters.AddWithValue("Address", client.Address);
                        command.Parameters.AddWithValue("PhoneNr", client.PhoneNr);
                        command.Parameters.AddWithValue("DrivingLicense", client.DrivingLicense);
                        command.Parameters.AddWithValue("Email", client.Email);
                        command.Parameters.AddWithValue("LoggedUser", client.InsertBy);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(int id)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_Clients_Remove",
                        CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("ClientID", id);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(Client client)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            try
            {
                List<Client> result = null;
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_Clients_GetAll", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Client>();
                            while (reader.Read())
                            {
                                result.Add(ToObject(reader));
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Client Get(int id)
        {
            try
            {
                Client result = null; 
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_Clients_GetByID", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("ClientID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result = ToObject(reader);
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Client Get(Client client)
        {
            throw new NotImplementedException();
        }


        public Client ToObject(SqlDataReader reader)
        {
            Client client = new Client();
            client.ClientID = int.Parse(reader["ClientID"].ToString());
            client.Name = reader["Name"].ToString();
            client.Surname = reader["Surname"].ToString();
            client.Birthdate = Convert.ToDateTime(reader["Birthdate"].ToString());
            client.Address = reader["Address"].ToString();
            client.PhoneNr = reader["PhoneNr"].ToString();
            client.DrivingLicense = reader["DrivingLicense"].ToString();
            client.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "No Email";
            if (reader["UserID"] != DBNull.Value)
                client.UserID = int.Parse(reader["UserID"].ToString());

            client.user = new User();
            if(reader["UserID"] != DBNull.Value)
                client.user.UserID = int.Parse(reader["UserID"].ToString());
            if (reader["Username"] != DBNull.Value)
                client.user.Username = reader["Username"].ToString();
            if (reader["Email"] != DBNull.Value)
                client.user.Email = reader["Email"].ToString();
            if (reader["LastLoginDate"] != DBNull.Value)
                client.user.LastLoginDate = DateTime.Parse(reader["LastLoginDate"].ToString());

            client.init();
            return client;
        }
    }
}
