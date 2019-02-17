using DotNetHelpersAndAdditions.SystemHelpers;
using System;
using System.Data;

namespace DotNetHelpersAndAdditions.SystemAdditions.DataAdditions
{
    public static class IDbConnectionAdditions
    {
        #region Private Fields

        private const string _IS_READY_COMMAND_TEXT = "select TOP(1) 1";

        #endregion Private Fields

        #region Public Methods

        public static bool DaIsOpen(this IDbConnection connection, MessageString errorMsg = null)
        {
            if (connection == null) { return false; }
            if (connection.State == ConnectionState.Open) { return true; }

            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex) { errorMsg?.Append(ex.ToString()); }
            return false;
        }

        public static bool DaIsReady(this IDbConnection connction, MessageString errorMsg = null)
        {
            if (connction.DaIsOpen(errorMsg) == false) { return false; }
            try
            {
                using (var command = connction.CreateCommand())
                {
                    command.CommandText = _IS_READY_COMMAND_TEXT;
                    command.Connection = connction;
                    return ((int)command.ExecuteScalar()) == 1;
                }
            }
            catch (Exception ex) { errorMsg?.Append(ex.ToString()); }
            return false;
        }

        #endregion Public Methods
    }
}