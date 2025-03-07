using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes the command and control classification of an ORGANISATION-TYPE.
    /// </summary>
    [DomId(100004184)]
    [DataContract]
    public enum OrganisationTypeCommandAndControlCategoryEnum
    {
		
        /// <summary>
        /// The ORGANISATION-TYPE is a command post.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CP")]
        [EnumMember]
        CommandPost,
		
        /// <summary>
        /// The ORGANISATION-TYPE is a coordination centre.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CC")]
        [EnumMember]
        CoordinationCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE is a headquarters.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("HQ")]
        [EnumMember]
        Headquarters,
		
        /// <summary>
        /// The ORGANISATION-TYPE is an operations centre.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("OC")]
        [EnumMember]
        OperationsCentre,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1874/4.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ARCNTC")]
        [EnumMember]
        AirControlCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE from which aircraft and air warning functions of combat air operations are directed, controlled, and executed. It is the senior agency of the air force component commander from which command and control of air operations are coordinated with other components and services.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("AIROPC")]
        [EnumMember]
        AirOperationsCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE of a tactical air control system collocated with a corps headquarters or an appropriate land force headquarters, which coordinates and directs close air support and other tactical air support.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("AROPCC")]
        [EnumMember]
        AirOperationsCoordinationCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE of a tactical air control system collocated with a corps headquarters or an appropriate land force headquarters, which coordinates and directs close air support and other tactical air support.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ARSOPC")]
        [EnumMember]
        AirSupportOperationsCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE that is an Airborne Warning and Control System (AWACS) aircraft that provides all-weather surveillance, command, control and communications needed by commanders of air defence forces.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("AWACS")]
        [EnumMember]
        AirborneWarningAndControlSystem,
		
        /// <summary>
        /// The ORGANISATION-TYPE that is staffed by members of more than one nation, established for planning, directing, and executing combined air operations in support of the combined force commander's operation or campaign objectives.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("CAOC")]
        [EnumMember]
        CombinedAirOperationsCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE that serves as the senior ground radar element of the theatre air control system (TACS). Mission is to detect, identify, and verify airborne targets in assigned area. CRC also provides decentralized execution of air defence and airspace control, provides early warning to air and ground elements and manages subordinate radar units.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("CNTRPC")]
        [EnumMember]
        ControlAndReportingCentre,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1874/4.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("CNTRPP")]
        [EnumMember]
        ControlAndReportingPost,
		
        /// <summary>
        /// The ORGANISATION-TYPE that is the principal air control agency of the U.S. Marine air command and control system responsible for the direction and control of air operations directly supporting the ground combat element. It processes and coordinates requests for immediate air support and coordinates air missions requiring integration with ground forces and other supporting arms.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("DASC")]
        [EnumMember]
        DirectAirSupportCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE that is the principal air control agency of the U.S. Marine air command and control system, operating in an airborne platform responsible for the direction and control of air operations directly supporting the ground combat element.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("DASCAR")]
        [EnumMember]
        DirectAirSupportCentreAirborne,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1395/5.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("FACC")]
        [EnumMember]
        ForwardAirControlParty,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1874/4.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("GRBOPC")]
        [EnumMember]
        GroundBasedAirDefenceOperationsCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE that is the senior U.S. Marine command and control agency providing centralized command for Marine Air Ground Task Forces, and serves as the command post for the aviation combat element (ACE) commander.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("MTACMC")]
        [EnumMember]
        MarineTacticalAirCommandCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE that is under the overall control of the tactical air control centre (afloat) or tactical air command centre, from which aircraft and air warning service functions of tactical air operations in an area of concern are directed.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("MTADRC")]
        [EnumMember]
        MarineTacticalAirDirectionCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE that is the principal air control agency of the U.S. Marine air command and control system responsible for airspace control and management. It provides real-time surveillance, direction, positive control, and navigational assistance for friendly aircraft. It performs real-time direction and control of all anti-air warfare operations, to include manned interceptors and surface-to-air weapons. It is subordinate to the tactical air command centre.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("MTAOPC")]
        [EnumMember]
        MarineTacticalAirOperationsCentre,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1874/4.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("RAPPRC")]
        [EnumMember]
        RecognisedAirPictureProductionCentre,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1874/4.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("SQDOPC")]
        [EnumMember]
        SquadronOperationsCentre,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1874/4.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("SAMOPC")]
        [EnumMember]
        SurfaceToAirMissileOperationsCentre,
		
        /// <summary>
        /// The ORGANISATION-TYPE that is an agency that provides assistance in the submission of pre-planned and immediate air support requests, as well as providing terminal control for supporting aircraft. It is an integral part of each combat unit from division down to battalion level and serves as an air advisor to each manoeuvre unit.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("TACP")]
        [EnumMember]
        TacticalAirControlParty,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1874/4.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("WNGOPC")]
        [EnumMember]
        WingOperationsCentre,
		
        /// <summary>
        /// A physical grouping of those elements of general and special staff concerned with the current tactical operations and the tactical support thereof.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("TACOPC")]
        [EnumMember]
        TacticalOperationsCentre,
		
    }
}
