using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of BIOLOGICAL-MATERIEL-TYPE.
    /// </summary>
    [DomId(100000351)]
    [DataContract]
    public enum BiologicalMaterielTypeCategoryEnum
    {
		
        /// <summary>
        /// A generic term for a BIOLOGICAL-MATERIEL-TYPE, member of a large group of unicellular micro-organisms (prokaryotes) that have cell walls but lack an organised nucleus and other structures, and include numerous disease causing forms.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BACTRL")]
        [EnumMember]
        Bacterial,
		
        /// <summary>
        /// A generic term for a BIOLOGICAL-MATERIEL-TYPE compound in solid, liquid, aerosolised or gaseous form. It may be used, or stored for use, for industrial, commercial, medical, military or domestic purposes.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("TOXMAT")]
        [EnumMember]
        ToxicIndustrialMaterial,
		
        /// <summary>
        /// A generic term for a BIOLOGICAL-MATERIEL-TYPE that is a micro-organism product that causes disease in man, plants or animals or causes the deterioration of materiel.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TOXIN")]
        [EnumMember]
        Toxin,
		
        /// <summary>
        /// A generic term for a BIOLOGICAL-MATERIEL-TYPE of the nature of a virus; submicroscopic infective particle, typically consisting of nucleic acid coated in protein, which is able to multiply within the cells of a host organism.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("VIRAL")]
        [EnumMember]
        Viral,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
