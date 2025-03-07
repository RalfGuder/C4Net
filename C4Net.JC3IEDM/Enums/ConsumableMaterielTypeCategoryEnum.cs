using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CONSUMABLE-MATERIEL-TYPE.
    /// </summary>
    [DomId(100000123)]
    [DataContract]
    public enum ConsumableMaterielTypeCategoryEnum
    {
		
        /// <summary>
        /// Any material that may be used in construction.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CON")]
        [EnumMember]
        ConstructionMaterials,
		
        /// <summary>
        /// Materiel to be used as nourishment in solid or liquid form.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("FOO")]
        [EnumMember]
        Food,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// Petroleum, Oil, and Lubricant - A broad term that includes all petroleum and associated products used by the armed forces.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("POL")]
        [EnumMember]
        Pol,
		
        /// <summary>
        /// A clear, colourless, nearly odourless and tasteless liquid.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("WAT")]
        [EnumMember]
        Water,
		
        /// <summary>
        /// Equipment issued to or carried by an individual.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("PEREQU")]
        [EnumMember]
        PersonalEquipment,
		
        /// <summary>
        /// A CONSUMABLE-MATERIEL-TYPE that is either a microorganism that causes disease in man, plants, or animals or causes the deterioration of materiel; or a toxin, produced by an animal, plant, or microorganism, which may kill, seriously injure, or incapacitate personnel through its physiological effects.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("BIOMAT")]
        [EnumMember]
        BiologicalMaterielType,
		
        /// <summary>
        /// A CONSUMABLE-MATERIEL-TYPE that is a substance that is not produced by a living organism, and does not emit radiation but may kill, seriously injure, or incapacitate personnel through its physiological effects or cause the deterioration of materiel.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("CHMMAT")]
        [EnumMember]
        ChemicalMaterielType,
		
        /// <summary>
        /// A CONSUMABLE-MATERIEL-TYPE that is a substance which spontaneously emits radiation, and which may kill, seriously injure, or incapacitate personnel through its physiological effects or causes the deterioration of materiel.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("RADMAT")]
        [EnumMember]
        RadioactiveMaterielType,
		
        /// <summary>
        /// All disposable materiel and items used in the equipment, support and maintenance of military forces or civilians.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("GENSPL")]
        [EnumMember]
        GeneralSupplies,
		
        /// <summary>
        /// A substance burned to create energy.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("FUEL")]
        [EnumMember]
        Fuel,
		
        /// <summary>
        /// A device placed or fabricated in an improvised manner incorporating destructive, lethal, noxious, pyrotechnic or incendiary chemicals and designed to destroy, incapacitate, harass or distract.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("IMEXDE")]
        [EnumMember]
        ImprovisedExplosiveDevice,
		
        /// <summary>
        /// A device that initiates an explosive train.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("FUSE")]
        [EnumMember]
        Fuse,
		
        /// <summary>
        /// A generic term covering materiel used as replacement parts.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SPRPRT")]
        [EnumMember]
        SpareParts,
		
        /// <summary>
        /// Cultivated agricultural plants, as grain, vegetables or fruit.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("CROPS")]
        [EnumMember]
        Crops,
		
        /// <summary>
        /// The official currency, coins and negotiable paper notes issued by a government.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("MONEY")]
        [EnumMember]
        Money,
		
        /// <summary>
        /// A CONSUMABLE-MATERIEL-TYPE that is a complete device charged with explosives, propellants, pyrotechnics, initiating composition, or nuclear, biological, or chemical material for use in military operations.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("AMMO")]
        [EnumMember]
        AmmunitionType,
		
        /// <summary>
        /// Supplies for the treatment of injuries, illness and disease, including drugs.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("MEDSPL")]
        [EnumMember]
        MedicalSupply,
		
        /// <summary>
        /// A narcotic, hallucinogen, or stimulant, esp. one causing addiction.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("DRUG")]
        [EnumMember]
        Drug,
		
        /// <summary>
        /// A pyrotechnic munition producing a bright light for illumination or identification.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("FLARE")]
        [EnumMember]
        Flare,
		
        /// <summary>
        /// A piece of paper that is a graphic representation of a part or the whole of the earth.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("MAP")]
        [EnumMember]
        Map,
		
        /// <summary>
        /// In naval mine warfare, a mine suitable for use in mine warfare exercises, fitted with visible or audible indicating devices to show where and when it would normally fire.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("MAMNEX")]
        [EnumMember]
        ExerciseMine,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
