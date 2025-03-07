using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of TASK-FORMATION-TYPE.
    /// </summary>
    [DomId(100000378)]
    [DataContract]
    public enum TaskFormationTypeCategoryEnum
    {
		
        /// <summary>
        /// A TASK-FORMATION-TYPE that consists of a number of ships and/or aircraft, normally a subdivision of a force, assigned for a specific purpose.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("GRNAVY")]
        [EnumMember]
        GroupNavy,
		
        /// <summary>
        /// A TASK-FORMATION-TYPE that is a land or maritime convoy that is controlled and reported as a military unit.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MLCNVY")]
        [EnumMember]
        MilitaryConvoyType,
		
        /// <summary>
        /// A TASK-FORMATION-TYPE that is a detachment of ground, sea, or air forces sent out for the purpose of gathering information or carrying out a destructive, harassing, mopping-up, or security mission.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PATROL")]
        [EnumMember]
        Patrol,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A temporary grouping of units, under one commander, formed for the purpose of carrying out a specific air operation or mission.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("AIRTF")]
        [EnumMember]
        AirTaskForce,
		
        /// <summary>
        /// A temporary grouping of units, under one commander, formed for the purpose of carrying out a specific amphibious operation or mission.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("AMPHTF")]
        [EnumMember]
        AmphibiousTaskForce,
		
        /// <summary>
        /// A temporary grouping of units, under one commander, formed for the purpose of carrying out a specific joint operation or mission.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("JNTTF")]
        [EnumMember]
        JointTaskForce,
		
        /// <summary>
        /// A temporary grouping of units, under one commander, formed for the purpose of carrying out a specific land operation or mission.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("LANDTF")]
        [EnumMember]
        LandTaskForce,
		
        /// <summary>
        /// A TASK-FORMATION-TYPE that is a component of a fleet organized by the commander of a task fleet or higher authority for the accomplishment of a specific task or tasks.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NAVLTF")]
        [EnumMember]
        NavalTaskForce,
		
        /// <summary>
        /// A TASK-FORMATION-TYPE that is a component of a task unit organized by the commander of the task unit or higher authority for accomplishing a specific task.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NAVLTE")]
        [EnumMember]
        NavalTaskElement,
		
        /// <summary>
        /// A TASK-FORMATION-TYPE that is a component of a task force organized by the commander of the task force or higher authority for accomplishing specific tasks.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("NAVLTG")]
        [EnumMember]
        NavalTaskGroup,
		
        /// <summary>
        /// A TASK-FORMATION-TYPE that is a component of a task group organized by the commander of a task group or higher authority for accomplishing specific tasks.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NAVLTU")]
        [EnumMember]
        NavalTaskUnit,
		
        /// <summary>
        /// An ordered arrangement of two or more aircraft proceeding together under a commander.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("AIRFMN")]
        [EnumMember]
        AirFormation,
		
        /// <summary>
        /// An ordered arrangement of troops and/or vehicles for a specific purpose.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("LNDFMN")]
        [EnumMember]
        LandFormation,
		
        /// <summary>
        /// An ordered arrangement of two or more ships, units or aircraft proceeding together under a commander.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("NAVFMN")]
        [EnumMember]
        NavalFormation,
		
        /// <summary>
        /// A small fleet; a fleet of boats or small vessels.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("FLOTLA")]
        [EnumMember]
        Flotilla,
		
        /// <summary>
        /// A group of people who come together to carry out a piece of work.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("WRKPTY")]
        [EnumMember]
        WorkParty,
		
        /// <summary>
        /// A TASK-FORMATION-TYPE that consists of parachute and combat diver qualified personnel trained and equipped to rapidly establish and control drop, landing, and extraction zone air traffic in austere or hostile conditions. They survey and establish terminal airheads as well as provide guidance to aircraft for airlift operations. They provide command and control, and conduct reconnaissance, surveillance, and survey assessments of potential objective airfields or assault zones.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("CMBCTM")]
        [EnumMember]
        CombatControlTeam,
		
        /// <summary>
        /// A TASK-FORMATION-TYPE that provides electronic, mechanical, visual, or other assistance given an aircraft pilot to facilitate arrival at, operation within or over, landing upon, or departure from an air landing or airdrop facility.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("INTGTM")]
        [EnumMember]
        InitialTerminalGuidanceTeam,
		
        /// <summary>
        /// A TASK-FORMATION-TYPE, subordinate to the U.S. Marine TACC, that controls local airspace/aircraft in and around a Marine Air Ground Task Force (MAGTF) airfields and provides precision approach control for MAGTF aircraft.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("MRATCD")]
        [EnumMember]
        MarineAirTrafficControlDetachment,
		
        /// <summary>
        /// A TASK-FORMATION-TYPE, subordinate to the U. S. Marine TACC, that controls local airspace/aircraft in and around Marine Air Ground Task Force (MAGTF) airfields and provides precision approach control for MAGTF aircraft.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("MRATCM")]
        [EnumMember]
        MarineAirTrafficControlMobileTeam,
		
    }
}
