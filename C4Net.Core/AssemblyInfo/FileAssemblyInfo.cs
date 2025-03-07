
namespace C4Net.Core.AssemblyInfo
{
    /// <summary>
    /// Assembly info for files.
    /// </summary>
    public class FileAssemblyInfo : BaseAssemblyInfo
    {
        #region - Properties -

        /// <summary>
        /// Gets the name of the resource file.
        /// </summary>
        /// <value>The name of the resource file.</value>
        public string ResourceFileName
        {
            get
            {
                return string.IsNullOrEmpty(this.assemblyName) ? this.Name : this.AssemblyName + "." + this.Name;
            }
        }

        #endregion
    }
}
