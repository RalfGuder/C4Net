using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the standard method of deplanement of a specific ACTION-RESOURCE in support of a specific ACTION.
    /// </summary>
    [DomId(100000307)]
    [DataContract]
    public enum ActionAircraftEmploymentDeplanementMethodEnum
    {
		
        /// <summary>
        /// To deplane using rappelling equipment while the aircraft is airborne.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ABSEIL")]
        [EnumMember]
        Abseil,
		
        /// <summary>
        /// To deplane without any mechanical means from an aircraft hovering close to the ground.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("HOVER")]
        [EnumMember]
        Hover,
		
        /// <summary>
        /// To deplane without any mechanical means from a landed aircraft.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LAND")]
        [EnumMember]
        Land,
		
        /// <summary>
        /// To deplane using a rope while the aircraft is airborne.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ROPE")]
        [EnumMember]
        Rope,
		
        /// <summary>
        /// To deplane by using a winch-operated cable while the aircraft is airborne.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("WINCH")]
        [EnumMember]
        Winch,
		
        /// <summary>
        /// To deplane by jumping out of the aircraft while it is airborne and deploy a parachute before reaching the ground.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PARCHT")]
        [EnumMember]
        Parachute,
		
        /// <summary>
        /// To deplane cargo without a parachute from the aircraft while it is airborne by gravitational force.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("GRAVTY")]
        [EnumMember]
        Gravity,
		
        /// <summary>
        /// To deplane from the aircraft while it is airborne with a parachute that will unfold itself automatically after leaving the aircraft.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("PARAUT")]
        [EnumMember]
        ParachuteAutomatic,
		
        /// <summary>
        /// To deplane from the aircraft while it is airborne with a parachute that will pull the cargo out of the aircraft, and then unfold the main parachute.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("PAREXT")]
        [EnumMember]
        ParachuteExtraction,
		
        /// <summary>
        /// To deplane from the aircraft while it is airborne with a parachute that will pull the cargo out of the aircraft.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("PARLAE")]
        [EnumMember]
        ParachuteLowAltitudeExtraction,
		
        /// <summary>
        /// To deplane by jumping out of the aircraft while it is airborne and manually deploy a parachute before reaching the ground.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("PARMAN")]
        [EnumMember]
        ParachuteManual,
		
        /// <summary>
        /// To deplane by jumping out of the aircraft while it is airborne and deploy a paraglider before reaching the ground.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("PARGLD")]
        [EnumMember]
        Paraglider,
		
        /// <summary>
        /// To deplane cargo from the aircraft by dropping it, using a wedge system.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("WEDGE")]
        [EnumMember]
        Wedge,
		
    }
}
