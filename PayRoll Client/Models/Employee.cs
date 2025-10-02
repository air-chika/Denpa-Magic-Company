using PayRoll_Client.Models;
using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class Employee : IDable
    {
        public Employee()
        {
            Name = string.Empty;
        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SqlSugar.SugarColumn(IsIdentity = true,IsPrimaryKey = true)]
        public int ID { get; set; }

        /// <summary>
        /// Desc:
        /// Default:Alice
        /// Nullable:False
        /// </summary>           
        public string Name { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:False
        /// </summary>           
        public int Type { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Address { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SecurityNumber { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public double TaxDeductions { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public double OtherDeductions { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public double HourlyRate { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public double Salary { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public double CommisionRate { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:False
        /// </summary>           
        public int PayMethod { get; set; }

        /// <summary>
        /// Desc:
        /// Default:24
        /// Nullable:False
        /// </summary>           
        public int HourLimit { get; set; }

        /// <summary>
        /// Desc:
        /// Default:214
        /// Nullable:False
        /// </summary>           
        public string Password { get; set; }
        public int BankID { get; set; }
        public int Fired { get; set; }
        //在职/解雇

        

    }
}
