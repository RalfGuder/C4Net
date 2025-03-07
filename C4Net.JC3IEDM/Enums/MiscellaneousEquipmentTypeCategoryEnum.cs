using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MISCELLANEOUS-EQUIPMENT-TYPE.
    /// </summary>
    [DomId(100000344)]
    [DataContract]
    public enum MiscellaneousEquipmentTypeCategoryEnum
    {
		
        /// <summary>
        /// A light that is used for the determination of bearings, courses, or locations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BCNLGT")]
        [EnumMember]
        BeaconLight,
		
        /// <summary>
        /// A container with a narrow neck, used for storing liquids, or a large metal cylinder holding liquefied gas.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BOTTLE")]
        [EnumMember]
        Bottle,
		
        /// <summary>
        /// Equipment used to show the way or direct movement.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("GUIDNC")]
        [EnumMember]
        Guidance,
		
        /// <summary>
        /// A machine capable of printing documents
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PRTMAC")]
        [EnumMember]
        PrintingMachine,
		
        /// <summary>
        /// An electric arc-lamp fitted with a reflector and suspended in a frame so that it may throw a beam of light in any desired direction; used in naval defence and for signalling purposes, etc.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SRCHLT")]
        [EnumMember]
        Searchlight,
		
        /// <summary>
        /// A system used to generate smoke in the battlespace.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SMKGEN")]
        [EnumMember]
        SmokeGenerator,
		
        /// <summary>
        /// A large receptacle or storage chamber, especially for liquid or gas.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("TANK")]
        [EnumMember]
        Tank,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A receptacle in which material is held or carried.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CONTNR")]
        [EnumMember]
        Container,
		
        /// <summary>
        /// Equipment specifically designed to be used in executing demolition tasks.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("DEMOEQ")]
        [EnumMember]
        DemolitionEquipment,
		
        /// <summary>
        /// A device that is used to carry and release submunitions.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("DSPNSR")]
        [EnumMember]
        Dispenser,
		
        /// <summary>
        /// Machines or machine parts in general.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MCHNRY")]
        [EnumMember]
        Machinery,
		
        /// <summary>
        /// A non-electronic instrument for carrying sound a long distance.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("MEGPHN")]
        [EnumMember]
        Megaphone,
		
        /// <summary>
        /// A machine for compressing air for use as a motive power.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("AIRCMP")]
        [EnumMember]
        AirCompressor,
		
        /// <summary>
        /// Equipment designed to facilitate aerial refuelling.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("AIRREF")]
        [EnumMember]
        AircraftRefuelling,
		
        /// <summary>
        /// A system for aerial delivery of supplies and small items of equipment from low or high altitudes into a small area.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("CNTDLS")]
        [EnumMember]
        ContainerDeliverySystem,
		
        /// <summary>
        /// An apparatus for the production of electricity.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("GENER")]
        [EnumMember]
        Generator,
		
        /// <summary>
        /// A light source that is designed to identify the source or location of a hazard.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("HAZLGT")]
        [EnumMember]
        HazardLight,
		
        /// <summary>
        /// A low-level, self-contained system capable of delivering heavy loads into an area where air landing is not feasible from an optimum aircraft wheel altitude of 5 to 10 feet above ground level.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("LAPSE")]
        [EnumMember]
        LowAltitudeParachuteExtractionSystem,
		
        /// <summary>
        /// A light source designed to be used for communication using a predefined code system of on and off flashes.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("SIGLGT")]
        [EnumMember]
        SignalLight,
		
        /// <summary>
        /// An imitation in any sense of a person, object or phenomenon which is intended to deceive enemy surveillance devices or mislead enemy evaluation.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("DECOY")]
        [EnumMember]
        Decoy,
		
        /// <summary>
        /// Equipment associated with photography.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("PHOTOG")]
        [EnumMember]
        Photographic,
		
        /// <summary>
        /// A discrete physical storage device (e.g., CD, DVD, USB stick, etc.).
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("ELCMED")]
        [EnumMember]
        ElectronicMediaDetachedPhysicalStorage,
		
        /// <summary>
        /// A thin flexible transparent material for recording imagery.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("FILM")]
        [EnumMember]
        Film,
		
        /// <summary>
        /// A tape coated or impregnated with a magnetic material or made of magnetic material intended for data recording.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("MAGTPE")]
        [EnumMember]
        MagneticTape,
		
        /// <summary>
        /// A substance composed of fibres for writing, printing or drawing on.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("PAPER")]
        [EnumMember]
        Paper,
		
        /// <summary>
        /// A lighting system put on top of a vertical obstacle to air navigation.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("AROBSL")]
        [EnumMember]
        AirObstructionLighting,
		
        /// <summary>
        /// A strong thick rope of hemp or wire.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("CABLE")]
        [EnumMember]
        Cable,
		
        /// <summary>
        /// A large roll of strong thick rope of hemp or wire wound onto a drum or spindle.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("CABLER")]
        [EnumMember]
        CableReel,
		
        /// <summary>
        /// A piece of bunting or other material usually oblong or square attached by one edge to a staff or pole and fixed to a float, mine, buoy in order to mark its location.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("FLAG")]
        [EnumMember]
        Flag,
		
        /// <summary>
        /// An equipment that is used to provide light to illuminate the location of an equipment, e.g a buoy.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("LAMP")]
        [EnumMember]
        Lamp,
		
        /// <summary>
        /// A piece of rope, cord, wire serving a special purpose.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("LINE")]
        [EnumMember]
        Line,
		
        /// <summary>
        /// A visual or electronic aid used to mark a designated point or area.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("MARKER")]
        [EnumMember]
        Marker,
		
        /// <summary>
        /// A piece of stout cord made of twisted strands of hemp, sisal, cotton, nylon, wire or other similar material.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("ROPE")]
        [EnumMember]
        Rope,
		
        /// <summary>
        /// Equipment specifically designed to be used for an agricultural purpose.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("AGRCTL")]
        [EnumMember]
        AgriculturalMaterial,
		
        /// <summary>
        /// A field-glass in the use of which both eyes are employed in viewing an object.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("BINOCL")]
        [EnumMember]
        Binoculars,
		
        /// <summary>
        /// Goods and utensils such as locks, tools, and cutlery and other items used within a domestic unit.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("HOUSHD")]
        [EnumMember]
        HouseholdHardware,
		
        /// <summary>
        /// A thing with which some operation is performed; a means of effecting something; an instrument.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("TOOL")]
        [EnumMember]
        Tool,
		
    }
}
