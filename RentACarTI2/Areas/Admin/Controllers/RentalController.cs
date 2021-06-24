using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACarTI2.BLL;

namespace RentACarTI2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class RentalController : Controller
    {
        public IActionResult Index()
        {
            var rentals = new RentalBLL().GetAll();

            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"];

            return View(rentals);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Create(int id)
        {
            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"];

            ViewBag.Booking = new BookingsBLL().Get(id);
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Rental_Return rental)
        {
            
            // CHECK IF BOOKING IS CANCELED OR RENTAL IS ALREADY CREATED
            var booking = new BookingsBLL().Get(rental.BookingID);
            if (booking.BookingStatusID == 2)
            {
                TempData["response"] = "rental already created";
                return RedirectToAction("Create", new { id = booking.BookingID });
            }
            else if (booking.BookingStatusID == 3)
            {
                TempData["response"] = "booking canceled";
                return RedirectToAction("Create", new { id = booking.BookingID });
            }
                

            rental.IsRental = true;
            var response = new RentalBLL().Add(rental);
            if (response == true)
                TempData["response"] = "successfully created rental";
            else
                TempData["response"] = "error creating rental";

            return RedirectToAction("Index");
        }
    }
}
