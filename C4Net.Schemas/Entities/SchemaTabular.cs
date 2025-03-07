using System.Collections.Generic;
using System.Linq;
using C4Net.Templates;

namespace C4Net.Schemas.Entities
{
    /// <summary>
    /// Class for the schema of tabular objects of the database, as objects that contains columns (tables, views).
    /// </summary>
    public class SchemaTabular : SchemaBase
    {
        #region - Properties -

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public List<SchemaColumn> Columns { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaTabular"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        /// <param name="logicalName">Name of the logical.</param>
        public SchemaTabular(SchemaBase parent, string physicalName, string logicalName)
            : base(parent, physicalName, logicalName)
        {
            this.Columns = new List<SchemaColumn>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaTabular"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="physicalName">Name of the physical.</param>
        public SchemaTabular(SchemaBase parent, string physicalName)
            : base(parent, physicalName) 
        {
            this.Columns = new List<SchemaColumn>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaTabular"/> class.
        /// </summary>
        public SchemaTabular()
            : base()
        {
            this.Columns = new List<SchemaColumn>();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Adds one column.
        /// </summary>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        public SchemaColumn AddColumn(string columnName)
        {
            SchemaColumn result = new SchemaColumn(this, columnName);
            this.Columns.Add(result);
            return result;
        }

        /// <summary>
        /// Gets one column.
        /// </summary>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        public SchemaColumn GetColumn(string columnName)
        {
            foreach (SchemaColumn column in this.Columns)
            {
                if (column.PhysicalName.Equals(columnName))
                {
                    return column;
                }
            }
            return null;
        }

        /// <summary>
        /// Sorts the content of the instance.
        /// </summary>
        public override void Sort()
        {
            this.Columns = this.Columns.OrderBy(x => x.Order).ToList();
        }

        /// <summary>
        /// Writes this instance content to a container.
        /// </summary>
        /// <param name="container">The container.</param>
        public override void WriteTo(TemplateContainer container)
        {
            container.Attributes.Add("LogicalName", this.LogicalName);
            container.Attributes.Add("PhysicalName", this.PhysicalName);
            TemplateContainer sonContainer = container.AddSon("Columns");
            foreach (SchemaColumn column in this.Columns)
            {
                column.WriteTo(sonContainer.AddArrayValue());
            }
        }

        #endregion
    }
}
