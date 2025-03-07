using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the most intense radiation emitted by a RADIOACTIVE-MATERIEL-TYPE.
    /// </summary>
    [DomId(100000365)]
    [DataContract]
    public enum RadioactiveMaterielTypePrimaryRadiationEnum
    {
		
        /// <summary>
        /// Ionising radiation consisting of alpha particles (a helium nucleus), emitted by some substances undergoing radioactive decay.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ALPHA")]
        [EnumMember]
        AlphaRadiation,
		
        /// <summary>
        /// Radioactive decay in which an electron is emitted.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BETA")]
        [EnumMember]
        BetaRadiation,
		
        /// <summary>
        /// Penetrating electromagnetic radiation of shorter wavelength than X-rays.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("GAMMA")]
        [EnumMember]
        GammaRadiation,
		
        /// <summary>
        /// Subatomic particle of about the same mass as a proton but without an electric charge, present in all atomic nuclei except those of ordinary hydrogen emitted during nuclear decay.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NEUTRN")]
        [EnumMember]
        Neutron,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
