using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACarTI2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Reservation/[action]")]
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
