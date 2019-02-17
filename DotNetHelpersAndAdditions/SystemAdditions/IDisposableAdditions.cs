using System;

namespace DotNetHelpersAndAdditions.SystemAdditions
{
    public static class IDisposableAdditions
    {
        #region Public Methods

        public static void DaDispose(this IDisposable[] args)
        {
            for (int index = 0; index < args.Length; index++)
            {
                if (args[index] == null) { continue; }
                args[index].Dispose();
                args[index] = null;
            }
        }

        #endregion Public Methods
    }
}