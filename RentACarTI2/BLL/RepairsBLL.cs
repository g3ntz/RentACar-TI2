using System;
using System.Collections.Generic;
using System.Text;
using RentACarTI2.Interfaces;
using RentACarTI2.Models;
using RentACarTI2.DAL;
using System.Linq;

namespace RentACarTI2.BLL
{
    public class RepairsBLL : IBaseCrud<Repair>
    {
        public static RepairsDAL dal = new RepairsDAL();

        public bool Add(Repair model)
        {
            return dal.Add(model);
        }

        public Repair Get(int id)
        {
            return dal.Get(id);
        }

        public Repair Get(Repair model)
        {
            return dal.Get(model);
        }

        public List<Repair> GetAll()
        {
            return dal.GetAll();
        }

        public bool Modify(Repair model)
        {
            return dal.Modify(model);
        }

        public bool Remove(int id)
        {
            return dal.Remove(id);
        }

        public bool Remove(Repair model)
        {
            return dal.Remove(model);
        }

        public bool CloseTransaction(int id)
        {
            return dal.CloseTransaction(id);
        }

        public List<int> GetRepairCostsDaily()
        {
            var repairCosts = new List<int>();

            DateTime currentDate;
            int dayOfWeek = (int)DateTime.Today.DayOfWeek;
            int dayOfWeekFinal = dayOfWeek == 0 ? 7 : dayOfWeek;

            for (int startDate = 1; startDate <= dayOfWeekFinal; startDate++)
            {
                currentDate = DateTime.Today.Date.AddDays(-dayOfWeekFinal + startDate);

                int costsThisDay = (int)new RepairsBLL().GetAll().Where(x => x.LUD.Date == currentDate.Date && x.IsRepaired).Select(x => x.Costs).Sum();
                repairCosts.Add(costsThisDay);
            }
            return repairCosts;
        }

        public List<int> GetRepairCostsMonthly()
        {
            var repairCosts = new List<int>();

            DateTime currentDate;
            int currentMonth = DateTime.Today.Month;

            var rentals = new RentalBLL().GetAll();
            for (int firstMonth = 1; firstMonth <= currentMonth; firstMonth++)
            {
                currentDate = DateTime.Today.Date.AddMonths(-currentMonth + firstMonth);

                int costsThisMonth = (int)new RepairsBLL().GetAll().Where(x => x.LUD.Month == currentDate.Month && x.IsRepaired).Select(x => x.Costs).Sum();
                repairCosts.Add(costsThisMonth);
            }
            if (repairCosts.Count < 12)
            {
                for (int i = repairCosts.Count; i < 12; i++)
                {
                    repairCosts.Add(0);
                }
            }
            return repairCosts;
        }
    }
}
