using System;

namespace DotNetHelpersAndAdditions.SystemAdditions
{
    public static class ArrayAdditions
    {
        #region Public Methods

        public static void DaClear(this Array args, int index = 0)
        {
            Array.Clear(args, index, args.Length);
        }

        #endregion Public Methods
    }
}