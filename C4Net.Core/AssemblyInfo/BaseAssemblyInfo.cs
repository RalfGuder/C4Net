
namespace C4Net.Core.AssemblyInfo
{
    /// <summary>
    /// Class for an assembly info (assembly name and inner name).
    /// </summary>
    public class BaseAssemblyInfo
    {
        #region - Fields -
        
        /// <summary>
        /// Inner name. For example in a file, will be the file name.
        /// </summary>
        protected string name = string.Empty;

        /// <summary>
        /// Name of the assembly.
        /// </summary>
        protected string assemblyName = string.Empty;

        /// <summary>
        /// Original name.
        /// </summary>
        protected string originalName = string.Empty;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets the original name.
        /// </summary>
        /// <value>The original name.</value>
        public string OriginalName
        {
            get
            {
                return this.originalName;
            }
            set
            {
                this.originalName = value;
                this.SplitName();
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Gets the name of the assembly.
        /// </summary>
        /// <value>The name of the assembly.</value>
        public string AssemblyName
        {
            get
            {
                return this.assemblyName;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is assembly ready.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is assembly ready; otherwise, <c>false</c>.
        /// </value>
        public bool IsAssemblyReady
        {
            get
            {
                return ((this.assemblyName != null) && (this.assemblyName.Length > 0));
            }
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Splits the name.
        /// </summary>
        protected virtual void SplitName()
        {
            int posSeparator = this.originalName.IndexOf(",");
            if (posSeparator < 0)
            {
                this.name = this.originalName.Trim();
                this.assemblyName = null;
            }
            else
            {
                this.name = this.originalName.Substring(0, posSeparator).Trim();
                this.assemblyName = this.originalName.Substring(posSeparator + 1).Trim();
            }
        }

        #endregion
    }
}
