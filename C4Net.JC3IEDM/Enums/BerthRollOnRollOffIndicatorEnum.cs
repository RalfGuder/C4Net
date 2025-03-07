using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether or not the BERTH has roll on/roll off capabilities.
    /// </summary>
    [DomId(100004290)]
    [DataContract]
    public enum BerthRollOnRollOffIndicatorEnum
    {
		
        /// <summary>
        /// Roll on / roll off capabilities are not available at the berth.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Roll on / roll off capabilities are available at the berth.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
