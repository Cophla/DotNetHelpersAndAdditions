using System.Data;

namespace DotNetHelpersAndAdditions.SystemHelpers.DataHelpers
{
    public interface IDbExecuter
    {
        #region Public Properties

        CommandType CommandType { get; set; }

        IDbConnection Connection { get; set; }

        DbDisposeType DisposeType { get; set; }

        string SqlString { get; set; }

        IDbTransaction Transaction { get; set; }

        #endregion Public Properties

        #region Public Methods

        IDataParameter AddOutParm(string parameterName, SqlDbType dbType, int size = 0);

        IDataParameter AddParm(string parameterName, object value);

        T ExecScalar<T>(T defaultValue = default(T));

        bool ExecSuccess();

        IDataReader GetDataReader();

        IDataReader GetSingleRow();

        T GetValue<T>(string parameterName);

        void Prepare(string sqlString);

        #endregion Public Methods
    }
}