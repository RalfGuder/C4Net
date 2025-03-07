using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the lifecycle of the artefact cited in a specific REFERENCE.
    /// </summary>
    [DomId(100004233)]
    [DataContract]
    public enum ReferenceLifecycleEnum
    {
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE has been produced in a preliminary version.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DRAFT")]
        [EnumMember]
        Draft,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE has been produced in a completed version.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FINAL")]
        [EnumMember]
        Final,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is no longer valid.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("OBSLTE")]
        [EnumMember]
        Obsolete,
		
    }
}
