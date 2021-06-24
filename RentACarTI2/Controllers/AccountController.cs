using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using RentACarTI2.ViewModels;
using RentACarTI2.BLL;
using Microsoft.AspNetCore.Http;
using RentACarTI2.Models;
using RentACarTI2.CustomHelpers;

namespace RentACarTI2.Controllers
{
    public class AccountController : Controller
    {
        UserBLL userBll;
        ClientBLL clientBLL;
        BookingsBLL bookingsBLL;

        public AccountController()
        {
            userBll = new UserBLL();
            clientBLL = new ClientBLL();
            bookingsBLL = new BookingsBLL();
        }

        [Route("account/register")]
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [Route("account/register")]
        [HttpPost]
        public IActionResult Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                var rvmClient = new Client()
                {
                    Name = rvm.Name,
                    Surname = rvm.Surname,
                    Birthdate = rvm.Birthdate,
                    Address = rvm.Address,
                    PhoneNr = rvm.PhoneNr,
                    DrivingLicense = rvm.DrivingLicense
                };
                var rvmUser = new User()
                {
                    Username = rvm.Username,
                    Email = rvm.Email,
                    Password = rvm.Password
                };

                var response = UserBLL.Register(rvmClient, rvmUser);
                if (response == true)
                {
                    var latestUserID = userBll.GetAll().Max(x => x.UserID);
                    var user = userBll.Get(latestUserID);
                    var client = clientBLL.GetAll().Where(x => x.UserID == user.UserID).FirstOrDefault();
                    HttpContext.Session.SetString("UserID", user.UserID.ToString());
                    HttpContext.Session.SetString("Username", user.Username);
                    HttpContext.Session.SetString("ClientID", client.ClientID.ToString());
                    HttpContext.Session.SetString("Role", "Client");
                    HttpContext.Session.SetString("RoleID", user.Role.RoleID.ToString());
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [Route("account/login")]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [Route("account/login")]
        [HttpPost]
        public ActionResult Login(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                var user = new User() { Email = lvm.UsernameOrEmail, Password = lvm.Password };
                var returnedUser = UserBLL.Login(UsernameOrEmail.usernameOrEmail(user));

                // CHECK IF USERNAME OR EMAIL IS VALID
                if (returnedUser != null)
                {
                    // CHECK IF PASSWORD IS VALID
                    if (BCrypt.Net.BCrypt.Verify(user.Password, returnedUser.Password) == true)
                    {
                        var userID = returnedUser.UserID;
                        var clientID = clientBLL.GetAll().Where(x => x.UserID == userID).Select(x => x.ClientID).FirstOrDefault();
                        HttpContext.Session.SetString("Username", returnedUser.Username);
                        HttpContext.Session.SetString("UserID", userID.ToString());
                        HttpContext.Session.SetString("ClientID", clientID.ToString());
                        HttpContext.Session.SetString("Role", returnedUser.Role.Name);
                        HttpContext.Session.SetString("RoleID", returnedUser.Role.RoleID.ToString());

                        // CHECK IF IS ADMIN
                        if (returnedUser.Role.Name == "Admin")
                            return RedirectToAction("Index","Home", new { area = "Admin" });

                        return RedirectToAction("Index", "Home");
                    }
                }
                ViewBag.InvalidData = true;
            }

            return View();
        }

        [Route("account/profile")]
        [HttpGet]
        public ActionResult Profile()
        {
            var clientID = HttpContext.Session.GetString("ClientID");
            ViewBag.ClientID = clientID;

            // GET CLIENT EXPIRED RESERVATIONS THAT ARE NOT UPDATED TO CANCELED
            var clientExpiredReservations = bookingsBLL.GetAll().Where(x => x.ClientID == int.Parse(clientID) && x.BookingStatusID == 1 && x.RentalDate.Date < DateTime.Now.Date).ToList();
            if(clientExpiredReservations.Any())
            {
                foreach (var reservation in clientExpiredReservations)
                {
                    // SET THE RESERVATION STATUS TO CANCELED
                    var existingReservation = bookingsBLL.Get(reservation.BookingID);
                    existingReservation.BookingStatusID = 3;
                    bookingsBLL.Modify(existingReservation);
                }
            }
            ViewBag.action = (string)TempData["action"];

            return View();
        }

        [Route("account/profile")]
        [HttpPost]
        public ActionResult Profile(RegisterViewModel rvm)
        {
            // RegisterViewModel IS RE-USED FOR USER PROFILE EDITING
            // PASSWORD AND CONFIRM PASSWORD ARE NOT NEEDED IN PROFILE PAGE
            ModelState.Remove("Password");
            ModelState.Remove("ConfirmPassword");

            if (ModelState.IsValid)
            {
                var user = new User();
                user.UserID = int.Parse(HttpContext.Session.GetString("UserID"));
                user.Username = rvm.Username;
                user.Email = rvm.Email;
                user.RoleID = int.Parse(HttpContext.Session.GetString("RoleID"));

                var client = new Client();
                client.ClientID = int.Parse(HttpContext.Session.GetString("ClientID"));
                client.Name = rvm.Name;
                client.Surname = rvm.Surname;
                client.Birthdate = rvm.Birthdate;
                client.DrivingLicense = rvm.DrivingLicense;
                client.PhoneNr = rvm.PhoneNr;
                client.Address = rvm.Address;
                var userResponse = userBll.Modify(user);
                var clientResponse = clientBLL.Modify(client);
                if (userResponse == true && clientResponse == true)
                    return RedirectToAction("Profile", "Account");
                else
                {
                    ViewBag.ClientID = HttpContext.Session.GetString("ClientID");
                    return View();
                }
            }
            ViewBag.ClientID = HttpContext.Session.GetString("ClientID");
            return View();
        }

        [Route("account/logout")]
        [HttpGet]
        public ActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
