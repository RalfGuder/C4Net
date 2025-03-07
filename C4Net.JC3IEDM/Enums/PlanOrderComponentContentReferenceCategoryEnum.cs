using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the reason a specific REFERENCE is associated to a specific PLAN-ORDER-COMPONENT-CONTENT.
    /// </summary>
    [DomId(100004388)]
    [DataContract]
    public enum PlanOrderComponentContentReferenceCategoryEnum
    {
		
        /// <summary>
        /// The specific artefact is subject to guidance provided in the artefact cited by the specific REFERENCE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HASINS")]
        [EnumMember]
        HasInstructionsProvidedIn,
		
        /// <summary>
        /// The specific artefact is subject to additional detail provided in the artefact cited by the specific REFERENCE.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ISAMPL")]
        [EnumMember]
        IsAmplifiedBy,
		
        /// <summary>
        /// The relationship of the specific PLAN-ORDER-CONTENT with the specific REFERENCE is deleted.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ISDISS")]
        [EnumMember]
        IsDissociatedFrom,
		
        /// <summary>
        /// The specific artefact is subject to relevant background information in the artefact cited by the specific REFERENCE.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ISPROV")]
        [EnumMember]
        IsProvidedSupplementaryInformationBy,
		
        /// <summary>
        /// The specific artefact is physically stored in the artefact cited by the specific REFERENCE.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ISRCRD")]
        [EnumMember]
        IsRecordedIn,
		
        /// <summary>
        /// The specific artefact references geographic mapping products in the artefact cited by the specific REFERENCE.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ISSPCM")]
        [EnumMember]
        IsSupportedByChartsAndMapsIn,
		
        /// <summary>
        /// The specific artefact references relevant pictorial material in the artefact cited by the specific REFERENCE.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ISSPPM")]
        [EnumMember]
        IsSupportedByPictorialMaterialIn,
		
    }
}
