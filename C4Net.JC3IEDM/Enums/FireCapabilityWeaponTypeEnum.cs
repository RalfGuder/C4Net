using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the general type of weapon that an EQUIPMENT-TYPE is qualified to employ.
    /// </summary>
    [DomId(100004373)]
    [DataContract]
    public enum FireCapabilityWeaponTypeEnum
    {
		
        /// <summary>
        /// The capability to deliver weapons which are not nuclear.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CONV")]
        [EnumMember]
        Conventional,
		
        /// <summary>
        /// The capability to deliver nuclear weapons.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NUC")]
        [EnumMember]
        Nuclear,
		
        /// <summary>
        /// The capability of executing both conventional and nuclear missions.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DUAL")]
        [EnumMember]
        DualCapable,
		
        /// <summary>
        /// The inability to deliver any type of weapon.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NCC")]
        [EnumMember]
        NonCombatCapable,
		
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
