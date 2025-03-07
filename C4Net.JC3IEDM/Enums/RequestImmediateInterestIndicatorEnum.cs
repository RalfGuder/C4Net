using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether the information sought in a request is of immediate interest.
    /// </summary>
    [DomId(100000218)]
    [DataContract]
    public enum RequestImmediateInterestIndicatorEnum
    {
		
        /// <summary>
        /// The request has no immediate interest, i.e. it can be reported at the normal delivery time.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The request has an immediate interest, i.e. it must be immediately reported.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
