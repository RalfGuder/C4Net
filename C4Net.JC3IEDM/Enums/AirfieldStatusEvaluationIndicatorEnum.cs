using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates that an AIRFIELD has been checked and its characteristics have been verified.
    /// </summary>
    [DomId(100004214)]
    [DataContract]
    public enum AirfieldStatusEvaluationIndicatorEnum
    {
		
        /// <summary>
        /// The specific AIRFIELD has not been evaluated.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific AIRFIELD has been evaluated.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
