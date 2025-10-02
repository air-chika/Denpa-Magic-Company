using Models;
using PayRoll_Client.Utils;
using PayRoll_Client.View;

namespace PayRoll_Client.Service
{
    public class VClockService
    {
        public static VirtualClock Vclock
        {
            get
            {
                var v = Sql.Query<VirtualClock>().First();
                if (v == null)
                {
                    ErrorBox.Error("时钟获取失败");
                    throw new Exception();
                }
                return v;
            }
        }

        public static VirtualClock NextHour()
        {
            var nex = Vclock;
            var d1 = nex.Date();
            var d2 = new TimeSpan(nex.NowTime + 1, 0, 0);

            if (d2.Hours >= 24)
            {
                d1 = d1.AddDays(1);
                d2 = new(0, 0, 0);
                PayRollService.NewDay(d1);
            }

            d1 = d1.Add(d2);

            var vc = d1.VClock();
            vc.ID = nex.ID;

            Sql.Update(vc);
            return vc;
        }

        public static VirtualClock NextDate()
        {
            var nex = Vclock;
            var d1 = nex.Date();
            var d2 = new TimeSpan(8, 0, 0);

            d1 = d1.AddDays(1);
            PayRollService.NewDay(d1);

            d1 = d1.Add(d2);

            var vc = d1.VClock();
            vc.ID = nex.ID;

            Sql.Update(vc);
            return vc;
        }

    }
}
