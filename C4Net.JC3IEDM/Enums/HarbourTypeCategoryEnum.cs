using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of HARBOUR-TYPE.
    /// </summary>
    [DomId(100004292)]
    [DataContract]
    public enum HarbourTypeCategoryEnum
    {
		
        /// <summary>
        /// A harbour located in the interior portion of a canal or lake that is connected with the sea by a navigable waterway.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CANAL")]
        [EnumMember]
        CanalOrLake,
		
        /// <summary>
        /// A coastal harbour lying behind a man-made breakwater constructed to provide shelter, or supplement inadequate shelter already provided by natural sources.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("COASTB")]
        [EnumMember]
        CoastalBreakwater,
		
        /// <summary>
        /// A coastal harbour sheltered from the wind and sea by virtue of its location within a natural coastal indentation or in the protective lee of an island, cape, reef or other natural barrier.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("COASTN")]
        [EnumMember]
        CoastalNatural,
		
        /// <summary>
        /// A coastal harbour, the waters of which are constrained by locks or other mechanical devices in order to provide sufficient water to float vessels at all stages of the tide.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("COASTT")]
        [EnumMember]
        CoastalTideGates,
		
        /// <summary>
        /// A harbour located in the interior portion of a river, canal or lake that is not connected with the sea by a navigable waterway.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("INLAND")]
        [EnumMember]
        InlandWaterWay,
		
        /// <summary>
        /// A port, which has no artificial barrier to provide shelter from the wind, sea and swell.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("OPENRD")]
        [EnumMember]
        OpenRoadstead,
		
        /// <summary>
        /// A river harbour in which slips for vessels have been excavated in the banks, obliquely or at right angles to the axis of the stream.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("RIVERB")]
        [EnumMember]
        RiverBasins,
		
        /// <summary>
        /// A harbour located on a river, the waters of which are not retained by any artificial means. The facilities may consist of quays or wharves parallel to the banks of the stream, or piers or jetties, which extend into the stream.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("RIVERN")]
        [EnumMember]
        RiverNatural,
		
        /// <summary>
        /// A river harbour, the waters of which are constrained by locks or other mechanical devices in order to provide sufficient water to float vessels at all stages of the tide.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("RIVERT")]
        [EnumMember]
        RiverTideGates,
		
    }
}
