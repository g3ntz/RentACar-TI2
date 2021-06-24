using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACarTI2.BLL;

namespace RentACarTI2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Reservation/[action]")]
    public class BookingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"];

            var bookings = new BookingsBLL().GetAll();
            return View(bookings);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            var response = new BookingsBLL().Remove(id);
            if (response == true)
                TempData["response"] = "successfully deleted";
            else
                TempData["response"] = "error deleting";

            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Cancel(int id)
        {
            // CHECK IF THERE IS ANY RENTAL CREATED FROM THIS BOOKING
            var booking = new BookingsBLL().Get(id);
            var rentals = new RentalBLL().GetAll().Where(x => x.BookingID == booking.BookingID).ToList();
            if(rentals.Any())
            {
                TempData["response"] = "rental exists";
                return RedirectToAction("Index");
            }

            var response = new BookingsBLL().Cancel(id);
            if (response == true)
                TempData["response"] = "successfully canceled";
            else
                TempData["response"] = "error canceling";

            return RedirectToAction("Index");
        }
    }
}
