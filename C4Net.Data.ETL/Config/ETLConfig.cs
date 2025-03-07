using System.Collections.Generic;
using System.Linq;
using System.Xml;
using C4Net.Core.Utils;

namespace C4Net.Data.ETL.Config
{
    /// <summary>
    /// Class for the configuration of the ETL Objects.
    /// </summary>
    public class ETLConfig : BaseXmlManager
    {
        #region - Fields -

        /// <summary>
        /// The ETL items dictionary.
        /// </summary>
        private Dictionary<string, ETLItemConfig> items = new Dictionary<string, ETLItemConfig>();

        private List<ETLMap> rootMaps = new List<ETLMap>();

        #endregion

        #region - Properties -

        public Dictionary<string, ETLItemConfig> ItemDict
        {
            get { return this.items; }
        }

        /// <summary>
        /// Gets the item list.
        /// </summary>
        /// <value>
        /// The item list.
        /// </value>
        public List<ETLItemConfig> ItemList
        {
            get { return this.items.Values.ToList(); }
        }

        public List<ETLMap> RootMaps
        {
            get { return this.rootMaps; }
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Adds a configuration item.
        /// </summary>
        /// <param name="item">The configuration item.</param>
        public void AddItem(ETLItemConfig item)
        {
            if (this.items.ContainsKey(item.Name))
            {
                this.items[item.Name] = item;
            }
            else
            {
                this.items.Add(item.Name, item);
            }
        }

        /// <summary>
        /// Removes one configuration item.
        /// </summary>
        /// <param name="name">The name.</param>
        public void RemoveItem(string name)
        {
            this.items.Remove(name);
        }

        /// <summary>
        /// Process the xml node.
        /// </summary>
        /// <param name="node">The node.</param>
        public override void ProcessNode(XmlNode rootNode)
        {
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                if (node.Name == "items")
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        this.AddItem(new ETLItemConfig(childNode));
                    }
                }
                else if (node.Name == "maps")
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        this.rootMaps.Add(new ETLMap(childNode));
                    }
                }
            }
        }

        #endregion
    }
}
