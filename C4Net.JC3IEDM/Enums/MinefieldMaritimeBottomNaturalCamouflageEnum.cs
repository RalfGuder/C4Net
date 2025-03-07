using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the description of the ground of a lake, river, or ocean, or other body of water with respect to the ability to hide mines on the bottom at a specific MINEFIELD-MARITIME.
    /// </summary>
    [DomId(100004325)]
    [DataContract]
    public enum MinefieldMaritimeBottomNaturalCamouflageEnum
    {
		
        /// <summary>
        /// Stable and smooth flat bottom, mine hunting possible, little camouflage for mines.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("STBSMT")]
        [EnumMember]
        StableAndSmoothFlatBottom,
		
        /// <summary>
        /// Rough bottom, mine hunting more difficult.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RGHBTM")]
        [EnumMember]
        RoughBottom,
		
        /// <summary>
        /// Rather stable and smooth but uneven bottom, mine hunting possible.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RTHRST")]
        [EnumMember]
        RatherStableAndSmoothButUnevenBottom,
		
        /// <summary>
        /// Mines are likely to be hidden completely owing to complete burial, mine hunting difficult.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SFTBTM")]
        [EnumMember]
        SoftBottom,
		
        /// <summary>
        /// Mines are likely to be hidden completely in deep hollows or crevices or by cliffs, mine hunting difficult.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BTMDEP")]
        [EnumMember]
        BottomHasDeepHollowsOrCrevicesOrCliffs,
		
        /// <summary>
        /// Mines are likely to be hidden by irregularity of the bottom, mine hunting difficult.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("IRREGL")]
        [EnumMember]
        IrregularBottom,
		
        /// <summary>
        /// Mines are likely to be hidden by seaweed, mine hunting possible with difficulty.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("BTMCVR")]
        [EnumMember]
        BottomCoveredInSeaweed,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
