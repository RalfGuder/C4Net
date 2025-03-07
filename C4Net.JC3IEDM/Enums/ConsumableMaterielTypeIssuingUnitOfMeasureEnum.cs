using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the unit of measure of which a standard quantity (unit) of a specific CONSUMABLE-MATERIEL-TYPE is made available.
    /// </summary>
    [DomId(100000124)]
    [DataContract]
    public enum ConsumableMaterielTypeIssuingUnitOfMeasureEnum
    {
		
        /// <summary>
        /// The standard international unit of volume in the metric system.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CM")]
        [EnumMember]
        CubicMetre,
		
        /// <summary>
        /// Singly.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("EA")]
        [EnumMember]
        Each,
		
        /// <summary>
        /// The standard international unit of mass in the metric system.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("KG")]
        [EnumMember]
        Kilogram,
		
        /// <summary>
        /// 1,000 metres.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("KM")]
        [EnumMember]
        Kilometre,
		
        /// <summary>
        /// 1/1,000th of a cubic metre.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LI")]
        [EnumMember]
        Litre,
		
        /// <summary>
        /// The standard international unit of linear measure in the metric system.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("METRE")]
        [EnumMember]
        Metre,
		
        /// <summary>
        /// 1,000 kilograms.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MTRCTN")]
        [EnumMember]
        MetricTon,
		
        /// <summary>
        /// The standard international unit of area in the metric system.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SQM")]
        [EnumMember]
        SquareMetre,
		
        /// <summary>
        /// 1/100th of a metre.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CNTMTR")]
        [EnumMember]
        Centimetre,
		
        /// <summary>
        /// A set of twelve.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("DOZEN")]
        [EnumMember]
        Dozen,
		
        /// <summary>
        /// 1/1,000th of a kilogram.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("GRAM")]
        [EnumMember]
        Gram,
		
        /// <summary>
        /// A group of 144.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("GROSS")]
        [EnumMember]
        Gross,
		
        /// <summary>
        /// A unit of explosive power, equal to that of one thousand tons of TNT.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("KILTON")]
        [EnumMember]
        Kiloton,
		
        /// <summary>
        /// 1/1,000,000th of a kilogram (1/1,000th of a gram).
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MILGRM")]
        [EnumMember]
        Milligram,
		
        /// <summary>
        /// 1/1,000,000th of a cubic metre (1/1,000th of a litre).
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("MILLTR")]
        [EnumMember]
        Millilitre,
		
        /// <summary>
        /// 1/1,000th of a metre.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("MILMTR")]
        [EnumMember]
        Millimetre,
		
        /// <summary>
        /// A measure of weight, legally 1016.05 kilograms normally referenced to the displacement of a vessel.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("LONGTN")]
        [EnumMember]
        LongTon,
		
        /// <summary>
        /// A measure of weight, legally 907.19 kilograms.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("SHRTTN")]
        [EnumMember]
        ShortTon,
		
    }
}
