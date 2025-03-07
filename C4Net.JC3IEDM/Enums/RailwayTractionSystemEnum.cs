using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the motive power (engine type) that is supported along a specific RAILWAY.
    /// </summary>
    [DomId(100004261)]
    [DataContract]
    public enum RailwayTractionSystemEnum
    {
		
        /// <summary>
        /// The RAILWAY supports electric locomotives.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("E")]
        [EnumMember]
        Electric,
		
        /// <summary>
        /// The RAILWAY supports locomotives that are not electric.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NE")]
        [EnumMember]
        NotElectric,
		
    }
}
