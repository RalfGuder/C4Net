using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ACTION-RESOURCE with respect to item or type.
    /// </summary>
    [DomId(100000117)]
    [DataContract]
    public enum ActionResourceCategoryEnum
    {
		
        /// <summary>
        /// An OBJECT-ITEM (FACILITY, FEATURE, MATERIEL, ORGANISATION, or PERSON) to be used, excluded from use, being used, or having been used, in conducting a specific ACTION.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("RI")]
        [EnumMember]
        ActionResourceItem,
		
        /// <summary>
        /// An OBJECT-TYPE (FACILITY-TYPE, FEATURE-TYPE, MATERIEL-TYPE, ORGANISATION-TYPE, or PERSON-TYPE) to be used, excluded from use, being used, or having been used, in conducting a specific ACTION.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RT")]
        [EnumMember]
        ActionResourceType,
		
    }
}
