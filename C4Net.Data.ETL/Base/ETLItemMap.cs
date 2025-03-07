using System;
using System.Collections.Generic;
using C4Net.Core.IoC;
using C4Net.Data.ETL.Config;
using C4Net.Data.ETL.Interfaces;

namespace C4Net.Data.ETL.Base
{
    /// <summary>
    /// An ETL Map with the item instance.
    /// </summary>
    public class ETLItemMap
    {
        #region - Fields -

        /// <summary>
        /// The configuration for the item.
        /// </summary>
        private ETLItemConfig config = null;

        /// <summary>
        /// The ETL item instance.
        /// </summary>
        private IETLObject item = null;

        /// <summary>
        /// The childs of this item.
        /// </summary>
        private List<ETLItemMap> childs = new List<ETLItemMap>();

        /// <summary>
        /// The path of this item.
        /// </summary>
        private string path;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <value>
        /// The item.
        /// </value>
        public IETLObject Item
        {
            get { return this.item; }
        }

        /// <summary>
        /// Gets the childs.
        /// </summary>
        /// <value>
        /// The childs.
        /// </value>
        public List<ETLItemMap> Childs
        {
            get { return this.childs; }
        }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="ETLItemMap"/> class.
        /// </summary>
        /// <param name="map">The map.</param>
        public ETLItemMap(ETLMap map)
        {
            IETLShell shell = DefaultContainer.Get<IETLShell>();
            if (shell.Configuration.ItemDict.ContainsKey(map.ItemName))
            {
                this.config = shell.Configuration.ItemDict[map.ItemName];
                string typeName = this.config.ItemType;
                if (shell.ItemTypes.ContainsKey(typeName))
                {
                    this.item = (IETLObject)Activator.CreateInstance(shell.ItemTypes[typeName]);
                    this.Item.OnEndProcessItem += DoOnEndProcess;
                }
            }
            foreach (ETLMap childMap in map.Child)
            {
                this.Childs.Add(new ETLItemMap(childMap));
            }
        }

        #endregion

        #region - Methods -

        public void Execute(string path)
        {
            this.path = path;
            if (this.Item != null)
            {
                this.Item.Configure(this.config);
                this.Item.Process(path);
            }
        }

        private void DoOnEndProcess(object item, EventArgs args)
        {
            foreach (ETLItemMap map in this.Childs)
            {
                string sonPath;
                if (this.path == "/")
                {
                    sonPath = this.path + this.Item.ChildTemplateName;
                }
                else
                {
                    sonPath = string.IsNullOrEmpty(this.path) ? this.Item.ChildTemplateName : this.path + "." + this.Item.ChildTemplateName;
                }
                map.Execute(sonPath);
            }
        }

        #endregion
    }
}
