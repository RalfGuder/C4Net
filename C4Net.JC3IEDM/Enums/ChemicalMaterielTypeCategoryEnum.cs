using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the general class of a specific CHEMICAL-MATERIEL-TYPE.
    /// </summary>
    [DomId(100000354)]
    [DataContract]
    public enum ChemicalMaterielTypeCategoryEnum
    {
		
        /// <summary>
        /// A CHEMICAL-MATERIEL-TYPE that injures the eyes and lungs, and burns or blisters the skin. Also called "vesicant agent".
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BLISTR")]
        [EnumMember]
        BlisterAgent,
		
        /// <summary>
        /// A CHEMICAL-MATERIEL-TYPE, including the cyanide group, that affects bodily functions by preventing the normal transfer of oxygen from the blood to body tissues. Also called "cyanogen agent".
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BLOOD")]
        [EnumMember]
        BloodAgent,
		
        /// <summary>
        /// A CHEMICAL-MATERIEL-TYPE that affects the human breathing function.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CHKNG")]
        [EnumMember]
        ChokingAgent,
		
        /// <summary>
        /// A CHEMICAL-MATERIEL-TYPE that prevents a human from functioning in a normal way.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("INCPCT")]
        [EnumMember]
        IncapacitatingAgent,
		
        /// <summary>
        /// A CHEMICAL-MATERIEL-TYPE that is designed to irritate the eyes, lungs and skin.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("IRRTNT")]
        [EnumMember]
        Irritant,
		
        /// <summary>
        /// A potentially lethal CHEMICAL-MATERIEL-TYPE, which is a colourless oily liquid whose vapour is a powerful irritant and vesicant, used in chemical weapons.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MUSTRD")]
        [EnumMember]
        MustardAgent,
		
        /// <summary>
        /// A potentially lethal CHEMICAL-MATERIEL-TYPE that interferes with the transmission of nerve impulses.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NERVE")]
        [EnumMember]
        NerveAgent,
		
        /// <summary>
        /// A CHEMICAL-MATERIEL-TYPE that is designed to penetrate the individual and collective equipment, therefore enabling an associated lethal agent to act.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("PNTRNG")]
        [EnumMember]
        PenetratingAgent,
		
        /// <summary>
        /// A generic term for a CHEMICAL-MATERIEL-TYPE compound found in solid, liquid, aerosolised or gaseous form. It may be used, or stored for use, for industrial, commercial, medical, military or domestic purposes.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("TOXMAT")]
        [EnumMember]
        ToxicIndustrialMaterial,
		
        /// <summary>
        /// A generic term for a CHEMICAL-MATERIEL-TYPE for a class of nerve agents.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("VAGENT")]
        [EnumMember]
        VAgent,
		
        /// <summary>
        /// A CHEMICAL-MATERIEL-TYPE that is designed to incapacitate by inducing vomiting in humans.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("VOMTNG")]
        [EnumMember]
        VomitingAgent,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The types of organophosphorus nerve gases.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("GAGENT")]
        [EnumMember]
        GAgent,
		
    }
}
