using System;
using System.Collections.Generic;
using C4Net.Core.IoC;
using C4Net.Data.ETL.Base;
using C4Net.Data.ETL.Config;
using C4Net.Data.ETL.Interfaces;

namespace C4Net.Data.ETL
{
    /// <summary>
    /// ETL Engine.
    /// </summary>
    public class ETLEngine
    {
        #region - Fields -

        /// <summary>
        /// The shell.
        /// </summary>
        private IETLShell shell = new ETLShell();

        /// <summary>
        /// The root maps
        /// </summary>
        private List<ETLItemMap> rootMaps = new List<ETLItemMap>();

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="ETLEngine"/> class.
        /// </summary>
        public ETLEngine()
        {
            DefaultContainer.RegisterSingleton<IETLShell>(this.shell);
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Loads the configuration.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="nodePath">The node path.</param>
        public void LoadConfiguration(string fileName, string nodePath = "/configuration")
        {
            this.shell.Configuration.LoadElements(fileName, nodePath);
        }

        /// <summary>
        /// Adds the item class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        public void AddItemClass(string name, Type type)
        {
            if (this.shell.ItemTypes.ContainsKey(name))
            {
                this.shell.ItemTypes[name] = type;
            }
            else
            {
                this.shell.ItemTypes.Add(name, type);
            }
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {
            foreach (ETLMap map in this.shell.Configuration.RootMaps)
            {
                this.rootMaps.Add(new ETLItemMap(map));
            }
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        public void Execute()
        {
            foreach (ETLItemMap map in this.rootMaps)
            {
                map.Execute("/");
            }
        }

        #endregion
    }
}
