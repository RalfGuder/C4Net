using C4Net.Templates;

namespace C4Net.Schemas.Reader
{
    /// <summary>
    /// Interface for a reader of database schemas
    /// </summary>
    public interface ISchemaReader
    {
        #region - Methods -

        /// <summary>
        /// Opens the reader.
        /// </summary>
        /// <returns></returns>
        bool Open();

        /// <summary>
        /// Closes the reader.
        /// </summary>
        void Close();

        /// <summary>
        /// Reads the tables.
        /// </summary>
        void ReadTables();

        /// <summary>
        /// Reads the views.
        /// </summary>
        void ReadViews();

        /// <summary>
        /// Reads the columns.
        /// </summary>
        void ReadColumns();

        /// <summary>
        /// Reads the indexes.
        /// </summary>
        void ReadIndexes();

        /// <summary>
        /// Sorts the content.
        /// </summary>
        void Sort();

        /// <summary>
        /// Reads the schemas.
        /// </summary>
        void Read();

        /// <summary>
        /// Gets the container.
        /// </summary>
        /// <param name="catalogName">Name of the catalog.</param>
        /// <param name="schemaName">Name of the schema.</param>
        /// <returns></returns>
        TemplateContainer GetContainer(string catalogName, string schemaName);

        #endregion
    }
}
