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
            {
                ViewBag.response = "edited";
            }

            return View(client);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            var response = new ClientBLL().Remove(id);
            if(response == false)
            {
                // show error
            }

            return RedirectToAction("Index");
        }
    }
}
