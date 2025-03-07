using System.Collections.Generic;
using System.Xml;
using C4Net.Core.Utils;

namespace C4Net.Data.ETL.Config
{
    /// <summary>
    /// Class for the configuration of one ETL Object, stored as XML.
    /// Each ETL Object has an unique name, a type, a dictionary of parameters (that will be used for configuration) 
    /// and a dictionary of mappings (that will rename the input fields to output fields).
    /// </summary>
    public class ETLItemConfig : BaseXmlManagerItem
    {
        #region - Fields -

        /// <summary>
        /// The parameter dictionary.
        /// </summary>
        private Dictionary<string, string> parameters = new Dictionary<string, string>();

        /// <summary>
        /// The mapping dictionary.
        /// </summary>
        private Dictionary<string, string> mappings = new Dictionary<string, string>();

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets the name of the ETL Object.
        /// </summary>
        /// <value>
        /// The name of the ETL Object.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of ETL Object.
        /// </summary>
        /// <value>
        /// The type of ETL Object.
        /// </value>
        public string ItemType { get; private set; }

        /// <summary>
        /// Gets the name of the child template.
        /// </summary>
        /// <value>
        /// The name of the child template.
        /// </value>
        public string ChildTemplateName { get; private set; }

        /// <summary>
        /// Gets the parameters dictionary.
        /// </summary>
        /// <value>
        /// The parameters.
        /// </value>
        public Dictionary<string, string> Parameters
        {
            get { return this.parameters; }
        }

        /// <summary>
        /// Gets the mappings dictionary.
        /// </summary>
        /// <value>
        /// The mappings.
        /// </value>
        public Dictionary<string, string> Mappings
        {
            get { return this.mappings; }
        }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="ETLItemConfig"/> class.
        /// </summary>
        /// <param name="node">The node.</param>
        public ETLItemConfig(XmlNode node)
            : base(node)
        {
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Adds a new mapping.
        /// </summary>
        /// <param name="sourceName">Name of the source.</param>
        /// <param name="targetName">Name of the target.</param>
        public void AddMapping(string sourceName, string targetName)
        {
            if (this.mappings.ContainsKey(sourceName))
            {
                this.mappings[sourceName] = targetName;
            }
            else
            {
                this.mappings.Add(sourceName, targetName);
            }
        }

        /// <summary>
        /// Removes a mapping.
        /// </summary>
        /// <param name="sourceName">Name of the source.</param>
        public void RemoveMapping(string sourceName)
        {
            this.mappings.Remove(sourceName);
        }

        /// <summary>
        /// Adds a new parameter.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="parameterValue">The parameter value.</param>
        public void AddParameter(string parameterName, string parameterValue)
        {
            if (this.parameters.ContainsKey(parameterName))
            {
                this.parameters[parameterName] = parameterValue;
            }
            else
            {
                this.parameters.Add(parameterName, parameterValue);
            }
        }

        /// <summary>
        /// Removes a parameter.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        public void RemoveParameter(string parameterName)
        {
            this.parameters.Remove(parameterName);
        }

        /// <summary>
        /// Load the config content from xml.
        /// </summary>
        /// <param name="attributes"></param>
        protected override void InnerLoad(NodeAttributes attributes)
        {
            this.Name = attributes.AsString("name");
            this.ItemType = attributes.AsString("type");
            this.ChildTemplateName = attributes.AsString("templateName");
            foreach (XmlNode node in attributes.Node.SelectNodes("Parameters/Parameter"))
            {
                NodeAttributes nodeParameters = new NodeAttributes(node);
                if (string.IsNullOrEmpty(nodeParameters.AsString("value")))
                {
                    this.AddParameter(nodeParameters.AsString("name"), nodeParameters.Node.InnerText);
                }
                else
                {
                    this.AddParameter(nodeParameters.AsString("name"), nodeParameters.AsString("value"));
                }
            }
            foreach (XmlNode node in attributes.Node.SelectNodes("Mappings/Mapping"))
            {
                NodeAttributes nodeMappings = new NodeAttributes(node);
                this.AddMapping(nodeMappings.AsString("source"), nodeMappings.AsString("target"));
            }
        }

        #endregion
    }
}
