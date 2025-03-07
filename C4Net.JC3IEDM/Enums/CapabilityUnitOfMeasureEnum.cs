using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the quantities in terms of which the magnitude of a specific CAPABILITY descriptor is stated.
    /// </summary>
    [DomId(100000173)]
    [DataContract]
    public enum CapabilityUnitOfMeasureEnum
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
        /// A unit of 3,600 seconds duration.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("HR")]
        [EnumMember]
        Hour,
		
        /// <summary>
        /// The standard international unit of mass in the metric system.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("KG")]
        [EnumMember]
        Kilogram,
		
        /// <summary>
        /// Units of 1,000 grams divided by the elapsed time in hours.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("KGH")]
        [EnumMember]
        KilogramSPerHour,
		
        /// <summary>
        /// 1,000 metres.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("KM")]
        [EnumMember]
        Kilometre,
		
        /// <summary>
        /// Units of 1,000 metres divided by the elapsed time in hours.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("KPH")]
        [EnumMember]
        KilometreSPerHour,
		
        /// <summary>
        /// A standard international unit of capacity in the metric system.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("LI")]
        [EnumMember]
        Litre,
		
        /// <summary>
        /// The number of rounds that can be fired in 60 seconds.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("RDM")]
        [EnumMember]
        RoundSPerMinute,
		
        /// <summary>
        /// The standard international unit of time in the metric system.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SECOND")]
        [EnumMember]
        Second,
		
        /// <summary>
        /// 1,000 kilograms.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("MTRCTN")]
        [EnumMember]
        MetricTon,
		
        /// <summary>
        /// One of 360 equally divided parts of a circle.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("DEG")]
        [EnumMember]
        Degree,
		
        /// <summary>
        /// Units of cubic metres divided by the elapsed time in hours.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("CMH")]
        [EnumMember]
        CubicMetreSPerHour,
		
        /// <summary>
        /// The standard international unit of linear measure in the metric system.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("METRE")]
        [EnumMember]
        Metre,
		
        /// <summary>
        /// A standard international unit of area in the metric system.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("SQM")]
        [EnumMember]
        SquareMetre,
		
        /// <summary>
        /// Units of square metres divided by the elapsed time in hours.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("SMH")]
        [EnumMember]
        SquareMetreSPerHour,
		
        /// <summary>
        /// An hour regarded in terms of the amount of work that could be done by one person within this period.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("MANHUR")]
        [EnumMember]
        ManHour,
		
        /// <summary>
        /// Units of man-hours divided by the elapsed time in hours.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MHPRHR")]
        [EnumMember]
        ManHourSPerHour,
		
        /// <summary>
        /// Units of litres divided by the elapsed time in minutes.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("LPM")]
        [EnumMember]
        LitreSPerMinute,
		
        /// <summary>
        /// Units of litres divided by the elapsed time in hours.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("LPH")]
        [EnumMember]
        LitreSPerHour,
		
        /// <summary>
        /// A unit of 60 seconds duration.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("MINUTE")]
        [EnumMember]
        Minute,
		
        /// <summary>
        /// There is no unit of measure used.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("UNTLS")]
        [EnumMember]
        Unitless,
		
        /// <summary>
        /// A standard measure of a ship’s speed in nautical miles per hour.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("KNOTS")]
        [EnumMember]
        Knots,
		
        /// <summary>
        /// Units of metres divided by the elapsed time in seconds.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("MPS")]
        [EnumMember]
        MetreSPerSecond,
		
        /// <summary>
        /// A standard measure of length equal to one minute of a great circle of the earth.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("NM")]
        [EnumMember]
        NauticalMile,
		
        /// <summary>
        /// A rate or proportion per cent.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("PRCNTG")]
        [EnumMember]
        Percentage,
		
        /// <summary>
        /// 1,000,000,000 hertz.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("GHZ")]
        [EnumMember]
        Gigahertz,
		
        /// <summary>
        /// The standard international unit of frequency in the metric system equal to one cycle per second.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("HZ")]
        [EnumMember]
        Hertz,
		
        /// <summary>
        /// 1,000 hertz.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("KHZ")]
        [EnumMember]
        Kilohertz,
		
        /// <summary>
        /// 1,000,000 hertz.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("MHZ")]
        [EnumMember]
        Megahertz,
		
        /// <summary>
        /// The rate at which pulses are generated or received.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("PPS")]
        [EnumMember]
        PulseSPerSecond,
		
        /// <summary>
        /// The standard international unit of power in the metric system.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("WATT")]
        [EnumMember]
        Watt,
		
        /// <summary>
        /// Number of Items against one day.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("ITEMPD")]
        [EnumMember]
        ItemSPerDay,
		
        /// <summary>
        /// Number of Items against one hour.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("ITEMPH")]
        [EnumMember]
        ItemSPerHour,
		
        /// <summary>
        /// Number of Items against one minute.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("ITEMPM")]
        [EnumMember]
        ItemSPerMinute,
		
    }
}
