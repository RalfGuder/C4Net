using System;
using System.Data;
using System.Xml;
using C4Net.Core.Types;
using C4Net.Core.Utils;

namespace C4Net.Data.Definitions
{
    /// <summary>
    /// Definition of a column, can be loaded from Attribute or from xml node.
    /// </summary>
    [Serializable]
    public class ColumnDefinition : Attribute, IXmlManagerItem
    {
        #region - Properties -

        /// <summary>
        /// Gets or sets the logical name of the column.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the physical name of the column.
        /// </summary>
        /// <value>
        /// The name of the column.
        /// </value>
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets the type of the data.
        /// </summary>
        /// <value>
        /// The type of the data.
        /// </value>
        public DbType DataType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is primary key.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is primary key; otherwise, <c>false</c>.
        /// </value>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance allow null values.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow null]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowNull { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is auto increment.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is auto increment; otherwise, <c>false</c>.
        /// </value>
        public bool IsAutoIncrement { get; set; }

        #endregion

        #region - Constructor -

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinition"/> class.
        /// </summary>
        public ColumnDefinition()
            : base()
        {
            this.Name = string.Empty;
            this.ColumnName = string.Empty;
            this.DataType = DbType.String;
            this.IsPrimaryKey = false;
            this.AllowNull = true;
            this.IsAutoIncrement = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinition"/> class.
        /// </summary>
        /// <param name="node">The node.</param>
        public ColumnDefinition(XmlNode node)
            : this()
        {
            this.LoadFromNode(node);
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Inner load of the attributes into the properties.
        /// </summary>
        protected void InnerLoad(NodeAttributes attributes)
        {
            this.Name = attributes.AsString("Name");
            this.ColumnName = attributes.AsString("ColumnName");
            this.IsPrimaryKey = attributes.AsBool("PrimaryKey", false);
            this.AllowNull = attributes.AsBool("AllowNulls", true);
            this.IsAutoIncrement = attributes.AsBool("AutoIncrement", false);
            this.DataType = TypesManager.GetDbType(attributes.AsString("DataType"));
        }

        /// <summary>
        /// Loads from node.
        /// </summary>
        /// <param name="node">The node.</param>
        public void LoadFromNode(XmlNode node)
        {
            this.InnerLoad(new NodeAttributes(node));
        }

        #endregion
    }
}
