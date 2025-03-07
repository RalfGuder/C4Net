using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes a judgement whether a specific event is a crime or not.
    /// </summary>
    [DomId(100004143)]
    [DataContract]
    public enum ActionEventDetailCrimeIndicatorEnum
    {
		
        /// <summary>
        /// The event is not considered to be a crime.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The event is considered to be a crime.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
