using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether a specific FACILITY or GEOGRAPHIC-FEATURE contains mines.
    /// </summary>
    [DomId(100000313)]
    [DataContract]
    public enum MinePresenceEnum
    {
		
        /// <summary>
        /// There are no mines in the specific FACILITY or GEOGRAPHIC-FEATURE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Mines are present in the specific FACILITY or GEOGRAPHIC-FEATURE.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
        /// <summary>
        /// It is not possible to determine whether mines are present.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
