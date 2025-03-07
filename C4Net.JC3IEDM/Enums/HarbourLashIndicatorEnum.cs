using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the HARBOUR can support the Lighter Aboard Ship (LASH) transportation system.
    /// </summary>
    [DomId(100004300)]
    [DataContract]
    public enum HarbourLashIndicatorEnum
    {
		
        /// <summary>
        /// The harbour does not support the Lighter Aboard Ship (LASH) transportation system.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The harbour supports the Lighter Aboard Ship (LASH) transportation system.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
