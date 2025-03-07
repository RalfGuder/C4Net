using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ORGANISATION.
    /// </summary>
    [DomId(100000149)]
    [DataContract]
    public enum OrganisationCategoryEnum
    {
		
        /// <summary>
        /// An ORGANISATION that is a group of vehicles or vessels organised for the purpose of control and orderly movement with or without escort protection.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CO")]
        [EnumMember]
        Convoy,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A military ORGANISATION whose structure is prescribed by competent authority.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("UN")]
        [EnumMember]
        Unit,
		
    }
}
