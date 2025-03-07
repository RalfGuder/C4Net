using System;
using System.Collections.Generic;
using C4Net.Data.ETL.Config;
using C4Net.Templates;

namespace C4Net.Data.ETL.Interfaces
{
    /// <summary>
    /// Interface for the shell of the ETL.
    /// </summary>
    public interface IETLShell
    {
        #region - Properties -

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        ETLConfig Configuration { get; }

        /// <summary>
        /// Gets the root container.
        /// </summary>
        /// <value>
        /// The root container.
        /// </value>
        TemplateContainer RootContainer { get; }

        Dictionary<string, Type> ItemTypes { get; }

        #endregion
    }
}
