using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACarTI2.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarTI2.Controllers
{
    public class VehiclesController : Controller
    {
        VehicleBLL bll;

        public VehiclesController()
        {
            bll = new VehicleBLL();
        }

        // GET: VehicleController
        [Route("Vehicles/Index")]
        public ActionResult Index(string make, string model, string category, string transmission, string fuelType, string seatsNr, string isAvailable, decimal price)
        {
            // SEND SELECTED FILTERS BACK TO VIEW AGAIN TO REMEMBER EACH FILTERING
            ViewBag.selectedMake = make;
            ViewBag.selectedModel = model;
            ViewBag.selectedCategory = category;
            ViewBag.selectedTransmission = transmission;
            ViewBag.selectedFuelType = fuelType;
            ViewBag.selectedSeatsNr = seatsNr;
            ViewBag.selectedIsAvailable = isAvailable;
            ViewBag.selectedPrice = price;

            var vehicles = bll.GetAll();

            // FILTERING
            if (make != null)
                vehicles = vehicles.Where(x => x.VehicleBrand.Make == make).ToList();

            if (model != null)
                vehicles = vehicles.Where(x => x.VehicleBrand.Model == model).ToList();

            if (category != null)
                vehicles = vehicles.Where(x => x.VehicleBrand.Category == category).ToList();

            if (transmission != null)
                vehicles = vehicles.Where(x => x.Transmission == transmission).ToList();

            if (fuelType != null)
                vehicles = vehicles.Where(x => x.FuelType == fuelType).ToList();

            if (seatsNr != null)
                vehicles = vehicles.Where(x => x.SeatsNr == int.Parse(seatsNr)).ToList();

            if (isAvailable != null)
            {
                if(isAvailable == "Yes")
                    vehicles = vehicles.Where(x => x.IsAvailable == true).ToList();
                else
                    vehicles = vehicles.Where(x => x.IsAvailable == false).ToList();
            }

            if(price != 0)
                vehicles = vehicles.Where(x => x.DailyPrice == price).ToList();


            return View(vehicles);
        }

        // GET: VehicleController/Details/5
        [Route("Vehicles/Details/{id}")]
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var vehicle = bll.Get(id);
            ViewBag.action = (string)TempData["action"];
            return View(vehicle);
        }
    }
}
