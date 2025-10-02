using Models;
using PayRoll_Admin.Control;
using PayRoll_Admin.Models;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using PayRoll_Client.View;
using PayRoll_Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Admin.ViewModel
{
    public class EmpCU : ITakeable
    {
        Employee emp = new();
        public string Title => "雇员";
        List<Action> btnClick;

        public EmpCU()
        {
            btnClick = new()
        {
             ()=>{
if (GetTextForm.TryGet("姓名", emp.Name, out string value,TextType.Name))
                emp.Name = value;
            },
                         ()=>{
if (GetEnumForm.TryGet("雇员类型", emp.Type, out int value,EnumHelper.EmpTypes))
                emp.Type = value;
            },
                         ()=>{
if (GetTextForm.TryGet("地址", emp.Address, out string value))
                emp.Address = value;
            },
                         ()=>{
if (GetTextForm.TryGet("身份证号", emp.SecurityNumber, out string value))
                emp.SecurityNumber = value;
            },

                         ()=>{
if (GetTextForm.TryGet("税率", emp.TaxDeductions, out double value,TextType.Tax))
                emp.TaxDeductions = value;
            },

                         ()=>{
if (GetTextForm.TryGet("其他扣除", emp.OtherDeductions, out double value))
                emp.OtherDeductions = value;
            },

                         ()=>{
if (GetTextForm.TryGet("电话号", emp.PhoneNumber, out string value,TextType.Digits))
                emp.PhoneNumber = value;
            },

                         ()=>{
if (GetTextForm.TryGet("时薪", emp.HourlyRate, out double value))
                emp.HourlyRate = value;
            },

                         ()=>{
if (GetTextForm.TryGet("月薪", emp.Salary, out double value))
                emp.Salary = value;
            },

                         ()=>{
if (GetTextForm.TryGet("佣金率", emp.CommisionRate, out double value,TextType.Tax))
                emp.CommisionRate = value;
            },


                         ()=>{
if (GetEnumForm.TryGet("支付方式", emp.PayMethod, out int value,EnumHelper.PayMethods))
                emp.PayMethod = value;
            },

                         ()=>{
if (GetTextForm.TryGet("每日工作小时上限", emp.HourLimit, out int value))
                emp.HourLimit = value;
            },

                         ()=>{
if (GetTextForm.TryGet("密码", emp.Password, out string value))
                emp.Password = value;
            },
                         BankClick,
                         ()=>{
if (GetEnumForm.TryGet("雇员状态", emp.Fired, out int value,EnumHelper.EmpFireds))
                emp.Fired = value;
            },
                         ()=>{}, //save
        };
        }

        void BankClick()
        {
            var banks = Sql.Query<Bank>().ToArray();
            int i = 0;
            if (banks.Any(x => x.ID == emp.BankID))
                while (banks[i].ID != emp.BankID)
                    i++;
            var itms = banks.Select(x => x.Name).ToArray();

            if (GetEnumForm.TryGet("支付银行", i, out int value, itms))
                emp.BankID = banks[value].ID;
        }

        public void Front()
        {
            emp = AdminFormCtr.EmpCRUD.emp;
        }

        public void Back()
        {
            AdminFormCtr.EmpCRUDView.BackFront();
        }


        public void Choose(int pnum, int i)
        {
            int n = pnum * 8 - 8 + i;
            btnClick[n]();
            if (n == btnClick.Count - 1)
            {
                var b1 = TypeCheck.Correct("姓名", emp.Name, TextType.Name);
                var b2 = emp.PayMethod == 1 ? TypeCheck.Correct("选择邮寄付款后的雇员地址", emp.Address, TextType.Name) : true;
                var b3 = emp.PayMethod == 2 ? TypeCheck.Correct("选择银行付款后的支付银行", emp.BankID == 0 ? "" : "1", TextType.Name) : true;
                if (b1 && b2 && b3)
                {
                    Sql.CU(emp, emp.ID);
                    AdminFormCtr.EmpCRUDView.BackFront();
                }
            }
            else
                AdminFormCtr.EmpCUView.BackFront();
        }



        public List<string> GetPageInfo(int pnum)
        {
            if (pnum == 1) return Page1();
            return Page2();
        }

        //List<string> Page1()
        //{
        //    return new List<string>()
        //    {
        //        "姓名：".Combine(emp.Name),
        //        "雇员类型：".Combine(emp.Type.EnumEmpType()),
        //        "地址：".Combine(emp.Address),
        //        "身份证号：".Combine(emp.SecurityNumber),
        //        "税率：".Combine(emp.TaxDeductions),
        //        "其他扣除：".Combine(emp.OtherDeductions),
        //        "电话号：".Combine(emp.PhoneNumber),
        //        "时薪：".Combine(emp.HourlyRate),

        //    };
        //}
        //List<string> Page2()
        //{
        //    var bank = Sql.QueryID<Bank>(emp.BankID);

        //    return new List<string>()
        //    {
        //        "月薪：".Combine(emp.Salary),
        //        "佣金率：".Combine(emp.CommisionRate),
        //        "支付方式：".Combine(emp.PayMethod.EnumEmpPayMethod()),
        //        "每天工作小时上限：".Combine(emp.HourLimit),
        //        "密码：".Combine(emp.Password),
        //        "支付银行：".Combine(bank?.Name),
        //        "雇员状态：".Combine(emp.Fired.EnumFired()),
        //        "保存",
        //    };
        //}

        List<string> Page1()
        {
            return new List<string>()
            {
                "1.姓名：" + emp.Name,
                "2.雇员类型：" + emp.Type.EnumEmpType(),
                "3.地址：" + emp.Address,
                "4.身份证号：" + emp.SecurityNumber,
                "5.税率：" + emp.TaxDeductions,
                "6.其他扣除：" + emp.OtherDeductions,
                "7.电话号：" + emp.PhoneNumber,
                "8.时薪：" + emp.HourlyRate,

            };
        }
        List<string> Page2()
        {
            var bank = Sql.QueryID<Bank>(emp.BankID);

            return new List<string>()
            {
                "9.月薪：" + emp.Salary,
                "10.佣金率：" + emp.CommisionRate,
                "11.支付方式：" + emp.PayMethod.EnumEmpPayMethod(),
                "12.每天工作小时上限：" + emp.HourLimit,
                "13.密码：" + emp.Password,
                "14.支付银行：" + bank?.Name,
                "15.雇员状态：" + emp.Fired.EnumFired(),
                "16.保存",
            };
        }


        public int GetPageLength()
        {
            return 2;
        }
    }
}
