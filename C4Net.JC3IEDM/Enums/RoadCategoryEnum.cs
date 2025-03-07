using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of ROAD.
    /// </summary>
    [DomId(100004264)]
    [DataContract]
    public enum RoadCategoryEnum
    {
		
        /// <summary>
        /// The specific ROAD is a track or lane.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("E")]
        [EnumMember]
        Lane,
		
        /// <summary>
        /// The specific ROAD is a local road or street.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("D")]
        [EnumMember]
        Local,
		
        /// <summary>
        /// The specific ROAD is a main road, highway or federal road.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("B")]
        [EnumMember]
        Main,
		
        /// <summary>
        /// The specific ROAD is a motorway or expressway.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("A")]
        [EnumMember]
        Motorway,
		
        /// <summary>
        /// The specific ROAD is a regional, secondary or district road.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("C")]
        [EnumMember]
        Regional,
		
        /// <summary>
        /// The specific ROAD is a pedestrian road.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("P")]
        [EnumMember]
        Pedestrian,
		
        /// <summary>
        /// The specific ROAD is a railway road.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("R")]
        [EnumMember]
        Railway,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A rough path or road, typically one beaten by use rather than constructed.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("TRACK")]
        [EnumMember]
        Track,
		
    }
}
