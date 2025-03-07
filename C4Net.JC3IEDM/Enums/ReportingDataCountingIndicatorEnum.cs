using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether the data referred to by a specific REPORTING-DATA is based on a count of objects.
    /// </summary>
    [DomId(100000278)]
    [DataContract]
    public enum ReportingDataCountingIndicatorEnum
    {
		
        /// <summary>
        /// Reported data is not based on a count.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Reported data is based on a count.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
