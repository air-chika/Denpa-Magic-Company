using PayRoll_Client.Utils;
using PayRoll_Client.View;
using PayRoll_Client.ViewObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.Controller
{
    internal static class FormCtr
    {
        public static LoginView LoginView { get; } = new();
        public static ReportProjectTakes RProTakes { get; } = new();
        public static EmployReport ReportView { get; } = new();
        public static ClientMain ClientMain { get; } = new();
        public static JoinProjectTake JoinProjectTake { get; } = new();
        public static InfoU Info { get; } = new();

        public static NoteCU NoteCU { get; } = new();

        public static NoteCRUD NoteCRUD = new();
        public static CRUDview NoteCRUDView { get; } = new(NoteCRUD);
        public static MultiTakeView RProtakesView { get; } = new(RProTakes);

        public static Form1 form;
        public static void Init(Form1 form)
        {
            FormCtr.form = form;
            form.Controls.Add(LoginView);
            form.Controls.Add(ClientMain);
            form.Controls.Add(JoinProjectTake);
            form.Controls.Add(Info);
            form.Controls.Add(NoteCU);
            form.Controls.Add(NoteCRUDView);
            form.Controls.Add(ReportView);
            form.Controls.Add(RProtakesView);
            LoginView.Front();
        }


        public static void Close()
        {
            form.Close();
        }
    }
}
