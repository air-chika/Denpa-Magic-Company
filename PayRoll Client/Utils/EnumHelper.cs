using System.Windows.Forms.VisualStyles;

namespace PayRoll_Client.Utils
{
    static public class EnumHelper
    {
        static Dictionary<int, string> empType = new()
        {
            {0,"小时工" },
            {1,"月薪党" },
            {2,"月薪党Pro" }
        };
        static Dictionary<int, string> empPayMethod = new()
        {
            {0,"领取" },
            {1,"邮寄" },
            {2,"存款" }
        };
        static Dictionary<int, string> empFired = new()
        {
            {0,"在职" },
            {1,"解雇" },
        };

        static Dictionary<string, int> empType2 = new();
        static Dictionary<string, int> empPayMethod2 = new();

        static EnumHelper()
        {
            foreach (var pair in empType)
                empType2[pair.Value] = pair.Key;
            foreach (var pair in empPayMethod)
                empPayMethod2[pair.Value] = pair.Key;
        }

        public static string EnumEmpType(this int i) => empType[i];
        public static int EnumEmpType(this string i) => empType2[i];
        public static string EnumEmpPayMethod(this int i) => empPayMethod[i];
        public static int EnumEmpPayMethod(this string i) => empPayMethod2[i];
        public static string EnumFired(this int i) => empFired[i];

        public static string[] EmpTypes { get; } = { "小时工", "月薪党", "月薪党Pro" };
        public static string[] PayMethods { get; } = { "领取", "邮寄", "存款" };
        public static string[] EmpFireds { get; } = { "在职","解雇" };


        public static int IndexOf<T>(this List<T> list, T t) where T : class
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i] == t)
                    return i;
            return -1;
        }

        public static int IndexOf<T, R>(this List<T> list, R r, Func<T, R> func) where T : class where R : IEquatable<R>
        {
            for (int i = 0; i < list.Count; i++)
                if (func(list[i]).Equals(r))
                    return i;
            return -1;
        }

    }
}
