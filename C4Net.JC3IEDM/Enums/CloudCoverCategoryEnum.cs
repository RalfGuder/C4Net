using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the prevailing class of a specific CLOUD-COVER.
    /// </summary>
    [DomId(100000168)]
    [DataContract]
    public enum CloudCoverCategoryEnum
    {
		
        /// <summary>
        /// A weather condition in which the sky or part of the sky is covered or partly covered by clouds.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("C")]
        [EnumMember]
        Clouds,
		
        /// <summary>
        /// A weather condition in which the sky or part of the sky is covered by smoke.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SMOKE")]
        [EnumMember]
        Smoke,
		
        /// <summary>
        /// A cloud that contains the hot gases, smoke, dust and other particulate matter from the nuclear bomb itself or other sources that are carried aloft.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("RDACCL")]
        [EnumMember]
        RadioactiveCloud,
		
    }
}
