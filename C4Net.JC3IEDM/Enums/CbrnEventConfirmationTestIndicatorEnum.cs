using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether a test confirms the presence of a CBRN-EVENT.
    /// </summary>
    [DomId(100000359)]
    [DataContract]
    public enum CbrnEventConfirmationTestIndicatorEnum
    {
		
        /// <summary>
        /// The specific CBRN-EVENT has not been confirmed by a test.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific CBRN-EVENT has been confirmed by a test.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
