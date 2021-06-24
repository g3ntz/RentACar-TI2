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
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            var clients = new ClientBLL().GetAll();

            if (TempData["response"] != null)
                ViewBag.Response = TempData["response"];

            return View(clients);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult Edit(int id)
        {
            var existingClient = new ClientBLL().Get(id);
            if (existingClient == null)
                return NotFound();

            return View(existingClient);
        }

        [HttpPost]
        public ActionResult Edit(Models.Client client)
        {
            if (client == null)
                return NotFound();

            var response = new ClientBLL().Modify(client);
            if (response == true)
                ViewBag.Response = "successfully edited client";
            else
                ViewBag.Response = "error editing client";

            return View(client);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            var response = new ClientBLL().Remove(id);
            if (response == true)
                TempData["response"] = "successfully deleted client";
            else
                TempData["response"] = "error deleting client";

            return RedirectToAction("Index");
        }
    }
}
