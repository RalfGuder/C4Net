using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the designation of a military branch for a particular UNIT-TYPE.
    /// </summary>
    [DomId(100000331)]
    [DataContract]
    public enum UnitTypeArmCategoryEnum
    {
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation the management and execution of all military matters not included in strategy or tactics.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ADMIN")]
        [EnumMember]
        Administrative,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of weapon systems against hostile air assets.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIRDEF")]
        [EnumMember]
        AirDefence,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of direct fire weapon systems against armoured vehicles.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AARMOR")]
        [EnumMember]
        AntiArmour,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of tanks or other armoured direct fire weapon systems.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ARMOUR")]
        [EnumMember]
        Armour,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of aircraft capable of performing a variety of battlespace functions, including reconnaissance, air operations, and tactical lift.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("AV")]
        [EnumMember]
        Aviation,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is major construction, demolition, and extensive camouflage projects.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ENG")]
        [EnumMember]
        Engineer,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the detection, identification, field evaluation, rendering-safe, recovery and final disposal of unexploded explosive ordnance.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("EOD")]
        [EnumMember]
        ExplosiveOrdnanceDisposal,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of tube artillery in support of manoeuvre units.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("FA")]
        [EnumMember]
        FieldArtillery,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of fire, coordinated with the manoeuvre of forces, to destroy neutralize or suppress the enemy.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("FIRSPT")]
        [EnumMember]
        FireSupport,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of non-mechanised or lorry-(truck-)borne infantry.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("INF")]
        [EnumMember]
        Infantry,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is to achieve information superiority by affecting a hostile's information, information-based processes and information systems, while defending one's own information, information-based processes and information systems.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("INFWAR")]
        [EnumMember]
        InformationWarfare,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the provision of landing support services.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("LNDSPT")]
        [EnumMember]
        LandingSupport,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the provision of law enforcement services.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("LAWENF")]
        [EnumMember]
        LawEnforcement,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the planning and support of the movement and maintenance of forces.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("LOG")]
        [EnumMember]
        Logistics,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the repair and maintenance of equipment.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MAINT")]
        [EnumMember]
        Maintenance,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of forces in the battlespace through movement in combination with fire, or fire potential, to achieve a position of advantage in respect to the enemy in order to accomplish the mission.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("MANOV")]
        [EnumMember]
        Manoeuvre,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the provision of medical and dental services and the evacuation of casualties.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("MEDCL")]
        [EnumMember]
        Medical,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the processing of information concerning foreign nations, hostile or potentially hostile forces or elements, or areas of actual or potential operations.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("MILINT")]
        [EnumMember]
        MilitaryIntelligence,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of surface-based missiles to fire at surface targets.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("MSL")]
        [EnumMember]
        MissileSurfaceToSurface,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is chemical, biological, radiological, or nuclear materiel defence.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("CBRN")]
        [EnumMember]
        Nbc,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is to obtain, by visual observation or other detection methods, information about the activities and resources of an enemy or potential enemy; or to secure data concerning the meteorological, hydrographic, or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("RECCE")]
        [EnumMember]
        Reconnaissance,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the provision of communications bearer systems.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("SIG")]
        [EnumMember]
        Signal,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the provision of all material and items used in the equipping, supporting and maintaining of military forces.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("SUPPLY")]
        [EnumMember]
        Supply,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the provision of transport for assets.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("TRNPTN")]
        [EnumMember]
        Transportation,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is maintenance of a state of law and order prevailing within a nation.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("ISFRCE")]
        [EnumMember]
        InternalSecurityForces,
		
        /// <summary>
        /// A UNIT-TYPE equipped with armoured vehicles whose principal designation is the employment of direct fire weapon systems against armoured vehicles.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("ARMANT")]
        [EnumMember]
        ArmouredAntiArmour,
		
        /// <summary>
        /// A UNIT-TYPE whose designation indicates employment of a mix of fixed wing, rotary wing and/or VSTOL aircraft.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("AVACOM")]
        [EnumMember]
        AviationComposite,
		
        /// <summary>
        /// A UNIT-TYPE whose designation indicates employment of fixed-wing assets in the air regime.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("AVAFW")]
        [EnumMember]
        AviationFixedWing,
		
        /// <summary>
        /// A UNIT-TYPE whose designation indicates employment of rotary-wing assets in the air regime.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("AVARW")]
        [EnumMember]
        AviationRotaryWing,
		
        /// <summary>
        /// A UNIT-TYPE whose designation indicates employment of vertical/short takeoff and landing assets in the air regime.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("AVAVST")]
        [EnumMember]
        AviationVstol,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is to provide staff and communication equipment to set up a command and control element.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("HQSIGS")]
        [EnumMember]
        HeadquartersAndSignals,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is to provide staff to man a command and control element.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("HQSTF")]
        [EnumMember]
        HeadquartersStaff,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the provision of transport for assets and the distribution of supplies.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("TRSSUP")]
        [EnumMember]
        TransportationAndSupply,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of large guns, cannon or ordnance in support of manoeuvre units.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("ARTLRY")]
        [EnumMember]
        Artillery,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of rockets in support of manoeuvre units.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("ROCKET")]
        [EnumMember]
        Rocket,
		
        /// <summary>
        /// A UNIT-TYPE whose principal designation is the employment of surface-based missiles to fire at air targets.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("MSLSTA")]
        [EnumMember]
        MissileSurfaceToAir,
		
    }
}
