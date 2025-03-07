using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the intended function of a specific MINEFIELD-MARITIME.
    /// </summary>
    [DomId(100004198)]
    [DataContract]
    public enum MinefieldMaritimeFunctionEnum
    {
		
        /// <summary>
        /// A minefield employed to protect an ORGANISATION, FACILITY, or FEATURE that is laid in international waters.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DEFSV")]
        [EnumMember]
        Defensive,
		
        /// <summary>
        /// A minefield employed as an obstacle laid in enemy waters.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OFFSV")]
        [EnumMember]
        Offensive,
		
        /// <summary>
        /// A minefield employed to protect an ORGANISATION, FACILITY, or FEATURE.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PROTCT")]
        [EnumMember]
        Protective,
		
    }
}
