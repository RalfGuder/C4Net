using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates the status of a specific AIRFIELD to only operate during daylight.
    /// </summary>
    [DomId(100004212)]
    [DataContract]
    public enum AirfieldStatusDayOperationsEnum
    {
		
        /// <summary>
        /// The specific AIRFIELD can support day and night operations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BOTH")]
        [EnumMember]
        Both,
		
        /// <summary>
        /// The specific AIRFIELD is restricted to daylight operations.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DAY")]
        [EnumMember]
        Day,
		
        /// <summary>
        /// The specific AIRFIELD is restricted to night time operations.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NIGHT")]
        [EnumMember]
        Night,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
