using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of OBJECT-ITEM-STATUS.
    /// </summary>
    [DomId(100000146)]
    [DataContract]
    public enum ObjectItemStatusCategoryEnum
    {
		
        /// <summary>
        /// An OBJECT-ITEM-STATUS that is a record of condition of a specific PERSON.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PE")]
        [EnumMember]
        PersonStatus,
		
        /// <summary>
        /// An OBJECT-ITEM-STATUS that is a record of condition of a specific CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CF")]
        [EnumMember]
        ControlFeatureStatus,
		
        /// <summary>
        /// An OBJECT-ITEM-STATUS that is a record of condition of a specific FACILITY.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("FA")]
        [EnumMember]
        FacilityStatus,
		
        /// <summary>
        /// An OBJECT-ITEM-STATUS that is a record of condition of a specific GEOGRAPHIC-FEATURE.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("GF")]
        [EnumMember]
        GeographicFeatureStatus,
		
        /// <summary>
        /// An OBJECT-ITEM-STATUS that is a record of condition of a specific MATERIEL.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MA")]
        [EnumMember]
        MaterielStatus,
		
        /// <summary>
        /// An OBJECT-ITEM-STATUS that is a record of condition of a specific ORGANISATION.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("OR")]
        [EnumMember]
        OrganisationStatus,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
