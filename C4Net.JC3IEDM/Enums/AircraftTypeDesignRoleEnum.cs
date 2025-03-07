using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the designed role of an AIRCRAFT-TYPE.
    /// </summary>
    [DomId(100004369)]
    [DataContract]
    public enum AircraftTypeDesignRoleEnum
    {
		
        /// <summary>
        /// The major role of this aircraft is defensive.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DEF")]
        [EnumMember]
        Defensive,
		
        /// <summary>
        /// An aircraft capable of carrying out more than one role.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MULTI")]
        [EnumMember]
        MultiRole,
		
        /// <summary>
        /// The major role of this aircraft is offensive.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("OFF")]
        [EnumMember]
        Offensive,
		
        /// <summary>
        /// The major role of this aircraft is support.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SUPPRT")]
        [EnumMember]
        Support,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
