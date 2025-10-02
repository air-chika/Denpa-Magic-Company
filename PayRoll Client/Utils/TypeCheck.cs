using PayRoll_Client.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.Utils
{
    public enum TextType
    {
        Text, Int, Real, Tax, Date, Name, Digits, Hours
    }

    public class TypeCheck
    {
        public static bool Correct(string name, string? text, TextType type)
        {
            switch (type)
            {
                case TextType.Text:
                    return true;
                case TextType.Name:
                    if (text == null || text.Trim() == "")
                    {
                        ErrorBox.Error(name + @"作为名称，无法为空。");
                        return false;
                    }
                    break;
                case TextType.Int:
                    if (!int.TryParse(text, out int r))
                    {
                        ErrorBox.Error(name + @"应该是整数。");
                        return false;
                    }
                    break;
                case TextType.Real:
                    if (!double.TryParse(text, out double d))
                    {
                        ErrorBox.Error(name + @"应该是浮点数。");
                        return false;
                    }
                    break;
                case TextType.Tax:
                    if (!(double.TryParse(text, out double m) && 0 <= m && m < 1))
                    {
                        ErrorBox.Error(name + @"应该是位于0与1之间的浮点数。");
                        return false;
                    }
                    break;
                case TextType.Date:
                    if (!(DateTime.TryParse(text, out var date)))
                    {
                        ErrorBox.Error(name + @"应该是日期。");
                        return false;
                    }
                    break;
                case TextType.Digits:
                    if (text == null ? false : text.Any(x => !char.IsDigit(x)))
                    {
                        ErrorBox.Error(name + @"只能包含数字。");
                        return false;
                    }
                    break;
                case TextType.Hours:
                    if (!(int.TryParse(text, out int h) && 0 <= h && h <= 24))
                    {
                        ErrorBox.Error(name + @"应该位于0~24之间。");
                        return false;
                    }
                    break;
            }

            return true;
        }

    }
}
