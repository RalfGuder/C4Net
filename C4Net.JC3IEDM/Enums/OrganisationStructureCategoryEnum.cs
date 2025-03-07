using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of the ORGANISATION-STRUCTURE.
    /// </summary>
    [DomId(100004429)]
    [DataContract]
    public enum OrganisationStructureCategoryEnum
    {
		
        /// <summary>
        /// An organisational structure representing a Taskorg.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("TSKORG")]
        [EnumMember]
        TaskOrganisation,
		
        /// <summary>
        /// An organisational structure representing an ORBAT
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ORBAT")]
        [EnumMember]
        OrderOfBattle,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
