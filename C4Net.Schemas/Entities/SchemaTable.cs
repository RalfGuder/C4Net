
namespace C4Net.Schemas.Entities
{
    /// <summary>
    /// Class for the schema of a database table.
    /// </summary>
    public class SchemaTable : SchemaTabular
    {
        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaTable"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        /// <param name="logicalName">Name of the logical.</param>
        public SchemaTable(SchemaBase parent, string physicalName, string logicalName)
            : base(parent, physicalName, logicalName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaTable"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        public SchemaTable(SchemaBase parent, string physicalName)
            : base(parent, physicalName) 
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaTable"/> class.
        /// </summary>
        public SchemaTable()
            : base()
        {
        }

        #endregion
    }
}
