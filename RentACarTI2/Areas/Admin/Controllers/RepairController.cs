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
    public class RepairController : Controller
    {
        public IActionResult Index()
        {
            var repairs = new RepairsBLL().GetAll();

            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"];

            return View(repairs);
        }
        
        [HttpGet]
        [Route("{id}")]
        public ActionResult Create(int id, bool fromReturn = false, bool fromDashboard = false)
        {
            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"];

            string page = "Return";
            if (fromDashboard)
                page = "Home";

            if (fromReturn == true)
            {
                var _return = new ReturnBLL().Get(id);

                // CHECK IF THERE IS AN REPAIR THAT EXISTS FOR RETURN
                var existingRepair = new RepairsBLL().GetAll().Where(x => x.Rental_ReturnID == id).FirstOrDefault();
                if (existingRepair != null)
                {
                    TempData["response"] = "repair exists";
                    return RedirectToAction("Index", page, new { area = "Admin" });
                }

                // CHECK IF RETURN IS CLOSED
                if (_return.IsClosed)
                {
                    TempData["response"] = "return is closed";
                    return RedirectToAction("Index", page, new { area = "Admin" });
                }
                // CHECK IF RETURN DOESNT HAVE DAMAGE
                var existingDamage = new FeeBLL().GetAll().Where(x => x.returnID == id && x.IsLate == false).FirstOrDefault();
                if (existingDamage == null)
                {
                    TempData["response"] = "return doesnt have damage";
                    return RedirectToAction("Index", page, new { area = "Admin" });
                }

                ViewBag.ReturnID = id;
                ViewBag.VehicleID = _return.VehicleID;
            }
            else
            {
                // CHECK IF THERE IS AN REPAIR THAT EXISTS FOR VEHICLE
                var existingRepairVehicle = new RepairsBLL().GetAll().Where(x => x.VehicleID == id && x.IsRepaired == false).FirstOrDefault();
                if (existingRepairVehicle != null)
                {
                    TempData["response"] = "repair exists for vehicle";
                    return RedirectToAction("Index", "Vehicle");
                }
                ViewBag.VehicleID = id;
            }
                
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Repair repair)
        {
            var response = new RepairsBLL().Add(repair);
            if(response == false)
                TempData["response"] = "error creating repair";
            else
                TempData["response"] = "successfully created repair";

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Edit(int id, bool fromDashboard)
        {
            if (fromDashboard)
                ViewBag.fromDashboard = true;

            var existingRepair = new RepairsBLL().Get(id);
            if (existingRepair == null)
                return NotFound();
            if (existingRepair.IsRepaired)
            {
                TempData["response"] = "repair is closed";
                return RedirectToAction("Index");
            }

            return View(existingRepair);
        }

        [HttpPost]
        public IActionResult Edit(Models.Repair repair, bool fromDashboard)
        {
            ViewBag.fromDashboard = fromDashboard;

            if (repair == null)
                return NotFound();

            var response = new RepairsBLL().Modify(repair);
            if (response == true)
                ViewBag.response = "edited successfully";
            else
                ViewBag.Response = "error editing";

            return View(repair);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Delete(int id, bool fromDashboard = false)
        {
            string page = "Repair";
            if (fromDashboard)
                page = "Home";

            var response = new RepairsBLL().Remove(id);
            if (response == false)
                TempData["response"] = "error deleting repair";
            else
                TempData["response"] = "successfully deleted repair";

            return RedirectToAction("Index", page, new { area = "Admin" });
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult CloseTransaction(int id, bool fromDashboard)
        {
            string page = "Repair";
            if (fromDashboard)
                page = "Home";

            var response = new RepairsBLL().CloseTransaction(id);
            if (response == false)
                TempData["response"] = "error closing tran";
            else
                TempData["response"] = "successfully closed tran";

            return RedirectToAction("Index", page, new { area = "Admin" });
        }
    }
}
