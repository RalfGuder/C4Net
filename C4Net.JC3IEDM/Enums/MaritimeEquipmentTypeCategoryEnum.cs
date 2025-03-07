using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MARITIME-EQUIPMENT-TYPE.
    /// </summary>
    [DomId(100004281)]
    [DataContract]
    public enum MaritimeEquipmentTypeCategoryEnum
    {
		
        /// <summary>
        /// An equipment for holding a vessel in a fixed position mooring it to the bottom of the sea or river by means of a heavy structure traditionally composed of a long shank with a ring at one end for the cable and at the other end two arms tending upwards with barbs on each side.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ANCHOR")]
        [EnumMember]
        Anchor,
		
        /// <summary>
        /// A floating object fastened in a particular place to mark the position of underwater objects or the course that ships have to navigate.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BUOY")]
        [EnumMember]
        Buoy,
		
        /// <summary>
        /// In naval mine warfare a device fitted to a sweep wire to cut or part the mooring of mines or obstructors. It may also be fitted in, or to, the mooring of a mine or obstructors to part a sweep wire.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CUTTER")]
        [EnumMember]
        Cutter,
		
        /// <summary>
        /// A structural device designed to support and hold a depth-charge in position for firing.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DCLAUN")]
        [EnumMember]
        DepthChargeLauncher,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1135/55.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("DIAPHR")]
        [EnumMember]
        Diaphragm,
		
        /// <summary>
        /// An object used to carry the magnetic cable in a dispersed form of loop, a specific form of float.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("DVERTR")]
        [EnumMember]
        Diverter,
		
        /// <summary>
        /// In naval mine warfare, a magnetic cable sweep in which salt water and the seabed form part of the electric circuit.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ELCTRD")]
        [EnumMember]
        Electrode,
		
        /// <summary>
        /// A cork or other buoyant object that is used to support other equipment, a mine sweep wire for surface minesweepng.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("FLOAT")]
        [EnumMember]
        Float,
		
        /// <summary>
        /// A device which when towed submerges and planes at a predetermined depth without sideways displacement.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("KITEDP")]
        [EnumMember]
        KiteDepressor,
		
        /// <summary>
        /// ROV used to destroy mines normally armed with MDC mine disposal charge.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("MRTMDV")]
        [EnumMember]
        MaritimeMineDisposalVehicle,
		
        /// <summary>
        /// Equipment designed to locate the mine by operating the magnetic firing system of a mine.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("MECHNF")]
        [EnumMember]
        MechanicalInfluence,
		
        /// <summary>
        /// A device laid with the sole object of obstructing or damaging mechanical minesweeping equipment.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("OBSTRM")]
        [EnumMember]
        ObstructorsMine,
		
        /// <summary>
        /// In naval mine warfare, a device which, when towed, displaces itself sideways to a predetermined distance.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("OTTER")]
        [EnumMember]
        Otter,
		
        /// <summary>
        /// A towed body with planes and a cutter with a means of depth keeping, which displaces itself sideways and can be used as a ship protection measure against certain moored mines.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("PARVNE")]
        [EnumMember]
        Paravane,
		
        /// <summary>
        /// Orange floats used to support a length of line to aid recovery.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("PELLET")]
        [EnumMember]
        Pellets,
		
        /// <summary>
        /// An object designed to increase the radio reflectivity of a vessel so that it is more visible on radar.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("RADARR")]
        [EnumMember]
        RadarReflector,
		
        /// <summary>
        /// Part of the mooring equipment used with a short scope buoy.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("RBBRMR")]
        [EnumMember]
        RubberMooring,
		
        /// <summary>
        /// An acoustic device used primarily for the detection and location of underwater objects.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("SONARM")]
        [EnumMember]
        SonarMaritime,
		
        /// <summary>
        /// Equipment designed to be employed in minesweeping operations.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("SWEEP")]
        [EnumMember]
        Sweep,
		
        /// <summary>
        /// A device used to record the pressure fluctuation on the bottom.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SWELLR")]
        [EnumMember]
        SwellRecorder,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("TASVST")]
        [EnumMember]
        TowedArraySurveillanceSystem,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("TTASVS")]
        [EnumMember]
        TowedArraySurveillanceSystemTactical,
		
        /// <summary>
        /// A heavy object used to pull, press or hold something down, e.g. buoy, mine.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("WEIGHT")]
        [EnumMember]
        Weight,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
