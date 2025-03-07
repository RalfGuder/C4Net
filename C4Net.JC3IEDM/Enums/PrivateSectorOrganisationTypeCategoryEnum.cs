using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of PRIVATE-SECTOR-ORGANISATION-TYPE.
    /// </summary>
    [DomId(100000377)]
    [DataContract]
    public enum PrivateSectorOrganisationTypeCategoryEnum
    {
		
        /// <summary>
        /// A PRIVATE-SECTOR-ORGANISATION-TYPE whose predominant business is the production and processing of agricultural products.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AGRCTL")]
        [EnumMember]
        Agricultural,
		
        /// <summary>
        /// A PRIVATE-SECTOR-ORGANISATION-TYPE whose predominant business is defence in nature.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DEFIND")]
        [EnumMember]
        DefenceIndustry,
		
        /// <summary>
        /// A PRIVATE-SECTOR-ORGANISATION-TYPE whose predominant business is the production and processing of seafood products.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FSHIND")]
        [EnumMember]
        FishingIndustry,
		
        /// <summary>
        /// A PRIVATE-SECTOR-ORGANISATION-TYPE whose predominant business is manufacturing in nature.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MFG")]
        [EnumMember]
        Manufacturing,
		
        /// <summary>
        /// A PRIVATE-SECTOR-ORGANISATION-TYPE whose predominant business is the gathering and dissemination of news.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NEWSMD")]
        [EnumMember]
        NewsMedia,
		
        /// <summary>
        /// A PRIVATE-SECTOR-ORGANISATION-TYPE whose predominant business is philanthropic in nature.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PHLNTP")]
        [EnumMember]
        Philanthropic,
		
        /// <summary>
        /// A PRIVATE-SECTOR-ORGANISATION-TYPE whose predominant business is retail in nature.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("RETAIL")]
        [EnumMember]
        Retail,
		
        /// <summary>
        /// A PRIVATE-SECTOR-ORGANISATION-TYPE whose predominant business is trade in nature.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("TRADE")]
        [EnumMember]
        Trade,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A PRIVATE-SECTOR-ORGANISATION-TYPE whose predominant business is multi-national in scope and nature.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("MULTIN")]
        [EnumMember]
        MultiNational,
		
    }
}
