using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that describes the immediate and direct goals or objectives of an enemy’s attack.
    /// </summary>
    [DomId(100004428)]
    [DataContract]
    public enum ActionEventDetailIntendedOutcomeEnum
    {
		
        /// <summary>
        /// The intended result is to damage or destroy aircraft and/or their payload as well as to kill or wound individuals inside the aircraft.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIRDEF")]
        [EnumMember]
        AntiAirVehicle,
		
        /// <summary>
        /// The intended result is to damage or destroy armoured vehicles and/or to kill or wound individuals inside armoured vehicles.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ARMDEF")]
        [EnumMember]
        AntiArmour,
		
        /// <summary>
        /// The intended result is to damage or destroy physical infrastructure.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("INFDEF")]
        [EnumMember]
        AntiInfrastructure,
		
        /// <summary>
        /// The intended result is to kill or wound people.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PERDEF")]
        [EnumMember]
        AntiPersonnel,
		
        /// <summary>
        /// The intended result is to damage or destroy vehicles, excluding armoured vehicles, and/or their cargo as well as to kill or wound individuals inside such vehicles.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("VEHDEF")]
        [EnumMember]
        AntiVehicle,
		
        /// <summary>
        /// The intended result is to damage or destroy vessels.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("VESDEF")]
        [EnumMember]
        AntiVessel,
		
        /// <summary>
        /// The intended result is to cause a reaction by forces in an effort to learn and understand employed tactics. This knowledge is then used by the attacker to plan new attacks incorporating the lessons learned to inflict additional casualties or to avoid countermeasures. (TTP - Tactics, Techniques and Procedures).
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("TTPID")]
        [EnumMember]
        TtpIdentification,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
