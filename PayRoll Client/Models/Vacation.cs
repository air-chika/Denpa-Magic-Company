using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.Models
{
    public partial class Vacation : IDable
    {
        public Vacation()
        {


        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SqlSugar.SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int ID { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public string Name { get; set; }


    }
}
