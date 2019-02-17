using System.Globalization;

namespace DotNetHelpersAndAdditions.SystemAdditions
{
    public static class BoolAdditions
    {
        #region Public Methods

        public static string DaToString(this bool byteValue)
            => byteValue.ToString(CultureInfo.InvariantCulture);

        #endregion Public Methods
    }
}