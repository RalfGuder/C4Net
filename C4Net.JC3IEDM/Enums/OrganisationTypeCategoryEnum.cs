using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ORGANISATION-TYPE.
    /// </summary>
    [DomId(100000154)]
    [DataContract]
    public enum OrganisationTypeCategoryEnum
    {
		
        /// <summary>
        /// An ORGANISATION-TYPE with a set of duties that are intended to be fulfilled by one person in private sector and non-military government organisations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CIVPST")]
        [EnumMember]
        CivilianPostType,
		
        /// <summary>
        /// An ORGANISATION-TYPE that controls and administers public policy either under a national or international mandate.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("GVTORG")]
        [EnumMember]
        GovernmentOrganisationType,
		
        /// <summary>
        /// An ORGANISATION-TYPE that is non-formal in nature and classes together its members due to mutual or common circumstances.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("GRPORG")]
        [EnumMember]
        GroupOrganisationType,
		
        /// <summary>
        /// An ORGANISATION-TYPE that is a non-government organisation and is constituted for business, commerce, manufacturing, trade, relief or philanthropy.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PVSORG")]
        [EnumMember]
        PrivateSectorOrganisationType,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
