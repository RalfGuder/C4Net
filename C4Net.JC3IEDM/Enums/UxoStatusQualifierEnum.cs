using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the qualification status of a specific Unexploded Explosive Ordnance.
    /// </summary>
    [DomId(100004134)]
    [DataContract]
    public enum UxoStatusQualifierEnum
    {
		
        /// <summary>
        /// The specific value that determines that an Unexploded Explosive Ordnance is undamaged.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("INTACT")]
        [EnumMember]
        Intact,
		
        /// <summary>
        /// The specific value that determines that an Unexploded Explosive Ordnance is losing its content.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LEAKNG")]
        [EnumMember]
        Leaking,
		
        /// <summary>
        /// The specific value that determines that an Unexploded Explosive Ordnance is not old.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NEW")]
        [EnumMember]
        New,
		
        /// <summary>
        /// The specific value that determines that an Unexploded Explosive Ordnance is not new.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("OLD")]
        [EnumMember]
        Old,
		
        /// <summary>
        /// The specific value that determines that an Unexploded Explosive Ordnance is corroded.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("RUSTED")]
        [EnumMember]
        Rusted,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The specific value that determines that an Unexploded Explosive Ordnance is broken.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("BROKEN")]
        [EnumMember]
        Broken,
		
    }
}
