using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACarTI2.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace RentACarTI2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class VehicleController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public VehicleController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            var vehicles = new VehicleBLL().GetAll();

            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"];
            
            return View(vehicles);
        }

        [HttpGet]
        public ActionResult Create()
        {
            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"].ToString();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ViewModels.VehicleViewModel vehicleModel)
        {
            Models.Vehicle vehicle = new Models.Vehicle()
            {
                VehicleBrand = new Models.VehicleBrand()
                {
                    Make = vehicleModel.VehicleBrand.Make,
                    Model = vehicleModel.VehicleBrand.Model,
                    Category = vehicleModel.VehicleBrand.Category
                },
                VehicleRegistration = new Models.VehicleRegistration()
                {
                    RegistrationDate = vehicleModel.VehicleRegistration.RegistrationDate
                },
                Transmission = vehicleModel.Transmission,
                ProductionYear = vehicleModel.ProductionYear,
                DailyPrice = vehicleModel.DailyPrice,
                PlateNr = vehicleModel.PlateNr,
                SeatsNr = vehicleModel.SeatsNr,
                Mileage = vehicleModel.Mileage,
                OtherInfos = vehicleModel.OtherInfos,
                VehicleActualCondition = vehicleModel.VehicleActualCondition,
                FuelType = vehicleModel.FuelType,
                FuelAmount = vehicleModel.FuelAmount,

            };

            // ADD VEHICLE
            var response = new VehicleBLL().Add(vehicle);
            if (response == false)
            {
                ViewBag.Response = "error creating vehicle";
                return View();
            }
            else
                ViewBag.Response = "successfully created vehicle";

            // ADD VEHICLE IMAGES
            string uniqueFileName;
            bool imgResponse = false;
            int addedVehicleID = new VehicleBLL().GetAll().Select(x => x.VehicleID).Max();
            if (vehicleModel.photos != null && vehicleModel.photos.Count > 0)
            {
                foreach (IFormFile photo in vehicleModel.photos)
                {

                    var uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "assets\\vehicleImages");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    Models.VehicleImages vehicleImages = new Models.VehicleImages()
                    {
                        Name = uniqueFileName,
                        ContentType = photo.ContentType,
                        Path = uniqueFileName,
                        VehicleID = addedVehicleID,
                        IsThumbnail = photo.FileName == vehicleModel.imageThumbnailName ? true : false
                    };
                    imgResponse = new VehicleImagesBLL().Add(vehicleImages);
                    if (imgResponse == false)
                    {
                        ViewBag.Response = "error creating images";
                    }
                }
            }

            if (ViewBag.Response == "successfully created vehicle")
            {
                TempData["response"] = "successfully created vehicle";
                return RedirectToAction("Index");
            }
            
            return View();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Edit(int id)
        {
            var existingVehicle = new VehicleBLL().Get(id);

            if (existingVehicle == null)
                return NotFound();

            ViewModels.VehicleViewModel vehicleViewModel = new ViewModels.VehicleViewModel()
            {
                VehicleBrand = new Models.VehicleBrand()
                {
                    Make = existingVehicle.VehicleBrand.Make,
                    Model = existingVehicle.VehicleBrand.Model,
                    Category = existingVehicle.VehicleBrand.Category
                },
                VehicleRegistration = new Models.VehicleRegistration()
                {
                    RegistrationDate = existingVehicle.VehicleRegistration.RegistrationDate
                },
                VehicleID = existingVehicle.VehicleID,
                Transmission = existingVehicle.Transmission,
                ProductionYear = existingVehicle.ProductionYear,
                DailyPrice = existingVehicle.DailyPrice,
                PlateNr = existingVehicle.PlateNr,
                SeatsNr = existingVehicle.SeatsNr,
                Mileage = existingVehicle.Mileage,
                OtherInfos = existingVehicle.OtherInfos,
                VehicleActualCondition = existingVehicle.VehicleActualCondition,
                FuelType = existingVehicle.FuelType,
                FuelAmount = existingVehicle.FuelAmount,
                IsAvailable = existingVehicle.IsAvailable,
                InGoodCondition = existingVehicle.InGoodCondition,
                vehicleImages = existingVehicle.vehicleImages
            };

            foreach (var image in vehicleViewModel.vehicleImages)
            {
                if (image.IsThumbnail)
                    vehicleViewModel.imageThumbnailName = image.Path;
            }

            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"];

            return View(vehicleViewModel);
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult Edit(ViewModels.VehicleViewModel vehicleModel)
        {
            if (vehicleModel == null)
                return NotFound();

            Models.Vehicle vehicle = new Models.Vehicle()
            {
                VehicleBrand = new Models.VehicleBrand()
                {
                    Make = vehicleModel.VehicleBrand.Make,
                    Model = vehicleModel.VehicleBrand.Model,
                    Category = vehicleModel.VehicleBrand.Category
                },
                VehicleRegistration = new Models.VehicleRegistration()
                {
                    RegistrationDate = vehicleModel.VehicleRegistration.RegistrationDate
                },
                VehicleID = vehicleModel.VehicleID,
                Transmission = vehicleModel.Transmission,
                ProductionYear = vehicleModel.ProductionYear,
                DailyPrice = vehicleModel.DailyPrice,
                PlateNr = vehicleModel.PlateNr,
                SeatsNr = vehicleModel.SeatsNr,
                Mileage = vehicleModel.Mileage,
                OtherInfos = vehicleModel.OtherInfos,
                VehicleActualCondition = vehicleModel.VehicleActualCondition,
                FuelType = vehicleModel.FuelType,
                FuelAmount = vehicleModel.FuelAmount,

            };

            // EDIT VEHICLE
            var response = new VehicleBLL().Modify(vehicle);
            if (response == false)
            {
                TempData["response"] = "error editing vehicle";
            }

            // ADD VEHICLE NEW IMAGES
            string uniqueFileName;
            bool imgResponse = false;
            int VehicleID = vehicleModel.VehicleID;
            string photoNameGuid = null;
            if (vehicleModel.photos != null && vehicleModel.photos.Count > 0)
            {
                foreach (IFormFile photo in vehicleModel.photos)
                {

                    var uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "assets\\vehicleImages");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    Models.VehicleImages vehicleImage = new Models.VehicleImages()
                    {
                        Name = uniqueFileName,
                        ContentType = photo.ContentType,
                        Path = uniqueFileName,
                        VehicleID = VehicleID,
                        IsThumbnail = photo.FileName == vehicleModel.imageThumbnailName ? true : false
                    };

                    if (vehicleImage.IsThumbnail)
                        photoNameGuid = vehicleImage.Path;

                    imgResponse = new VehicleImagesBLL().Add(vehicleImage);
                    if (imgResponse == false)
                        TempData["response"] = "error adding images";
                }
            }

            // EDIT THUMBNAIL
            var vehicleImages = new VehicleImagesBLL().GetAll().Where(x => x.VehicleID == VehicleID).ToList();
            foreach (var image in vehicleImages)
            {
                if (photoNameGuid != null)
                    image.IsThumbnail = photoNameGuid == image.Path ? true : false;
                else
                    image.IsThumbnail = vehicleModel.imageThumbnailName == image.Path ? true : false;
                var thumbnailResponse = new VehicleImagesBLL().Modify(image);
                if (thumbnailResponse == false)
                    TempData["response"] = "error changing thumbnail";
            }

            if (TempData["response"] == null)
                TempData["response"] = "successfully edited vehicle";

            return RedirectToAction("Edit");
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            // FIRST DELETE VEHICLE IMAGES FROM WWWROOT DIRECTORY
            var vehicleImages = new VehicleImagesBLL().GetAll().Where(x => x.VehicleID == id).ToList();
            foreach (var image in vehicleImages)
            {
                string fullPath = Path.Combine(_hostingEnvironment.WebRootPath, "assets\\vehicleImages\\" + image.Path);
                if (System.IO.File.Exists(fullPath))
                {
                    System.IO.File.Delete(fullPath);
                }
            }

            // DELETE VEHICLE FROM DATABASE
            var response = new VehicleBLL().Remove(id);
            if (response == true)
                TempData["response"] = "deleted successfully";
            else
                TempData["response"] = "error deleting";

            return RedirectToAction("Index", "Vehicle");
        }
    }
}
