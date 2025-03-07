using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed type of relationship between the subject OBJECT-ITEM that is an ORGANISATION and the object OBJECT-ITEM that is an ORGANISATION in a specific OBJECT-ITEM-ASSOCIATION.
    /// </summary>
    [DomId(100000297)]
    [DataContract]
    public enum ObjectItemAssociationSubcategoryEnum
    {
		
        /// <summary>
        /// The military authority and responsibility of a superior officer to issue orders to subordinates.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COMD")]
        [EnumMember]
        HasFullCommandOf,
		
        /// <summary>
        /// The authority granted to a commander to assign missions or tasks to subordinate commanders, to deploy units, to reassign forces, and to retain or delegate operational and/or tactical control as may be deemed necessary.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OPCOMD")]
        [EnumMember]
        HasOperationalCommandOf,
		
        /// <summary>
        /// The authority delegated to a commander to assign tasks to forces under his command for the accomplishment of the mission assigned by higher authority.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TACCOM")]
        [EnumMember]
        HasTacticalCommandOf,
		
        /// <summary>
        /// The authority delegated to a commander to direct forces assigned so that the commander may accomplish specific missions or tasks which are usually limited by function, time, or location; to deploy units concerned, and to retain or assign tactical control of those units. It does not include authority to assign separate employment of components of the units concerned.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("OPCON")]
        [EnumMember]
        HasOperationalControlOf,
		
        /// <summary>
        /// The detailed, and, usually, local direction and control of movements or manoeuvres necessary to accomplish missions or tasks assigned.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("TACCNT")]
        [EnumMember]
        HasTacticalControlOf,
		
        /// <summary>
        /// The support provided by a unit not attached to or under command of the supported unit or formation, but required to give priority to the support required by that unit or formation.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("DIRSUP")]
        [EnumMember]
        HasInDirectSupport,
		
        /// <summary>
        /// In artillery usage, a tactical mission in which one artillery unit augments the fire of another artillery unit.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("REINFC")]
        [EnumMember]
        HasReinforcing,
		
        /// <summary>
        /// General Support Reinforcing artillery has the mission of supporting the forces as a whole and, on a secondary basis, of providing reinforcing fire for another artillery unit.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("GENSRI")]
        [EnumMember]
        HasInGeneralSupportReinforcing,
		
        /// <summary>
        /// The support that is given to the supported force as a whole and not to any particular subdivision thereof.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("GENSUP")]
        [EnumMember]
        HasInGeneralSupport,
		
        /// <summary>
        /// Term designating the support provided to another unit, formation or organisation while remaining under the initial command.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("HSNSPT")]
        [EnumMember]
        HasInSupportOf,
		
        /// <summary>
        /// An object ORGANISATION is placed in the subject ORGANISATION where such placement is relatively permanent, and/or where such "subject" organisation controls and administers the "object" organisation for its primary functions.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ASGND")]
        [EnumMember]
        HasAssigned,
		
        /// <summary>
        /// The placement of units in an organisation where such placement is relatively temporary.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ATTACH")]
        [EnumMember]
        HasAttached,
		
        /// <summary>
        /// A precedence applied to the task of an artillery unit to provide fire to a formation/unit on a guaranteed basis.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("ATPRCL")]
        [EnumMember]
        HasAtPriorityCall,
		
        /// <summary>
        /// Supporting unit satisfies all ammunition resupply requirements of the supported unit including crew-served weapons and artillery.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("SPTAMM")]
        [EnumMember]
        SupportServicesAmmunition,
		
        /// <summary>
        /// Supporting unit satisfies supply requirements of the supported unit.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("SPTSPL")]
        [EnumMember]
        SupportServicesSupply,
		
        /// <summary>
        /// Supporting unit satisfies fuel/POL supply requirements of the supported unit.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("SPTPOL")]
        [EnumMember]
        SupportServicesPol,
		
        /// <summary>
        /// Supporting unit satisfies 2nd and 3rd line repair, recovery and evacuation requirements of the supported unit.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("SPTRRE")]
        [EnumMember]
        SupportServicesRepRecEvc,
		
        /// <summary>
        /// Supporting unit coordinates and provides road credits for the movement of the supported unit.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SPTMVT")]
        [EnumMember]
        SupportServicesMovement,
		
        /// <summary>
        /// Supporting unit satisfies 2nd and 3rd line transport requirements of the supported unit.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("SPTTRN")]
        [EnumMember]
        SupportServicesTransport,
		
        /// <summary>
        /// Supporting unit satisfies medical requirements of the supported unit.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("SPTMED")]
        [EnumMember]
        SupportServicesMedical,
		
        /// <summary>
        /// Supporting unit satisfies all personnel administration and replacement requirements of the supported unit.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("SPTPAR")]
        [EnumMember]
        SupportServicesPerAdmRpl,
		
        /// <summary>
        /// Supporting unit satisfies food replenishment requirements of the supported unit.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("SPTRAT")]
        [EnumMember]
        SupportServicesRations,
		
        /// <summary>
        /// Supporting unit satisfies engineering support requirements of the supported unit.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("SPTENG")]
        [EnumMember]
        SupportServicesEngineering,
		
        /// <summary>
        /// Supporting unit satisfies postal requirements of the supported unit.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("SPTPST")]
        [EnumMember]
        SupportServicesPostal,
		
        /// <summary>
        /// The subject ORGANISATION has the object ORGANISATION as able to execute its functions should the need arise.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("ALTFOR")]
        [EnumMember]
        HasAsAlternate,
		
        /// <summary>
        /// The subject ORGANISATION has taken possession, as a result of forceful means, of the object ORGANISATION.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("HSCPTD")]
        [EnumMember]
        HasCaptured,
		
        /// <summary>
        /// The object ORGANISATION constitutes a force that may be committed into combat only on the order of the commander of the subject ORGANISATION.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("RESERV")]
        [EnumMember]
        HasInReserve,
		
        /// <summary>
        /// The subject ORGANISATION is deemed to be the same as the object ORGANISATION.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("SAME")]
        [EnumMember]
        IsTheSameAs,
		
        /// <summary>
        /// The subject ORGANISATION is made available to the object ORGANISATION commander for the purpose of supplementing an in-place force.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("FORCE")]
        [EnumMember]
        Reinforces,
		
        /// <summary>
        /// The subject ORGANISATION normally has the object ORGANISATION under command in garrison.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("ORGANC")]
        [EnumMember]
        HasOrganic,
		
        /// <summary>
        /// The subject ORGANISATION plays the role of an object ORGANISATION.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("ROLE")]
        [EnumMember]
        PlaysTheRoleOf,
		
        /// <summary>
        /// A term used to specify that a pre-arranged concentration, air strike or final protective fire may be called for.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("ONCALL")]
        [EnumMember]
        HasOnCall,
		
        /// <summary>
        /// The subject ORGANISATION has the object ORGANISATION separated from its main organisation for duty elsewhere.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("DETACH")]
        [EnumMember]
        HasDetached,
		
        /// <summary>
        /// Working or acting together.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("ISCPER")]
        [EnumMember]
        IsCoOperatingWith,
		
        /// <summary>
        /// An air-defence capable warship ORGANISATION is under tactical control of the Air Defence Commander.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("CASP1")]
        [EnumMember]
        CoordinatedAirSeaProcedureOne,
		
        /// <summary>
        /// An air-defence capable warship ORGANISATION is working closely with the shore based Air Defence Commander. Tactical control of the ship remains with the Officer in Tactical Command.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("CASP2")]
        [EnumMember]
        CoordinatedAirSeaProcedureTwo,
		
        /// <summary>
        /// A warship ORGANISATION that is unable to contribute to the Recognized Air Picture but requires receiving it normally via the Joint Anti-Air Warfare Shore Coordination net.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("CASP3")]
        [EnumMember]
        CoordinatedAirSeaProcedureThree,
		
        /// <summary>
        /// An air-defence capable warship ORGANISATION, entering or berthed in a port or anchorage, which is able to assist the SOC/CAOC in whose sector the port or anchorage is located.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("CASP4")]
        [EnumMember]
        CoordinatedAirSeaProcedureFour,
		
        /// <summary>
        /// Direction or exercise of authority over subordinate or other organizations in respect to administrative matters such as personnel management, supply, services, and other matters not included in the operational missions of the subordinate or other organizations.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("ADMCON")]
        [EnumMember]
        HasAdministrativeControlOf,
		
        /// <summary>
        /// The authority granted to a commander or individual assigned responsibility for coordinating specific functions or activities involving forces of two or more countries or commands, or two or more services or two or more forces of the same service.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("COAUTH")]
        [EnumMember]
        HasCoordinationAuthorityOver,
		
        /// <summary>
        /// That action of the supporting force against targets or objectives that are sufficiently near the supported force as to require detailed integration or coordination of the supporting action with the fire, movement, or other actions of the supported force.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("CLSSUP")]
        [EnumMember]
        HasInCloseSupport,
		
        /// <summary>
        /// That support which units render each other against an enemy, because of their assigned tasks, their position relative to each other and to the enemy, and their inherent capabilities.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("MUTSUP")]
        [EnumMember]
        HasInMutualSupport,
		
        /// <summary>
        /// Logistic Control (LOGCON) is that authority granted to a Commander over assigned logistics units and organizations in the JOA, including National Support Elements (NSE) that empowers him to synchronize, prioritize, and integrate their logistics functions and activities to accomplish the joint mission.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("LOGCON")]
        [EnumMember]
        HasLogisticalControlOf,
		
    }
}
