using PayRoll_Client.Models;
using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class VirtualClock : IDable
    {

        public VirtualClock()
        {


        }
        [SqlSugar.SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int ID { get; set; }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int NowDate { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int NowTime { get; set; }

    }
}
