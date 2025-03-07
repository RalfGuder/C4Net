using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the visual status of a specific Unexploded Explosive Ordnance.
    /// </summary>
    [DomId(100004133)]
    [DataContract]
    public enum UxoStatusExposureEnum
    {
		
        /// <summary>
        /// A status indicating that a specific Unexploded Explosive Ordnance is fully exposed.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FULEXP")]
        [EnumMember]
        FullyExposed,
		
        /// <summary>
        /// A status indicating that a specific Unexploded Explosive Ordnance is partially exposed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PRTEX")]
        [EnumMember]
        PartiallyExposed,
		
        /// <summary>
        /// A status indicating that the body of a specific Unexploded Explosive Ordnance is partially exposed.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PRTEXB")]
        [EnumMember]
        PartiallyExposedBody,
		
        /// <summary>
        /// A status indicating that the nose of a specific Unexploded Explosive Ordnance is partially exposed.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PRTEXN")]
        [EnumMember]
        PartiallyExposedNose,
		
        /// <summary>
        /// A status indicating that the side of a specific Unexploded Explosive Ordnance is partially exposed.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PRTEXS")]
        [EnumMember]
        PartiallyExposedSide,
		
        /// <summary>
        /// A status indicating that the tail of a specific Unexploded Explosive Ordnance is partially exposed.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PRTEXT")]
        [EnumMember]
        PartiallyExposedTail,
		
        /// <summary>
        /// A status indicating that a specific Unexploded Explosive Ordnance is not exposed.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("UNEXPD")]
        [EnumMember]
        Unexposed,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
