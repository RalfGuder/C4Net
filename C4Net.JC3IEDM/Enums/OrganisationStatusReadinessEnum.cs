using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that gives the readiness level of an ORGANISATION.
    /// </summary>
    [DomId(100004117)]
    [DataContract]
    public enum OrganisationStatusReadinessEnum
    {
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the aircrews will be in cockpits of their fighters and be capable of starting their engines and becoming airborne in the minimum practicable time.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BTLSTN")]
        [EnumMember]
        BattleStations,
		
        /// <summary>
        /// A readiness level of a "Marine Unit" type ORGANISATION where the troops must be able to open fire in 2 to 5 minutes.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("RED")]
        [EnumMember]
        Red,
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the aircrews will be in the cockpits with the applicable checks completed and the aircraft will be located on or near the runway with engines running ready for take off.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("RNYALR")]
        [EnumMember]
        RunwayAlert,
		
        /// <summary>
        /// A readiness level of a "Marine Unit" type ORGANISATION where the troops must be able to open fire in 30 to 60 minutes.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("WHITE")]
        [EnumMember]
        White,
		
        /// <summary>
        /// A readiness level of a "Marine Unit" type ORGANISATION where the troops must be able to open fire in 15 minutes.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("YELLOW")]
        [EnumMember]
        Yellow,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A readiness level of an ORGANISATION wherein combat-equipped aircraft are airborne and ready for immediate action.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("AIRALR")]
        [EnumMember]
        AirborneAlert,
		
        /// <summary>
        /// A readiness level of an ORGANISATION wherein aircraft on the ground/deck are fully serviced and armed, with combat crews in readiness to take off within a specified short period of time (usually 15 minutes) after receipt of a mission order.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("GRDALR")]
        [EnumMember]
        GroundAlert,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION cannot be ready within 12 hours.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NRD12H")]
        [EnumMember]
        NotReadyWithin12Hours,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within 10 minutes.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("RDY10M")]
        [EnumMember]
        ReadyWithin10Minutes,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within 12 hours.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("RDY12H")]
        [EnumMember]
        ReadyWithin12Hours,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within 15 minutes.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("RDY15M")]
        [EnumMember]
        ReadyWithin15Minutes,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within 2 hours.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("RDY2H")]
        [EnumMember]
        ReadyWithin2Hours,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within 20 minutes.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("RDY20M")]
        [EnumMember]
        ReadyWithin20MinutesUs,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within 3 hours.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("RDY3H")]
        [EnumMember]
        ReadyWithin3Hours,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within 30 minutes.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("RDY30M")]
        [EnumMember]
        ReadyWithin30Minutes,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within 5 minutes.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("RDY5M")]
        [EnumMember]
        ReadyWithin5Minutes,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within 6 hours.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("RDY6H")]
        [EnumMember]
        ReadyWithin6Hours,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within 60 minutes.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("RDY60M")]
        [EnumMember]
        ReadyWithin60Minutes,
		
        /// <summary>
        /// A readiness state of an ORGANISATION indicating that the ORGANISATION can be ready within less than 5 minutes.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("RDYL5M")]
        [EnumMember]
        ReadyWithinLessThan5Minutes,
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the troops will be able to be engaged in action, defence or protection within 10 days.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("WT10D")]
        [EnumMember]
        Within10Days,
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the troops will be able to be engaged in action, defence or protection within 180 days.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("WT180D")]
        [EnumMember]
        Within180Days,
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the troops will be able to be engaged in action, defence or protection within 2 days.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("WT2D")]
        [EnumMember]
        Within2Days,
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the troops will be able to be engaged in action, defence or protection within 20 days.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("WT20D")]
        [EnumMember]
        Within20Days,
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the troops will be able to be engaged in action, defence or protection within 30 days.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("WT30D")]
        [EnumMember]
        Within30Days,
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the troops will be able to be engaged in action, defence or protection within 365 days.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("WT365D")]
        [EnumMember]
        Within365Days,
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the troops will be able to be engaged in action, defence or protection within 5 days.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("WT5D")]
        [EnumMember]
        Within5Days,
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the troops will be able to be engaged in action, defence or protection within 60 days.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("WT60D")]
        [EnumMember]
        Within60Days,
		
        /// <summary>
        /// A readiness level of an ORGANISATION where the troops will be able to be engaged in action, defence or protection within 90 days.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("WT90D")]
        [EnumMember]
        Within90Days,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// Readiness state 1, in line with definitions provided by "Shape Standing Defence Plan (SDP) 10901D - ANGRY HASP" [NC] and by the "Comairnorth Supplan 24600D Constant Effort" for the Northern Region Integrated Air Defence System (NRIADS), Annex h dated 15 FEB 2000 [NC].
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("RDNS1")]
        [EnumMember]
        ReadinessState1,
		
        /// <summary>
        /// Readiness state 2, in line with definitions provided by "Shape Standing Defence Plan (SDP) 10901D - ANGRY HASP" [NC] and by the "Comairnorth Supplan 24600D Constant Effort" for the Northern Region Integrated Air Defence System (NRIADS), Annex h dated 15 FEB 2000 [NC].
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("RDNS2")]
        [EnumMember]
        ReadinessState2,
		
        /// <summary>
        /// Readiness state 3, in line with definitions provided by "Shape Standing Defence Plan (SDP) 10901D - ANGRY HASP" [NC] and by the "Comairnorth Supplan 24600D Constant Effort" for the Northern Region Integrated Air Defence System (NRIADS), Annex h dated 15 FEB 2000 [NC].
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("RDNS3")]
        [EnumMember]
        ReadinessState3,
		
        /// <summary>
        /// Readiness state 4, in line with definitions provided by "Shape Standing Defence Plan (SDP) 10901D - ANGRY HASP" [NC] and by the "Comairnorth Supplan 24600D Constant Effort" for the Northern Region Integrated Air Defence System (NRIADS), Annex h dated 15 FEB 2000 [NC].
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("RDNS4")]
        [EnumMember]
        ReadinessState4,
		
        /// <summary>
        /// Readiness state 5, in line with definitions provided by "Shape Standing Defence Plan (SDP) 10901D - ANGRY HASP" [NC] and by the "Comairnorth Supplan 24600D Constant Effort" for the Northern Region Integrated Air Defence System (NRIADS), Annex h dated 15 FEB 2000 [NC].
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("RDNS5")]
        [EnumMember]
        ReadinessState5,
		
        /// <summary>
        /// Readiness state 6, in line with definitions provided by "Shape Standing Defence Plan (SDP) 10901D - ANGRY HASP" [NC] and by the "Comairnorth Supplan 24600D Constant Effort" for the Northern Region Integrated Air Defence System (NRIADS), Annex h dated 15 FEB 2000 [NC].
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("RDNS6")]
        [EnumMember]
        ReadinessState6,
		
        /// <summary>
        /// Readiness state 7, in line with definitions provided by "Shape Standing Defence Plan (SDP) 10901D - ANGRY HASP" [NC] and by the "Comairnorth Supplan 24600D Constant Effort" for the Northern Region Integrated Air Defence System (NRIADS), Annex h dated 15 FEB 2000 [NC].
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("RDNS7")]
        [EnumMember]
        ReadinessState7,
		
        /// <summary>
        /// Readiness state 8, in line with definitions provided by "Shape Standing Defence Plan (SDP) 10901D - ANGRY HASP" [NC] and by the "Comairnorth Supplan 24600D Constant Effort" for the Northern Region Integrated Air Defence System (NRIADS), Annex h dated 15 FEB 2000 [NC].
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("RDNS8")]
        [EnumMember]
        ReadinessState8,
		
        /// <summary>
        /// Readiness state 9, in line with definitions provided by "Shape Standing Defence Plan (SDP) 10901D - ANGRY HASP" [NC] and by the "Comairnorth Supplan 24600D Constant Effort" for the Northern Region Integrated Air Defence System (NRIADS), Annex h dated 15 FEB 2000 [NC].
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("RDNS9")]
        [EnumMember]
        ReadinessState9,
		
    }
}
