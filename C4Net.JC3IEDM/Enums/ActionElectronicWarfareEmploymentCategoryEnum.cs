using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents an electronic or mechanical technique.
    /// </summary>
    [DomId(100004274)]
    [DataContract]
    public enum ActionElectronicWarfareEmploymentCategoryEnum
    {
		
        /// <summary>
        /// Imitating or controlling the signature of a ship to mislead or deceive the enemy.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACOUST")]
        [EnumMember]
        AcousticSimulationOfSurfaceAndSubsurfaceForces,
		
        /// <summary>
        /// Employed to offset unfriendly radar detection capability by dispensing a blanket of chaff over a designated area.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CHAFBL")]
        [EnumMember]
        ChaffBlanket,
		
        /// <summary>
        /// Chaff drops at intervals short enough to appear on radar displays as an individual target.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CHAFBU")]
        [EnumMember]
        ChaffBurst,
		
        /// <summary>
        /// To offset unfriendly radar detection capability by dispensing a heavy continuous trail of chaff from an aircraft in a corridor fashion as it approaches the radar.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("CHAFCO")]
        [EnumMember]
        ChaffCorridor,
		
        /// <summary>
        /// Employed to offset unfriendly radar detection and associated weapons employment by dispensing singular or limited bursts of chaff.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CHAFSE")]
        [EnumMember]
        ChaffSelfProtection,
		
        /// <summary>
        /// Can be accomplished by using sounds to mask unavoidable operational noises.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CONCEL")]
        [EnumMember]
        ConcealmentOfForces,
		
        /// <summary>
        /// The deliberate act of conveying through friendly communications false or misleading information to support an overall cover and deception plan.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CONTRL")]
        [EnumMember]
        ControlledBreachesOfCommunicationSecurity,
		
        /// <summary>
        /// A sophisticated imitative communications deception (ICD) technique whereby SIGINT personnel gain access to the enemy’s communication system and introduce bogus messages enciphered in the enemy’s own crypto system.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("CRYPTO")]
        [EnumMember]
        CryptographicIntrusion,
		
        /// <summary>
        /// The increase or decrease of friendly activity.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("DCFLAC")]
        [EnumMember]
        DeceiveFalseActivity,
		
        /// <summary>
        /// This technique is the reverse of false traffic levels and serves the purpose of simulating unusual activity on a communication net.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("DCFLPK")]
        [EnumMember]
        DeceiveFalsePeaks,
		
        /// <summary>
        /// A method of deceiving the enemy by creating false targets.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("DCFLTA")]
        [EnumMember]
        DeceiveFalseTargetGenerationOrSpoofing,
		
        /// <summary>
        /// This technique is applied on a communications net over a period of days to create the impression of normal operations.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("DCFLTR")]
        [EnumMember]
        DeceiveFalseTrafficLevels,
		
        /// <summary>
        /// Used to generate multiple false targets.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("DCMLFL")]
        [EnumMember]
        DeceiveMultipleFalseTargets,
		
        /// <summary>
        /// The variance of location and usage of emitters in tactical units to alter the stereotype patterns associated with those electromagnetic signatures.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("ELECCO")]
        [EnumMember]
        ElectronicCover,
		
        /// <summary>
        /// A method of transmitting radiation to prevent enemy detection.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("EWSELF")]
        [EnumMember]
        ElectronicWarfareSelfProtection,
		
        /// <summary>
        /// The method of breaking a lock on a conical scan tracking radar by providing false azimuth information.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("INVGNM")]
        [EnumMember]
        InverseGainModulation,
		
        /// <summary>
        /// The simultaneous jamming of a number of adjacent channels or frequencies.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("JAMBAR")]
        [EnumMember]
        JamBarrage,
		
        /// <summary>
        /// The broadcast or rebroadcast of any type of noise or other transmission intended to render the victim communications frequency unusable.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("JAMCOM")]
        [EnumMember]
        JamCommunicationsNoise,
		
        /// <summary>
        /// A method of transmitting signals which will prevent or reduce the enemy’s use of the communication portion of the electromagnetic spectrum, without his being aware of the source of emissions.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("JAMDEC")]
        [EnumMember]
        JamDeceptive,
		
        /// <summary>
        /// The intercept of the intended victim signal, which is then altered and retransmitted for the purpose of falsifying or disrupting information flow.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("JAMREP")]
        [EnumMember]
        JamRepeater,
		
        /// <summary>
        /// The jamming of a specific channel or frequency.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("JAMSPT")]
        [EnumMember]
        JamSpot,
		
        /// <summary>
        /// Used for search for and jam signals automatically over a broad frequency band employing a sweeping technique.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("JAMSWP")]
        [EnumMember]
        JamSweep,
		
        /// <summary>
        /// The employment of a sweeping receiver with a jammer that locks on a detected victim signal and performs spot jamming.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("JAMSWL")]
        [EnumMember]
        JamSweepLockOn,
		
        /// <summary>
        /// Automatically transmits a predetermined signal and is programmed to respond to a specific type of victim signal.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("JAMTRS")]
        [EnumMember]
        JamTransponder,
		
        /// <summary>
        /// An ICD technique whereby SIGINT/EW personnel gain entry into the enemy’s communications net as a bonafide subscriber, to harass and distract the enemy.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("NUISNC")]
        [EnumMember]
        NuisanceIntrusion,
		
        /// <summary>
        /// This method involves the insertion of dummy code or cipher groups into individual valid encrypted messages.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("PADDNG")]
        [EnumMember]
        Padding,
		
        /// <summary>
        /// A device released by a submarine to create false sonar targets by generating clouds of air or gas bubbles.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("PILL")]
        [EnumMember]
        Pill,
		
        /// <summary>
        /// A technique similar to nuisance intrusion with the intent to introduce valid enemy traffic into the enemy’s communication network.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("PLNMSG")]
        [EnumMember]
        PlannedMessageIntrusion,
		
        /// <summary>
        /// This technique involves stealing the tracking radars timing gate to disrupt the tracking function.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("RANGGT")]
        [EnumMember]
        RangeGatePullOff,
		
        /// <summary>
        /// Consists of flat reflecting surfaces, of various shapes and sizes, connected to form a three-dimensional reflector.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("RFLCCR")]
        [EnumMember]
        ReflectorCorner,
		
        /// <summary>
        /// A floating radar reflector used to simulate surface targets.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("RLLCGL")]
        [EnumMember]
        ReflectorGull,
		
        /// <summary>
        /// Deceptive method of concealing the routing of traffic by sending to stations other than the intended recipients.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("ROUTNG")]
        [EnumMember]
        Routing,
		
        /// <summary>
        /// This technique causes the enemy radar antenna to loose lock on target.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("SCANRT")]
        [EnumMember]
        ScanRateModulation,
		
        /// <summary>
        /// Simulate sounds or noises that resemble an amphibious operation such as dropping anchors, starting boat engines, etc.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("SIMAMP")]
        [EnumMember]
        SimulationAmphibiousWarfare,
		
        /// <summary>
        /// This technique can be achieved by projecting selected audio signals or by emitting sounds from specific areas.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("SIMFRC")]
        [EnumMember]
        SimulationForce,
		
        /// <summary>
        /// Simulate river patrol operations.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("SIMRIV")]
        [EnumMember]
        SimulationRiverineWarfare,
		
        /// <summary>
        /// A combination of sonic deception and surface craft movements during low visibility.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("SIMTAC")]
        [EnumMember]
        SimulationTacticalMovements,
		
        /// <summary>
        /// Establishing a network of communications and non-communications emitters to simulate a unit or organisation. The creation of fictitious friendly units with actual or specially designed equipment.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("SIMUNT")]
        [EnumMember]
        SimulationUnit,
		
    }
}
