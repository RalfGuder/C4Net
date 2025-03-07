using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using C4Net.Schemas.Entities;
using C4Net.Schemas.Reader;

namespace C4Net.Schemas.OleDb
{
    /// <summary>
    /// Class for the schema reader of ole db.
    /// </summary>
    public class OleDbSchemaReader : SchemaReader
    {
        #region - Fields -

        /// <summary>
        /// The oleconnection.
        /// </summary>
        private OleDbConnection oleconnection = null;

        /// <summary>
        /// The tables
        /// </summary>
        private Dictionary<string, SchemaTable> tables = new Dictionary<string, SchemaTable>();

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="OleDbSchemaReader"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public OleDbSchemaReader(string connectionString)
            : base(connectionString)
        {
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Reads the tables.
        /// </summary>
        public override void ReadTables()
        {
            this.tables.Clear();
            DataTable table = this.oleconnection.GetSchema("Tables");
            foreach (DataRow row in table.Rows) 
            {
                if (!row["table_type"].ToString().Equals("VIEW"))
                {
                    string catalogName = row["table_catalog"].ToString();
                    string schemaName = row["table_schema"].ToString();
                    string tableName = row["table_name"].ToString();
                    if (!tableName.StartsWith("MSys"))
                    {
                        this.GetTable(catalogName, schemaName, tableName);
                    }
                }
            }
        }

        /// <summary>
        /// Reads the views.
        /// </summary>
        public override void ReadViews()
        {
            DataTable table = this.oleconnection.GetSchema("Tables");
            foreach (DataRow row in table.Rows)
            {
                if (row["table_type"].ToString().Equals("VIEW"))
                {
                    string catalogName = row["table_catalog"].ToString();
                    string schemaName = row["table_schema"].ToString();
                    string tableName = row["table_name"].ToString();
                    if (!tableName.StartsWith("MSys"))
                    {
                        this.GetView(catalogName, schemaName, tableName);
                    }
                }
            }
        }

        public string CalculateNetType(SchemaColumn column)
        {
            switch (column.DataType)
            {
                case "SmallInt": 
                case "TinyInt": return "int";
                case "BigInt": return "long";
                case "Single":
                case "Double":
                case "currency": return "double";
                case "DateTime":
                case "Date": return "DateTime";
                case "Boolean": return "Boolean";
                case "Char":
                case "NChar":
                case "VarChar":
                case "Text":
                case "NVarChar":
                case "NText": return "string";
                case "Decimal":
                    if (column.NumDecimals == 0)
                    {
                        return "long";
                    }
                    else
                    {
                        return "double";
                    }
                default: return "string";
            }
        }

        /// <summary>
        /// Converts the type of the data.
        /// </summary>
        /// <param name="dataType">Type of the data.</param>
        /// <returns></returns>
        public string ConvertDataType(string dataType)
        {
            switch (int.Parse(dataType))
            {
                case 2: return "SmallInt"; // adSmallInt
                case 3: return "Identity"; // adInteger + Autonumeric
                case 4: return "Single";   // adSingle
                case 5: return "Double";   // adDouble
                case 6: return "Currency"; // adCurrency
                case 7: return "Date";     // adDate
                case 9: return "IDispatch"; // adIDispatch
                case 11: return "Boolean"; // adBoolean
                case 12: return "Variant"; // adVariant
                case 14: return "Decimal"; // adDecimal
                case 17: return "TinyInt"; // adTinyInt
                case 20: return "BigInt";  // adBigInt
                case 72: return "GUID"; // adGUID
                case 128: return "Binary"; // adBinary
                case 129: return "Char";   // adChar
                case 130: return "NChar"; // adWChar
                case 131: return "Decimal"; // adNumeric
                case 135: return "DateTime"; // adDateTime
                case 200: return "VarChar"; // adVarChar
                case 201: return "Text"; // adLongVarChar
                case 202: return "NVarChar"; // adVarWChar
                case 203: return "NText"; // adLongVarWChar
                case 204: return "VarBinary"; // adVarBinary
                case 205: return "Image"; // adLongVarBinary
                default: return dataType;
            }
        }

        /// <summary>
        /// Reads the columns.
        /// </summary>
        public override void ReadColumns()
        {
            DataTable table = this.oleconnection.GetSchema("Columns");
            foreach (DataRow row in table.Rows)
            {
                string tableName = row["table_name"].ToString();
                if (!tableName.StartsWith("MSys"))
                {
                    string catalogName = row["table_catalog"].ToString();
                    string schemaName = row["table_schema"].ToString();
                    string columnName = row["column_name"].ToString();
                    Int64 ordinalPosition = (Int64)row["ordinal_position"];
                    bool isNullable = (bool)row["is_nullable"];
                    string dataTypeStr = row["data_type"].ToString();
                    Int64? characterMaxLength = null;
                    if (row["character_maximum_length"] != DBNull.Value)
                    {
                        characterMaxLength = (Int64)row["character_maximum_length"];
                    }
                    Int64? characterOctetLength = null;
                    if (row["character_octet_length"] != DBNull.Value)
                    {
                        characterOctetLength = (Int64)row["character_octet_length"];
                    }
                    Int32? numericPrecision = null;
                    if (row["numeric_precision"] != DBNull.Value)
                    {
                        numericPrecision = (Int32)row["numeric_precision"];
                    }
                    Int64? numericScale = null;
                    if (row["numeric_scale"] != DBNull.Value)
                    {
                        numericScale = (Int64)row["numeric_scale"];
                    }
                    Int64? datetimePrecision = null;
                    if (row["datetime_precision"] != DBNull.Value)
                    {
                        datetimePrecision = (Int64)row["datetime_precision"];
                    }
                    SchemaColumn column = this.GetColumn(catalogName, schemaName, tableName, columnName);
                    column.Order = (int)ordinalPosition;
                    column.DataType = this.ConvertDataType(dataTypeStr);
                    column.DataLength = characterMaxLength.HasValue ? (int)characterMaxLength.Value : 0;
                    if (column.DataLength == 0)
                    {
                        column.DataLength = numericPrecision.HasValue ? (int)numericPrecision.Value : 0;
                    }
                    column.IsNullable = isNullable;
                    column.NumDecimals = numericScale.HasValue ? (int)numericScale.Value : 0;
                    column.NetType = this.CalculateNetType(column);
                }
            }
        }

        /// <summary>
        /// Reads the indexes.
        /// </summary>
        public override void ReadIndexes()
        {
            DataTable table = this.oleconnection.GetSchema("Indexes");
            foreach (DataRow row in table.Rows)
            {
                string tableName = row["table_name"].ToString();
                if (tableName.StartsWith("MSys"))
                {
                    continue;
                }
                bool primaryKey = (bool)row["primary_key"];
                if (primaryKey)
                {
                    string catalogName = row["table_catalog"].ToString();
                    string schemaName = row["table_schema"].ToString();
                    string columnName = row["column_name"].ToString();
                    this.GetColumn(catalogName, schemaName, tableName, columnName).IsPrimaryKey = true;
                }
            }
        }

        /// <summary>
        /// Creates the connection.
        /// </summary>
        public override void CreateConnection()
        {
            this.oleconnection = new OleDbConnection(this.ConnectionString);
            this.Connection = oleconnection;
        }

        #endregion
    }
}
