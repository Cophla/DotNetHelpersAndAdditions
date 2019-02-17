using System.Globalization;

namespace DotNetHelpersAndAdditions.SystemAdditions
{
    public static class ByteAdditions
    {
        #region Public Methods

        public static string DaToString(this byte byteValue)
            => byteValue.ToString(CultureInfo.InvariantCulture);

        public static string DaToString(this byte byteValue, string format)
            => byteValue.ToString(format, CultureInfo.InvariantCulture);

        #endregion Public Methods
    }
}