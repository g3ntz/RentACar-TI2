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
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"].ToString();

            var roles = new RoleBLL().GetAll();
            return View(roles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Role role)
        {
            var response = new RoleBLL().Add(role);
            if (response == true)
            {
                TempData["response"] = "created";
                return RedirectToAction("Index", "Role");
            }

            return View();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Edit(int id)
        {
            var existingRole = new RoleBLL().Get(id);
            if (existingRole == null)
                return NotFound();

            return View(existingRole);
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult Edit(Models.Role role)
        {
            if (role == null)
                return NotFound();

            var response = new RoleBLL().Modify(role);
            if (response == true)
            {
                ViewBag.response = "edited";
            }

            return View(role);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            var response = new RoleBLL().Remove(id);
            if (response == true)
            {
                TempData["response"] = "deleted";
                return RedirectToAction("Index", "Role");
            }

            return RedirectToAction("Index", "Role");
        }
    }
}
