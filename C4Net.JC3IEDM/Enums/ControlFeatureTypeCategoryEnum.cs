using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CONTROL-FEATURE-TYPE.
    /// </summary>
    [DomId(100000128)]
    [DataContract]
    public enum ControlFeatureTypeCategoryEnum
    {
		
        /// <summary>
        /// A designated area in a hostile or threatened territory which, when seized and held, ensures the continuous air landing of troops and material and provides manoeuvre space for operations. Normally it is the area seized in the assault phase of an airborne or air assault operation. Army--The airhead contains enough drop zones (DZs), landing zones (LZs), and extraction zones (EZs) to ensure mass, interior lines of communication and defence in depth.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIRH")]
        [EnumMember]
        Airhead,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location which denotes that area of concern to the commander, including the area of influence, and extending into enemy territory to the objectives of current or planned operations. This area also includes areas occupied by enemy forces that could jeopardise the accomplishment of the mission.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AOI")]
        [EnumMember]
        AreaOfInterest,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location which defines an area of land in which responsibility is specifically assigned to the commander of the area for the development and maintenance of installations, control of movement and the conduct of tactical operations involving troops under his control along with parallel authority to exercise these functions.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("AOR")]
        [EnumMember]
        AreaOfResponsibility,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location assigned to artillery units for terrain management purposes on which the artillery manoeuvres.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ARA")]
        [EnumMember]
        ArtilleryArea,
		
        /// <summary>
        /// A general route of advance, assigned for control, which extends towards the enemy. An axis of advance symbol graphically portrays a commander’s intention, such as avoidance of built-up areas or envelopment of an enemy force. It follows terrain suitable for the size of the force to which the axis was assigned, and is often a road, a group of roads, or a designated series of locations. An axis of advance is not used to direct the control of terrain or the clearance of enemy forces from specific locations. Intermediate objectives are normally assigned for these purposes.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("AXIS")]
        [EnumMember]
        AxisOfAdvance,
		
        /// <summary>
        /// A designated area on a hostile or potentially hostile shore that, when seized and held, ensures the continuous landing of troops and materiel, and provides manoeuvre space requisite for subsequent projected operations ashore.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("BCHH")]
        [EnumMember]
        Beachhead,
		
        /// <summary>
        /// A point on a boundary.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("BDYPT")]
        [EnumMember]
        BoundaryPoint,
		
        /// <summary>
        /// An area of ground held or to be gained on the enemy’s side of an obstacle. Army--In river-crossing operations, an area on the enemy’s side of the water obstacle that is large enough to accommodate the majority of the crossing force, has adequate terrain to permit defence of the crossing sites, and provides a base for continuing the attack.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("BRDGH")]
        [EnumMember]
        Bridgehead,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location which defines the rear part of theatre of operations (behind but contiguous to the combat zone) which contains the lines of communication, establishments for supply and evacuation, and other agencies required for the immediate support and maintenance of the field forces.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("COMMZ")]
        [EnumMember]
        CommunicationZone,
		
        /// <summary>
        /// An area, usually in the theatre of operations, where troops are assembled before beginning active operations.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("CONCA")]
        [EnumMember]
        ConcentrationArea,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location that denotes the area required by combat forces for the conduct of operations.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("CZ")]
        [EnumMember]
        CombatZone,
		
        /// <summary>
        /// A specific direction or route that the main attack or the centre of mass of the unit main body of the force will follow.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("DA")]
        [EnumMember]
        DirectionOfAttack,
		
        /// <summary>
        /// A specific area upon which airborne troops, equipment, or supplies are airdropped by parachute. NOTE: This zone can include one or more drop sites.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("DZ")]
        [EnumMember]
        DropZone,
		
        /// <summary>
        /// An area where the commander intends to contain and destroy an enemy force with the massed fires of all available weapons and supporting systems.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("EA")]
        [EnumMember]
        EngagementArea,
		
        /// <summary>
        /// The line bounding a controlled area (such as crossing area) that controls entry to that area.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("ENTL")]
        [EnumMember]
        EntryLine,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location compromising the territory forward of the corps rear boundary.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("FCZ")]
        [EnumMember]
        ForwardCombatZone,
		
        /// <summary>
        /// The foremost limits of a series of areas in which ground combat units are deployed, excluding the areas in which the covering or screening forces are operating, designated to coordinate fire support, the positioning of forces, or the manoeuvre of units.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("FEBA")]
        [EnumMember]
        ForwardEdgeOfTheBattleArea,
		
        /// <summary>
        /// The specific location within an Artillery area CONTROL-FEATURE-TYPE from which a fire unit delivers fire.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("FIRING")]
        [EnumMember]
        FirePositionArea,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location that is established and adjusted by appropriate land or amphibious force commanders within their boundaries in consultation with superior, subordinate, supporting, and affected commanders. Fire support coordination lines (FSCLs) facilitate the expeditious attack of surface targets of opportunity beyond the coordinating measure.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("FSCL")]
        [EnumMember]
        FireSupportCoordinationLine,
		
        /// <summary>
        /// An area in which a force conceals itself before operations or before moving into battle position.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("HIDE")]
        [EnumMember]
        Hide,
		
        /// <summary>
        /// The part of the objective area within which the landing operations of an amphibious force are conducted.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("LA")]
        [EnumMember]
        LandingArea,
		
        /// <summary>
        /// The designation of forward friendly positions as the LD when opposing forces are in contact.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("LOC")]
        [EnumMember]
        LineOfContact,
		
        /// <summary>
        /// A specified area used for the landing of aircraft.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("LZ")]
        [EnumMember]
        LandingZone,
		
        /// <summary>
        /// A line short of which artillery or ships do not fire except on request or approval of the supported commander, but beyond which they may fire at any time without danger to friendly troops.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("NFL")]
        [EnumMember]
        NoFireLine,
		
        /// <summary>
        /// A defined geographical area within which is located an objective to be captured or reached by the military forces. This area is defined by competent authority for purposes of command and control.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("OBJA")]
        [EnumMember]
        ObjectiveArea,
		
        /// <summary>
        /// A line used for control and coordination of military operations, usually a terrain feature extending across the zone of action. Army-- A line used for control and coordination of military operations. It is usually along a recognisable terrain feature extending across the sector or zone of action. Units normally report crossing PLs, but do not halt unless specifically directed.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("PHLINE")]
        [EnumMember]
        PhaseLine,
		
        /// <summary>
        /// A geographic area used to pick up troops and/or equipment by helicopter.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("PZ")]
        [EnumMember]
        PickupZone,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location usually compromising the territory between the corps rear boundary and the army group rear boundary.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("RCZ")]
        [EnumMember]
        RearCombatZone,
		
        /// <summary>
        /// Phase line used in river-crossing operations that delineates a change in the headquarters controlling movement.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("RELL")]
        [EnumMember]
        ReleaseLine,
		
        /// <summary>
        /// A well-defined point on a route at which the elements composing a column return under the authority of their respective commanders, each one of these elements continuing its movement toward its own appropriate destination.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("RELPT")]
        [EnumMember]
        ReleasePoint,
		
        /// <summary>
        /// A line at which troops, after having reached it, must report to their command echelon.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("REPLIN")]
        [EnumMember]
        ReportLine,
		
        /// <summary>
        /// A line established between converging forces that prohibits fires or the effect of fires across the line without prior coordination.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("RFL")]
        [EnumMember]
        RestrictedFireLine,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with a line location to divide responsibility for the nomination of ground targets. Short of the RIPL the ground commander has this responsibility for nominating targets that have a direct bearing on the land battle. Beyond this, the targeting authority lies with the Air Commander.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("RIPL")]
        [EnumMember]
        ReconnaissanceAndInterdictionPlanningLine,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that is a general locality established for the concentration of organisations and transient persons between movements over the lines of communications.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("STAGA")]
        [EnumMember]
        StagingArea,
		
        /// <summary>
        /// A defensive position, usually strongly fortified and heavily armed with automatic weapons around which other positions are grouped for its protection. Army--A position requiring extensive engineering effort for obstacles and survivability positions and positioned to control or block an avenue of approach. Normally, command and control, aid stations, and critical supply stockpiles will be dug-in with overhead protection. Trenches and other protective construction will be done to protect soldiers and weapons from damage during assault by mounted and dismounted forces.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("STPT")]
        [EnumMember]
        StrongPoint,
		
        /// <summary>
        /// A well-defined point on a route at which movement of vehicles begins to be under the control of the commander of this movement. It is at this point that the column is formed by the successive passing, at an appointed time, of each of the elements composing the column. In addition to the principal start point of a column there may be secondary start points for its different elements.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("STRTPT")]
        [EnumMember]
        StartPoint,
		
        /// <summary>
        /// A location adjacent to the route or axis that may be used for the concealment of vehicles, troops, and equipment while an element is waiting to resume movement. Waiting areas are normally located on both banks close to crossing areas.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("WAITA")]
        [EnumMember]
        WaitingArea,
		
        /// <summary>
        /// A number of adjacent crossing sites under the control of one commander.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("XA")]
        [EnumMember]
        CrossingArea,
		
        /// <summary>
        /// The location along a water obstacle where the crossing can be made using amphibious vehicles, assault boats, rafts, bridges, or fording vehicles.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("XSITE")]
        [EnumMember]
        CrossingSite,
		
        /// <summary>
        /// An event, area, line, or point in the battlespace where tactical decisions are required resulting from the wargaming process or the operations order. Decision points do not dictate commander's decisions, they only indicate that a decision is required, and they indicate when/where the decision should be made to have the maximum effect on friendly or enemy courses of action.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("DECPNT")]
        [EnumMember]
        DecisionPoint,
		
        /// <summary>
        /// A point or area along a particular avenue of approach through which enemy activity is expected to occur. Activity or lack of activity within an NAI will help to confirm or deny a particular enemy course of action.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("NAMAIN")]
        [EnumMember]
        NamedAreaOfInterest,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies the contour of an area where supply units, depots, and dumps may be located.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("SUPARE")]
        [EnumMember]
        SupplyArea,
		
        /// <summary>
        /// Designated point at which, in all types of combat, adjacent units/formations must make contact for purposes of control and coordination. Army--A control measure that indicates a specific location for the coordination of fires and manoeuvre between adjacent units. They usually are indicated whenever a boundary crosses the forward battle area (FEBA), and may be indicated when a boundary crosses phase lines (PLs) used to control security forces.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("CRDPNT")]
        [EnumMember]
        CoordinatingPoint,
		
        /// <summary>
        /// A position along a route of march at which men are stationed to give information and instructions for the regulation of supply or traffic.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("CTLPNT")]
        [EnumMember]
        ControlPoint,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that is used in planning to designate a belt of terrain, generally parallel to the front, which includes two or more organised, or partially organised, battle positions.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("DEFPOS")]
        [EnumMember]
        DefensivePosition,
		
        /// <summary>
        /// An area or feature between the line of departure and an objective that must be seized and/or held.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("INTOBJ")]
        [EnumMember]
        IntermediateObjective,
		
        /// <summary>
        /// Any locality, or area, the seizure of which affords a marked advantage to either combatant.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("KEYTER")]
        [EnumMember]
        KeyTerrain,
		
        /// <summary>
        /// An area that is trafficable with difficulty.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("SGA")]
        [EnumMember]
        SlowGoArea,
		
        /// <summary>
        /// An area that is not trafficable.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("NGA")]
        [EnumMember]
        NoGoArea,
		
        /// <summary>
        /// 1. A line which delineates surface areas (or airspace) for the purpose of facilitating coordination and deconfliction of operations between adjacent units, formations or areas. 2. A control measure normally drawn along identifiable terrain features and used to delineate areas of tactical responsibility between adjacent units and between higher headquarters to the rear of the subordinate units. Control measures which define the left and right limits of a unit's zone of action or sector. Together with the rear and forward boundary and a coordinating altitude, lateral boundaries define the area of operations for a commander.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("BDYOR")]
        [EnumMember]
        BoundaryOrganisation,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with a line location by which political or administrative areas of responsibility are defined.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("BDYPOA")]
        [EnumMember]
        BoundaryPoliticalAdministrative,
		
        /// <summary>
        /// A point associated with a target and assigned for a specific weapon impact.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("AIMPT")]
        [EnumMember]
        AimPoint,
		
        /// <summary>
        /// The summation of geographical areas under surveillance or protected by supporting fire.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("AOC")]
        [EnumMember]
        AreaOfCoverage,
		
        /// <summary>
        /// The area extending from the forward edge of the battle area to its rear boundary.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("DEFZ")]
        [EnumMember]
        DefenceZone,
		
        /// <summary>
        /// A point designated for use by vehicles or personnel in entering an area, line or volume.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("ENTPT")]
        [EnumMember]
        EntryPoint,
		
        /// <summary>
        /// A point designated for use by vehicles or personnel in leaving an area, line or volume.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("EXITPT")]
        [EnumMember]
        ExitPoint,
		
        /// <summary>
        /// Minimum range to which an aircraft may close to a maritime force without having been positively identified as friendly.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("ISR")]
        [EnumMember]
        IdentificationSafetyRange,
		
        /// <summary>
        /// A well-defined point, easily distinguishable visually and/or electronically, used as a starting point for a weapons or reconnaissance run on a target.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("INITPT")]
        [EnumMember]
        InitialPoint,
		
        /// <summary>
        /// A zone in which a commander plans to force the enemy to concentrate so as to destroy him.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("KILLA")]
        [EnumMember]
        KillingArea,
		
        /// <summary>
        /// A line delineating the rear of an area in proximity to combat.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("RBFA")]
        [EnumMember]
        RearBoundaryOfTheForwardArea,
		
        /// <summary>
        /// An area (land, sea or air) reserved for non-combat operations of friendly aircraft, surface ships, submarines or ground forces.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("SAFZ")]
        [EnumMember]
        SafetyZone,
		
        /// <summary>
        /// An area into which a designated ground unit or fire support asset delivers, or is prepared to deliver, fires.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("ZFIRE")]
        [EnumMember]
        ZoneOfFire,
		
        /// <summary>
        /// The line extending outward from the area of Secondary Hazard marking the maximum extent to the left (facing in the effective downwind direction) where significant fallout is expected to occur.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("LRADLN")]
        [EnumMember]
        LeftRadialLine,
		
        /// <summary>
        /// A designated phase line forward of which vehicles are required to use blackout lights at night.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("LGHTLN")]
        [EnumMember]
        LightLine,
		
        /// <summary>
        /// An easily recognized terrain feature beyond which attacking elements will not advance.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("LIMADV")]
        [EnumMember]
        LimitOfAdvance,
		
        /// <summary>
        /// That portion of the battlespace in which the decisive battle is fought to defeat the enemy. For any particular command, the main battle area extends rearward from the forward edge of the battle area to the rear boundary of the command's subordinate units.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("MNBTAR")]
        [EnumMember]
        MainBattleArea,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The line extending outward from the area of Secondary Hazard marking the maximum extent to the right (facing in the effective downwind direction) where significant fallout is expected to occur.
        /// </summary>
        [DomValIx(1000096)]
        [StringValue("RRADLN")]
        [EnumMember]
        RightRadialLine,
		
        /// <summary>
        /// A circular area of Immediate Operational Concern where exposed, unprotected personnel may receive doses of 150 cGy or greater in relatively short periods of time (less than 4 hours after actual arrival of fallout). Major disruptions to unit operations and casualties may occur in some parts of this zone. However, radiation risk category for emergency risk is changing from 150 cGy to 125 cGy. Zone I is calculated on the basis of the weapon size and downwind speed. The boundary for Zone 1 is determined by drawing 2 lines tangent to the cloud radius circle and intersecting the points on the radial lines where the Zone 1 downwind distance arc intersects these lines.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("ZONEI")]
        [EnumMember]
        ZoneI,
		
        /// <summary>
        /// A circular area (less Zone I area) of Secondary Hazard where the total dose received by exposed, unprotected personnel is not expected to reach 150 cGy within a period of four hours after the actual arrival of fallout. Within this zone, personnel may receive a total dose of 50 cGy or greater within the first 24 hours after arrival of fallout. The boundaries of Zone II are determined by the Zone 1 downwind distance arc, the Zone 2 distance arc and the 2 radial lines.
        /// </summary>
        [DomValIx(1000098)]
        [StringValue("ZONEII")]
        [EnumMember]
        ZoneIi,
		
        /// <summary>
        /// An easily identifiable point on the terrain or an electronic navigational aid used to provide necessary control during air movement. Air control points are generally designated at each point where the flight route or air corridor makes a definite change in any direction and at any other point deemed necessary for timing or control of the operation.
        /// </summary>
        [DomValIx(1000101)]
        [StringValue("AIRCTP")]
        [EnumMember]
        AirControlPoint,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that is a three-dimensional block of airspace in a target area, established by the appropriate ground commander, in which friendly aircraft are reasonably safe from friendly surface fire. The ACA may be formal or informal.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("AIRCOA")]
        [EnumMember]
        AirspaceCoordinationArea,
		
        /// <summary>
        /// That portion of an area necessary for military operations and for the administration of such operations. Army--A geographical area, usually defined by lateral, forward, and rear boundaries assigned to a commander, by a higher commander, in which he has responsibility and the authority to conduct military operations.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("AOP")]
        [EnumMember]
        AreaOfOperations,
		
        /// <summary>
        /// That position between the line of departure (LD) and the objective in an attack from which forces assault the objective. Ideally, it is the last covered and concealed position before reaching the objective.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("ASLTPO")]
        [EnumMember]
        AssaultPosition,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that is an area against which fire is employed to destroy the enemy from a distance, normally used when the mission does not dictate or support occupation of the objective.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("ATTFIR")]
        [EnumMember]
        AttackByFirePosition,
		
        /// <summary>
        /// The last position occupied or passed through by the assault echelon before crossing the line of departure (LD).
        /// </summary>
        [DomValIx(1000108)]
        [StringValue("ATTPOS")]
        [EnumMember]
        AttackPosition,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that is the angle and direction from which electronic, acoustic, or optical contact is made.
        /// </summary>
        [DomValIx(1000109)]
        [StringValue("BERLIN")]
        [EnumMember]
        BearingLine,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies the predicted or confirmed contour of an area in which biological agents may produce casualties in man or animals and damage to plants or materiel.
        /// </summary>
        [DomValIx(1000110)]
        [StringValue("BIOCTM")]
        [EnumMember]
        BiologicallyContaminatedArea,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies the predicted or confirmed contour of an area in which chemical agents may produce casualties in man or animals and damage to plants or materiel.
        /// </summary>
        [DomValIx(1000111)]
        [StringValue("CHMCTM")]
        [EnumMember]
        ChemicallyContaminatedArea,
		
        /// <summary>
        /// An air control point that requires serial leaders to report either to the aviation mission commander or the terminal control facility.
        /// </summary>
        [DomValIx(1000112)]
        [StringValue("COMCKP")]
        [EnumMember]
        CommunicationCheckpoint,
		
        /// <summary>
        /// Position of weapon release.
        /// </summary>
        [DomValIx(1000113)]
        [StringValue("DROPPT")]
        [EnumMember]
        DropPoint,
		
        /// <summary>
        /// A point to where aviators will attempt to evade and escape to be recovered by friendly forces.
        /// </summary>
        [DomValIx(1000114)]
        [StringValue("DNPKPT")]
        [EnumMember]
        DownedAircrewPickupPoint,
		
        /// <summary>
        /// The loss of freedom of manoeuvre to one force resulting from an enemy force’s control of all routes of egress and reinforcement.
        /// </summary>
        [DomValIx(1000115)]
        [StringValue("ENCRCL")]
        [EnumMember]
        Encirclement,
		
        /// <summary>
        /// Checkpoint to ensure that vehicles do not exceed the capacity of the crossing means and to give drivers final instructions on site-specific procedures and information, such as speed and vehicle interval.
        /// </summary>
        [DomValIx(1000116)]
        [StringValue("ENGREG")]
        [EnumMember]
        EngineerRegulatingPoint,
		
        /// <summary>
        /// A specified drop zone used for the delivery of equipment and/or supplies by means of an extraction technique from an aircraft flying very close to the ground.
        /// </summary>
        [DomValIx(1000117)]
        [StringValue("EXTZON")]
        [EnumMember]
        ExtractionZone,
		
        /// <summary>
        /// A line close to the enemy position used to coordinate the lifting and/or shifting of supporting fires with the final deployment of manoeuvre elements. It should be recognisable on the ground. It is not a fire support coordination measure.
        /// </summary>
        [DomValIx(1000118)]
        [StringValue("FNCOLN")]
        [EnumMember]
        FinalCoordinationLine,
		
        /// <summary>
        /// An area of forward area air defence (FAAD) deployment that may fall within a missile engagement zone.
        /// </summary>
        [DomValIx(1000119)]
        [StringValue("FWDZON")]
        [EnumMember]
        ForwardAreaAirDefenceZone,
		
        /// <summary>
        /// Line indicating the most forward positions of friendly forces in any kind of military operation at a specific time.
        /// </summary>
        [DomValIx(1000120)]
        [StringValue("FLT")]
        [EnumMember]
        ForwardLineOfTroops,
		
        /// <summary>
        /// Supplementary permissive fire support coordination measure, established to facilitate the rapid engagement of targets of opportunity, into which any weapon system may fire without additional coordination with the establishing headquarters.
        /// </summary>
        [DomValIx(1000121)]
        [StringValue("FREFIR")]
        [EnumMember]
        FreeFireArea,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies an area defined by a higher commander within which the subordinate must accomplish his mission and protect his forces. It applies to both land and naval forces.
        /// </summary>
        [DomValIx(1000122)]
        [StringValue("GENARE")]
        [EnumMember]
        GeneralArea,
		
        /// <summary>
        /// The airspace of defined dimensions within which the responsibility for engagement of air threats normally rests with high-altitude surface-to-air missiles.
        /// </summary>
        [DomValIx(1000123)]
        [StringValue("HAMZON")]
        [EnumMember]
        HighAltitudeMissileEngagementZone,
		
        /// <summary>
        /// Airspace designated in an airspace control plan or airspace control order in which there is a concentrated employment of numerous and varied weapons and airspace users. A high-density airspace control zone has defined dimensions that usually coincide with geographical features or navigational aids. Access to a high-density airspace control zone is normally controlled by the manoeuvre commander. The manoeuvre commander can also direct a more restrictive weapons status within the high-density airspace control zone.
        /// </summary>
        [DomValIx(1000124)]
        [StringValue("HDAZON")]
        [EnumMember]
        HighDensityAirspaceControlZone,
		
        /// <summary>
        /// 1. The point on the drop zone where the first parachutist or air dropped cargo item lands or is expected to land. See FM 90-26. 2. The point at which a projectile, bomb, or re-entry vehicle impacts or is expected to impact.
        /// </summary>
        [DomValIx(1000125)]
        [StringValue("IMPTPT")]
        [EnumMember]
        ImpactPoint,
		
        /// <summary>
        /// An infiltration lane is a control measure that fixes fire planning responsibilities and coordinates forward and lateral movement of infiltrating units.
        /// </summary>
        [DomValIx(1000126)]
        [StringValue("INFLIN")]
        [EnumMember]
        InfiltrationLine,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location to indicate to what personnel or equipment the area is impassable. Note - this definition does not identify whether it is a procedural issue, limitation or a trafficability issue.
        /// </summary>
        [DomValIx(1000127)]
        [StringValue("LIMARE")]
        [EnumMember]
        LimitedAccessArea,
		
        /// <summary>
        /// An easily recognisable point location on the ground where two forces conducting a linkup meet. When one force is stationary, linkup points normally are established where the moving force's routes of advance intersect the stationary force's security elements. Linkup points for two moving forces are established on boundaries where the two forces are expected to converge.
        /// </summary>
        [DomValIx(1000128)]
        [StringValue("LNKPPT")]
        [EnumMember]
        LinkupPoint,
		
        /// <summary>
        /// Airspace within which the responsibility for engagement normally rests with the commander of the low-to-medium altitude GBAD systems.
        /// </summary>
        [DomValIx(1000129)]
        [StringValue("LAMZON")]
        [EnumMember]
        LowAltitudeMissileEngagementZone,
		
        /// <summary>
        /// An area/airspace in which fires or the effects of fires are not allowed without prior clearance from the establishing headquarters, except when a force must defend itself against an engaging enemy force within the no fire area.
        /// </summary>
        [DomValIx(1000132)]
        [StringValue("NFRARE")]
        [EnumMember]
        NoFireArea,
		
        /// <summary>
        /// Normally, a brigade-level obstacle control measure that specifies the intent and location of subordinate obstacles. It also supports the intent of the higher headquarters obstacle zone.
        /// </summary>
        [DomValIx(1000133)]
        [StringValue("OBSBLT")]
        [EnumMember]
        ObstacleBelt,
		
        /// <summary>
        /// An area the commander designates as restricted from the emplacement of man-made obstacles, normally to facilitate future operations.
        /// </summary>
        [DomValIx(1000134)]
        [StringValue("OBFARE")]
        [EnumMember]
        ObstacleFreeArea,
		
        /// <summary>
        /// An area within a minefield or obstacle belt, free of live mines or obstacles, whose width and direction will allow a friendly force to pass through in tactical formation.
        /// </summary>
        [DomValIx(1000135)]
        [StringValue("OBSGAP")]
        [EnumMember]
        ObstacleGap,
		
        /// <summary>
        /// A route through an enemy or friendly obstacle that provides a passing force safe passage. The route may be reduced and proofed as part of a breach operation, or constructed as part of a friendly obstacle. A clear route through an obstacle.
        /// </summary>
        [DomValIx(1000136)]
        [StringValue("OBSLAN")]
        [EnumMember]
        ObstacleLane,
		
        /// <summary>
        /// A conceptual control measure used at battalion or brigade level to show placement intent without specifying a particular type of linear obstacle.
        /// </summary>
        [DomValIx(1000137)]
        [StringValue("OBSLIN")]
        [EnumMember]
        ObstacleLine,
		
        /// <summary>
        /// A command and control measure used to limit the type or number of obstacles within an area.
        /// </summary>
        [DomValIx(1000138)]
        [StringValue("OBRARE")]
        [EnumMember]
        ObstacleRestrictedArea,
		
        /// <summary>
        /// A division-level command and control measure, normally done graphically, to designate specific land areas where lower echelons are allowed to employ tactical obstacles.
        /// </summary>
        [DomValIx(1000139)]
        [StringValue("OBSZON")]
        [EnumMember]
        ObstacleZone,
		
        /// <summary>
        /// A specifically designated place where units will pass through one another either in an advance or withdrawal. It is located where the commander desires subordinate units to physically execute a passage of lines.
        /// </summary>
        [DomValIx(1000140)]
        [StringValue("PSSGPT")]
        [EnumMember]
        PassagePoint,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that defines the area intended for penetration through enemy defences, a form of offensive which seeks to break through the enemy's defence and disrupt the defensive system.
        /// </summary>
        [DomValIx(1000141)]
        [StringValue("PNTRBX")]
        [EnumMember]
        PenetrationBox,
		
        /// <summary>
        /// In night or limited visibility attacks, a specific place on the line of departure (LD) where a unit will cross.
        /// </summary>
        [DomValIx(1000142)]
        [StringValue("PTDPRT")]
        [EnumMember]
        PointOfDeparture,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with a point location that is significant for military planning or activity.
        /// </summary>
        [DomValIx(1000143)]
        [StringValue("PTINT")]
        [EnumMember]
        PointOfInterest,
		
        /// <summary>
        /// The location at which aircraft quickly gain altitude for target acquisition and engagement.
        /// </summary>
        [DomValIx(1000144)]
        [StringValue("POPUPT")]
        [EnumMember]
        PopUpPoint,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies the predicted or confirmed contour of an area in which radiological materials may produce casualties in man or animals and damage to plants or materiel.
        /// </summary>
        [DomValIx(1000145)]
        [StringValue("RADARE")]
        [EnumMember]
        RadioactiveArea,
		
        /// <summary>
        /// An easily identifiable point location on the ground at which units can reassemble/reorganise if they become disbursed or aircrews/passengers can assemble and reorganise following an incident requiring a forced landing.
        /// </summary>
        [DomValIx(1000146)]
        [StringValue("RALYPT")]
        [EnumMember]
        RallyPoint,
		
        /// <summary>
        /// An area/airspace into which specific restrictions are imposed and into which fires that exceed those restrictions are prohibited without prior coordination.
        /// </summary>
        [DomValIx(1000147)]
        [StringValue("RSFARE")]
        [EnumMember]
        RestrictedFireArea,
		
        /// <summary>
        /// A volume of airspace of defined dimensions designated for a specific operational mission. Entry into that zone is authorised only by the originating headquarters.
        /// </summary>
        [DomValIx(1000148)]
        [StringValue("RSOPZN")]
        [EnumMember]
        RestrictedOperationsZone,
		
        /// <summary>
        /// Used to depict the area within which a unit or formation is responsible for reconnaissance. As shown, the points of the arrows indicate the width of that area but not its forward edge.
        /// </summary>
        [DomValIx(1000149)]
        [StringValue("SEREAR")]
        [EnumMember]
        SearchAreaReconnaissanceArea,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that is an area by which a manoeuvre element moves to a position in the battlespace where it can engage the enemy by direct fire. The manoeuvre element does not attempt to manoeuvre to capture enemy forces or terrain.
        /// </summary>
        [DomValIx(1000151)]
        [StringValue("SPTPOS")]
        [EnumMember]
        SupportByFirePosition,
		
        /// <summary>
        /// An easily recognisable point location on the ground (either natural or man-made) used to initiate, distribute, and control fires. TRPs can also designate the centre of an area where the commander plans to distribute or converge the fires of all his weapons rapidly. They are used by task force and below, and can further delineate sectors of fire within an engagement area. TRPs are designated using the standard target symbol and numbers issued by the fire support officer. Once designated, TRPs also constitute indirect fire targets.
        /// </summary>
        [DomValIx(1000152)]
        [StringValue("TGTRPT")]
        [EnumMember]
        TargetReferencePoint,
		
        /// <summary>
        /// The geographical area or point along a mobility corridor the successful interdiction of which will cause an enemy to either abandon a particular course of action or require him to use specialized engineer support to continue and where he can be acquired and engaged by friendly forces. Not all TAI will form part of the friendly COA; only TAI associated with higher payoff targets (HTP) are of interest to the staff. These are identified during staff planning and wargaming. TAI differ from engagement areas in degree. Engagement areas plan for the use of all available weapons; TAI might be engaged by a single weapon.
        /// </summary>
        [DomValIx(1000153)]
        [StringValue("TGTAOI")]
        [EnumMember]
        TargetedAreaOfInterest,
		
        /// <summary>
        /// An area in which there are unexploded ordnance. Explosive ordnance which has been primed, fused, armed, or otherwise prepared for action, and which has been fired, dropped, launched, or placed in such a manner as to constitute a hazard to operations, installations, personnel, or material, and remains unexploded either by malfunction or for any other cause.
        /// </summary>
        [DomValIx(1000154)]
        [StringValue("UNEXOD")]
        [EnumMember]
        UnexplodedOrdnanceArea,
		
        /// <summary>
        /// 1. In air operations, a point or a series of points in space to which an aircraft, ship, or cruise missile may be vectored. 2. A designated point or series of points loaded and stored in a global positioning system or other electronic navigational aid system to facilitate movement.
        /// </summary>
        [DomValIx(1000156)]
        [StringValue("WAYPT")]
        [EnumMember]
        WayPoint,
		
        /// <summary>
        /// An air defence zone (ADZ) established around key assets or facilities which merit special protection by ground based air defence assets, other than airbases, where weapons may be fired at any target not positively identified as friendly.
        /// </summary>
        [DomValIx(1000157)]
        [StringValue("WPNFZN")]
        [EnumMember]
        WeaponsFreeZone,
		
        /// <summary>
        /// A line beyond which conventional surface fire support may fire at any time within the area of operations of the establishing headquarters without additional coordination. NOTE Also known as Coordinated fire line.
        /// </summary>
        [DomValIx(1000158)]
        [StringValue("CFL")]
        [EnumMember]
        CoordinationFireLine,
		
        /// <summary>
        /// An immediately available prearranged barrier of fire designed to impede enemy movement across defensive lines or areas.
        /// </summary>
        [DomValIx(1000159)]
        [StringValue("FNPRFR")]
        [EnumMember]
        FinalProtectiveFire,
		
        /// <summary>
        /// Minimum Safe Distance 1 identifies the minimum safe distance for warned, protected personnel measured to the nearest 100 metres from the expected ground zero. The recommended action within Minimum Safe Distance 1 prior to strike is evacuation of all personnel (if evacuation is not possible or if a commander elects a higher degree of risk, maximum protective measures will be required). Minimum Safe Distance 1 is used when there is a single burst.
        /// </summary>
        [DomValIx(1000164)]
        [StringValue("MNSFD1")]
        [EnumMember]
        MinimumSafeDistance1,
		
        /// <summary>
        /// Minimum Safe Distance 2 identifies the minimum safe distance for warned, exposed personnel measured to the nearest 100 metres from the planned ground zero. Within Minimum Safe Distance 2 and outside of Minimum Safe Distance 1 there is a limit of negligible risk to warned and protected personnel. Maximum protective measures will be required. Minimum Safe Distance 2 is used when there is a single burst.
        /// </summary>
        [DomValIx(1000165)]
        [StringValue("MNSFD2")]
        [EnumMember]
        MinimumSafeDistance2,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies the predicted or confirmed contour of the NBC (CBRN) hazard area.
        /// </summary>
        [DomValIx(1000167)]
        [StringValue("CBRNHA")]
        [EnumMember]
        CbrnHazardArea,
		
        /// <summary>
        /// The point at which a reading, sample or detection of an NBC (CBRN) contaminant is performed.
        /// </summary>
        [DomValIx(1000168)]
        [StringValue("CBRNRS")]
        [EnumMember]
        CbrnReadingSampleDetection,
		
        /// <summary>
        /// The boundary of the region of the atmosphere where radar measurements indicate the presence of suspended radioactive material.
        /// </summary>
        [DomValIx(1000170)]
        [StringValue("RADCLD")]
        [EnumMember]
        RadarDeterminedContourOfRadioactiveCloud,
		
        /// <summary>
        /// The predicted or confirmed contour of the toxic industrial material isolation and hazard area.
        /// </summary>
        [DomValIx(1000171)]
        [StringValue("ROTAAR")]
        [EnumMember]
        ReleaseOtherThanAttackRotaIsolationAndHazardArea,
		
        /// <summary>
        /// An area to which access is denied by civil authority or group of people (e.g. faction, gang, militia).
        /// </summary>
        [DomValIx(1000174)]
        [StringValue("NGACIV")]
        [EnumMember]
        NoGoAreaCivil,
		
        /// <summary>
        /// An area in which a command is assembled preparatory to further action.
        /// </summary>
        [DomValIx(1000175)]
        [StringValue("ASYGEN")]
        [EnumMember]
        AssemblyAreaGeneral,
		
        /// <summary>
        /// In a supply installation, the gross area used for collecting and combining components into complete units, kits, or assemblies.
        /// </summary>
        [DomValIx(1000176)]
        [StringValue("ASYSPL")]
        [EnumMember]
        AssemblyAreaSupply,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE used as a means of controlling movement, a registration target for fire adjustment, or reference for location.
        /// </summary>
        [DomValIx(1000177)]
        [StringValue("CKPGEN")]
        [EnumMember]
        CheckPointGeneral,
		
        /// <summary>
        /// A line designated to coordinate the departure of attack elements (commitment of attacking units or scouting elements at a specific time).
        /// </summary>
        [DomValIx(1000179)]
        [StringValue("LODLND")]
        [EnumMember]
        LineOfDepartureLand,
		
        /// <summary>
        /// A suitably marked offshore coordinating line to assist assault craft to land on designated beaches at scheduled times.
        /// </summary>
        [DomValIx(1000180)]
        [StringValue("LODSEA")]
        [EnumMember]
        LineOfDepartureSea,
		
        /// <summary>
        /// In air defence, that airspace of defined dimensions within which the responsibility for engagement of air threats normally rests with short-range air defence weapons. It may be established within a low or high altitude missile engagement.
        /// </summary>
        [DomValIx(1000181)]
        [StringValue("MEZ")]
        [EnumMember]
        MissileEngagementZoneGeneral,
		
        /// <summary>
        /// Airspace in which friendly surface-to-air missiles and fighters are simultaneously employed and operated.
        /// </summary>
        [DomValIx(1000182)]
        [StringValue("JEZ")]
        [EnumMember]
        JointEngagementZone,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that marks a point or area where alleged kills have occurred.
        /// </summary>
        [DomValIx(1000183)]
        [StringValue("SITKIL")]
        [EnumMember]
        SiteOfAllegedKills,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that approximates the location of the airspace of an airfield.
        /// </summary>
        [DomValIx(1000184)]
        [StringValue("ARFLDZ")]
        [EnumMember]
        AirfieldZone,
		
        /// <summary>
        /// A geographically or electronically defined location used in stationing aircraft in flight during tactical operations when a predetermined pattern is not established.
        /// </summary>
        [DomValIx(1000185)]
        [StringValue("ORBTPT")]
        [EnumMember]
        OrbitPoint,
		
        /// <summary>
        /// An area or a group of targets constituting an area designated for bombing.
        /// </summary>
        [DomValIx(1000186)]
        [StringValue("BOMBAR")]
        [EnumMember]
        BombArea,
		
        /// <summary>
        /// No definition provided in APP-6B JUN 08.
        /// </summary>
        [DomValIx(1000187)]
        [StringValue("NUCTGT")]
        [EnumMember]
        NuclearTarget,
		
        /// <summary>
        /// A procedural airspace control method to separate fixed-and rotary-wing aircraft by determining an altitude below which fixed-wing aircraft will normally not fly and above which rotary-wing aircraft normally will not fly. The coordinating altitude is normally specified in the airspace control plan and may include a buffer zone for small altitude deviations.
        /// </summary>
        [DomValIx(1000188)]
        [StringValue("CRDALT")]
        [EnumMember]
        CoordinatingAltitude,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies the position at which a mission leader makes radio contact with an air control agency. Note: A point used for control purposes in air-to-air refuelling and close air support missions.
        /// </summary>
        [DomValIx(1000189)]
        [StringValue("CNTPTA")]
        [EnumMember]
        ContactPointAir,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an easily identifiable point location, where two or more units are required to make contact.
        /// </summary>
        [DomValIx(1000190)]
        [StringValue("CNTPTL")]
        [EnumMember]
        ContactPointLand,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies the point that marks the end of a straight-line segment along which a tanker aircraft offloads fuel to a receiving aircraft.
        /// </summary>
        [DomValIx(1000191)]
        [StringValue("ENDARP")]
        [EnumMember]
        EndAerialRefuellingPoint,
		
        /// <summary>
        /// The point in a non-precision approach where the final approach normally begins.
        /// </summary>
        [DomValIx(1000192)]
        [StringValue("FINAPF")]
        [EnumMember]
        FinalApproachFix,
		
        /// <summary>
        /// The point in an instrument approach that the aircraft has departed and is manoeuvring to enter the intermediate or final approach.
        /// </summary>
        [DomValIx(1000193)]
        [StringValue("INIAPF")]
        [EnumMember]
        InitialApproachFix,
		
        /// <summary>
        /// No definition provided in APP-6B JUN 08.
        /// </summary>
        [DomValIx(1000194)]
        [StringValue("MSLDET")]
        [EnumMember]
        MissileDetectPoint,
		
        /// <summary>
        /// A given location at which to regroup before, during or after an operation at a specified time or in a specified situation.
        /// </summary>
        [DomValIx(1000195)]
        [StringValue("RNDZPT")]
        [EnumMember]
        RendezvousPoint,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location, delineated in the initiating directive, for purposes of command and control within which is located the objective(s) to be secured by the amphibious task force.
        /// </summary>
        [DomValIx(1000196)]
        [StringValue("AMPHOA")]
        [EnumMember]
        AmphibiousOperationArea,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with a point location that specifies the centre point of a search area.
        /// </summary>
        [DomValIx(1000197)]
        [StringValue("SRCHAR")]
        [EnumMember]
        SearchCentre,
		
        /// <summary>
        /// An area and the airspace above it within which friendly aircraft or surface-to-air weapons are normally given precedence in operations except under specified conditions.
        /// </summary>
        [DomValIx(1000199)]
        [StringValue("ADACAR")]
        [EnumMember]
        AirDefenceActionArea,
		
        /// <summary>
        /// Airspace within which ready identification, location, and control of airborne vehicles are required.
        /// </summary>
        [DomValIx(1000200)]
        [StringValue("ADIDZN")]
        [EnumMember]
        AirDefenceIdentificationZone,
		
        /// <summary>
        /// Airspace established specifically for airborne platforms conducting early warning.
        /// </summary>
        [DomValIx(1000203)]
        [StringValue("AIREWA")]
        [EnumMember]
        AirborneEarlyWarningArea,
		
        /// <summary>
        /// Airspace which is laterally defined by boundaries of the area of operations.
        /// </summary>
        [DomValIx(1000204)]
        [StringValue("AIRCAR")]
        [EnumMember]
        AirspaceControlArea,
		
        /// <summary>
        /// Sub-element of an airspace control area, established to facilitate the control of the overall area.
        /// </summary>
        [DomValIx(1000205)]
        [StringValue("AIRCSA")]
        [EnumMember]
        AirspaceControlSubareaSector,
		
        /// <summary>
        /// Airspace of defined dimensions set aside for air-to-air refuelling operations, excluding special operation forces air-to-air missions.
        /// </summary>
        [DomValIx(1000206)]
        [StringValue("AIRRFL")]
        [EnumMember]
        AirToAirRefuellingArea,
		
        /// <summary>
        /// Airspace which may contain a high volume of pilot training activities or an unusual type of aerial activity, neither of which is hazardous to aircraft.
        /// </summary>
        [DomValIx(1000208)]
        [StringValue("ALRTAR")]
        [EnumMember]
        AlertArea,
		
        /// <summary>
        /// Block of altitude, normally medium to high, reserved for aircraft to transit or loiter within the Force Air Coordination Area (FACA) for mission accomplishment.
        /// </summary>
        [DomValIx(1000209)]
        [StringValue("ALTRAR")]
        [EnumMember]
        AltitudeReservationArea,
		
        /// <summary>
        /// Area encompassing the amphibious objective area and adjoining airspace as required for the accompanying naval force.
        /// </summary>
        [DomValIx(1000210)]
        [StringValue("AMPDZN")]
        [EnumMember]
        AmphibiousDefenceZone,
		
        /// <summary>
        /// Geographic area delineated for the purpose of command and control within which is located the objective(s) to be secured by the amphibious task force.
        /// </summary>
        [DomValIx(1000211)]
        [StringValue("AMPOZN")]
        [EnumMember]
        AmphibiousObjectiveArea,
		
        /// <summary>
        /// A zone established around airbases to enhance the effectiveness of local ground based air defence systems.
        /// </summary>
        [DomValIx(1000214)]
        [StringValue("BASDZN")]
        [EnumMember]
        BaseDefenceZone,
		
        /// <summary>
        /// Airspace designed specifically to provide a buffer between various airspace control measures.
        /// </summary>
        [DomValIx(1000215)]
        [StringValue("BUFRZN")]
        [EnumMember]
        BufferZone,
		
        /// <summary>
        /// An established reference point from which the position of an object can be references by bearing (Magnetic) and range (in nautical miles NM) from this point.
        /// </summary>
        [DomValIx(1000216)]
        [StringValue("BULEYE")]
        [EnumMember]
        Bullseye,
		
        /// <summary>
        /// Area around a ship operating fixed/rotary wing aircraft.
        /// </summary>
        [DomValIx(1000217)]
        [StringValue("CRCNZN")]
        [EnumMember]
        CarrierControlZone,
		
        /// <summary>
        /// An airspace in which only instrument flight rule flights are permitted; all flights are subject to air traffic control service and are separated from each other.
        /// </summary>
        [DomValIx(1000218)]
        [StringValue("CLSASP")]
        [EnumMember]
        ClassAAirspace,
		
        /// <summary>
        /// An airspace in which instrument flight rule and visual flight rule flights are permitted; all flights are subject to air traffic control service and are separated from each other.
        /// </summary>
        [DomValIx(1000219)]
        [StringValue("CLSBSP")]
        [EnumMember]
        ClassBAirspace,
		
        /// <summary>
        /// An airspace in which instrument flight rule and visual flight rule flights are permitted; all flights are subject to air traffic control service and instrument flight rule flights are separated from other instrument flight rule flights and from visual flight rule flights. Visual flight rule flights are separated from instrument flight rule flights and receive traffic information in respect to other visual flight rule flights.
        /// </summary>
        [DomValIx(1000220)]
        [StringValue("CLSCSP")]
        [EnumMember]
        ClassCAirspace,
		
        /// <summary>
        /// An airspace in which instrument flight rule and visual flight rule flights are permitted; all flights are subject to air traffic control service and instrument flight rule flights are separated from other instrument flight rule flights and receive traffic information in respect to visual flight rule flights. Visual flight rule flights receive traffic information in respect to all other flights.
        /// </summary>
        [DomValIx(1000221)]
        [StringValue("CLSDSP")]
        [EnumMember]
        ClassDAirspace,
		
        /// <summary>
        /// An airspace in which instrument flight rule flights and visual flight rule flights are permitted; all flights are subject to air traffic control service and are separated from other instrument flight rule flights. All flights receive traffic information as far as practical.
        /// </summary>
        [DomValIx(1000222)]
        [StringValue("CLSESP")]
        [EnumMember]
        ClassEAirspace,
		
        /// <summary>
        /// An airspace in which instrument flight rule and visual flight rule flights are permitted; all participating instrument flight rule flights receive an air traffic advisory service and all flights receive flight information service if requested.
        /// </summary>
        [DomValIx(1000223)]
        [StringValue("CLSFSP")]
        [EnumMember]
        ClassFAirspace,
		
        /// <summary>
        /// An airspace in which instrument flight rule and visual flights are permitted; all flights receive flight information service if requested.
        /// </summary>
        [DomValIx(1000224)]
        [StringValue("CLSGSP")]
        [EnumMember]
        ClassGAirspace,
		
        /// <summary>
        /// Airspace designed for holding orbit and used by rotary and fixed-winged aircraft in close proximity to friendly forces.
        /// </summary>
        [DomValIx(1000225)]
        [StringValue("CLSHAR")]
        [EnumMember]
        CloseAirSupportHoldingArea,
		
        /// <summary>
        /// A controlled airspace extending upwards from a specified limit above the earth.
        /// </summary>
        [DomValIx(1000227)]
        [StringValue("CONTAR")]
        [EnumMember]
        ControlArea,
		
        /// <summary>
        /// A controlled airspace extending upwards from the surface of the earth to a specified upper limit.
        /// </summary>
        [DomValIx(1000228)]
        [StringValue("CONTZN")]
        [EnumMember]
        ControlZone,
		
        /// <summary>
        /// A mutually defined block of airspace between land-based air commander and a naval commander when their forces are operating in close proximity to one another.
        /// </summary>
        [DomValIx(1000229)]
        [StringValue("COOAAR")]
        [EnumMember]
        CoordinatedAirDefenceArea,
		
        /// <summary>
        /// A procedural method to separate fixed and rotary wing aircraft by determining an altitude below which fixed wing aircraft normally will not fly.
        /// </summary>
        [DomValIx(1000230)]
        [StringValue("COORLV")]
        [EnumMember]
        CoordinationLevel,
		
        /// <summary>
        /// A temporary segregated area established over international boundaries for specific operational requirements.
        /// </summary>
        [DomValIx(1000231)]
        [StringValue("CRSBAR")]
        [EnumMember]
        CrossBorderArea,
		
        /// <summary>
        /// The airspace beyond the maritime Missile Engagement Zone (MEZ) that may be entered by Combat Air Patrol (CAP) aircraft when in hot pursuit in order to complete an interception.
        /// </summary>
        [DomValIx(1000232)]
        [StringValue("CRSVZN")]
        [EnumMember]
        CrossoverZone,
		
        /// <summary>
        /// An airspace of defined dimensions within which activities dangerous to the flight of aircraft may exist at specified times.
        /// </summary>
        [DomValIx(1000233)]
        [StringValue("DNGRAR")]
        [EnumMember]
        DangerArea,
		
        /// <summary>
        /// The forward boundary of the ground component commander's (GCC) area of operation. The DBSL defines the geographic areas of responsibility of the GCC and air component commander.
        /// </summary>
        [DomValIx(1000234)]
        [StringValue("DPBSLN")]
        [EnumMember]
        DeepBattleSynchronisationLine,
		
        /// <summary>
        /// Airspace established specifically for airborne platforms engaging in electronic combat.
        /// </summary>
        [DomValIx(1000235)]
        [StringValue("ELCCAR")]
        [EnumMember]
        ElectronicCombatArea,
		
        /// <summary>
        /// Planned magnetic bearings along which aircraft depart and return to ships.
        /// </summary>
        [DomValIx(1000237)]
        [StringValue("FALRAR")]
        [EnumMember]
        FalconRadialsArea,
		
        /// <summary>
        /// The airspace over a naval force at sea within the fire of ships' anti-aircraft weapons can endanger aircraft, and within which special procedures are established for identification and operation of friendly aircraft.
        /// </summary>
        [DomValIx(1000238)]
        [StringValue("FIRUMB")]
        [EnumMember]
        FireUmbrella,
		
        /// <summary>
        /// An airspace of defined dimensions within which flight information service and alerting service are provided.
        /// </summary>
        [DomValIx(1000239)]
        [StringValue("FLINRG")]
        [EnumMember]
        FlightInformationRegion,
		
        /// <summary>
        /// An area surrounding a force within which air coordination measures are required to prevent mutual interference between all friendly surface and air units and their weapon systems.
        /// </summary>
        [DomValIx(1000240)]
        [StringValue("FOACAR")]
        [EnumMember]
        ForceAirCoordinationArea,
		
        /// <summary>
        /// An advanced position, usually of a temporary nature, from which air or ground units operate.
        /// </summary>
        [DomValIx(1000241)]
        [StringValue("FOOPLN")]
        [EnumMember]
        ForwardOperatingLocation,
		
        /// <summary>
        /// A point at which the control of the aircraft, if radar hand over is used, changes from one controller to another.
        /// </summary>
        [DomValIx(1000242)]
        [StringValue("HNDVGT")]
        [EnumMember]
        HandOverGate,
		
        /// <summary>
        /// A point at which aircraft, on joining a maritime force, will attempt to establish two-way communications with the surface force and commence identification procedures.
        /// </summary>
        [DomValIx(1000243)]
        [StringValue("IDSFPT")]
        [EnumMember]
        IdentificationSafetyPoint,
		
        /// <summary>
        /// Line demarking where friendly aircraft enroute to targets stop emitting an Identification-Friend-Foe signal.
        /// </summary>
        [DomValIx(1000244)]
        [StringValue("IFFOFF")]
        [EnumMember]
        IdentificationFriendFoeSwitchOffLine,
		
        /// <summary>
        /// Line demarking where friendly aircraft returning to friendly territory start emitting an Identification-Friend-Foe signal.
        /// </summary>
        [DomValIx(1000245)]
        [StringValue("IFFONL")]
        [EnumMember]
        IdentificationFriendFoeSwitchOnLine,
		
        /// <summary>
        /// Area of land, sea, and airspace defined by a combat commander or subordinate unified commander, in which joint force commander conducts military operations to accomplish a specific mission.
        /// </summary>
        [DomValIx(1000246)]
        [StringValue("JNTOAR")]
        [EnumMember]
        JointOperationsArea,
		
        /// <summary>
        /// A volume of airspace where fighter aircraft operate in a weapons free mode and can use their weapons in beyond line of sight operations.
        /// </summary>
        [DomValIx(1000247)]
        [StringValue("KILBOX")]
        [EnumMember]
        KillBox,
		
        /// <summary>
        /// Airspace of defined dimensions within which the responsibility for engagement of air threats normally rests with the commander of the surface based air defence system.
        /// </summary>
        [DomValIx(1000249)]
        [StringValue("LNMEZN")]
        [EnumMember]
        LandMissileEngagementZone,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that participates as a logical element in a communications network.
        /// </summary>
        [DomValIx(1000251)]
        [StringValue("LOGNOD")]
        [EnumMember]
        LogicalNode,
		
        /// <summary>
        /// A designated airspace in which, under weapons control status weapons free, ships are automatically cleared to fire at any target which penetrates the zone, unless known to be friendly, adhering to airspace control procedures or unless otherwise directed by the anti-air warfare commander.
        /// </summary>
        [DomValIx(1000253)]
        [StringValue("MRMEZN")]
        [EnumMember]
        MaritimeMissileEngagementZone,
		
        /// <summary>
        /// A point to which aircraft fly for air traffic purposes prior to commencing an outbound transit after takeoff or prior to landing.
        /// </summary>
        [DomValIx(1000254)]
        [StringValue("MRSHGT")]
        [EnumMember]
        MarshallingGate,
		
        /// <summary>
        /// Airspace established outside class "A" airspace to separate or segregate certain non-hazardous military activities from instrument flight rule traffic and to identify for visual flight rule traffic where these activities are conducted.
        /// </summary>
        [DomValIx(1000255)]
        [StringValue("MLOPAR")]
        [EnumMember]
        MilitaryOperationsArea,
		
        /// <summary>
        /// An area of arc subtending 10 degrees, or as large as ordered by the officer in tactical command (OTC), centred on the bearing of the target with a range that extends to the maximum range of the surface-to-air missile (SAM).
        /// </summary>
        [DomValIx(1000257)]
        [StringValue("MSLARC")]
        [EnumMember]
        MissileArc,
		
        /// <summary>
        /// Airspace of specific dimensions set aside for a specific purpose in which no aircraft operations are permitted, except as authorized by the appropriate commander and controlling agency.
        /// </summary>
        [DomValIx(1000258)]
        [StringValue("NOFLZN")]
        [EnumMember]
        NoFlyZone,
		
        /// <summary>
        /// An area within which navy ships separate friendly from hostile aircraft.
        /// </summary>
        [DomValIx(1000259)]
        [StringValue("PIRAZN")]
        [EnumMember]
        PositiveIdentificationRadarAdvisoryZone,
		
        /// <summary>
        /// An airspace of defined dimensions, above the land areas or territorial waters of a state within which the flight of aircraft is prohibited.
        /// </summary>
        [DomValIx(1000260)]
        [StringValue("PRHBAR")]
        [EnumMember]
        ProhibitedArea,
		
        /// <summary>
        /// Airspace established specifically for airborne platforms conducting reconnaissance.
        /// </summary>
        [DomValIx(1000261)]
        [StringValue("RCNSAR")]
        [EnumMember]
        ReconnaissanceArea,
		
        /// <summary>
        /// A portion of defined dimensions within which general air traffic (GAT) is permitted "off-route" without requiring GAT controllers to initiate coordination with operational air traffic (OAT) controllers.
        /// </summary>
        [DomValIx(1000262)]
        [StringValue("RDCOSP")]
        [EnumMember]
        ReducedCoordinationAirspace,
		
        /// <summary>
        /// An airspace of defined dimensions, above the land areas or territorial waters of a state, within which the flight of aircraft is restricted in accordance with certain specified conditions.
        /// </summary>
        [DomValIx(1000263)]
        [StringValue("RSTRAR")]
        [EnumMember]
        RestrictedArea,
		
        /// <summary>
        /// Airspace designated by the airspace control authority, in response to specific operational situations/requirements within which the operation of one or more airspace users is restricted.
        /// </summary>
        [DomValIx(1000264)]
        [StringValue("RSOPAR")]
        [EnumMember]
        RestrictedOperationsArea,
		
        /// <summary>
        /// Designated area in hostile territory that offers the evader or escapee a reasonable chance of avoiding capture and of surviving until he can be evacuated.
        /// </summary>
        [DomValIx(1000266)]
        [StringValue("SFAREV")]
        [EnumMember]
        SafeAreaForEvasion,
		
        /// <summary>
        /// A bi-directional lane connecting an airbase, landing site and/or base defence zone to adjacent routes/corridors. Safe lanes may also be used to connect adjacent activated routes/corridors.
        /// </summary>
        [DomValIx(1000267)]
        [StringValue("SAFELN")]
        [EnumMember]
        SafeLane,
		
        /// <summary>
        /// An airspace established to route friendly aircraft to maritime forces with minimum risk.
        /// </summary>
        [DomValIx(1000268)]
        [StringValue("SFSCTR")]
        [EnumMember]
        SafetySector,
		
        /// <summary>
        /// A reference point used during SAR operations.
        /// </summary>
        [DomValIx(1000269)]
        [StringValue("SARPNT")]
        [EnumMember]
        SearchAndRescuePoint,
		
        /// <summary>
        /// An area activated around a ship operating aircraft, which is not to be entered by friendly aircraft without permission, in order to prevent friendly interference.
        /// </summary>
        [DomValIx(1000270)]
        [StringValue("SHPCZN")]
        [EnumMember]
        ShipControlZone,
		
        /// <summary>
        /// The airspace of defined dimensions within which the responsibility for engagement of air-threats normally rests with short-range air defence (SHORAD) weapons.
        /// </summary>
        [DomValIx(1000271)]
        [StringValue("SRADZN")]
        [EnumMember]
        ShortRangeAirDefenceEngagementZone,
		
        /// <summary>
        /// Airspace established specifically for airborne platforms conducting special electronic missions.
        /// </summary>
        [DomValIx(1000273)]
        [StringValue("SPEMAR")]
        [EnumMember]
        SpecialElectronicMissionArea,
		
        /// <summary>
        /// Airspace specifically for special operations forces missions requested by special operations forces airspace planners.
        /// </summary>
        [DomValIx(1000274)]
        [StringValue("SPOFSP")]
        [EnumMember]
        SpecialOperationsForcesAirspace,
		
        /// <summary>
        /// Airspace defined specifically for army tactical missile system and tomahawk land attack missile launch and impact points.
        /// </summary>
        [DomValIx(1000275)]
        [StringValue("SSMSAR")]
        [EnumMember]
        SurfaceToSurfaceMissileSystemArea,
		
        /// <summary>
        /// An airspace of defined dimensions within which activities require the reservation of airspace for the exclusive use of specific users during a determined period of time.
        /// </summary>
        [DomValIx(1000277)]
        [StringValue("TMSGAR")]
        [EnumMember]
        TemporarySegregatedArea,
		
        /// <summary>
        /// A control area normally established at the confluence of air traffic services routes in the vicinity of one or more major aerodromes.
        /// </summary>
        [DomValIx(1000278)]
        [StringValue("TRCNAR")]
        [EnumMember]
        TerminalControlArea,
		
        /// <summary>
        /// Airspace surrounding designated airports wherein air traffic control provides radar vectoring, sequencing, and separation on a full-time basis for all instrument flight rule and participating visual flight rule aircraft.
        /// </summary>
        [DomValIx(1000279)]
        [StringValue("TRRSAR")]
        [EnumMember]
        TerminalRadarServiceArea,
		
        /// <summary>
        /// Battlespace created during a contingency for the purpose of conducting training.
        /// </summary>
        [DomValIx(1000280)]
        [StringValue("TRNGAR")]
        [EnumMember]
        TrainingArea,
		
        /// <summary>
        /// Bi-directional corridor in the rear area. Air traffic services not normally provided.
        /// </summary>
        [DomValIx(1000281)]
        [StringValue("TRSCRD")]
        [EnumMember]
        TransitCorridor,
		
        /// <summary>
        /// That vertical displacement above low level air defence systems, expressed both as a height and altitude, at which aircraft can cross that area in order to improve the effectiveness of the air defence systems by providing an extra friendly discriminator.
        /// </summary>
        [DomValIx(1000283)]
        [StringValue("TRVLVL")]
        [EnumMember]
        TraverseLevel,
		
        /// <summary>
        /// Airspace created specifically for unmanned aerial vehicle operations.
        /// </summary>
        [DomValIx(1000284)]
        [StringValue("UAVASP")]
        [EnumMember]
        UnmannedAerialVehicleAirspace,
		
        /// <summary>
        /// Airspace extending from 3 nautical miles (5.556 km) outward from the coast of the continental (US) that contains activity that may be hazardous to non-participating aircraft.
        /// </summary>
        [DomValIx(1000285)]
        [StringValue("WARNAR")]
        [EnumMember]
        WarningArea,
		
        /// <summary>
        /// The airspace beyond the crossover zone out to limits defined by the officer in tactical command, in which fighters have freedom of action to identify and engage air targets.
        /// </summary>
        [DomValIx(1000286)]
        [StringValue("FEZ")]
        [EnumMember]
        FighterEngagementZone,
		
        /// <summary>
        /// A general air corridor of advance, which extends towards the enemy. An air axis of advance symbol graphically portrays a commander’s air manoeuvre intention, such as avoidance air defence coverage or envelopment of an enemy force. It follows an axis suitable for the airmobile force to which the axis was assigned. An air axis of advance does not directly control or use terrain.
        /// </summary>
        [DomValIx(1000287)]
        [StringValue("AAXIS")]
        [EnumMember]
        AirAxisOfAdvance,
		
        /// <summary>
        /// A main route of advance, assigned for control, which extends towards the enemy. A main axis of advance symbol graphically portrays a commander’s intention for the main elements of his force, such as avoidance of built-up areas or envelopment of an enemy force. It follows terrain suitable for the size of the force to which the axis was assigned, and is often a road, a group of roads, or a designated series of locations. An axis of advance is not used to direct the control of terrain or the clearance of enemy forces from specific locations. Intermediate objectives are normally assigned for these purposes.
        /// </summary>
        [DomValIx(1000288)]
        [StringValue("MAXIS")]
        [EnumMember]
        MainAxisOfAdvance,
		
        /// <summary>
        /// A location where a patient is transferred from one ambulance to another en-route to a medical treatment facility. This may be an established point in an ambulance shuttle system or it may be designated independently.
        /// </summary>
        [DomValIx(1000289)]
        [StringValue("AMBEXP")]
        [EnumMember]
        AmbulanceExchangePoint,
		
        /// <summary>
        /// 1. A defensive location oriented on a likely enemy avenue of approach. (FM 3-90) 2. For attack helicopters, an area designated in which they can manoeuvre and fire into a designated engagement area or engage targets of opportunity. (FM 1-112) (Marine Corps) 1. In ground operations, a defensive location oriented on an enemy avenue of approach from which a unit may defend. 2. In air operations, an airspace coordination area containing fire points for attack helicopters.
        /// </summary>
        [DomValIx(1000290)]
        [StringValue("BATPOS")]
        [EnumMember]
        BattlePosition,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that is the prescribed course to be travelled from a point of origin to a destination.
        /// </summary>
        [DomValIx(1000291)]
        [StringValue("RTETYP")]
        [EnumMember]
        RouteType,
		
        /// <summary>
        /// A specifically defined airspace for which air defence must be planned and provided.
        /// </summary>
        [DomValIx(1000292)]
        [StringValue("ADAREA")]
        [EnumMember]
        AirDefenceArea,
		
        /// <summary>
        /// A geographical area within which procedures are established to minimize interference between air defence operations and other types of operations.
        /// </summary>
        [DomValIx(1000293)]
        [StringValue("ADOPAR")]
        [EnumMember]
        AirDefenceOperationsArea,
		
        /// <summary>
        /// Airspace of defined dimensions within which air traffic control service is provided to instrument flight rules (IFR) and visual flight rules (VFR) flights in accordance with civil air traffic control regulations.
        /// </summary>
        [DomValIx(1000294)]
        [StringValue("ATCAIR")]
        [EnumMember]
        AirTrafficControlAirspace,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1044/66.
        /// </summary>
        [DomValIx(1000295)]
        [StringValue("ACCPOS")]
        [EnumMember]
        AircraftControlPosition,
		
        /// <summary>
        /// A defensive position so sited as to deny the enemy access to a given area or to prevent his advance in a given direction.
        /// </summary>
        [DomValIx(1000296)]
        [StringValue("BLOPOS")]
        [EnumMember]
        BlockingPosition,
		
        /// <summary>
        /// The lateral limits of an airspace control area, airspace control sub-area, high-density airspace control zone or airspace restricted area.
        /// </summary>
        [DomValIx(1000297)]
        [StringValue("BOUNDR")]
        [EnumMember]
        BoundaryAirspace,
		
        /// <summary>
        /// An area established for aircraft to patrol over an objective area, over the force protected, over the critical area of a combat zone, or over an air defence area, for the purpose of interception and destroying hostile aircraft before they reach their target.
        /// </summary>
        [DomValIx(1000298)]
        [StringValue("COAPAR")]
        [EnumMember]
        CombatAirPatrolArea,
		
        /// <summary>
        /// The mission will terminate at the specific point.
        /// </summary>
        [DomValIx(1000299)]
        [StringValue("ENDMPT")]
        [EnumMember]
        EndOfMissionPoint,
		
        /// <summary>
        /// Identifies the end point of a route.
        /// </summary>
        [DomValIx(1000300)]
        [StringValue("ENDRPT")]
        [EnumMember]
        EndOfRoutePoint,
		
        /// <summary>
        /// The point to which an aircraft will be directed to commence the transit inbound from an airfield or force at sea.
        /// </summary>
        [DomValIx(1000301)]
        [StringValue("ENTRGT")]
        [EnumMember]
        EntryGate,
		
        /// <summary>
        /// The point to which an aircraft will be directed to commence the transit outbound from an airfield or force at sea.
        /// </summary>
        [DomValIx(1000302)]
        [StringValue("EXITGT")]
        [EnumMember]
        ExitGate,
		
        /// <summary>
        /// The last position occupied by the assault echelon before crossing the start line/line of departure.
        /// </summary>
        [DomValIx(1000303)]
        [StringValue("FRUPPL")]
        [EnumMember]
        FormingUpPlace,
		
        /// <summary>
        /// A point designated by a deployed aviation commander that permits combat aircraft to rapidly refuel and rearm simultaneously.
        /// </summary>
        [DomValIx(1000304)]
        [StringValue("FARRFP")]
        [EnumMember]
        ForwardArmingAndRefuellingPoint,
		
        /// <summary>
        /// Airspace of defined dimensions within which the responsibility for engagement of air threats normally rests with the commander of the AD fighter package.
        /// </summary>
        [DomValIx(1000305)]
        [StringValue("LFGEZN")]
        [EnumMember]
        LandFighterEngagementZone,
		
        /// <summary>
        /// The aircraft, ship or other vehicle will land at the route point.
        /// </summary>
        [DomValIx(1000306)]
        [StringValue("LANDPT")]
        [EnumMember]
        LandingPoint,
		
        /// <summary>
        /// The airspace beyond the crossover zone out to limits defined by the officer in tactical command, in which fighters have freedom of action to identify and engage air targets.
        /// </summary>
        [DomValIx(1000307)]
        [StringValue("MFGEZN")]
        [EnumMember]
        MaritimeFighterEngagementZone,
		
        /// <summary>
        /// The aircraft, ship or other vehicle will change course, speed and/or altitude at this point.
        /// </summary>
        [DomValIx(1000308)]
        [StringValue("NAGTPT")]
        [EnumMember]
        NavigationPoint,
		
        /// <summary>
        /// That portion of an area of war necessary for military operations and for the administration of such operations.
        /// </summary>
        [DomValIx(1000309)]
        [StringValue("OPERZN")]
        [EnumMember]
        OperationsZone,
		
        /// <summary>
        /// The point at which a projectile, bomb or re-entry vehicle is expected to strike on earth.
        /// </summary>
        [DomValIx(1000310)]
        [StringValue("PRITPT")]
        [EnumMember]
        PredictedImpactPoint,
		
        /// <summary>
        /// A point or set of coordinates generally used for control purposes or to indicate a reference position.
        /// </summary>
        [DomValIx(1000312)]
        [StringValue("REFCPT")]
        [EnumMember]
        ReferencePoint,
		
        /// <summary>
        /// The aircraft, ship or other vehicle will refuel at this point.
        /// </summary>
        [DomValIx(1000313)]
        [StringValue("REFLPT")]
        [EnumMember]
        RefuellingPoint,
		
        /// <summary>
        /// Maritime MEZ designated area, promulgated in the OPTASK AAW message, within which the: (a) Ships remain covert, receiving the air picture via data links. (b) Ship Weapon Control Status is automatically "Weapons Free". (c) No friendly aircraft are allowed in the Maritime MEZ SSMEZ, except for airborne early warning (AEW) aircraft, anti-surface warfare (ASuW) aircraft and anti-submarine warfare (ASW) aircraft that are required to operate within this area, provided that the following criteria are met: 1. SAM ships be alerted to the mission. 2. Aircraft are kept under positive control. 3. Aircraft are being continuously tracked and their position transmitted via data link. 4. Gridlock between data link reporting unit and SAM ship is excellent. (d) No safety sectors are established in a Maritime MEZ SSMEZ.
        /// </summary>
        [DomValIx(1000314)]
        [StringValue("SSAMEZ")]
        [EnumMember]
        SilentSurfaceToAirMissileEngagementZone,
		
        /// <summary>
        /// Airspace defined for a specific purpose; or to designate airspace in which no flight activity is organized.
        /// </summary>
        [DomValIx(1000315)]
        [StringValue("SUSASP")]
        [EnumMember]
        SpecialUseAirspace,
		
        /// <summary>
        /// A designated airspace in which, under weapons control status (WCS) Weapons Free, ships are automatically cleared to fire at any target which penetrates the zone, unless known to be friendly, adhering to airspace control (ASC) procedures or unless otherwise directed by the AAWC (anti air warfare commander).
        /// </summary>
        [DomValIx(1000316)]
        [StringValue("SSAMEN")]
        [EnumMember]
        StandardSurfaceToAirMissileEngagementZone,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 11.
        /// </summary>
        [DomValIx(1000317)]
        [StringValue("SAWCTP")]
        [EnumMember]
        SurfaceToAirWeaponControlPosition,
		
        /// <summary>
        /// The aircraft will take off from the route point.
        /// </summary>
        [DomValIx(1000318)]
        [StringValue("TKEOFF")]
        [EnumMember]
        TakeoffPoint,
		
        /// <summary>
        /// A designated location that is expected to contain a target or targets.
        /// </summary>
        [DomValIx(1000319)]
        [StringValue("TGTLOC")]
        [EnumMember]
        TargetLocation,
		
        /// <summary>
        /// The aircraft, ship or other vehicle will terminate its mission at this route point.
        /// </summary>
        [DomValIx(1000320)]
        [StringValue("TERMPT")]
        [EnumMember]
        TerminationPoint,
		
        /// <summary>
        /// A point used to adjust or control time relative to a known geographical position.
        /// </summary>
        [DomValIx(1000321)]
        [StringValue("TMREPT")]
        [EnumMember]
        TimingReferencePoint,
		
        /// <summary>
        /// The aircraft, ship or other vehicle will change direction at this point.
        /// </summary>
        [DomValIx(1000322)]
        [StringValue("TURNPT")]
        [EnumMember]
        TurningPoint,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that represents one of the 18 main geographical sea areas of the world.
        /// </summary>
        [DomValIx(1000323)]
        [StringValue("QZONE")]
        [EnumMember]
        QZone,
		
        /// <summary>
        /// The point at which a projectile, bomb, or re-entry vehicle is expected to impact.
        /// </summary>
        [DomValIx(1000324)]
        [StringValue("DMPI")]
        [EnumMember]
        DesiredMeanPointOfImpact,
		
        /// <summary>
        /// In retrograde river-crossing operations, the outer limit of the area established between the enemy and the water obstacle to preclude direct and observed indirect fires into crossing areas.
        /// </summary>
        [DomValIx(1000325)]
        [StringValue("HOLDLN")]
        [EnumMember]
        HoldingLine,
		
        /// <summary>
        /// A line along which, or an area in which, fires with smoke bombs or rockets degrades temporarily the capability of enemy forces to see through.
        /// </summary>
        [DomValIx(1000326)]
        [StringValue("SMOKTG")]
        [EnumMember]
        SmokeTarget,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE with an area location assigned to rocket/missile units for terrain management purposes on which they manoeuvre.
        /// </summary>
        [DomValIx(1000327)]
        [StringValue("ROMIAR")]
        [EnumMember]
        RocketMissileArea,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that specifies approach directional details for takeoff and landing.
        /// </summary>
        [DomValIx(1000328)]
        [StringValue("APPRDR")]
        [EnumMember]
        ApproachDirection,
		
        /// <summary>
        /// An area established around the position of a suspected or known mine.
        /// </summary>
        [DomValIx(1000329)]
        [StringValue("MDASEA")]
        [EnumMember]
        MineDangerAreaSea,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies a point where aircraft split up during a mission.
        /// </summary>
        [DomValIx(1000330)]
        [StringValue("BRKUPP")]
        [EnumMember]
        BreakUpPoint,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies a point where an incident has occurred.
        /// </summary>
        [DomValIx(1000331)]
        [StringValue("INCDPT")]
        [EnumMember]
        IncidentPoint,
		
        /// <summary>
        /// The direction within the beam of an antenna for which the amplitude of the specified field component is a maximum or about which the beam may be considered symmetrical.
        /// </summary>
        [DomValIx(1000332)]
        [StringValue("MNBMAX")]
        [EnumMember]
        MainBeamAxis,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that represents the line or area along which the enemy forces are assumed to constitute the largest threat.
        /// </summary>
        [DomValIx(1000333)]
        [StringValue("MNTHAX")]
        [EnumMember]
        MainThreatAxis,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies a point where aircraft join again during a mission.
        /// </summary>
        [DomValIx(1000334)]
        [StringValue("REFRPT")]
        [EnumMember]
        ReformPoint,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies a point at which troops, after having reached it, must report to their command.
        /// </summary>
        [DomValIx(1000335)]
        [StringValue("REPRPT")]
        [EnumMember]
        ReportPoint,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies a point where aircraft separate during a mission.
        /// </summary>
        [DomValIx(1000336)]
        [StringValue("SPRDPT")]
        [EnumMember]
        SpreadPoint,
		
        /// <summary>
        /// The area in which a specified weapon control status is imposed.
        /// </summary>
        [DomValIx(1000337)]
        [StringValue("WPNCTA")]
        [EnumMember]
        WeaponControlArea,
		
        /// <summary>
        /// A line on a map, diagram or overlay joining all points at which the biological atmospheric concentration at a given time is the same. Biological atmospheric concentration is the mass of a biological substance distributed in the atmosphere per unit volume.
        /// </summary>
        [DomValIx(1000338)]
        [StringValue("BIOATC")]
        [EnumMember]
        BiologicalAtmosphericConcentrationContourLine,
		
        /// <summary>
        /// A line on a map, diagram or overlay joining all points at which the biological concentration-time (for which a quantified portion of exposed personnel are expected to experience (or not experience) effects of given severity) at a given time is the same. Biological concentration time is the product of the concentration of a biological substance in the atmosphere and the exposure time.
        /// </summary>
        [DomValIx(1000339)]
        [StringValue("BIOCNT")]
        [EnumMember]
        BiologicalConcentrationTimeContourLine,
		
        /// <summary>
        /// A line on a map, diagram or overlay joining all points at which the biological surface deposition concentration at a given time is the same. Biological surface deposition concentration is the mass of a biological substance distributed on a surface per unit area.
        /// </summary>
        [DomValIx(1000340)]
        [StringValue("BIODPC")]
        [EnumMember]
        BiologicalSurfaceDepositionConcentrationContourLine,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies the predicted or confirmed area immediately affected by the CBRN-EVENT. If the release is an attack, then the release area is generally called the attack area.
        /// </summary>
        [DomValIx(1000341)]
        [StringValue("CBRNRA")]
        [EnumMember]
        CbrnReleaseOrAttackArea,
		
        /// <summary>
        /// A line on a map, diagram or overlay joining all points at which the chemical concentration-time (for which a quantified portion of exposed personnel are expected to experience (or not experience) effects of given severity) at a given time is the same. Chemical concentration time is the product of the concentration of a chemical substance in the atmosphere and the exposure time.
        /// </summary>
        [DomValIx(1000342)]
        [StringValue("CHMCNT")]
        [EnumMember]
        ChemicalConcentrationTimeContourLine,
		
        /// <summary>
        /// A line on a map, diagram or overlay joining all points at which the chemical surface deposition concentration at a given time is the same. Chemical surface deposition concentration is the mass of a chemical substance distributed on a surface per unit area.
        /// </summary>
        [DomValIx(1000343)]
        [StringValue("CHMDPC")]
        [EnumMember]
        ChemicalSurfaceDepositionConcentrationContourLine,
		
        /// <summary>
        /// A line on a map, diagram or overlay joining all points at which the chemical atmospheric concentration at a given time is the same. Chemical atmospheric concentration is the mass of a chemical substance distributed in the atmosphere per unit volume.
        /// </summary>
        [DomValIx(1000344)]
        [StringValue("CHMATC")]
        [EnumMember]
        ChemicalAtmosphericConcentrationContourLine,
		
        /// <summary>
        /// A CONTROL-FEATURE-TYPE that identifies the linear distance from the centre of the CBRN-EVENT to the outer edge of the initial cloud.
        /// </summary>
        [DomValIx(1000345)]
        [StringValue("CLDRAD")]
        [EnumMember]
        CbrnCloudRadius,
		
        /// <summary>
        /// A line on a map, diagram or overlay joining all points at which the radiation dose at a given time is the same. Radiation dose is the amount of energy from ionizing radiation that would be absorbed.
        /// </summary>
        [DomValIx(1000346)]
        [StringValue("RADDOS")]
        [EnumMember]
        RadiationDoseContourLine,
		
        /// <summary>
        /// A line on a map, diagram or overlay joining all points at which the radiation dose rate at a given time is the same. Radiation dose rate is the rate at which energy from ionizing radiation is absorbed.
        /// </summary>
        [DomValIx(1000347)]
        [StringValue("RADDSR")]
        [EnumMember]
        RadiationDoseRateContourLine,
		
        /// <summary>
        /// A line on a map, diagram or overlay joining all points at which the radiation atmospheric concentration at a given time is the same. Radiation atmospheric concentration is the quantity of radioactive material distributed in the atmosphere per unit volume.
        /// </summary>
        [DomValIx(1000348)]
        [StringValue("RADATC")]
        [EnumMember]
        RadioactiveAtmosphericConcentrationContourLine,
		
        /// <summary>
        /// A line on a map, diagram or overlay joining all points at which the radiation surface deposition concentration at a given time is the same. Radiation surface deposition concentration is the quantity of radioactive material distributed on a surface per unit area.
        /// </summary>
        [DomValIx(1000349)]
        [StringValue("RADDPC")]
        [EnumMember]
        RadioactiveSurfaceDepositionConcentrationContourLine,
		
        /// <summary>
        /// A terrain movement restriction of individuals or groups.
        /// </summary>
        [DomValIx(1000350)]
        [StringValue("CHKPT")]
        [EnumMember]
        ChokePoint,
		
    }
}
