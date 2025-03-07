using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that differentiates between left, right and centre parallel runways, Short Takeoff and Landing (STOL) or true as applicable.
    /// </summary>
    [DomId(100004279)]
    [DataContract]
    public enum ApproachDirectionCategoryEnum
    {
		
        /// <summary>
        /// The specific value that specifies the centre runway approach for parallel runways.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("C")]
        [EnumMember]
        Centre,
		
        /// <summary>
        /// The specific value that specifies the left side runway approach for parallel runways.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("L")]
        [EnumMember]
        Left,
		
        /// <summary>
        /// The specific value that specifies the right side runway approach for parallel runways.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("R")]
        [EnumMember]
        Right,
		
        /// <summary>
        /// The specific value that specifies short take-off and landing approach direction.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("S")]
        [EnumMember]
        Stol,
		
        /// <summary>
        /// The specific value, which specifies that the approach direction is comparable to the true heading not magnetic heading.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("T")]
        [EnumMember]
        True,
		
    }
}
