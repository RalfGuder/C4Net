using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value assigned to represent divisions of the Earth's surface in which standard time is kept as it applies to the specific PLAN-ORDER.
    /// </summary>
    [DomId(100004392)]
    [DataContract]
    public enum PlanOrderHeaderContentTimeZoneEnum
    {
		
        /// <summary>
        /// Universal Time Coordinate (Zulu).
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("Z")]
        [EnumMember]
        UtcZulu,
		
        /// <summary>
        /// Universal Time Coordinate with 1 hour added.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("A")]
        [EnumMember]
        UtcPlus1Hour,
		
        /// <summary>
        /// Universal Time Coordinate with 2 hours added.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("B")]
        [EnumMember]
        UtcPlus2Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 3 hours added.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("C")]
        [EnumMember]
        UtcPlus3Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 4 hours added.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("D")]
        [EnumMember]
        UtcPlus4Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 5 hours added.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("E")]
        [EnumMember]
        UtcPlus5Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 6 hours added.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("F")]
        [EnumMember]
        UtcPlus6Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 7 hours added.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("G")]
        [EnumMember]
        UtcPlus7Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 8 hours added.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("H")]
        [EnumMember]
        UtcPlus8Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 9 hours added.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("I")]
        [EnumMember]
        UtcPlus9Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 10 hours added.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("K")]
        [EnumMember]
        UtcPlus10Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 11 hours added.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("L")]
        [EnumMember]
        UtcPlus11Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 12 hours added.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("M")]
        [EnumMember]
        UtcPlus12Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 12 hours subtracted.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("Y")]
        [EnumMember]
        UtcMinus12Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 11 hours subtracted.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("X")]
        [EnumMember]
        UtcMinus11Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 10 hours subtracted.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("W")]
        [EnumMember]
        UtcMinus10Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 9 hours subtracted.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("V")]
        [EnumMember]
        UtcMinus9Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 8 hours subtracted.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("U")]
        [EnumMember]
        UtcMinus8Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 7 hours subtracted.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("T")]
        [EnumMember]
        UtcMinus7Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 6 hours subtracted.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("S")]
        [EnumMember]
        UtcMinus6Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 5 hours subtracted.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("R")]
        [EnumMember]
        UtcMinus5Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 4 hours subtracted.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("Q")]
        [EnumMember]
        UtcMinus4Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 3 hours subtracted.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("P")]
        [EnumMember]
        UtcMinus3Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 2 hours subtracted.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("O")]
        [EnumMember]
        UtcMinus2Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 1 hour subtracted.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("N")]
        [EnumMember]
        UtcMinus1Hour,
		
        /// <summary>
        /// Universal Time Coordinate with 3 hours and 30 minutes subtracted.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("P30")]
        [EnumMember]
        UtcMinus3HoursAnd30Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 4 hours and 30 minutes subtracted.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("Q30")]
        [EnumMember]
        UtcMinus4HoursAnd30Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 9 hours and 30 minutes subtracted.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("V30")]
        [EnumMember]
        UtcMinus9HoursAnd30Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 10hours and 30 minutes added.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("K30")]
        [EnumMember]
        UtcPlus10HoursAnd30Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 11 hours and 30 minutes added.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("L30")]
        [EnumMember]
        UtcPlus11HoursAnd30Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 3 hours and 30 minutes added.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("C30")]
        [EnumMember]
        UtcPlus3HoursAnd30Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 4 hours and 30 minutes added.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("D30")]
        [EnumMember]
        UtcPlus4HoursAnd30Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 5 hours and 30 minutes added.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("E30")]
        [EnumMember]
        UtcPlus5HoursAnd30Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 5 hours and 45 minutes added.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("E45")]
        [EnumMember]
        UtcPlus5HoursAnd45Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 6 hours and 30 minutes added.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("F30")]
        [EnumMember]
        UtcPlus6HoursAnd30Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 8 hours and 45 minutes added.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("H45")]
        [EnumMember]
        UtcPlus8HoursAnd45Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 9 hours and 30 minutes added.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("I30")]
        [EnumMember]
        UtcPlus9HoursAnd30Minutes,
		
        /// <summary>
        /// Universal Time Coordinate with 13 hours.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("M60")]
        [EnumMember]
        UtcPlus13Hours,
		
        /// <summary>
        /// Universal Time Coordinate with 14 hours.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("M120")]
        [EnumMember]
        UtcPlus14Hours,
		
    }
}
