using Models;
using PayRoll_Client.Controller;
using PayRoll_Client.Service;
using PayRoll_Client.Utils;
using System.Drawing.Design;

namespace PayRoll_Client.View
{
    public partial class InfoU : UserControl
    {
        Button[] nameBtns;
        Button[] infoBtns;
        int fsize = 20;
        const int tableLength = 16;
        Employee emp = new();
        bool[] canUpdate;

        public InfoU()
        {
            InitializeComponent();
            title.BasedTitle(fsize);
            SaveBtn.Text = "保存";
            CancelBtn.Text = "返回";
            SaveBtn.Based();
            CancelBtn.Based();

            nameBtns = new Button[tableLength];
            infoBtns = new Button[tableLength];
            canUpdate = new bool[tableLength];

            for (int i = 0; i < tableLength; i++)
            {
                nameBtns[i] = new();
                infoBtns[i] = new();
                nameBtns[i].BasedLab(fsize);
                infoBtns[i].BasedAmberBtn(fsize);
                table.Controls.Add(nameBtns[i]);
                table.Controls.Add(infoBtns[i]);
            }
            int top = 0;
            infoBtns[top].BasedLab(fsize);
            nameBtns[top++].Text = "ID"; //0

            canUpdate[top] = true;
            infoBtns[top].Click += (a, b) =>
            {
                if(!Updating) return;
                ((Button)a).Text = emp.Name = GetTextForm.TryGet("姓名", emp.Name, out string val, TextType.Name) ? val : emp.Name;
            };
            nameBtns[top++].Text = "姓名"; //1

            canUpdate[top] = true;
            infoBtns[top].Click += (a, b) =>
            {
                if(!Updating) return;
                ((Button)a).Text = emp.SecurityNumber = GetTextForm.TryGet("身份证号", emp.SecurityNumber, out string val, TextType.Digits) ? val : emp.SecurityNumber;
            };
            nameBtns[top++].Text = "身份证号";//2

            canUpdate[top] = true;
            infoBtns[top].Click += (a, b) =>
            {
                if(!Updating) return;
                ((Button)a).Text = emp.PhoneNumber = GetTextForm.TryGet("电话号", emp.PhoneNumber, out string val, TextType.Digits) ? val : emp.PhoneNumber;
            };
            nameBtns[top++].Text = "电话号";//3

            infoBtns[top].BasedLab(fsize);
            nameBtns[top++].Text = "雇员类型";//4
            infoBtns[top].BasedLab(fsize);
            nameBtns[top++].Text = "时薪";//5
            infoBtns[top].BasedLab(fsize);
            nameBtns[top++].Text = "月薪";//6
            infoBtns[top].BasedLab(fsize);
            nameBtns[top++].Text = "佣金率";//7
            infoBtns[top].BasedLab(fsize);
            nameBtns[top++].Text = "税率";//8
            infoBtns[top].BasedLab(fsize);
            nameBtns[top++].Text = "额外扣除";//9

            canUpdate[top] = true;
            infoBtns[top].Click += (a, b) =>
            {
                if(!Updating) return;
                emp.HourLimit = GetTextForm.TryGet("每日结薪小时上限", emp.HourLimit, out int val, TextType.Hours) ? val : emp.HourLimit;
                ((Button)a).Text = emp.HourLimit.ToString();
            };
            nameBtns[top++].Text = "每日结薪小时上限";//10

            canUpdate[top] = true;
            infoBtns[top].Click += (a, b) =>
            {
                if(!Updating) return;
                emp.PayMethod = GetEnumForm.TryGet("收款方式", emp.PayMethod, out int idx, EnumHelper.PayMethods) ? idx : emp.PayMethod;
                ((Button)a).Text = emp.PayMethod.EnumEmpPayMethod();
            };
            nameBtns[top++].Text = "收款方式";//11

            canUpdate[top] = true;
            infoBtns[top].Click += (a, b) =>
            {
                if(!Updating) return;
                ((Button)a).Text = emp.Address = GetTextForm.TryGet("邮寄地址", emp.Address, out string val, TextType.Text) ? val : emp.Address;
            };
            nameBtns[top++].Text = "邮寄地址";//12

            canUpdate[top] = true;
            infoBtns[top].Click += (a, b) =>
            {
                if(!Updating) return;
                var banks = Sql.Query<Bank>().ToList();
                emp.BankID = GetEnumForm.TryGet("存款银行", banks, x => x.Name, emp.BankID, x => x.ID, out int idx) ? banks[idx].ID : emp.BankID;
                ((Button)a).Text = banks[idx].Name;
            };
            nameBtns[top++].Text = "存款银行";//13


            canUpdate[top] = true;
            infoBtns[top].Click += (a, b) =>
            {
                if(!Updating) return;
                ((Button)a).Text = emp.Password = GetTextForm.TryGet("密码", emp.Password, out string val, TextType.Text) ? val : emp.Password;
            };
            nameBtns[top++].Text = "密码";//14

            canUpdate[top] = true;
            infoBtns[top].Click += (a, b) =>
            {
                if(!Updating) return;
                emp.Fired = GetEnumForm.TryGet("雇员状态", emp.Fired, out int idx, EnumHelper.EmpFireds) ? idx : emp.Fired;

                ((Button)a).Text = emp.Fired.EnumFired();
            };
            nameBtns[top++].Text = "雇员状态";//15

            Polling();
        }

        public void InitFront()
        {
            Updating = false;
            BringToFront();
        }


        bool _updating = false;
        bool Updating
        {
            get => _updating;
            set
            {
                _updating = value;
                if (value)
                {
                    //更新ing
                    SaveBtn.Text = "保存";
                    for (int i = 0; i < tableLength; i++)
                        if (canUpdate[i])
                            infoBtns[i].BasedAmberBtn();
                }
                else
                {
                    //看ing
                    SaveBtn.Text = "更新";
                    for (int i = 0; i < tableLength; i++)
                        if (canUpdate[i])
                            infoBtns[i].BasedLab();
                }
            }
        }

        void Refresh()
        {
            var newEmp = ClockinService.CurEmployee;
            if (newEmp == null) return;

            string? bank = Sql.QueryID<Bank>(newEmp.BankID)?.Name;
            int top = -1;

            if (!(canUpdate[++top] && Updating))
            {
                infoBtns[top].Text = newEmp.ID.ToString();
                emp.ID = newEmp.ID;
            }

            if (!(canUpdate[++top] && Updating))
                emp.Name = infoBtns[top].Text = newEmp.Name;

            if (!(canUpdate[++top] && Updating))
                emp.SecurityNumber = infoBtns[top].Text = newEmp.SecurityNumber;

            if (!(canUpdate[++top] && Updating))
                emp.PhoneNumber = infoBtns[top].Text = newEmp.PhoneNumber;

            if (!(canUpdate[++top] && Updating))
            {
                infoBtns[top].Text = newEmp.Type.EnumEmpType();
                emp.Type = newEmp.Type;
            }

            if (!(canUpdate[++top] && Updating))
            {
                infoBtns[top].Text = newEmp.HourlyRate.ToString();
                emp.HourlyRate = newEmp.HourlyRate;
            }

            if (!(canUpdate[++top] && Updating))
            {
                infoBtns[top].Text = newEmp.Salary.ToString();
                emp.Salary = newEmp.Salary;
            }

            if (!(canUpdate[++top] && Updating))
            {
                infoBtns[top].Text = newEmp.CommisionRate.ToString();
                emp.CommisionRate = newEmp.CommisionRate;
            }

            if (!(canUpdate[++top] && Updating))
            {

                infoBtns[top].Text = newEmp.TaxDeductions.ToString();
                emp.TaxDeductions = newEmp.TaxDeductions;
            }

            if (!(canUpdate[++top] && Updating))
            {
                emp.OtherDeductions = newEmp.OtherDeductions;
                infoBtns[top].Text = newEmp.OtherDeductions.ToString();
            }

            if (!(canUpdate[++top] && Updating))
            {

                emp.HourLimit = newEmp.HourLimit;
                infoBtns[top].Text = newEmp.HourLimit.ToString();
            }

            if (!(canUpdate[++top] && Updating))
            {
                emp.PayMethod = newEmp.PayMethod;
                infoBtns[top].Text = newEmp.PayMethod.EnumEmpPayMethod();
            }

            if (!(canUpdate[++top] && Updating))
                emp.Address = infoBtns[top].Text = newEmp.Address;

            if (!(canUpdate[++top] && Updating))
                infoBtns[top].Text = bank;

            if (!(canUpdate[++top] && Updating))
                emp.Password = infoBtns[top].Text = newEmp.Password;

            if (!(canUpdate[++top] && Updating))
            {
                emp.Fired = newEmp.Fired;
                infoBtns[top].Text = newEmp.Fired.EnumFired();
            }
        }

        async void Polling()
        {
            while (true)
            {
                Refresh();
                await Task.Delay(1000);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!Updating)
            {
                Updating = true;
                return;
            }
            if (emp.PayMethod == 1)
                if (!TypeCheck.Correct("选择邮寄收款后的地址", emp.Address, TextType.Name))
                    return;
            if (emp.PayMethod == 2)
                if (!TypeCheck.Correct("选择银行收款后的银行", Sql.QueryID<Bank>(emp.BankID)?.Name, TextType.Name))
                    return;
            Updating = false;
            Sql.Update(emp);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            FormCtr.ClientMain.BackFront();
        }

    }
}
