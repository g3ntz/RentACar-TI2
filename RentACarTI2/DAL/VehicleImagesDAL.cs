using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarTI2.DAL
{
    public class VehicleImagesDAL : IBaseConvert<VehicleImages>, IBaseCrud<VehicleImages>
    {
        public bool Add(VehicleImages model)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_VehicleImages_Insert",
                        CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("Name", model.Name);
                        command.Parameters.AddWithValue("ContentType", model.ContentType);
                        command.Parameters.AddWithValue("Path", model.Path);
                        command.Parameters.AddWithValue("VehicleID", model.VehicleID);
                        command.Parameters.AddWithValue("IsThumbnail", model.IsThumbnail);

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
            try
            {
                List<VehicleImages> result = null;
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_VehicleImages_GetAll", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<VehicleImages>();
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

        public bool Modify(VehicleImages model)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_VehicleImages_Modify",
                        CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("VehicleImageID", model.VehicleImageID);
                        command.Parameters.AddWithValue("Name", model.Name);
                        command.Parameters.AddWithValue("ContentType", model.ContentType);
                        command.Parameters.AddWithValue("Path", model.Path);
                        command.Parameters.AddWithValue("VehicleID", model.VehicleID);
                        command.Parameters.AddWithValue("IsThumbnail", model.IsThumbnail);

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
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {
                    using (var command = SqlHelper.Command(connection, "dbo.usp_VehicleImages_ResetThumbnail",
                        CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("VehicleID", model.VehicleID);

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

        public VehicleImages ToObject(SqlDataReader reader)
        {
            VehicleImages vehicleImages = new VehicleImages();
            vehicleImages.VehicleImageID = int.Parse(reader["VehicleImageID"].ToString());
            vehicleImages.ContentType = reader["ContentType"].ToString();
            vehicleImages.Path = reader["Path"].ToString();
            vehicleImages.Name = reader["Name"].ToString();
            vehicleImages.IsThumbnail = bool.Parse(reader["IsThumbnail"].ToString());
            vehicleImages.VehicleID = int.Parse(reader["VehicleID"].ToString());
            return vehicleImages;
        }
    }
}
