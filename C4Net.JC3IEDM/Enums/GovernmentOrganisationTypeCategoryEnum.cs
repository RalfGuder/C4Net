using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of GOVERNMENT-ORGANISATION-TYPE.
    /// </summary>
    [DomId(100000371)]
    [DataContract]
    public enum GovernmentOrganisationTypeCategoryEnum
    {
		
        /// <summary>
        /// A GOVERNMENT-ORGANISATION-TYPE that is officially involved in international civil affairs.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("INTCIV")]
        [EnumMember]
        InternationalCivil,
		
        /// <summary>
        /// A GOVERNMENT-ORGANISATION-TYPE that is officially involved in international affairs that include both civil and military elements.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("INTCMI")]
        [EnumMember]
        InternationalCivilMilitary,
		
        /// <summary>
        /// A GOVERNMENT-ORGANISATION-TYPE that is officially sanctioned and is trained and equipped to exert force.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MILORG")]
        [EnumMember]
        MilitaryOrganisationType,
		
        /// <summary>
        /// A GOVERNMENT-ORGANISATION-TYPE that is officially involved in national civil affairs.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NATCIV")]
        [EnumMember]
        NationalCivil,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
