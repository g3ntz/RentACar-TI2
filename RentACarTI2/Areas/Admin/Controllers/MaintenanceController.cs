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

            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"];

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
                TempData["response"] = "error creating maintenance";
            else
                TempData["response"] = "successfully created maintenance";

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Edit(int id, bool fromDashboard)
        {
            if (fromDashboard)
                ViewBag.fromDashboard = true;

            var existingMaintenance = new MaintenancesBLL().Get(id);
            if (existingMaintenance == null)
                return NotFound();
            if (existingMaintenance.IsReturned)
            {
                TempData["response"] = "maintenance is closed";
                return RedirectToAction("Index");
            }

            return View(existingMaintenance);
        }

        [HttpPost]
        public IActionResult Edit(Models.Maintenance maintenance, bool fromDashboard)
        {
            ViewBag.fromDashboard = fromDashboard;

            if (maintenance == null)
                return NotFound();

            var response = new MaintenancesBLL().Modify(maintenance);
            if (response == true)
                ViewBag.response = "edited successfully";
            else
                ViewBag.Response = "error editing";

            return View(maintenance);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Delete(int id, bool fromDashboard = false)
        {
            string page = "Maintenance";
            if (fromDashboard)
                page = "Home";

            var response = new MaintenancesBLL().Remove(id);
            if (response == false)
                TempData["response"] = "error deleting maintenance";
            else
                TempData["response"] = "successfully deleted maintenance";

            return RedirectToAction("Index", page, new { area = "Admin" });
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult CloseTransaction(int id, bool fromDashboard)
        {
            string page = "Maintenance";
            if (fromDashboard)
                page = "Home";

            var response = new MaintenancesBLL().CloseTransaction(id);
            if (response == false)
                TempData["response"] = "error closing tran";
            else
                TempData["response"] = "successfully closed tran";

            return RedirectToAction("Index", page, new { area = "Admin" });
        }
    }
}
