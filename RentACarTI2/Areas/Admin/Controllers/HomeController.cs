using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACarTI2.BLL;
using Newtonsoft.Json;

namespace RentACarTI2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // DASHBOARD CHARTS
            var vehicleSalesMonthly = new VehicleBLL().GetVehicleSalesMonthly();
            var vehicleSalesDaily = new VehicleBLL().GetVehicleSalesDaily();
            var maintenanceCostsDaily = new MaintenancesBLL().GetMaintenanceCostsDaily();
            var maintenanceCostsMonthly = new MaintenancesBLL().GetMaintenanceCostsMonthly();
            var repairCostsDaily = new RepairsBLL().GetRepairCostsDaily();
            var repairCostsMonthly = new RepairsBLL().GetRepairCostsMonthly();

            var dashboardCharts = new
            {
                vehicleSales = new { daily = vehicleSalesDaily, monthly = vehicleSalesMonthly },
                maintenanceCosts = new { daily = maintenanceCostsDaily, monthly = maintenanceCostsMonthly },
                repairCosts = new { daily = repairCostsDaily, monthly = repairCostsMonthly }
            };
            ViewBag.ChartsData = Json(new { dashboardCharts });

            // DASHBOARD STATISTICS ( THE DATE IS HARDCODED INSIDE METHOD, DONT FORGET TO CHANGE IT )
            ViewBag.Statistics = StatisticsBLL.GetStatistics();

            // DASHBOARD TODAY RESERVATIONS ( add x.BookingStatus and date parameters for filtering )
            ViewBag.Bookings = new BookingsBLL().GetAll().Take(4).ToList();

            // DASHBOARD TASKS
            ViewBag.Returns = new ReturnBLL().GetAll().Where(x => x.IsClosed == false).Take(4).ToList();
            ViewBag.Repairs = new RepairsBLL().GetAll().Where(x => x.IsRepaired == false).Take(4).ToList();
            ViewBag.Maintenances = new MaintenancesBLL().GetAll().Where(x => x.IsReturned == false).Take(4).ToList();

            return View();
        }
    }
}
