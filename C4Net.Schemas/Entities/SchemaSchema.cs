using System.Collections.Generic;
using C4Net.Templates;

namespace C4Net.Schemas.Entities
{
    /// <summary>
    /// Class for the schema of a database schema.
    /// </summary>
    public class SchemaSchema : SchemaBase
    {
        #region - Properties -

        /// <summary>
        /// Gets or sets the tables.
        /// </summary>
        /// <value>
        /// The tables.
        /// </value>
        public Dictionary<string, SchemaTable> Tables { get; set; }

        /// <summary>
        /// Gets or sets the views.
        /// </summary>
        /// <value>
        /// The views.
        /// </value>
        public Dictionary<string, SchemaView> Views { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaSchema"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        /// <param name="logicalName">Name of the logical.</param>
        public SchemaSchema(SchemaBase parent, string physicalName, string logicalName)
            : base(parent, physicalName, logicalName)
        {
            this.Tables = new Dictionary<string, SchemaTable>();
            this.Views = new Dictionary<string, SchemaView>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaSchema"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        public SchemaSchema(SchemaBase parent, string physicalName)
            : base(parent, physicalName) 
        {
            this.Tables = new Dictionary<string, SchemaTable>();
            this.Views = new Dictionary<string, SchemaView>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaSchema"/> class.
        /// </summary>
        public SchemaSchema()
            : base()
        {
            this.Tables = new Dictionary<string, SchemaTable>();
            this.Views = new Dictionary<string, SchemaView>();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Sorts the content of the instance.
        /// </summary>
        public override void Sort()
        {
            foreach (SchemaTable table in this.Tables.Values)
            {
                table.Sort();
            }
            foreach (SchemaView view in this.Views.Values)
            {
                view.Sort();
            }
        }

        /// <summary>
        /// Writes this instance content to a container.
        /// </summary>
        /// <param name="container">The container.</param>
        public override void WriteTo(TemplateContainer container)
        {
            base.WriteTo(container);
            TemplateContainer sonContainer = container.AddSon("Tables");
            foreach (SchemaTable table in this.Tables.Values)
            {
                table.WriteTo(sonContainer.AddArrayValue());
            }
            sonContainer = container.AddSon("Views");
            foreach (SchemaView view in this.Views.Values)
            {
                view.WriteTo(sonContainer.AddArrayValue());
            }
        }

        #endregion
    }
}
