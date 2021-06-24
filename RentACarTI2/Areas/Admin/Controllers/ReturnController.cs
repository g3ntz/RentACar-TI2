using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACarTI2.BLL;
using Newtonsoft.Json;

namespace RentACarTI2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ReturnController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"];

            var returns = new ReturnBLL().GetAll();
            return View(returns);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Create(int id)
        {
            var rental = new RentalBLL().Get(id);
            ViewBag.Rental = rental;

            var difference = DateTime.Today.Date - rental.Booking.ReturnDate.Date;
            var daysLate = difference.TotalDays;
            ViewBag.DaysLate = daysLate;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Rental_Return _return, bool isReturnedInTime)
        {
            var existingRental = new RentalBLL().Get(_return.Rental_ReturnID);

            if(isReturnedInTime == false)
            {
                var difference = DateTime.Today.Date - existingRental.Booking.ReturnDate.Date;
                var daysLate = difference.TotalDays;

                if (daysLate > 0)
                {
                    _return.Fee.Costs = CalculateFee(existingRental.Booking.ReturnDate, existingRental.Booking.Vehicle.DailyPrice);
                    _return.Fee.IsLate = true;
                    _return.Fee.IsPaid = false;
                    _return.Fee.returnDate = DateTime.Today;
                }
            }

            _return.BookingID = existingRental.BookingID;
            _return.Date = DateTime.Today;


            var response = new ReturnBLL().Add(_return);
            if (response == true)
                TempData["response"] = "successfully created return";
            else
                TempData["response"] = "error creating return";

            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult CloseTransaction(int id, bool fromDashboard)
        {
            string page = "Return";
            if (fromDashboard)
                page = "Home";

            // CHECK IF TRANSACTION IS ALREADY CLOSED
            var existingReturn = new ReturnBLL().Get(id);
            if(existingReturn.IsClosed)
            {
                TempData["response"] = "return is already closed";
                return RedirectToAction("Index", page, new { area = "Admin" });
            }

            // CHECK IF RETURN HAS DAMAGES
            var existingDamage = new FeeBLL().GetAll().Where(x => x.returnID == id && x.Reason != "").FirstOrDefault();
            if (existingDamage != null)
            {
                // CHECK IF REPAIR IS CREATED AND CLOSED FOR THIS RETURN
                var existingRepair = new RepairsBLL().GetAll().Where(x => x.Rental_ReturnID == id && x.IsRepaired == true).FirstOrDefault();
                if (existingRepair == null)
                {
                    TempData["response"] = "repair is not completed";
                    return RedirectToAction("Index", page, new { area = "Admin" });
                }
            }

            var response = new ReturnBLL().CloseTransaction(id);
            if (response == false)
                TempData["response"] = "error closing tran";
            else
                TempData["response"] = "successfully closed tran";

            return RedirectToAction("Index", page, new { area = "Admin" });
        }

        public decimal CalculateFee(DateTime returnDate, decimal dailyPrice)
        {
            var difference = DateTime.Today.Date - returnDate.Date;
            var daysLate = difference.TotalDays;
            return (decimal)daysLate * dailyPrice;
        }

        #region API CALLS

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetFullDetails(int id)
        {
            var @return = new ReturnBLL().Get(id);
            var rental = new RentalBLL().GetAll().Where(x => x.BookingID == @return.BookingID && x.IsRental).FirstOrDefault();
            var booking = new BookingsBLL().Get(@return.BookingID);
            var damage = new FeeBLL().GetAll().Where(x => x.returnID == id && x.IsLate == false).FirstOrDefault();
            var late = new FeeBLL().GetAll().Where(x => x.returnID == id && x.IsLate == true).FirstOrDefault();

            int daysLate = 0;
            if(late != null)
            {
                var difference = @return.Date.Date - booking.ReturnDate.Date;
                daysLate = Convert.ToInt32((difference.TotalDays));
            }

            var obj = new
            {
                booking = booking,
                rental = rental,
                @return = @return,
                damage = damage,
                late = late,
                daysLate = daysLate
            };

            return Ok(JsonConvert.SerializeObject(obj));
        }

        #endregion
    }
}
