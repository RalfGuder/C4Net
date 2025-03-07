using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of ELECTRONIC-EQUIPMENT-TYPE.
    /// </summary>
    [DomId(100000340)]
    [DataContract]
    public enum ElectronicEquipmentTypeSubcategoryEnum
    {
		
        /// <summary>
        /// A radar used for monitoring air traffic.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("RDRATC")]
        [EnumMember]
        RadarAirTrafficControl,
		
        /// <summary>
        /// The transmission and reception of radio-frequency electromagnetic waves as a means of communication usually as a hobby.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AMTRAD")]
        [EnumMember]
        AmateurRadioDevice,
		
        /// <summary>
        /// A device, usually film, tapes, or Laser Disk used for the storage of sound.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("AUDSTD")]
        [EnumMember]
        AudioStorageDevice,
		
        /// <summary>
        /// An electronic source that emits a distinctive or characteristic signal used for the determination of bearings, courses, or locations.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BEACON")]
        [EnumMember]
        Beacon,
		
        /// <summary>
        /// An equipment for sending or receiving electromagnetic waves.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("COMANT")]
        [EnumMember]
        CommunicationAntenna,
		
        /// <summary>
        /// A set of equipment designed for communications purposes.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("COMSYS")]
        [EnumMember]
        CommunicationSystem,
		
        /// <summary>
        /// A vehicle equipped with communication devices.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("COMVEH")]
        [EnumMember]
        CommunicationVehicle,
		
        /// <summary>
        /// The equipment providing the means of transmitting and receiving data.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("DATLNK")]
        [EnumMember]
        DataLink,
		
        /// <summary>
        /// A system using electromagnetic transmissions to which equipment carried by friendly forces automatically responds.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("IDNTFF")]
        [EnumMember]
        IdentificationFriendFoe,
		
        /// <summary>
        /// An instrument for converting variations in an applied electrical current or voltage into corresponding sound waves.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("LOUDSP")]
        [EnumMember]
        Loudspeaker,
		
        /// <summary>
        /// An electronic instrument for carrying sound a long distance.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MEGPHN")]
        [EnumMember]
        Megaphone,
		
        /// <summary>
        /// Organised wireless broadcasting in sound as a medium of communication or as an art form.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("RADBRD")]
        [EnumMember]
        RadioBroadcastDevice,
		
        /// <summary>
        /// SOund NAvigation Ranging. A sonic device used primarily for the detection and location of underwater objects.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("SONAR")]
        [EnumMember]
        Sonar,
		
        /// <summary>
        /// A device that stores images to be displayed on a television screen or other cathode-ray tube device.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("VIDBRD")]
        [EnumMember]
        VideoBroadcastDevice,
		
        /// <summary>
        /// A device, usually film, tape, Digital Video Device (DVD) or Laser Disk used for the storage of pictures.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("VISSTR")]
        [EnumMember]
        VisualStorageDevice,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A device for making and breaking the connections in a telephone system.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("TELSWT")]
        [EnumMember]
        TelephoneSwitch,
		
        /// <summary>
        /// A device that records the ocean temperature at various depths. Used to assist in the determination of characteristics of sound propagation and sonar detection.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("BTHTGH")]
        [EnumMember]
        Bathythermograph,
		
        /// <summary>
        /// An expendable device that records the ocean temperature at various depths. Used to assist in the determination of characteristics of sound propagation and sonar detection.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("BTHTGE")]
        [EnumMember]
        BathythermographExpendable,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("BUOYCL")]
        [EnumMember]
        BuoyCalibration,
		
        /// <summary>
        /// A high-vacuum tube in which cathode rays produce a luminous image on a fluorescent screen.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("CTRYTB")]
        [EnumMember]
        CathodeRayTube,
		
        /// <summary>
        /// A High Frequency Direction Finding ocean surveillance system.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("CLSWZD")]
        [EnumMember]
        ClassicWizard,
		
        /// <summary>
        /// A system that may be hardened or ruggedized for use in combat employed for determining the bearing of an electromagnetic emission.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("CBDCFD")]
        [EnumMember]
        CombatDirectionFinding,
		
        /// <summary>
        /// Those parts of two data terminal equipments that are controlled by a protocol along with the interconnecting optical data circuit, that together enable data transfer.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("DTLOPT")]
        [EnumMember]
        DataLinkOptical,
		
        /// <summary>
        /// Those parts of two data terminal equipments that are controlled by a protocol along with the interconnecting radio data circuit, that together enable data transfer.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("DTLRAD")]
        [EnumMember]
        DataLinkRadio,
		
        /// <summary>
        /// Equipment that provides detection, identification, and direction-finding for radar and communication signals emanating from ships, aircraft, submarines, and other emitters.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("ELSPSM")]
        [EnumMember]
        ElectronicSupportMeasure,
		
        /// <summary>
        /// Equipment that deals with the translation of electromagnetic radiation in the visible and infrared portion of the spectrum into a format suitable for electronic application and vice versa.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("ELTOPT")]
        [EnumMember]
        Electrooptical,
		
        /// <summary>
        /// An airborne, electro-optical thermal imaging device that detects far-infrared energy, converts the energy into an electronic signal, and provides a visible image for day or night viewing. Also called FLIR.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("FLIR")]
        [EnumMember]
        ForwardLookingInfrared,
		
        /// <summary>
        /// A commercial electronic system that receives and translates signals from global positioning system satellites.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("GPSCOM")]
        [EnumMember]
        GpsReceiverCommercial,
		
        /// <summary>
        /// A military electronic system that receives and translates signals from global positioning system satellites.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("GPSMIL")]
        [EnumMember]
        GpsReceiverMilitary,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("HFRDFD")]
        [EnumMember]
        HighFrequencyDirectionFinder,
		
        /// <summary>
        /// Equipment that uses a circularly-disposed antenna array, looks similar to a bulls-eye, and can detect, locate and identify targets at long range.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("HFDFBL")]
        [EnumMember]
        HighFrequencyDirectionFinderBullseye,
		
        /// <summary>
        /// A direction finder that can detect, locate, and identify targets at long range. OUTBOARD - Organizational Unit Tactical Baseline Operational Area Radio Detection.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("HFDFOT")]
        [EnumMember]
        HighFrequencyDirectionFinderOutboard,
		
        /// <summary>
        /// Equipment used to detect signals that fall within the region of the electromagnetic spectrum between the long wavelength extreme of the visible spectrum (about 0.7 micrometers) and the shortest microwaves (about 1 millimetre).
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("INDETS")]
        [EnumMember]
        InfraredDetectionSystem,
		
        /// <summary>
        /// Fixed, mobile, and deployable acoustic listening arrays that provide a means for submarine detection.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("INUWSS")]
        [EnumMember]
        IntegratedUnderwaterSurveillanceSystem,
		
        /// <summary>
        /// A receiver utilising the electromagnetic spectrum for the interception of speech and data information.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("INTERC")]
        [EnumMember]
        InterceptReceiver,
		
        /// <summary>
        /// Large shipboard sonar that uses intense sound for long-range surveillance and detecting submarines.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("LFRACS")]
        [EnumMember]
        LowFrequencyActiveSystem,
		
        /// <summary>
        /// System that detects sounds emitted by submarines using a hydrophone lowered from a passive omnidirectional sonobuoy. Also known as LOFAR system.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("LFRARC")]
        [EnumMember]
        LowFrequencyAnalysisAndRecordingSystem,
		
        /// <summary>
        /// Television-type system that uses ambient light to reduce the value of the ratio of brightness between target and background and the brightness of the background that is used for day/night surveillance, target acquisition, fire control, fire adjustment, target identification, and target tracking; the LLLTV cannot “see” in complete darkness, it needs some ambient light from the atmosphere, moon, stars etc.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("LGLVTV")]
        [EnumMember]
        LowLightLevelTelevision,
		
        /// <summary>
        /// A device that detects minute natural or man-made variations in the Earth's magnetic field and is used to detect submarines from aircraft.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("MGANDT")]
        [EnumMember]
        MagneticAnomalyDetector,
		
        /// <summary>
        /// A scope, goggles, camera or other device that uses either ambient light amplification or thermal imaging using the infrared spectrum enabling vision during periods of low light.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("NGOBDV")]
        [EnumMember]
        NightObservationDevice,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1677/7.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("OPTICL")]
        [EnumMember]
        Optical,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1677/7.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("PANOVW")]
        [EnumMember]
        PanoramicView,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("PHOTOG")]
        [EnumMember]
        Photographic,
		
        /// <summary>
        /// A cathode ray oscilloscope on the screen of which radar echoes are represented for observation.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("RDRSCP")]
        [EnumMember]
        RadarScope,
		
        /// <summary>
        /// A multimode real-time, high-resolution reconnaissance system carried on an aircraft with all-weather, day-night, and long-range mapping capabilities. ASARS detects and accurately locates stationary and moving ground targets.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("RDRASA")]
        [EnumMember]
        RadarAdvancedSyntheticAperture,
		
        /// <summary>
        /// A radar used specifically in an air-defence tracking mode.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("RDRADT")]
        [EnumMember]
        RadarAirDefenceTracking,
		
        /// <summary>
        /// A radar carried through the air by an aircraft.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("RDRARB")]
        [EnumMember]
        RadarAirborne,
		
        /// <summary>
        /// The radar used for systematic observation of air space by electronic or other means, primarily for the purpose of identifying and determining the movements of aircraft and missiles, friendly and enemy, in the air space under observation.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("RDRARS")]
        [EnumMember]
        RadarAirSurveillance,
		
        /// <summary>
        /// A radar used specifically for bomb navigation.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("RDRBNV")]
        [EnumMember]
        RadarBombNavigation,
		
        /// <summary>
        /// A radar used to detect and locate enemy artillery weapon systems.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("RDRCAT")]
        [EnumMember]
        RadarCounterArtillery,
		
        /// <summary>
        /// Weapon locating radar capable of locating guns, mortars and rockets.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("RDRCBR")]
        [EnumMember]
        RadarCounterBatteryRanging,
		
        /// <summary>
        /// Mortar locating radar capable of locating mortars.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("RDRCMR")]
        [EnumMember]
        RadarCounterMortarRanging,
		
        /// <summary>
        /// The radar used for determining the bearing of an electromagnetic emission.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("RDRDFD")]
        [EnumMember]
        RadarDirectionFinding,
		
        /// <summary>
        /// A radar used for early notification of the launch or approach of unknown weapons or weapon carriers.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("RDREWA")]
        [EnumMember]
        RadarEarlyWarningAcquisition,
		
        /// <summary>
        /// A radar used for tracking satellite or other objects in space.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("RDREST")]
        [EnumMember]
        RadarEarthSatelliteSpaceTracking,
		
        /// <summary>
        /// Radar used to provide target information inputs to a weapon fire control system.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("RDRFC")]
        [EnumMember]
        RadarFireControl,
		
        /// <summary>
        /// Radar with the normal function of maintaining continuous watch over an area.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("RDRGRS")]
        [EnumMember]
        RadarGroundSurveillance,
		
        /// <summary>
        /// A radar used to display the distance between an aircraft datum and the surface vertically below as determined by a reflecting radar transmission.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("RDRHFD")]
        [EnumMember]
        RadarHeightFinding,
		
        /// <summary>
        /// A radar that provides detailed information on the size and shape of a target and surface imaging.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("RDRHRL")]
        [EnumMember]
        RadarHighResolution,
		
        /// <summary>
        /// A high-resolution radar that tracks a moving object by using a stationary single radiating antenna element that transmits when the moving object is at sequential positions on its line of movement. Used in maritime surveillance.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("RDISAR")]
        [EnumMember]
        RadarInverseSyntheticAperture,
		
        /// <summary>
        /// A long-range, air-to-ground surveillance system designed to locate, classify and track ground targets in all weather conditions.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("RDRJST")]
        [EnumMember]
        RadarJointSurveillanceTargetAttack,
		
        /// <summary>
        /// A radar used to observe and measure meteorological conditions.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("RDRMET")]
        [EnumMember]
        RadarMeteorological,
		
        /// <summary>
        /// A navigation radar is a means by which direction and/or position is assessed when moving from one point to another. The radar facilitates navigation by determining position and may also provide vector information for calculating direction and speed.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("RDRNAV")]
        [EnumMember]
        RadarNavigation,
		
        /// <summary>
        /// A radar system that makes use of the atmospheric reflection and refraction phenomena to extend its range of detection beyond line of sight.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("RDOTHR")]
        [EnumMember]
        RadarOverTheHorizon,
		
        /// <summary>
        /// A radar that is designated to be the primary in a particular platform.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("RDRPRI")]
        [EnumMember]
        RadarPrimary,
		
        /// <summary>
        /// A radar used for the process of establishing target distance.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("RDRRNG")]
        [EnumMember]
        RadarRanging,
		
        /// <summary>
        /// A relocatable radar system makes use of the atmospheric reflection and refraction phenomena to extend its range of detection beyond line of sight.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("RROTHR")]
        [EnumMember]
        RadarRelocatableOverTheHorizon,
		
        /// <summary>
        /// An airborne radar, viewing at right angles to the axis of the vehicle, which produces a presentation of terrain or moving targets.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("RDSLAR")]
        [EnumMember]
        RadarSideLookingAirborne,
		
        /// <summary>
        /// A radar, viewing at right angles to the axis of the vehicle, which produces a presentation of terrain or moving targets.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("RDRSLR")]
        [EnumMember]
        RadarSideLooking,
		
        /// <summary>
        /// A high-resolution radar that simulates a large aperture by using a single radiating antenna element installed on a moving platform and transmitting at sequential positions on a line.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("RDSNRS")]
        [EnumMember]
        RadarSyntheticAperture,
		
        /// <summary>
        /// Equipment that uses radio signal intercepts and their azimuths to determine a location of a transmitter.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("RADDFD")]
        [EnumMember]
        RadioDirectionFinding,
		
        /// <summary>
        /// Remote control of the motion of a craft or vehicle by means of radio waves.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("RADGDN")]
        [EnumMember]
        RadioGuidance,
		
        /// <summary>
        /// Telephone set that may be carried by a person and that uses a radio link with a telepoint base station or a base station of a mobile radio communication cellular system.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("RADTLP")]
        [EnumMember]
        RadioTelephone,
		
        /// <summary>
        /// The system for communication by teleprinter over radio circuits (RATT).
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("RADTLT")]
        [EnumMember]
        RadioTeletype,
		
        /// <summary>
        /// A device that uses laser energy for determining the distance from the device to a place or object.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("RNGLAS")]
        [EnumMember]
        RangefinderLaser,
		
        /// <summary>
        /// An equipment used to detect objects moving into or within an area of interest.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("RTINDD")]
        [EnumMember]
        RemoteIntrusionDetectionDevice,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("SHETLC")]
        [EnumMember]
        ShipboardEmitterLocator,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("SHINST")]
        [EnumMember]
        ShipboardInertialSystem,
		
        /// <summary>
        /// A device used for the process of establishing target distance using sound.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("SDRANG")]
        [EnumMember]
        SoundRanging,
		
        /// <summary>
        /// High-gain long fixed arrays in deep ocean basins that provide deep-water long-range detection capability using acoustic signals.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("SDSVST")]
        [EnumMember]
        SoundSurveillanceSystem,
		
        /// <summary>
        /// A board for frame bearing a set of switches for connecting and disconnecting the various circuits of an electrical system, such as a telegraph or telephone.
        /// </summary>
        [DomValIx(1000111)]
        [StringValue("SWCBRD")]
        [EnumMember]
        Switchboard,
		
        /// <summary>
        /// Photographic sensor that obtains photographic information from the air that is installed on a tactical air vehicle.
        /// </summary>
        [DomValIx(1000112)]
        [StringValue("TARPHS")]
        [EnumMember]
        TacticalAirReconnaissancePhotoSystem,
		
        /// <summary>
        /// Pertaining to or designating equipments connected to the end of a subscriber´s line or telegraph circuit, which can either establish or receive calls, or store and retransmit signals, and which can be uniquely identified.
        /// </summary>
        [DomValIx(1000113)]
        [StringValue("TELGPH")]
        [EnumMember]
        Telegraph,
		
        /// <summary>
        /// A telegraph instrument for transmitting telegraph messages as they are typed on a keyboard and printing incoming ones.
        /// </summary>
        [DomValIx(1000114)]
        [StringValue("TELTYP")]
        [EnumMember]
        Teletype,
		
        /// <summary>
        /// A device for the transmission of signals representing scenes, images of the scenes being reproduced on a screen as they are received.
        /// </summary>
        [DomValIx(1000115)]
        [StringValue("TELEVS")]
        [EnumMember]
        Television,
		
        /// <summary>
        /// A device that detects emitted infrared energy from both target and background, converts the infrared wavelengths to the visual spectrum.
        /// </summary>
        [DomValIx(1000116)]
        [StringValue("THEINF")]
        [EnumMember]
        ThermalInfrared,
		
        /// <summary>
        /// A satellite based navigation system.
        /// </summary>
        [DomValIx(1000119)]
        [StringValue("TRNRCV")]
        [EnumMember]
        TransitReceiver,
		
        /// <summary>
        /// An apparatus producing microwave frequency energy intended to be radiated by an antenna, normally for the purpose of radio communication.
        /// </summary>
        [DomValIx(1000120)]
        [StringValue("TRTMWV")]
        [EnumMember]
        TransmitterMicrowave,
		
        /// <summary>
        /// An expendable, non-repairable sonobuoy known as VLAD (DIFAR is short for Directional Frequency Analysis and Recording System) designed to increase the detection of signals of interest in an environment where there is an ever-increasing amount of ambient noise.
        /// </summary>
        [DomValIx(1000121)]
        [StringValue("VLAD")]
        [EnumMember]
        VerticalLineArrayDifar,
		
        /// <summary>
        /// Equipment that uses the visual portion of the electromagnetic spectrum.
        /// </summary>
        [DomValIx(1000122)]
        [StringValue("VISUAL")]
        [EnumMember]
        Visual,
		
        /// <summary>
        /// Search and height finding radars and communications equipment (AWACS) designed to provide air surveillance and to control airborne weapons systems usually carried by an aircraft.
        /// </summary>
        [DomValIx(1000123)]
        [StringValue("WCSAIR")]
        [EnumMember]
        WarningAndControlSystemAirborne,
		
        /// <summary>
        /// A radar that provides information used to guide an object such as a missile to a target.
        /// </summary>
        [DomValIx(1000124)]
        [StringValue("RDRGUD")]
        [EnumMember]
        RadarGuidance,
		
        /// <summary>
        /// A system of horizontal guidance embodied in the instrument landing system which indicates the horizontal deviation of the aircraft from its optimum path of descent along the axis of the runway.
        /// </summary>
        [DomValIx(1000125)]
        [StringValue("ILSLOC")]
        [EnumMember]
        InstrumentLandingSystemLocaliser,
		
        /// <summary>
        /// A device for conveying sound and other digital services from a subscriber to a network.
        /// </summary>
        [DomValIx(1000126)]
        [StringValue("TELEPH")]
        [EnumMember]
        Telephone,
		
        /// <summary>
        /// A system that provides platform threat warning or targeting support through passive reception of electromagnetic energy.
        /// </summary>
        [DomValIx(1000127)]
        [StringValue("THRTWS")]
        [EnumMember]
        ThreatWarningSystem,
		
        /// <summary>
        /// A marker beacon that indicates the final approach fix, where approach descent is commenced.
        /// </summary>
        [DomValIx(1000128)]
        [StringValue("MRKRBA")]
        [EnumMember]
        MarkerBackCourse,
		
        /// <summary>
        /// A marker beacon used with an Instrument Landing System Category II precision approach located between the middle marker and the end of the ILS runway that indicates that the pilot is at the designated decision height.
        /// </summary>
        [DomValIx(1000129)]
        [StringValue("MRKRIN")]
        [EnumMember]
        MarkerInner,
		
        /// <summary>
        /// A marker beacon that defines a point along the glide path of an Instrument Landing System (ILS) normally located at or near the point of decision height (ILS Category I).
        /// </summary>
        [DomValIx(1000130)]
        [StringValue("MRKRMD")]
        [EnumMember]
        MarkerMiddle,
		
        /// <summary>
        /// A marker beacon at or near the glide path intercept altitude of an instrument landing system approach.
        /// </summary>
        [DomValIx(1000131)]
        [StringValue("MRKROU")]
        [EnumMember]
        MarkerOuter,
		
        /// <summary>
        /// An electronic air navigation system operating on an ultra high frequency, able to provide continuous bearing and slant range to a selected station.
        /// </summary>
        [DomValIx(1000132)]
        [StringValue("TACTAN")]
        [EnumMember]
        TacticalAirNavigation,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1200/1.
        /// </summary>
        [DomValIx(1000133)]
        [StringValue("DM40AP")]
        [EnumMember]
        Dm40ApssCubic,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1200/1.
        /// </summary>
        [DomValIx(1000134)]
        [StringValue("LORANC")]
        [EnumMember]
        LoranC,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1200/1.
        /// </summary>
        [DomValIx(1000135)]
        [StringValue("MBRPOS")]
        [EnumMember]
        MbrPosition,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1200/1.
        /// </summary>
        [DomValIx(1000136)]
        [StringValue("MINIRN")]
        [EnumMember]
        MiniRangerModel,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1200/1.
        /// </summary>
        [DomValIx(1000137)]
        [StringValue("PINS")]
        [EnumMember]
        Pins,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1200/1.
        /// </summary>
        [DomValIx(1000138)]
        [StringValue("RYDSTD")]
        [EnumMember]
        RaydistDirector,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1200/1.
        /// </summary>
        [DomValIx(1000139)]
        [StringValue("RYDSTN")]
        [EnumMember]
        RaydistNonDirector,
		
        /// <summary>
        /// A hyperbolic radio navigation system offering coverage in the Bay of Biscay and the Western Approaches.
        /// </summary>
        [DomValIx(1000140)]
        [StringValue("TORAN")]
        [EnumMember]
        Toran,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1200/1.
        /// </summary>
        [DomValIx(1000141)]
        [StringValue("VSLBRG")]
        [EnumMember]
        VisualBrgRadarRange,
		
        /// <summary>
        /// A voice encryption Terminal that provides secure speech over a civil or military phone system.
        /// </summary>
        [DomValIx(1000142)]
        [StringValue("BRAHMS")]
        [EnumMember]
        Brahms,
		
        /// <summary>
        /// A tactical format or encipher relay of messages.
        /// </summary>
        [DomValIx(1000143)]
        [StringValue("CVRRAD")]
        [EnumMember]
        CoveredRadioTeletype,
		
        /// <summary>
        /// A secure voice communication security systems device.
        /// </summary>
        [DomValIx(1000144)]
        [StringValue("NESTOR")]
        [EnumMember]
        Nestor,
		
        /// <summary>
        /// A secure voice communications terminal.
        /// </summary>
        [DomValIx(1000145)]
        [StringValue("PRKHLL")]
        [EnumMember]
        Parkhill,
		
        /// <summary>
        /// A secure voice communications security systems device.
        /// </summary>
        [DomValIx(1000146)]
        [StringValue("SNGSDE")]
        [EnumMember]
        SingleSideBand,
		
        /// <summary>
        /// A secure device for voice and FM communications.
        /// </summary>
        [DomValIx(1000147)]
        [StringValue("VINSON")]
        [EnumMember]
        Vinson,
		
        /// <summary>
        /// Equipment specifically designed to use as a command and control information system.
        /// </summary>
        [DomValIx(1000148)]
        [StringValue("C2IS")]
        [EnumMember]
        C2Is,
		
        /// <summary>
        /// Any device that can communicate with a computer.
        /// </summary>
        [DomValIx(1000149)]
        [StringValue("COMPER")]
        [EnumMember]
        ComputerPeripheral,
		
    }
}
