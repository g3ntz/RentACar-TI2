using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACarTI2.BLL;
using Newtonsoft.Json;

namespace RentACarTI2.BLL
{
    public class StatisticsBLL
    {
        public static string GetStatistics()
        {
            return JsonConvert.SerializeObject(new
            {
                revenue = GetRevenue(),
                expenses = GetExpenses(),
                reservations = GetNrOfReservations(),
                canceledReservations = GetNrOfCanceledReservations()
            });
        }

        public static string GetRevenue()
        {
            var revenue = new ReturnBLL().GetAll().Where(x => x.IsClosed && x.LUD > DateTime.Today.AddHours(-24) &&
            x.LUD < DateTime.Today.AddHours(+24)).Select(x => x.Booking.TotalPrice).Sum();
            var feesRevenue = new FeeBLL().GetAll().Where(x => x.IsPaid && x.LUD > DateTime.Today.AddHours(-24) &&
            x.LUD < DateTime.Today.AddHours(+24)).Select(x => x.Costs).Sum();

            var finalRevenue = revenue + feesRevenue;

            return finalRevenue.ToString();
        }

        public static string GetExpenses()
        {
            var maintenanceExpenses = new MaintenancesBLL().GetAll().Where(x => x.IsReturned && x.LUD > DateTime.Today.AddHours(-24) &&
            x.LUD < DateTime.Today.AddHours(+24)).Select(x => x.Costs).Sum();

            var repairExpenses = new RepairsBLL().GetAll().Where(x => x.IsRepaired && x.LUD > DateTime.Today.AddHours(-24) &&
            x.LUD < DateTime.Today.AddHours(+24)).Select(x => x.Costs).Sum();

            var totalExpenses = maintenanceExpenses + repairExpenses;
            return totalExpenses.ToString();
        }

        public static string GetNrOfReservations()
        {
            var nrOfReservations = new BookingsBLL().GetAll().Where(x => x.BookingStatusID == 1 && x.BookingDate > DateTime.Today.AddHours(-24) &&
            x.BookingDate < DateTime.Today.AddHours(+24)).Count();

            return nrOfReservations.ToString();
        }

        public static string GetNrOfCanceledReservations()
        {
            var nrOfCanceledReservations = new BookingsBLL().GetAll().Where(x => x.BookingStatusID == 3 && x.LUD > DateTime.Today.AddHours(-24) &&
            x.LUD < DateTime.Today.AddHours(+24)).Count();

            return nrOfCanceledReservations.ToString();
        }
    }
}
