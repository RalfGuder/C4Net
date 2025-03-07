using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the intended purpose of the MINEFIELD-MARITIME.
    /// </summary>
    [DomId(100004326)]
    [DataContract]
    public enum MinefieldMaritimeSubfunctionEnum
    {
		
        /// <summary>
        /// A maritime minefield that is primarily intended to cause damage to enemy vessels engaging in an attack on a friendly shore line.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ANTINV")]
        [EnumMember]
        AntiInvasion,
		
        /// <summary>
        /// A maritime minefield that is primarily intended to cause damage to enemy vessels in a specific channel.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ANTPSG")]
        [EnumMember]
        AntiPassage,
		
        /// <summary>
        /// A maritime minefield that is primarily intended to cause damage to enemy ships.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ANTSHP")]
        [EnumMember]
        AntiShipping,
		
        /// <summary>
        /// A maritime minefield that is primarily intended to cause damage to enemy vessels over time.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ATTRIT")]
        [EnumMember]
        Attrition,
		
        /// <summary>
        /// A maritime minefield that is primarily intended to prevent the passage of enemy vessels into or out of a specific area with respect to a fixed location on land.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BLCKDE")]
        [EnumMember]
        Blockade,
		
        /// <summary>
        /// A maritime minefield that is primarily intended to impede the movement of enemy vessels.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("DELAY")]
        [EnumMember]
        Delay,
		
        /// <summary>
        /// A maritime minefield that is primarily intended to cause damage to enemy vessels over a period of time in a random manner.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("HARASS")]
        [EnumMember]
        Harassment,
		
        /// <summary>
        /// A maritime minefield that is primarily intended to deny the usage of a harbour/port to an enemy.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("PRTCLS")]
        [EnumMember]
        PortClosure,
		
        /// <summary>
        /// A maritime minefield that is primarily intended to deny the usage of a particular strait to enemy vessels.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("STRCLS")]
        [EnumMember]
        StraitClosure,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
