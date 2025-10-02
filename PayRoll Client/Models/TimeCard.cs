using PayRoll_Client.Models;
using PayRoll_Client.Utils;
using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class TimeCard : IDable
    {
        public TimeCard()
        {
            ID = 0;
        }
        public void Set(Employee emp, Project prj, VirtualClock c1, VirtualClock c2)
        {
            EmployeeID = emp.ID;
            ProjectID = prj.ID;
            Date = c2.NowDate;
            EndTime = c2.NowTime;
            DurationHours = c1.DurationTo(c2);
        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>      
        [SqlSugar.SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int ID { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public int EmployeeID { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public int ProjectID { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public int Date { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int EndTime { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int DurationHours { get; set; }

    }
}
