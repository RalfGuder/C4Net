using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of a specific CAPABILITY-REFERENCE-ASSOCIATION.
    /// </summary>
    [DomId(100004227)]
    [DataContract]
    public enum CapabilityReferenceAssociationCategoryEnum
    {
		
        /// <summary>
        /// The specific CAPABILITY has additional detail provided in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ISAMPL")]
        [EnumMember]
        IsAmplifiedBy,
		
        /// <summary>
        /// The specific CAPABILITY is prescribed in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ISDFND")]
        [EnumMember]
        IsDefinedIn,
		
        /// <summary>
        /// The specific CAPABILITY is explained in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ISDSCR")]
        [EnumMember]
        IsDescribedBy,
		
    }
}
