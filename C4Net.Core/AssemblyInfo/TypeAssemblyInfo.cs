
namespace C4Net.Core.AssemblyInfo
{
    /// <summary>
    /// Assembly info for types.
    /// </summary>
    public class TypeAssemblyInfo : BaseAssemblyInfo
    {
        #region - Constants -

        /// <summary>
        /// Constant for the starter of a nullable type.
        /// </summary>
        public static readonly string NullableTypeStarter = "System.Nullable";

        #endregion

        #region - Methods -

        /// <summary>
        /// Splits the name.
        /// </summary>
        protected override void SplitName()
        {
            if (this.originalName.StartsWith(NullableTypeStarter))
            {
                int i = this.originalName.IndexOf("]],");
                if (i < 0)
                {
                    this.name = this.originalName;
                    this.assemblyName = null;
                }
                else
                {
                    this.name = this.originalName.Substring(0, i + 2).Trim();
                    this.assemblyName = this.originalName.Substring(i + 3).Trim();
                }
            }
            else
            {
                base.SplitName();
            }
        }

        #endregion
    }
}
