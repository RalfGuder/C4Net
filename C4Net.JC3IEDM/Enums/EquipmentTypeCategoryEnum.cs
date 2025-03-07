using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of EQUIPMENT-TYPE.
    /// </summary>
    [DomId(100000334)]
    [DataContract]
    public enum EquipmentTypeCategoryEnum
    {
		
        /// <summary>
        /// An EQUIPMENT-TYPE that is designed to use electronic processing to realise its primary function.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ELCTRN")]
        [EnumMember]
        ElectronicEquipmentType,
		
        /// <summary>
        /// An EQUIPMENT-TYPE that is designed to accomplish engineering functions.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ENGEQ")]
        [EnumMember]
        EngineeringEquipmentType,
		
        /// <summary>
        /// An EQUIPMENT-TYPE of any kind used in warfare or combat to attack and overcome an enemy.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("WEPTYP")]
        [EnumMember]
        WeaponType,
		
        /// <summary>
        /// An EQUIPMENT-TYPE whose designed function does not fit in any other defined category.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MISCEQ")]
        [EnumMember]
        MiscellaneousEquipmentType,
		
        /// <summary>
        /// An EQUIPMENT-TYPE that is designed for specialised roles in detecting, decontaminating or reconnoitring NBC (CBRN) materiel.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CBRNEQ")]
        [EnumMember]
        CbrnEquipmentType,
		
        /// <summary>
        /// An EQUIPMENT-TYPE that is designed to operate on rail tracks.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("RAIL")]
        [EnumMember]
        RailcarType,
		
        /// <summary>
        /// An EQUIPMENT-TYPE that is designed to operate on land routes (other than rail) with a primary role of transporting personnel, equipment or supplies.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("VEHCLE")]
        [EnumMember]
        VehicleType,
		
        /// <summary>
        /// An EQUIPMENT-TYPE that is designed to operate on or under the water surface.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("VESSEL")]
        [EnumMember]
        VesselType,
		
        /// <summary>
        /// An EQUIPMENT-TYPE that is designed to be used in a maritime environment.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("MRTMEQ")]
        [EnumMember]
        MaritimeEquipmentType,
		
        /// <summary>
        /// An EQUIPMENT-TYPE that is designed to fly.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIRCFT")]
        [EnumMember]
        AircraftType,
		
    }
}
