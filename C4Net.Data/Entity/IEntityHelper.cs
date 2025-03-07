using System.Collections.Generic;
using C4Net.Core.Accessor;
using C4Net.Data.Definitions;

namespace C4Net.Data.Entity
{
    /// <summary>
    /// Interface for an Entity Helper.
    /// </summary>
    public interface IEntityHelper
    {
        #region - Properties -

        int Depth { get; }

        /// <summary>
        /// Gets the definition.
        /// </summary>
        /// <value>
        /// The definition.
        /// </value>
        TableDefinition Definition { get; }

        /// <summary>
        /// Gets the object proxy.
        /// </summary>
        /// <value>
        /// The object proxy.
        /// </value>
        IObjectProxy ObjectProxy { get; }

        /// <summary>
        /// Gets the get primary key properties.
        /// </summary>
        /// <value>
        /// The get primary key properties.
        /// </value>
        List<string> GetPrimaryKeyProperties { get; }

        #endregion

        #region - Methods -

        /// <summary>
        /// Gets the primary key values.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        object[] GetPrimaryKeyValues(object instance);

        /// <summary>
        /// Gets the primary key STR.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        string GetPrimaryKeyStr(object instance);

        #endregion
    }
}
