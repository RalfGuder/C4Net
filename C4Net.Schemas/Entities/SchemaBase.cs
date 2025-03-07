using C4Net.Core.Utils;
using C4Net.Templates;

namespace C4Net.Schemas.Entities
{
    /// <summary>
    /// Base class for schema objects.
    /// </summary>
    public abstract class SchemaBase
    {
        #region - Properties -

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        public SchemaBase Parent { get; set; }

        /// <summary>
        /// Gets or sets the name of the logical.
        /// </summary>
        /// <value>
        /// The name of the logical.
        /// </value>
        public string LogicalName { get; set; }

        /// <summary>
        /// Gets or sets the name of the physical.
        /// </summary>
        /// <value>
        /// The name of the physical.
        /// </value>
        public string PhysicalName { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaBase"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        /// <param name="logicalName">Name of the logical.</param>
        public SchemaBase(SchemaBase parent, string physicalName, string logicalName)
        {
            this.Parent = parent;
            this.PhysicalName = physicalName;
            this.LogicalName = logicalName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaBase"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        public SchemaBase(SchemaBase parent, string physicalName)
            : this(parent, physicalName, StringUtil.Pascalize(physicalName))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaBase"/> class.
        /// </summary>
        public SchemaBase()
        {
            this.Parent = null;
            this.PhysicalName = string.Empty;
            this.LogicalName = string.Empty;
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Sorts the content of the instance.
        /// </summary>
        public abstract void Sort();

        /// <summary>
        /// Writes this instance content to a container.
        /// </summary>
        /// <param name="container">The container.</param>
        public virtual void WriteTo(TemplateContainer container)
        {
            container.Attributes.Add("LogicalName", this.LogicalName);
            container.Attributes.Add("PhysicalName", this.PhysicalName);
        }

        #endregion
    }
}
