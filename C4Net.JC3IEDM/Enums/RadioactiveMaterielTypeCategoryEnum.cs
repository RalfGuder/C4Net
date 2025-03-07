using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of RADIOACTIVE-MATERIEL-TYPE.
    /// </summary>
    [DomId(100000364)]
    [DataContract]
    public enum RadioactiveMaterielTypeCategoryEnum
    {
		
        /// <summary>
        /// A radioactive isotope of the chemical element of atomic number 55, a soft, silvery, rare, extremely reactive metal of the alkali metal group.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CESIUM")]
        [EnumMember]
        Cesium137,
		
        /// <summary>
        /// A radioactive isotope of the chemical element of atomic number 27, a hard silvery-white magnetic metal.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("COBALT")]
        [EnumMember]
        Cobalt60,
		
        /// <summary>
        /// Nuclear reactor fuel that has not yet been used in a live nuclear reactor.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FRFUEL")]
        [EnumMember]
        FreshReactorFuel,
		
        /// <summary>
        /// A radioactive isotope of the chemical element of atomic number 53, a halogen forming black crystals and a violet vapour.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("IODINE")]
        [EnumMember]
        Iodine133,
		
        /// <summary>
        /// Radioactive residues originating in a nuclear explosion.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NUCFLT")]
        [EnumMember]
        NuclearWeaponFallout,
		
        /// <summary>
        /// An intended or non-intended release of nuclear radiation from a non-militarily significant source or weapon.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NROTA")]
        [EnumMember]
        NuclearReleaseOtherThanAttackRota,
		
        /// <summary>
        /// A radioactive isotope of the chemical element of atomic number 94, a dense silvery radioactive metal of the actinide series, used as a fuel in nuclear reactors and as an explosive in nuclear fission weapons.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PLTNUM")]
        [EnumMember]
        Plutonium239,
		
        /// <summary>
        /// Nuclear reactor fuel that has been used in a live nuclear reactor.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SPFUEL")]
        [EnumMember]
        SpentReactorFuel,
		
        /// <summary>
        /// A generic term for radioactive compounds in solid, liquid, aerosolised or gaseous form. These may be used, or stored for use, for industrial, commercial, medical, military or domestic purposes.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("TOXMAT")]
        [EnumMember]
        ToxicIndustrialMaterial,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
