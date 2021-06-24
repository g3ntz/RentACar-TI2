using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using RentACarTI2.Models;
using RentACarTI2.BLL;
using Newtonsoft.Json;

namespace RentACarTI2.Controllers
{
    public class ReservationsController : Controller
    {
        BookingsBLL bookingsBLL;
        VehicleBLL vehicleBLL;

        public ReservationsController()
        {
            bookingsBLL = new BookingsBLL();
            vehicleBLL = new VehicleBLL();
        }

        [Route("reservations/reserve")]
        [HttpPost]
        public IActionResult Reserve(Booking booking)
        {
            // CHECK IF BOOKING DATE IS INVALID
            if(booking.RentalDate.Date >= DateTime.Now.Date && booking.RentalDate.Date < booking.ReturnDate.Date)
            {
                var vehicle = vehicleBLL.Get(booking.VehicleID);

                // IF VEHICLE IS NOT AVAILABLE JUST RETURN THE VIEW
                if (vehicle.IsAvailable == false)
                {
                    TempData["action"] = "not available";
                    return RedirectToAction("Details", "Vehicles", new { id = vehicle.VehicleID });
                }

                // CHECK IF CLIENT HAS ANY ACTIVE RESERVATION, IN THAT CASE CLIENT CANNOT RESERVE ANOTHER VEHICLE
                var clientID = HttpContext.Session.GetString("ClientID");
                var clientActiveReservations = bookingsBLL.GetAll().Where(x => x.ClientID == int.Parse(clientID) && x.BookingStatusID == 1).ToList();
                if (clientActiveReservations.Any())
                {
                    TempData["action"] = "active reservation";
                    return RedirectToAction("Details", "Vehicles", new { id = vehicle.VehicleID });
                }

                // FIND THE DIFFERENCE OF RENTAL AND RETURN DATE IN DAYS
                // MULTIPLY IT BY VEHICLE DAILY PRICE AND ASSIGN IT TO BOOKING PRICE
                var difference = booking.ReturnDate - booking.RentalDate;
                booking.TotalPrice = (decimal)difference.TotalDays * vehicle.DailyPrice;

                // RESERVE THE VEHICLE
                booking.ClientID = int.Parse(HttpContext.Session.GetString("ClientID"));
                var response = bookingsBLL.Add(booking);
                TempData["action"] = "just reserved";
                return RedirectToAction("Details", "Vehicles", new { id = booking.VehicleID });
            }
            TempData["action"] = "rental date error";
            return RedirectToAction("Details", "Vehicles", new { id = booking.VehicleID });
        }

        #region API CALLS

        [Route("reservations/GetReservationDetails/{id}")]
        [HttpGet]
        public ActionResult GetReservationDetails(int id)
        {
            RentalBLL rentalBLL = new RentalBLL();
            ReturnBLL returnBLL = new ReturnBLL();
            FeeBLL feeBLL = new FeeBLL();

            var reservation = bookingsBLL.Get(id);
            var rental = rentalBLL.GetAll().Where(x => x.BookingID == id).Where(x => x.IsRental == true).FirstOrDefault();
            var _return = returnBLL.GetAll().Where(x => x.BookingID == id).Where(x => x.IsRental == false).FirstOrDefault();

            Fee lateFees = null;
            Fee damageFees = null;

            if (_return != null)
            {
                lateFees = feeBLL.GetAll().Where(x => x.returnID == _return.Rental_ReturnID).Where(x => x.IsLate).FirstOrDefault();
                damageFees = feeBLL.GetAll().Where(x => x.returnID == _return.Rental_ReturnID).Where(x => !x.IsLate).FirstOrDefault();
            }

            var normalPrice = reservation.TotalPrice;
            var lateCosts = lateFees != null ? lateFees.Costs : 0.00M;
            var damageCosts = damageFees != null ? damageFees.Costs : 0.00M;
            var totalPrice = normalPrice + lateCosts + damageCosts;

            var obj = new
            {
                rental = rental,
                _return = _return,
                lateFees = lateFees,
                damageFees = damageFees,
                normalPrice = normalPrice,
                lateCosts = lateCosts,
                damageCosts = damageCosts,
                totalPrice = totalPrice
            };

            return Ok(JsonConvert.SerializeObject(obj));
        }

        [Route("reservations/EditReservationInfos/{id}")]
        [HttpGet]
        public ActionResult EditReservationInfos(int id)
        {
            var reservation = bookingsBLL.Get(id);
            var obj = new
            {
                rentalDate = reservation.RentalDate.Date.ToShortDateString(),
                returnDate = reservation.ReturnDate.Date.ToShortDateString(),
                vehicleInfos = reservation.vehicleInfos,
                totalPrice = reservation.TotalPrice,
                status = reservation.BookingStatusID
            };

            return Ok(JsonConvert.SerializeObject(obj));
        }

        [Route("reservations/EditReservation")]
        [HttpPost]
        public ActionResult EditReservation(Booking booking)
        {
            if (booking.RentalDate > DateTime.Now || booking.RentalDate < booking.ReturnDate)
            {
                var existingBooking = bookingsBLL.Get(booking.BookingID);
                if(existingBooking.BookingStatusID != 3)
                {
                    existingBooking.RentalDate = booking.RentalDate;
                    existingBooking.ReturnDate = booking.ReturnDate;
                    var difference = booking.ReturnDate - booking.RentalDate;
                    existingBooking.TotalPrice = (decimal)difference.TotalDays * booking.Vehicle.DailyPrice;
                    var response = bookingsBLL.Modify(existingBooking);
                }
                else
                {
                    TempData["isCanceled"] = "true";
                    RedirectToAction("Profile", "Account");
                }
            }
            return RedirectToAction("Profile","Account");
        }

        [Route("reservations/CancelReservation/{id}")]
        [HttpGet]
        public ActionResult CancelReservation(int id)
        {
            var existingBooking = bookingsBLL.Get(id);
            if(existingBooking.BookingStatusID != 3)
            {
                existingBooking.BookingStatusID = 3;
                var response = bookingsBLL.Modify(existingBooking);
                TempData["action"] = "just canceled";
            }
            else
            {
                TempData["action"] = "already canceled";
                RedirectToAction("Profile", "Account");
            }
            return RedirectToAction("Profile", "Account");
        }

        #endregion
    }
}
