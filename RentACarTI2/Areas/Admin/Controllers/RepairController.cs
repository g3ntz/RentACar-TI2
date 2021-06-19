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
            return View(repairs);
        }
        
        [HttpGet]
        [Route("{id}")]
        public ActionResult Create(int id)
        {
            ViewBag.VehicleID = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Repair repair)
        {
            var response = new RepairsBLL().Add(repair);
            if(response == false)
            {
                // show user smth went wrong..
            }
            return View();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Edit(int id)
        {
            var existingRepair = new RepairsBLL().Get(id);
            if (existingRepair == null)
                return NotFound();

            return View(existingRepair);
        }

        [HttpPost]
        public IActionResult Edit(Models.Repair repair)
        {
            if (repair == null)
                return NotFound();

            var response = new RepairsBLL().Modify(repair);
            if (response == true)
            {
                ViewBag.response = "edited";
            }

            return View(repair);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            var response = new RepairsBLL().Remove(id);
            if(response == false)
            {
                // return error
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult CloseTransaction(int id)
        {
            var response = new RepairsBLL().CloseTransaction(id);
            if (response == false)
            {
                // return error
            }

            return RedirectToAction("Index");
        }
    }
}
