using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of SUPPORT-CAPABILITY.
    /// </summary>
    [DomId(100004350)]
    [DataContract]
    public enum SupportCapabilityCategoryEnum
    {
		
        /// <summary>
        /// The capability to provide bedding.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BEDDNG")]
        [EnumMember]
        Bedding,
		
        /// <summary>
        /// The capability to provide air at more than atmospheric pressure - often used to power mechanical devices or to provide a portable supply of oxygen.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CMPAIR")]
        [EnumMember]
        CompressedAir,
		
        /// <summary>
        /// The capability to provide deck supplies.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DECK")]
        [EnumMember]
        Deck,
		
        /// <summary>
        /// The capability to provide education services.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("EDUCTN")]
        [EnumMember]
        Education,
		
        /// <summary>
        /// The capability to provide electrical power.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ELECTR")]
        [EnumMember]
        Electrical,
		
        /// <summary>
        /// The capability to provide engine supplies.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ENGINE")]
        [EnumMember]
        Engine,
		
        /// <summary>
        /// The capability to provide food.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("FODRAT")]
        [EnumMember]
        FoodRations,
		
        /// <summary>
        /// The capability to provide fuel for heating.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("FUELHE")]
        [EnumMember]
        FuelHeating,
		
        /// <summary>
        /// The capability to provide health care services.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("HLTHCR")]
        [EnumMember]
        Healthcare,
		
        /// <summary>
        /// The capability to provide a surface for helicopter take off and landing.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("HELPLT")]
        [EnumMember]
        HelicopterPlatform,
		
        /// <summary>
        /// The capability to provide infrastructure support.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("INFSTR")]
        [EnumMember]
        InfrastructureSupport,
		
        /// <summary>
        /// The capability to provide laundry services.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("LUNDRY")]
        [EnumMember]
        Laundry,
		
        /// <summary>
        /// The capability to treat people for illnesses and injuries.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MEDCAL")]
        [EnumMember]
        Medical,
		
        /// <summary>
        /// The capability to provide medicine.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MEDSPL")]
        [EnumMember]
        MedicalSupplies,
		
        /// <summary>
        /// The capability to provide a place providing meals and recreational facilities.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("MESSNG")]
        [EnumMember]
        Messing,
		
        /// <summary>
        /// The capability to provide clothing.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("PERSEQ")]
        [EnumMember]
        PersonalEquipment,
		
        /// <summary>
        /// The capability to provide recreation services.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("RECRTN")]
        [EnumMember]
        Recreation,
		
        /// <summary>
        /// The capability to provide security services.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("SECRTY")]
        [EnumMember]
        Security,
		
        /// <summary>
        /// The capability to provide sewage and refuse disposal.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("SEWAGE")]
        [EnumMember]
        Sewage,
		
        /// <summary>
        /// The capability to provide shelter.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SHLTER")]
        [EnumMember]
        Shelter,
		
        /// <summary>
        /// The capability to provide combat/fresh rations, water and personal, health and welfare items.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("SPLC1")]
        [EnumMember]
        SupplyClassI,
		
        /// <summary>
        /// The capability to provide materiel (supplies for which allowances are established by tables of organisation and equipment).
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("SPLC2")]
        [EnumMember]
        SupplyClassIi,
		
        /// <summary>
        /// The capability to provide aviation fuel and lubricants.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("SPLC3A")]
        [EnumMember]
        SupplyClassIiiAviation,
		
        /// <summary>
        /// The capability to provide fuel and lubricants.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("SPLC3")]
        [EnumMember]
        SupplyClassIii,
		
        /// <summary>
        /// The capability to provide construction materials (supplies for which initial issue allowances are not prescribed by approved issue tables).
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("SPLC4")]
        [EnumMember]
        SupplyClassIv,
		
        /// <summary>
        /// The capability to provide ammunition, explosives and chemical agents.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("SPLC5")]
        [EnumMember]
        SupplyClassV,
		
        /// <summary>
        /// The capability to provide potable water.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("WATER")]
        [EnumMember]
        Water,
		
    }
}
