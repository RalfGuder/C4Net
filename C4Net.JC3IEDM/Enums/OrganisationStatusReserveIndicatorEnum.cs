using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether a specific ORGANISATION has been placed in reserve.
    /// </summary>
    [DomId(100000264)]
    [DataContract]
    public enum OrganisationStatusReserveIndicatorEnum
    {
		
        /// <summary>
        /// The specific ORGANISATION is not in reserve status.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific ORGANISATION is currently in reserve status.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
