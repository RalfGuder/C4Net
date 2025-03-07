using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the security status of a specific FACILITY.
    /// </summary>
    [DomId(100004102)]
    [DataContract]
    public enum FacilityStatusSecurityStatusEnum
    {
		
        /// <summary>
        /// The specific facility is being guarded so as to control entry or exit.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("GUARDD")]
        [EnumMember]
        Guarded,
		
        /// <summary>
        /// No special action has been taken to guarantee the security of the specific facility.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NONE")]
        [EnumMember]
        None,
		
        /// <summary>
        /// The specific facility is protected or safe.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SECURD")]
        [EnumMember]
        Secured,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
