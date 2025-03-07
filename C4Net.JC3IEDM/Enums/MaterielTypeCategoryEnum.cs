using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MATERIEL-TYPE.
    /// </summary>
    [DomId(100000139)]
    [DataContract]
    public enum MaterielTypeCategoryEnum
    {
		
        /// <summary>
        /// A MATERIEL-TYPE that is an expendable class of supply.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CM")]
        [EnumMember]
        ConsumableMaterielType,
		
        /// <summary>
        /// A MATERIEL-TYPE that is not intended for consumption.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("EQ")]
        [EnumMember]
        EquipmentType,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
