using System;
using System.Globalization;

namespace DotNetHelpersAndAdditions.SystemAdditions
{
    public static class DateTimeAdditions
    {
        #region Public Methods

        public static DateTime? DaNParse(this string text, string format)
        {
            if (DateTime.TryParseExact(
                text.Trim(), format, CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime outValue))
            {
                return outValue;
            }
            return default(DateTime?);
        }

        public static DateTime DaParse(this string text, string format)
            => DateTime.ParseExact(text.Trim(), format, CultureInfo.InvariantCulture);

        public static string DaToString(this DateTime value, string format)
            => value.ToString(format, CultureInfo.InvariantCulture);

        #endregion Public Methods
    }
}