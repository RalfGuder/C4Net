using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the absolute, uncertain or relative timing for a specific REPORTING-DATA.
    /// </summary>
    [DomId(100000291)]
    [DataContract]
    public enum ReportingDataTimingCategoryEnum
    {
		
        /// <summary>
        /// A REPORTING-DATA that specifies effective date and time that are referenced to Universal Time.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("RDABST")]
        [EnumMember]
        ReportingDataAbsoluteTiming,
		
        /// <summary>
        /// A REPORTING-DATA that specifies effective timing that is referenced to a specific ACTION-TASK.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RDRELT")]
        [EnumMember]
        ReportingDataRelativeTiming,
		
        /// <summary>
        /// A REPORTING-DATA that indicates that the start or end timing with respect to past, current, or future periods is not available.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TIMNA")]
        [EnumMember]
        TimingNotAvailable,
		
    }
}
