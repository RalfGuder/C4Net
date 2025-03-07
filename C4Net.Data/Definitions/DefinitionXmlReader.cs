using System;
using System.IO;
using System.Xml;
using C4Net.Core.Utils;

namespace C4Net.Data.Definitions
{
    /// <summary>
    /// Static class for loading definitions XmlElements from XmlDocuments specified by a Type with Definition Attribute.
    /// </summary>
    public static class DefinitionXmlReader
    {
        #region - Methods -

        /// <summary>
        /// Loads the XML element document from a document, searching nodes at the path testing match with name.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="name">The name.</param>
        /// <param name="nodePath">The node path.</param>
        /// <returns></returns>
        private static XmlElement LoadXmlDocument(XmlDocument document, string name, string nodePath)
        {
            foreach (XmlNode node in document.SelectNodes(nodePath))
            {
                if ((node is XmlElement) && ((node as XmlElement).Attributes["Name"].Value == name))
                {
                    return node as XmlElement;
                }
            }
            return null;
        }

        /// <summary>
        /// Loads the XML document from the assembly data of the type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="name">The name.</param>
        /// <param name="nodePath">The node path.</param>
        /// <returns></returns>
        private static XmlElement LoadXmlDocument(Type type, string fileName, string name, string nodePath)
        {
            XmlElement result = null;
            Stream stream = type.Assembly.GetManifestResourceStream(fileName);
            if (stream == null)
            {
                stream = XmlResources.GetEmbeddedResourceStream(fileName);
            }
            if (stream == null)
            {
                stream = type.Assembly.GetManifestResourceStream(type.FullName);
            }
            if (stream != null)
            {
                XmlDocument document = new XmlDocument();
                document.Load(stream);
                result = LoadXmlDocument(document, name, nodePath);
            }
            return result;
        }

        /// <summary>
        /// Loads the XML document.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static XmlElement LoadXmlDocument(Type type, string nodePath)
        {
            DefinitionNameAttribute attribute = Attribute.GetCustomAttribute(type, typeof(DefinitionNameAttribute)) as DefinitionNameAttribute;
            if (attribute == null)
            {
                attribute = new DefinitionNameAttribute(type.FullName);
            }
            if (attribute != null)
            {
                if (string.IsNullOrEmpty(attribute.FileName))
                {
                    attribute.FileName = attribute.Name + "definition.xml";
                }
                return LoadXmlDocument(type, attribute.FileName, attribute.Name, nodePath);
            }
            return null;
        }

        #endregion
    }
}
