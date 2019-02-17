using System;
using System.Data;

namespace DotNetHelpersAndAdditions.SystemAdditions.DataAdditions
{
    public static class IDbTransactionAdditions
    {
        #region Public Methods

        public static void DaCommit(this IDbTransaction transaction)
        {
            try
            {
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
        }

        #endregion Public Methods
    }
}