using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of a specific CHEMICAL-MATERIEL-TYPE.
    /// </summary>
    [DomId(100000355)]
    [DataContract]
    public enum ChemicalMaterielTypeSubcategoryEnum
    {
		
        /// <summary>
        /// A poisonous gas made by the reaction of some arsenic compounds with acids. [AsH3.]
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ARSINE")]
        [EnumMember]
        Arsine,
		
        /// <summary>
        /// A poisonous gas made by the reaction of some chloro compounds with nitrated phenol.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CHLRPC")]
        [EnumMember]
        Chloropicrin,
		
        /// <summary>
        /// A colourless flammable highly poisonous gas made by oxidising hydrogen cyanide. (Blood agent)
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CYNGNC")]
        [EnumMember]
        CyanogenChloride,
		
        /// <summary>
        /// An organophosphorus nerve gas evolved from Sarin.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("CYCLSR")]
        [EnumMember]
        CycloSarin,
		
        /// <summary>
        /// A poisonous gas formerly used in warfare derived from phosgene. [COCl2.]
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("DIPSGN")]
        [EnumMember]
        DiPhosgene,
		
        /// <summary>
        /// A highly poisonous gas or volatile liquid with an odour of bitter almonds, made by the action of acids on cyanides. [HCN.]
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("HDRNCY")]
        [EnumMember]
        HydrogenCyanide,
		
        /// <summary>
        /// A dark oily liquid producing an irritant gas that causes blisters, developed for use in chemical warfare.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("LWSITE")]
        [EnumMember]
        Lewisite,
		
        /// <summary>
        /// A colourless oily liquid, whose vapour is a powerful irritant and vesicant, used in chemical weapons.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MSTRDD")]
        [EnumMember]
        MustardDistilled,
		
        /// <summary>
        /// A mixture of distilled mustard and Lewisite.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("MSTRDL")]
        [EnumMember]
        MustardLewisite,
		
        /// <summary>
        /// A nitrated colourless oily liquid, whose vapour is a powerful irritant and vesicant, used in chemical weapons.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NTRGNM")]
        [EnumMember]
        NitrogenMustard,
		
        /// <summary>
        /// A poisonous gas formerly used in warfare. [COCl2.]
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("PHOSGN")]
        [EnumMember]
        Phosgene,
		
        /// <summary>
        /// A poisonous gas formerly used in warfare derived from phosgene used to block the oxygenation of aemoglobin. [COCl2.] (Blood agent)
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("PHSGNO")]
        [EnumMember]
        PhosgeneOxime,
		
        /// <summary>
        /// A poisonous gas formerly used in warfare.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("QNCLDN")]
        [EnumMember]
        QuinuclidinylBenzilate,
		
        /// <summary>
        /// An organophosphorus nerve gas.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("SARIN")]
        [EnumMember]
        Sarin,
		
        /// <summary>
        /// An organophosphorus nerve gas.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("TABUN")]
        [EnumMember]
        Tabun,
		
        /// <summary>
        /// A type of chemical compound used in riot control agents.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("TRGAS")]
        [EnumMember]
        TearGas,
		
        /// <summary>
        /// A thickened colourless oily liquid, whose vapour is a powerful irritant and vesicant, used in chemical weapons.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("TRMRCM")]
        [EnumMember]
        TrimericMustard,
		
        /// <summary>
        /// An organophosphorus nerve gas.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("VX")]
        [EnumMember]
        Vx,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A colourless liquid use as a nerve gas. Chemically, is fluoromethylpinacolyloxyphosphine oxide.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("SOMAN")]
        [EnumMember]
        Soman,
		
    }
}
