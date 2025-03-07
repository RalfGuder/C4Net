using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that determines whether a specific REPORTING-DATA refers to real data in an exercise scenario.
    /// </summary>
    [DomId(100004311)]
    [DataContract]
    public enum ReportingDataRealDataExerciseUseOnlyEnum
    {
		
        /// <summary>
        /// The REPORTING-DATA instance is real data not part of the exercise scenario.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("REAL")]
        [EnumMember]
        Real,
		
    }
}
