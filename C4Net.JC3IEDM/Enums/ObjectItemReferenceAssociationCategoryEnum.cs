using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of a specific OBJECT-ITEM-REFERENCE-ASSOCIATION.
    /// </summary>
    [DomId(100004228)]
    [DataContract]
    public enum ObjectItemReferenceAssociationCategoryEnum
    {
		
        /// <summary>
        /// The specific OBJECT-ITEM is provided guidance in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HASINS")]
        [EnumMember]
        HasInstructionsProvidedIn,
		
        /// <summary>
        /// The operational status of the specific OBJECT-ITEM is made active by provisions in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ISACTV")]
        [EnumMember]
        IsActivatedBy,
		
        /// <summary>
        /// The specific OBJECT-ITEM is sanctioned by the provisions in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ISAUTH")]
        [EnumMember]
        IsAuthorisedBy,
		
        /// <summary>
        /// The operational status of the specific OBJECT-ITEM is made inactive by provisions in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ISDEAC")]
        [EnumMember]
        IsDeactivatedBy,
		
        /// <summary>
        /// The specific OBJECT-ITEM is depicted in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ISDSCR")]
        [EnumMember]
        IsDescribedIn,
		
        /// <summary>
        /// The specific OBJECT-ITEM is pictorially described in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ISGRPH")]
        [EnumMember]
        IsGraphicallyDepictedBy,
		
        /// <summary>
        /// The specific OBJECT-ITEM is alluded to in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ISRFNC")]
        [EnumMember]
        IsReferencedBy,
		
        /// <summary>
        /// The specific OBJECT-ITEM is given a formal account in the artefact cited in the specific REFERENCE.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ISRPTD")]
        [EnumMember]
        IsReportedIn,
		
    }
}
