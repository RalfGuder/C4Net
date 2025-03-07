using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that identifies the source type from which intelligence information is obtained and which is referred to by a specific REPORTING-DATA.
    /// </summary>
    [DomId(100000318)]
    [DataContract]
    public enum ReportingDataSourceTypeEnum
    {
		
        /// <summary>
        /// The intelligence information is gathered either by visual observation from the air or through the use of airborne sensors.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIRREC")]
        [EnumMember]
        AirReconnaissance,
		
        /// <summary>
        /// The intelligence information is derived from artillery unit surveillance.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ARTOBS")]
        [EnumMember]
        ArtilleryObservation,
		
        /// <summary>
        /// The intelligence information is derived from documentation seized from the enemy.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CAPDOC")]
        [EnumMember]
        CapturedDocument,
		
        /// <summary>
        /// The intelligence information is derived from equipment or supplies seized from the enemy.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("CAPMAT")]
        [EnumMember]
        CapturedMaterial,
		
        /// <summary>
        /// The intelligence information is derived from electromagnetic communications and communications systems by other than intended recipients or users.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("COMINT")]
        [EnumMember]
        CommunicationsIntelligence,
		
        /// <summary>
        /// The discrete airborne, surface or subsurface intelligence information is collected from electronic, acoustic, and/or visual sensors.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CONTAC")]
        [EnumMember]
        Contact,
		
        /// <summary>
        /// The intelligence information is collected from a person who repudiates his or her country when beyond its jurisdiction or control.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("DEFECT")]
        [EnumMember]
        Defector,
		
        /// <summary>
        /// The intelligence information is derived from electromagnetic non-communications transmissions by other than intended recipients or users.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ELINT")]
        [EnumMember]
        ElectronicIntelligence,
		
        /// <summary>
        /// The intelligence information is derived from a human observation without any device.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("EYOBSN")]
        [EnumMember]
        EyeballObservation,
		
        /// <summary>
        /// The intelligence information is derived from ground reconnaissance tasks.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("GRDREC")]
        [EnumMember]
        GroundReconnaissance,
		
        /// <summary>
        /// The intelligence information is collected and provided by human sources.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("HUMINT")]
        [EnumMember]
        HumanIntelligence,
		
        /// <summary>
        /// The intelligence information is reported as mission results by aircrews while in flight.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("INFLIT")]
        [EnumMember]
        Inflight,
		
        /// <summary>
        /// The intelligence information is derived from ground reconnaissance behind the FLOT.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("LRRP")]
        [EnumMember]
        LongRangeReconnaissancePatrol,
		
        /// <summary>
        /// The intelligence information is derived from captured forces.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("POW")]
        [EnumMember]
        PrisonerOfWar,
		
        /// <summary>
        /// The intelligence information is derived from persons who, owing to religious persecution or political troubles, move within their own country (national refugees) or across international boundaries.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("REFUGE")]
        [EnumMember]
        Refugee,
		
        /// <summary>
        /// The intelligence information is derived from an unmanned vehicle capable of being controlled from a distant location through a communication link.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("RPV")]
        [EnumMember]
        RemotelyPilotedVehicle,
		
        /// <summary>
        /// The intelligence information is derived from satellite surveillance or reconnaissance.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("SAT")]
        [EnumMember]
        Satellite,
		
        /// <summary>
        /// The intelligence information is collected either by communications intelligence or electronic intelligence when there is no requirement to differentiate between these two types of intelligence, or represents a fusion of information from the two.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SIGINT")]
        [EnumMember]
        SignalIntelligence,
		
        /// <summary>
        /// The intelligence information is derived from an unmanned ground sensor device.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("UGS")]
        [EnumMember]
        UnattendedGroundSensor,
		
        /// <summary>
        /// The source of the intelligence information is not specified.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("UNSPEC")]
        [EnumMember]
        UnspecifiedSensitiveSource,
		
        /// <summary>
        /// The intelligence information is derived from different sources.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("VARI")]
        [EnumMember]
        VariousSources,
		
        /// <summary>
        /// The intelligence information is derived from airborne infrared systems.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("AIRIFR")]
        [EnumMember]
        AirborneInfrared,
		
        /// <summary>
        /// The intelligence information is derived from an individual whose primary mission is to observe or take photographs from an aircraft.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("AOBSR")]
        [EnumMember]
        AirObserver,
		
        /// <summary>
        /// The intelligence information is derived from flash ranging devices.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("FLRNG")]
        [EnumMember]
        FlashRanging,
		
        /// <summary>
        /// The intelligence information is derived from an observer with forward troops trained to call for and adjust supporting fire and pass battlefield information.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("FO")]
        [EnumMember]
        ForwardObserver,
		
        /// <summary>
        /// The intelligence information is derived from an observer with forward troops without laser systems.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("FOWOL")]
        [EnumMember]
        ForwardObserverWithoutLaser,
		
        /// <summary>
        /// The intelligence information is derived from non-artillery observation.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("OBSR")]
        [EnumMember]
        ObserverNotArtillery,
		
        /// <summary>
        /// The intelligence information is derived from extraction from photographs or other recorded images.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("PI")]
        [EnumMember]
        PhotoInterpretation,
		
        /// <summary>
        /// The intelligence information is derived from counter battery radar systems.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("CBRR")]
        [EnumMember]
        RadarCounterBattery,
		
        /// <summary>
        /// The intelligence information is derived from counter mortar radar systems.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("CMRR")]
        [EnumMember]
        RadarCounterMortar,
		
        /// <summary>
        /// The intelligence information is derived from ground surveillance radar systems.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("GSRA")]
        [EnumMember]
        RadarGroundSurveillance,
		
        /// <summary>
        /// The intelligence information is derived from an airborne radar, viewing at right angles to the axis of the vehicle, which produces a presentation of terrain or moving targets.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("SLAR")]
        [EnumMember]
        RadarSideLooking,
		
        /// <summary>
        /// The intelligence information is derived from sound ranging devices.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("SORNG")]
        [EnumMember]
        SoundRanging,
		
        /// <summary>
        /// The intelligence information is derived from tactical air operations.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("TACAIR")]
        [EnumMember]
        TacticalAir,
		
        /// <summary>
        /// The intelligence information is derived from target bases.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("TGTB")]
        [EnumMember]
        TargetBase,
		
    }
}
