using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of a specific ACTION-REFERENCE-ASSOCIATION.
    /// </summary>
    [DomId(100004226)]
    [DataContract]
    public enum ActionReferenceAssociationCategoryEnum
    {
		
        /// <summary>
        /// The specific ACTION is terminated in response to the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ISCNCL")]
        [EnumMember]
        IsCancelledBy,
		
        /// <summary>
        /// The specific ACTION is amended as the result of the provisions in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ISCHNG")]
        [EnumMember]
        IsChangedBy,
		
        /// <summary>
        /// The specific ACTION has additional detail provided in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ISAMPL")]
        [EnumMember]
        IsAmplifiedBy,
		
        /// <summary>
        /// The specific ACTION is prescribed in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ISDFND")]
        [EnumMember]
        IsDefinedBy,
		
        /// <summary>
        /// The specific ACTION is depicted in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ISDSCR")]
        [EnumMember]
        IsDescribedBy,
		
        /// <summary>
        /// The specific ACTION is to be executed as ordered in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ISDRCT")]
        [EnumMember]
        IsDirectedBy,
		
        /// <summary>
        /// The specific ACTION is provided supplementary information in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ISPRBK")]
        [EnumMember]
        IsProvidedBackgroundInformationBy,
		
        /// <summary>
        /// The specific ACTION is alluded to in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ISRFRN")]
        [EnumMember]
        IsReferencedBy,
		
        /// <summary>
        /// The specific ACTION is given a formal account in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("ISRPTD")]
        [EnumMember]
        IsReportedBy,
		
    }
}
