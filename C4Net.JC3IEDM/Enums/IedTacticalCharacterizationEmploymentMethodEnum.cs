using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that describes how the device is delivered or attached to the target.
    /// </summary>
    [DomId(100004423)]
    [DataContract]
    public enum IedTacticalCharacterizationEmploymentMethodEnum
    {
		
        /// <summary>
        /// An IED held aloft by aerodynamic means or buoyancy that serves as concealment means for explosives with an initiating device.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ABIED")]
        [EnumMember]
        AirBorne,
		
        /// <summary>
        /// An IED worn by an animal where the whole IED or principal IED components are placed on the animal and also serves as the delivery or concealment means for explosives with an initiating device.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ANIED")]
        [EnumMember]
        AnimalBorne,
		
        /// <summary>
        /// An IED built into any large ground-based vehicle (e.g., dump truck, panel truck, bongo truck, commercial bus, tanker, etc.) that serves as the concealment means for explosives with an initiating device.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LVBIED")]
        [EnumMember]
        LargeVehicleBorne,
		
        /// <summary>
        /// A type of IED employment in which the device is attached to the target using magnets.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("TACHMG")]
        [EnumMember]
        MagneticAttachment,
		
        /// <summary>
        /// A type of IED employment in which the device is attached to the target using non-magnetic means.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("TACHNM")]
        [EnumMember]
        NonMagneticAttachment,
		
        /// <summary>
        /// An IED worn by a person where the whole IED or principal IED components are placed in a vest, belt, backpack, etc, and also serves as the delivery or concealment means for explosives with an initiating device.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PBIED")]
        [EnumMember]
        PersonBorne,
		
        /// <summary>
        /// An IED introduced or delivered through a postal or package delivery system.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("POSTAL")]
        [EnumMember]
        PostalPackageDelivery,
		
        /// <summary>
        /// An IED delivered by an improvised weapons system that delivers the main charge through the air to its target.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("PROJD")]
        [EnumMember]
        Projected,
		
        /// <summary>
        /// A type of IED employment in which the device targets the underside of a vehicle, using large amounts of explosives buried to deliberately defeat armour (can include conventional land mines).
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("UBELLY")]
        [EnumMember]
        Underbelly,
		
        /// <summary>
        /// An IED delivered by any small ground-based vehicle (e.g., passenger vehicle, motorcycle, moped, bicycle, etc.) that serves as the concealment means for explosives with an Initiating device.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("VBIED")]
        [EnumMember]
        VehicleBorne,
		
        /// <summary>
        /// An IED delivered by any vessel that serves as the concealment means for explosives with an Initiating device.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("VSBIED")]
        [EnumMember]
        VesselBorne,
		
        /// <summary>
        /// An IED delivered by floating, drifting, anchored, or propelled on or below the water that serves as the concealment means for explosives with an initiating device.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("WBIED")]
        [EnumMember]
        WaterBorne,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
