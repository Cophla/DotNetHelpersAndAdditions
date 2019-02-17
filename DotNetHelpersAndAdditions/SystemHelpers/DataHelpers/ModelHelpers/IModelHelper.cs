using System;
using System.Data;

namespace DotNetHelpersAndAdditions.SystemHelpers.DataHelpers.ModelHelpers
{
    public interface IModelHelper
    {
        #region Public Properties

        bool Enabled { get; set; }

        string ExtraComment { get; set; }

        Type ModelType { get; set; }

        int UserExecuterId { get; set; }

        #endregion Public Properties

        #region Public Methods

        void Fill(IDataReader reader);

        #endregion Public Methods
    }
}