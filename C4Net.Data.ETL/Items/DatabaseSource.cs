using System;
using System.Data;
using System.Data.Common;
using System.Globalization;
using C4Net.Core.IoC;
using C4Net.Data.Connections;
using C4Net.Data.ETL.Base;
using C4Net.Templates.Parser;

namespace C4Net.Data.ETL.Sources
{
    /// <summary>
    /// Class for a database ETL source.
    /// </summary>
    public class DatabaseSource : ETLSourceBase
    {
        #region - Fields -

        /// <summary>
        /// The connection name
        /// </summary>
        private string connectionName;

        /// <summary>
        /// The SQL to be executed.
        /// </summary>
        private string sql;

        /// <summary>
        /// The data table.
        /// </summary>
        private DataTable table;

        #endregion

        #region - Methods -

        /// <summary>
        /// Internal configuration.
        /// </summary>
        /// <returns></returns>
        protected override bool InnerConfigure()
        {
            bool result = base.InnerConfigure();
            if (result)
            {
                this.connectionName = LanguageParser.ReplaceString(this.config.Parameters["connectionName"], this.container);
                this.table = new DataTable();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Opens the source.
        /// </summary>
        protected override void OpenSource()
        {
            this.sql = LanguageParser.ReplaceString(this.config.Parameters["sql"].Trim(), this.container);
            if (this.sql.StartsWith("TABLE"))
            {
                this.sql = "SELECT * FROM " + this.sql.Remove(0, 6);
            }
            DbConnectionInfo connectionInfo = DefaultContainer.Get<IDbConnectionManager>().GetConnectionInfo(this.connectionName);
            IDbDataAdapter adapter = connectionInfo.Provider.CreateDataAdapter();
            IDbConnection connection = DefaultContainer.Get<IDbConnectionManager>().GetConnection(this.connectionName);
            adapter.SelectCommand = connection.CreateCommand();
            adapter.SelectCommand.CommandText = this.sql;
            (adapter as DbDataAdapter).Fill(this.table);
            this.TotalRows = this.table.Rows.Count;
            this.Row.Clear();
        }

        /// <summary>
        /// Gets the column names.
        /// </summary>
        protected override void GetColumnNames()
        {
            foreach (DataColumn column in this.table.Columns)
            {
                this.ColumnNames.Add(column.ColumnName);
            }
        }

        /// <summary>
        /// Converts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="dataType">Type of the data.</param>
        /// <returns></returns>
        protected virtual string Convert(object value, Type dataType)
        {
            if (value.GetType() == typeof(DBNull))
            {
                return null;
            }
            if (dataType == typeof(double))
            {
                return ((double?)value).HasValue ? ((double?)value).Value.ToString(CultureInfo.InvariantCulture) : null;
            }
            if (dataType == typeof(decimal))
            {
                return ((decimal?)value).HasValue ? ((decimal?)value).Value.ToString(CultureInfo.InvariantCulture) : null;
            }
            return value.ToString();
        }

        /// <summary>
        /// Reads the next record.
        /// </summary>
        /// <returns></returns>
        protected override bool ReadNext()
        {
            if (this.CurrentRow >= this.TotalRows)
            {
                return false;
            }
            this.Row.Clear();
            foreach (DataColumn column in this.table.Columns)
            {
                this.Row.Add(this.Convert(this.table.Rows[this.CurrentRow][column], column.DataType));
            }
            return true;
        }

        #endregion
    }
}
