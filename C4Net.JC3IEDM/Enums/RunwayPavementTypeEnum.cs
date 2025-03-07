using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of pavement classification, which is part of the standard ICAO (International Civil Aviation Organization) method of reporting pavement strength for pavements with bearing strength greater than 5,700 kilograms (12,500 pounds).
    /// </summary>
    [DomId(100004275)]
    [DataContract]
    public enum RunwayPavementTypeEnum
    {
		
        /// <summary>
        /// The pavement type has a flexible classification.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("F")]
        [EnumMember]
        Flexible,
		
        /// <summary>
        /// The pavement type has a rigid classification.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("R")]
        [EnumMember]
        Rigid,
		
    }
}
