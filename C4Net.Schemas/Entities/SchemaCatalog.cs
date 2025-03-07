using System.Collections.Generic;
using C4Net.Templates;

namespace C4Net.Schemas.Entities
{
    /// <summary>
    /// Class for a Database Catalog Schema.
    /// </summary>
    public class SchemaCatalog : SchemaBase
    {
        #region - Properties -

        /// <summary>
        /// Gets or sets the schemas.
        /// </summary>
        /// <value>
        /// The schemas.
        /// </value>
        public Dictionary<string, SchemaSchema> Schemas { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaCatalog"/> class.
        /// </summary>
        /// <param name="physicalName">Name of the physical.</param>
        /// <param name="logicalName">Name of the logical.</param>
        public SchemaCatalog(string physicalName, string logicalName)
            : base(null, physicalName, logicalName)
        {
            this.Schemas = new Dictionary<string, SchemaSchema>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaCatalog"/> class.
        /// </summary>
        /// <param name="physicalName">Name of the physical.</param>
        public SchemaCatalog(string physicalName)
            : base(null, physicalName) 
        {
            this.Schemas = new Dictionary<string, SchemaSchema>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaCatalog"/> class.
        /// </summary>
        public SchemaCatalog()
            : base()
        {
            this.Schemas = new Dictionary<string, SchemaSchema>();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Sorts the content of the instance.
        /// </summary>
        public override void Sort()
        {
            foreach (SchemaSchema schema in this.Schemas.Values)
            {
                schema.Sort();
            }
        }

        /// <summary>
        /// Writes this instance content to a container.
        /// </summary>
        /// <param name="container">The container.</param>
        public override void WriteTo(TemplateContainer container)
        {
            base.WriteTo(container);
            TemplateContainer sonContainer = container.AddSon("Schemas");
            foreach (SchemaSchema schema in this.Schemas.Values)
            {
                schema.WriteTo(sonContainer.AddArrayValue());
            }
        }

        #endregion
    }
}
