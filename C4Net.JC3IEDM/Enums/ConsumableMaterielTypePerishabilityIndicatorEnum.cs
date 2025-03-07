using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether a particular CONSUMABLE-MATERIEL-TYPE is liable to decay or spoil.
    /// </summary>
    [DomId(100000228)]
    [DataContract]
    public enum ConsumableMaterielTypePerishabilityIndicatorEnum
    {
		
        /// <summary>
        /// The CONSUMABLE-MATERIEL-TYPE is not liable to decay or spoil.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The CONSUMABLE-MATERIEL-TYPE is liable to decay or spoil.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
