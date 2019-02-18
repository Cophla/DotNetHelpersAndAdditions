using System.Data;

namespace DotNetHelpersAndAdditions.SystemHelpers.DataHelpers
{
    public interface IDbConnectionManager
    {
        #region Public Methods

        IDbConnection Add(string name);

        bool Exists(string name);

        IDbConnection GetConn(string name);

        IDbConnection GetNewConn(string name);

        #endregion Public Methods
    }
}