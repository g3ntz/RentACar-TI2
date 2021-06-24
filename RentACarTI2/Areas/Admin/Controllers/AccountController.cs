using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACarTI2.BLL;
using Microsoft.AspNetCore.Http;

namespace RentACarTI2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            int loggedUserID = int.Parse(HttpContext.Session.GetString("UserID"));
            var loggedUser = new UserBLL().Get(loggedUserID);
            return View(loggedUser);
        }

        [HttpPost]
        public IActionResult Edit(Models.User user)
        {
            var response = new UserBLL().Modify(user);
            if(response == true)
            {
                // show message
            }

            return RedirectToAction("Index");
        }
    }
}
