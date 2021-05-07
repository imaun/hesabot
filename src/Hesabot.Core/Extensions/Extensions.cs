namespace Hesabot.Core.Extensions {

    public static class Extensions {

        private static readonly System.Type _typeOfString = typeof(string);

        public const char ArabicYeChar = (char)1610;
        public const char PersianYeChar = (char)1740;

        public const char ArabicKeChar = (char)1603;
        public const char PersianKeChar = (char)1705;

        public static string ApplyCorrectYeKe(this string data) {
            return string.IsNullOrWhiteSpace(data) ?
                data :
                data.Replace(ArabicYeChar, PersianYeChar)
                    .Replace(ArabicKeChar, PersianKeChar)
                    .Trim();
        }

        public static bool IsNullOrEmpty(this string value)
            => string.IsNullOrWhiteSpace(value);

        public static bool IsNotNullOrEmpty(this string value)
            => !IsNullOrEmpty(value);

    }
}
