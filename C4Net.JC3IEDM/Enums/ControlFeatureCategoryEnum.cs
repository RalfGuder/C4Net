using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CONTROL-FEATURE.
    /// </summary>
    [DomId(100000127)]
    [DataContract]
    public enum ControlFeatureCategoryEnum
    {
		
        /// <summary>
        /// A CONTROL-FEATURE that is the prescribed course to be travelled from a specific point of origin to a specific destination.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ROUTE")]
        [EnumMember]
        Route,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A CONTROL-FEATURE that reserves airspace for specific airspace users, restricts the action of airspace users, controls the actions of specific airspace users, and/or requires airspace users to accomplish specific actions.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ACM")]
        [EnumMember]
        AirspaceControlMeans,
		
        /// <summary>
        /// A portion of a route usually without an intermediate stop, as defined by two consecutive significant points.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("RTESEG")]
        [EnumMember]
        RouteSegment,
		
        /// <summary>
        /// A CONTROL-FEATURE that specifies approach directional details for takeoff and landing.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("APPRDR")]
        [EnumMember]
        ApproachDirection,
		
    }
}
