using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the MOBILITY-CAPABILITY that is being quantified.
    /// </summary>
    [DomId(100004358)]
    [DataContract]
    public enum MobilityCapabilityDescriptorEnum
    {
		
        /// <summary>
        /// The highest elevation above sea-level at which a specified aircraft can fly.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MALTID")]
        [EnumMember]
        MaximumAltitude,
		
        /// <summary>
        /// The one-dimensional linear measurement that represents the greatest depth at which a vessel can operate.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MDEPTH")]
        [EnumMember]
        MaximumDepth,
		
        /// <summary>
        /// The one-dimensional linear measurement denoting the greatest depth a vehicle can traverse.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MAXFOR")]
        [EnumMember]
        MaximumFordingDepth,
		
        /// <summary>
        /// The numeric value representing the gradient of the steepest slope that can be climbed or descended head-on.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MOBGRA")]
        [EnumMember]
        MaximumObstacleGradientAngle,
		
        /// <summary>
        /// The longest distance that can be achieved.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MRANGE")]
        [EnumMember]
        MaximumRange,
		
        /// <summary>
        /// The numeric value representing the gradient of the steepest slope that can be traversed in a direction perpendicular to that slope.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MSSLOP")]
        [EnumMember]
        MaximumSideSlopeAngle,
		
        /// <summary>
        /// The highest velocity in any direction that can be achieved for a prolonged period of time.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MSPEED")]
        [EnumMember]
        MaximumSpeed,
		
        /// <summary>
        /// The one-dimensional linear measurement that represents the largest horizontal distance of any aperture that can be successfully navigated.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MTRENC")]
        [EnumMember]
        MaximumTrenchWidth,
		
        /// <summary>
        /// The specific value that represents the military class number indicating the relationship between the load bearing capacity of a terrain feature or man-made structure and the effect produced by tracked vehicles in one-way traffic.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("MLCOWT")]
        [EnumMember]
        MilitaryLoadClassificationOneWayTracked,
		
        /// <summary>
        /// The specific value that represents the military class number indicating the relationship between the load bearing capacity of a terrain feature or man-made structure and the effect produced by wheeled vehicles in one-way traffic.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("MLCOWW")]
        [EnumMember]
        MilitaryLoadClassificationOneWayWheeled,
		
        /// <summary>
        /// The specific value that represents the military class number indicating the relationship between the load bearing capacity of a terrain feature or man-made structure and the effect produced by tracked vehicles.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("MLCTRK")]
        [EnumMember]
        MilitaryLoadClassificationTracked,
		
        /// <summary>
        /// The specific value that represents the military class number indicating the relationship between the load bearing capacity of a terrain feature or man-made structure and the effect produced by tracked vehicles in two-way traffic.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("MLCTWT")]
        [EnumMember]
        MilitaryLoadClassificationTwoWayTracked,
		
        /// <summary>
        /// The specific value that represents the military class number indicating the relationship between the load bearing capacity of a terrain feature or man-made structure and the effect produced by wheeled vehicles in two-way traffic.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MLCTWW")]
        [EnumMember]
        MilitaryLoadClassificationTwoWayWheeled,
		
        /// <summary>
        /// The specific value that represents the military class number indicating the relationship between the load bearing capacity of a terrain feature or man-made structure and the effect produced by wheeled vehicles.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MLCWHL")]
        [EnumMember]
        MilitaryLoadClassificationWheeled,
		
        /// <summary>
        /// The one-dimensional linear measurement that represents the shallowest depth a vessel can navigate.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("NDEPTH")]
        [EnumMember]
        MinimumDepth,
		
        /// <summary>
        /// The shortest stretch of unblocked and flat terrain or water required by an aircraft for it to be able to land.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("MNLAND")]
        [EnumMember]
        MinimumLandingDistance,
		
        /// <summary>
        /// The shortest distance that can be achieved.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("NRANGE")]
        [EnumMember]
        MinimumRange,
		
        /// <summary>
        /// The slowest speed at which a piece of equipment can operate and remain functional.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MNMSPD")]
        [EnumMember]
        MinimumSpeed,
		
        /// <summary>
        /// The shortest stretch of unblocked and flat terrain or water required by an aircraft for it to be able to take off.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("MNTOFF")]
        [EnumMember]
        MinimumTakeOffDistance,
		
        /// <summary>
        /// The average distance that can be achieved which is considered normal for planning purposes.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("PRANGE")]
        [EnumMember]
        PlanningRange,
		
        /// <summary>
        /// The average speed that can be achieved which is considered normal for planning purposes.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("PSPEED")]
        [EnumMember]
        PlanningSpeed,
		
    }
}
