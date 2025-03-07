using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the standard procedure to be used in controlling the employment of a specific ACTION-RESOURCE in support of a specific ACTION.
    /// </summary>
    [DomId(100000118)]
    [DataContract]
    public enum ActionResourceEmploymentMethodOfControlEnum
    {
		
        /// <summary>
        /// The target is fired upon at the direction of the observer, the supported unit or the higher headquarters.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ASORD")]
        [EnumMember]
        AsOrdered,
		
        /// <summary>
        /// The ACTION-RESOURCE will be used at a to be specified time.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ONORD")]
        [EnumMember]
        OnOrders,
		
    }
}
