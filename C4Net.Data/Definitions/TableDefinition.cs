using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using C4Net.Core.Utils;

namespace C4Net.Data.Definitions
{
    /// <summary>
    /// Definition of a table, can be loaded from attributes of a type or from a xml node.
    /// </summary>
    public class TableDefinition : Attribute, IXmlManagerItem
    {
        #region - Fields -

        /// <summary>
        /// The primary keys.
        /// </summary>
        private readonly List<string> primaryKeys = new List<string>();

        /// <summary>
        /// The columns.
        /// </summary>
        private readonly Dictionary<string, ColumnDefinition> columns = new Dictionary<string, ColumnDefinition>();

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets or sets the logical name of the table.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the physical name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets the primary keys.
        /// </summary>
        /// <value>
        /// The primary keys.
        /// </value>
        public List<string> PrimaryKeys
        {
            get { return this.primaryKeys; }
        }

        /// <summary>
        /// Gets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public Dictionary<string, ColumnDefinition> Columns
        {
            get { return this.columns; }
        }

        public Type DefinitionType { get; set; }

        public ColumnDefinition FirstAutoincrementColumn { get; set; }

        #endregion

        #region - Constructor -

        /// <summary>
        /// Initializes a new instance of the <see cref="TableDefinition"/> class.
        /// </summary>
        public TableDefinition()
        {
            this.Name = "";
            this.TableName = "";
            this.FirstAutoincrementColumn = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableDefinition"/> class.
        /// </summary>
        /// <param name="node">The node.</param>
        public TableDefinition(XmlNode node)
            : this()
        {
            this.LoadFromNode(node);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableDefinition"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="tableName">Name of the table.</param>
        public TableDefinition(string name, string tableName)
            : this()
        {
            this.Name = name;
            this.TableName = tableName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableDefinition"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public TableDefinition(Type type)
        {
            this.DefinitionType = type;
            this.LoadFromType();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Load the data of the node from xml attributes.
        /// </summary>
        protected void InnerLoad(NodeAttributes attributes)
        {
            this.Name = attributes.AsString("Name");
            this.TableName = attributes.AsString("TableName");
        }

        /// <summary>
        /// Loads from xml node.
        /// </summary>
        /// <param name="node">The node.</param>
        public void LoadFromNode(XmlNode node)
        {
            this.InnerLoad(new NodeAttributes(node));
            foreach (XmlNode child in node.SelectNodes("Column"))
            {
                ColumnDefinition column = new ColumnDefinition(child);
                this.columns.Add(column.Name, column);
                if (column.IsAutoIncrement && this.FirstAutoincrementColumn == null)
                {
                    this.FirstAutoincrementColumn = column;
                }
                if (column.IsPrimaryKey)
                {
                    this.primaryKeys.Add(column.Name);
                }
            }
        }

        /// <summary>
        /// Loads the table definition from a type, first trying to resolve the xml, if not found then by attributes.
        /// </summary>
        /// <param name="type">The type.</param>
        private void LoadFromType()
        {
            XmlElement element = DefinitionXmlReader.LoadXmlDocument(this.DefinitionType, "Definition/Table");
            if (element != null)
            {
                this.LoadFromNode(element);
            }
            else
            {
                TableDefinition attribute = Attribute.GetCustomAttribute(this.DefinitionType, typeof(TableDefinition)) as TableDefinition;
                if (attribute != null)
                {
                    this.Name = attribute.Name;
                    this.TableName = attribute.TableName;
                }
                PropertyInfo[] properties = this.DefinitionType.GetProperties();
                if (properties != null)
                {
                    foreach (PropertyInfo property in properties)
                    {
                        ColumnDefinition column = property.GetCustomAttribute(typeof(ColumnDefinition)) as ColumnDefinition;
                        if (column != null)
                        {
                            this.columns.Add(column.Name, column);
                            if (column.IsAutoIncrement && this.FirstAutoincrementColumn == null)
                            {
                                this.FirstAutoincrementColumn = column;
                            }
                            if (column.IsPrimaryKey)
                            {
                                this.primaryKeys.Add(column.Name);
                            }
                        }
                    }
                }
            }
        }

        #endregion

    }
}
