using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type classification of a MILITARY-POST-TYPE.
    /// </summary>
    [DomId(100000375)]
    [DataContract]
    public enum MilitaryPostTypeCategoryEnum
    {
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the designated alternate controller of a Joint Air Attack Team.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AJAATC")]
        [EnumMember]
        AlternativeJaatController,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Anaesthetics.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ANSPHY")]
        [EnumMember]
        AnaestheticsPhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the authority with the right and power to approve plans, orders or other official documents.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("APAUTH")]
        [EnumMember]
        ApprovingAuthority,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the designated commander of an attack helicopter unit.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("AHLCDR")]
        [EnumMember]
        AttackHelicopterCommander,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the duly appointed officer in charge of a unit, post, camp, or operation.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("AUTCDR")]
        [EnumMember]
        AuthorisedCommander,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Dentistry.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("DNTPHY")]
        [EnumMember]
        DentistryPhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the member of the tactical air control party who, from a forward ground or airborne position, controls aircraft in close air support of ground troops.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("FAC")]
        [EnumMember]
        ForwardAirController,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the observer operating with front line troops on the ground or in the air and trained to adjust ground or naval gunfire and pass back battlespace information.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("FOOAOP")]
        [EnumMember]
        ForwardObservationOfficerAirObservationPost,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the designated commander of a ground manoeuvre unit.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("GMCDR")]
        [EnumMember]
        GroundManoeuvreCommander,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Gynaecology.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("GYNPHY")]
        [EnumMember]
        GynaecologyPhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Head/neck.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("HDNPHY")]
        [EnumMember]
        HeadNeckPhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the officer who is responsible for activities relating to gathering and analysing information about an actual or potential foe.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("INTOFF")]
        [EnumMember]
        IntelligenceOfficer,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Internal medicine.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("INMPHY")]
        [EnumMember]
        InternalMedicinePhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the designated controller of a Joint Air Attack Team.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("JAATC")]
        [EnumMember]
        JaatController,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the person specialised to take all actions to retain materiel in or to restore it to a specified condition.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("MANTCH")]
        [EnumMember]
        MaintenanceTechnician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the officer who is responsible for activities relating to planning and directing military operations.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("OPSOFF")]
        [EnumMember]
        OperationsOfficer,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Orthopaedics.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("ORTPHY")]
        [EnumMember]
        OrthopaedicsPhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician with an unidentified speciality.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("OTHPHY")]
        [EnumMember]
        OtherPhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Pathology.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("PTHPHY")]
        [EnumMember]
        PathologyPhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Primary care.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("PRCPHY")]
        [EnumMember]
        PrimaryCarePhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Psychology.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("PSYPHY")]
        [EnumMember]
        PsychologyPhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Radiology.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("RADPHY")]
        [EnumMember]
        RadiologyPhysician,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a physician specialising in Surgery.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("SURPHY")]
        [EnumMember]
        SurgicalPhysician,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A MILITARY-POST-TYPE responsible to coordinate details for each element of support required.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("POC")]
        [EnumMember]
        PointOfContact,
		
        /// <summary>
        /// A MILITARY-POST-TYPE responsible for liaison duties.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("LIAISN")]
        [EnumMember]
        LiaisonOfficer,
		
        /// <summary>
        /// A tactical air force or naval aviation officer attached to a ground or naval unit or formation as the advisor on tactical air operation matters.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("AIRLSN")]
        [EnumMember]
        AirLiaisonOfficer,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as a soldier armed with a rifle.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("RFLEMN")]
        [EnumMember]
        Rifleman,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as one who designs and constructs military works for attack or defence.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("SAPPER")]
        [EnumMember]
        Sapper,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as one sent out ahead of the main force in order to reconnoitre the position and movement of the enemy.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("SCOUT")]
        [EnumMember]
        Scout,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as one who snipes, or shoots from concealment.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("SNIPER")]
        [EnumMember]
        Sniper,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is a subordinate operational component of a tactical air control system designed to provide air liaison to land forces and for the control of aircraft.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("TAC")]
        [EnumMember]
        TacticalAirController,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as the HAVE QUICK Mickey net controller.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("MCKNET")]
        [EnumMember]
        MickeyNetController,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is identified as one who operates a gun.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("GUNNER")]
        [EnumMember]
        Gunner,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that provides air coordination and control during helicopter operations within the Marine Air Command and Control System (MACCS). Serves as an extension of Direct Air Support Centre (DASC) or Helicopter Direction Centre (HDC) in support of the air mission commander.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("ASCAIR")]
        [EnumMember]
        AssaultSupportCoordinatorAirborne,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is a specifically trained and qualified aviation officer who exercises control from the air of aircraft engaged in close air support of ground troops. The forward air controller (airborne) is normally an airborne extension of the tactical air control party.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("FACAIR")]
        [EnumMember]
        ForwardAirControllerAirborne,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that is an officer who coordinates, from an aircraft, the action of combat aircraft engaged in close support of ground or sea forces.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("TACAIR")]
        [EnumMember]
        TacticalAirCoordinatorAirborne,
		
        /// <summary>
        /// A MILITARY-POST-TYPE that executes component’s rescue coordination centre (RCC) and coordinates the combat search and rescue (CSAR) effort between the combat search and rescue task force (CSARTF) and the RCC (or joint search and rescue centre) by monitoring the status of all CSARTF elements, requesting additional assets when needed, and ensuring the recovery and supporting forces arrive at their designated areas to accomplish the CSAR mission.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("ARBNMC")]
        [EnumMember]
        AirborneMissionCommander,
		
    }
}
