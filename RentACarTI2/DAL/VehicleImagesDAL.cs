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
            throw new NotImplementedException();
        }

        public VehicleImages Get(int id)
        {
            throw new NotImplementedException();
        }

        public VehicleImages Get(VehicleImages model)
        {
            throw new NotImplementedException();
            //try
            //{
            //    List<VehicleImages> result = null;

            //    using (var connection = SqlHelper.GetConnection())
            //    {
            //        using (var command = SqlHelper.Command(connection, "dbo.usp_VehicleImages_GetByVehicleID", CommandType.StoredProcedure))
            //        {
            //            command.Parameters.AddWithValue("VehicleID", model.VehicleID);

            //            using (SqlDataReader reader = command.ExecuteReader())
            //            {
            //                result = new List<VehicleImages>();
            //                while (reader.Read())
            //                {
            //                    result.Add(ToObject(reader));
            //                }
            //            }
            //        }
            //    }
            //    return result;
            //}
            //catch (Exception)
            //{
            //    return null;
            //}
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
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(VehicleImages model)
        {
            throw new NotImplementedException();
        }

        public VehicleImages ToObject(SqlDataReader reader)
        {
            VehicleImages vehicleImages = new VehicleImages();
            vehicleImages.ContentType = reader["ContentType"].ToString();
            vehicleImages.Path = reader["Path"].ToString();
            vehicleImages.Name = reader["Name"].ToString();
            vehicleImages.IsThumbnail = bool.Parse(reader["IsThumbnail"].ToString());
            vehicleImages.VehicleID = int.Parse(reader["VehicleID"].ToString());
            return vehicleImages;
        }
    }
}
