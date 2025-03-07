using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the general operational role of an aircraft.
    /// </summary>
    [DomId(100004374)]
    [DataContract]
    public enum ActionAircraftEmploymentGeneralRoleEnum
    {
		
        /// <summary>
        /// The aircraft is employed in a defensive role.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DEF")]
        [EnumMember]
        Defensive,
		
        /// <summary>
        /// The aircraft is employed in an offensive role.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OFF")]
        [EnumMember]
        Offensive,
		
        /// <summary>
        /// The aircraft is employed in a support role.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SUPPRT")]
        [EnumMember]
        Support,
		
        /// <summary>
        /// The aircraft is employed in an offensive and defensive role.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SWING")]
        [EnumMember]
        SwingRole,
		
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
