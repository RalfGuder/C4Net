
namespace C4Net.Schemas.Entities
{
    /// <summary>
    /// Class for the schema of a database view.
    /// </summary>
    public class SchemaView : SchemaTabular
    {
        #region - Methods -

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaView"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        /// <param name="logicalName">Name of the logical.</param>
        public SchemaView(SchemaBase parent, string physicalName, string logicalName)
            : base(parent,physicalName, logicalName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaView"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        public SchemaView(SchemaBase parent, string physicalName)
            : base(parent, physicalName) 
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaView"/> class.
        /// </summary>
        public SchemaView()
            : base()
        {
        }

        #endregion
    }
}
