using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether a specific PERSON has been placed in reserve.
    /// </summary>
    [DomId(100000266)]
    [DataContract]
    public enum PersonStatusReserveIndicatorEnum
    {
		
        /// <summary>
        /// The specific PERSON is not in reserve status.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific PERSON is currently in reserve status.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
