using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the maximum resolution used for the expression of a linear measure.
    /// </summary>
    [DomId(100004216)]
    [DataContract]
    public enum DistancePrecisionEnum
    {
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of 10 feet (3.048 metres).
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("10FT")]
        [EnumMember]
        _10Feet,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of 100 feet (30.48 metres).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("100FT")]
        [EnumMember]
        _100Feet,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of 10 metres.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("10MTR")]
        [EnumMember]
        _10Metres,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of 100 metres.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("100MTR")]
        [EnumMember]
        _100Metres,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of 3 metres.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("3MTR")]
        [EnumMember]
        _3Metres,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of 30 metres.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("30MTR")]
        [EnumMember]
        _30Metres,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of 300 metres.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("300MTR")]
        [EnumMember]
        _300Metres,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of 0.01 metre.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("CM")]
        [EnumMember]
        Centimetre,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of one foot (0.3048 metres).
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("FOOT")]
        [EnumMember]
        Foot,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of one inch (0.0254 metres).
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("INCH")]
        [EnumMember]
        Inch,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of 1000 metres.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("KM")]
        [EnumMember]
        Kilometre,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of one metre.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("METRE")]
        [EnumMember]
        Metre,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of one mile (1609.344 metres).
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MILE")]
        [EnumMember]
        Mile,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of one millimetre.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MM")]
        [EnumMember]
        Millimetre,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of a nautical mile (1852 metres).
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("NM")]
        [EnumMember]
        NauticalMile,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of a yard (0.9144 metres).
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("YARD")]
        [EnumMember]
        Yard,
		
        /// <summary>
        /// A linear measure (distance, length) is defined to the precision of a kiloyard (914,4 metres).
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("KILYRD")]
        [EnumMember]
        Kiloyard,
		
    }
}
