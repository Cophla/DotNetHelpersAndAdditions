using System.Data;

namespace DotNetHelpersAndAdditions.SystemAdditions.DataAdditions
{
    public static class DataRowAdditions
    {
        #region Public Methods

        public static T ExGet<T>(this DataRow dr, string name, T defaultValue = default(T))
            => dr[name].DaDbOut(defaultValue);

        #endregion Public Methods
    }
}