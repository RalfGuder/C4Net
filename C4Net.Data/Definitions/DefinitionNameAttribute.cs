using System;

namespace C4Net.Data.Definitions
{
    /// <summary>
    /// Attribute for the Definition Name of a type.
    /// </summary>
    [Serializable]
    public class DefinitionNameAttribute : Attribute
    {
        #region - Properties -

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        #endregion

        #region - Constructor -

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinitionNameAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="fileName">Name of the file.</param>
        public DefinitionNameAttribute(string name, string fileName)
        {
            this.Name = name;
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinitionNameAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public DefinitionNameAttribute(string name)
            : this(name, string.Empty)
        {
        }

        #endregion
    }
}
