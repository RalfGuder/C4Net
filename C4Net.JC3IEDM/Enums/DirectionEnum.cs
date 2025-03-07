using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a specific direction.
    /// </summary>
    [DomId(100000222)]
    [DataContract]
    public enum DirectionEnum
    {
		
        /// <summary>
        /// The cardinal point at 0 degree to True North.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("N")]
        [EnumMember]
        North,
		
        /// <summary>
        /// The cardinal point at 45 degrees to True North.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NE")]
        [EnumMember]
        Northeast,
		
        /// <summary>
        /// The cardinal point at 90 degrees to True North.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("E")]
        [EnumMember]
        East,
		
        /// <summary>
        /// The cardinal point at 135 degrees to True North.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SE")]
        [EnumMember]
        Southeast,
		
        /// <summary>
        /// The cardinal point at 180 degrees to True North.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("S")]
        [EnumMember]
        South,
		
        /// <summary>
        /// The cardinal point at 225 degrees to True North.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SW")]
        [EnumMember]
        Southwest,
		
        /// <summary>
        /// The cardinal point at 270 degrees to True North.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("W")]
        [EnumMember]
        West,
		
        /// <summary>
        /// The cardinal point at 315 degrees to True North.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NW")]
        [EnumMember]
        Northwest,
		
        /// <summary>
        /// In any or all directions at one time.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ALL")]
        [EnumMember]
        AllDirections,
		
        /// <summary>
        /// The specific direction midway between North and Northeast referenced to True North.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NNE")]
        [EnumMember]
        NorthNortheast,
		
        /// <summary>
        /// The specific direction midway between East and Northeast referenced to True North.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("ENE")]
        [EnumMember]
        EastNortheast,
		
        /// <summary>
        /// The specific direction midway between East and Southeast referenced to True North.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("ESE")]
        [EnumMember]
        EastSoutheast,
		
        /// <summary>
        /// The specific direction midway between South and Southeast referenced to True North.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("SSE")]
        [EnumMember]
        SouthSoutheast,
		
        /// <summary>
        /// The specific direction midway between South and Southwest referenced to True North.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("SSW")]
        [EnumMember]
        SouthSouthwest,
		
        /// <summary>
        /// The specific direction midway between West and Southwest referenced to True North.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("WSW")]
        [EnumMember]
        WestSouthwest,
		
        /// <summary>
        /// The specific direction midway between West and Northwest referenced to True North.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("WNW")]
        [EnumMember]
        WestNorthwest,
		
        /// <summary>
        /// The specific direction midway between North and Northwest referenced to True North.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("NNW")]
        [EnumMember]
        NorthNorthwest,
		
    }
}
