using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The protection provided from wind, sea, and swell in the area where normal port operations are conducted.
    /// </summary>
    [DomId(100004304)]
    [DataContract]
    public enum HarbourShelterQualityEnum
    {
		
        /// <summary>
        /// The protection provided is excellent.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("E")]
        [EnumMember]
        Excellent,
		
        /// <summary>
        /// The protection provided is fair.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("F")]
        [EnumMember]
        Fair,
		
        /// <summary>
        /// The protection provided is good.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("G")]
        [EnumMember]
        Good,
		
        /// <summary>
        /// The protection provided is poor.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("P")]
        [EnumMember]
        Poor,
		
    }
}
