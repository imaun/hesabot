using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesabot.Telegram.Models
{
    public static class BotCommandList
    {
        public const string START = "start";
        public const string MENU = "منو";
        public const string CANCEL = "کنسل";
        public const string REP_TODAY = "امروز";
        public const string REP_YESTERDAY = "دیروز";
        public const string REP_WEEK = "هفته";
        public const string REP_MONTH = "ماه";
        public const string TRX_ADD = "ثبت تراکنش";
        public static string[] TRXX_ADD = new[] { "ثبت تراکنش", "تراکنش" };
        public static string[] ACCOUNT_ADD = new[] { "تعریف حساب", "ثبت حساب" };
        public static string[] HELP = new[] { "راهنما", "کمک" };
        public static string CONTACT = "تماس";

    }
}
