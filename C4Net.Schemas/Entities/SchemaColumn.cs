using C4Net.Templates;

namespace C4Net.Schemas.Entities
{
    /// <summary>
    /// Class for a column schema.
    /// </summary>
    public class SchemaColumn : SchemaBase
    {
        #region - Properties -

        /// <summary>
        /// Gets or sets the order of the column in the table.
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the type of the data.
        /// </summary>
        /// <value>
        /// The type of the data.
        /// </value>
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets the .NET type.
        /// </summary>
        /// <value>
        /// The type of the net.
        /// </value>
        public string NetType { get; set; }

        /// <summary>
        /// Gets or sets the length of the data.
        /// </summary>
        /// <value>
        /// The length of the data.
        /// </value>
        public int DataLength { get; set; }

        /// <summary>
        /// Gets or sets the num decimals.
        /// </summary>
        /// <value>
        /// The num decimals.
        /// </value>
        public int NumDecimals { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is primary key.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is primary key; otherwise, <c>false</c>.
        /// </value>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this column is nullable.
        /// </summary>
        /// <value>
        /// <c>true</c> if this column is nullable; otherwise, <c>false</c>.
        /// </value>
        public bool IsNullable { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaColumn"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        /// <param name="logicalName">Name of the logical.</param>
        public SchemaColumn(SchemaBase parent, string physicalName, string logicalName)
            : base(parent, physicalName, logicalName)
        {
            this.DataType = string.Empty;
            this.NetType = string.Empty;
            this.DataLength = 0;
            this.NumDecimals = 0;
            this.IsPrimaryKey = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaColumn"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        public SchemaColumn(SchemaBase parent, string physicalName)
            : base(parent, physicalName)
        {
            this.DataType = string.Empty;
            this.NetType = string.Empty;
            this.DataLength = 0;
            this.NumDecimals = 0;
            this.IsPrimaryKey = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaColumn"/> class.
        /// </summary>
        public SchemaColumn()
            : base()
        {
            this.DataType = string.Empty;
            this.NetType = string.Empty;
            this.DataLength = 0;
            this.NumDecimals = 0;
            this.IsPrimaryKey = false;
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Sorts the content of the instance.
        /// </summary>
        public override void Sort()
        {
            
        }

        /// <summary>
        /// Writes this instance content to a container.
        /// </summary>
        /// <param name="container">The container.</param>
        public override void WriteTo(TemplateContainer container)
        {
            base.WriteTo(container);
            container.AddAttribute("Order", this.Order.ToString());
            container.AddAttribute("DataType", this.DataType);
            container.AddAttribute("NetType", this.NetType);
            container.AddAttribute("DataLength", this.DataLength.ToString());
            container.AddAttribute("NumDecimals", this.NumDecimals.ToString());
            container.AddAttribute("IsPrimaryKey", this.IsPrimaryKey.ToString());
            container.AddAttribute("IsNullable", this.IsNullable.ToString());
        }

        #endregion
    }
}
