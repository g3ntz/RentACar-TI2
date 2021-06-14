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
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            if(TempData["response"] != null)
                ViewBag.Response = TempData["response"].ToString();

            var users = new UserBLL().GetAll();
            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Roles = new RoleBLL().GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            var response = new UserBLL().Add(user);
            if (response == true)
            {
                TempData["response"] = "created";
                return RedirectToAction("Index", "User");
            }
                
            return View();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Edit(int id)
        {
            var existingUser = new UserBLL().Get(id);
            if (existingUser == null)
                return NotFound();

            ViewBag.Roles = new RoleBLL().GetAll();
            return View(existingUser);
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult Edit(Models.User user)
        {
            if (user == null)
                return NotFound();

            var response = new UserBLL().Modify(user);
            if(response == true)
            {
                ViewBag.response = "edited";
            }
                
            ViewBag.Roles = new RoleBLL().GetAll();
            return View(user);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            var response = new UserBLL().Remove(id);
            if (response == true)
            {
                TempData["response"] = "deleted";
                return RedirectToAction("Index", "User");
            }

            return RedirectToAction("Index", "User");
        }
    }
}
