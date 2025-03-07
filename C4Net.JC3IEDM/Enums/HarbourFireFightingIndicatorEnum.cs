using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the HARBOUR is capable of supplying fire-fighting facilities.
    /// </summary>
    [DomId(100004165)]
    [DataContract]
    public enum HarbourFireFightingIndicatorEnum
    {
		
        /// <summary>
        /// The harbour is not capable of supplying fire-fighting facilities.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The harbour is capable of supplying fire-fighting facilities.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
