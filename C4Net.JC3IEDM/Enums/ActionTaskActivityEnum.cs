using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of activity prescribed by the ACTION-TASK.
    /// </summary>
    [DomId(100000280)]
    [DataContract]
    public enum ActionTaskActivityEnum
    {
		
        /// <summary>
        /// To move towards an objective in some form of tactical formation. This is a transitional phase between operations which may or may not result in contact with the enemy.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ADVANC")]
        [EnumMember]
        Advance,
		
        /// <summary>
        /// To conduct a surprise attack by fire or other destructive means, from concealed positions on a moving or temporarily halted force or group of personnel.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AMBUSH")]
        [EnumMember]
        Ambush,
		
        /// <summary>
        /// To mount an operation launched from the sea by naval and land forces against a hostile, or potentially hostile shore.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AMPH")]
        [EnumMember]
        AmphibiousOperation,
		
        /// <summary>
        /// To mount an operation in which assault forces (combat, combat service, and combat service support), using the firepower, mobility, and total integration of helicopter assets, maneuver on the battlefield under the control of the ground or air manoeuvre commander to engage and destroy enemy forces or to seize and hold key terrain.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ARASLT")]
        [EnumMember]
        AirAssault,
		
        /// <summary>
        /// In an airborne operation, a phase beginning with delivery by air of the assault echelon of the force into the objective area and extending through attack of assault objectives and consolidation of the initial airhead.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ARBNAS")]
        [EnumMember]
        AirborneAssault,
		
        /// <summary>
        /// To join together multiple objects in the same area.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ASSMBL")]
        [EnumMember]
        Assemble,
		
        /// <summary>
        /// To conduct a type of offensive action characterised by coordinated employment of firepower and manoeuvre to close with and destroy or capture the enemy.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ATTACK")]
        [EnumMember]
        AttackNotOtherwiseSpecified,
		
        /// <summary>
        /// To miss or take evading action.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("AVOID")]
        [EnumMember]
        Avoid,
		
        /// <summary>
        /// To attain prescribed strength of units and prescribed levels of vehicles, equipment, stores and supplies.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("BLDUP")]
        [EnumMember]
        BuildUp,
		
        /// <summary>
        /// To deny the enemy access to an area or to prevent his advance in a direction or along an avenue of approach.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("BLOCK")]
        [EnumMember]
        Block,
		
        /// <summary>
        /// To break through or secure a passage through an enemy defence, obstacle, minefield, or fortification.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("BREACH")]
        [EnumMember]
        Breach,
		
        /// <summary>
        /// To provide a security element whose primary task is to move ahead of the main body and protect the main force by fighting to gain time, whilst also observing and reporting information.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("CADVGD")]
        [EnumMember]
        ConstituteAnAdvanceGuard,
		
        /// <summary>
        /// To form the force during an obstacle crossing which seizes or controls ground in order to permit the continuous embarkation, landing or crossing of troops or materiel and to provide manoeuvre space.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("CBRHDF")]
        [EnumMember]
        ConstituteBridgeheadForce,
		
        /// <summary>
        /// To form the force during an obstacle crossing which is tasked with the continuation of the operation.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("CBRKOF")]
        [EnumMember]
        ConstituteBreakoutForce,
		
        /// <summary>
        /// To provide a security element whose primary task is to protect the main force by fighting on the designated flank to gain time, whilst also observing and reporting information.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("CFLKGD")]
        [EnumMember]
        ConstituteAFlankGuard,
		
        /// <summary>
        /// To form the force during an obstacle crossing which provides fire and other support to the bridgehead force.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("CINPLF")]
        [EnumMember]
        ConstituteInPlaceForce,
		
        /// <summary>
        /// To constitute the main force for a specific operation.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("CMAINB")]
        [EnumMember]
        ConstituteAMainBody,
		
        /// <summary>
        /// To build, dig or create an object.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("CONSTR")]
        [EnumMember]
        Construct,
		
        /// <summary>
        /// To constitute a force which may be committed into combat only on the order of the commander of the ORGANISATION who so designated the reserve force.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("CRESRV")]
        [EnumMember]
        ConstituteAReserve,
		
        /// <summary>
        /// To break off an action.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("DISENG")]
        [EnumMember]
        Disengage,
		
        /// <summary>
        /// To move over a FEATURE or FACILITY.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("CROSS")]
        [EnumMember]
        Cross,
		
        /// <summary>
        /// To provide a security element whose primary task is to move (or remain) at the rear of the main body and protect the main force by fighting to gain time, whilst also observing and reporting information.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("CRRGD")]
        [EnumMember]
        ConstituteARearGuard,
		
        /// <summary>
        /// To mount an offensive operation in which an attack by a part or all of a defending force is made against an enemy attacking force, for such specific purposes as regaining ground lost, cutting off or destroying lead enemy units, and with the general objective of regaining the initiative and denying the enemy the attainment of his goal or purpose in attacking.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("CTRATK")]
        [EnumMember]
        CounterAttack,
		
        /// <summary>
        /// To deliver fire for the purpose of destroying or neutralizing indirect fire weapons systems.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("CTRBYF")]
        [EnumMember]
        CounterBatteryFire,
		
        /// <summary>
        /// To diminish the effectiveness of the enemy to the extent that he is unable to participate further in the battle or at least cannot fulfil his intention.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("DEFEAT")]
        [EnumMember]
        Defeat,
		
        /// <summary>
        /// To hold a defined object against an enemy attack; to halt or ward off an attack in order to defeat or destroy the enemy.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("DEFEND")]
        [EnumMember]
        Defend,
		
        /// <summary>
        /// To slow the momentum of the enemy by conducting an operation in which the force under pressure trades time for space. The aim is to inflict the maximum damage on the enemy without becoming decisively engaged.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("DELAY")]
        [EnumMember]
        Delay,
		
        /// <summary>
        /// To prevent access by blocking, disrupting, dislocating and/or bringing fire to bear.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("DENY")]
        [EnumMember]
        Deny,
		
        /// <summary>
        /// To move and adopt tactical formation or dispersal in a specific location.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("DEPLOY")]
        [EnumMember]
        Deploy,
		
        /// <summary>
        /// To physically render an enemy force combat-ineffective or damaging a target so that it cannot function as intended, nor be restored to a usable condition without being entirely rebuilt.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("DESTRY")]
        [EnumMember]
        Destroy,
		
        /// <summary>
        /// To draw the attention and forces of an enemy from the point of the principal operation; an attack, alarm, or feint which diverts attention.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("DIVERT")]
        [EnumMember]
        Divert,
		
        /// <summary>
        /// To conduct a type of offensive action characterised by pre-planned coordinated employment of firepower and manoeuvre to close with and destroy or capture the enemy.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("DLBATK")]
        [EnumMember]
        AttackDeliberate,
		
        /// <summary>
        /// To conduct an offensive manoeuvre in which the main attacking force passes around or over the enemy's principal defensive positions with the aim of securing objectives to the enemy's rear.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("ENVLP")]
        [EnumMember]
        Envelop,
		
        /// <summary>
        /// To accompany and protect another force or convoy.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("ESCRT")]
        [EnumMember]
        Escort,
		
        /// <summary>
        /// To clear materiel and personnel from a given locality.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("EVACT")]
        [EnumMember]
        Evacuate,
		
        /// <summary>
        /// To take advantage of a successful attack by mounting an offensive operation to follow-up and harass a dislocated enemy with the aim of further disorganising him in depth. This may provide the opportunity to capture ground which was not part of the objective of the original attack.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("EXPLT")]
        [EnumMember]
        Exploit,
		
        /// <summary>
        /// An operation in which an incoming force attacks through a unit (outgoing force).that is in contact with the enemy.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("CNFPSL")]
        [EnumMember]
        ConductForwardPassageOfLines,
		
        /// <summary>
        /// To protect the main body by fighting to gain time while also observing and reporting information.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("GUARD")]
        [EnumMember]
        Guard,
		
        /// <summary>
        /// To mount an operation or fire plan designed to curtail movement and, by threat of losses, to lower the morale of enemy troops.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("HARASS")]
        [EnumMember]
        Harass,
		
        /// <summary>
        /// To occupy an area in which an ORGANISATION or FACILITY may conceal itself before operations or before moving into battle positions.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("HIDE")]
        [EnumMember]
        Hide,
		
        /// <summary>
        /// To determine the identification of a particular class of object, recognising the friendly or enemy character of an object, or detecting the presence of an object.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("IDENT")]
        [EnumMember]
        Identify,
		
        /// <summary>
        /// To provide battlespace lighting by employing searchlight or pyrotechnic illuminants using diffusion or reflection.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("ILLUMN")]
        [EnumMember]
        Illuminate,
		
        /// <summary>
        /// To move a force, broken down as individuals or small groups, over, through or around enemy positions with the aim of avoiding detection.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("INFILT")]
        [EnumMember]
        Infiltrate,
		
        /// <summary>
        /// To conduct Electronic Warfare Support operations with a view to searching, locating, recording and analysing radiated electromagnetic energy for the purposes of supporting an operation.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("INTCEP")]
        [EnumMember]
        Intercept,
		
        /// <summary>
        /// To divert, disrupt, delay, or destroy the enemy's surface military potential before it can be used effectively against friendly forces.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("INTDCT")]
        [EnumMember]
        Interdict,
		
        /// <summary>
        /// To deliberately radiate, re-radiate or reflect electromagnetic energy with the object of impairing the use of electronic devices, equipment or systems being used by the enemy.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("JAM")]
        [EnumMember]
        Jam,
		
        /// <summary>
        /// To adopt a defended formation as a temporary defensive measure in areas of low or moderate risk of combat (usually applied to Coy/Sqn level).
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("LEAGR")]
        [EnumMember]
        Leaguer,
		
        /// <summary>
        /// To transport assets using non-organic means, by sea, land or air.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("LIFT")]
        [EnumMember]
        Lift,
		
        /// <summary>
        /// To establish the position or presence of an object.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("LOCATE")]
        [EnumMember]
        Locate,
		
        /// <summary>
        /// To make visible (by the use of light/IR/laser/arty) an object in order to allow its identification by another object (usually as a precursor to the use of direct fire weapons).
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("MARK")]
        [EnumMember]
        Mark,
		
        /// <summary>
        /// To move any person who is wounded, injured or ill to/between medical treatment facilities.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("MEDEVC")]
        [EnumMember]
        MedicalEvacuation,
		
        /// <summary>
        /// To change position from one location to another.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("MOVE")]
        [EnumMember]
        Move,
		
        /// <summary>
        /// To provide continuous view, and the potential for reports on the activity of an ACTION-OBJECTIVE.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("OBSRV")]
        [EnumMember]
        Observe,
		
        /// <summary>
        /// To move onto an objective, key terrain, or other manmade or natural terrain area without opposition and control that entire area.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("OCCUPY")]
        [EnumMember]
        Occupy,
		
        /// <summary>
        /// To gather information or to carry out a destructive, harassing, mopping-up, or security mission.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("PATROL")]
        [EnumMember]
        Patrol,
		
        /// <summary>
        /// To create a detailed formulation of a programme of action.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("PLAN")]
        [EnumMember]
        Plan,
		
        /// <summary>
        /// To establish certain conditions.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("PREPR")]
        [EnumMember]
        Prepare,
		
        /// <summary>
        /// To continue offensive operations designed to catch or cut off a hostile force attempting to escape, with the aim of destroying it. Typically, contact is maintained and risk taken to harass relentlessly, thereby turning the pursuit into a rout.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("PURSUE")]
        [EnumMember]
        Pursue,
		
        /// <summary>
        /// To attain prescribed strength of units and prescribed levels of vehicles, equipment, stores and supplies. The process will only take place after a unit/formation combat effectiveness has been reduced.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("RECONS")]
        [EnumMember]
        Reconstitute,
		
        /// <summary>
        /// To conduct a mission to obtain by visual operations or other detection methods information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographic or geographic characteristics of a particular area.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("RECCE")]
        [EnumMember]
        Reconnaissance,
		
        /// <summary>
        /// To conduct an offensive operation designed to discover and/or test the enemy's strength, or to obtain other information.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("RECCEF")]
        [EnumMember]
        ReconnaissanceInForce,
		
        /// <summary>
        /// To retrieve any lost, incapacitated or captured object.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("RECOVR")]
        [EnumMember]
        Recover,
		
        /// <summary>
        /// To transfer a unit, an individual, or supplies deployed in one area to another area, or to another location within the area, for the purpose of further employment.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("REDEPL")]
        [EnumMember]
        Redeploy,
		
        /// <summary>
        /// To move or make a force available to another commander for the purpose of supplementing the in-place forces.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("REINF")]
        [EnumMember]
        Reinforce,
		
        /// <summary>
        /// To change a task organisation for a particular operation. (Normally takes place before an operation). This includes the transfer of authority.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("REORG")]
        [EnumMember]
        Reorganise,
		
        /// <summary>
        /// To restore an item to serviceable condition through correction of a specific failure or unserviceable condition.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("REPAIR")]
        [EnumMember]
        Repair,
		
        /// <summary>
        /// To impose a specified period of inactivity on an ORGANISATION that is out of contact with the enemy.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("REST")]
        [EnumMember]
        Rest,
		
        /// <summary>
        /// To replenish stocks in order to maintain the required levels of supply.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("RESUPL")]
        [EnumMember]
        Resupply,
		
        /// <summary>
        /// To move a force out of contact with the enemy with the expectation of no further significant contact.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("RETIRE")]
        [EnumMember]
        Retire,
		
        /// <summary>
        /// To achieve a pre-arranged meeting at a given time and place.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("RNDZVS")]
        [EnumMember]
        Rendezvous,
		
        /// <summary>
        /// An operation when a force (outgoing force) effecting a movement to the rear passes through the sector of a unit (incoming force).
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("CNRPSL")]
        [EnumMember]
        ConductRearwardPassageOfLines,
		
        /// <summary>
        /// To operate as a security element whose primary task is to observe, identify and report information, and which only fights in self-protection.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("SCREEN")]
        [EnumMember]
        Screen,
		
        /// <summary>
        /// To gain possession of a position or terrain feature, with or without force, and to make such disposition as will prevent, as far as possible, its destruction or loss by enemy action.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("SECURE")]
        [EnumMember]
        Secure,
		
        /// <summary>
        /// To prepare or establish a FACILITY, ORGANISATION or FEATURE.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("SETUP")]
        [EnumMember]
        SetUp,
		
        /// <summary>
        /// To provide fire which neutralizes or temporarily degrades the capabilities of enemy forces within a specific area. This makes no assumptions as to enemy casualties; it may be a transitory effect.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("SUPPRS")]
        [EnumMember]
        Suppress,
		
        /// <summary>
        /// To disengage a force in contact from an enemy force.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("WITHDR")]
        [EnumMember]
        Withdraw,
		
        /// <summary>
        /// To rest a unit after it has been in action. Some reconstitution may take place as well.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("RECUPR")]
        [EnumMember]
        Recuperate,
		
        /// <summary>
        /// To conduct a type of offensive action using firepower and manoeuvre to close with and destroy or capture the enemy. Planning and coordination will normally be limited, as the attack will be carried out at short notice.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("HASTY")]
        [EnumMember]
        AttackHasty,
		
        /// <summary>
        /// To manoeuvre around an obstacle, position, or enemy force in order to maintain the momentum of advance.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("BYPASS")]
        [EnumMember]
        Bypass,
		
        /// <summary>
        /// To deliver fire on a target preparatory to an assault.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("PREFIR")]
        [EnumMember]
        PreparatoryFire,
		
        /// <summary>
        /// To enable the movement of a number of specific units.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("CNRSVC")]
        [EnumMember]
        ConductRoadService,
		
        /// <summary>
        /// To employ measures designed to mislead the enemy by manipulation, distortion, or falsification of evidence to induce him to react in a manner prejudicial to his interests.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("DECEIV")]
        [EnumMember]
        Deceive,
		
        /// <summary>
        /// To aid, protect, complement or sustain any other object.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("SUPPRT")]
        [EnumMember]
        Support,
		
        /// <summary>
        /// To menace the enemy by manoeuvre or action.
        /// </summary>
        [DomValIx(1000096)]
        [StringValue("THREAT")]
        [EnumMember]
        Threaten,
		
        /// <summary>
        /// To move assets using any means by sea, land or air to a specified objective.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("TRANS")]
        [EnumMember]
        Transport,
		
        /// <summary>
        /// To destroy structures, facilities, or materiel by use of fire, water, explosives, mechanical, or other means.
        /// </summary>
        [DomValIx(1000098)]
        [StringValue("DEMO")]
        [EnumMember]
        Demolish,
		
        /// <summary>
        /// To detect the presence and location of a target in sufficient detail to permit identification.
        /// </summary>
        [DomValIx(1000099)]
        [StringValue("ACQUIR")]
        [EnumMember]
        Acquire,
		
        /// <summary>
        /// To break apart an enemy's formation and tempo, to interrupt the enemy's timetable, to cause premature commitment of forces, and/or splinter their attack using integrated fire planning and obstacle effect.
        /// </summary>
        [DomValIx(1000101)]
        [StringValue("DISRPT")]
        [EnumMember]
        Disrupt,
		
        /// <summary>
        /// To prevent the enemy from moving any part of his force from a specific location for a specific period of time.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("FIX")]
        [EnumMember]
        Fix,
		
        /// <summary>
        /// To liquidate the remnants of enemy resistance in an area that has been surrounded or isolated, or through which other units have passed without eliminating all active resistance.
        /// </summary>
        [DomValIx(1000103)]
        [StringValue("MOPUP")]
        [EnumMember]
        MopUp,
		
        /// <summary>
        /// To fill again.
        /// </summary>
        [DomValIx(1000104)]
        [StringValue("REFILL")]
        [EnumMember]
        Refill,
		
        /// <summary>
        /// To take on more fuel.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("REFUEL")]
        [EnumMember]
        Refuel,
		
        /// <summary>
        /// To use aircraft, surface craft, submarines, specialized rescue teams and equipment to search for and rescue personnel in distress on land or at sea.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("SAR")]
        [EnumMember]
        SearchAndRescue,
		
        /// <summary>
        /// To provide information about enemy air activity that poses immediate threat to friendly forces and monitors and directs the use of airspace.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("AWACS")]
        [EnumMember]
        AirWarningAirControl,
		
        /// <summary>
        /// To position stocks to meet future requirements.
        /// </summary>
        [DomValIx(1000108)]
        [StringValue("DUMPNG")]
        [EnumMember]
        Dumping,
		
        /// <summary>
        /// To provide the party at the site which is technically responsible for the demolition.
        /// </summary>
        [DomValIx(1000109)]
        [StringValue("DEMFRP")]
        [EnumMember]
        ConstituteADemolitionFiringParty,
		
        /// <summary>
        /// To provide a local force positioned to ensure that a target is not captured by an enemy before orders are given for its demolition and before the demolition has been successfully fired.
        /// </summary>
        [DomValIx(1000110)]
        [StringValue("DEMGRD")]
        [EnumMember]
        ConstituteADemolitionGuard,
		
        /// <summary>
        /// To deploy strips of frequency-cut metal foil, wire or metalized glass fibre to reflect electromagnetic energy, usually dropped from aircraft or expelled from shells or rockets as a radar countermeasure.
        /// </summary>
        [DomValIx(1000111)]
        [StringValue("CHAFF")]
        [EnumMember]
        ReleaseChaff,
		
        /// <summary>
        /// To conduct the principal attack or effort into which the commander throws the full weight of the offensive power at his disposal. An attack directed against the chief objective of the campaign or battle.
        /// </summary>
        [DomValIx(1000114)]
        [StringValue("ATTMN")]
        [EnumMember]
        AttackMain,
		
        /// <summary>
        /// To conduct an offensive operation carried out in conjunction with a main attack and designed to achieve one or more of the following: a. deceive the enemy; b. destroy or pin down enemy forces which could interfere with the main attack; c. control ground whose occupation by the enemy will hinder the main attack; or d. force the enemy to commit reserves prematurely or in an indecisive area.
        /// </summary>
        [DomValIx(1000115)]
        [StringValue("ATTSPT")]
        [EnumMember]
        AttackSupporting,
		
        /// <summary>
        /// To restrict operations to a narrow zone by use of existing or reinforcing obstacles or by fire or bombing. (Army)--A tactical task used to restrict operations to a narrow zone by the use of obstacles, fires, and/or unit manoeuvring or positioning.
        /// </summary>
        [DomValIx(1000116)]
        [StringValue("CANLSE")]
        [EnumMember]
        Canalise,
		
        /// <summary>
        /// To take possession of an object, normally by force; it frequently involves movement as a preliminary phase.
        /// </summary>
        [DomValIx(1000117)]
        [StringValue("CAPTUR")]
        [EnumMember]
        Capture,
		
        /// <summary>
        /// To stop, hold, or surround the forces of the enemy or to cause the enemy to centre activity on a given front and to prevent his withdrawing any part of his forces for use elsewhere. (Army)--A tactical task to restrict enemy movement.
        /// </summary>
        [DomValIx(1000118)]
        [StringValue("CONTAN")]
        [EnumMember]
        Contain,
		
        /// <summary>
        /// To deny the enemy his goal in attacking through fire into an engagement area to defeat or destroy an enemy force.
        /// </summary>
        [DomValIx(1000119)]
        [StringValue("CTRFIR")]
        [EnumMember]
        CounterAttackByFire,
		
        /// <summary>
        /// To operate as a force apart to protect the main body by fighting to gain time while also observing and reporting information and preventing enemy ground observation of an direct fire against the main body.
        /// </summary>
        [DomValIx(1000120)]
        [StringValue("COVER")]
        [EnumMember]
        Cover,
		
        /// <summary>
        /// To prevent an enemy force from following the intended course.
        /// </summary>
        [DomValIx(1000121)]
        [StringValue("DEFLCT")]
        [EnumMember]
        Deflect,
		
        /// <summary>
        /// To determine a position using electromagnetic data.
        /// </summary>
        [DomValIx(1000122)]
        [StringValue("FIXELM")]
        [EnumMember]
        FixElectromagnetic,
		
        /// <summary>
        /// To determine a position using acoustic data.
        /// </summary>
        [DomValIx(1000123)]
        [StringValue("FIXACO")]
        [EnumMember]
        FixAcoustic,
		
        /// <summary>
        /// To determine a position using electro-optical data.
        /// </summary>
        [DomValIx(1000124)]
        [StringValue("FIXELO")]
        [EnumMember]
        FixElectroOptical,
		
        /// <summary>
        /// To operate as a committed force that follows a force conducting an offensive operation, and is prepared to continue the mission of the force it is following when that force is fixed, attrited, or otherwise unable to continue. Such a force is not a reserve but is committed to accomplish specified tasks.
        /// </summary>
        [DomValIx(1000125)]
        [StringValue("FOLASS")]
        [EnumMember]
        FollowAndAssume,
		
        /// <summary>
        /// To operate as a committed force that follows and supports the mission accomplishment of a force conducting an offensive operation. Such a force is not a reserve, but is committed to accomplish specified tasks.
        /// </summary>
        [DomValIx(1000126)]
        [StringValue("FOLSPT")]
        [EnumMember]
        FollowAndSupport,
		
        /// <summary>
        /// To seal off (both physically and psychologically) an enemy from its sources of support, to deny an enemy freedom of movement, and prevent an enemy unit from having contact with other enemy forces. An enemy must not be allowed sanctuary within its present position.
        /// </summary>
        [DomValIx(1000128)]
        [StringValue("ISOLAT")]
        [EnumMember]
        Isolate,
		
        /// <summary>
        /// To emplace or deploy one or more mines.
        /// </summary>
        [DomValIx(1000129)]
        [StringValue("MINLAY")]
        [EnumMember]
        MineLaying,
		
        /// <summary>
        /// To break through the enemy's defence or to disrupt the enemy's defensive systems.
        /// </summary>
        [DomValIx(1000130)]
        [StringValue("PENTRT")]
        [EnumMember]
        Penetrate,
		
        /// <summary>
        /// To conduct an operation in which, by direction of higher authority, all or part of a unit is replaced in an area by the incoming unit. The responsibilities of the replaced elements for the mission and the assigned zone of operations are transferred to the incoming unit. The incoming unit continues the operation as ordered.
        /// </summary>
        [DomValIx(1000131)]
        [StringValue("RLFPLC")]
        [EnumMember]
        ReliefInPlace,
		
        /// <summary>
        /// To occupy and hold a terrain feature to ensure it is free of enemy occupation or use.
        /// </summary>
        [DomValIx(1000132)]
        [StringValue("RETAIN")]
        [EnumMember]
        Retain,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000133)]
        [StringValue("SERCH")]
        [EnumMember]
        Search,
		
        /// <summary>
        /// To clear a designated area and obtain control of it.
        /// </summary>
        [DomValIx(1000134)]
        [StringValue("SEIZE")]
        [EnumMember]
        Seize,
		
        /// <summary>
        /// To compel an enemy force to move from an avenue of approach or movement corridor to another.
        /// </summary>
        [DomValIx(1000135)]
        [StringValue("TURN")]
        [EnumMember]
        Turn,
		
        /// <summary>
        /// To disengage from the enemy when the enemy has sufficient contact with friendly forces to interfere with the withdrawal.
        /// </summary>
        [DomValIx(1000136)]
        [StringValue("WDRPRS")]
        [EnumMember]
        WithdrawUnderPressure,
		
        /// <summary>
        /// To collect samples for testing for biological hazards.
        /// </summary>
        [DomValIx(1000137)]
        [StringValue("BIOSMP")]
        [EnumMember]
        BiologicalSampling,
		
        /// <summary>
        /// To collect samples for testing for chemical hazards.
        /// </summary>
        [DomValIx(1000138)]
        [StringValue("CHMSMP")]
        [EnumMember]
        ChemicalSampling,
		
        /// <summary>
        /// To collect samples for testing for nuclear hazards.
        /// </summary>
        [DomValIx(1000140)]
        [StringValue("NUCSMP")]
        [EnumMember]
        NuclearSampling,
		
        /// <summary>
        /// To deprive a person of his property as forfeited by public authority.
        /// </summary>
        [DomValIx(1000141)]
        [StringValue("CNFSTE")]
        [EnumMember]
        Confiscate,
		
        /// <summary>
        /// To seize and detain a person under authority of the law.
        /// </summary>
        [DomValIx(1000143)]
        [StringValue("ARRLGL")]
        [EnumMember]
        ArrestLegal,
		
        /// <summary>
        /// To stop or check the motion, progress, growth, or spread of something.
        /// </summary>
        [DomValIx(1000144)]
        [StringValue("ARROBS")]
        [EnumMember]
        ArrestObstruct,
		
        /// <summary>
        /// To clear the air to gain either temporary or permanent air superiority or control in a given sector.
        /// </summary>
        [DomValIx(1000145)]
        [StringValue("CLRAIR")]
        [EnumMember]
        ClearAir,
		
        /// <summary>
        /// To remove all enemy forces from a specific location, area, or zone.
        /// </summary>
        [DomValIx(1000146)]
        [StringValue("CLRLND")]
        [EnumMember]
        ClearLandCombat,
		
        /// <summary>
        /// To totally eliminate or neutralize an obstacle; a task that is usually performed by follow-on engineers and is not done under fire.
        /// </summary>
        [DomValIx(1000147)]
        [StringValue("CLROBS")]
        [EnumMember]
        ClearObstacle,
		
        /// <summary>
        /// To eliminate transmissions on a tactical radio net in order to allow a higher precedence transmission to occur.
        /// </summary>
        [DomValIx(1000148)]
        [StringValue("CLRRAD")]
        [EnumMember]
        ClearRadioNet,
		
        /// <summary>
        /// To make safe or non-toxic an object contaminated with a chemical agent.
        /// </summary>
        [DomValIx(1000149)]
        [StringValue("NTRCHM")]
        [EnumMember]
        NeutralizeChemical,
		
        /// <summary>
        /// To render ineffective or unusable in military operations.
        /// </summary>
        [DomValIx(1000150)]
        [StringValue("NTRCOM")]
        [EnumMember]
        NeutralizeCombat,
		
        /// <summary>
        /// To render bombs, mines, missiles and booby traps into a safe state.
        /// </summary>
        [DomValIx(1000151)]
        [StringValue("NTREXP")]
        [EnumMember]
        NeutralizeExplosive,
		
        /// <summary>
        /// To observe an activity in an official capacity with a view of providing evidence.
        /// </summary>
        [DomValIx(1000152)]
        [StringValue("WITNES")]
        [EnumMember]
        Witness,
		
        /// <summary>
        /// To divide or dispense in portions.
        /// </summary>
        [DomValIx(1000153)]
        [StringValue("DSTRBT")]
        [EnumMember]
        Distribute,
		
        /// <summary>
        /// To send forth; publish; put into circulation a non-fictional essay, especially one included with others in a newspaper, magazine, or journal.
        /// </summary>
        [DomValIx(1000154)]
        [StringValue("ISSMDA")]
        [EnumMember]
        IssueMediaArticle,
		
        /// <summary>
        /// To send forth; publish; put into circulation any document published on a media that provides a factual record or report.
        /// </summary>
        [DomValIx(1000155)]
        [StringValue("ISSMDD")]
        [EnumMember]
        IssueMediaDocumentary,
		
        /// <summary>
        /// To send forth; publish; put into circulation an official statement issued to media for information.
        /// </summary>
        [DomValIx(1000156)]
        [StringValue("ISSPRS")]
        [EnumMember]
        IssuePressRelease,
		
        /// <summary>
        /// To organise a meeting for discussion, esp. a regular one held by an association or organisation.
        /// </summary>
        [DomValIx(1000157)]
        [StringValue("ORGCNF")]
        [EnumMember]
        OrganiseConference,
		
        /// <summary>
        /// To organise a conversation between a reporter etc. and a person of public interest, used as a basis of a broadcast or publication.
        /// </summary>
        [DomValIx(1000158)]
        [StringValue("ORGMED")]
        [EnumMember]
        OrganiseMediaInterview,
		
        /// <summary>
        /// To organise a refreshing or entertaining activity.
        /// </summary>
        [DomValIx(1000159)]
        [StringValue("ORGRCR")]
        [EnumMember]
        OrganiseRecreationalActivities,
		
        /// <summary>
        /// To organise any social gathering, esp. one organised by a club or congregation.
        /// </summary>
        [DomValIx(1000160)]
        [StringValue("ORGSCL")]
        [EnumMember]
        OrganiseSocialEvents,
		
        /// <summary>
        /// To organise any game or competitive activity, esp. an outdoor one involving physical exertion.
        /// </summary>
        [DomValIx(1000161)]
        [StringValue("ORGSPT")]
        [EnumMember]
        OrganiseSportingEvents,
		
        /// <summary>
        /// To provide advice or supplies for cultivating the soil and rearing animals.
        /// </summary>
        [DomValIx(1000162)]
        [StringValue("PRVAGR")]
        [EnumMember]
        ProvideAgriculturalSupport,
		
        /// <summary>
        /// To provide (1) sleeping accommodation or (2) mattress and bedclothes.
        /// </summary>
        [DomValIx(1000163)]
        [StringValue("PRVBDD")]
        [EnumMember]
        ProvideBedding,
		
        /// <summary>
        /// To provide temporary accommodation of various kinds, usually consisting of huts or tents, for detainees, homeless persons, and other emergency use.
        /// </summary>
        [DomValIx(1000164)]
        [StringValue("PRVCMP")]
        [EnumMember]
        ProvideCamps,
		
        /// <summary>
        /// To provide labour and materiel for construction of facilities.
        /// </summary>
        [DomValIx(1000165)]
        [StringValue("PRVCNS")]
        [EnumMember]
        ProvideConstructionServices,
		
        /// <summary>
        /// To provide labour and materiel for the educational process.
        /// </summary>
        [DomValIx(1000166)]
        [StringValue("PRVEDU")]
        [EnumMember]
        ProvideEducationServices,
		
        /// <summary>
        /// To provide labour and materiel for maintaining the general health and welfare.
        /// </summary>
        [DomValIx(1000167)]
        [StringValue("PRVHLT")]
        [EnumMember]
        ProvideHealthcareServices,
		
        /// <summary>
        /// To provide basic facilities such as roads, bridges, and sewers.
        /// </summary>
        [DomValIx(1000168)]
        [StringValue("PRVINF")]
        [EnumMember]
        ProvideInfrastructure,
		
        /// <summary>
        /// To provide labour and materiel for laundering of clothes or linens.
        /// </summary>
        [DomValIx(1000169)]
        [StringValue("PRVLND")]
        [EnumMember]
        ProvideLaundryServices,
		
        /// <summary>
        /// To provide labour and materiel to restore objects to unimpaired condition.
        /// </summary>
        [DomValIx(1000170)]
        [StringValue("PRVRPR")]
        [EnumMember]
        ProvideRepairServices,
		
        /// <summary>
        /// To provide labour and materiel to assure safety of personnel and facilities.
        /// </summary>
        [DomValIx(1000171)]
        [StringValue("PRVSCY")]
        [EnumMember]
        ProvideSecurityServices,
		
        /// <summary>
        /// To provide housing.
        /// </summary>
        [DomValIx(1000172)]
        [StringValue("PRVSHL")]
        [EnumMember]
        ProvideShelter,
		
        /// <summary>
        /// To make generally known a non-fictional essay, esp. one included with others in a newspaper, magazine, journal, etc.
        /// </summary>
        [DomValIx(1000173)]
        [StringValue("PUBMDA")]
        [EnumMember]
        PublishMediaArticle,
		
        /// <summary>
        /// To make generally known any document published on a media that provides a factual record or report.
        /// </summary>
        [DomValIx(1000174)]
        [StringValue("PUBMDD")]
        [EnumMember]
        PublishMediaDocumentary,
		
        /// <summary>
        /// To make generally known an official statement issued to media for information.
        /// </summary>
        [DomValIx(1000175)]
        [StringValue("PUBPRS")]
        [EnumMember]
        PublishPressRelease,
		
        /// <summary>
        /// Air action against hostile targets which are in close proximity to friendly forces and which require detailed integration of each air mission with the fire and movement of those forces.
        /// </summary>
        [DomValIx(1000176)]
        [StringValue("CLARSP")]
        [EnumMember]
        CloseAirSupport,
		
        /// <summary>
        /// Air action, which consist of the collection of information of intelligence from the air or through the use of airborne sensors.
        /// </summary>
        [DomValIx(1000177)]
        [StringValue("TCARRC")]
        [EnumMember]
        TacticalAirReconnaissance,
		
        /// <summary>
        /// To conduct air operations to destroy, neutralize, or delay the enemy's military potential on the battlefield before it can be brought to bear effectively against friendly forces at such distance from friendly forces that detailed integration of each air mission with the fire and movement of friendly forces is not required.
        /// </summary>
        [DomValIx(1000178)]
        [StringValue("ARINTR")]
        [EnumMember]
        AirInterdictionBattlefield,
		
        /// <summary>
        /// To produce chemical smoke to act as a form of cover to protect ongoing operations.
        /// </summary>
        [DomValIx(1000179)]
        [StringValue("GENCHS")]
        [EnumMember]
        GenerateChemicalSmoke,
		
        /// <summary>
        /// To provide services to keep equipment in condition to carry out its function.
        /// </summary>
        [DomValIx(1000180)]
        [StringValue("MAINTN")]
        [EnumMember]
        Maintain,
		
        /// <summary>
        /// To buy whatever is needed to fulfil a certain action.
        /// </summary>
        [DomValIx(1000181)]
        [StringValue("PROCUR")]
        [EnumMember]
        Procure,
		
        /// <summary>
        /// To provide room for receiving people, esp. a place to live or lodgings.
        /// </summary>
        [DomValIx(1000182)]
        [StringValue("PRVACC")]
        [EnumMember]
        ProvideAccommodation,
		
        /// <summary>
        /// To provide purification making any person, object, or area safe by absorbing, destroying, neutralizing, making harmless, or removing, chemical or biological agents, or by removing radioactive material clinging to or around it.
        /// </summary>
        [DomValIx(1000183)]
        [StringValue("DECSVC")]
        [EnumMember]
        DecontaminationServices,
		
        /// <summary>
        /// Civil and military assistance rendered in peace, crisis and war by a host nation to Allied forces and NATO organisations which are located on or in transit through the host nation's territory. The basis of such assistance is commitments arising from the NATO Alliance or from bilateral or multilateral agreements concluded between the host nation, NATO organisations and (the) nation(s) having forces operating on the host nation's territory.
        /// </summary>
        [DomValIx(1000184)]
        [StringValue("HONASP")]
        [EnumMember]
        HostNationSupport,
		
        /// <summary>
        /// To provide services for storage.
        /// </summary>
        [DomValIx(1000185)]
        [StringValue("PRVSTG")]
        [EnumMember]
        ProvideStorageServices,
		
        /// <summary>
        /// To provide movement of cargo from one ship or train or container to another for further shipment.
        /// </summary>
        [DomValIx(1000186)]
        [StringValue("PRVTRS")]
        [EnumMember]
        ProvideTranshipmentServices,
		
        /// <summary>
        /// To conduct an attack wherein a force attacks, or threatens to attack, a target other than the main target for the purpose of drawing enemy defences away from the main effort.
        /// </summary>
        [DomValIx(1000187)]
        [StringValue("ATTDVR")]
        [EnumMember]
        AttackDiversion,
		
        /// <summary>
        /// To organise and strengthen a newly captured position so that it can be used against the enemy.
        /// </summary>
        [DomValIx(1000188)]
        [StringValue("CNSLDT")]
        [EnumMember]
        ConsolidateAPosition,
		
        /// <summary>
        /// To maintain or retain possession by force, a position or area in defensive operations.
        /// </summary>
        [DomValIx(1000189)]
        [StringValue("HLDDEF")]
        [EnumMember]
        HoldDefensive,
		
        /// <summary>
        /// To exert sufficient pressure in an offensive operation by means of combat power, to prevent the movement or redeployment of enemy forces.
        /// </summary>
        [DomValIx(1000190)]
        [StringValue("HLDOFF")]
        [EnumMember]
        HoldOffensive,
		
        /// <summary>
        /// To provide air traffic control service to flights in control areas.
        /// </summary>
        [DomValIx(1000191)]
        [StringValue("ARTCTL")]
        [EnumMember]
        AirTrafficControl,
		
        /// <summary>
        /// To keep combat equipped aircraft airborne and prepared for immediate action. Airborne alert is designed to reduce reaction time and to increase the survivability factor.
        /// </summary>
        [DomValIx(1000192)]
        [StringValue("MNTAIR")]
        [EnumMember]
        MaintainOnCallAirborneAlert,
		
        /// <summary>
        /// To keep aircraft on the ground/runway/deck fully serviced and armed, with combat crews in readiness to take off within a specified short period of time after receipt of a mission order.
        /// </summary>
        [DomValIx(1000193)]
        [StringValue("MNTGRD")]
        [EnumMember]
        MaintainOnCallGroundAlert,
		
        /// <summary>
        /// To conduct warfare that includes the launch of naval and land forces from sea against a hostile, or potentially hostile shore.
        /// </summary>
        [DomValIx(1000194)]
        [StringValue("AMPHWF")]
        [EnumMember]
        AmphibiousWarfare,
		
        /// <summary>
        /// To conduct warfare with the purpose of defending friendly forces, against the threat aircraft and airborne weapons, whether launched from air, surface, or sub-surface platforms.
        /// </summary>
        [DomValIx(1000195)]
        [StringValue("ANARWF")]
        [EnumMember]
        AntiAirWarfare,
		
        /// <summary>
        /// To conduct warfare with the intention of denying the opponent the effective use of his submarines.
        /// </summary>
        [DomValIx(1000196)]
        [StringValue("ANSBWF")]
        [EnumMember]
        AntiSubmarineWarfare,
		
        /// <summary>
        /// To conduct warfare against an adversary’s surface forces or merchant ships to achieve sea control or sea denial, to disrupt his SLOC (Sea Lines of Communication) or to defend against surface threat.
        /// </summary>
        [DomValIx(1000197)]
        [StringValue("ANSFWF")]
        [EnumMember]
        AntiSurfaceWarfare,
		
        /// <summary>
        /// To conduct an operation that includes actions to influence decision makers in support of political and military objectives by affecting other’s information, information based processes, command and control systems and communications and information systems while exploiting and protecting one’s own information and/or information systems.
        /// </summary>
        [DomValIx(1000198)]
        [StringValue("INFOOP")]
        [EnumMember]
        InformationOperations,
		
        /// <summary>
        /// To conduct an operation that encompasses seaborne enforcement measures to interdict the movement of certain types of designated items into or out of a nation or specific area.
        /// </summary>
        [DomValIx(1000199)]
        [StringValue("MRITOP")]
        [EnumMember]
        MaritimeInterdictionOperations,
		
        /// <summary>
        /// To conduct warfare that includes the actions of laying mines and actions taken to counter the threat of an adversary (referred to as Mine Countermeasures).
        /// </summary>
        [DomValIx(1000200)]
        [StringValue("MINEWF")]
        [EnumMember]
        MineWarfare,
		
        /// <summary>
        /// To conduct warfare that includes strikes against targets ashore using carrier-based strike aircraft, sea-launched cruise missiles, naval guns, and special operations forces.
        /// </summary>
        [DomValIx(1000201)]
        [StringValue("STRWAF")]
        [EnumMember]
        StrikeWarfare,
		
        /// <summary>
        /// To conduct warfare that includes the use of submarines.
        /// </summary>
        [DomValIx(1000202)]
        [StringValue("SUBWAF")]
        [EnumMember]
        SubmarineWarfare,
		
        /// <summary>
        /// To conduct an operation in which maritime forces continue to provide direct and indirect support to combat operations ashore, and help in sustaining land and air forces by maintaining sealift and keeping SLOC (Sea Lines of Communication) open.
        /// </summary>
        [DomValIx(1000203)]
        [StringValue("SUSOAA")]
        [EnumMember]
        SustainingOperationsAfloatAndAshore,
		
        /// <summary>
        /// Control exercised by naval authorities of movement, routing, reporting, convoy organisation and tactical diversion of Allied merchant shipping. It does not include the employment or active protection of such shipping.
        /// </summary>
        [DomValIx(1000204)]
        [StringValue("NACLSP")]
        [EnumMember]
        NavalControlOfShipping,
		
        /// <summary>
        /// To conduct battlespace command and control operations from an airborne platform.
        /// </summary>
        [DomValIx(1000205)]
        [StringValue("ARCCTL")]
        [EnumMember]
        AirborneCommandAndControl,
		
        /// <summary>
        /// An aircraft patrol provided over an objective area, the force protected, the critical area of a combat zone, or in an air defence area, for the purpose of intercepting and destroying hostile aircraft before they reach their targets.
        /// </summary>
        [DomValIx(1000206)]
        [StringValue("COARPL")]
        [EnumMember]
        CombatAirPatrol,
		
        /// <summary>
        /// To reduce of the effectiveness of a force by causing loss of personnel and materiel.
        /// </summary>
        [DomValIx(1000207)]
        [StringValue("ATTRIT")]
        [EnumMember]
        Attrit,
		
        /// <summary>
        /// To prevent a FACILITY or FEATURE from performing its intended function.
        /// </summary>
        [DomValIx(1000208)]
        [StringValue("CLOSE")]
        [EnumMember]
        Close,
		
        /// <summary>
        /// To refuel aircraft in flight, which extends presence, increases range, and serves as a force multiplier.
        /// </summary>
        [DomValIx(1000209)]
        [StringValue("AERRFL")]
        [EnumMember]
        AerialRefuelling,
		
        /// <summary>
        /// To move patients under medical supervision to and between medical treatment facilities by air transportation.
        /// </summary>
        [DomValIx(1000210)]
        [StringValue("AEREVA")]
        [EnumMember]
        AeromedicalEvacuation,
		
        /// <summary>
        /// To deliver personnel or cargo from aircraft in flight.
        /// </summary>
        [DomValIx(1000212)]
        [StringValue("ARDROP")]
        [EnumMember]
        Airdrop,
		
        /// <summary>
        /// To unload heavy equipment from an aircraft in flight.
        /// </summary>
        [DomValIx(1000213)]
        [StringValue("ARDREQ")]
        [EnumMember]
        AirdropHeavyEquipment,
		
        /// <summary>
        /// To conduct an offensive mission by fighter aircraft to seek out and destroy enemy aircraft or targets of opportunity in an allotted area of operations.
        /// </summary>
        [DomValIx(1000214)]
        [StringValue("AIRSWP")]
        [EnumMember]
        AirToAirSweep,
		
        /// <summary>
        /// To review in order to identify significant facts for subsequent interpretation.
        /// </summary>
        [DomValIx(1000215)]
        [StringValue("ANALYS")]
        [EnumMember]
        Analyse,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1299/19.
        /// </summary>
        [DomValIx(1000216)]
        [StringValue("BRAKUP")]
        [EnumMember]
        Breakup,
		
        /// <summary>
        /// To launch aircraft from a naval platform.
        /// </summary>
        [DomValIx(1000217)]
        [StringValue("CARLNC")]
        [EnumMember]
        CarrierLaunch,
		
        /// <summary>
        /// To recover aircraft on a naval platform.
        /// </summary>
        [DomValIx(1000218)]
        [StringValue("CARREC")]
        [EnumMember]
        CarrierRecovery,
		
        /// <summary>
        /// To conduct a patrol by fighter aircraft that is employed between a force and an objective area as a barrier across the probable direction of enemy attack. Used as far from the force as control conditions permit, to give added protection against raids along the most direct approach routes.
        /// </summary>
        [DomValIx(1000219)]
        [StringValue("CAPBAR")]
        [EnumMember]
        CombatAirPatrolBarrier,
		
        /// <summary>
        /// To protect the search and rescue task forces during recovery operations.
        /// </summary>
        [DomValIx(1000220)]
        [StringValue("CAPRES")]
        [EnumMember]
        CombatAirPatrolRescue,
		
        /// <summary>
        /// To exercise authority and direction over assigned and attached forces in the accomplishment of the mission.
        /// </summary>
        [DomValIx(1000221)]
        [StringValue("CANDC")]
        [EnumMember]
        CommandAndControl,
		
        /// <summary>
        /// To employ an aircraft to serve as a communications relay.
        /// </summary>
        [DomValIx(1000222)]
        [StringValue("COMREL")]
        [EnumMember]
        CommunicationsRelay,
		
        /// <summary>
        /// To work or act together.
        /// </summary>
        [DomValIx(1000223)]
        [StringValue("COOPER")]
        [EnumMember]
        Cooperate,
		
        /// <summary>
        /// To travel as a courier.
        /// </summary>
        [DomValIx(1000224)]
        [StringValue("COURER")]
        [EnumMember]
        Courier,
		
        /// <summary>
        /// To unload troops with their supplies and equipment from a ship.
        /// </summary>
        [DomValIx(1000225)]
        [StringValue("DEBARK")]
        [EnumMember]
        Debark,
		
        /// <summary>
        /// To neutralize, destroy or temporarily degrade enemy defences in a specific area by physical attack and/or electronic warfare.
        /// </summary>
        [DomValIx(1000226)]
        [StringValue("DEFSUP")]
        [EnumMember]
        DefenceSuppression,
		
        /// <summary>
        /// To conduct air operations to attain and maintain a desired degree of air superiority by the destruction or neutralization of enemy forces, conducted near to or over friendly territory and generally reactive to the initiative of the enemy air forces.
        /// </summary>
        [DomValIx(1000227)]
        [StringValue("DEFCNT")]
        [EnumMember]
        DefensiveCounterAir,
		
        /// <summary>
        /// To state the characteristics, appearance, etc. of an object.
        /// </summary>
        [DomValIx(1000228)]
        [StringValue("DESCRB")]
        [EnumMember]
        Describe,
		
        /// <summary>
        /// To discover by any means of the presence of a person, object or phenomenon of potential military significance.
        /// </summary>
        [DomValIx(1000229)]
        [StringValue("DETECT")]
        [EnumMember]
        Detect,
		
        /// <summary>
        /// To exploit the electromagnetic spectrum encompassing; the search for, interception of electromagnetic emissions, the employment of electromagnetic energy, including directed energy, to reduce or prevent hostile use of the electromagnetic spectrum, and the actions to ensure its effective use by friendly forces.
        /// </summary>
        [DomValIx(1000230)]
        [StringValue("ELCWAR")]
        [EnumMember]
        ElectronicWarfare,
		
        /// <summary>
        /// To search for, intercept, locate, record measures and analyse radiated electromagnetic energy for the purpose of exploiting such radiations in support of military operations. Thus, ESM provides a source of EW information required to conduct ECM, ECCM, threat detection, warning, avoidance, target acquisition, and homing.
        /// </summary>
        [DomValIx(1000231)]
        [StringValue("ELCWRS")]
        [EnumMember]
        ElectronicWarfareSupport,
		
        /// <summary>
        /// To put personnel and/or vehicles and their associated stores and equipment into ships or aircraft.
        /// </summary>
        [DomValIx(1000232)]
        [StringValue("EMBARK")]
        [EnumMember]
        Embark,
		
        /// <summary>
        /// To withdraw from a dangerous position.
        /// </summary>
        [DomValIx(1000233)]
        [StringValue("EXFLTR")]
        [EnumMember]
        Exfiltrate,
		
        /// <summary>
        /// To direct the action of combat aircraft engaged in close air support of land forces from a forward position on the ground or in the air.
        /// </summary>
        [DomValIx(1000234)]
        [StringValue("FRWDAC")]
        [EnumMember]
        ForwardAirControl,
		
        /// <summary>
        /// To conduct a test flight to ensure the general aircraft safety after maintenance/repair, and to ensure the aircraft is fully serviceable for operations.
        /// </summary>
        [DomValIx(1000235)]
        [StringValue("FNCHFL")]
        [EnumMember]
        FunctionalCheckFlight,
		
        /// <summary>
        /// To determine by any act or means additional information of a detected person, object or phenomenon, in a detailed, accurate and trusted way.
        /// </summary>
        [DomValIx(1000236)]
        [StringValue("IDENTP")]
        [EnumMember]
        IdentifyPrecise,
		
        /// <summary>
        /// To gather information from all available sources to meet an intelligence requirement. Specifically, a logical plan for transforming the essential elements of information into orders or requests to sources within a required time limit.
        /// </summary>
        [DomValIx(1000237)]
        [StringValue("INTCOL")]
        [EnumMember]
        IntelligenceCollection,
		
        /// <summary>
        /// To place on a surface, esp. horizontally or in the proper or specified place.
        /// </summary>
        [DomValIx(1000238)]
        [StringValue("LAY")]
        [EnumMember]
        Lay,
		
        /// <summary>
        /// Airlift normally provided by specifically identifiable aircraft assigned to organisations or commands for internal administration.
        /// </summary>
        [DomValIx(1000239)]
        [StringValue("LIFTAD")]
        [EnumMember]
        LiftAdministrative,
		
        /// <summary>
        /// Mine Counter Measure operation stage 11.
        /// </summary>
        [DomValIx(1000240)]
        [StringValue("MCM11")]
        [EnumMember]
        McmOperationStage11,
		
        /// <summary>
        /// Mine Counter Measure operation stage 12.
        /// </summary>
        [DomValIx(1000241)]
        [StringValue("MCM12")]
        [EnumMember]
        McmOperationStage12,
		
        /// <summary>
        /// Mine Counter Measure operation stage 13.
        /// </summary>
        [DomValIx(1000242)]
        [StringValue("MCM13")]
        [EnumMember]
        McmOperationStage13,
		
        /// <summary>
        /// Mine Counter Measure operation stage 14.
        /// </summary>
        [DomValIx(1000243)]
        [StringValue("MCM14")]
        [EnumMember]
        McmOperationStage14,
		
        /// <summary>
        /// Mine Counter Measure operation stage 31.
        /// </summary>
        [DomValIx(1000244)]
        [StringValue("MCM31")]
        [EnumMember]
        McmOperationStage31,
		
        /// <summary>
        /// Mine Counter Measure operation stage 32.
        /// </summary>
        [DomValIx(1000245)]
        [StringValue("MCM32")]
        [EnumMember]
        McmOperationStage32,
		
        /// <summary>
        /// Mine Counter Measure operation stage 33.
        /// </summary>
        [DomValIx(1000246)]
        [StringValue("MCM33")]
        [EnumMember]
        McmOperationStage33,
		
        /// <summary>
        /// Mine Counter Measure operation stage 34.
        /// </summary>
        [DomValIx(1000247)]
        [StringValue("MCM34")]
        [EnumMember]
        McmOperationStage34,
		
        /// <summary>
        /// Mine Counter Measure operation stage 35.
        /// </summary>
        [DomValIx(1000248)]
        [StringValue("MCM35")]
        [EnumMember]
        McmOperationStage35,
		
        /// <summary>
        /// Mine Counter Measure operation stage 36.
        /// </summary>
        [DomValIx(1000249)]
        [StringValue("MCM36")]
        [EnumMember]
        McmOperationStage36,
		
        /// <summary>
        /// Mine Counter Measure operation stage 37.
        /// </summary>
        [DomValIx(1000250)]
        [StringValue("MCM37")]
        [EnumMember]
        McmOperationStage37,
		
        /// <summary>
        /// Mine Counter Measure operation stage 38.
        /// </summary>
        [DomValIx(1000251)]
        [StringValue("MCM38")]
        [EnumMember]
        McmOperationStage38,
		
        /// <summary>
        /// Mine Counter Measure operation stage 39.
        /// </summary>
        [DomValIx(1000252)]
        [StringValue("MCM39")]
        [EnumMember]
        McmOperationStage39,
		
        /// <summary>
        /// Mine Counter Measure operation stage 41.
        /// </summary>
        [DomValIx(1000253)]
        [StringValue("MCM41")]
        [EnumMember]
        McmOperationStage41,
		
        /// <summary>
        /// Mine Counter Measure operation stage 42.
        /// </summary>
        [DomValIx(1000254)]
        [StringValue("MCM42")]
        [EnumMember]
        McmOperationStage42,
		
        /// <summary>
        /// Mine Counter Measure operation stage 43.
        /// </summary>
        [DomValIx(1000255)]
        [StringValue("MCM43")]
        [EnumMember]
        McmOperationStage43,
		
        /// <summary>
        /// Mine Counter Measure operation stage 44.
        /// </summary>
        [DomValIx(1000256)]
        [StringValue("MCM44")]
        [EnumMember]
        McmOperationStage44,
		
        /// <summary>
        /// Mine Counter Measure operation stage 45.
        /// </summary>
        [DomValIx(1000257)]
        [StringValue("MCM45")]
        [EnumMember]
        McmOperationStage45,
		
        /// <summary>
        /// Mine Counter Measure operation stage 46.
        /// </summary>
        [DomValIx(1000258)]
        [StringValue("MCM46")]
        [EnumMember]
        McmOperationStage46,
		
        /// <summary>
        /// Mine Counter Measure operation stage 47.
        /// </summary>
        [DomValIx(1000259)]
        [StringValue("MCM47")]
        [EnumMember]
        McmOperationStage47,
		
        /// <summary>
        /// Mine Counter Measure operation stage 48.
        /// </summary>
        [DomValIx(1000260)]
        [StringValue("MCM48")]
        [EnumMember]
        McmOperationStage48,
		
        /// <summary>
        /// Mine Counter Measure operation stage 50.
        /// </summary>
        [DomValIx(1000261)]
        [StringValue("MCM50")]
        [EnumMember]
        McmOperationStage50,
		
        /// <summary>
        /// Mine Counter Measure operation stage 51.
        /// </summary>
        [DomValIx(1000262)]
        [StringValue("MCM51")]
        [EnumMember]
        McmOperationStage51,
		
        /// <summary>
        /// Mine Counter Measure operation stage 52.
        /// </summary>
        [DomValIx(1000263)]
        [StringValue("MCM52")]
        [EnumMember]
        McmOperationStage52,
		
        /// <summary>
        /// Mine Counter Measure operation stage 53.
        /// </summary>
        [DomValIx(1000264)]
        [StringValue("MCM53")]
        [EnumMember]
        McmOperationStage53,
		
        /// <summary>
        /// Mine Counter Measure operation stage 54.
        /// </summary>
        [DomValIx(1000265)]
        [StringValue("MCM54")]
        [EnumMember]
        McmOperationStage54,
		
        /// <summary>
        /// Mine Counter Measure operation stage 55.
        /// </summary>
        [DomValIx(1000266)]
        [StringValue("MCM55")]
        [EnumMember]
        McmOperationStage55,
		
        /// <summary>
        /// Mine Counter Measure operation stage 56.
        /// </summary>
        [DomValIx(1000267)]
        [StringValue("MCM56")]
        [EnumMember]
        McmOperationStage56,
		
        /// <summary>
        /// Mine Counter Measure operation stage 57.
        /// </summary>
        [DomValIx(1000268)]
        [StringValue("MCM57")]
        [EnumMember]
        McmOperationStage57,
		
        /// <summary>
        /// Mine Counter Measure operation stage 58A.
        /// </summary>
        [DomValIx(1000269)]
        [StringValue("MCM58A")]
        [EnumMember]
        McmOperationStage58A,
		
        /// <summary>
        /// Mine Counter Measure operation stage 58B.
        /// </summary>
        [DomValIx(1000270)]
        [StringValue("MCM58B")]
        [EnumMember]
        McmOperationStage58B,
		
        /// <summary>
        /// Mine Counter Measure operation stage 58C.
        /// </summary>
        [DomValIx(1000271)]
        [StringValue("MCM58C")]
        [EnumMember]
        McmOperationStage58C,
		
        /// <summary>
        /// Mine Counter Measure operation stage 59.
        /// </summary>
        [DomValIx(1000272)]
        [StringValue("MCM59")]
        [EnumMember]
        McmOperationStage59,
		
        /// <summary>
        /// Mine Counter Measure operation stage 61.
        /// </summary>
        [DomValIx(1000273)]
        [StringValue("MCM61")]
        [EnumMember]
        McmOperationStage61,
		
        /// <summary>
        /// Mine Counter Measure operation stage 62.
        /// </summary>
        [DomValIx(1000274)]
        [StringValue("MCM62")]
        [EnumMember]
        McmOperationStage62,
		
        /// <summary>
        /// Mine Counter Measure operation stage 63.
        /// </summary>
        [DomValIx(1000275)]
        [StringValue("MCM63")]
        [EnumMember]
        McmOperationStage63,
		
        /// <summary>
        /// Mine Counter Measure operation stage 71.
        /// </summary>
        [DomValIx(1000276)]
        [StringValue("MCM71")]
        [EnumMember]
        McmOperationStage71,
		
        /// <summary>
        /// Mine Counter Measure operation stage 72.
        /// </summary>
        [DomValIx(1000277)]
        [StringValue("MCM72")]
        [EnumMember]
        McmOperationStage72,
		
        /// <summary>
        /// Mine Counter Measure operation stage 73.
        /// </summary>
        [DomValIx(1000278)]
        [StringValue("MCM73")]
        [EnumMember]
        McmOperationStage73,
		
        /// <summary>
        /// Mine Counter Measure operation stage 74.
        /// </summary>
        [DomValIx(1000279)]
        [StringValue("MCM74")]
        [EnumMember]
        McmOperationStage74,
		
        /// <summary>
        /// Mine Counter Measure operation stage 75.
        /// </summary>
        [DomValIx(1000280)]
        [StringValue("MCM75")]
        [EnumMember]
        McmOperationStage75,
		
        /// <summary>
        /// Mine Counter Measure operation stage 81.
        /// </summary>
        [DomValIx(1000281)]
        [StringValue("MCM81")]
        [EnumMember]
        McmOperationStage81,
		
        /// <summary>
        /// Mine Counter Measure operation stage 82.
        /// </summary>
        [DomValIx(1000282)]
        [StringValue("MCM82")]
        [EnumMember]
        McmOperationStage82,
		
        /// <summary>
        /// Mine Counter Measure operation stage 83.
        /// </summary>
        [DomValIx(1000283)]
        [StringValue("MCM83")]
        [EnumMember]
        McmOperationStage83,
		
        /// <summary>
        /// Mine Counter Measure operation stage 84.
        /// </summary>
        [DomValIx(1000284)]
        [StringValue("MCM84")]
        [EnumMember]
        McmOperationStage84,
		
        /// <summary>
        /// Mine Counter Measure operation stage 85.
        /// </summary>
        [DomValIx(1000285)]
        [StringValue("MCM85")]
        [EnumMember]
        McmOperationStage85,
		
        /// <summary>
        /// Mine Counter Measure operation stage 86.
        /// </summary>
        [DomValIx(1000286)]
        [StringValue("MCM86")]
        [EnumMember]
        McmOperationStage86,
		
        /// <summary>
        /// Mine Counter Measure operation stage 87.
        /// </summary>
        [DomValIx(1000287)]
        [StringValue("MCM87")]
        [EnumMember]
        McmOperationStage87,
		
        /// <summary>
        /// Mine Counter Measure operation stage 88.
        /// </summary>
        [DomValIx(1000288)]
        [StringValue("MCM88")]
        [EnumMember]
        McmOperationStage88,
		
        /// <summary>
        /// Mine Counter Measure operation stage 89.
        /// </summary>
        [DomValIx(1000289)]
        [StringValue("MCM89")]
        [EnumMember]
        McmOperationStage89,
		
        /// <summary>
        /// Mine Counter Measure operation stage 91.
        /// </summary>
        [DomValIx(1000290)]
        [StringValue("MCM91")]
        [EnumMember]
        McmOperationStage91,
		
        /// <summary>
        /// Mine Counter Measure operation stage 92.
        /// </summary>
        [DomValIx(1000291)]
        [StringValue("MCM92")]
        [EnumMember]
        McmOperationStage92,
		
        /// <summary>
        /// Mine Counter Measure operation stage 93.
        /// </summary>
        [DomValIx(1000292)]
        [StringValue("MCM93")]
        [EnumMember]
        McmOperationStage93,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ALPHA.
        /// </summary>
        [DomValIx(1000293)]
        [StringValue("MCMSA")]
        [EnumMember]
        McmSlsAlpha,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ALPHA-ALPHA.
        /// </summary>
        [DomValIx(1000294)]
        [StringValue("MCMSAA")]
        [EnumMember]
        McmSlsAlphaAlpha,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ALPHA-CHARLIE.
        /// </summary>
        [DomValIx(1000295)]
        [StringValue("MCMSAC")]
        [EnumMember]
        McmSlsAlphaCharlie,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ALPHA-DELTA.
        /// </summary>
        [DomValIx(1000296)]
        [StringValue("MCMSAD")]
        [EnumMember]
        McmSlsAlphaDelta,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ALPHA-GOLF.
        /// </summary>
        [DomValIx(1000297)]
        [StringValue("MCMSAG")]
        [EnumMember]
        McmSlsAlphaGolf,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ALPHA-HOTEL.
        /// </summary>
        [DomValIx(1000298)]
        [StringValue("MCMSAH")]
        [EnumMember]
        McmSlsAlphaHotel,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ALPHA-MIKE.
        /// </summary>
        [DomValIx(1000299)]
        [StringValue("MCMSAM")]
        [EnumMember]
        McmSlsAlphaMike,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ALPHA-ZULU.
        /// </summary>
        [DomValIx(1000300)]
        [StringValue("MCMSAZ")]
        [EnumMember]
        McmSlsAlphaZulu,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes BRAVO.
        /// </summary>
        [DomValIx(1000301)]
        [StringValue("MCMSB")]
        [EnumMember]
        McmSlsBravo,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes BRAVO-ZULU.
        /// </summary>
        [DomValIx(1000302)]
        [StringValue("MCMSBZ")]
        [EnumMember]
        McmSlsBravoZulu,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes CHARLIE.
        /// </summary>
        [DomValIx(1000303)]
        [StringValue("MCMSC")]
        [EnumMember]
        McmSlsCharlie,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes CHARLIE-ALPHA.
        /// </summary>
        [DomValIx(1000304)]
        [StringValue("MCMSCA")]
        [EnumMember]
        McmSlsCharlieAlpha,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes CHARLIE-CHARLIE.
        /// </summary>
        [DomValIx(1000305)]
        [StringValue("MCMSCC")]
        [EnumMember]
        McmSlsCharlieCharlie,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes CHARLIE-DELTA.
        /// </summary>
        [DomValIx(1000306)]
        [StringValue("MCMSCD")]
        [EnumMember]
        McmSlsCharlieDelta,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes CHARLIE-GOLF.
        /// </summary>
        [DomValIx(1000307)]
        [StringValue("MCMSCG")]
        [EnumMember]
        McmSlsCharlieGolf,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes CHARLIE-HOTEL.
        /// </summary>
        [DomValIx(1000308)]
        [StringValue("MCMSCH")]
        [EnumMember]
        McmSlsCharlieHotel,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes CHARLIE-MIKE.
        /// </summary>
        [DomValIx(1000309)]
        [StringValue("MCMSCM")]
        [EnumMember]
        McmSlsCharlieMike,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes CHARLIE-ZULU.
        /// </summary>
        [DomValIx(1000310)]
        [StringValue("MCMSCZ")]
        [EnumMember]
        McmSlsCharlieZulu,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ECHO.
        /// </summary>
        [DomValIx(1000311)]
        [StringValue("MCMSE")]
        [EnumMember]
        McmSlsEcho,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ECHO-ALPHA.
        /// </summary>
        [DomValIx(1000312)]
        [StringValue("MCMSEA")]
        [EnumMember]
        McmSlsEchoAlpha,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ECHO-CHARLIE.
        /// </summary>
        [DomValIx(1000313)]
        [StringValue("MCMSEC")]
        [EnumMember]
        McmSlsEchoCharlie,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ECHO-DELTA.
        /// </summary>
        [DomValIx(1000314)]
        [StringValue("MCMSED")]
        [EnumMember]
        McmSlsEchoDelta,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ECHO-GOLF.
        /// </summary>
        [DomValIx(1000315)]
        [StringValue("MCMSEG")]
        [EnumMember]
        McmSlsEchoGolf,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ECHO-HOTEL.
        /// </summary>
        [DomValIx(1000316)]
        [StringValue("MCMSEH")]
        [EnumMember]
        McmSlsEchoHotel,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ECHO-MIKE.
        /// </summary>
        [DomValIx(1000317)]
        [StringValue("MCMSEM")]
        [EnumMember]
        McmSlsEchoMike,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ECHO-ZULU.
        /// </summary>
        [DomValIx(1000318)]
        [StringValue("MCMSEZ")]
        [EnumMember]
        McmSlsEchoZulu,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes LIMA.
        /// </summary>
        [DomValIx(1000319)]
        [StringValue("MCMSL")]
        [EnumMember]
        McmSlsLima,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes LIMA-ALPHA.
        /// </summary>
        [DomValIx(1000320)]
        [StringValue("MCMSLA")]
        [EnumMember]
        McmSlsLimaAlpha,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes LIMA-HOTEL.
        /// </summary>
        [DomValIx(1000321)]
        [StringValue("MCMSLH")]
        [EnumMember]
        McmSlsLimaHotel,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes LIMA-MIKE.
        /// </summary>
        [DomValIx(1000322)]
        [StringValue("MCMSLM")]
        [EnumMember]
        McmSlsLimaMike,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes LIMA-ZULU.
        /// </summary>
        [DomValIx(1000323)]
        [StringValue("MCMSLZ")]
        [EnumMember]
        McmSlsLimaZulu,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes PAPA.
        /// </summary>
        [DomValIx(1000324)]
        [StringValue("MCMSP")]
        [EnumMember]
        McmSlsPapa,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes PAPA-ALPHA.
        /// </summary>
        [DomValIx(1000325)]
        [StringValue("MCMSPA")]
        [EnumMember]
        McmSlsPapaAlpha,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes PAPA-CHARLIE.
        /// </summary>
        [DomValIx(1000326)]
        [StringValue("MCMSPC")]
        [EnumMember]
        McmSlsPapaCharlie,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes PAPA-GOLF.
        /// </summary>
        [DomValIx(1000327)]
        [StringValue("MCMSPG")]
        [EnumMember]
        McmSlsPapaGolf,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes PAPA-HOTEL.
        /// </summary>
        [DomValIx(1000328)]
        [StringValue("MCMSPH")]
        [EnumMember]
        McmSlsPapaHotel,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes PAPA-MIKE.
        /// </summary>
        [DomValIx(1000329)]
        [StringValue("MCMSPM")]
        [EnumMember]
        McmSlsPapaMike,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes PAPA-ZULU.
        /// </summary>
        [DomValIx(1000330)]
        [StringValue("MCMSPZ")]
        [EnumMember]
        McmSlsPapaZulu,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ROMEO.
        /// </summary>
        [DomValIx(1000331)]
        [StringValue("MCMSR")]
        [EnumMember]
        McmSlsRomeo,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ROMEO-DELTA.
        /// </summary>
        [DomValIx(1000332)]
        [StringValue("MCMSRD")]
        [EnumMember]
        McmSlsRomeoDelta,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ROMEO-HOTEL.
        /// </summary>
        [DomValIx(1000333)]
        [StringValue("MCMSRH")]
        [EnumMember]
        McmSlsRomeoHotel,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes SIERRA.
        /// </summary>
        [DomValIx(1000334)]
        [StringValue("MCMSS")]
        [EnumMember]
        McmSlsSierra,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes SIERRA-ALPHA.
        /// </summary>
        [DomValIx(1000335)]
        [StringValue("MCMSSA")]
        [EnumMember]
        McmSlsSierraAlpha,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes SIERRA-CHARLIE.
        /// </summary>
        [DomValIx(1000336)]
        [StringValue("MCMSSC")]
        [EnumMember]
        McmSlsSierraCharlie,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes SIERRA-DELTA.
        /// </summary>
        [DomValIx(1000337)]
        [StringValue("MCMSSD")]
        [EnumMember]
        McmSlsSierraDelta,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes SIERRA-GOLF.
        /// </summary>
        [DomValIx(1000338)]
        [StringValue("MCMSSG")]
        [EnumMember]
        McmSlsSierraGolf,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes SIERRA-HOTEL.
        /// </summary>
        [DomValIx(1000339)]
        [StringValue("MCMSSH")]
        [EnumMember]
        McmSlsSierraHotel,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes SIERRA-MIKE.
        /// </summary>
        [DomValIx(1000340)]
        [StringValue("MCMSSM")]
        [EnumMember]
        McmSlsSierraMike,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes SIERRA-ZULU.
        /// </summary>
        [DomValIx(1000341)]
        [StringValue("MCMSSZ")]
        [EnumMember]
        McmSlsSierraZulu,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes UNIFORM.
        /// </summary>
        [DomValIx(1000342)]
        [StringValue("MCMSU")]
        [EnumMember]
        McmSlsUniform,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes UNIFORM-HOTEL.
        /// </summary>
        [DomValIx(1000343)]
        [StringValue("MCMSUH")]
        [EnumMember]
        McmSlsUniformHotel,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes UNIFORM-ZULU.
        /// </summary>
        [DomValIx(1000344)]
        [StringValue("MCMSUZ")]
        [EnumMember]
        McmSlsUniformZulu,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes VICTOR.
        /// </summary>
        [DomValIx(1000345)]
        [StringValue("MCMSV")]
        [EnumMember]
        McmSlsVictor,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes VICTOR-ALPHA.
        /// </summary>
        [DomValIx(1000346)]
        [StringValue("MCMSVA")]
        [EnumMember]
        McmSlsVictorAlpha,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes VICTOR-CHARLIE.
        /// </summary>
        [DomValIx(1000347)]
        [StringValue("MCMSVC")]
        [EnumMember]
        McmSlsVictorCharlie,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes VICTOR-DELTA.
        /// </summary>
        [DomValIx(1000348)]
        [StringValue("MCMSVD")]
        [EnumMember]
        McmSlsVictorDelta,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes VICTOR-GOLF.
        /// </summary>
        [DomValIx(1000349)]
        [StringValue("MCMSVG")]
        [EnumMember]
        McmSlsVictorGolf,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes VICTOR-HOTEL.
        /// </summary>
        [DomValIx(1000350)]
        [StringValue("MCMSVH")]
        [EnumMember]
        McmSlsVictorHotel,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes VICTOR-MIKE.
        /// </summary>
        [DomValIx(1000351)]
        [StringValue("MCMSVM")]
        [EnumMember]
        McmSlsVictorMike,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes VICTOR-ZULU.
        /// </summary>
        [DomValIx(1000352)]
        [StringValue("MCMSVZ")]
        [EnumMember]
        McmSlsVictorZulu,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes WHISKEY.
        /// </summary>
        [DomValIx(1000353)]
        [StringValue("MCMSW")]
        [EnumMember]
        McmSlsWhiskey,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes WHISKEY-ZULU.
        /// </summary>
        [DomValIx(1000354)]
        [StringValue("MCMSWZ")]
        [EnumMember]
        McmSlsWhiskeyZulu,
		
        /// <summary>
        /// Mine Countermeasures Operation Standard Letter Suffixes ZULU-ZULU.
        /// </summary>
        [DomValIx(1000355)]
        [StringValue("MCMSZZ")]
        [EnumMember]
        McmSlsZuluZulu,
		
        /// <summary>
        /// To search for or clear mines using mechanical or explosion gear, which physically removes or destroys the mine, or produces, in the area, the influence fields necessary to actuate it.
        /// </summary>
        [DomValIx(1000356)]
        [StringValue("MINSWP")]
        [EnumMember]
        MinesweepingLand,
		
        /// <summary>
        /// To launch or recover aircraft by a naval platform.
        /// </summary>
        [DomValIx(1000357)]
        [StringValue("NVLPLF")]
        [EnumMember]
        NavalPlatformFlightOperations,
		
        /// <summary>
        /// To provide support by the air forces on land or sea in offensive operations.
        /// </summary>
        [DomValIx(1000358)]
        [StringValue("OFFAIR")]
        [EnumMember]
        OffensiveAirSupport,
		
        /// <summary>
        /// To conduct an operation to destroy, disrupt or limit enemy air power as close to its source as possible.
        /// </summary>
        [DomValIx(1000359)]
        [StringValue("OFFCNA")]
        [EnumMember]
        OffensiveCounterAir,
		
        /// <summary>
        /// To use propaganda or other means designed to undermine the morale or allegiance of one's opponents.
        /// </summary>
        [DomValIx(1000360)]
        [StringValue("PSYCHW")]
        [EnumMember]
        PsychologicalWarfare,
		
        /// <summary>
        /// To locate and attack targets of opportunity, i.e. enemy material, personnel, and facilities in assigned surface communications routes, and not for the purpose of attacking specific briefed targets.
        /// </summary>
        [DomValIx(1000361)]
        [StringValue("RECARM")]
        [EnumMember]
        ReconnaissanceArmed,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1299/19.
        /// </summary>
        [DomValIx(1000362)]
        [StringValue("REFORM")]
        [EnumMember]
        Reform,
		
        /// <summary>
        /// To use aircraft, surface craft (land or water), submarines, specialized rescue teams, and equipment to rescue personnel in distress on land or at sea.
        /// </summary>
        [DomValIx(1000369)]
        [StringValue("RESCUE")]
        [EnumMember]
        Rescue,
		
        /// <summary>
        /// To launch or take-off an aircraft as quickly as possible, usually followed by mission instructions.
        /// </summary>
        [DomValIx(1000370)]
        [StringValue("SCRMBL")]
        [EnumMember]
        Scramble,
		
        /// <summary>
        /// To detect, locate, identify and rescue downed aircrew in hostile territory in crisis and wartime and, when appropriate, isolated military personnel in distress, who are equipped and trained to receive CSAR support, throughout a theatre of operations.
        /// </summary>
        [DomValIx(1000371)]
        [StringValue("SRCRES")]
        [EnumMember]
        SearchAndRescueCombat,
		
        /// <summary>
        /// To take measures necessary to achieve protection against espionage, sabotage, subversion and terrorism, as well as against loss or unauthorised disclosure.
        /// </summary>
        [DomValIx(1000372)]
        [StringValue("SECURT")]
        [EnumMember]
        Security,
		
        /// <summary>
        /// To insert a piece of equipment which detects, and may indicate, and/or record objects and activities by means of energy or particles emitted, reflected, or modified by objects.
        /// </summary>
        [DomValIx(1000373)]
        [StringValue("SENSIM")]
        [EnumMember]
        SensorImplant,
		
        /// <summary>
        /// To serve as a fraction of a command in the direction of depth, which is an assigned strategic reserve.
        /// </summary>
        [DomValIx(1000374)]
        [StringValue("SERSTR")]
        [EnumMember]
        ServeAsAStrategicReserve,
		
        /// <summary>
        /// To serve as a fraction of a command in the direction of depth, to which a support mission is assigned.
        /// </summary>
        [DomValIx(1000375)]
        [StringValue("SERSPE")]
        [EnumMember]
        ServeAsASupportEchelon,
		
        /// <summary>
        /// To serve as an element of a force which is scheduled for initial assault on the objective area.
        /// </summary>
        [DomValIx(1000376)]
        [StringValue("SERASE")]
        [EnumMember]
        ServeAsAnAssaultEchelon,
		
        /// <summary>
        /// To serve as a fraction of a command in the direction of depth, to which an attack mission is assigned.
        /// </summary>
        [DomValIx(1000377)]
        [StringValue("SERATE")]
        [EnumMember]
        ServeAsAnAttackEchelon,
		
        /// <summary>
        /// To serve as a fraction of a command, to which the first mission is assigned or which forms the forward line of own troops or which is first troops in the theatre.
        /// </summary>
        [DomValIx(1000378)]
        [StringValue("SERFOE")]
        [EnumMember]
        ServeAsTheFirstOperationalEchelon,
		
        /// <summary>
        /// To serve as a fraction of a tactical command, to which a primary mission is assigned.
        /// </summary>
        [DomValIx(1000379)]
        [StringValue("SERFTE")]
        [EnumMember]
        ServeAsTheFirstTacticalEchelon,
		
        /// <summary>
        /// To serve as, in amphibious operations, that echelon of the assault troops, vehicles, aircraft equipment, and supplies which, though not needed to initiate the assault, is required to support and sustain the assault.
        /// </summary>
        [DomValIx(1000380)]
        [StringValue("SERFLO")]
        [EnumMember]
        ServeAsTheFollowOnEchelon,
		
        /// <summary>
        /// To serve as, in air transport operations, an element moved into the objective area after the assault echelon.
        /// </summary>
        [DomValIx(1000381)]
        [StringValue("SERFUE")]
        [EnumMember]
        ServeAsTheFollowUpEchelon,
		
        /// <summary>
        /// To serve as a forward subdivision of a headquarters.
        /// </summary>
        [DomValIx(1000382)]
        [StringValue("SERFRE")]
        [EnumMember]
        ServeAsTheForwardEchelon,
		
        /// <summary>
        /// To serve as elements of a force which are not required in the objective area.
        /// </summary>
        [DomValIx(1000383)]
        [StringValue("SERREE")]
        [EnumMember]
        ServeAsTheRearEchelon,
		
        /// <summary>
        /// To serve as a fraction of a command in the direction of depth, which is an assigned reserve.
        /// </summary>
        [DomValIx(1000384)]
        [StringValue("SERRSE")]
        [EnumMember]
        ServeAsTheReserveEchelon,
		
        /// <summary>
        /// To serve as a portion of the assault shipping which withdraws from, or remains out of, the transport area during an amphibious landing and operates in designated areas to seaward in an on-call or unscheduled status.
        /// </summary>
        [DomValIx(1000385)]
        [StringValue("SERSEA")]
        [EnumMember]
        ServeAsTheSeaEchelon,
		
        /// <summary>
        /// To serve as a fraction of an operational command either in the direction of depth or as a follow up on the timeline, to which a secondary operational mission is assigned.
        /// </summary>
        [DomValIx(1000386)]
        [StringValue("SERSOE")]
        [EnumMember]
        ServeAsTheSecondOperationalEchelon,
		
        /// <summary>
        /// To serve as a fraction of a tactical command either in the direction of depth or as a follow up on the timeline, to which a secondary tactical mission is assigned.
        /// </summary>
        [DomValIx(1000387)]
        [StringValue("SERSTE")]
        [EnumMember]
        ServeAsTheSecondTacticalEchelon,
		
        /// <summary>
        /// To serve as a fraction of a command in the direction of depth, which is an assigned theatre reserve.
        /// </summary>
        [DomValIx(1000388)]
        [StringValue("SERTHR")]
        [EnumMember]
        ServeAsTheTheatreReserve,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1299/19.
        /// </summary>
        [DomValIx(1000389)]
        [StringValue("SPREAD")]
        [EnumMember]
        Spread,
		
        /// <summary>
        /// To conduct reconnaissance strike control and reconnaissance operations.
        /// </summary>
        [DomValIx(1000390)]
        [StringValue("STRCON")]
        [EnumMember]
        StrikeControlAndReconnaissance,
		
        /// <summary>
        /// To develop, maintain or improve the readiness of individuals or units.
        /// </summary>
        [DomValIx(1000391)]
        [StringValue("TRAIN")]
        [EnumMember]
        Train,
		
        /// <summary>
        /// To conduct operations for military, political or economic purposes within an area occupied by the enemy and making use of the local inhabitants and resources.
        /// </summary>
        [DomValIx(1000392)]
        [StringValue("UNCONW")]
        [EnumMember]
        UnconventionalWarfare,
		
        /// <summary>
        /// To conduct a flight in which the aircraft has the capability of performing multiple missions.
        /// </summary>
        [DomValIx(1000393)]
        [StringValue("UTILTY")]
        [EnumMember]
        UtilityFlight,
		
        /// <summary>
        /// To identify, locate, and physically suppress or destroy ground based enemy air defence systems that employ sensors radiating electromagnetic energy.
        /// </summary>
        [DomValIx(1000394)]
        [StringValue("WLDWSL")]
        [EnumMember]
        WildWeasel,
		
        /// <summary>
        /// To testify to, to assert, to affirm or confirm, as true or certain.
        /// </summary>
        [DomValIx(1000395)]
        [StringValue("VERIFY")]
        [EnumMember]
        Verify,
		
        /// <summary>
        /// To concentrate large quantities of military equipment and personnel.
        /// </summary>
        [DomValIx(1000396)]
        [StringValue("MASSFR")]
        [EnumMember]
        MassForces,
		
        /// <summary>
        /// To travel over a designated route.
        /// </summary>
        [DomValIx(1000397)]
        [StringValue("TRVRS")]
        [EnumMember]
        Traverse,
		
        /// <summary>
        /// To conduct an activity described by the action-task-detail-text.
        /// </summary>
        [DomValIx(1000398)]
        [StringValue("CDWDAC")]
        [EnumMember]
        CodewordActivity,
		
        /// <summary>
        /// To conduct electronic warfare involving the use of electromagnetic energy, directed energy or anti-radiation weapons to attack personnel, facilities, or equipment with the intent of degrading, neutralizing, or destroying enemy combat capability and is considered a form of fires.
        /// </summary>
        [DomValIx(1000399)]
        [StringValue("ATTEL")]
        [EnumMember]
        AttackElectronic,
		
        /// <summary>
        /// In electronic countermeasures, the deliberate radiation, re-radiation, alteration, absorption or reflection of electromagnetic energy in a manner intended to confuse, distract or seduce an enemy or his electronic systems.
        /// </summary>
        [DomValIx(1000400)]
        [StringValue("DCPTEL")]
        [EnumMember]
        DeceptionElectronic,
		
        /// <summary>
        /// That division of electronic warfare involving actions taken to ensure effective friendly use of the electromagnetic spectrum despite the enemy's use of electromagnetic energy.
        /// </summary>
        [DomValIx(1000401)]
        [StringValue("PROTEL")]
        [EnumMember]
        ProtectionElectronic,
		
        /// <summary>
        /// The systematic observation of aerospace, surface or subsurface areas, places, persons, or things, by electronic means.
        /// </summary>
        [DomValIx(1000402)]
        [StringValue("SURVEL")]
        [EnumMember]
        SurveillanceElectronic,
		
        /// <summary>
        /// To minimize the probability of acquisition of real targets by creating false targets in the vicinity of real targets by means of electronic spoofing or use of decoys.
        /// </summary>
        [DomValIx(1000403)]
        [StringValue("TGTDLT")]
        [EnumMember]
        TargetDilution,
		
        /// <summary>
        /// To perform the assembly of aircraft for the completion of a mission or other activity.
        /// </summary>
        [DomValIx(1000404)]
        [StringValue("MISSTG")]
        [EnumMember]
        MissionStaging,
		
        /// <summary>
        /// To rendezvous using a procedure directed by a radar control station, whether ground based, seaborne, or airborne (anchor rendezvous).
        /// </summary>
        [DomValIx(1000405)]
        [StringValue("RNDZVA")]
        [EnumMember]
        RendezvousProcedureAlpha,
		
        /// <summary>
        /// To rendezvous using a heading based procedure which utilises air-to-air equipment of both tanker and receiver. The tanker controls the procedure.
        /// </summary>
        [DomValIx(1000406)]
        [StringValue("RNDZVB")]
        [EnumMember]
        RendezvousProcedureBravo,
		
        /// <summary>
        /// To rendezvous using a heading based procedure which allows receivers with an airborne intercept (AI) radar to control the procedure once positive AI radar contact is established.
        /// </summary>
        [DomValIx(1000407)]
        [StringValue("RNDZVC")]
        [EnumMember]
        RendezvousProcedureCharlie,
		
        /// <summary>
        /// To rendezvous using a procedure that requires the receiver to maintain an agreed track and the tanker to maintain the reciprocal track, offset a pre-determined distance (point parallel).
        /// </summary>
        [DomValIx(1000408)]
        [StringValue("RNDZVD")]
        [EnumMember]
        RendezvousProcedureDelta,
		
        /// <summary>
        /// To rendezvous using a procedure for use in support of a combat air patrol (CAP). It is particularly useful during periods of EMCON constraints.
        /// </summary>
        [DomValIx(1000409)]
        [StringValue("RNDZVE")]
        [EnumMember]
        RendezvousProcedureEcho,
		
        /// <summary>
        /// To rendezvous using a procedure where the tanker and receiver operate from the same base.
        /// </summary>
        [DomValIx(1000410)]
        [StringValue("RNDZVF")]
        [EnumMember]
        RendezvousProcedureFoxtrot,
		
        /// <summary>
        /// To rendezvous using a procedure that facilitates join-up on a common track; receivers may have departed either from the same or different bases (enroute).
        /// </summary>
        [DomValIx(1000411)]
        [StringValue("RNDZVG")]
        [EnumMember]
        RendezvousProcedureGolf,
		
        /// <summary>
        /// To descend or plunge into or underwater or some other liquid.
        /// </summary>
        [DomValIx(1000412)]
        [StringValue("DIVE")]
        [EnumMember]
        Dive,
		
        /// <summary>
        /// To search for or counter mines by maritime minesweepers using mechanical or explosive gear, which physically removes or destroys the mine, or by producing, in the volume, the influence field necessary to actuate it.
        /// </summary>
        [DomValIx(1000413)]
        [StringValue("MNSWMA")]
        [EnumMember]
        MinesweepingMaritime,
		
        /// <summary>
        /// To locate and dispose of individual mines by means of detection equipment with the employment of ships, airborne equipment and/or divers.
        /// </summary>
        [DomValIx(1000414)]
        [StringValue("MNHUNT")]
        [EnumMember]
        MineHuntingMaritime,
		
        /// <summary>
        /// To conduct continuous application of Mine Countermeasures (MCM) to keep the risk from mines to all vessels as low as possible. Appropriate to minefields that are being replenished.
        /// </summary>
        [DomValIx(1000415)]
        [StringValue("MCMATT")]
        [EnumMember]
        McmAttrition,
		
        /// <summary>
        /// To conduct a Mine Countermeasures (MCM) operation to check that as far as possible no maritime mines are left after the previous MCM operation.
        /// </summary>
        [DomValIx(1000416)]
        [StringValue("MCMCHK")]
        [EnumMember]
        McmCheck,
		
        /// <summary>
        /// To conduct a Mine Countermeasures (MCM) operation in which a sample of the route or area is subjected to MCM procedures to determine the presence or absence of mines.
        /// </summary>
        [DomValIx(1000417)]
        [StringValue("MCMEXP")]
        [EnumMember]
        McmExploratory,
		
        /// <summary>
        /// To assist traffic in the transit of parts of a mined area which have previously been subject to Mine Countermeasures (MCM) operations.
        /// </summary>
        [DomValIx(1000418)]
        [StringValue("MCMLDT")]
        [EnumMember]
        McmLeadThrough,
		
        /// <summary>
        /// To clear particular types of mines from an area, channel or route.
        /// </summary>
        [DomValIx(1000419)]
        [StringValue("MCMLMC")]
        [EnumMember]
        McmLimitedClearing,
		
        /// <summary>
        /// To carry out operations in an area or channel using relatively safe methods and techniques in order to reduce the risk to mine countermeasures (MCM) vessels.
        /// </summary>
        [DomValIx(1000420)]
        [StringValue("MCMPRE")]
        [EnumMember]
        McmPrecursor,
		
        /// <summary>
        /// To conduct a minesweeping and/or minehunting carried out when time available before ships are passed through a mined area, (or suspected mined area), is insufficient to carry out clearance operations.
        /// </summary>
        [DomValIx(1000421)]
        [StringValue("MCMTML")]
        [EnumMember]
        McmTimeLimited,
		
        /// <summary>
        /// To collect environmental data which may be used in support of current and future mine countermeasures (MCM) operations.
        /// </summary>
        [DomValIx(1000422)]
        [StringValue("MCMSRV")]
        [EnumMember]
        McmSurvey,
		
        /// <summary>
        /// To provide airborne early warning and surveillance.
        /// </summary>
        [DomValIx(1000423)]
        [StringValue("AEW")]
        [EnumMember]
        AirborneEarlyWarning,
		
        /// <summary>
        /// To provide airborne early warning, surveillance and the control of airborne weapon systems.
        /// </summary>
        [DomValIx(1000424)]
        [StringValue("AEWCON")]
        [EnumMember]
        AirborneEarlyWarningAndControl,
		
        /// <summary>
        /// To protect and defend an area, a strike attack, an installation or naval forces.
        /// </summary>
        [DomValIx(1000425)]
        [StringValue("AIRDEF")]
        [EnumMember]
        AirDefence,
		
        /// <summary>
        /// To obtain a degree of dominance in the air battle of one force over another in order to permit the conduct of operations by the former and its related land, sea and air forces at a given time and place without prohibitive interference by the opposite force.
        /// </summary>
        [DomValIx(1000426)]
        [StringValue("AIRSUP")]
        [EnumMember]
        AirSuperiority,
		
        /// <summary>
        /// To destroy armoured targets.
        /// </summary>
        [DomValIx(1000427)]
        [StringValue("ANTARM")]
        [EnumMember]
        AntiArmour,
		
        /// <summary>
        /// To perform a short, violent, but well ordered, attack against a local objective such as a gun emplacement, a fort or a machine-gun nest.
        /// </summary>
        [DomValIx(1000428)]
        [StringValue("ARMAS")]
        [EnumMember]
        ArmedAssault,
		
        /// <summary>
        /// To provide communication means such as data links or radio for the purpose of communication, command, control and intelligence.
        /// </summary>
        [DomValIx(1000429)]
        [StringValue("COMC3I")]
        [EnumMember]
        CommunicationsC3I,
		
        /// <summary>
        /// To perform the launching of drones.
        /// </summary>
        [DomValIx(1000430)]
        [StringValue("DRONL")]
        [EnumMember]
        DroneLaunch,
		
        /// <summary>
        /// To perform electronic warfare actions to prevent or reduce an enemy’s effective use of the electromagnetic spectrum through the use of electromagnetic energy. There are three subdivisions of electronic countermeasures: electronic jamming, electronic deception and electronic neutralization.
        /// </summary>
        [DomValIx(1000431)]
        [StringValue("ELCCNM")]
        [EnumMember]
        ElectronicCounterMeasures,
		
        /// <summary>
        /// To gather imagery for intelligence purposes.
        /// </summary>
        [DomValIx(1000432)]
        [StringValue("IMINGT")]
        [EnumMember]
        ImageryIntelligenceGathering,
		
        /// <summary>
        /// To gather meteorological information such as humidity, pressure, and temperature characteristics of Earth’s atmosphere.
        /// </summary>
        [DomValIx(1000433)]
        [StringValue("METBAL")]
        [EnumMember]
        Meteorological,
		
        /// <summary>
        /// To perform mine countermeasures.
        /// </summary>
        [DomValIx(1000434)]
        [StringValue("MINCM")]
        [EnumMember]
        MineCountermeasures,
		
        /// <summary>
        /// To fly over an area, monitor and, where necessary, destroy hostile aircraft, as well as protect friendly shipping in the vicinity of the objective area.
        /// </summary>
        [DomValIx(1000435)]
        [StringValue("MPA")]
        [EnumMember]
        PatrolMaritime,
		
        /// <summary>
        /// To collect a series of photographs from which it is possible to create maps.
        /// </summary>
        [DomValIx(1000436)]
        [StringValue("PHOTO")]
        [EnumMember]
        PhotoMapping,
		
        /// <summary>
        /// To fly on a specific route in order to allow calibration of radars and radios.
        /// </summary>
        [DomValIx(1000437)]
        [StringValue("RCALIB")]
        [EnumMember]
        RadioRadarCalibration,
		
        /// <summary>
        /// To detect ECM activities and resources of an enemy or potential enemy in a particular area.
        /// </summary>
        [DomValIx(1000438)]
        [StringValue("RECECM")]
        [EnumMember]
        ReconnaissanceEcm,
		
        /// <summary>
        /// To obtain, by photographic means, information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographical, or geographical characteristics of a particular area.
        /// </summary>
        [DomValIx(1000439)]
        [StringValue("RECPHO")]
        [EnumMember]
        ReconnaissancePhotographic,
		
        /// <summary>
        /// To obtain, by radar detection methods, information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographical, or geographical characteristics of a particular area.
        /// </summary>
        [DomValIx(1000440)]
        [StringValue("RECRAD")]
        [EnumMember]
        ReconnaissanceRadar,
		
        /// <summary>
        /// To obtain information about the activities and resources of a target.
        /// </summary>
        [DomValIx(1000441)]
        [StringValue("RECTGT")]
        [EnumMember]
        ReconnaissanceTarget,
		
        /// <summary>
        /// To obtain visual information about the activities and resources of an enemy or potential enemy, or to secure data concerning the meteorological, hydrographical, or geographical characteristics of a particular area.
        /// </summary>
        [DomValIx(1000442)]
        [StringValue("RECVIS")]
        [EnumMember]
        ReconnaissanceVisual,
		
        /// <summary>
        /// To collect intelligence without engaging enemy forces.
        /// </summary>
        [DomValIx(1000443)]
        [StringValue("SCOUT")]
        [EnumMember]
        Scout,
		
        /// <summary>
        /// To intercept and gather electronic and communications transmissions for intelligence purposes.
        /// </summary>
        [DomValIx(1000444)]
        [StringValue("SINGA")]
        [EnumMember]
        SignalsIntelligenceGathering,
		
        /// <summary>
        /// To tow a target used for gunnery practice.
        /// </summary>
        [DomValIx(1000445)]
        [StringValue("TOWTGT")]
        [EnumMember]
        TowTarget,
		
        /// <summary>
        /// To move a unit by air and disembark or unload it, after the aircraft has landed or while a helicopter is hovering.
        /// </summary>
        [DomValIx(1000446)]
        [StringValue("AIRLND")]
        [EnumMember]
        Airland,
		
        /// <summary>
        /// To require a special airlift for which a need of special consideration due to the number of passengers involved or the weight or size of cargo, the urgency of movement, sensitivity, other valid factors such as the presence of the chairman of the joint chiefs of staff -directed or -coordinated exercises, that preclude the use of channel airlift.
        /// </summary>
        [DomValIx(1000447)]
        [StringValue("ARLFSA")]
        [EnumMember]
        AirliftSpecialAssignment,
		
        /// <summary>
        /// To provide air movement and delivery of personnel and equipment directly into objective areas through air landing, airdrop, extraction, or other delivery techniques; and the air logistic support of all theatre forces, including those engaged in combat operations, to meet specific theatre objectives and requirements.
        /// </summary>
        [DomValIx(1000448)]
        [StringValue("ARLFTR")]
        [EnumMember]
        AirliftTheatre,
		
        /// <summary>
        /// Combat air patrol flown in support of friendly aircraft as the aircraft ingress into enemy territory.
        /// </summary>
        [DomValIx(1000449)]
        [StringValue("CAPNGR")]
        [EnumMember]
        CombatAirPatrolIngress,
		
        /// <summary>
        /// An aircraft patrol flying over an objective area in order to protect friendly forces.
        /// </summary>
        [DomValIx(1000450)]
        [StringValue("CAPPRT")]
        [EnumMember]
        CombatAirPatrolProtect,
		
        /// <summary>
        /// Combat air patrol flown in support of surface vessels conducting maritime operations.
        /// </summary>
        [DomValIx(1000451)]
        [StringValue("CAPSRF")]
        [EnumMember]
        CombatAirPatrolSurface,
		
        /// <summary>
        /// To gather communication intelligence in order to meet current operational requirements.
        /// </summary>
        [DomValIx(1000452)]
        [StringValue("COMINC")]
        [EnumMember]
        CommunicationIntelligenceCollection,
		
        /// <summary>
        /// To destroy enemy defences in a specific area by any means.
        /// </summary>
        [DomValIx(1000453)]
        [StringValue("DEFDST")]
        [EnumMember]
        DefenceDestruction,
		
        /// <summary>
        /// To create a graphic representation, usually on a plane surface and at an established scale, of natural or artificial features on the surface of a part or the whole of the earth or other planetary body. The features are positioned relative to a coordinate reference system.
        /// </summary>
        [DomValIx(1000454)]
        [StringValue("MAP")]
        [EnumMember]
        Map,
		
        /// <summary>
        /// To obtain information concerning terrain, weather, and the disposition, composition, movement, installations, lines of communications, electronic and communication emissions of enemy forces. Also included are artillery and naval gunfire adjustment, and systematic and random observation of ground battle areas, targets, and/or sectors of airspace.
        /// </summary>
        [DomValIx(1000455)]
        [StringValue("RECCEL")]
        [EnumMember]
        ReconnaissanceLand,
		
        /// <summary>
        /// To observe an enemy unit or force, usually as a sequel to surveillance or reconnaissance, for the purpose of reporting its composition, location, movement, and any other relevant information.
        /// </summary>
        [DomValIx(1000456)]
        [StringValue("RECCES")]
        [EnumMember]
        ReconnaissanceShadow,
		
        /// <summary>
        /// To remove personnel from areas under enemy control by specially trained personnel qualified to penetrate to the site of an incident by land or parachute, render medical aid, accomplish survival methods, and rescue survivors.
        /// </summary>
        [DomValIx(1000457)]
        [StringValue("SARCME")]
        [EnumMember]
        SearchAndRescueCombatExfiltrate,
		
        /// <summary>
        /// To move through or into an area or territory occupied by either friendly or enemy troops or organisations specially trained personnel qualified to penetrate to the site of an incident by land or parachute, render medical aid, accomplish survival methods, and rescue survivors.
        /// </summary>
        [DomValIx(1000458)]
        [StringValue("SARCMI")]
        [EnumMember]
        SearchAndRescueCombatInfiltrate,
		
        /// <summary>
        /// Helicopter maintains station in vicinity of carrier for potential SAR during flight operations.
        /// </summary>
        [DomValIx(1000459)]
        [StringValue("SARPLG")]
        [EnumMember]
        SearchAndRescuePlaneGuard,
		
        /// <summary>
        /// To distribute fire in depth by successive changes in the elevation of the gun.
        /// </summary>
        [DomValIx(1000460)]
        [StringValue("SRCHFR")]
        [EnumMember]
        SearchByFire,
		
        /// <summary>
        /// A mission conducted by specially designated, organised, trained and equipped forces using operational techniques and modes of employment not standard to conventional forces. These activities are conducted across the full range of military operations independently or in coordination with operations of conventional forces to achieve political, military, psychological and economic objectives. Politico-military considerations may require clandestine, covert or discrete techniques and the acceptance of a degree of physical and political risk not associated with conventional operations.
        /// </summary>
        [DomValIx(1000461)]
        [StringValue("SPCOPS")]
        [EnumMember]
        SpecialOperations,
		
        /// <summary>
        /// To involve in emergency, military forces due to natural disasters, terrorists, subversives, or by required military operations. Due to the uncertainty of the situation, contingencies require plans, rapid response, and special procedures to ensure the safety and readiness of personnel, installations, and equipment.
        /// </summary>
        [DomValIx(1000462)]
        [StringValue("SPTCON")]
        [EnumMember]
        SupportContingency,
		
        /// <summary>
        /// To provide information required for decisions involving electronic warfare operations and other tactical actions such as threat avoidance, targeting, and homing.
        /// </summary>
        [DomValIx(1000463)]
        [StringValue("SPTELC")]
        [EnumMember]
        SupportElectronic,
		
        /// <summary>
        /// To observe aerospace, surface or subsurface areas, places, persons, or things, by visual, aural electronic, photographic, or other means.
        /// </summary>
        [DomValIx(1000464)]
        [StringValue("SURVLE")]
        [EnumMember]
        Surveillance,
		
        /// <summary>
        /// An offensive mission by fighter aircraft to seek out and destroy enemy aircraft and other targets of opportunity in an allocated area of operations.
        /// </summary>
        [DomValIx(1000465)]
        [StringValue("SWEEP")]
        [EnumMember]
        Sweep,
		
        /// <summary>
        /// Training operations or exercises. This training includes: a. delivery of personnel and equipment; b. Assault operations; c. Loading exercises and local orientation fights of short duration; and d. Manoeuvres and/or exercises as agreed upon by services concerned and/or as authorized by the joint chiefs of staff.
        /// </summary>
        [DomValIx(1000466)]
        [StringValue("TRANOP")]
        [EnumMember]
        TrainOperations,
		
        /// <summary>
        /// To transport cargo and/or passengers delivered by air-landing the aircraft to a combat zone.
        /// </summary>
        [DomValIx(1000467)]
        [StringValue("TRNSAA")]
        [EnumMember]
        TransportAssaultAirland,
		
        /// <summary>
        /// To confuse the enemy by temporary loss of vision or a temporary reduction in visual acuity; may also be applied to effects on optics.
        /// </summary>
        [DomValIx(1000468)]
        [StringValue("DAZZLE")]
        [EnumMember]
        Dazzle,
		
        /// <summary>
        /// To bring the enemy under fire.
        /// </summary>
        [DomValIx(1000469)]
        [StringValue("ENGAGE")]
        [EnumMember]
        Engage,
		
        /// <summary>
        /// To cover something by a smoke screen.
        /// </summary>
        [DomValIx(1000470)]
        [StringValue("OBSCUR")]
        [EnumMember]
        Obscure,
		
    }
}
