using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether bridge and/or overhead power cables exist.
    /// </summary>
    [DomId(100004302)]
    [DataContract]
    public enum HarbourOverheadLimitsIndicatorEnum
    {
		
        /// <summary>
        /// No overhead limitation at the harbour.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Overhead limitation at the harbour.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
