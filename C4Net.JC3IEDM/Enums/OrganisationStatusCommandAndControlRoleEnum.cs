using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the role played by a command and control ORGANISATION.
    /// </summary>
    [DomId(100004185)]
    [DataContract]
    public enum OrganisationStatusCommandAndControlRoleEnum
    {
		
        /// <summary>
        /// The advanced command post of a unit/formation.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ADVNCP")]
        [EnumMember]
        AdvancedCommandPost,
		
        /// <summary>
        /// The organisation performs the functions of a forward headquarters.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FRWDHQ")]
        [EnumMember]
        ForwardHeadquarters,
		
        /// <summary>
        /// The organisation performs the functions of a leapfrog element.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LPFRGE")]
        [EnumMember]
        LeapfrogElement,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1284/2.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("LOGCP")]
        [EnumMember]
        LogisticCommandPost,
		
        /// <summary>
        /// A command post that includes those staff activities involved in controlling and sustaining current operations and in planning future operations.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MAINCP")]
        [EnumMember]
        MainCommandPost,
		
        /// <summary>
        /// The mobile command post of a unit/formation.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MOBLCP")]
        [EnumMember]
        MobileCommandPost,
		
        /// <summary>
        /// The organisation performs the functions of a mobile war headquarters.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MOBLHQ")]
        [EnumMember]
        MobileWarHeadquarters,
		
        /// <summary>
        /// The organisation performs the functions of a peace headquarters.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("PEACHQ")]
        [EnumMember]
        PeaceHeadquarters,
		
        /// <summary>
        /// The peacetime command post of a unit/formation.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("PEACCP")]
        [EnumMember]
        PeacetimeCommandPost,
		
        /// <summary>
        /// The organisation performs the functions of a primary war headquarters.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("PRWRHQ")]
        [EnumMember]
        PrimaryWarHeadquarters,
		
        /// <summary>
        /// Those staff activities concerned primarily with combat service support of the force, administrative support of the headquarters and other activities not immediately concerned with current operations.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("REARCP")]
        [EnumMember]
        RearCommandPost,
		
        /// <summary>
        /// A command post that is only activated when required.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("RESVCP")]
        [EnumMember]
        ReserveCommandPost,
		
        /// <summary>
        /// The static command post of a unit/formation.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("STATCP")]
        [EnumMember]
        StaticCommandPost,
		
        /// <summary>
        /// The organisation performs the functions of a static war headquarters.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("STATHQ")]
        [EnumMember]
        StaticWarHeadquarters,
		
        /// <summary>
        /// The organisation performs the functions of a step up headquarters.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("STUPHQ")]
        [EnumMember]
        StepUpHeadquarters,
		
        /// <summary>
        /// Any location designated by a commander to assume command post functions in the event the main or rear command post becomes inoperative.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("STUPCP")]
        [EnumMember]
        StepUpAlternateCommandPost,
		
        /// <summary>
        /// A small, mobile headquarters capable of serving the requirements of the commander (but usually not the staff) for short periods.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("TACTCP")]
        [EnumMember]
        TacticalCommandPost,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The organisation performs the functions of a national headquarters.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("NATLHQ")]
        [EnumMember]
        NationalHeadquarters,
		
        /// <summary>
        /// The organisation performs the functions of a tactical headquarters.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("TACTHQ")]
        [EnumMember]
        TacticalHeadquarters,
		
    }
}
