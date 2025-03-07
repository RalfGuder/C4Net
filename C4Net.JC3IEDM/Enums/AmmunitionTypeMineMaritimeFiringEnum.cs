using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the firing mechanism for a maritime mine.
    /// </summary>
    [DomId(100004280)]
    [DataContract]
    public enum AmmunitionTypeMineMaritimeFiringEnum
    {
		
        /// <summary>
        /// A (maritime) mine firing mechanism actuated by the reflection from a target of a signal emitted by the mine.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACTIVE")]
        [EnumMember]
        Active,
		
        /// <summary>
        /// A (maritime) mine firing mechanism actuated by the effect of a target on some physical condition in the vicinity of the mine or on radiations emanating from the mine.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("INFLUN")]
        [EnumMember]
        Influence,
		
        /// <summary>
        /// A (maritime) mine firing mechanism with an acoustic circuit which responds to the acoustic field of a ship or sweep.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ACOUST")]
        [EnumMember]
        Acoustic,
		
        /// <summary>
        /// A (maritime) mine firing mechanism with an acoustic audio circuit which responds to the acoustic field of a ship or sweep.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ACOUAF")]
        [EnumMember]
        AcousticAudioFrequency,
		
        /// <summary>
        /// A (maritime) mine firing mechanism with an acoustic high frequency circuit, 20 to 50 Hz, which responds to the acoustic field of a ship or sweep.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ACOUHF")]
        [EnumMember]
        AcousticHighFrequency,
		
        /// <summary>
        /// A (maritime) mine firing mechanism with an acoustic low frequency circuit, less than 2 Hz, which responds to the acoustic field of a ship or sweep.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ACOULF")]
        [EnumMember]
        AcousticLowFrequency,
		
        /// <summary>
        /// A contact (maritime) mine firing mechanism which, when touched by a ferrous object, set up galvanic action to fire the mine. The antenna generally takes the form of a special section in the mooring cable, and/or special cable suspended above the mine by a float.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ANTENA")]
        [EnumMember]
        Antenna,
		
        /// <summary>
        /// A (maritime) mine firing mechanism fitted that is regarded as coarse firing.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("COARAS")]
        [EnumMember]
        CoarseAntiSweep,
		
        /// <summary>
        /// A (maritime) mine firing mechanism that fires depending upon the previous simultaneous or subsequent reception of signals resulting from other influences, such as acoustic and pressure.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("COMBIN")]
        [EnumMember]
        CombinationOverlap,
		
        /// <summary>
        /// A (maritime) mine firing mechanism that is designed to fire by physical contact between the target mine or its appendages.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CONTCT")]
        [EnumMember]
        Contact,
		
        /// <summary>
        /// A (maritime) mine firing mechanism fitted with a ship counting mechanism, a tactical device.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("FITWSC")]
        [EnumMember]
        FittedWithShipCounter,
		
        /// <summary>
        /// A (maritime) mine firing mechanism fitted with a timing mechanism that keeps the mine circuits open (off) for a preset time after laying. If fitted with also a rising mechanism the release and rising of the mine can be delayed by means of a device fitted to either the sinker or to the windings of the mooring cable.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("FITWDA")]
        [EnumMember]
        FittedWithDelayedArmingOrRisingMechanism,
		
        /// <summary>
        /// A (maritime) mine firing mechanism with a magnetic influence circuit that responds to the magnetic field of a ship.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MAGNET")]
        [EnumMember]
        Magnetic,
		
        /// <summary>
        /// A (maritime) mine firing mechanism with a magnetic influence circuit that responds to the horizontal component of the magnetic field of a ship.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MAGNHH")]
        [EnumMember]
        MagneticHHorizontalComponent,
		
        /// <summary>
        /// A (maritime) mine with a magnetic influence circuit that responds to the total component of the magnetic field of a ship.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("MAGNTT")]
        [EnumMember]
        MagneticTTotalComponent,
		
        /// <summary>
        /// A (maritime) mine firing mechanism with a magnetic influence circuit which responds to the vertical component of the magnetic field of a ship.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("MAGNVV")]
        [EnumMember]
        MagneticVVerticalComponent,
		
        /// <summary>
        /// A small object with a large sonar signal, or inert minelike objects, Non-mine Bottom Objects (NOMBOs).
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("MINHSD")]
        [EnumMember]
        MinehuntingSonarDecoy,
		
        /// <summary>
        /// A type of maritime mine actuation.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MULTLM")]
        [EnumMember]
        MultiLookMines,
		
        /// <summary>
        /// A (maritime) mine firing mechanism that does not emit a signal to detect the presence of a target.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("PASIVE")]
        [EnumMember]
        Passive,
		
        /// <summary>
        /// A (maritime) mine firing mechanism with a pressure sensitive circuit which responds to the pressure variation as a result of a ship or sweep.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("PRESUR")]
        [EnumMember]
        Pressure,
		
        /// <summary>
        /// A (maritime) mine firing mechanism that may actuated by a small change in its influence field.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("SENFNT")]
        [EnumMember]
        SensitiveForNormalTarget,
		
        /// <summary>
        /// A (maritime) mine firing mechanism that has a firing circuit which requires actuation by a predetermined sequence of influences of predetermined magnitude.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("SEQUEN")]
        [EnumMember]
        Sequence,
		
        /// <summary>
        /// A (maritime) mine firing mechanism that is fitted with a sensitive firing mechanism that react to a small influences of pressure, acoustic or magnetic (for magnetic values of less than 200 nanotesla are sufficient.)
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("VERSEN")]
        [EnumMember]
        VerySensitiveAntiSweeper,
		
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
