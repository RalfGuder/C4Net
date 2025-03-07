using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether a detector has indicated the presence of a CBRN-EVENT.
    /// </summary>
    [DomId(100000358)]
    [DataContract]
    public enum CbrnEventAlarmResultIndicatorEnum
    {
		
        /// <summary>
        /// A specific CBRN-EVENT has not been detected.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// A specific CBRN-EVENT has been detected.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
