using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the average density of a specific CLOUD-COVER as fractional coverage.
    /// </summary>
    [DomId(100000213)]
    [DataContract]
    public enum CloudCoverAverageCoverageEnum
    {
		
        /// <summary>
        /// Clear sky.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("0")]
        [EnumMember]
        _08,
		
        /// <summary>
        /// Sky partially obscured 12 ½ percent.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("1")]
        [EnumMember]
        _18,
		
        /// <summary>
        /// Sky partially obscured 25 percent.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("2")]
        [EnumMember]
        _28,
		
        /// <summary>
        /// Scattered sky or sky partially obscured 37 ½ percent.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("3")]
        [EnumMember]
        _38,
		
        /// <summary>
        /// Scattered sky or sky partially obscured 50 percent.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("4")]
        [EnumMember]
        _48,
		
        /// <summary>
        /// Broken sky or sky partially obscured 62 ½ percent.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("5")]
        [EnumMember]
        _58,
		
        /// <summary>
        /// Broken sky or sky partially obscured 75 percent.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("6")]
        [EnumMember]
        _68,
		
        /// <summary>
        /// Sky partially obscured or overcast with breaks.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("7")]
        [EnumMember]
        _78,
		
        /// <summary>
        /// Complete overcast.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("8")]
        [EnumMember]
        _88,
		
        /// <summary>
        /// A condition in which an overcast layer has discernible break(s) totalling less than 1 octal.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("78")]
        [EnumMember]
        _788,
		
    }
}
