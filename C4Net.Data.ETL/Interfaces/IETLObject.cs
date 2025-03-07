using System;
using C4Net.Data.ETL.Config;
using C4Net.Templates;

namespace C4Net.Data.ETL.Interfaces
{
    /// <summary>
    /// Interface for any object of the ETL.
    /// </summary>
    public interface IETLObject
    {
        #region - Properties -

        /// <summary>
        /// Gets the name of the ETL Object
        /// </summary>
        /// <value>
        /// The name of the ETL Object.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets the type of the ETL object.
        /// </summary>
        /// <value>
        /// The type of the item.
        /// </value>
        string ItemType { get; }

        string ChildTemplateName { get; }

        #endregion

        #region - Events -

        /// <summary>
        /// Occurs when [on begin process item].
        /// </summary>
        event EventHandler OnBeginProcessItem;

        /// <summary>
        /// Occurs when [on end process item].
        /// </summary>
        event EventHandler OnEndProcessItem;

        #endregion

        #region - Methods -

        /// <summary>
        /// Configures the ETL Object.
        /// </summary>
        /// <param name="etlShell">The ETL shell.</param>
        /// <returns></returns>
        bool Configure(ETLItemConfig config);

        /// <summary>
        /// Opens the object.
        /// </summary>
        /// <returns></returns>
        bool Open();

        /// <summary>
        /// Closes the object.
        /// </summary>
        void Close();

        /// <summary>
        /// Executes the object using the specified container path.
        /// </summary>
        /// <param name="path">The path.</param>
        void Process(string containerPath);

        #endregion
    }
}
