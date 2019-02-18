using DotNetHelpersAndAdditions.SystemHelpers.DataHelpers.ModelHelpers;
using System.Collections.Generic;

namespace DotNetHelpersAndAdditions.SystemHelpers.DataHelpers
{
    public interface IDbModelHelper
    {
        #region Public Methods

        IList<T> GetList<T>() where T : IModelHelper;

        IList<T> GetListCounted<T>(string numberOfRowsField = "number_of_rows")
            where T : IModelHelper;

        #endregion Public Methods
    }
}