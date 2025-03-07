using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of a specific OBJECT-TYPE-REFERENCE-ASSOCIATION.
    /// </summary>
    [DomId(100004229)]
    [DataContract]
    public enum ObjectTypeReferenceAssociationCategoryEnum
    {
		
        /// <summary>
        /// The specific OBJECT-TYPE is competent to perform according to provisions in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HASCAP")]
        [EnumMember]
        HasCapabilitiesDefinedIn,
		
        /// <summary>
        /// The training for a specific OBJECT-TYPE is aided by the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("HASTNG")]
        [EnumMember]
        HasTrainingSupportedBy,
		
        /// <summary>
        /// The specific OBJECT-TYPE is depicted in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ISDSCR")]
        [EnumMember]
        IsDescribedBy,
		
        /// <summary>
        /// The maintenance of the specific OBJECT-TYPE is performed according to the provisions in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ISMNTN")]
        [EnumMember]
        IsMaintainedUsing,
		
        /// <summary>
        /// The specific OBJECT-TYPE is acquired according to provisions in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ISPRCR")]
        [EnumMember]
        IsProcuredUsing,
		
        /// <summary>
        /// The specific OBJECT-TYPE is alluded to in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ISRFNC")]
        [EnumMember]
        IsReferencedIn,
		
        /// <summary>
        /// The specific OBJECT-TYPE is specified by the provisions in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ISSPCF")]
        [EnumMember]
        IsSpecifiedBy,
		
    }
}
