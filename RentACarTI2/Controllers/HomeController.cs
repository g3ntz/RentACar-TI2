using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using RentACarTI2.BLL;

namespace RentACarTI2.Controllers
{
    public class HomeController : Controller
    {
        VehicleBLL bll;

        public HomeController()
        {
            bll = new VehicleBLL();
        }

        [Route("")]
        [Route("Home/Index")]
        public ActionResult Index()
        {
            var availableVehicles = bll.GetAll().Where(x => x.IsAvailable).ToList();
            return View(availableVehicles);
        }
    }
}
