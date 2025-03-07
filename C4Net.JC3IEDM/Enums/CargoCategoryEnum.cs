using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of cargo that is subject to a HANDLING-CAPABILITY or a STORAGE-CAPABILITY.
    /// </summary>
    [DomId(100004345)]
    [DataContract]
    public enum CargoCategoryEnum
    {
		
        /// <summary>
        /// The specific cargo consists of aircraft.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACFT")]
        [EnumMember]
        Aircraft,
		
        /// <summary>
        /// The specific cargo consists of agricultural products.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AGP")]
        [EnumMember]
        AgriculturalProducts,
		
        /// <summary>
        /// The specific cargo consists of ammunition.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AMMO")]
        [EnumMember]
        Ammunition,
		
        /// <summary>
        /// The specific cargo consists of arms, ammunition and explosives.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ARAMEX")]
        [EnumMember]
        ArmsAmmunitionAndExplosives,
		
        /// <summary>
        /// The specific cargo consists of boats.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BOATS")]
        [EnumMember]
        Boats,
		
        /// <summary>
        /// The specific cargo consists of bulk.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("BULK")]
        [EnumMember]
        BulkCargo,
		
        /// <summary>
        /// The specific cargo consists of chemical products.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CHE")]
        [EnumMember]
        Chemicals,
		
        /// <summary>
        /// The specific cargo consists of classified or protected cargo.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("CLASS")]
        [EnumMember]
        ClassifiedOrProtectedCargo,
		
        /// <summary>
        /// The specific cargo consists of coal.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("COL")]
        [EnumMember]
        Coal,
		
        /// <summary>
        /// The specific cargo consists of construction materials.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CON")]
        [EnumMember]
        ConstructionMaterials,
		
        /// <summary>
        /// The specific cargo consists of containers.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("CTR")]
        [EnumMember]
        Containers,
		
        /// <summary>
        /// The specific cargo consists of dry cargo.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("DRY")]
        [EnumMember]
        DryCargo,
		
        /// <summary>
        /// The specific cargo consists of forestry products.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("FOP")]
        [EnumMember]
        ForestryProducts,
		
        /// <summary>
        /// The specific cargo consists of general cargo.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("GEN")]
        [EnumMember]
        GeneralCargo,
		
        /// <summary>
        /// The specific cargo consists of general cargo composed of hazardous material.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("HAZMAT")]
        [EnumMember]
        HazardousMaterial,
		
        /// <summary>
        /// The specific cargo consists of heavy equipment.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("HYEQPT")]
        [EnumMember]
        HeavyEquipment,
		
        /// <summary>
        /// The specific cargo consists of liquid cargo.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("LIQUID")]
        [EnumMember]
        LiquidCargo,
		
        /// <summary>
        /// The specific cargo consists of military associated cargo.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MAC")]
        [EnumMember]
        MilitaryAssociatedCargo,
		
        /// <summary>
        /// The specific cargo consists of mail.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("MAIL")]
        [EnumMember]
        Mail,
		
        /// <summary>
        /// The specific cargo consists of material.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("MAT")]
        [EnumMember]
        Material,
		
        /// <summary>
        /// The specific cargo consists of material and equipment.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("MCH")]
        [EnumMember]
        MaterialAndEquipment,
		
        /// <summary>
        /// The specific cargo consists of medical supplies.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("MED")]
        [EnumMember]
        MedicalSupplies,
		
        /// <summary>
        /// The specific cargo consists of minerals/metals.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("MIM")]
        [EnumMember]
        MineralsMetals,
		
        /// <summary>
        /// The specific cargo consists of other cargo.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("OTR")]
        [EnumMember]
        Other,
		
        /// <summary>
        /// The specific cargo consists of passengers.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("PAX")]
        [EnumMember]
        Passengers,
		
        /// <summary>
        /// The specific cargo consists of personnel.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("PERS")]
        [EnumMember]
        Personnel,
		
        /// <summary>
        /// The specific cargo consists of petroleum, oils and lubricants.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("POL")]
        [EnumMember]
        PetroleumOilsAndLubricants,
		
        /// <summary>
        /// The specific cargo consists of prisoners of war.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("POW")]
        [EnumMember]
        PrisonersOfWar,
		
        /// <summary>
        /// The specific cargo consists of reefer cargo (chill).
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("CHILL")]
        [EnumMember]
        ReeferCargoChill,
		
        /// <summary>
        /// The specific cargo consists of reefer cargo (freeze).
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("FREEZE")]
        [EnumMember]
        ReeferCargoFreeze,
		
        /// <summary>
        /// The specific cargo consists of special cargo.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("SPECL")]
        [EnumMember]
        SpecialCargo,
		
        /// <summary>
        /// The specific cargo consists of subsistence.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("SUBS")]
        [EnumMember]
        Subsistence,
		
        /// <summary>
        /// The specific cargo consists of sugar.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("SUG")]
        [EnumMember]
        Sugar,
		
        /// <summary>
        /// The specific cargo consists of textiles and textile apparels.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("TEX")]
        [EnumMember]
        TextilesAndTextileApparel,
		
        /// <summary>
        /// The specific cargo consists of troops.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("TROOPS")]
        [EnumMember]
        Troops,
		
        /// <summary>
        /// The specific cargo consists of non-military vehicles.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("VEH")]
        [EnumMember]
        VehicleNonMilitary,
		
        /// <summary>
        /// The specific cargo consists of tracked vehicles.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("VEHT")]
        [EnumMember]
        VehicleTracked,
		
        /// <summary>
        /// The specific cargo consists of wheeled vehicles.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("VEHW")]
        [EnumMember]
        VehicleWheeled,
		
        /// <summary>
        /// The specific cargo consists of wounded persons.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("WOUND")]
        [EnumMember]
        Wounded,
		
    }
}
