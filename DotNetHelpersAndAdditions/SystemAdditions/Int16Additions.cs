using System.Globalization;

namespace DotNetHelpersAndAdditions.SystemAdditions
{
    public static class Int16Additions
    {
        #region Public Methods

        public static string DaToString(this short value)
           => value.ToString(CultureInfo.InvariantCulture);

        #endregion Public Methods
    }
}