using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the known threat (risk) of a MINEFIELD-MARITIME.
    /// </summary>
    [DomId(100004321)]
    [DataContract]
    public enum MinefieldMaritimeStatusMineZoneRiskEnum
    {
		
        /// <summary>
        /// The threat to a vessel is small.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LITTLE")]
        [EnumMember]
        Little,
		
        /// <summary>
        /// The threat to a vessel is serious.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SERIOS")]
        [EnumMember]
        Serious,
		
        /// <summary>
        /// The threat to a vessel is very large.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("VRYGRT")]
        [EnumMember]
        VeryGreat,
		
    }
}
