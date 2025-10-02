using PayRoll_Admin.View;
using PayRoll_Admin.ViewModel;
using PayRoll_Client.Utils;
using PayRoll_Client.View;

namespace PayRoll_Admin.Control
{
    internal static class AdminFormCtr
    {
        public static AdminMain AdminMain { get; } = new();
        public static ProjCU ProjCU { get; } = new();
        public static EmpCRUD EmpCRUD { get; } = new();
        public static EmpCU EmpCU { get; } = new();
        public static AdminReportTakes ReportTakes { get; } = new();


        //public static ProjInfo ProjInfo { get; } = new(projManage);
        public static ProjCRUD ProjCURD { get; } = new();
        public static CRUDview ProjCRUDView { get; } = new(ProjCURD);
        public static CRUDview EmpCRUDView { get; } = new(EmpCRUD);
        public static TakeView ProjCUView { get; } = new(ProjCU);
        public static TakeView EmpCUView { get; } = new(EmpCU);
        public static MultiTakeView ReportTakesView { get; } = new(ReportTakes);

        public static AdminReport ReportView { get; } = new();
        public static PayRoll_Admin.View.LoginView LoginView { get; } = new();

        //public static EmpManage empManage = new();
        //public static CRUDview EmpView { get; } = new(empManage);
        //public static EmpInfo EmpInfo { get; } = new(empManage);

        public static Form1 form;
        public static void Init(Form1 form)
        {
            AdminFormCtr.form = form;
            GetTextForm.fatherForm = form;
            ErrorBox.fatherForm = form;
            ConfirmBox.fatherForm = form;
            GetEnumForm.fatherForm = form;

            form.Controls.Add(LoginView);
            form.Controls.Add(AdminMain);
            form.Controls.Add(ProjCRUDView);
            form.Controls.Add(EmpCRUDView);
            form.Controls.Add(ProjCUView);
            form.Controls.Add(EmpCUView);
            form.Controls.Add(ReportTakesView);
            form.Controls.Add(ReportView);
            //form.Controls.Add(ProjInfo);
            //form.Controls.Add(EmpView);
            //form.Controls.Add(EmpInfo);


            //var pb = form.pb;
            //await Task.Delay(500);
            //int fp = (int)1000.0 / 60;
            //for (int i = 0; i < 60; i++)
            //{
            //    int bl = (int)(128.0 - 38) / 60 * (60 - i) + 38;
            //    pb.BackColor = Color.FromArgb(bl, bl, bl);
            //    Task.Delay(fp).Wait();
            //    pb.BringToFront();
            //    form.Refresh();
            //}
            LoginView.Front();
        }

        public static void Close()
        {
            form.Close();
        }
    }
}
