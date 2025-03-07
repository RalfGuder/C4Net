using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the maximum degree of discrimination or resolution for which speed is stated.
    /// </summary>
    [DomId(100004217)]
    [DataContract]
    public enum SpeedPrecisionEnum
    {
		
        /// <summary>
        /// The speed is defined to the precision of kilometres per hour.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("KPH")]
        [EnumMember]
        KilometresPerHour,
		
        /// <summary>
        /// The speed is defined to the precision of a knot.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("KNOTS")]
        [EnumMember]
        Knots,
		
        /// <summary>
        /// The speed is defined to the precision of metres per second.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MPS")]
        [EnumMember]
        MetresPerSecond,
		
    }
}
