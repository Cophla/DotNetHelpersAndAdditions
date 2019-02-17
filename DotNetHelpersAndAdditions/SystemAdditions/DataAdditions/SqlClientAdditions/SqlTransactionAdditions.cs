using System;
using System.Data.SqlClient;

namespace DotNetHelpersAndAdditions.SystemAdditions.DataAdditions.SqlClientAdditions
{
    public static class SqlTransactionAdditions
    {
        #region Public Methods

        public static void DaCommit(this SqlTransaction transaction, string TRANSACTION_NAME)
        {
            try
            {
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.DaRollback(TRANSACTION_NAME);
            }
        }

        public static string DaCut32(this string value) => value.DaCut(32);

        public static void DaRollback(this SqlTransaction transaction, string TRANSACTION_NAME)
        {
            if (TRANSACTION_NAME.DaIsNone()) { transaction.Rollback(TRANSACTION_NAME); }
            else { transaction.Rollback(); }
        }

        #endregion Public Methods
    }
}