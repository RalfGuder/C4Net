using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a CONSUMABLE-MATERIEL-TYPE that requires special handling because of environmental or safety reasons.
    /// </summary>
    [DomId(100000186)]
    [DataContract]
    public enum ConsumableMaterielTypeHazardEnum
    {
		
        /// <summary>
        /// The designation of the possible danger caused by a specific CONSUMABLE-MATERIEL-TYPE having corrosive properties.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COR")]
        [EnumMember]
        Corrosive,
		
        /// <summary>
        /// The designation of the possible danger caused by a specific CONSUMABLE-MATERIEL-TYPE having explosive properties.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("EXPLOS")]
        [EnumMember]
        Explosive,
		
        /// <summary>
        /// The designation of the possible danger caused by a specific CONSUMABLE-MATERIEL-TYPE having inflammable properties.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("INF")]
        [EnumMember]
        Inflammable,
		
        /// <summary>
        /// The designation of the possible danger caused by a specific CONSUMABLE-MATERIEL-TYPE having radiation properties.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("RAD")]
        [EnumMember]
        Radiation,
		
        /// <summary>
        /// The designation of the possible danger caused by a specific CONSUMABLE-MATERIEL-TYPE having chemical properties.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CHM")]
        [EnumMember]
        Chemical,
		
        /// <summary>
        /// The designation of the possible danger caused by a specific CONSUMABLE-MATERIEL-TYPE having toxic properties.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("TOX")]
        [EnumMember]
        Toxic,
		
        /// <summary>
        /// The designation of the possible danger caused by a specific CONSUMABLE-MATERIEL-TYPE having biological properties.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("BIOLOG")]
        [EnumMember]
        Biological,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
