using System.Data;

namespace DotNetHelpersAndAdditions.SystemAdditions.DataAdditions
{
    public static class IDataReaderAdditions
    {
        #region Public Methods

        public static T DaGet<T>(this IDataReader reader, string name)
           => reader[name].DaDbOut<T>();

        #endregion Public Methods
    }
}