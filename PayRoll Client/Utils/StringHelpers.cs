using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.Utils
{
    public static class StringHelpers
    {
        public static string Pad(this string str, int total, bool isLeft)
        {
            int doubleNum = 0;
            foreach (char c in str)
                if (c < 0 || c > 0x007f) doubleNum++;
            total -= doubleNum;
            total = Math.Max(0, total);
            return isLeft ? str.PadRight(total) : str.PadLeft(total);
        }
        public static string PadMid(this string str, int total)
        {
            int doubleNum = 0;
            foreach (char c in str)
                if (c < 0 || c > 0x007f) doubleNum++;
            return str.PadLeft((total + str.Length - doubleNum) / 2).PadRight(total - doubleNum);
        }

        public static int RealLen(this string? str)
        {
            if(str== null) return 0;
            int doubleNum = 0;
            foreach (char c in str)
                if (c < 0 || c > 0x007f) doubleNum++;
            return str.Length + doubleNum;
        }

        public static string Combine(this string str1, string? str2, int total = 50)
        {
            return str1.Pad(total - str2.RealLen(),true) + str2;
        }
        public static string Combine<T>(this string str1, T? str2, int total = 50)
        {
            return str1.Pad(total - Convert.ToString(str2).RealLen(), true) + str2;
        }

    }
}
