using System;
using System.Collections.Generic;
using System.Xml;
using C4Net.Core.Types;
using C4Net.Core.Utils;

namespace C4Net.Data.Definitions
{
    /// <summary>
    /// Manager for definitions.
    /// </summary>
    public static class DefinitionManager
    {
        #region - Fields -

        /// <summary>
        /// The table definitions dictionary.
        /// </summary>
        private static Dictionary<Type, TableDefinition> tableDefinitions = new Dictionary<Type, TableDefinition>();

        #endregion

        #region - Methods -

        /// <summary>
        /// Gets the definition.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static TableDefinition GetDefinition(Type type)
        {
            if (tableDefinitions.ContainsKey(type))
            {
                return tableDefinitions[type];
            }
            TableDefinition result = new TableDefinition(type);
            tableDefinitions.Add(type, result);
            return result;
        }

        /// <summary>
        /// Adds the table definition.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="definition">The definition.</param>
        public static void AddTableDefinition(Type type, TableDefinition definition)
        {
            if (tableDefinitions.ContainsKey(type))
            {
                tableDefinitions[type] = definition;
            }
            else
            {
                definition.DefinitionType = type;
                tableDefinitions.Add(type, definition);
            }
        }

        /// <summary>
        /// Removes the table definition.
        /// </summary>
        /// <param name="type">The type.</param>
        public static void RemoveTableDefinition(Type type)
        {
            if (tableDefinitions.ContainsKey(type))
            {
                tableDefinitions.Remove(type);
            }
        }

        /// <summary>
        /// Loads several definitions from a xml file, resolving the type by the name of the definition.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="definitionsPath">The definitions path.</param>
        /// <param name="xmlAssembly">The assembly name of the xml file.</param>
        /// <param name="typesAssembly">The assembly name of the types to resolve.</param>
        public static void LoadFromXml(string fileName, string definitionsPath, string xmlAssembly, string typesAssembly)
        {
            if (!string.IsNullOrEmpty(xmlAssembly))
            {
                fileName = xmlAssembly + "." + fileName;
            }
            XmlDocument document = XmlResources.GetFromEmbeddedResource(fileName);
            if (document != null)
            {
                foreach (XmlNode node in document.SelectNodes(definitionsPath))
                {
                    TableDefinition definition = new TableDefinition();
                    definition.LoadFromNode(node);
                    string typeName;
                    if (!string.IsNullOrEmpty(typesAssembly))
                    {
                        typeName = typesAssembly + "." + definition.Name;
                    }
                    else
                    {
                        typeName = definition.Name;
                    }
                    Type type = TypesManager.ResolveType(typeName);
                    if (type != null)
                    {
                        AddTableDefinition(type, definition);
                    }
                }
            }
        }

        #endregion
    }
}
