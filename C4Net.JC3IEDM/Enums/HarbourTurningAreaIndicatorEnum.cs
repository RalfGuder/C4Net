using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether there is a turning basin or other water area available in a specific HARBOUR.
    /// </summary>
    [DomId(100004307)]
    [DataContract]
    public enum HarbourTurningAreaIndicatorEnum
    {
		
        /// <summary>
        /// A turning area is not available at the harbour.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// A turning area is available at the harbour.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
