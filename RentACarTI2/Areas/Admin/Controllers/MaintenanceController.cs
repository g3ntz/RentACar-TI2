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
    public class MaintenanceController : Controller
    {
        public IActionResult Index()
        {
            var maintenances = new MaintenancesBLL().GetAll();
            return View(maintenances);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Create(int id)
        {
            ViewBag.VehicleID = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Maintenance maintenance)
        {
            var response = new MaintenancesBLL().Add(maintenance);
            if (response == false)
            {
                // show user smth went wrong..
            }
            return View();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Edit(int id)
        {
            var existingMaintenance = new MaintenancesBLL().Get(id);
            if (existingMaintenance == null)
                return NotFound();

            return View(existingMaintenance);
        }

        [HttpPost]
        public IActionResult Edit(Models.Maintenance maintenance)
        {
            if (maintenance == null)
                return NotFound();

            var response = new MaintenancesBLL().Modify(maintenance);
            if (response == true)
            {
                ViewBag.response = "edited";
            }

            return View(maintenance);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            var response = new MaintenancesBLL().Remove(id);
            if (response == false)
            {
                // return error
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult CloseTransaction(int id)
        {
            var response = new MaintenancesBLL().CloseTransaction(id);
            if (response == false)
            {
                // return error
            }

            return RedirectToAction("Index");
        }
    }
}
