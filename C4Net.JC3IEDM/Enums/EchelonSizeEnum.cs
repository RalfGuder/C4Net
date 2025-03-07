using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the relative size of the commonly accepted configuration of military formations.
    /// </summary>
    [DomId(100000166)]
    [DataContract]
    public enum EchelonSizeEnum
    {
		
        /// <summary>
        /// The largest formation of land forces, normally comprising two or more armies or army corps under a designated commander.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AG")]
        [EnumMember]
        ArmyGroup,
		
        /// <summary>
        /// A formation larger than an army corps but smaller than an army group. It usually consists of two or more army corps.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ARMY")]
        [EnumMember]
        Army,
		
        /// <summary>
        /// Unit composed of a headquarters and two or more battalions. It may be part of an army and be charged with only tactical functions, or it may be a separate unit and be charged with both administrative and tactical functions.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BDE")]
        [EnumMember]
        Brigade,
		
        /// <summary>
        /// Unit composed of a headquarters and two or more companies or batteries. It may be part of a regiment and be charged with only tactical functions, or it may be a separate unit and be charged with both administrative and tactical functions.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BN")]
        [EnumMember]
        Battalion,
		
        /// <summary>
        /// An operational grouping which is based on an infantry battalion and which has elements of other supporting arms and services allocated according to need.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BNG")]
        [EnumMember]
        BattalionGroup,
		
        /// <summary>
        /// A formation larger than a division but smaller than an army or army group. It usually consists to two or more divisions together with supporting arms and services.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CORPS")]
        [EnumMember]
        Corps,
		
        /// <summary>
        /// Basic administrative and tactical unit in most arms and services of the Army. A company is on a command level below a battalion and above a platoon.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("COY")]
        [EnumMember]
        Company,
		
        /// <summary>
        /// An operational grouping which is based on either an infantry company or a tank company, which has elements of other supporting arms and services allocated according to need.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("COYG")]
        [EnumMember]
        CompanyGroup,
		
        /// <summary>
        /// A tactical unit/formation that is a major administrative and tactical unit/formation that combines in itself the necessary arms and services required for sustained combat, larger than a regiment/brigade and smaller than a corps.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("DIV")]
        [EnumMember]
        Division,
		
        /// <summary>
        /// Basic administrative and tactical unit in most arms and services of the Army.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("PLT")]
        [EnumMember]
        Platoon,
		
        /// <summary>
        /// Administrative and tactical unit, on a command level below a division or brigade and above a battalion, the entire organisation of which is prescribed by table of organisation.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("RGT")]
        [EnumMember]
        Regiment,
		
        /// <summary>
        /// A small tactical unit.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SECT")]
        [EnumMember]
        Section,
		
        /// <summary>
        /// A small number of men, a subdivision or section of a company, formed for drill.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SQUAD")]
        [EnumMember]
        Squad,
		
        /// <summary>
        /// Any unit smaller than a squad that will be denoted by a vehicle or weapon symbol in a graphical representation.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("TEAM")]
        [EnumMember]
        TeamFireTeamCrew,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A specified group of aircraft engaged in a common mission.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("FLIGHT")]
        [EnumMember]
        Flight,
		
        /// <summary>
        /// An operational grouping which is based on either an infantry battalion or a tank regiment, each with at least a squadron or company of the other arm and with elements of other supporting arms and services allocated according to need.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("BATGRP")]
        [EnumMember]
        BattleGroup,
		
        /// <summary>
        /// An operational grouping which is based on an infantry or armoured brigade and which has elements of other supporting arms and services allocated according to need.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("BDEGRP")]
        [EnumMember]
        BrigadeGroup,
		
        /// <summary>
        /// An organisation of ships, aircraft, Marine forces, and shore-based fleet activities all under the command of a commander or commander in chief who may exercise operational as well as administrative control.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("FLEET")]
        [EnumMember]
        Fleet,
		
        /// <summary>
        /// A grouping of two or more Army groups.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("REGION")]
        [EnumMember]
        Region,
		
        /// <summary>
        /// A component of a task unit organized by the commander of the task unit or higher authority for accomplishing a specific task.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("TSKELN")]
        [EnumMember]
        TaskElementNavy,
		
        /// <summary>
        /// An aviation unit composed normally of one primary mission group and the necessary supporting organisations.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("WING")]
        [EnumMember]
        Wing,
		
        /// <summary>
        /// An administrative or tactical organisation normally but not necessarily composed of aircraft of the same type.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("SQDRNA")]
        [EnumMember]
        SquadronAir,
		
        /// <summary>
        /// An administrative or tactical organisation consisting of two or more divisions of ships, plus such additional ships as may be assigned as flagships or tenders.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("SQDRNM")]
        [EnumMember]
        SquadronMaritime,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A component of a fleet organized by the commander of a task fleet or higher authority for the accomplishment of a specific task or tasks.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("NTF")]
        [EnumMember]
        TaskForceNavy,
		
        /// <summary>
        /// A component of a task force organized by the commander of the task force or higher authority for accomplishing specific tasks.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("NTG")]
        [EnumMember]
        TaskGroupNavy,
		
        /// <summary>
        /// A component of a task group organized by the commander of a task group or higher authority for accomplishing specific tasks.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("NTU")]
        [EnumMember]
        TaskUnitNavy,
		
    }
}
