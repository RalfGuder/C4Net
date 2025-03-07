using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of WEAPON-TYPE.
    /// </summary>
    [DomId(100000343)]
    [DataContract]
    public enum WeaponTypeSubcategoryEnum
    {
		
        /// <summary>
        /// An automatic cannon, usually linked to remote sensors, used primarily in the role of air defence.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ADCAN")]
        [EnumMember]
        AirDefenceAutomaticCannon,
		
        /// <summary>
        /// A gun used primarily in the role of air defence.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ADGUN")]
        [EnumMember]
        AirDefenceGun,
		
        /// <summary>
        /// A heavy gun used primarily in the role of air defence.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ADHEV")]
        [EnumMember]
        AirDefenceGunHeavy,
		
        /// <summary>
        /// A light gun used primarily in the role of air defence.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ADLGT")]
        [EnumMember]
        AirDefenceGunLight,
		
        /// <summary>
        /// A medium gun used primarily in the role of air defence.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ADMED")]
        [EnumMember]
        AirDefenceGunMedium,
		
        /// <summary>
        /// A structural device designed to support and hold an air defence missile in position for firing.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ADMIS")]
        [EnumMember]
        AirDefenceMissileLauncher,
		
        /// <summary>
        /// A structural device designed to support and hold a long range air defence missile in position for firing.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ADMLLR")]
        [EnumMember]
        AirDefenceMissileLauncherLongRange,
		
        /// <summary>
        /// A structural device designed to support and hold a medium range air defence missile in position for firing.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ADMLMR")]
        [EnumMember]
        AirDefenceMissileLauncherMediumRange,
		
        /// <summary>
        /// A structural device designed to support and hold a short range air defence missile in position for firing.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("ADMLSR")]
        [EnumMember]
        AirDefenceMissileLauncherShortRange,
		
        /// <summary>
        /// A structural device designed to support and hold a theatre air defence missile in position for firing.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ADMLT")]
        [EnumMember]
        AirDefenceMissileLauncherTheatre,
		
        /// <summary>
        /// An anti-aircraft gun, normally belt fed, employed in the air defence role.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("AAMGUN")]
        [EnumMember]
        AntiAircraftMachineGun,
		
        /// <summary>
        /// A structural device designed to support and hold an anti-ship surface missile in position for firing.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ASSML")]
        [EnumMember]
        AntiShipSurfaceMissileLauncher,
		
        /// <summary>
        /// A structural device designed to support and hold a grenade in position for firing.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("GRENLN")]
        [EnumMember]
        GrenadeLauncher,
		
        /// <summary>
        /// A heavy structural device designed to support and hold a grenade in position for firing.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("GRLNHV")]
        [EnumMember]
        GrenadeLauncherHeavy,
		
        /// <summary>
        /// A light structural device designed to support and hold a grenade in position for firing.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("GRLNLT")]
        [EnumMember]
        GrenadeLauncherLight,
		
        /// <summary>
        /// A medium structural device designed to support and hold a grenade in position for firing.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("GRLNMD")]
        [EnumMember]
        GrenadeLauncherMedium,
		
        /// <summary>
        /// A gun designed to destroy tanks.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("ATGUN")]
        [EnumMember]
        AntiTankGun,
		
        /// <summary>
        /// A heavy gun designed to destroy tanks.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("ATGNHV")]
        [EnumMember]
        AntiTankGunHeavy,
		
        /// <summary>
        /// A light gun designed to destroy tanks.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("ATGNLT")]
        [EnumMember]
        AntiTankGunLight,
		
        /// <summary>
        /// A medium gun designed to destroy tanks.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("ATGNMD")]
        [EnumMember]
        AntiTankGunMedium,
		
        /// <summary>
        /// A structural device designed to support and hold an anti-tank missile in position for firing.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("ATMIS")]
        [EnumMember]
        AntiTankMissileLauncher,
		
        /// <summary>
        /// A heavy structural device designed to support and hold an anti-tank missile in position for firing.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("ATMLHV")]
        [EnumMember]
        AntiTankMissileLauncherHeavy,
		
        /// <summary>
        /// A light structural device designed to support and hold an anti-tank missile in position for firing.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("ATMLLT")]
        [EnumMember]
        AntiTankMissileLauncherLight,
		
        /// <summary>
        /// A medium structural device designed to support and hold an anti-tank missile in position for firing.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("ATMLMD")]
        [EnumMember]
        AntiTankMissileLauncherMedium,
		
        /// <summary>
        /// A structural device designed to support and hold an anti-tank rocket in position for firing.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("ATROC")]
        [EnumMember]
        AntiTankRocketLauncher,
		
        /// <summary>
        /// A heavy structural device designed to support and hold an anti-tank rocket in position for firing.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("ATRLHV")]
        [EnumMember]
        AntiTankRocketLauncherHeavy,
		
        /// <summary>
        /// A light structural device designed to support and hold an anti-tank rocket in position for firing.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("ATRLLT")]
        [EnumMember]
        AntiTankRocketLauncherLight,
		
        /// <summary>
        /// A medium structural device designed to support and hold an anti-tank rocket in position for firing.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("ATRLMD")]
        [EnumMember]
        AntiTankRocketLauncherMedium,
		
        /// <summary>
        /// An armoured vehicle used for transporting an infantry team and able to support it by the use of weapons.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("AIFV")]
        [EnumMember]
        ArmouredInfantryFightingCombatVehicle,
		
        /// <summary>
        /// A lightly armoured, highly mobile vehicle, serving as the main reconnaissance in infantry and airborne operations.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("ARV")]
        [EnumMember]
        ArmouredReconnaissanceVehicle,
		
        /// <summary>
        /// Field artillery cannon with a calibre normally between 161mm and 210mm.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("ARTHEV")]
        [EnumMember]
        ArtilleryHeavy,
		
        /// <summary>
        /// Field artillery cannon with a calibre of 120mm and less.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("ARTLGT")]
        [EnumMember]
        ArtilleryLight,
		
        /// <summary>
        /// Field artillery cannon with a calibre between 121 and 160mm.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("ARTMED")]
        [EnumMember]
        ArtilleryMedium,
		
        /// <summary>
        /// A structural device designed to support and hold a long range ballistic missile in position for firing.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("BMLLR")]
        [EnumMember]
        BallisticMissileLauncherLongRange,
		
        /// <summary>
        /// A structural device designed to support and hold a medium range ballistic missile in position for firing.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("BMLMR")]
        [EnumMember]
        BallisticMissileLauncherMediumRange,
		
        /// <summary>
        /// A structural device designed to support and hold a short range ballistic missile in position for firing.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("BMLSR")]
        [EnumMember]
        BallisticMissileLauncherShortRange,
		
        /// <summary>
        /// An armoured fighting vehicle of more than 50 metric tons which, as its primary function, is designed to close with the enemy and engage their armour and infantry with direct fire.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("BTNKHE")]
        [EnumMember]
        BattleTankHeavy,
		
        /// <summary>
        /// An armoured fighting vehicle of less than 20 metric tons which, as its primary function, is designed to close with the enemy and engage their armour and infantry with direct fire.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("BTNKLI")]
        [EnumMember]
        BattleTankLight,
		
        /// <summary>
        /// An armoured fighting vehicle of more than 20 and less than 50 metric tons which, as its primary function, is designed to close with the enemy and engage their armour and infantry with direct fire.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("BTNKME")]
        [EnumMember]
        BattleTankMedium,
		
        /// <summary>
        /// A cannon with a relatively low angle of fire, having a high muzzle velocity with a tube length of 30 calibres or more that delivers fire on a target using the target itself as a point of aim for either the weapon or the director.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("DFGN")]
        [EnumMember]
        DirectFireGun,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("DFGNHV")]
        [EnumMember]
        DirectFireGunHeavy,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("DFGNLT")]
        [EnumMember]
        DirectFireGunLight,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("DFGNMD")]
        [EnumMember]
        DirectFireGunMedium,
		
        /// <summary>
        /// Guns inside a fortress.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("FFART")]
        [EnumMember]
        FixedFortificationArtillery,
		
        /// <summary>
        /// A weapon that projects incendiary fuel and has provision for ignition of this fuel.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("FLAMET")]
        [EnumMember]
        FlameThrower,
		
        /// <summary>
        /// A structural device designed to support and hold a guided cruise missile in position for firing.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("GCML")]
        [EnumMember]
        GuidedCruiseMissileLauncher,
		
        /// <summary>
        /// A cannon with a relatively long barrel, operating with a relatively low angle of fire, and having a high muzzle velocity.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("GUN")]
        [EnumMember]
        Gun,
		
        /// <summary>
        /// A cannon that has the capability of both low-angle and high-angles of fire.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("GUNHOW")]
        [EnumMember]
        GunHowitzer,
		
        /// <summary>
        /// A cannon that combines certain characteristics of guns and mortars. Normally a cannon with a tube length of 20 to 30 calibres; however, the tube length can exceed 30 calibres and still be considered a howitzer when the high angle firing zoning solution permits range overlap between charges.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("HOWIT")]
        [EnumMember]
        Howitzer,
		
        /// <summary>
        /// A heavy cannon that combines certain characteristics of guns and mortars. Normally a cannon with a tube length of 20 to 30 calibres; however, the tube length can exceed 30 calibres and still be considered a howitzer when the high angle firing zoning solution permits range overlap between charges.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("HOWTHV")]
        [EnumMember]
        HowitzerHeavy,
		
        /// <summary>
        /// A light cannon that combines certain characteristics of guns and mortars. Normally a cannon with a tube length of 20 to 30 calibres; however, the tube length can exceed 30 calibres and still be considered a howitzer when the high angle firing zoning solution permits range overlap between charges.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("HOWTLT")]
        [EnumMember]
        HowitzerLight,
		
        /// <summary>
        /// A medium cannon that combines certain characteristics of guns and mortars. Normally a cannon with a tube length of 20 to 30 calibres; however, the tube length can exceed 30 calibres and still be considered a howitzer when the high angle firing zoning solution permits range overlap between charges.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("HOWTMD")]
        [EnumMember]
        HowitzerMedium,
		
        /// <summary>
        /// An automatic gun giving continuous fire.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("MACGUN")]
        [EnumMember]
        MachineGun,
		
        /// <summary>
        /// A heavy automatic gun giving continuous fire.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("MACGHV")]
        [EnumMember]
        MachineGunHeavy,
		
        /// <summary>
        /// A light automatic gun giving continuous fire.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("MACGLT")]
        [EnumMember]
        MachineGunLight,
		
        /// <summary>
        /// A towed or vehicle-mounted, indirect fire weapon with either a rifled or smooth bore. It usually has a shorter range than a howitzer, employs a higher angle of fire, and its calibre is usually between 108mm and 150mm.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("MRTHEV")]
        [EnumMember]
        MortarHeavy,
		
        /// <summary>
        /// A man-portable, muzzle-loading, indirect fire weapon with either a rifled or smooth bore. It usually has a shorter range than a howitzer, employs a higher angle of fire, and its calibre is usually 60mm or smaller.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("MRTLGT")]
        [EnumMember]
        MortarLight,
		
        /// <summary>
        /// A man-portable, muzzle-loading, indirect fire weapon with either a rifled or smooth bore. It usually has a shorter range than a howitzer, employs a higher angle of fire, and its calibre is usually between 61mm and 107mm.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("MRTMED")]
        [EnumMember]
        MortarMedium,
		
        /// <summary>
        /// An indirect fire weapon, usually with a shorter range than a howitzer, employs a higher angle of fire, and its calibre is 151mm or larger.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("MRTVHV")]
        [EnumMember]
        MortarVeryHeavy,
		
        /// <summary>
        /// A structural device designed to support and hold multiple rockets in position for firing.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("MLRS")]
        [EnumMember]
        MultipleRocketLauncher,
		
        /// <summary>
        /// A heavy structural device designed to support and hold multiple rockets in position for firing.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("MLRSHV")]
        [EnumMember]
        MultipleRocketLauncherHeavy,
		
        /// <summary>
        /// A light structural device designed to support and hold multiple rockets in position for firing.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("MLRSLT")]
        [EnumMember]
        MultipleRocketLauncherLight,
		
        /// <summary>
        /// A medium structural device designed to support and hold multiple rockets in position for firing.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("MLRSMD")]
        [EnumMember]
        MultipleRocketLauncherMedium,
		
        /// <summary>
        /// A small hand-held firearm.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("PISTOL")]
        [EnumMember]
        PistolRevolver,
		
        /// <summary>
        /// A weapon capable of being fired from either a ground mount or from a vehicle, and capable of destroying tanks.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("RECGUN")]
        [EnumMember]
        RecoillessGun,
		
        /// <summary>
        /// A mobile armoured vehicle providing firepower and crew protection for reconnaissance activities.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("RECTNK")]
        [EnumMember]
        ReconnaissanceTank,
		
        /// <summary>
        /// A firearm that has a rifled bore designed to be fired from the shoulder.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("RIFLE")]
        [EnumMember]
        Rifle,
		
        /// <summary>
        /// A smooth-bore gun for firing small pellets at short range.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("SHOTGU")]
        [EnumMember]
        Shotgun,
		
        /// <summary>
        /// A lightweight automatic or semiautomatic gun.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("SUBMAC")]
        [EnumMember]
        SubmachineGun,
		
        /// <summary>
        /// A structural device designed to support and hold a surface to surface missile in position for firing.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("SSMIS")]
        [EnumMember]
        SurfaceToSurfaceMissileLauncher,
		
        /// <summary>
        /// A structural device designed to support and hold a long range surface to surface missile in position for firing.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("SSMLLR")]
        [EnumMember]
        SurfaceToSurfaceMissileLauncherLongRange,
		
        /// <summary>
        /// A structural device designed to support and hold a medium range surface to surface missile in position for firing.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("SSMLMR")]
        [EnumMember]
        SurfaceToSurfaceMissileLauncherMediumRange,
		
        /// <summary>
        /// A structural device designed to support and hold a short range surface to surface missile in position for firing.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("SSMLSR")]
        [EnumMember]
        SurfaceToSurfaceMissileLauncherShortRange,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A structural device designed to support and hold a rocket in position for firing.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("SRCLAU")]
        [EnumMember]
        SingleRocketLauncher,
		
        /// <summary>
        /// A heavy structural device designed to support and hold a rocket in position for firing.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("SRKLHV")]
        [EnumMember]
        SingleRocketLauncherHeavy,
		
        /// <summary>
        /// A light structural device designed to support and hold a rocket in position for firing.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("SRKLLG")]
        [EnumMember]
        SingleRocketLauncherLight,
		
        /// <summary>
        /// A medium structural device designed to support and hold a rocket in position for firing.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("SRKLMD")]
        [EnumMember]
        SingleRocketLauncherMedium,
		
        /// <summary>
        /// An anti-aircraft weapon employed in the air defence role.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("AAARTR")]
        [EnumMember]
        AntiAircraftArtillery,
		
        /// <summary>
        /// A structural device designed to support and hold an anti-tank grenade in position for firing.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("ATGRLC")]
        [EnumMember]
        AntiTankGrenadeLauncher,
		
        /// <summary>
        /// A heavy structural device designed to support and hold an anti-tank grenade in position for firing.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("ATGRLH")]
        [EnumMember]
        AntiTankGrenadeLauncherHeavy,
		
        /// <summary>
        /// A light structural device designed to support and hold an anti-tank grenade in position for firing.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("ATGRLL")]
        [EnumMember]
        AntiTankGrenadeLauncherLight,
		
        /// <summary>
        /// A medium structural device designed to support and hold an anti-tank grenade in position for firing.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("ATGRLM")]
        [EnumMember]
        AntiTankGrenadeLauncherMedium,
		
        /// <summary>
        /// Heavy artillery, calibre of 211 MM or larger, for use in the field in support of manoeuvre forces.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("ARTVHV")]
        [EnumMember]
        ArtilleryVeryHeavy,
		
        /// <summary>
        /// A cannon, with a relatively long barrel, operating with a relatively low angle of fire, and having a high muzzle velocity.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("ASSGUN")]
        [EnumMember]
        AssaultGun,
		
        /// <summary>
        /// An anti-aircraft weapon system employed, as a last resort, in the air defence role.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("CINWPS")]
        [EnumMember]
        CloseInWeaponSystem,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1650/6.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("CRWPUN")]
        [EnumMember]
        CrewServedWeaponUnknownType,
		
        /// <summary>
        /// A small hand-held firearm capable of giving continuous fire.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("MCHPTL")]
        [EnumMember]
        MachinePistol,
		
        /// <summary>
        /// A firearm used in an assault role, that has a rifled bore designed to be fired from the shoulder.
        /// </summary>
        [DomValIx(1000099)]
        [StringValue("RFLASS")]
        [EnumMember]
        RifleAssault,
		
        /// <summary>
        /// A short firearm, usually a rifle that has a rifled bore designed to be fired from the shoulder.
        /// </summary>
        [DomValIx(1000100)]
        [StringValue("RFLCRB")]
        [EnumMember]
        RifleCarbine,
		
        /// <summary>
        /// A structural device designed to support and hold a surface to air missile in position for firing.
        /// </summary>
        [DomValIx(1000101)]
        [StringValue("SAMISL")]
        [EnumMember]
        SurfaceToAirMissileLauncher,
		
        /// <summary>
        /// A tracked vehicle that relies on speed and firepower and has minimum armoured protection, usually armed with either anti-tank guided missile launcher, 80-90 MM gun or a recoilless rifle.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("TKDTRY")]
        [EnumMember]
        TankDestroyer,
		
        /// <summary>
        /// Heavy, turret mounted, tank gun, calibre over 120 MM, for use in the field against tanks.
        /// </summary>
        [DomValIx(1000103)]
        [StringValue("TKGUNH")]
        [EnumMember]
        TankGunHeavy,
		
        /// <summary>
        /// Light, turret mounted, tank gun, calibre under 90 MM, for use in the field against tanks.
        /// </summary>
        [DomValIx(1000104)]
        [StringValue("TKGUNL")]
        [EnumMember]
        TankGunLight,
		
        /// <summary>
        /// Medium, turret mounted, tank gun, calibre between 90 and 120 MM, for use in the field against tanks.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("TKGUNM")]
        [EnumMember]
        TankGunMedium,
		
        /// <summary>
        /// Flat cutting edge of a knife, saw or other tool or weapon.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("BLADE")]
        [EnumMember]
        Blade,
		
    }
}
