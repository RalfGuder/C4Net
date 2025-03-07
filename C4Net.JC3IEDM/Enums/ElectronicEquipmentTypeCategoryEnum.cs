using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ELECTRONIC-EQUIPMENT-TYPE.
    /// </summary>
    [DomId(100000339)]
    [DataContract]
    public enum ElectronicEquipmentTypeCategoryEnum
    {
		
        /// <summary>
        /// Equipment specifically designed to be used for Command, Control, Communications and Intelligence (C3I) support.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("C3I")]
        [EnumMember]
        C3I,
		
        /// <summary>
        /// A group of interrelated communications equipment utilising the electromagnetic spectrum for the transmission and/or receiving of speech and data information.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("COM")]
        [EnumMember]
        Communication,
		
        /// <summary>
        /// Equipment for storing, sharing and manipulation of data.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DPE")]
        [EnumMember]
        DataProcessing,
		
        /// <summary>
        /// An equipment used for military action involving the use of electromagnetic energy to determine, exploit, reduce, or prevent hostile use of the electromagnetic spectrum and action to retain its effective use by friendly forces.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("EW")]
        [EnumMember]
        ElectronicWarfare,
		
        /// <summary>
        /// A group of interrelated fire control equipments and/or instruments designed for use with a weapon or group of weapons.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("FRC")]
        [EnumMember]
        FireControl,
		
        /// <summary>
        /// Any electronic device which provides point-to-point guidance information or position data.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NAV")]
        [EnumMember]
        NavigationalAid,
		
        /// <summary>
        /// A device capable of delivering voice messages.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PAS")]
        [EnumMember]
        PublicAddressSystem,
		
        /// <summary>
        /// A device that detects or measures a physical property and records, indicates, or otherwise responds to it.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SEN")]
        [EnumMember]
        Sensor,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// Radio equipment based on emission of radio waves towards an object and analysis of the waves returned by that object or emitted in response to excitation by the received waves.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("RADAR")]
        [EnumMember]
        Radar,
		
        /// <summary>
        /// An ELECTRONIC-EQUIPMENT-TYPE that provides aircraft with horizontal and vertical guidance just before landing and during landing, and at certain fixed points, indicates the distance to the reference point of landing.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ILS")]
        [EnumMember]
        InstrumentLandingSystem,
		
    }
}
