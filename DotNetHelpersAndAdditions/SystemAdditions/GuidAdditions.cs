using System;
using System.Globalization;

namespace DotNetHelpersAndAdditions.SystemAdditions
{
    public static class GuidAdditions
    {
        #region Public Methods

        public static string DaToString(this Guid value, string format)
            => value.ToString(format, CultureInfo.InvariantCulture);

        #endregion Public Methods
    }
}