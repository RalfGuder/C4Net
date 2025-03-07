using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes a judgement whether a specific resource (OBJECT-ITEM or OBJECT-TYPE) associated with a specific ACTION is essential for the effective completion of that ACTION.
    /// </summary>
    [DomId(100000225)]
    [DataContract]
    public enum ActionResourceCriticalityIndicatorEnum
    {
		
        /// <summary>
        /// The resource is not essential for the effective completion of the ACTION.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The resource is essential for the effective completion of the ACTION.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
