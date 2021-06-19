using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using RentACarTI2.DAL;
using System.Linq;

namespace RentACarTI2.BLL
{
    public class MaintenancesBLL : IBaseCrud<Maintenance>
    {
        public static MaintenancesDAL dal = new MaintenancesDAL();

        public bool Add(Maintenance maintenance)
        {
            return dal.Add(maintenance);
        }

        public Maintenance Get(int id)
        {
            return dal.Get(id);
        }

        public Maintenance Get(Maintenance maintenance)
        {
            return dal.Get(maintenance);
        }

        public List<Maintenance> GetAll()
        {
            return dal.GetAll();
        }

        public bool Modify(Maintenance maintenance)
        {
            return dal.Modify(maintenance);
        }

        public bool Remove(int id)
        {
            return dal.Remove(id);
        }

        public bool Remove(Maintenance maintenance)
        {
            return dal.Remove(maintenance);
        }

        public bool CloseTransaction(int id)
        {
            return dal.CloseTransaction(id);
        }

        public List<int> GetMaintenanceCostsDaily()
        {
            var maintenanceCosts = new List<int>();

            DateTime currentDate;
            int dayOfWeek = (int)DateTime.Today.DayOfWeek;
            int dayOfWeekFinal = dayOfWeek == 0 ? 7 : dayOfWeek;

            for (int startDate = 1; startDate <= dayOfWeekFinal; startDate++)
            {
                //currentDate = DateTime.Today.Date.AddDays(-dayOfWeekFinal + startDate);
                currentDate = new DateTime(2020, 2, 5);
                int costsThisDay = (int)new MaintenancesBLL().GetAll().Where(x => x.LUD.Date == currentDate.Date && x.IsReturned).Select(x => x.Costs).Sum();
                maintenanceCosts.Add(costsThisDay);
            }
            return maintenanceCosts;
        }

        public List<int> GetMaintenanceCostsMonthly()
        {
            var maintenanceCosts = new List<int>();

            DateTime currentDate;
            int currentMonth = DateTime.Today.Month;

            var rentals = new RentalBLL().GetAll();
            for (int firstMonth = 1; firstMonth <= currentMonth; firstMonth++)
            {
                currentDate = DateTime.Today.Date.AddMonths(-currentMonth + firstMonth);
                //currentDate = new DateTime(2020, 9, 20);
                int costsThisMonth = (int)new MaintenancesBLL().GetAll().Where(x => x.LUD.Month == currentDate.Month && x.IsReturned).Select(x => x.Costs).Sum();
                maintenanceCosts.Add(costsThisMonth);
            }
            if (maintenanceCosts.Count < 12)
            {
                for (int i = maintenanceCosts.Count; i < 12; i++)
                {
                    maintenanceCosts.Add(0);
                }
            }
            return maintenanceCosts;
        }
    }
}
