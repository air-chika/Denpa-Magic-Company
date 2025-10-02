using Microsoft.VisualBasic.Devices;
using Models;
using PayRoll_Client.Controller;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.Utils
{
    public static class ArtHelpers
    {
        public static Color red = Color.FromArgb(181, 46, 49);
        public static Color blue = Color.FromArgb(21, 69, 153);
        public static Color orange = Color.FromArgb(250, 150, 70);

        public static Color black1 = Color.FromArgb(38, 38, 38);
        public static Color black2 = Color.FromArgb(88, 88, 88);
        public static Color black3 = Color.FromArgb(128, 128, 128);

        public static Color amber = Color.FromArgb(255, 191, 0);
        public static Color bGold = Color.FromArgb(159, 125, 53);
        public static Color gold = Color.FromArgb(215, 190, 135);
        public static Color brown = Color.FromArgb(190, 140, 0);


        public static Color ggreen = Color.FromArgb(155, 190, 90);
        public static Color green = Color.FromArgb(21, 121, 94);
        public static Color disable = Color.FromArgb(7, 39, 31);


        public static Color tbSingle = Color.FromArgb(100, 100, 100);


        public static void abase(this Button bt, float size)
        {
            bt.Dock = DockStyle.Fill;
            bt.FlatAppearance.BorderSize = bt.Height < 50 ? 2 : bt.Height < 60 ? 3 : 4;
            bt.FlatStyle = FlatStyle.Flat;
            bt.Font = new Font("得意黑", size, FontStyle.Regular, GraphicsUnit.Point);
        }
        public static void alabable(this Button bt, float size)
        {
            bt.FlatAppearance.MouseOverBackColor = bt.BackColor;
            bt.FlatAppearance.MouseDownBackColor = bt.BackColor;
        }

        public static void Based(this Button bt, float size = 17F)
        {
            bt.abase(size);
            bt.ForeColor = gold;
            bt.BackColor = green;
            bt.FlatAppearance.BorderColor = ggreen;
        }

        public static void BasedLabBtn(this Button bt, float size = 17F)
        {
            bt.Based(size);
            bt.FlatAppearance.BorderColor = bt.BackColor;
        }

        public static void BasedLab(this Button bt, float size = 17F)
        {
            bt.BasedLabBtn(size);
            bt.alabable(size);
        }


        public static void BasedLab_SameBase(this Button bt, float size = 17F)
        {
            bt.Based(size);
            bt.alabable(size);
        }

        public static void BasedTitle(this Button bt, float size = 17F)
        {
            BasedTitleBtn(bt, size);
            bt.alabable(size);
        }

        public static void BasedTitleBtn(this Button bt, float size = 17F)
        {
            bt.abase(size);
            bt.ForeColor = gold;
            bt.BackColor = green;
            bt.FlatAppearance.BorderColor = blue;
        }
        public static void BasedTitleR(this Button bt, float size = 17F)
        {
            bt.BasedTitleRBtn(size);
            bt.alabable(size);
        }

        public static void BasedTitleRBtn(this Button bt, float size = 17F)
        {
            bt.abase(size);
            bt.ForeColor = gold;
            bt.BackColor = green;
            bt.FlatAppearance.BorderColor = red;
        }


        public static void BasedAmber(this Button bt, float size = 17F)
        {
            bt.BasedAmberBtn(size);
            bt.alabable(size);
        }

        public static void BasedAmberBtn(this Button bt, float size = 17F)
        {
            bt.abase(size);
            bt.ForeColor = gold;
            bt.BackColor = green;
            bt.FlatAppearance.BorderColor = amber;
        }



        public static void BasedChoice(this Button bt, float size = 17F)
        {
            bt.abase(size);
            bt.ForeColor = gold;
            bt.BackColor = green;
            bt.FlatAppearance.BorderColor = gold;
            bt.alabable(size);
        }

        public static void BasedChoiceAlter(this Button bt, float size = 17F)
        {
            bt.abase(size);
            bt.ForeColor = green;
            bt.BackColor = gold;
            bt.FlatAppearance.BorderColor = green;
            bt.alabable(size);
        }

        public static void BasedChoosing(this Button bt, float size = 17F)
        {
            bt.abase(size);
            bt.ForeColor = gold;
            bt.BackColor = blue;
            bt.FlatAppearance.BorderColor = gold;
            bt.alabable(size);
        }


        public static void BasedDelete(this Button bt, float size = 17F)
        {
            bt.abase(size);
            bt.ForeColor = gold;
            bt.BackColor = red;
            bt.FlatAppearance.BorderColor = gold;
            bt.alabable(size);
        }

        public static void Reported(this TextBox tb, float size = 17F)
        {
            tb.ForeColor = gold;
            tb.BackColor = green;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = new Font("微软雅黑", size, FontStyle.Bold, GraphicsUnit.Point);
            tb.Multiline = true;
            tb.TextAlign = HorizontalAlignment.Left;
        }

        public static void Reported2(this TextBox tb, float size = 17F)
        {
            tb.BackColor = green;
            tb.ForeColor = gold;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = new Font("微软雅黑", size, FontStyle.Bold, GraphicsUnit.Point);
            tb.Multiline = true;
            tb.TextAlign = HorizontalAlignment.Left;
        }


        public static void abase(this TextBox tb, float size = 20F)
        {
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = new Font("得意黑", size, FontStyle.Regular, GraphicsUnit.Point);
            tb.Multiline = true;
            tb.TextAlign = HorizontalAlignment.Center;
        }


        public static void Based(this TextBox tb, float size = 20F)
        {
            tb.abase(size);
            tb.BackColor = green;
            tb.ForeColor = gold;
        }


        public static void Based(this Label label1, float size = 17F)
        {
            label1.ForeColor = gold;
            label1.BackColor = black1;
            label1.Font = new Font("得意黑", size, FontStyle.Regular, GraphicsUnit.Point);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
        }
        public static void BasedFill(this Label label1, float size = 17F)
        {
            label1.ForeColor = gold;
            label1.BackColor = green;
            label1.Font = new Font("得意黑", size, FontStyle.Regular, GraphicsUnit.Point);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Dock = DockStyle.Fill;
        }

        public static void Based(this ComboBox team1, float size = 20F)
        {
            team1.BackColor = green;
            team1.ForeColor = gold;
            team1.FlatStyle = FlatStyle.Flat;
            team1.Font = new Font("得意黑", size, FontStyle.Regular, GraphicsUnit.Point);
        }


        public static Point Dxy(this Point pt, int dx, int dy)
        {
            return new Point(pt.X + dx, pt.Y + dy);
        }

        public static void SetMidLoc(this Form f, Form mainForm = null)
        {
            if (mainForm == null) mainForm = FormCtr.form;
            var l1 = mainForm.Location;
            var s1 = mainForm.ClientSize;

            var s2 = f.ClientSize;
            var x = (s1 - s2) / 2;
            f.SetDesktopLocation(l1.X + x.Width, l1.Y + x.Height);
        }



    }
}
