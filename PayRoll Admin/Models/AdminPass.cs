using PayRoll_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Admin.Models
{
    public partial class AdminPass 
    {
        public AdminPass()
        {


        }
        //[SqlSugar.SugarColumn(IsIdentity = true, IsPrimaryKey = true)]

        public string Password { get; set; }

    }
}
