using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of AFFILIATION.
    /// </summary>
    [DomId(100004160)]
    [DataContract]
    public enum AffiliationCategoryEnum
    {
		
        /// <summary>
        /// A specification of a country or political entity to which membership or allegiance may be ascribed.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AFLGEO")]
        [EnumMember]
        AffiliationGeopolitical,
		
        /// <summary>
        /// A specification of an ethnic group to which membership or allegiance may be ascribed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AFLETH")]
        [EnumMember]
        AffiliationEthnicGroup,
		
        /// <summary>
        /// A specification of a functional group characterised by its primary purpose to which membership or allegiance may be ascribed.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("AFLFNC")]
        [EnumMember]
        AffiliationFunctionalGroup,
		
        /// <summary>
        /// A specification of a religion to which membership or allegiance may be ascribed.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("AFLREL")]
        [EnumMember]
        AffiliationReligion,
		
    }
}
