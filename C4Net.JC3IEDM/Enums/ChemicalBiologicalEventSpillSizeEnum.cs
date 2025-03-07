using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the mass or the volume of a materiel spilled in a CHEMICAL-BIOLOGICAL-EVENT that is a release other than attack (ROTA).
    /// </summary>
    [DomId(100000362)]
    [DataContract]
    public enum ChemicalBiologicalEventSpillSizeEnum
    {
		
        /// <summary>
        /// Greater than 1500 litres in volume or 1500 kilograms in mass.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("XLG")]
        [EnumMember]
        ExtraLarge,
		
        /// <summary>
        /// Equal to or greater than 208 litres and less than or equal to 1500 litres in volume or equal to or greater than 200 kilograms and less than or equal to 1500 kilograms in mass.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LRG")]
        [EnumMember]
        Large,
		
        /// <summary>
        /// Less than 208 litres in volume or 200 kilograms in mass.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SML")]
        [EnumMember]
        Small,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
