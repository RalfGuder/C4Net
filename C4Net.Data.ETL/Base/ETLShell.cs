using System;
using System.Collections.Generic;
using C4Net.Data.ETL.Config;
using C4Net.Data.ETL.Interfaces;
using C4Net.Templates;

namespace C4Net.Data.ETL.Base
{
    /// <summary>
    /// The ETL shell.
    /// </summary>
    public class ETLShell : IETLShell
    {
        #region - Properties -

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public ETLConfig Configuration { get; private set; }

        /// <summary>
        /// Gets the root container.
        /// </summary>
        /// <value>
        /// The root container.
        /// </value>
        public TemplateContainer RootContainer { get; private set; }

        public Dictionary<string, Type> ItemTypes { get; private set; }


        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="ETLShell"/> class.
        /// </summary>
        public ETLShell()
        {
            this.Configuration = new ETLConfig();
            this.RootContainer = new TemplateContainer(null);
            this.ItemTypes = new Dictionary<string, Type>();
        }

        #endregion
    }
}
