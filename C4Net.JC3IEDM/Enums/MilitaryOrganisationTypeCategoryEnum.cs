using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MILITARY-ORGANISATION-TYPE.
    /// </summary>
    [DomId(100000373)]
    [DataContract]
    public enum MilitaryOrganisationTypeCategoryEnum
    {
		
        /// <summary>
        /// A MILITARY-ORGANISATION-TYPE whose function is to manage and direct the military establishment.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("EXCMIL")]
        [EnumMember]
        ExecutiveMilitaryOrganisationType,
		
        /// <summary>
        /// A MILITARY-ORGANISATION-TYPE with a set of duties that can be fulfilled by one person.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MILPST")]
        [EnumMember]
        MilitaryPostType,
		
        /// <summary>
        /// An ORGANISATION-TYPE that is constituted on a temporary or semi-permanent basis for the purpose of carrying out a specific operation, mission or task.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TASK")]
        [EnumMember]
        TaskFormationType,
		
        /// <summary>
        /// A MILITARY-ORGANISATION-TYPE whose structure is prescribed by competent authority.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("UNIT")]
        [EnumMember]
        UnitType,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
