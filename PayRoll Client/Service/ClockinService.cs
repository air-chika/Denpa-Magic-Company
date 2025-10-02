using Microsoft.VisualBasic.Devices;
using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Utils;
using PayRoll_Client.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.Service
{
    public class ClockinService
    {

        //service中只保存id，每次访问实体时，都会在数据库中找对应数据，没有说明被（管理员）删除。
        static int curEmpID;
        static int curProjectID;

        public static Employee? CurEmployee
        {
            get
            {
                var x = Sql.QueryID<Employee>(curEmpID);
                if (x == null && !FormCtr.LoginView.IsLogining)
                {
                    ErrorBox.Error("wasted（作为一条数据，您被删除了）");
                    FormCtr.LoginView.Front();
                    return null;
                }
                return x;
            }
            set => curEmpID = value?.ID ?? 0;
        }
        public static Project? CurProject
        {
            get
            {
                var x = Sql.QueryID<Project>(curProjectID);
                if (x == null && clockinTime != null)
                {
                    ErrorBox.Error("您的项目似乎被老板砍掉了。");
                    FormCtr.ClientMain.InitFront();
                    return null;
                }
                return x;
            }
            set => curProjectID = value?.ID ?? 0;
        }


        public static VirtualClock? clockinTime;
        public static void ClockIn()
        {
            clockinTime = VClockService.Vclock;
        }

        public static (VirtualClock c2, int dura) Refresh()
        {
            var cur = VClockService.Vclock;
            return (cur, clockinTime?.DurationTo(cur) ?? 0);
        }

        public static void ClockOut()
        {
            if (clockinTime == null) return;
            var cur = VClockService.Vclock;

            if (clockinTime.DurationTo(cur) == 0) 
                goto dipose;

            if (CurEmployee == null || CurProject == null)
                goto dipose;

            TimeCard timeCard = new TimeCard();
            timeCard.Set(CurEmployee, CurProject, clockinTime, cur);
            Sql.Insert(timeCard);

        dipose: CurProject = null;
            clockinTime = null;
        }

    }
}
