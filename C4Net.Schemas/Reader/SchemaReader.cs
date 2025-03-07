using System.Collections.Generic;
using System.Data;
using System.Linq;
using C4Net.Schemas.Entities;
using C4Net.Templates;

namespace C4Net.Schemas.Reader
{
    /// <summary>
    /// Abstract class for one schema reader.
    /// </summary>
    public abstract class SchemaReader : ISchemaReader
    {
        #region - Properties -

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public string ConnectionString { get; private set; }

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public IDbConnection Connection { get; set; }

        /// <summary>
        /// Gets or sets the catalogs.
        /// </summary>
        /// <value>
        /// The catalogs.
        /// </value>
        public Dictionary<string, SchemaCatalog> Catalogs { get; set; }

        #endregion

        #region - Constructors -

        public SchemaReader(string connectionString)
        {
            this.Catalogs = new Dictionary<string, SchemaCatalog>();
            this.ConnectionString = connectionString;
            this.CreateConnection();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Creates the connection.
        /// </summary>
        public abstract void CreateConnection();

        /// <summary>
        /// Reads the tables.
        /// </summary>
        public abstract void ReadTables();

        /// <summary>
        /// Reads the views.
        /// </summary>
        public abstract void ReadViews();

        /// <summary>
        /// Reads the columns.
        /// </summary>
        public abstract void ReadColumns();

        /// <summary>
        /// Reads the indexes.
        /// </summary>
        public abstract void ReadIndexes();

        /// <summary>
        /// Opens the reader.
        /// </summary>
        /// <returns></returns>
        public bool Open()
        {
            try
            {
                this.Connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Closes the reader.
        /// </summary>
        public void Close()
        {
            this.Connection.Close();
        }

        /// <summary>
        /// Gets the catalog.
        /// </summary>
        /// <param name="catalogName">Name of the catalog.</param>
        /// <returns></returns>
        public SchemaCatalog GetCatalog(string catalogName)
        {
            if (this.Catalogs.ContainsKey(catalogName))
            {
                return this.Catalogs[catalogName];
            }
            SchemaCatalog result = new SchemaCatalog(catalogName);
            this.Catalogs.Add(result.PhysicalName, result);
            return result;
        }

        /// <summary>
        /// Gets the schema.
        /// </summary>
        /// <param name="catalogName">Name of the catalog.</param>
        /// <param name="schemaName">Name of the schema.</param>
        /// <returns></returns>
        public SchemaSchema GetSchema(string catalogName, string schemaName)
        {
            SchemaCatalog catalog = this.GetCatalog(catalogName);
            if (catalog.Schemas.ContainsKey(schemaName))
            {
                return catalog.Schemas[schemaName];
            }
            SchemaSchema result = new SchemaSchema(catalog, schemaName);
            catalog.Schemas.Add(result.PhysicalName, result);
            return result;
        }

        /// <summary>
        /// Gets the table.
        /// </summary>
        /// <param name="catalogName">Name of the catalog.</param>
        /// <param name="schemaName">Name of the schema.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <returns></returns>
        public SchemaTable GetTable(string catalogName, string schemaName, string tableName)
        {
            SchemaSchema schema = this.GetSchema(catalogName, schemaName);
            if (schema.Tables.ContainsKey(tableName))
            {
                return schema.Tables[tableName];
            }
            SchemaTable result = new SchemaTable(schema, tableName);
            schema.Tables.Add(result.PhysicalName, result);
            return result;
        }

        /// <summary>
        /// Gets the view.
        /// </summary>
        /// <param name="catalogName">Name of the catalog.</param>
        /// <param name="schemaName">Name of the schema.</param>
        /// <param name="viewName">Name of the view.</param>
        /// <returns></returns>
        public SchemaView GetView(string catalogName, string schemaName, string viewName)
        {
            SchemaSchema schema = this.GetSchema(catalogName, schemaName);
            if (schema.Views.ContainsKey(viewName))
            {
                return schema.Views[viewName];
            }
            SchemaView result = new SchemaView(schema, viewName);
            schema.Views.Add(result.PhysicalName, result);
            return result;
        }

        /// <summary>
        /// Gets the column.
        /// </summary>
        /// <param name="catalogName">Name of the catalog.</param>
        /// <param name="schemaName">Name of the schema.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns></returns>
        public SchemaColumn GetColumn(string catalogName, string schemaName, string tableName, string columnName)
        {
            SchemaSchema schema = this.GetSchema(catalogName, schemaName);
            SchemaTabular tabular;
            if (schema.Tables.ContainsKey(tableName))
            {
                tabular = schema.Tables[tableName];
            }
            else if (schema.Views.ContainsKey(tableName))
            {
                tabular = schema.Views[tableName];
            }
            else
            {
                return null;
            }
            SchemaColumn column = tabular.GetColumn(columnName);
            if (column == null)
            {
                return tabular.AddColumn(columnName);
            }
            return column;
        }


        /// <summary>
        /// Sorts the content.
        /// </summary>
        public virtual void Sort()
        {
            foreach (SchemaCatalog catalog in this.Catalogs.Values)
            {
                foreach (SchemaSchema schema in catalog.Schemas.Values)
                {
                    foreach (SchemaTable table in schema.Tables.Values)
                    {
                        table.Columns = table.Columns.OrderBy(x => x.Order).ToList();
                    }
                    foreach (SchemaView view in schema.Views.Values)
                    {
                        view.Columns = view.Columns.OrderBy(x => x.Order).ToList();
                    }
                }
            }
        }

        /// <summary>
        /// Reads the schemas.
        /// </summary>
        public void Read()
        {
            this.ReadTables();
            this.ReadViews();
            this.ReadColumns();
            this.ReadIndexes();
            this.Sort();
        }

        /// <summary>
        /// Gets the container.
        /// </summary>
        /// <param name="catalogName">Name of the catalog.</param>
        /// <param name="schemaName">Name of the schema.</param>
        /// <returns></returns>
        public TemplateContainer GetContainer(string catalogName, string schemaName)
        {
            SchemaSchema schema = this.GetSchema(catalogName, schemaName);
            TemplateContainer container = new TemplateContainer(null);
            schema.WriteTo(container);
            return container;

        }

        #endregion
    }
}
