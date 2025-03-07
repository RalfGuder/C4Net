using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of FIRE-CAPABILITY.
    /// </summary>
    [DomId(100004356)]
    [DataContract]
    public enum FireCapabilityCategoryEnum
    {
		
        /// <summary>
        /// The specific value implies that a specific FIRE-CAPABILITY involves firing from aircraft at targets in the air.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIRAIR")]
        [EnumMember]
        AirToAir,
		
        /// <summary>
        /// The specific value implies that a specific FIRE-CAPABILITY involves firing from aircraft at targets on the ground.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIRGRD")]
        [EnumMember]
        AirToGround,
		
        /// <summary>
        /// The specific value implies that a specific FIRE-CAPABILITY involves firing from aircraft at targets at sea.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AIRSEA")]
        [EnumMember]
        AirToSea,
		
        /// <summary>
        /// The specific value implies that a specific FIRE-CAPABILITY involves firing from the ground to an airborne target.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("GRDAIR")]
        [EnumMember]
        GroundToAir,
		
        /// <summary>
        /// The specific value implies that a specific FIRE-CAPABILITY involves surface firing.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("GRDGRD")]
        [EnumMember]
        GroundToGround,
		
        /// <summary>
        /// The specific value implies that a specific FIRE-CAPABILITY involves firing from the ground to targets at sea.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("GRDSEA")]
        [EnumMember]
        GroundToSea,
		
        /// <summary>
        /// The specific value implies that a specific FIRE-CAPABILITY involves firing from a vessel to airborne targets.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("SEAAIR")]
        [EnumMember]
        SeaToAir,
		
        /// <summary>
        /// The specific value implies that a specific FIRE-CAPABILITY involves firing from a vessel to targets on the ground.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SEAGRD")]
        [EnumMember]
        SeaToGround,
		
        /// <summary>
        /// The specific value implies that a specific FIRE-CAPABILITY involves firing from a vessel to targets at sea.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("SEASEA")]
        [EnumMember]
        SeaToSea,
		
    }
}
