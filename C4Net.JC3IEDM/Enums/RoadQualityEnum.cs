using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a subjective rating of the quality of the ROAD.
    /// </summary>
    [DomId(100004267)]
    [DataContract]
    public enum RoadQualityEnum
    {
		
        /// <summary>
        /// The quality of the ROAD is rated as excellent.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("E")]
        [EnumMember]
        Excellent,
		
        /// <summary>
        /// The quality of the ROAD is rated as fair.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("F")]
        [EnumMember]
        Fair,
		
        /// <summary>
        /// The quality of the ROAD is rated as good.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("G")]
        [EnumMember]
        Good,
		
        /// <summary>
        /// The quality of the ROAD is rated as poor.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("P")]
        [EnumMember]
        Poor,
		
    }
}
