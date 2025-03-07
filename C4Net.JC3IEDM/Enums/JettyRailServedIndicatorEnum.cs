using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the JETTY has railway facilities.
    /// </summary>
    [DomId(100004179)]
    [DataContract]
    public enum JettyRailServedIndicatorEnum
    {
		
        /// <summary>
        /// Railway services are not available at the jetty.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Railway services are available at the jetty.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
