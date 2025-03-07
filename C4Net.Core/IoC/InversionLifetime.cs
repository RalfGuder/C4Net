
namespace C4Net.Core.IoC
{
    /// <summary>
    /// Lifetime of the inversion items.
    /// </summary>
    public enum InversionLifetime
    {
        /// <summary>
        /// The inversion item is a singleton.
        /// </summary>
        Singleton,

        /// <summary>
        /// The inversion item creates a new instance per call.
        /// </summary>
        PerCall,

        /// <summary>
        /// The inversion item creates instances per token.
        /// </summary>
        PerToken
    }
}
