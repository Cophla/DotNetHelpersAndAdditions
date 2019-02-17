using System.Globalization;

namespace DotNetHelpersAndAdditions.SystemAdditions
{
    public static class Int64Additions
    {
        #region Public Methods

        public static string DaToString(this long value)
            => value.ToString(CultureInfo.InvariantCulture);

        #endregion Public Methods
    }
}