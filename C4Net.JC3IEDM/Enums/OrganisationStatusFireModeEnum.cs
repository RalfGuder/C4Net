using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the status of weapons employment constraint for a specific ORGANISATION.
    /// </summary>
    [DomId(100000262)]
    [DataContract]
    public enum OrganisationStatusFireModeEnum
    {
		
        /// <summary>
        /// An emergency order to stop firing; missiles in flight must be prevented from intercepting, if technically possible.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HLDFIR")]
        [EnumMember]
        HoldFire,
		
        /// <summary>
        /// A weapon control order imposing a status whereby weapons systems may be fired at any target not positively identified as friendly.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("WPNFRE")]
        [EnumMember]
        WeaponsFree,
		
        /// <summary>
        /// A weapon control order imposing a status whereby weapons systems may be fired only at targets recognised as hostile.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("WPNTGT")]
        [EnumMember]
        WeaponsTight,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A weapon control order imposing a status whereby weapons systems may only be fired in self defence or in response to a formal order.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("WPNHLD")]
        [EnumMember]
        WeaponsHold,
		
    }
}
