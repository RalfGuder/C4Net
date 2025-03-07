using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a range of wave heights on a specific liquid surface.
    /// </summary>
    [DomId(100004210)]
    [DataContract]
    public enum LiquidSurfaceStatusSeaStateEnum
    {
		
        /// <summary>
        /// Wave height 0 metres.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("0")]
        [EnumMember]
        CalmGlassy,
		
        /// <summary>
        /// Wave height 0 to 0.1 metre.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("1")]
        [EnumMember]
        CalmRippled,
		
        /// <summary>
        /// Wave height 0.1 to 0.5 metre.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("2")]
        [EnumMember]
        SmoothWavelets,
		
        /// <summary>
        /// Wave height 0.5 to 1.25 metre.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("3")]
        [EnumMember]
        Slight,
		
        /// <summary>
        /// Wave height 1.25 to 2.5 metres.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("4")]
        [EnumMember]
        Moderate,
		
        /// <summary>
        /// Wave height 2.5 to 4 metres.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("5")]
        [EnumMember]
        Rough,
		
        /// <summary>
        /// Wave height 4 to 6 metres.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("6")]
        [EnumMember]
        VeryRough,
		
        /// <summary>
        /// Wave height 6 to 9 metres.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("7")]
        [EnumMember]
        High,
		
        /// <summary>
        /// Wave height 9 to 14 metres.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("8")]
        [EnumMember]
        VeryHigh,
		
        /// <summary>
        /// Wave height greater than 14 metres.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("9")]
        [EnumMember]
        Phenomenal,
		
    }
}
