using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ACTION-EFFECT with respect to item or type.
    /// </summary>
    [DomId(100000113)]
    [DataContract]
    public enum ActionEffectCategoryEnum
    {
		
        /// <summary>
        /// An ACTION-EFFECT of a specific ACTION in accomplishing its aim in relation to a specific OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AEITEM")]
        [EnumMember]
        ActionEffectItem,
		
        /// <summary>
        /// An ACTION-EFFECT of a specific ACTION in accomplishing its aim in relation to a specific OBJECT-TYPE.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AETYPE")]
        [EnumMember]
        ActionEffectType,
		
    }
}
