using Models;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PayRoll_Client.Service
{
    class EmpInfo
    {
        public EmpInfo(Employee employ)
        {
            emp = employ;
            Other = emp.OtherDeductions;
        }
        public Employee emp;
        public double RawWages = 0;
        public double Tax = 0;
        public double Other = 0;
        public double RealWages = 0;
        public double Commision = 0;
    }

    public class PayRollService
    {

        static void FullFillBpc(EmpInfo emp)
        {
            if (!((Math.Abs(emp.RawWages) < 1e-5 && Math.Abs(emp.RealWages) < 1e-5)))
            {
                BankPayCheck res = new();
                res.BankID = emp.emp.BankID;
                res.Date = dateInt;
                res.EmployeeID = emp.emp.ID;
                res.OtherDeductions = emp.emp.OtherDeductions;
                res.RawWages = emp.RawWages;
                res.RealWages = emp.RealWages;
                res.Tax = emp.RawWages * emp.emp.TaxDeductions;
                res.Commision = emp.Commision;
                Sql.Insert(res);
            }
            TryDelete(emp.emp);
        }
        static void FullFillPc(EmpInfo emp)
        {
            if (!((Math.Abs(emp.RawWages) < 1e-5 && Math.Abs(emp.RealWages) < 1e-5)))
            {
                PayCheck res = new();
                res.Date = dateInt;
                res.EmployeeID = emp.emp.ID;
                res.OtherDeductions = emp.emp.OtherDeductions;
                res.RawWages = emp.RawWages;
                res.RealWages = emp.RealWages;
                res.Tax = emp.RawWages * emp.emp.TaxDeductions;
                res.Commision = emp.Commision;
                Sql.Insert(res);
            }
            TryDelete(emp.emp);
        }

        static void TryDelete(Employee c)
        {
            if (c.Fired == 1)
            {
                Sql.Delete(c);
                Sql.DB.Deleteable<TimeCard>().Where(x => x.EmployeeID == c.ID).ExecuteCommand();

                Sql.DB.Deleteable<ResearchNote>().Where(x => x.EmployeeID == c.ID).ExecuteCommand();

                //不删除支票
                //Sql.DB.Deleteable<PayCheck>().Where(x => x.EmployeeID == c.ID).ExecuteCommand();
                //Sql.DB.Deleteable<BankPayCheck>().Where(x => x.EmployeeID == c.ID).ExecuteCommand();
            }

        }

        static void PayHourlyGuy()
        {
            var emps = Sql.Query<Employee>().Where(x => x.Type == 0).ToList();
            var ids = emps.Select(x => x.ID).ToHashSet();

            var cards = Sql.Query<TimeCard>().Where(x => ids.Contains(x.EmployeeID)).ToList();

            //id,date,dura
            var sumcards = cards.GroupBy(x => x.EmployeeID).ToDictionary(x => x.Key, x =>
            {
                var m = x.ToList();
                var r = m.GroupBy(z => z.Date).ToDictionary(z => z.Key, z => z.Sum(c => c.DurationHours));
                return r;
            }
            );


            foreach (var emp in emps)
            {
                EmpInfo empi = new(emp);
                double rate = emp.HourlyRate;
                if (sumcards.ContainsKey(emp.ID))
                {
                    var dates = sumcards[emp.ID];

                    foreach (var hr in dates.Values)
                    {
                        int h = Math.Min(hr, emp.HourLimit);
                        empi.RawWages += h * rate;
                        if (h > 8)
                            empi.RawWages += (h - 8) * 0.5 * rate;
                    }
                }

                empi.Tax = empi.RawWages * emp.TaxDeductions;
                empi.RealWages = empi.RawWages - empi.Tax - empi.Other;


                if (emp.PayMethod != 2)
                    FullFillPc(empi);
                else
                    FullFillBpc(empi);
            }
        }
        static void PaySalaryGuy()
        {
            var emps = Sql.Query<Employee>().Where(x => x.Type == 1).ToList();

            foreach (var emp in emps)
            {
                EmpInfo empi = new(emp);

                empi.RawWages = emp.Salary;

                empi.Tax = empi.RawWages * emp.TaxDeductions;
                empi.RealWages = empi.RawWages - empi.Tax - empi.Other;

                if (emp.PayMethod != 2)
                    FullFillPc(empi);
                else
                    FullFillBpc(empi);
            }
        }

        static void PayCommisionGuy()
        {
            var emps = Sql.Query<Employee>().Where(x => x.Type == 2).ToList();
            var ids = emps.Select(x => x.ID).ToHashSet();

            var notes = Sql.Query<ResearchNote>().Where(x => ids.Contains(x.EmployeeID)).ToList();

            //id,date,dura
            var sumnotes = notes.GroupBy(x => x.EmployeeID).ToDictionary(x => x.Key, x =>
                x.Sum(z => z.Contribute));


            foreach (var emp in emps)
            {
                EmpInfo empi = new(emp);
                double rate = emp.CommisionRate;
                empi.RawWages += emp.Salary;

                if (sumnotes.ContainsKey(emp.ID))
                    empi.Commision = sumnotes[emp.ID] * rate;
                double sum = empi.RawWages + empi.Commision;

                empi.Tax = sum * emp.TaxDeductions;
                empi.RealWages = sum - empi.Tax - empi.Other;


                if (emp.PayMethod != 2)
                    FullFillPc(empi);
                else
                    FullFillBpc(empi);
            }
        }

        static DateTime date;
        static int dateInt;
        public static void NewDay(in DateTime da)
        {
            date = da;
            dateInt = da.Int();
            if (date.DayOfWeek == DayOfWeek.Friday)
                PayHourlyGuy();
            if (DateTime.DaysInMonth(date.Year, date.Month) == date.Day)
            {
                PaySalaryGuy();
                PayCommisionGuy();
            }
        }



    }
}
