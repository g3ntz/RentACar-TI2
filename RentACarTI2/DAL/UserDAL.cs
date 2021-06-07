using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using System.Data.SqlClient;
using System.Data;

namespace RentACarTI2.DAL
{
    public class UserDAL : IBaseCrud<User>,IBaseConvert<User>
    {
        public User Login(User user)
        {
            try
            {
                using (var conn = SqlHelper.GetConnection())
                {
                    using (var cmd = SqlHelper.Command(conn, "dbo.usp_Authenticate", CommandType.StoredProcedure))
                    {
                        SqlHelper.AddParameter(cmd, "Username", user.Username);
                        SqlHelper.AddParameter(cmd, "Email", user.Email);

                        using (var reader = cmd.ExecuteReader())
                        {
                            User result = null;
                            if (reader.Read())
                            {
                                //----------User
                                User User = new User();

                                User.UserID = int.Parse(reader["UserID"].ToString());
                                User.Username = reader["Username"].ToString();
                                User.Password = reader["Password"].ToString();

                                if (reader["LastLoginDate"] != DBNull.Value)
                                    User.LastLoginDate = (DateTime)reader["LastLoginDate"];

                                if (reader["LastPasswordChangeDate"] != DBNull.Value)
                                    User.LastPasswordChangeDate = (DateTime)reader["LastPasswordChangeDate"];

                                if (reader["IsPasswordChanged"] != DBNull.Value)
                                    User.IsPasswordChanged = reader["IsPasswordChanged"].ToString() == "1";

                                //-----------Role
                                User.Role = new Role();
                                User.Role.Name = reader["Name"].ToString();
                                User.Role.RoleID = (int)reader["RoleID"];


                                return User;
                            }
                            return result;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Register(Client client, User user)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_Clients_Register",
                        CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("Name", client.Name);
                        command.Parameters.AddWithValue("Surname", client.Surname);
                        command.Parameters.AddWithValue("Birthdate", client.Birthdate);
                        command.Parameters.AddWithValue("Address", client.Address);
                        command.Parameters.AddWithValue("PhoneNr", client.PhoneNr);
                        command.Parameters.AddWithValue("DrivingLicense", client.DrivingLicense);

                        command.Parameters.AddWithValue("Username", user.Username);
                        command.Parameters.AddWithValue("Email", user.Email);
                        command.Parameters.AddWithValue("Password", user.Password);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ChangePassword(string username,string actualPassword,string newPassword)
        {
            try
            {
                using (var conn = SqlHelper.GetConnection())
                {
                    using (var cmd = SqlHelper.Command(conn, "dbo.usp_ChangePassword", CommandType.StoredProcedure))
                    {
                        int result;
                        SqlHelper.AddParameter(cmd, "Username", username);
                        SqlHelper.AddParameter(cmd, "ActualPassword", actualPassword);
                        SqlHelper.AddParameter(cmd, "NewPassword", newPassword);
                        result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(User user)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_Users_Insert",
                        CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("Username", user.Username);
                        command.Parameters.AddWithValue("Password", user.Password);
                        command.Parameters.AddWithValue("Email", user.Email);
                        command.Parameters.AddWithValue("RoleID", user.RoleID);
                        command.Parameters.AddWithValue("LoggedUser", user.InsertBy);
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

        public User Get(int id)
        {
            try
            {
                User result = null;

                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_Users_GetByID", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("UserID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
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

        public User Get(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            try
            {
                List<User> result = null;
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "usp_Users_GetAll", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<User>();
                            while (reader.Read())
                            {
                                result.Add(ToObject(reader));
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

        public bool Modify(User user)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_Users_Modify",
                        CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("UserID", user.UserID);
                        command.Parameters.AddWithValue("Username", user.Username);
                        command.Parameters.AddWithValue("Email", user.Email);
                        command.Parameters.AddWithValue("RoleID", user.RoleID);
                        command.Parameters.AddWithValue("LoggedUser", user.InsertBy);
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
                    using (var command = SqlHelper.Command(connection, "dbo.usp_Users_Remove",
                        CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("UserID", id);
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

        public bool Remove(User model)
        {
            throw new NotImplementedException();
        }

        public User ToObject(SqlDataReader reader)
        {
            //----------User
            User User = new User();

            User.UserID = int.Parse(reader["UserID"].ToString());
            User.Username = reader["Username"].ToString();
            User.Password = reader["Password"].ToString();
            User.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : null;

            User.LastLoginDate = reader["LastLoginDate"] != DBNull.Value ? DateTime.Parse(reader["LastLoginDate"].ToString()) : DateTime.MinValue;
            User.LastPasswordChangeDate = reader["LastPasswordChangeDate"] != DBNull.Value ? DateTime.Parse(reader["LastPasswordChangeDate"].ToString()) : DateTime.MinValue;

            //-----------Role
            User.Role = new Role();
            User.Role.Name = reader["Name"].ToString();
            User.RoleID = int.Parse(reader["RoleID"].ToString());

            User.init();

            return User;
        }
    }
}
