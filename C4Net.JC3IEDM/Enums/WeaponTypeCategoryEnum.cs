using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of WEAPON-TYPE.
    /// </summary>
    [DomId(100000342)]
    [DataContract]
    public enum WeaponTypeCategoryEnum
    {
		
        /// <summary>
        /// A weapon specifically designed for the engagement of aircraft.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AD")]
        [EnumMember]
        AirDefence,
		
        /// <summary>
        /// A weapon specifically designed for the engagement of armoured vehicles.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AT")]
        [EnumMember]
        AntiTank,
		
        /// <summary>
        /// A weapon for firing projectiles, having a heavy metal tube installed on a carriage or mounting.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CANNON")]
        [EnumMember]
        Cannon,
		
        /// <summary>
        /// Artillery that is self-propelled or towed for use in the field in support of manoeuvre forces.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("FA")]
        [EnumMember]
        FieldArtillery,
		
        /// <summary>
        /// A system designed to launch one or more powered guided objects at a target.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MISSYS")]
        [EnumMember]
        MissileSystem,
		
        /// <summary>
        /// A portable, muzzle-loading cannon used to fire shells at low velocities, short ranges, and high trajectories.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MORTAR")]
        [EnumMember]
        Mortar,
		
        /// <summary>
        /// A system designed to launch one or more powered unguided objects at a target.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("RCKART")]
        [EnumMember]
        RocketArtillery,
		
        /// <summary>
        /// Individual portable weapon for defensive purposes.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SMARMS")]
        [EnumMember]
        SmallArms,
		
        /// <summary>
        /// An armoured vehicle whose principal weapon is a direct fire gun optimised for the destruction of armoured vehicles.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("TANK")]
        [EnumMember]
        Tank,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A weapon specifically designed for the engagement of submarines.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ANTSUB")]
        [EnumMember]
        AntiSubmarine,
		
    }
}
