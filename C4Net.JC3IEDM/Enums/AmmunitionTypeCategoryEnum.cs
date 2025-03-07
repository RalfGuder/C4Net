using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of AMMUNITION-TYPE.
    /// </summary>
    [DomId(100004110)]
    [DataContract]
    public enum AmmunitionTypeCategoryEnum
    {
		
        /// <summary>
        /// An air-launched guided missile for use against air targets.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AAMIS")]
        [EnumMember]
        AirToAirMissile,
		
        /// <summary>
        /// A self-propelled airborne munition which is guided automatically, or by remote control, fired from an aircraft at an object on the ground or sea.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ASMIS")]
        [EnumMember]
        AirToSurfaceMissile,
		
        /// <summary>
        /// A guided weapon designed to immobilise or destroy a tank.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ATGDWP")]
        [EnumMember]
        AntiTankGuidedWeapon,
		
        /// <summary>
        /// A case filled with explosive, inflammable material, poison gas, or smoke, etc., dropped from aircraft, or thrown or deposited by hand.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BOMB")]
        [EnumMember]
        Bomb,
		
        /// <summary>
        /// One of a number of small bombs usually contained in a cluster bomb and released in mid-air.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BOMBLT")]
        [EnumMember]
        Bomblet,
		
        /// <summary>
        /// Any charge designed for explosion under water, especially such a charge dropped or catapulted from delivery equipment and used against submarines.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("DPTHCH")]
        [EnumMember]
        DepthCharge,
		
        /// <summary>
        /// An explosive substance.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("EXPLOS")]
        [EnumMember]
        Explosive,
		
        /// <summary>
        /// A munition that is propelled from a barrel and thereafter follows a ballistic trajectory.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("GNSHEL")]
        [EnumMember]
        GunShell,
		
        /// <summary>
        /// An explosive missile, smaller than a bombshell, thrown by hand.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("HNDGRN")]
        [EnumMember]
        HandGrenade,
		
        /// <summary>
        /// A mine designed to cause damage to helicopters.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("MINAHL")]
        [EnumMember]
        MineAntiHelicopter,
		
        /// <summary>
        /// A mine designed to cause casualties to personnel.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("MINAPR")]
        [EnumMember]
        MineAntiPersonnel,
		
        /// <summary>
        /// A mine designed to immobilise or destroy a tank.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("MINAT")]
        [EnumMember]
        MineAntiTank,
		
        /// <summary>
        /// A mine designed to immobilize or destroy a tank. The mine includes an internal or external device arranged to actuate it in case of attempts to deactivate the mine.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MINATA")]
        [EnumMember]
        MineAntiTankWithAntiHandlingDevice,
		
        /// <summary>
        /// It is not possible to determine the type of mine.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MINNKN")]
        [EnumMember]
        MineNotKnown,
		
        /// <summary>
        /// A mine whose appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("MINNOS")]
        [EnumMember]
        MineNotOtherwiseSpecified,
		
        /// <summary>
        /// A mine or mines designed to attack a target obliquely to the targets direction of travel (i.e. in the targets flank or side).
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("MINOFR")]
        [EnumMember]
        MineOffRoute,
		
        /// <summary>
        /// A mine designed to disable armoured vehicles and will allow large areas to be sown with smart mines that should be difficult to neutralize.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("MINWAR")]
        [EnumMember]
        MineWideArea,
		
        /// <summary>
        /// A round fired from a mortar weapon.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MRTRBM")]
        [EnumMember]
        MortarBomb,
		
        /// <summary>
        /// An object capable of being propelled by a force normally from a gun, and continuing in motion by virtue of its kinetic energy.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("PRJNOS")]
        [EnumMember]
        ProjectileNotOtherwiseSpecified,
		
        /// <summary>
        /// A fuse wherein primary initiation occurs by remotely sensing the presence, distance or direction of a target or its associated environment by means of a signal generated by the fuse or emitted by the target, or by detecting a disturbance of a natural field surrounding the target.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("PRXFUS")]
        [EnumMember]
        ProximityFuse,
		
        /// <summary>
        /// A mixture of chemicals which when ignited is capable of reacting exothermically to produce light, heat, smoke, sound or gas, and may also be used to introduce a delay into an explosive train because of its known burning time.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("PYROTC")]
        [EnumMember]
        PyrotechnicDevice,
		
        /// <summary>
        /// A munition that is self-propelled in flight whose trajectory or course whilst in flight cannot be controlled.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("RCKET")]
        [EnumMember]
        Rocket,
		
        /// <summary>
        /// A powered projectile designed for use against people.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("RKTATP")]
        [EnumMember]
        RocketMissileAntiPersonnel,
		
        /// <summary>
        /// A powered projectile designed for use against tanks.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("RKTATT")]
        [EnumMember]
        RocketMissileAntiTank,
		
        /// <summary>
        /// A powered projectile designed for use by heavy launchers.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("RKTHEV")]
        [EnumMember]
        RocketMissileHeavy,
		
        /// <summary>
        /// A powered projectile designed for use by light launchers.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("RKTLGT")]
        [EnumMember]
        RocketMissileLight,
		
        /// <summary>
        /// A powered projectile designed for use by medium launchers.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("RKTMED")]
        [EnumMember]
        RocketMissileMedium,
		
        /// <summary>
        /// An explosive device laid in the water with the intention of damaging or sinking ships or of deterring shipping from entering an area.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("SEAMIN")]
        [EnumMember]
        SeaMine,
		
        /// <summary>
        /// A mine with negative buoyancy, which remains on the seabed. (bottom mine)
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("SEABDM")]
        [EnumMember]
        SeabedMine,
		
        /// <summary>
        /// Ammunition designed for hand held weapons.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("SMAMMO")]
        [EnumMember]
        SmallArmsAmmunition,
		
        /// <summary>
        /// A self-propelled airborne munition which is guided automatically, or by remote control, fired from the ground or vessel at an aircraft or other airborne target.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("SRAMIS")]
        [EnumMember]
        SurfaceToAirMissile,
		
        /// <summary>
        /// A self-propelled airborne munition which is guided automatically, or by remote control, fired from the ground or vessel at an object on the ground or sea.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("SRSMIS")]
        [EnumMember]
        SurfaceToSurfaceMissile,
		
        /// <summary>
        /// Any munition that, to perform its task, separates from a parent munition.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("SUBMUN")]
        [EnumMember]
        Submunition,
		
        /// <summary>
        /// A weapon for destroying ships by rupturing their hulls below the waterline.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("TRPEDO")]
        [EnumMember]
        Torpedo,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A weapon in the form of a pilotless jet aircraft carrying a warhead and capable of flying at low altitudes.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("CRUMSL")]
        [EnumMember]
        CruiseMissile,
		
        /// <summary>
        /// Any mine case in more than a certain depth of water is deep.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("MINDPM")]
        [EnumMember]
        MineDeepMoored,
		
        /// <summary>
        /// A contact or influence-operated mine of positive buoyancy held below the surface by a mooring attached to a sinker or anchor on the bottom.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("MINMOR")]
        [EnumMember]
        MineMoored,
		
        /// <summary>
        /// A mine with negative buoyancy which remains on the seabed with explosive charge of 500kg or greater.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("MINSEG")]
        [EnumMember]
        MineSeabedExplosiveCharge500KgOrGreater,
		
        /// <summary>
        /// A mine with negative buoyancy which remains on the seabed with explosive charge less than 500kg.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("MINSEL")]
        [EnumMember]
        MineSeabedExplosiveChargeLessThan500Kg,
		
        /// <summary>
        /// Any mine case in less than a certain depth of water is shallow.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("MINSHM")]
        [EnumMember]
        MineShallowMoored,
		
        /// <summary>
        /// A missile that homes passively on a radiation source.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("MISATR")]
        [EnumMember]
        MissileAntiRadiation,
		
        /// <summary>
        /// An unmanned self-propelled vehicle whose trajectory or course, while in flight, is controlled.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("MISGUI")]
        [EnumMember]
        MissileGuided,
		
        /// <summary>
        /// An explosive charge that is used to destroy a mine.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("MRTMDC")]
        [EnumMember]
        MaritimeMineDisposalCharge,
		
        /// <summary>
        /// A mine designed to be propelled to its proposed laying position by propulsion equipment like a torpedo. It sinks at the end of its run and then operates like a mine.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("MNMRTM")]
        [EnumMember]
        MineMaritimeMoving,
		
        /// <summary>
        /// The collective description of mines, such as drifting, oscillating, creeping, mobile, rising, homing and bouquet mines.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("MVSEAM")]
        [EnumMember]
        MovingMineSea,
		
        /// <summary>
        /// A self-propelled airborne munition that is guided automatically, or by remote control, fired from an aircraft.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("ALMIS")]
        [EnumMember]
        AirLaunchedMissile,
		
        /// <summary>
        /// An unguided rocket equipped with an explosive warhead.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("RPG")]
        [EnumMember]
        RocketPropelledGrenade,
		
        /// <summary>
        /// A charge shaped so as to concentrate its explosive force in a particular direction.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("SHPCHG")]
        [EnumMember]
        ShapedCharge,
		
    }
}
