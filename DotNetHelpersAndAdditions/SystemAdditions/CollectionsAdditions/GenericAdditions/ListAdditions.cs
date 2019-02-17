using System;
using System.Collections.Generic;

namespace DotNetHelpersAndAdditions.SystemAdditions.CollectionsAdditions.GenericAdditions
{
    public static class ListAdditions
    {
        #region Public Methods

        public static void DaDispose<T>(this IList<T> list) where T : IDisposable
        {
            for (int index = 0; index < list.Count; index++)
            {
                list[index]?.Dispose();
            }
            list.Clear();
        }

        #endregion Public Methods
    }
}