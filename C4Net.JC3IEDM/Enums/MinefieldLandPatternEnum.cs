using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the pattern of a specific MINEFIELD-LAND.
    /// </summary>
    [DomId(100000141)]
    [DataContract]
    public enum MinefieldLandPatternEnum
    {
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A minefield that is implemented by placing mines one at a time in a regular pattern as directed by current doctrine (for example, straight line or zigzag).
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("REGMNF")]
        [EnumMember]
        RegularMinefield,
		
        /// <summary>
        /// A minefield that is implemented by placing mines one at a time in combination with scattered mines.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("REGTHK")]
        [EnumMember]
        RegularMinefieldThickenedWithScatteredMines,
		
        /// <summary>
        /// A minefield that is implemented by mines that are delivered by aircraft, artillery, missile or ground dispenser without any regard to classical patterns.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SCATTR")]
        [EnumMember]
        Scattered,
		
    }
}
