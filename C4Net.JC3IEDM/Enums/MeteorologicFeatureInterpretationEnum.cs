using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes the statistical meaning of a specified METEOROLOGIC-FEATURE.
    /// </summary>
    [DomId(100000196)]
    [DataContract]
    public enum MeteorologicFeatureInterpretationEnum
    {
		
        /// <summary>
        /// A value that represents the average of maximum readings over a period of time.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AVMAX")]
        [EnumMember]
        AverageMaximum,
		
        /// <summary>
        /// A value that represents the average of minimum readings over a period of time.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AVMIN")]
        [EnumMember]
        AverageMinimum,
		
        /// <summary>
        /// The actual or expected value.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NOMIN")]
        [EnumMember]
        Nominal,
		
        /// <summary>
        /// The highest actual value.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ABMAX")]
        [EnumMember]
        AbsoluteMaximum,
		
        /// <summary>
        /// The lowest actual value.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ABMIN")]
        [EnumMember]
        AbsoluteMinimum,
		
    }
}
