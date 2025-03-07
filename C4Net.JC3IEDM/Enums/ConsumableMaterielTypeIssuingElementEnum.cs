using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a standard unit in which a specific CONSUMABLE-MATERIEL-TYPE is made available.
    /// </summary>
    [DomId(100000132)]
    [DataContract]
    public enum ConsumableMaterielTypeIssuingElementEnum
    {
		
        /// <summary>
        /// Issued en masse (usually applies to liquids).
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BLK")]
        [EnumMember]
        Bulk,
		
        /// <summary>
        /// Issued in drums, the size of which is recorded in the issuing-unit-of-measure-code (usually applies to liquids) (e.g., 200-litre drums).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DRM")]
        [EnumMember]
        Drum,
		
        /// <summary>
        /// Issuing unit of measure is packs, the size of which is recorded in the issuing-unit-of-measure-code and issuing-quantity.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PAK")]
        [EnumMember]
        Pack,
		
        /// <summary>
        /// Issued in units of standard NATO pallets.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PAL")]
        [EnumMember]
        Pallet,
		
        /// <summary>
        /// Issued singly.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("UNT")]
        [EnumMember]
        Unit,
		
        /// <summary>
        /// A large bound, often wrapped package of materiel.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("BALE")]
        [EnumMember]
        Bale,
		
        /// <summary>
        /// A large cylindrical container having a flat top and bottom of equal diameter.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("BARREL")]
        [EnumMember]
        Barrel,
		
        /// <summary>
        /// A rectangular container usually having a lid or cover.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("BOX")]
        [EnumMember]
        Box,
		
        /// <summary>
        /// A container.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("CASE")]
        [EnumMember]
        Case,
		
        /// <summary>
        /// A series of connected spirals or concentric rings.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("COIL")]
        [EnumMember]
        Coil,
		
        /// <summary>
        /// A receptacle for holding or carrying material.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("CONTNR")]
        [EnumMember]
        Container,
		
        /// <summary>
        /// A container, as a slatted wooden case.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("CRATE")]
        [EnumMember]
        Crate,
		
        /// <summary>
        /// A container that holds 20 litres.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("JERCAN")]
        [EnumMember]
        Jerrican,
		
        /// <summary>
        /// A fixed portion.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("RATION")]
        [EnumMember]
        Ration,
		
        /// <summary>
        /// A single item of ammunition.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("ROUND")]
        [EnumMember]
        Round,
		
        /// <summary>
        /// A Day of supply (at combat rate) is the amount of consumable materiel required to enable a formation (unit i.e. Division, Brigade etc) to carry out operations for 1 day.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("DAYSPL")]
        [EnumMember]
        DayOfSupply,
		
    }
}
