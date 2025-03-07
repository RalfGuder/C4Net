using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value used to indicate the class of air stability.
    /// </summary>
    [DomId(100004309)]
    [DataContract]
    public enum WindAirStabilityCategoryEnum
    {
		
        /// <summary>
        /// The air is unstable, so there is strong mixing, and the material is effective over shorter distances.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("U")]
        [EnumMember]
        SimplifiedUnstable,
		
        /// <summary>
        /// The degree of mixing is intermediate between that for stable and unstable conditions, and the range of effectiveness is intermediate between that for stable and unstable conditions.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("N")]
        [EnumMember]
        SimplifiedNeutral,
		
        /// <summary>
        /// The air is stable, so there is little mixing, and the material is effective over longer distances.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("S")]
        [EnumMember]
        SimplifiedStable,
		
        /// <summary>
        /// The air is very unstable, with reference to the detailed class. This is determined from observations of wind speed, cloud cover, and time of day based on a standard table, developed from the work of Pasquill, Gifford, and Turner. The more unstable the conditions, the greater the degree of mixing, and the shorter the range of effectiveness.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("1")]
        [EnumMember]
        DetailedVeryUnstable,
		
        /// <summary>
        /// The air is unstable, with reference to the detailed class. This is determined from observations of wind speed, cloud cover, and time of day based on a standard table developed from the work of Pasquill, Gifford, and Turner. The more unstable the conditions, the greater the degree of mixing, and the shorter the range of effectiveness.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("2")]
        [EnumMember]
        DetailedUnstable,
		
        /// <summary>
        /// The air is slightly unstable, with reference to the detailed class. This is determined from observations of wind speed, cloud cover, and time of day based on a standard table developed from the work of Pasquill, Gifford, and Turner. The more unstable the conditions, the greater the degree of mixing, and the shorter the range of effectiveness.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("3")]
        [EnumMember]
        DetailedSlightlyUnstable,
		
        /// <summary>
        /// The air is neutral in stability, with reference to the detailed class. This is determined from observations of wind speed, cloud cover, and time of day based on a standard table developed from the work of Pasquill, Gifford, and Turner. The more unstable the conditions, the greater the degree of mixing, and the shorter the range of effectiveness.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("4")]
        [EnumMember]
        DetailedNeutral,
		
        /// <summary>
        /// The air is slightly stable, with reference to the detailed class. This is determined from observations of wind speed, cloud cover, and time of day based on a standard table developed from the work of Pasquill, Gifford, and Turner. The more unstable the conditions, the greater the degree of mixing, and the shorter the range of effectiveness.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("5")]
        [EnumMember]
        DetailedSlightlyStable,
		
        /// <summary>
        /// The air is stable, with reference to the detailed class. This is determined from observations of wind speed, cloud cover, and time of day based on a standard table developed from the work of Pasquill, Gifford, and Turner. The more unstable the conditions, the greater the degree of mixing, and the shorter the range of effectiveness.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("6")]
        [EnumMember]
        DetailedStable,
		
        /// <summary>
        /// The air is very stable, with reference to the detailed class. This is determined from observations of wind speed, cloud cover, and time of day based on a standard table developed from the work of Pasquill, Gifford, and Turner. The more unstable the conditions, the greater the degree of mixing, and the shorter the range of effectiveness.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("7")]
        [EnumMember]
        DetailedVeryStable,
		
    }
}
