using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of EXECUTIVE-MILITARY-ORGANISATION-TYPE.
    /// </summary>
    [DomId(100000370)]
    [DataContract]
    public enum ExecutiveMilitaryOrganisationTypeCategoryEnum
    {
		
        /// <summary>
        /// An EXECUTIVE-MILITARY-ORGANISATION-TYPE that performs the management functions of an international, national, strategic or service headquarters.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HQ")]
        [EnumMember]
        Headquarters,
		
        /// <summary>
        /// An EXECUTIVE-MILITARY-ORGANISATION-TYPE that provides management of logistics services.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LOG")]
        [EnumMember]
        Logistics,
		
        /// <summary>
        /// An EXECUTIVE-MILITARY-ORGANISATION-TYPE, other than police, that manages the training, equipping, manning, and operating of an armed uniformed force.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MILSVC")]
        [EnumMember]
        MilitaryService,
		
        /// <summary>
        /// An EXECUTIVE-MILITARY-ORGANISATION-TYPE that provides management of personnel services.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PRSNL")]
        [EnumMember]
        Personnel,
		
        /// <summary>
        /// An EXECUTIVE-MILITARY-ORGANISATION-TYPE that provides management of supply services.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SUPPLY")]
        [EnumMember]
        Supply,
		
        /// <summary>
        /// An EXECUTIVE-MILITARY-ORGANISATION-TYPE that provides management of transportation services.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("TRNPTN")]
        [EnumMember]
        Transportation,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
