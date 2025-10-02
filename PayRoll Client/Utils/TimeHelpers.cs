using Models;
using PayRoll_Client.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.Utils
{
    public static class TimeHelpers
    {
        public static int Int(this DateTime time)
        {
            return time.Year * 10000 + time.Month * 100 + time.Day;
        }

        public static VirtualClock VClock(this DateTime time)
        {
            VirtualClock clock = new();
            clock.NowDate = time.Int();
            clock.NowTime = time.Hour;
            return clock;
        }

        public static string Str(this DateTime time)
        {
            return time.ToShortDateString().Split()[0];
        }

        public static DateTime VacationDate(this int date)
        {
            int year = VClockService.Vclock.NowDate / 10000;
            int month = date / 100 % 100;
            int day = date % 100;
            return new DateTime(year, month, day);
        }
        public static DateTime Date(this int date)
        {
            int year = date / 10000;
            int month = date / 100 % 100;
            int day = date % 100;
            return new DateTime(year, month, day);
        }



        public static DateTime Date(this VirtualClock c1)
        {
            return c1.NowDate.Date();
        }

        public static int DurationTo(this VirtualClock c1, VirtualClock c2)
        {
            if (c1 == null) return 0;
            return c2.NowTime + 24 * (c2.NowDate - c1.NowDate) - c1.NowTime;
        }

        public static string VDateString(this VirtualClock c1)
        {
            var x = c1.Date();
            return $"{x.Month} / {x.Day} / {x.Year}";
        }
        public static string VTimeString(this VirtualClock c1)
        {
            return $"{c1.NowTime} : 00 : 00";
        }

    }
}
