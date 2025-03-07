using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether a specific ORGANISATION has additional or detached strength.
    /// </summary>
    [DomId(100000263)]
    [DataContract]
    public enum OrganisationStatusReinforcementEnum
    {
		
        /// <summary>
        /// The UNIT in question has sub-UNITs detached.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DETD")]
        [EnumMember]
        DetachedOnly,
		
        /// <summary>
        /// The UNIT in question has no attachments or detachments.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NORM")]
        [EnumMember]
        NormalStrength,
		
        /// <summary>
        /// The UNIT in question has UNITs attached and sub-UNITs detached.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RIDT")]
        [EnumMember]
        ReinforcedAndDetached,
		
        /// <summary>
        /// The UNIT in question has additional UNITs attached.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("REIN")]
        [EnumMember]
        ReinforcedOnly,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
