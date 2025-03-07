using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the general physical status of a specific PERSON.
    /// </summary>
    [DomId(100000106)]
    [DataContract]
    public enum PersonStatusPhysicalStatusEnum
    {
		
        /// <summary>
        /// A status indicating that a PERSON is considered as having normal physical capabilities.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FT")]
        [EnumMember]
        Fit,
		
        /// <summary>
        /// A status indicating that a PERSON is so seriously incapacitated that the person is not capable of walking and can only be moved by stretcher.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("IN")]
        [EnumMember]
        IncapacitatedNotWalking,
		
        /// <summary>
        /// A status indicating that a PERSON is incapacitated, but is capable of walking.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("IW")]
        [EnumMember]
        IncapacitatedWalking,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A status indicating that a PERSON is incapacitated, but without any major reduction of normal physical capabilities.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SI")]
        [EnumMember]
        SlightlyIncapacitated,
		
    }
}
